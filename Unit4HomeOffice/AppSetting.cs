using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Unit4HomeOffice
{
    public class AppSetting
    {
        Configuration config;

        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public string GetUserName()
        {
            return config.AppSettings.Settings["username"].Value;
        }

        public void SaveUserName(string value)
        {
            config.AppSettings.Settings.Remove("username");
            config.AppSettings.Settings.Add("username", value);           
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

        public string GetPassword()
        {
            return config.AppSettings.Settings["password"].Value;
        }

        public void SavePassword(string value)
        {
            config.AppSettings.Settings.Remove("password");
            config.AppSettings.Settings.Add("password", value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
    }
}

