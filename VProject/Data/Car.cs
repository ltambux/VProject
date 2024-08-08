using Newtonsoft.Json;

namespace VProject.Data;

public class Car{
    public string Brand {get;set;}
    public string Model {get;set;}
    public string Series {get;set;}
    public GearRatio GearRatios {get;set;}
    public int Weight {get;set;}
    public int Power {get;set;}

    [JsonConstructor]
    public Car(string brand,string model,string series,GearRatio gearRatios,int weight,int power){
        Brand=brand;
        Model=model;
        Series=series;
        GearRatios=gearRatios;
        Weight=weight;
        Power=power;
    }
}