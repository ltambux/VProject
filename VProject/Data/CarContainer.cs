using System;
using System.Collections.Generic;
using VProject.Services;

namespace VProject.Data;

public class CarContainer{
    private static CarContainer _instance;
    public List<Car> Cars {get;}

    private CarContainer(){
        Cars=[];
        try {
            Cars=JsonToClass.ReadFromJsom<List<Car>>(@"Resources\CarsList.json");
        }catch(Exception ex){
            Log.Error(ex.ToString());
        }
    }
    public static CarContainer Instance()=>_instance??=new();
}