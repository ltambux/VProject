using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using VProject.Data;

namespace VProject.Services;

public static class JsonToClass{
    public static string Directory=_getDir();
    public static T ReadFromJsom<T>(string fileName,Func<JObject,T> convert,T _default=null)where T:class{
        if(fileName is null or ""){
            // Log.Error($".{nameof(ReadFromJsom)}<{nameof(T)}>() > file name null or empty");
            throw new ArgumentNullException("","");
        }
        try{
            string path=Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            JsonSerializerSettings settings=new();
            settings.ContractResolver=new CamelCasePropertyNamesContractResolver();
            string fullJson=File.ReadAllText(Path.Combine(path,fileName));
            return convert(JsonConvert.DeserializeObject<JObject>(fullJson,settings));
        }catch(Exception ex){
            // Log.Error(ex.ToString());
            return _default;
        }
    }

    public static Dictionary<string,GearRatio> ReadGearRatios(){
        string filename="GearRatioConfig.json";
        string path=Path.Combine(Directory,filename);
        
        return null;
    }

    private static string _getDir(){
        return Assembly.GetExecutingAssembly().Location.Replace($"VProject.exe",@"Resources\");
    }
}