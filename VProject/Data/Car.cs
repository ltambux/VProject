using Newtonsoft.Json;

namespace VProject.Data;

public class Car{
    public FuelEfficiency Consumption { get; set; }
    public Wheel Wheels { get; set; }
    public string Brand {get;set;}
    public string Model {get;set;}
    public string Series {get;set;}
    public GearRatios Gears {get;set;}
    public int Weight {get;set;}
    public int Power {get;set;}
    public string Name=>$"{Brand} {Model}"; // {Series}

    [JsonConstructor]
    public Car(string brand,string model,string series,GearRatios gears,int weight,int power){
        Brand=brand;
        Model=model;
        Series=series;
        Gears=gears;
        Weight=weight;
        Power=power;
    }
}