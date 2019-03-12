namespace Unit4HomeOffice
{
    partial class Main
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBoxUNIT4 = new System.Windows.Forms.PictureBox();
            this.labelHO = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonShutDown = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.salesforceLabel = new System.Windows.Forms.Label();
            this.labelMouse = new System.Windows.Forms.Label();
            this.monitorLabel = new System.Windows.Forms.Label();
            this.buttonSF = new System.Windows.Forms.Button();
            this.buttonRobot = new System.Windows.Forms.Button();
            this.buttonActiveCheck = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressLabel = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.casesListView = new System.Windows.Forms.ListView();
            this.inProgHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newcasesListView = new System.Windows.Forms.ListView();
            this.newHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removedCasesListView = new System.Windows.Forms.ListView();
            this.removedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dragControl1 = new Unit4HomeOffice.WorkClasses.DragControl();
            this.dragControl2 = new Unit4HomeOffice.WorkClasses.DragControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUNIT4)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxUNIT4
            // 
            this.pictureBoxUNIT4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxUNIT4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUNIT4.Image")));
            this.pictureBoxUNIT4.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUNIT4.Name = "pictureBoxUNIT4";
            this.pictureBoxUNIT4.Size = new System.Drawing.Size(294, 131);
            this.pictureBoxUNIT4.TabIndex = 0;
            this.pictureBoxUNIT4.TabStop = false;
            // 
            // labelHO
            // 
            this.labelHO.AutoSize = true;
            this.labelHO.BackColor = System.Drawing.SystemColors.Window;
            this.labelHO.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelHO.Font = new System.Drawing.Font("Century Gothic", 28F);
            this.labelHO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(135)))), ((int)(((byte)(142)))));
            this.labelHO.Location = new System.Drawing.Point(502, 38);
            this.labelHO.Name = "labelHO";
            this.labelHO.Size = new System.Drawing.Size(333, 45);
            this.labelHO.TabIndex = 1;
            this.labelHO.Text = "Support Assistant";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Window;
            this.panelHeader.Controls.Add(this.button6);
            this.panelHeader.Controls.Add(this.buttonOptions);
            this.panelHeader.Controls.Add(this.buttonShutDown);
            this.panelHeader.Controls.Add(this.labelHO);
            this.panelHeader.Controls.Add(this.pictureBoxUNIT4);
            this.panelHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1199, 133);
            this.panelHeader.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1045, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(20, 25);
            this.button6.TabIndex = 6;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonOptions.Image")));
            this.buttonOptions.Location = new System.Drawing.Point(314, 12);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(131, 111);
            this.buttonOptions.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buttonOptions, "Options");
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonShutDown
            // 
            this.buttonShutDown.BackColor = System.Drawing.Color.White;
            this.buttonShutDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShutDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonShutDown.Image")));
            this.buttonShutDown.Location = new System.Drawing.Point(1062, 12);
            this.buttonShutDown.Name = "buttonShutDown";
            this.buttonShutDown.Size = new System.Drawing.Size(126, 114);
            this.buttonShutDown.TabIndex = 4;
            this.buttonShutDown.Text = " ";
            this.buttonShutDown.UseVisualStyleBackColor = false;
            this.buttonShutDown.Click += new System.EventHandler(this.buttonShutDown_Click_1);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.salesforceLabel);
            this.panelLeft.Controls.Add(this.labelMouse);
            this.panelLeft.Controls.Add(this.monitorLabel);
            this.panelLeft.Controls.Add(this.buttonSF);
            this.panelLeft.Controls.Add(this.buttonRobot);
            this.panelLeft.Controls.Add(this.buttonActiveCheck);
            this.panelLeft.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 133);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 483);
            this.panelLeft.TabIndex = 3;
            // 
            // salesforceLabel
            // 
            this.salesforceLabel.AutoSize = true;
            this.salesforceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.salesforceLabel.Location = new System.Drawing.Point(56, 132);
            this.salesforceLabel.Name = "salesforceLabel";
            this.salesforceLabel.Size = new System.Drawing.Size(87, 21);
            this.salesforceLabel.TabIndex = 9;
            this.salesforceLabel.Text = "Logged in";
            this.salesforceLabel.Visible = false;
            // 
            // labelMouse
            // 
            this.labelMouse.AutoSize = true;
            this.labelMouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelMouse.Location = new System.Drawing.Point(38, 444);
            this.labelMouse.Name = "labelMouse";
            this.labelMouse.Size = new System.Drawing.Size(123, 21);
            this.labelMouse.TabIndex = 8;
            this.labelMouse.Text = "Mouse clicking";
            this.labelMouse.Visible = false;
            // 
            // monitorLabel
            // 
            this.monitorLabel.AutoSize = true;
            this.monitorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.monitorLabel.Location = new System.Drawing.Point(38, 269);
            this.monitorLabel.Name = "monitorLabel";
            this.monitorLabel.Size = new System.Drawing.Size(116, 21);
            this.monitorLabel.TabIndex = 7;
            this.monitorLabel.Text = "Check active";
            this.monitorLabel.Visible = false;
            // 
            // buttonSF
            // 
            this.buttonSF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSF.Image = ((System.Drawing.Image)(resources.GetObject("buttonSF.Image")));
            this.buttonSF.Location = new System.Drawing.Point(27, 6);
            this.buttonSF.Name = "buttonSF";
            this.buttonSF.Size = new System.Drawing.Size(144, 123);
            this.buttonSF.TabIndex = 2;
            this.buttonSF.Text = " ";
            this.buttonSF.UseVisualStyleBackColor = true;
            this.buttonSF.Click += new System.EventHandler(this.buttonSF_Click);
            // 
            // buttonRobot
            // 
            this.buttonRobot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRobot.Image = ((System.Drawing.Image)(resources.GetObject("buttonRobot.Image")));
            this.buttonRobot.Location = new System.Drawing.Point(27, 304);
            this.buttonRobot.Name = "buttonRobot";
            this.buttonRobot.Size = new System.Drawing.Size(144, 137);
            this.buttonRobot.TabIndex = 1;
            this.buttonRobot.Text = " ";
            this.toolTip1.SetToolTip(this.buttonRobot, "Click my left mouse button every 5 seconds, so I can pretend I\'m online!");
            this.buttonRobot.UseVisualStyleBackColor = true;
            this.buttonRobot.Click += new System.EventHandler(this.buttonRobot_Click);
            // 
            // buttonActiveCheck
            // 
            this.buttonActiveCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActiveCheck.Image = ((System.Drawing.Image)(resources.GetObject("buttonActiveCheck.Image")));
            this.buttonActiveCheck.Location = new System.Drawing.Point(27, 159);
            this.buttonActiveCheck.Name = "buttonActiveCheck";
            this.buttonActiveCheck.Size = new System.Drawing.Size(144, 107);
            this.buttonActiveCheck.TabIndex = 0;
            this.buttonActiveCheck.Text = " ";
            this.buttonActiveCheck.UseVisualStyleBackColor = true;
            this.buttonActiveCheck.Click += new System.EventHandler(this.buttonActiveCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "In Progress";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.progressLabel);
            this.panel3.Controls.Add(this.mainLabel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(999, 100);
            this.panel3.TabIndex = 5;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(149, 38);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(20, 21);
            this.progressLabel.TabIndex = 6;
            this.progressLabel.Text = "--";
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mainLabel.Location = new System.Drawing.Point(387, 3);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(199, 21);
            this.mainLabel.TabIndex = 5;
            this.mainLabel.Text = "Case Queue Dashboard";
            // 
            // casesListView
            // 
            this.casesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.inProgHeader});
            this.casesListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.casesListView.Location = new System.Drawing.Point(200, 233);
            this.casesListView.Name = "casesListView";
            this.casesListView.Size = new System.Drawing.Size(169, 383);
            this.casesListView.TabIndex = 6;
            this.casesListView.UseCompatibleStateImageBehavior = false;
            this.casesListView.View = System.Windows.Forms.View.Details;
            // 
            // inProgHeader
            // 
            this.inProgHeader.Text = "In Progress Cases";
            this.inProgHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inProgHeader.Width = 165;
            // 
            // newcasesListView
            // 
            this.newcasesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.newHeader});
            this.newcasesListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.newcasesListView.Location = new System.Drawing.Point(369, 233);
            this.newcasesListView.Name = "newcasesListView";
            this.newcasesListView.Size = new System.Drawing.Size(169, 383);
            this.newcasesListView.TabIndex = 7;
            this.newcasesListView.UseCompatibleStateImageBehavior = false;
            this.newcasesListView.View = System.Windows.Forms.View.Details;
            // 
            // newHeader
            // 
            this.newHeader.Text = "New in Progress";
            this.newHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newHeader.Width = 163;
            // 
            // removedCasesListView
            // 
            this.removedCasesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.removedHeader});
            this.removedCasesListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.removedCasesListView.Location = new System.Drawing.Point(538, 233);
            this.removedCasesListView.Name = "removedCasesListView";
            this.removedCasesListView.Size = new System.Drawing.Size(165, 383);
            this.removedCasesListView.TabIndex = 8;
            this.removedCasesListView.UseCompatibleStateImageBehavior = false;
            this.removedCasesListView.View = System.Windows.Forms.View.Details;
            // 
            // removedHeader
            // 
            this.removedHeader.Text = "Gone from Progress";
            this.removedHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.removedHeader.Width = 161;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelHeader;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.panelLeft;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(201)))), ((int)(((byte)(22)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1199, 616);
            this.Controls.Add(this.removedCasesListView);
            this.Controls.Add(this.newcasesListView);
            this.Controls.Add(this.casesListView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unit4 HomeOffice";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUNIT4)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxUNIT4;
        private System.Windows.Forms.Label labelHO;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonRobot;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonActiveCheck;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button buttonShutDown;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonSF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label mainLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private WorkClasses.DragControl dragControl1;
        private WorkClasses.DragControl dragControl2;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.Label monitorLabel;
        public System.Windows.Forms.Label labelMouse;
        public System.Windows.Forms.Label salesforceLabel;
        public System.Windows.Forms.ListView casesListView;
        private System.Windows.Forms.ColumnHeader inProgHeader;
        public System.Windows.Forms.ListView newcasesListView;
        private System.Windows.Forms.ColumnHeader newHeader;
        public System.Windows.Forms.ListView removedCasesListView;
        private System.Windows.Forms.ColumnHeader removedHeader;
    }
}

