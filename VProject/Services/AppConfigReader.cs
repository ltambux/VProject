using System.Reflection;

namespace VProject.Services;
public class AppConfigReader{
    private static AppConfigReader INSTANCE;
    // private AppSettingsSection _appSetting {get;}

    private AppConfigReader(Assembly parentAssembly){
        /*
        ExeConfigurationFileMap map=new(){ExeConfigFilename=parentAssembly.Location+".config"};
        Configuration libConfig=ConfigurationManager.OpenMappedExeConfiguration(map,ConfigurationUserLevel.None);
        _appSetting=libConfig.GetSection("appSettings") as AppSettingsSection;
        */
    }
    public static AppConfigReader Init(Assembly parentAssembly)=>INSTANCE??=new(parentAssembly);

    // public string Get(string name)=>_appSetting.Settings[name].Value??"";
}