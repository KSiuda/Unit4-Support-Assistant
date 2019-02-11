using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using Unit4HomeOffice.WorkClasses;

namespace Unit4HomeOffice
{
    public partial class Main : Form
    {
        Configuration _config;
        IWebDriver _driver;
        AppSetting _setting;
        MouseMover _mover;
        CaseUpdater _updater;
        Main _main;

        private Thread Mover;
        private Thread CaseUpdater;

        bool update = false;
        bool move = false;



        public Main(AppSetting setting, MouseMover mover, CaseUpdater updater)
        {
            _setting = setting;
            _mover = mover;
            _updater = updater;
            _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _main = this;
            InitializeComponent();
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Mover!= null && Mover.IsAlive)
            {
                Mover.Abort();
            }
            if(CaseUpdater!= null && CaseUpdater.IsAlive)
            {
                CaseUpdater.Abort();
            }
            if(_driver != null)
            {
                try
                {
                    _driver.Close();

                }
                catch
                {

                }
            }
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm(_setting);
            settings.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(move == false)
            {
                move = true;
                Mover = _mover.GhostMouse(move);
                Mover.Start();
            }
            else
            {
                move = false;
                Mover.Abort();
            }
        }

        

        private void Main_Load(object sender, EventArgs e)
        {
             move = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                IWebDriver driver = _updater.GetNew(_config);
                driver.Url = "https://u4.my.salesforce.com/";
                _driver = driver;

                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                driver.FindElement(By.Id("username")).SendKeys(_setting.GetUserName());
                driver.FindElement(By.Id("password")).SendKeys(_setting.GetPassword() + OpenQA.Selenium.Keys.Enter);
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
            


            //progressLabel.Text = progress.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var driver = _driver;

               
                if(update == false)
                {
                    update = true;
                    CaseUpdater = _updater.CaseUpdaterThread(driver, _setting, update, _main);
                    CaseUpdater.Start();
                }
                else
                {
                    update = false;
                    CaseUpdater.Abort();
                }
                
            }
            catch
            {
                MessageBox.Show("Please log in to the Salesforce first!");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
