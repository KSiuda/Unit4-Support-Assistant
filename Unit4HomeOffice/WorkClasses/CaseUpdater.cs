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
using System.Windows.Forms;

namespace Unit4HomeOffice.WorkClasses
{
    public class CaseUpdater
    {

        public Thread CaseUpdaterThread(IWebDriver driver, AppSetting appSetting, bool update, Main form)
        {
            return new Thread(() => UpdateCases(driver,appSetting, update, form));
        }

        List<string> GetCurrentInProgressCases(IWebDriver driver)
        {
            var frame = driver.FindElement(By.CssSelector("#ext-comp-1005"));
            driver.SwitchTo().Frame(frame);
            var frame2 = driver.FindElement(By.CssSelector("#\\30 66w0000001Ft1W"));
            driver.SwitchTo().Frame(frame2);

            var worktable = driver.FindElement(By.Id("Casepage:j_id40:j_id43"));
            var table = worktable.FindElement(By.Id("opp_quote_reagent_content1"));
            var rows = table.FindElements(By.TagName("tr"));

            List<string> cases = new List<string>();
            foreach (var row in rows)
            {
                var rowTds = row.FindElements(By.ClassName("colValue"));
                foreach (var td in rowTds)
                {
                    if (td.Text.StartsWith("00"))
                    {
                        cases.Add(td.Text);
                    }
                }
            }

            driver.Navigate().Refresh();
            driver.SwitchTo().DefaultContent();

            return cases;
        }


        public string GetInProgress(IWebDriver driver)
        {
            var frame = driver.FindElement(By.CssSelector("#ext-comp-1005"));
            driver.SwitchTo().Frame(frame);
            var frame2 = driver.FindElement(By.CssSelector("#\\30 66w0000001Ft1W"));
            driver.SwitchTo().Frame(frame2);
            var progres = driver.FindElement(By.Id("Casepage:j_id40:j_id43_lbl")).Text;

            driver.Navigate().Refresh();
            driver.SwitchTo().DefaultContent();

            return progres;
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

        public void UpdateCases(IWebDriver driver, AppSetting appSetting, bool update, Main form)
        {
            int cached = 0;
            int count = 0;

            while (update)
            {
                try
                {
                    Int32.TryParse((GetInProgress(driver).Substring(13, 2)), out int current);
                    form.progressLabel.Invoke(new Action(() => form.progressLabel.Text = current.ToString()));
                    if (count > 0)
                    {
                        if (cached != current)
                        {
                            MessageBox.Show("YOUR PROGRESS HAS CHANGED!!!");
                        }
                        cached = current;
                    }
                    //GetCurrentInProgressCases(driver);
                    Thread.Sleep(appSetting.GetInterval());

                    count++;
                }
                catch
                {
                    MessageBox.Show("Please log in to the Salesforce first or maximize the automated browser!");
                    update = false;
                }
                
            }
           
        }

    }

    

    
}
