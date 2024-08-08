using System;

namespace VProject.Data;

public class Wheel{
    /// <summary> Rim of the wheel [Inch] </summary>
    public WheelDiam R {get;set;}
    /// <summary> Width of the wheel [mm] </summary>
    public WheelWidth Width {get;set;}
    /// <summary> value of the width(mm) of the wheel </summary>
    public TirePercentage TirePercent {get;set;}
    public double TireThickness => Width.Percentage(TirePercent);

    public Wheel(WheelDiam r,WheelWidth w,TirePercentage t){
        R=r;
        Width=w;
        TirePercent=t;
    }

    /// <summary> Diameter of rim + tire [cm] </summary>
    public double TotalDiameter()=>R.ToMeasure() + TireThickness*2;
    /// <summary> single revolution space [m] </summary>
    public double SingleRevolution()=>TotalDiameter()*Math.PI;
    public double RPMs(double ms) {
        double rev=SingleRevolution();
        return (ms*60)/rev;
    }
}

public enum WheelDiam{
    UNDEFINED=-1,R15,R16,R17,R18,R19,R20,R21
}
public enum WheelWidth{
    UNDEFINED=-1,mm185,mm195,mm205,mm215,mm225,mm235,mm245,mm255
}
public enum TirePercentage{
    UNDEFINED=-1,p25,p35,p45,p55,p65
}
public static class WheelExtension{
    public static double ToMeasure(this WheelDiam r)=>r switch{
        WheelDiam.R15=>Converter.InchToCm(15),
        WheelDiam.R16=>Converter.InchToCm(16),
        WheelDiam.R17=>Converter.InchToCm(17),
        WheelDiam.R18=>Converter.InchToCm(18),
        WheelDiam.R19=>Converter.InchToCm(19),
        WheelDiam.R20=>Converter.InchToCm(20),
        WheelDiam.R21=>Converter.InchToCm(21),
        _=>-1
    };
    public static WheelDiam WheelDiameter(string w)=>w switch{
        "R15"=>WheelDiam.R15,
        "R16"=>WheelDiam.R15,
        "R17"=>WheelDiam.R15,
        "R18"=>WheelDiam.R15,
        _=>WheelDiam.UNDEFINED
    };
    public static string[] WheelDiameters()=>[WheelDiam.R15.ToString(),WheelDiam.R16.ToString(),WheelDiam.R17.ToString(),WheelDiam.R18.ToString()];
    public static double Percentage(this WheelWidth w,TirePercentage tire)=>w switch{
        WheelWidth.mm185=>Converter.Percent(185,tire.ToInt()),
        WheelWidth.mm195=>Converter.Percent(195,tire.ToInt()),
        WheelWidth.mm205=>Converter.Percent(205,tire.ToInt()),
        WheelWidth.mm215=>Converter.Percent(215,tire.ToInt()),
        WheelWidth.mm225=>Converter.Percent(225,tire.ToInt()),
        WheelWidth.mm235=>Converter.Percent(235,tire.ToInt()),
        WheelWidth.mm245=>Converter.Percent(245,tire.ToInt()),
        WheelWidth.mm255=>Converter.Percent(255,tire.ToInt()),
        _=>-1
    };

    public static string[] TiresPercs()=>[TirePercentage.p25.AsString(),TirePercentage.p35.AsString(),
        TirePercentage.p45.AsString(),TirePercentage.p55.AsString(),TirePercentage.p65.AsString()];
    public static string[] WheelWidths()=>[WheelWidth.mm185.AsString(),WheelWidth.mm195.AsString(),
        WheelWidth.mm205.AsString(),WheelWidth.mm215.AsString(),WheelWidth.mm225.AsString(),
        WheelWidth.mm235.AsString(),WheelWidth.mm245.AsString(),WheelWidth.mm255.AsString()];

    public static string AsString(this WheelWidth w)=>w.ToString().TrimStart('m');
    public static string AsString(this TirePercentage p)=>p.ToString().TrimStart('p');
    public static int ToInt(this TirePercentage p)=>int.Parse(p.ToString().TrimStart('p'));
}