using System;

namespace VProject.Data;

public class Calculator{
    public Wheel Wheel {get;private set;}
    public GearRatio Gears {get;set;}
    public GearRatio SpeedCalculation {get;set;}
    public Gear Selected { get; set; }

    public Calculator(){
        Wheel=new(WheelDiam.R17,WheelWidth.mm205,TirePercentage.p55);
        Gears=new();
        Selected=Data.Gear.First;
    }

    public double RPMs(double kmh){
        double w_rpm=Wheel.RPMs(kmh/3.6);
        double ratio=Gears.FinalDrive * GetGearRatio();
        return w_rpm*ratio;
    }

    public double GetGearRatio(){
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

    public void SetWheel() {
        
    }

    public void SetGear(string gear){
        Selected=GearRatio.GetGears(gear);
        if(GetGearRatio() is 0)throw new ArgumentOutOfRangeException();
    }
}