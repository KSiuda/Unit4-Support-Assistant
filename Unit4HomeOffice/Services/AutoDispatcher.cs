using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading.Tasks;
using System.Threading;

namespace Unit4HomeOffice.Services
{
    public class AutoDispatcher
    {
        public Thread AutoDispatching(IWebDriver driver, AppSetting appSetting, bool dispatch, Main form)
        {
            return new Thread(() => AutoDispatch(driver, appSetting, dispatch, form));
        }

        public void AutoDispatch(IWebDriver driver, AppSetting appSetting, bool dispatch, Main main)
        {

        }

        List<Tuple<string, string, string, string, string>> CheckQueue(IWebDriver driver, int tabNumber)
        {
            Actions actions = new Actions(driver);
            var frame = driver.FindElement(By.CssSelector("#ext-comp-1005"));
            driver.SwitchTo().Frame(frame);
            var frame2 = driver.FindElement(By.CssSelector("#\\30 66w0000001Ft1W"));
            driver.SwitchTo().Frame(frame2);
            actions.MoveToElement(driver.FindElement(By.Id($"Casepage:tab{tabNumber}_cell"))).Perform();
            actions.DoubleClick(driver.FindElement(By.Id($"Casepage:tab{tabNumber}_cell"))).Perform();
            Thread.Sleep(3000);


            var tables = driver.FindElements(By.ClassName("x-grid3-row-table"));
            var cases = new List<Tuple<string, string, string, string, string>>();

            int i = 1;

            foreach (var table in tables)
            {
                string caseNumber = "";
                string FunctionalArea = "";
                string SubModule = "";
                string SupportCountry = "";
                string SupportModel = "";

                var rows = table.FindElements(By.TagName("tr"));

                foreach (var row in rows)
                {
                    var Td = row.FindElement(By.CssSelector($"div.x-grid3-row:nth-child({i})>table:nth-child(1)>tbody:nth-child(1)>tr:nth-child(1)>td:nth-child(5)"));
                    var Td2 = row.FindElement(By.CssSelector($"div.x-grid3-row:nth-child({i})>table:nth-child(1)>tbody:nth-child(1)>tr:nth-child(1)>td:nth-child(15)"));
                    var Td3 = row.FindElement(By.CssSelector($"div.x-grid3-row:nth-child({i})>table:nth-child(1)>tbody:nth-child(1)>tr:nth-child(1)>td:nth-child(16)"));
                    var Td4 = row.FindElement(By.CssSelector($"div.x-grid3-row:nth-child({i})>table:nth-child(1)>tbody:nth-child(1)>tr:nth-child(1)>td:nth-child(13)"));
                    var Td5 = row.FindElement(By.CssSelector($"div.x-grid3-row:nth-child({i})>table:nth-child(1)>tbody:nth-child(1)>tr:nth-child(1)>td:nth-child(9)"));


                    caseNumber = Td.Text;
                    FunctionalArea = Td2.Text;
                    SubModule = Td3.Text.Substring(2, Td3.Text.Length - 2);
                    SupportCountry = Td4.Text;
                    SupportModel = Td5.Text;
                    cases.Add(Tuple.Create(caseNumber, FunctionalArea, SubModule, SupportCountry, SupportModel));

                    i++;
                }
            }

            driver.Navigate().Refresh();
            driver.SwitchTo().DefaultContent();

            return cases;
        }
    }
}
