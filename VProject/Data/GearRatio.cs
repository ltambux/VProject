using Newtonsoft.Json;

namespace VProject.Data;

public class GearRatio{
    public double Rear {get;set;}
    public double First {get;set;}
    public double Second {get;set;}
    public double Third {get;set;}
    public double Fourth {get;set;}
    public double Fifth {get;set;}
    public double Sixth {get;set;}
    public double FinalDrive {get;private set;}

    public GearRatio(){}
    [JsonConstructor]
    public GearRatio(double first,double second,double third,double fourth,double fifth,double sixth,
            double rear,double final){
        First=first;
        Second=second;
        Third=third;
        Fourth=fourth;
        Fifth=fifth;
        Sixth=sixth;
        Rear=rear;
        FinalDrive=final;
    }
    public static string[] GetGears()=>["First","Second","Third","Fourth","Fifth","Sixth","Rear"];
    public static Gear GetGears(string g) => g switch{
        "First"=>Gear.First,
        "Second"=>Gear.Second,
        "Third"=>Gear.Third,
        "Fourth"=>Gear.Fourth,
        "Fifth"=>Gear.Fifth,
        "Sixth"=>Gear.Sixth,
        "Rear"=>Gear.Rear,
        _=>Gear.UNDEFINED
    };
}
public enum Gear{
    UNDEFINED=-1,
    First,
    Second,
    Third,
    Fourth,
    Fifth,
    Sixth,
    Rear
}