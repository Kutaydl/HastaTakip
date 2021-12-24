
namespace HastaTakip
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.randevularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahlillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPageMenu = new System.Windows.Forms.MenuStrip();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turkishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDate = new System.Windows.Forms.Label();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.reportEx = new System.Windows.Forms.PictureBox();
            this.pictureBoxAnaly = new System.Windows.Forms.PictureBox();
            this.gridTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridAppo = new System.Windows.Forms.DataGridView();
            this.mainPageMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnaly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppo)).BeginInit();
            this.SuspendLayout();
            // 
            // randevularToolStripMenuItem
            // 
            this.randevularToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F);
            this.randevularToolStripMenuItem.Name = "randevularToolStripMenuItem";
            this.randevularToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.randevularToolStripMenuItem.Text = "Appointments";
            this.randevularToolStripMenuItem.Click += new System.EventHandler(this.randevularToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F);
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.raporToolStripMenuItem.Text = "Reports";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // tahlillerToolStripMenuItem
            // 
            this.tahlillerToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F);
            this.tahlillerToolStripMenuItem.Name = "tahlillerToolStripMenuItem";
            this.tahlillerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.tahlillerToolStripMenuItem.Text = "Analyzes";
            this.tahlillerToolStripMenuItem.Click += new System.EventHandler(this.tahlillerToolStripMenuItem_Click);
            // 
            // mainPageMenu
            // 
            this.mainPageMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevularToolStripMenuItem,
            this.raporToolStripMenuItem,
            this.tahlillerToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.mainPageMenu.Location = new System.Drawing.Point(0, 0);
            this.mainPageMenu.Name = "mainPageMenu";
            this.mainPageMenu.Size = new System.Drawing.Size(700, 24);
            this.mainPageMenu.TabIndex = 0;
            this.mainPageMenu.Text = "mainPageStrip";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatientToolStripMenuItem,
            this.selectPatientToolStripMenuItem});
            this.patientToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F);
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // addPatientToolStripMenuItem
            // 
            this.addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            this.addPatientToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addPatientToolStripMenuItem.Text = "Add Patient";
            this.addPatientToolStripMenuItem.Click += new System.EventHandler(this.addPatientToolStripMenuItem_Click);
            // 
            // selectPatientToolStripMenuItem
            // 
            this.selectPatientToolStripMenuItem.Name = "selectPatientToolStripMenuItem";
            this.selectPatientToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.selectPatientToolStripMenuItem.Text = "Select Patient";
            this.selectPatientToolStripMenuItem.Click += new System.EventHandler(this.selectPatientToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitAplicationToolStripMenuItem});
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F);
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitAplicationToolStripMenuItem
            // 
            this.exitAplicationToolStripMenuItem.Name = "exitAplicationToolStripMenuItem";
            this.exitAplicationToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitAplicationToolStripMenuItem.Text = "Exit Application";
            this.exitAplicationToolStripMenuItem.Click += new System.EventHandler(this.exitAplicationToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turkishToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F);
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // turkishToolStripMenuItem
            // 
            this.turkishToolStripMenuItem.Name = "turkishToolStripMenuItem";
            this.turkishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.turkishToolStripMenuItem.Text = "Turkish";
            this.turkishToolStripMenuItem.Click += new System.EventHandler(this.turkishToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDate.Location = new System.Drawing.Point(627, 39);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(73, 26);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "01/01/0001\r\n01:01:01";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Interval = 1000;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // reportEx
            // 
            this.reportEx.Image = ((System.Drawing.Image)(resources.GetObject("reportEx.Image")));
            this.reportEx.Location = new System.Drawing.Point(12, 39);
            this.reportEx.Name = "reportEx";
            this.reportEx.Size = new System.Drawing.Size(407, 500);
            this.reportEx.TabIndex = 2;
            this.reportEx.TabStop = false;
            this.reportEx.Visible = false;
            // 
            // pictureBoxAnaly
            // 
            this.pictureBoxAnaly.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAnaly.Image")));
            this.pictureBoxAnaly.Location = new System.Drawing.Point(12, 39);
            this.pictureBoxAnaly.Name = "pictureBoxAnaly";
            this.pictureBoxAnaly.Size = new System.Drawing.Size(407, 500);
            this.pictureBoxAnaly.TabIndex = 4;
            this.pictureBoxAnaly.TabStop = false;
            this.pictureBoxAnaly.Visible = false;
            // 
            // gridTime
            // 
            this.gridTime.FillWeight = 150F;
            this.gridTime.HeaderText = "Time";
            this.gridTime.Name = "gridTime";
            this.gridTime.ReadOnly = true;
            this.gridTime.Width = 120;
            // 
            // gridDate
            // 
            this.gridDate.FillWeight = 150F;
            this.gridDate.HeaderText = "Date";
            this.gridDate.Name = "gridDate";
            this.gridDate.ReadOnly = true;
            this.gridDate.Width = 120;
            // 
            // gridDoc
            // 
            this.gridDoc.FillWeight = 150F;
            this.gridDoc.HeaderText = "Doktor";
            this.gridDoc.Name = "gridDoc";
            this.gridDoc.ReadOnly = true;
            this.gridDoc.Width = 120;
            // 
            // dataGridAppo
            // 
            this.dataGridAppo.AllowUserToAddRows = false;
            this.dataGridAppo.AllowUserToDeleteRows = false;
            this.dataGridAppo.AllowUserToResizeColumns = false;
            this.dataGridAppo.AllowUserToResizeRows = false;
            this.dataGridAppo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAppo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridDoc,
            this.gridDate,
            this.gridTime});
            this.dataGridAppo.Location = new System.Drawing.Point(12, 39);
            this.dataGridAppo.Name = "dataGridAppo";
            this.dataGridAppo.ReadOnly = true;
            this.dataGridAppo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridAppo.Size = new System.Drawing.Size(406, 213);
            this.dataGridAppo.TabIndex = 3;
            this.dataGridAppo.Visible = false;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 356);
            this.Controls.Add(this.dataGridAppo);
            this.Controls.Add(this.reportEx);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.mainPageMenu);
            this.Controls.Add(this.pictureBoxAnaly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.mainPageMenu.ResumeLayout(false);
            this.mainPageMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnaly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem randevularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahlillerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainPageMenu;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turkishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAplicationToolStripMenuItem;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.PictureBox reportEx;
        private System.Windows.Forms.PictureBox pictureBoxAnaly;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDoc;
        private System.Windows.Forms.DataGridView dataGridAppo;
    }
}