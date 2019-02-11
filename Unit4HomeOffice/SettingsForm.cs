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
        AppSetting _setting;

        public SettingsForm(AppSetting setting)
        {
            InitializeComponent();
            _setting = setting;
            if (_setting.GetBrowserSettings() == "Firefox")
            {
                checkBoxFirefox.Checked = true;
            }
            else if(_setting.GetBrowserSettings() == "Chrome")
            {
                checkBoxChrome.Checked = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxChrome.Checked)
                {
                    _setting.SaveBrowserSettings("Chrome");
                }
                else if (checkBoxFirefox.Checked)
                {
                    _setting.SaveBrowserSettings("Firefox");
                }

              _setting.SaveUserName(textBoxUserName.Text);
              _setting.SavePassword(textBoxPassword.Text);
                int minutes = Int32.Parse(intervalTextBox.Text) * 60000;
              _setting.SaveInterval(minutes.ToString());
              MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

            textBoxUserName.Text = _setting.GetUserName();
            textBoxPassword.Text = _setting.GetPassword();
            intervalTextBox.Text = (_setting.GetInterval() / 60000).ToString();
        }

        private void checkBoxFirefox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFirefox.Checked == true)
            {
                checkBoxChrome.Checked = false;
                
            }

        }

        private void checkBoxChrome_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChrome.Checked == true)
            {
                checkBoxFirefox.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
