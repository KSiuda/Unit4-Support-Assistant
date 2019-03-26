using System;
using System.Configuration;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using Unit4HomeOffice.Entities;
using Unit4HomeOffice.Forms;
using Unit4HomeOffice.Services;

namespace Unit4HomeOffice
{
    public partial class Main : Form
    {
        Configuration _config;
        IWebDriver _driver;
        AppSetting _setting;
        MouseClicker _mover;
        CaseUpdater _updater;
        AutoDispatcher _autoDispatcher;
        Main _main;
        DriverCreator _creator;
        Context _context;
        Color color = Color.FromArgb(160, 201, 22);

        private Thread Mover;
        private Thread CaseUpdater;
        private Thread AliveChecker;
        private Thread AutoDispatcher;

        bool update = false;
        bool move = false;
        bool dispatch = false;
        



        public Main(AppSetting setting, MouseClicker mover, CaseUpdater updater, DriverCreator creator, AutoDispatcher autoDispatcher, Context context)
        {
            _setting = setting;
            _mover = mover;
            _updater = updater;
            _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _creator = creator;
            _autoDispatcher = autoDispatcher;
            _context = context;
            _main = this;
            InitializeComponent();
        }
      

        private void buttonShutDown_Click_1(object sender, EventArgs e)
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
            if (AutoDispatcher != null && AutoDispatcher.IsAlive)
            {
                AutoDispatcher.Abort();
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

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm(_setting);
            settings.Show();
        }

        private void buttonRobot_Click(object sender, EventArgs e)
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

        private void buttonSF_Click(object sender, EventArgs e)
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

        private void buttonActiveCheck_Click(object sender, EventArgs e)
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
                    monitorLabel.Visible = false;
                    progressLabel.Text = "";
                    casesListView.Items.Clear();
                    casesListView.BackColor = color;

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

        private void buttonDispatch_Click(object sender, EventArgs e)
        {
            try
            {
                var driver = _driver;

                if (dispatch == false)
                {
                    dispatch = true;
                    AutoDispatcher = _autoDispatcher.AutoDispatching(driver, _setting, dispatch, _main);
                    AutoDispatcher.Start();
                }
                else
                {
                    dispatch = false;
                    AutoDispatcher.Abort();
                    dispatchLabel.Visible = false;

                    mainQueueListView.Items.Clear();
                    mainQueueListView.BackColor = color;

                    GenericsListView.Items.Clear();
                    GenericsListView.BackColor = color;

                }
            }
            catch
            {
                MessageBox.Show("Please log in to the Salesforce first!");
            }
        }

        private void ConsultantsFormButton_Click(object sender, EventArgs e)
        {           
            var consultants = new ConsultantsForm(_context);
            consultants.Show();
        }
    }
}
