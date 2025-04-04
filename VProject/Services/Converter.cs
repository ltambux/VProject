namespace VProject.Services;

public static class Converter{
    public static double CmToInch(this double cm)=>cm/2.54;
    public static double CmToMeters(this double cm)=>cm/100;
    public static double InchToCm(this double inch)=>inch*2.54;

    public static double KmhToMs(this double kmh)=>kmh/3.6;
    public static double MsToKmh(this double ms)=>ms*3.6;

    public static double HpToKW(this double hp)=>hp/1.36;
    public static double KWToHp(this double kw)=>kw*1.36;

    public static double Percent(this double value,double perc)=>value*perc/100;
}