using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Unit4HomeOffice
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



        public void UpdateCases(IWebDriver driver, AppSetting appSetting, bool update, Main form)
        {
            int cached = 0;
            int count = 0;
            int current = 0;

            while (update)
            {
                form.monitorLabel.Invoke(new Action(() => form.monitorLabel.Visible = true));

                try
                {
                    var progres = GetInProgress(driver);
                    if (progres.Length == 16)
                    {
                        Int32.TryParse((progres.Substring(13, 2)), out current);
                    }
                    else if (progres.Length == 15)
                    {
                        Int32.TryParse((progres.Substring(13, 1)), out current);
                    }
                    form.progressLabel.Invoke(new Action(() => form.progressLabel.Text = current.ToString()));
                    if (count > 0)
                    {
                        if (cached != current)
                        {
                            System.Media.SystemSounds.Beep.Play();
                            MessageBox.Show("YOUR PROGRESS HAS CHANGED!!!");
                        }
                    }
                    //GetCurrentInProgressCases(driver);
                    Thread.Sleep(appSetting.GetInterval());
                    cached = current;
                    count++;
                }
                catch
                {
                    MessageBox.Show("Please log in to the Salesforce first or maximize the automated browser!");
                    update = false;
                }
                
            }

            form.monitorLabel.Invoke(new Action(() => form.monitorLabel.Visible = false));

        }

    }

    

    
}
