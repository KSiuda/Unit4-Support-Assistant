using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Unit4HomeOffice.Classes
{
    public class DriverCreator
    {


        public IWebDriver CreateDriver(CaseUpdater updater, Configuration configuration, AppSetting setting, Main form)
        {
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            IWebDriver driver = GetNew(configuration);
            driver.Url = "https://u4.my.salesforce.com/";
            

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.Id("username")).SendKeys(setting.GetUserName());
            driver.FindElement(By.Id("password")).SendKeys(setting.GetPassword() + OpenQA.Selenium.Keys.Enter);

            form.salesforceLabel.Invoke(new Action(() => form.salesforceLabel.Visible = true));

            return driver;
        }



        public IWebDriver GetNew(Configuration configuration)
        {
            if (configuration.AppSettings.Settings["browser"].Value == "Firefox")
            {

                var o = new FirefoxOptions();
                o.AddArgument("-headless");
                var driver = new FirefoxDriver(o);

                return driver;
            }

            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;

            return new ChromeDriver(chromeDriverService, new ChromeOptions());

        }



        public Thread DriverAliveChecker(IWebDriver driver, AppSetting appSetting, Main form)
        {
            return new Thread(() => CheckAlive(driver, appSetting, form));
        }



        public void CheckAlive(IWebDriver driver, AppSetting setting, Main form)
        {
            while(driver != null)
            {
                
            }

            form.salesforceLabel.Invoke(new Action(() => form.salesforceLabel.Visible = false));
        }


    }
}
