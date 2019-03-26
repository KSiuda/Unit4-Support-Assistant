namespace Unit4HomeOffice.Forms
{
    partial class ConsultantsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultantsForm));
            this.pictureBoxUNIT4 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonShutDown = new System.Windows.Forms.Button();
            this.labelHO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragControl1 = new Unit4HomeOffice.WorkClasses.DragControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUNIT4)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUNIT4
            // 
            this.pictureBoxUNIT4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxUNIT4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUNIT4.Image")));
            this.pictureBoxUNIT4.Location = new System.Drawing.Point(-3, 0);
            this.pictureBoxUNIT4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUNIT4.Name = "pictureBoxUNIT4";
            this.pictureBoxUNIT4.Size = new System.Drawing.Size(293, 130);
            this.pictureBoxUNIT4.TabIndex = 7;
            this.pictureBoxUNIT4.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Window;
            this.panelHeader.Controls.Add(this.button6);
            this.panelHeader.Controls.Add(this.buttonShutDown);
            this.panelHeader.Controls.Add(this.labelHO);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1367, 156);
            this.panelHeader.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1185, 4);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonShutDown
            // 
            this.buttonShutDown.BackColor = System.Drawing.Color.White;
            this.buttonShutDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShutDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonShutDown.Image")));
            this.buttonShutDown.Location = new System.Drawing.Point(1203, 4);
            this.buttonShutDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShutDown.Name = "buttonShutDown";
            this.buttonShutDown.Size = new System.Drawing.Size(161, 139);
            this.buttonShutDown.TabIndex = 4;
            this.buttonShutDown.Text = " ";
            this.buttonShutDown.UseVisualStyleBackColor = false;
            this.buttonShutDown.Click += new System.EventHandler(this.buttonShutDown_Click);
            // 
            // labelHO
            // 
            this.labelHO.AutoSize = true;
            this.labelHO.BackColor = System.Drawing.SystemColors.Window;
            this.labelHO.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelHO.Font = new System.Drawing.Font("Century Gothic", 28F);
            this.labelHO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(135)))), ((int)(((byte)(142)))));
            this.labelHO.Location = new System.Drawing.Point(575, 49);
            this.labelHO.Name = "labelHO";
            this.labelHO.Size = new System.Drawing.Size(290, 57);
            this.labelHO.TabIndex = 1;
            this.labelHO.Text = "Consultants";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelHeader;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(646, 235);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(89, 32);
            this.buttonImport.TabIndex = 9;
            this.buttonImport.Text = "Import data";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // ConsultantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 871);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.pictureBoxUNIT4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultantsForm";
            this.Text = "Consultants";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUNIT4)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxUNIT4;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonShutDown;
        private System.Windows.Forms.Label labelHO;
        public System.Windows.Forms.PictureBox pictureBox1;
        private WorkClasses.DragControl dragControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonImport;
    }
}