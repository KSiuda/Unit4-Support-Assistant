using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Unit4HomeOffice
{
    public class DriverCreator
    {
        private List<int> _driverProcessIDs;

        public async Task<IWebDriver> CreateDriver(CaseUpdater updater, Configuration configuration, AppSetting setting, Main form)
        {
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            IEnumerable<int> pidsBefore = await Task.Run(() => Process.GetProcessesByName("chrome").Select(p => p.Id));

            IWebDriver driver = await GetNew(configuration);
            driver.Url = "https://u4.my.salesforce.com/";


            await Task.Run(() => driver.Manage().Window.Maximize());
            await Task.Run(() => driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10));

            await Task.Run(() => driver.FindElement(By.Id("username")).SendKeys(setting.GetUserName()));
            await Task.Run(() => driver.FindElement(By.Id("password")).SendKeys(setting.GetPassword() + OpenQA.Selenium.Keys.Enter));

            
            IEnumerable<int> pidsAfter = Process.GetProcessesByName("chrome").Select(p => p.Id);
            IEnumerable<int> driverPids = pidsAfter.Except(pidsBefore);
            List<int> driverslist = driverPids.ToList();
            _driverProcessIDs.AddRange(driverslist);

            form.salesforceLabel.Invoke(new Action(() => form.salesforceLabel.Visible = true));


            return driver;
        }



        public async Task<IWebDriver> GetNew(Configuration configuration)
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

            var driverProcessIds = await Task.Run(() => new List<int> { chromeDriverService.ProcessId });
            _driverProcessIDs = driverProcessIds;
            return new ChromeDriver(chromeDriverService, new ChromeOptions());

        }



        public Thread DriverAliveChecker(IWebDriver driver, AppSetting appSetting, Main form)
        {
            return new Thread(() => CheckAlive(driver, appSetting, form));
        }



        public void CheckAlive(IWebDriver driver, AppSetting setting, Main form)
        {
            while (form != null)
            {
                foreach (var proces in _driverProcessIDs.ToList())
                {
                    try
                    {
                        Process.GetProcessById(proces);                       
                    }
                    catch
                    {
                        _driverProcessIDs.Remove(proces);
                    }
                }
                if(_driverProcessIDs.Count() == 1)
                {
                    try
                    {
                        driver.Dispose();
                        form.salesforceLabel.Invoke(new Action(() => form.salesforceLabel.Visible = false));
                    }
                    catch
                    {

                    }                  
                }
            }
        }


    }
}
