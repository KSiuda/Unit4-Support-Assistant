using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace Unit4HomeOffice
{
    public partial class Main : Form
    {
        Configuration _config;
        IWebDriver _driver;
        AppSetting _setting;
        MouseClicker _mover;
        CaseUpdater _updater;
        Main _main;
        DriverCreator _creator;

        private Thread Mover;
        private Thread CaseUpdater;
        private Thread AliveChecker;

        bool update = false;
        bool move = false;



        public Main(AppSetting setting, MouseClicker mover, CaseUpdater updater, DriverCreator creator)
        {
            _setting = setting;
            _mover = mover;
            _updater = updater;
            _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _creator = creator;
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
            if (AliveChecker != null && AliveChecker.IsAlive)
            {
                AliveChecker.Abort();
            }

            if (_driver != null)
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
                Mover = _mover.GhostMouse(move, _main);
                Mover.Start();
            }
            else
            {
                move = false;
                labelMouse.Invoke(new Action(() => labelMouse.Visible = false));
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
               _driver = _creator.CreateDriver(_updater, _config, _setting, _main);
               AliveChecker = _creator.DriverAliveChecker(_driver, _setting, _main);
               AliveChecker.Start();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
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

        private void readMeButton_Click(object sender, EventArgs e)
        {
            if(readmeTextBox.Visible == false)
            {
                readmeTextBox.Invoke(new Action(() => readmeTextBox.Visible = true));
            }
            else if(readmeTextBox.Visible == true)
            {
                readmeTextBox.Invoke(new Action(() => readmeTextBox.Visible = false));
            }
        }
    }
}
