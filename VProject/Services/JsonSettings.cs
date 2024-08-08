using System;
using System.IO;

namespace VProject.Services;

public class JsonSettings{
    private static string TIME=>DateTime.Now.ToString("yyyy-MM-dd_hh-mm");
    public static readonly string DEFAULT_PATH=_defaultDirectory();
    public FilePosition Read {get;set;}
    public FilePosition Write {get;set;}

    public JsonSettings(string loadingDir=null,string loadingName=null,string savingDir=null,string savingName=null){
        Read=new(loadingDir??DEFAULT_PATH,loadingName??_getLoadingName());
        Write=new(savingDir??DEFAULT_PATH,savingName??_getSavingName());
        Log.Debug("Read",Read.Directory,Read.Filename,Read.FullPath());
        Log.Debug("Write",Write.Directory,Write.Filename,Write.FullPath());
    }

    public class FilePosition(string directory,string filename){
        public string Directory {get;set;}=directory;
        public string Filename {get;set;}=filename;

        public string FullPath()=>Path.Combine(Directory,Filename);
    }

    private static string _getLoadingName()=>$"";
    private static string _getSavingName()=>$"DgvSaving_{TIME}.json";
    private static string _defaultDirectory()=>Path.Combine(Directory.GetCurrentDirectory(),"Repository");
}