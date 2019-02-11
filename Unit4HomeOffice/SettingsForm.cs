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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              _setting.SaveUserName(textBoxUserName.Text);
              _setting.SavePassword(textBoxPassword.Text);
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
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                _setting.SaveBrowserSettings("Chrome");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                _setting.SaveBrowserSettings("Firefox");
            }
        }
    }
}
