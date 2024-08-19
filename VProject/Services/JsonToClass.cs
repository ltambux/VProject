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
            Log.Error(ex.ToString());
            return _default;
        }
    }
    public static T ReadFromJsom<T>(string fileName)where T:class{
        if(fileName is null or ""){
            // Log.Error($".{nameof(ReadFromJsom)}<{nameof(T)}>() > file name null or empty");
            throw new ArgumentNullException("","");
        }
        try{
            string path=Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            JsonSerializerSettings settings=new();
            settings.ContractResolver=new CamelCasePropertyNamesContractResolver();
            string fullJson=File.ReadAllText(Path.Combine(path,fileName));
            return JsonConvert.DeserializeObject<T>(fullJson,settings);
        }catch(Exception ex){
            Log.Error(ex.ToString());
            return null;
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

/*
public class DgvJsonManager{
    private static DgvJsonManager _instance;
    private JsonSettings _js;
    public string ReadPath=>_js.Read.FullPath();
    public string WritePath=>_js.Write.FullPath();

    private DgvJsonManager(JsonSettings js){
        _columns=[];
        _js=js ?? throw new MissingFieldException($"First instance of {nameof(DgvJsonManager)} called without {nameof(JsonSettings)}");
        ReadFromJson<JObject>(_js.Read.FullPath(),_internalConvert);
    }
    public static DgvJsonManager Instance(JsonSettings js=null)=>_instance??=new(js);

    public void SetJsonSettings(JsonSettings js)=>_js=js;

    private void _internalConvert(JObject obj){
        if(obj is null)return;
        try{
            JArray array=(JArray)obj["columns"];
            _columns=array.ToObject<List<CustomColumn>>();

            array=(JArray)obj["settings"];
            ColumnSettings[] tempSettings=array.ToObject<ColumnSettings[]>();
            foreach(CustomColumn c in _columns){
                try{
                    c.Settings=tempSettings.Single(cs=>cs.ConfigType==c.DgvType);
                }catch(InvalidOperationException ex){
                    Log.Warn($"Settings for {c.DgvType} column type:",ex.Message);
                }
            }
        }catch(InvalidCastException ex){
            Log.Error(ex.Message,ex.Source,ex.ToString());
        }catch(Exception ex){
            Log.Error(ex.Message,ex.Source,ex.ToString());
            throw;
        }
    }
    public void ReadFromJson(string full_path)=>
        ReadFromJson<Dictionary<string,CustomColumn>>(full_path,o=>_columns=o.Values.ToList());
    public static void ReadFromJson<T>(string full_path,Action<T> construct){
        if(full_path is ""){
            Log.Warn($"{typeof(JsonReader)}.{nameof(ReadFromJson)}(-,{nameof(Action<T>)}): no file passed!");
            throw new ArgumentNullException();
        }
        try{
            JsonSerializerSettings settings=new();
            settings.ContractResolver=new CamelCasePropertyNamesContractResolver();
            string jsonString=File.ReadAllText(full_path);
            T o=JsonConvert.DeserializeObject<T>(jsonString,settings);
            construct(o);
        }catch(Exception ex){
            Log.Error(ex.ToString());
        }
    }
    public void WriteToJson(List<CustomRow> data,JsonSettings js=null){
        string jsonString=JsonConvert.SerializeObject(data,Formatting.Indented);
        if(js is not null)_js=js;
        Log.Debug(jsonString);
        File.WriteAllText(_js.Write.FullPath(),jsonString);
    }
}
*/