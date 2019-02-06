using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Unit4HomeOffice
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
             
              AppSetting setting = new AppSetting();
              setting.SaveUserName(textBoxUserName.Text);
              setting.SaveUserName(textBoxPassword.Text);
              MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

            textBoxUserName.Text = ConfigurationManager.AppSettings["username"];
            textBoxPassword.Text = ConfigurationManager.AppSettings["password"];
        }
    }
}
