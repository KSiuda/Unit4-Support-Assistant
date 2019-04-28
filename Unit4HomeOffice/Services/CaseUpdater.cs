using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit4HomeOffice
{
    public class CaseUpdater
    {

        public Thread CaseUpdaterThread(IWebDriver driver, AppSetting appSetting, bool update, Main form)
        {
            return new Thread(() => UpdateCases(driver,appSetting, update, form));
        }

        async Task Populate(IWebDriver driver, ListView casesListView, List<string> cases)
        {
            if (cases.Count > 0)
            {
                ChangeToWhite(casesListView);
            }
            foreach (var acase in cases)
            {
                ListViewItem Cases = new ListViewItem(acase);
                casesListView.Invoke(new Action(() => casesListView.Items.Add(acase)));
            }
        }

        void Populate(IWebDriver driver, ListView casesListView, ListView newCasesListView, List<string> cases, List<string> newcases)
        {
            if (cases.Count > 0)
            {
                ChangeToWhite(casesListView);
            }
            foreach (var acase in cases)
            {
                ListViewItem Cases = new ListViewItem(acase);
                casesListView.Invoke(new Action(() => casesListView.Items.Add(acase)));
                

            }
            if (cases.Count > 0)
            {
                ChangeToWhite(newCasesListView);
            }
            foreach (var acase in newcases)
            {
                 ListViewItem Cases = new ListViewItem(acase);
                 newCasesListView.Invoke(new Action(() => newCasesListView.Items.Add(acase)));
                 
            }
        }

        void Populate(IWebDriver driver, ListView casesListView,ListView removedCasesListView, List<string> cases, IEnumerable<string> removedcases)
        {
            if (cases.Count > 0)
            {
                ChangeToWhite(casesListView);
            }
            foreach (var acase in cases)
            {
                ListViewItem Cases = new ListViewItem(acase);
                casesListView.Invoke(new Action(() => casesListView.Items.Add(acase)));
               

            }
            if (cases.Count > 0)
            {
                ChangeToWhite(removedCasesListView);
            }
            foreach (var acase in removedcases)
            {
                ListViewItem Cases = new ListViewItem(acase);
                removedCasesListView.Invoke(new Action(() => removedCasesListView.Items.Add(acase)));
              
            }
        }

        void ChangeToWhite(ListView element)
        {
            Color color = Color.FromName("WhiteSmoke");
            element.Invoke(new Action(() => element.BackColor = color ));
        }
        void ChangeToBackground(ListView element)
        {
            Color color = Color.FromArgb(160, 201, 22);
            element.Invoke(new Action(() => element.BackColor = color));
        }

        void ClearRemoved(ListView removedCasesListView)
        {
            removedCasesListView.Invoke(new Action(() => removedCasesListView.Items.Clear()));
            ChangeToBackground(removedCasesListView);
        }
        void ClearNew(ListView newCasesListView)
        {
            newCasesListView.Invoke(new Action(() => newCasesListView.Items.Clear()));
            ChangeToBackground(newCasesListView);
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



        public async Task UpdateCases(IWebDriver driver, AppSetting appSetting, bool update, Main form)
        {
            int cached = 0;
            int count = 0;
            int current = 0;
            List<string> cachedCases = null;
            List<string> currentCases;
            List<string> newCases;
            List<string> removedCases;
            var casesList = form.casesListView;
            var newCasesList = form.newcasesListView;
            var removedCasesList = form.removedCasesListView;

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
                       await Populate(driver, casesList, currentCases);
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
                                Populate(driver, casesList,newCasesList, currentCases, newCases);
                            }
                            if (removedCases.Count() != 0)
                            {
                                Populate(driver, casesList, removedCasesList, currentCases, removedCases.AsEnumerable());
                            }
                        }
                        if(removedCases.Count() == 0)
                        {
                            ClearRemoved(removedCasesList);
                        }
                        if(newCases.Count() == 0)
                        {
                            ClearNew(newCasesList);
                        }
                        else
                        {
                           await Populate(driver, casesList, currentCases);
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
                catch(Exception ex)
                {
                    MessageBox.Show(ex.StackTrace, ex.Message);               
                    update = false;
                }
                
            }
            form.monitorLabel.Invoke(new Action(() => form.monitorLabel.Visible = false));



        }

    }

    

    
}
