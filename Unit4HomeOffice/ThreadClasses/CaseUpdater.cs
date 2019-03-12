using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
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

        void Populate(IWebDriver driver, Main form, List<string> cases)
        {
            foreach(var acase in cases)
            {
                ListViewItem Cases = new ListViewItem(acase);
                form.casesListView.Invoke(new Action(() => form.casesListView.Items.Add(acase)));
            }
            
        }

        void Populate(IWebDriver driver, Main form, List<string> cases, List<string> newcases)
        {
            foreach (var acase in cases)
            {
                ListViewItem Cases = new ListViewItem(acase);
                form.casesListView.Invoke(new Action(() => form.casesListView.Items.Add(acase)));

            }
            foreach(var acase in newcases)
            {
                 ListViewItem Cases = new ListViewItem(acase);
                 form.casesListView.Invoke(new Action(() => form.newcasesListView.Items.Add(acase)));
            }

        }

        void Populate(IWebDriver driver, Main form, List<string> cases, IEnumerable<string> removedcases)
        {
            foreach (var acase in cases)
            {
                ListViewItem Cases = new ListViewItem(acase);
                form.casesListView.Invoke(new Action(() => form.casesListView.Items.Add(acase)));

            }
            foreach (var acase in removedcases)
            {
                ListViewItem Cases = new ListViewItem(acase);
                form.casesListView.Invoke(new Action(() => form.removedCasesListView.Items.Add(acase)));
            }

        }

        void ClearRemoved(Main form)
        {
            form.casesListView.Invoke(new Action(() => form.removedCasesListView.Items.Clear()));
        }
        void ClearNew(Main form)
        {
            form.casesListView.Invoke(new Action(() => form.newcasesListView.Items.Clear()));
        }

        List<string> GetCurrentInProgressCases(IWebDriver driver)
        {
            driver.Navigate().Refresh();
            driver.SwitchTo().DefaultContent();

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

            return cases;
        }

        #region oldsolution
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
        #endregion 



        public void UpdateCases(IWebDriver driver, AppSetting appSetting, bool update, Main form)
        {
            int cached = 0;
            int count = 0;
            int current = 0;
            List<string> cachedCases = null;
            List<string> currentCases;
            List<string> newCases;
            List<string> removedCases;

            while (update)
            {
                form.monitorLabel.Invoke(new Action(() => form.monitorLabel.Visible = true));

                try
                {

                    currentCases = new List<string>(GetCurrentInProgressCases(driver));
                    current = currentCases.Count();
                    form.progressLabel.Invoke(new Action(() => form.progressLabel.Text = current.ToString()));


                    if (count == 0)
                    {
                        Populate(driver, form, currentCases);
                    }


                    if (count > 0)
                    {
                        newCases = new List<string>(currentCases.AsEnumerable().Except(cachedCases.AsEnumerable()).ToList());
                        removedCases = new List<string>(cachedCases.AsEnumerable().Except(currentCases.AsEnumerable()).ToList());

                        if (cached != current)
                        {
                            System.Media.SystemSounds.Beep.Play();
                            string gainedCases = string.Join(", ", newCases.ToArray());
                            string lostCases = string.Join(", ", removedCases.ToArray());
                            if(gainedCases.Length > 1)
                            {
                                MessageBox.Show($"YOUR PROGRESS HAS CHANGED!!! You have received cases: {gainedCases}");

                            }
                            if(lostCases.Length > 1)
                            {
                                MessageBox.Show($"Good job! Someone took: {lostCases} from you!");
                            }
                        }
                        

                        if (newCases.Count() != 0 || removedCases.Count() != 0)
                        {
                            if(newCases.Count() != 0)
                            {
                                Populate(driver, form, currentCases, newCases);
                            }
                            if (removedCases.Count() != 0)
                            {
                                Populate(driver, form, currentCases, removedCases.AsEnumerable());
                            }
                        }
                        if(removedCases.Count() == 0)
                        {
                            ClearRemoved(form);
                        }
                        if(newCases.Count() == 0)
                        {
                            ClearNew(form);
                        }
                        else
                        {
                            Populate(driver, form, currentCases);
                        }

                    }

                    
                    cachedCases = new List<string>(currentCases);
                    cached = current;
                    count++;

                    Thread.Sleep(appSetting.GetInterval());
                }
                catch(System.Threading.ThreadAbortException) //To stop the MessageBox from appearing after the program shutdown
                {
                    update = false;
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
