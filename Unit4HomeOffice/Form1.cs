using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Unit4HomeOffice
{
    public partial class Main : Form
    {
        Configuration config;
        bool move = false;
        

        public Main()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm();
            settings.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread ghostMouse = new Thread(new ThreadStart(ghostMove));

            if (move == false)
            {
                move = true;               
                ghostMouse.Start();
            }
            else
            {
                move = false;
                ghostMouse.Abort();
            }

        }

        private void ghostMove()
        {
            
            while (move)
            {
                Cursor.Position = new System.Drawing.Point(Cursor.Position.X + 500, Cursor.Position.Y + 500);
                Thread.Sleep(500);
                Cursor.Position = new System.Drawing.Point(Cursor.Position.X - 500, Cursor.Position.Y - 500);

            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
             move = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://u4.my.salesforce.com/";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.Id("username")).SendKeys(config.AppSettings.Settings["username"].Value);
            driver.FindElement(By.Id("password")).SendKeys(config.AppSettings.Settings["password"].Value + OpenQA.Selenium.Keys.Enter);
        }
       
    }
}
