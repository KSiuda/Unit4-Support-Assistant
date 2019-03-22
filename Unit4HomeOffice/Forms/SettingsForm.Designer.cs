namespace Unit4HomeOffice
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.checkBoxFirefox = new System.Windows.Forms.CheckBox();
            this.checkBoxChrome = new System.Windows.Forms.CheckBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxUNIT4 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dragControl1 = new Unit4HomeOffice.WorkClasses.DragControl();
            this.dragControl2 = new Unit4HomeOffice.WorkClasses.DragControl();
            this.DispatcherSetupMainLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genericsTabTextBox = new System.Windows.Forms.TextBox();
            this.mainQueueTextBox = new System.Windows.Forms.TextBox();
            this.panelLeft.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUNIT4)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxFirefox
            // 
            this.checkBoxFirefox.AutoSize = true;
            this.checkBoxFirefox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxFirefox.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxFirefox.Image")));
            this.checkBoxFirefox.Location = new System.Drawing.Point(33, 234);
            this.checkBoxFirefox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxFirefox.Name = "checkBoxFirefox";
            this.checkBoxFirefox.Size = new System.Drawing.Size(138, 144);
            this.checkBoxFirefox.TabIndex = 0;
            this.checkBoxFirefox.Text = "use Firefox";
            this.checkBoxFirefox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxFirefox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBoxFirefox.UseVisualStyleBackColor = true;
            this.checkBoxFirefox.CheckedChanged += new System.EventHandler(this.checkBoxChrome_CheckedChanged);
            // 
            // checkBoxChrome
            // 
            this.checkBoxChrome.AutoSize = true;
            this.checkBoxChrome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChrome.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxChrome.Image")));
            this.checkBoxChrome.Location = new System.Drawing.Point(31, 32);
            this.checkBoxChrome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxChrome.Name = "checkBoxChrome";
            this.checkBoxChrome.Size = new System.Drawing.Size(140, 142);
            this.checkBoxChrome.TabIndex = 1;
            this.checkBoxChrome.Text = "use Chrome";
            this.checkBoxChrome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxChrome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBoxChrome.UseVisualStyleBackColor = true;
            this.checkBoxChrome.CheckedChanged += new System.EventHandler(this.checkBoxFirefox_CheckedChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(232, 183);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(173, 21);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "SalesForce Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(232, 218);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(167, 21);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "SalesForce Password";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.checkBoxChrome);
            this.panelLeft.Controls.Add(this.checkBoxFirefox);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(232, 440);
            this.panelLeft.TabIndex = 4;
            this.toolTip1.SetToolTip(this.panelLeft, "Select browser to run Salesforce");
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(423, 186);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(270, 20);
            this.textBoxUserName.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(423, 219);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(270, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalLabel.Location = new System.Drawing.Point(232, 149);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(373, 21);
            this.intervalLabel.TabIndex = 8;
            this.intervalLabel.Text = "Interval of checking for new cases (in minutes):";
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Location = new System.Drawing.Point(663, 154);
            this.intervalTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(30, 20);
            this.intervalTextBox.TabIndex = 9;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pictureBoxUNIT4);
            this.panelHeader.Controls.Add(this.button2);
            this.panelHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(232, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(623, 131);
            this.panelHeader.TabIndex = 10;
            // 
            // pictureBoxUNIT4
            // 
            this.pictureBoxUNIT4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxUNIT4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUNIT4.Image")));
            this.pictureBoxUNIT4.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUNIT4.Name = "pictureBoxUNIT4";
            this.pictureBoxUNIT4.Size = new System.Drawing.Size(294, 131);
            this.pictureBoxUNIT4.TabIndex = 6;
            this.pictureBoxUNIT4.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(494, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 114);
            this.button2.TabIndex = 5;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelHeader;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.panelLeft;
            // 
            // DispatcherSetupMainLabel
            // 
            this.DispatcherSetupMainLabel.AutoSize = true;
            this.DispatcherSetupMainLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DispatcherSetupMainLabel.Location = new System.Drawing.Point(448, 253);
            this.DispatcherSetupMainLabel.Name = "DispatcherSetupMainLabel";
            this.DispatcherSetupMainLabel.Size = new System.Drawing.Size(208, 21);
            this.DispatcherSetupMainLabel.TabIndex = 11;
            this.DispatcherSetupMainLabel.Text = "Dispatcher configuration:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Generics Tab number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Main queue tab number:";
            // 
            // genericsTabTextBox
            // 
            this.genericsTabTextBox.Location = new System.Drawing.Point(452, 302);
            this.genericsTabTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genericsTabTextBox.Name = "genericsTabTextBox";
            this.genericsTabTextBox.Size = new System.Drawing.Size(33, 20);
            this.genericsTabTextBox.TabIndex = 14;
            // 
            // mainQueueTextBox
            // 
            this.mainQueueTextBox.Location = new System.Drawing.Point(452, 336);
            this.mainQueueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainQueueTextBox.Name = "mainQueueTextBox";
            this.mainQueueTextBox.Size = new System.Drawing.Size(33, 20);
            this.mainQueueTextBox.TabIndex = 15;
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 440);
            this.Controls.Add(this.mainQueueTextBox);
            this.Controls.Add(this.genericsTabTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DispatcherSetupMainLabel);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.intervalTextBox);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUNIT4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxFirefox;
        private System.Windows.Forms.CheckBox checkBoxChrome;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.TextBox intervalTextBox;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.PictureBox pictureBoxUNIT4;
        private WorkClasses.DragControl dragControl1;
        private WorkClasses.DragControl dragControl2;
        private System.Windows.Forms.Label DispatcherSetupMainLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox genericsTabTextBox;
        private System.Windows.Forms.TextBox mainQueueTextBox;
    }
}