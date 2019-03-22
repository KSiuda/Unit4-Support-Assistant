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
            string password = StringCipher.Decrypt(config.AppSettings.Settings["password"].Value, config.AppSettings.Settings["salt"].Value);
            return password;
            //return config.AppSettings.Settings["password"].Value;
        }

        public void SavePassword(string value)
        {
            config.AppSettings.Settings.Remove("password");
            config.AppSettings.Settings.Remove("salt");
            string salt = StringCipher.GenerateSalt();
            string encryptedstring = StringCipher.Encrypt(value, salt);
            config.AppSettings.Settings.Add("password", encryptedstring);
            config.AppSettings.Settings.Add("salt", salt);
            //config.AppSettings.Settings.Add("password", value);
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

        public void SaveGenericsTab(string value)
        {
            config.AppSettings.Settings.Remove("genericsTab");
            config.AppSettings.Settings.Add("genericsTab", value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
        public int GetGenericsTab()
        {
            var tab = Convert.ToInt32(config.AppSettings.Settings["genericsTab"].Value);

            return tab;
        }

        public void SaveMainQueueTab(string value)
        {
            config.AppSettings.Settings.Remove("mainQueueTab");
            config.AppSettings.Settings.Add("mainQueueTab", value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

        public int GetMainQueueTab()
        {
            var tab = Convert.ToInt32(config.AppSettings.Settings["mainQueueTab"].Value);

            return tab;
        }
    }
}

