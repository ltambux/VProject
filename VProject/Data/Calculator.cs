namespace VProject.Data;

public class Calculator{
    public Wheel Wheel {get;private set;}
    public GearRatio Gear {get;set;}
    public GearRatio SpeedCalculation {get;set;}

    public Calculator(){
        Wheel=new(WheelDiam.R17,WheelWidth.mm205,55);
        Gear=new();
    }

    public int RPMs(double kmh){
        
        return-1;
    }
    public int Speed(double rpm){
        return-1;
    }
}