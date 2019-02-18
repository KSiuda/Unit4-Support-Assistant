using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium;

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
            // string password = StringCipher.Decrypt(config.AppSettings.Settings["password"].Value, "password");
            // return password ;
            return config.AppSettings.Settings["password"].Value;
        }

        public void SavePassword(string value)
        {
            config.AppSettings.Settings.Remove("password");
            //string encryptedstring = StringCipher.Encrypt(value, "password");
            //config.AppSettings.Settings.Add("password", encryptedstring);
            config.AppSettings.Settings.Add("password", value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

        public void SaveBrowserSettings(string value)
        {
            config.AppSettings.Settings.Remove("browser");
            config.AppSettings.Settings.Add("browser", value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

        public string GetBrowserSettings()
        {
            return config.AppSettings.Settings["browser"].Value;
        }

        public int GetInterval()
        {
            var interval = Convert.ToInt32(config.AppSettings.Settings["interval"].Value);

            return interval;
        }

        public void SaveInterval(string value)
        {
            config.AppSettings.Settings.Remove("interval");
            config.AppSettings.Settings.Add("interval", value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
    }
}

