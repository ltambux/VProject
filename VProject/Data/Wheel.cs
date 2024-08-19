using System;

namespace VProject.Data;

public class Wheel{
    /// <summary> Rim of the wheel [Inch] </summary>
    public WheelDiam R {get;set;}
    /// <summary> Width of the wheel [mm] </summary>
    public WheelWidth Width {get;set;}
    /// <summary> value of the width (mm) of the wheel </summary>
    public TirePercentage TirePercent {get;set;}
    /// <summary> value of the thickness (mm) of the wheel </summary>
    public double TireThickness => Width.Percentage(TirePercent);

    public Wheel(WheelDiam r,WheelWidth w,TirePercentage t){
        R=r;
        Width=w;
        TirePercent=t;
    }

    /// <summary> Diameter of rim + tire [cm] </summary>
    public double TotalDiameter()=>R.ToMeasure() + TireThickness*0.2;
    /// <summary> single revolution space [m] </summary>
    public double SingleRevolution()=>TotalDiameter()*100*Math.PI;
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
    UNDEFINED=-1,p25,p35,p45,p50,p55,p60,p65
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
        "R16"=>WheelDiam.R16,
        "R17"=>WheelDiam.R17,
        "R18"=>WheelDiam.R18,
        "R19"=>WheelDiam.R19,
        "R20"=>WheelDiam.R20,
        "R21"=>WheelDiam.R21,
        _=>WheelDiam.UNDEFINED
    };
    public static WheelWidth WheelWidthFromString(string w)=>w switch{
        "185"=>WheelWidth.mm185,
        "195"=>WheelWidth.mm195,
        "205"=>WheelWidth.mm205,
        "215"=>WheelWidth.mm215,
        "225"=>WheelWidth.mm225,
        "235"=>WheelWidth.mm235,
        "245"=>WheelWidth.mm245,
        "255"=>WheelWidth.mm255,
        _=>Data.WheelWidth.UNDEFINED
    };
    public static TirePercentage WheelTirePercentage(string w)=>w switch{
        "25"=>TirePercentage.p25,
        "35"=>TirePercentage.p35,
        "45"=>TirePercentage.p45,
        "50"=>TirePercentage.p50,
        "55"=>TirePercentage.p55,
        "60"=>TirePercentage.p60,
        "65"=>TirePercentage.p65,
        _=>TirePercentage.UNDEFINED
    };
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

    public static string[] WheelDiameters()=>[WheelDiam.R15.ToString(),WheelDiam.R16.ToString(),WheelDiam.R17.ToString(),
        WheelDiam.R18.ToString(),WheelDiam.R19.ToString(),WheelDiam.R20.ToString(),WheelDiam.R21.ToString()];
    public static string[] TiresPercs()=>[TirePercentage.p25.AsString(),TirePercentage.p35.AsString(),
        TirePercentage.p45.AsString(),TirePercentage.p50.AsString(),TirePercentage.p55.AsString(),
        TirePercentage.p60.AsString(),TirePercentage.p65.AsString()];
    public static string[] WheelWidths()=>[WheelWidth.mm185.AsString(),WheelWidth.mm195.AsString(),
        WheelWidth.mm205.AsString(),WheelWidth.mm215.AsString(),WheelWidth.mm225.AsString(),
        WheelWidth.mm235.AsString(),WheelWidth.mm245.AsString(),WheelWidth.mm255.AsString()];

    public static string AsString(this WheelWidth w)=>w.ToString().TrimStart('m');
    public static int ToInt(this WheelWidth p)=>int.Parse(p.AsString());
    public static string AsString(this TirePercentage p)=>p.ToString().TrimStart('p');
    public static int ToInt(this TirePercentage p)=>int.Parse(p.AsString());
}