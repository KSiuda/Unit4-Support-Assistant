using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unit4HomeOffice.Classes;
using Unit4HomeOffice.Entities;

namespace Unit4HomeOffice.Forms
{
    public partial class ConsultantsForm : Form
    {
        public Context context;
        string path;

        public ConsultantsForm(Context context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void buttonShutDown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = String.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 path = openFileDialog1.FileName;
            }

                using (context)
            {
                ExcelImport excelImport = new ExcelImport();
                excelImport.Import(context, path);
            }
        }

        private void ConsultantsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supportAssistantDataSet.Trainings' table. You can move, or remove it, as needed.
            this.trainingsTableAdapter.Fill(this.supportAssistantDataSet.Trainings);

        }
    }
}
