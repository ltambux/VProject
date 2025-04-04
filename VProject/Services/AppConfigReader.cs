using System.Configuration;
using System.Reflection;

namespace VProject.Services;


public static class AppConfigReader{
    private static AppSettingsSection _appSetting {get;}
    static AppConfigReader(){
        ExeConfigurationFileMap map=new(){
            ExeConfigFilename=Assembly.GetExecutingAssembly().Location+".config"};
        Configuration libConfig=ConfigurationManager.OpenMappedExeConfiguration(map,ConfigurationUserLevel.None);
        _appSetting=libConfig.GetSection("appSettings") as AppSettingsSection;
    }
    public static string Get(string name)=>_appSetting.Settings[name].Value??"";
}