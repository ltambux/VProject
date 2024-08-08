using System;

namespace VProject.Data;

public class Wheel{
    /// <summary> Rim of the wheel [Inch] </summary>
    public WheelDiam R;
    /// <summary> Width of the wheel [mm] </summary>
    public WheelWidth Width;
    /// <summary> value of the width(mm) of the wheel </summary>
    public int TirePercent;

    public Wheel(WheelDiam r,WheelWidth w,int perc){
        R=r;
        Width=w;
        TirePercent=perc;
    }

    /// <summary> Diameter of rim + tire [cm] </summary>
    public double TotalDiameter()=>R.ToMeasure() + Width.Percentage(TirePercent)*0.02;
    /// <summary> single revolution space [m] </summary>
    public double SingleRevolution()=>TotalDiameter()*Math.PI;
    public double RPMs(){
        return-1;
    }
}

public enum WheelDiam{
    R15,R16,R17,R18
}
public enum WheelWidth{
    mm185,mm195,mm205,mm215,mm225,mm235,mm245,mm255
}
public enum TirePercentage{
    p35,p45,p55,p65
}
public static class WheelExtension{
    public static double ToMeasure(this WheelDiam r)=>r switch{
        WheelDiam.R15=>Converter.InchToCm(15),
        WheelDiam.R16=>Converter.InchToCm(16),
        WheelDiam.R17=>Converter.InchToCm(17),
        WheelDiam.R18=>Converter.InchToCm(18),
        _=>-1
    };
    public static string[] WheelDiameters()=>[WheelDiam.R15.ToString(),WheelDiam.R16.ToString(),WheelDiam.R17.ToString(),WheelDiam.R18.ToString()];
    public static double Percentage(this WheelWidth w,int perc)=>w switch{
        WheelWidth.mm185=>185*Converter.Percent(perc),
        WheelWidth.mm195=>195*Converter.Percent(perc),
        WheelWidth.mm205=>205*Converter.Percent(perc),
        WheelWidth.mm215=>215*Converter.Percent(perc),
        WheelWidth.mm225=>225*Converter.Percent(perc),
        WheelWidth.mm235=>235*Converter.Percent(perc),
        WheelWidth.mm245=>245*Converter.Percent(perc),
        WheelWidth.mm255=>255*Converter.Percent(perc),
        _=>-1
    };

    public static string[] TiresPercs()=>["35","45","55","65"];
    public static string[] WheelWidths()=>[WheelWidth.mm185.AsString(),WheelWidth.mm195.AsString(),
        WheelWidth.mm205.AsString(),WheelWidth.mm215.AsString(),WheelWidth.mm225.AsString(),WheelWidth.mm255.AsString()];

    public static string AsString(this WheelWidth w)=>w.ToString().TrimStart('m');
    public static string AsString(this TirePercentage p)=>p.ToString().TrimStart('p');
}