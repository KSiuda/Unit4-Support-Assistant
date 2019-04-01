using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using Unit4HomeOffice.Entities;
using System.Linq;
using Unit4HomeOffice.Classes;

namespace Unit4HomeOffice.Services
{
    public class AutoDispatcher
    {
        Context context;
        List<string> Consultants = new List<string>();
        List<Tuple<string, int>> available = new List<Tuple<string, int>>();

        public AutoDispatcher(Context context)
        {
            this.context = context;
        }
     
        public Thread AutoDispatching(IWebDriver driver, AppSetting appSetting, bool dispatch, Main form)
        {
            return new Thread(() => AutoDispatch(driver, appSetting, dispatch, form));
        }

        public void AutoDispatch(IWebDriver driver, AppSetting appSetting, bool dispatch, Main form)
        {
            List<Tuple<string, string, string, string, string, string>> mainQueue;
            List<Tuple<string, string, string, string, string, string>> Generics;

            while (dispatch)
            {
                form.dispatchLabel.Invoke(new Action(() => form.dispatchLabel.Visible = true));

                try
                {   ExcelImport importer = new ExcelImport();
                    available = importer.CheckConsultants(@"C:\Users\KSIUDA\Desktop\SQL\TICKETS LOGISTICS Mar 19 - Dec 19.xlsx");
                    mainQueue = CheckQueue(driver, appSetting.GetMainQueueTab(), Consultants);
                    foreach(var item in mainQueue)
                    {
                        Consultants.Add(item.Item6);
                    }
                    Populate(driver, form.mainQueueListView, mainQueue);

                    Generics = CheckQueue(driver, appSetting.GetGenericsTab(), Consultants);
                    Populate(driver, form.GenericsListView, Generics);
                    Consultants.Clear();
                    available.Clear();

                }
                catch (System.Threading.ThreadAbortException)
                {
                    dispatch = false;
                }
                catch
                {
                    MessageBox.Show("Please log in to the Salesforce first or maximize the automated browser!");
                    dispatch = false;
                }

                Thread.Sleep(appSetting.GetInterval());
            }
            form.dispatchLabel.Invoke(new Action(() => form.dispatchLabel.Visible = false));

        }

        List<Tuple<string, string, string, string, string, string>> CheckQueue(IWebDriver driver, int tabNumber,List<string> Consultants)
        {
            List<string> CachedConsultants = Consultants;
            Actions actions = new Actions(driver);
            var frame = driver.FindElement(By.CssSelector("#ext-comp-1005"));
            driver.SwitchTo().Frame(frame);
            var frame2 = driver.FindElement(By.CssSelector("#\\30 66w0000001Ft1W"));
            driver.SwitchTo().Frame(frame2);
            actions.MoveToElement(driver.FindElement(By.Id($"Casepage:tab{tabNumber}_cell"))).Perform();
            actions.DoubleClick(driver.FindElement(By.Id($"Casepage:tab{tabNumber}_cell"))).Perform();
            Thread.Sleep(3000);


            var tables = driver.FindElements(By.ClassName("x-grid3-row-table"));
            var cases = new List<Tuple<string, string, string, string, string, string>>();

            int i = 1;

            foreach (var table in tables)
            {
                string caseNumber = "";
                string FunctionalArea = "";
                string SubModule = "";
                string SupportCountry = "";
                string SupportModel = "";
                string Consultant = "";

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
                    try
                    {
                        if (SubModule == "Salesorders")
                            SubModule = "Sales Orders";

                            if(SubModule == "Other")
                            {                              
                                var query= (from c in context.TrainingDetails
                                              where !CachedConsultants.Contains(c.ConsultantName)
                                              && (c.Status == "YES" ||c.Status =="TR")
                                              select c.ConsultantName);
                                Consultant  = (from c in available
                                                orderby c.Item2
                                                where query.Contains(c.Item1)
                                                select c.Item1).FirstOrDefault();
                                CachedConsultants.Add(Consultant);
                            }
                            else
                            {
                            var query = (from c in context.TrainingDetails
                                         where c.TrainingName.Contains(SubModule)
                                         && !CachedConsultants.Contains(c.ConsultantName)
                                         && (c.Status == "YES" || c.Status == "TR")
                                         select c.ConsultantName);
                               Consultant = (from c in available
                                             orderby c.Item2
                                             where query.Contains(c.Item1)
                                             select c.Item1).FirstOrDefault();

                            CachedConsultants.Add(Consultant);
                            }
                            
                        
                    }
                    catch
                    {
                        Consultant = "Not found";
                    }
                   
                    


                    cases.Add(Tuple.Create(caseNumber, FunctionalArea, SubModule, SupportCountry, SupportModel, Consultant));

                    i++;
                }
            }
          
            driver.Navigate().Refresh();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(5000);

            return cases;
        }

        void Populate(IWebDriver driver, ListView queueListView, List<Tuple<string, string, string, string, string, string>> cases)
        {
            queueListView.Invoke(new Action(() => queueListView.Items.Clear()));           
            if (cases.Count > 0)
            {
                ChangeToWhite(queueListView);
            }
            else
            {
                ChangeToBackground(queueListView);
            }
            foreach (var acase in cases)
            {
                acase.Deconstruct(out string item1, out string item2, out string item3, out string item4, out string item5, out string item6);
                ListViewItem Cases = new ListViewItem(item1);
                Cases.SubItems.Add(item2);
                Cases.SubItems.Add(item3);
                Cases.SubItems.Add(item4);
                Cases.SubItems.Add(item5);
                Cases.SubItems.Add(item6);
                queueListView.Invoke(new Action(() => queueListView.Items.Add(Cases)));
            }           
        }

        void ChangeToWhite(ListView element)
        {
            Color color = Color.FromName("WhiteSmoke");
            element.Invoke(new Action(() => element.BackColor = color));
        }
        void ChangeToBackground(ListView element)
        {
            Color color = Color.FromArgb(160, 201, 22);
            element.Invoke(new Action(() => element.BackColor = color));
        }
    }
}
