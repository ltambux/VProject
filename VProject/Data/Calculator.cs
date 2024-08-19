using System;
using VProject.Services;

namespace VProject.Data;

public class Calculator{
    public Wheel Wheel {get;private set;}
    public Car Car {get;set;}
    public GearRatio Gears => Car.GearRatios;
    public GearRatio SpeedCalculation {get;set;}
    public Gear Selected { get; set; }

    public Calculator(){
        Wheel=new(WheelDiam.R17,WheelWidth.mm205,TirePercentage.p55);
        Selected=Data.Gear.First;
    }

    public double RPMs(double kmh){
        double w_rpm=Wheel.RPMs(kmh/3.6);
        double ratio=Gears.FinalDrive * SelectedGear();
        return w_rpm*ratio;
    }

    public double SelectedGear(){
        return Selected switch{
            Gear.First=>Gears.First,
            Gear.Second=>Gears.Second,
            Gear.Third=>Gears.Third,
            Gear.Fourth=>Gears.Fourth,
            Gear.Fifth=>Gears.Fifth,
            Gear.Sixth=>Gears.Sixth,
            _=>Gears.Rear
        };
    }

    public int Speed(double rpm){
        return-1;
    }

    public void SetWheel(string diam,string width,string p){
        Wheel.R=WheelExtension.WheelDiameter(diam);
        Wheel.Width=WheelExtension.WheelWidthFromString(width);
        Wheel.TirePercent=WheelExtension.WheelTirePercentage(p);
        Log.Debug($"Wheel setted to {Wheel.Width}/{Wheel.TirePercent} {Wheel.R}",
                  "Distance in a revolution = "+Wheel.SingleRevolution());
    }

    public void SetGear(string gear){
        Selected=GearRatio.GetGears(gear);
        if(SelectedGear() is 0)throw new ArgumentOutOfRangeException($"{Selected}",
            $"{Car.Model} doesn't have this gear value. Check the json");
    }
}