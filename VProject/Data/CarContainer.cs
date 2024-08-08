using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VProject.Services;

namespace VProject.Data;

public class CarContainer{
    private static CarContainer _instance;
    public List<Car> Cars {get;}

    private CarContainer(){
        Cars=[];
        Log.Debug("Prova di lettura del json");
        try {
            Cars=JsonToClass.ReadFromJsom<List<Car>>("CarsList.json");
        }catch(Exception ex){
            Log.Error(ex.ToString());
        }
    }
    public static CarContainer Instance()=>_instance??=new();
}