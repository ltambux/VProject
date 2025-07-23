using Newtonsoft.Json;

namespace VProject.Data;

public class FuelEfficiency{
    public FuelType FType {get;set;}
    public int Capacity {get;set;} // L of tank
    public double Min {get;set;}
    public double Max {get;set;}

    [JsonConstructor]
    public FuelEfficiency(string fType,int capacity,double min,double max){
        FType=FuelTypeMethods.FromString(fType);
        Capacity=capacity;
        Min=min;
        Max=max;
    }
}

public enum FuelType{
    UNDEFINED=-1,Benzina,Diesel,IbridoBenzina,IbridoDiesel,GPL,Metano
}
public static class FuelTypeMethods{
    public static FuelType FromString(string fuel)=>fuel switch{
        "Benzina"=>FuelType.Benzina,
        "Diesel"=>FuelType.Diesel,
        "Ibrido Benzina"=>FuelType.IbridoBenzina,
        "Ibrido Diesel"=>FuelType.IbridoDiesel,
        "GPL"=>FuelType.GPL,
        "Metano"=>FuelType.Metano,
        _=>FuelType.UNDEFINED
    };
}