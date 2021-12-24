
namespace HastaTakip
{
    partial class HastaSec
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
            this.dataGridHasta = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSelect = new Guna.UI2.WinForms.Guna2Button();
            this.languageSwi = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.HastaNumara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBlood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBirt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHasta
            // 
            this.dataGridHasta.AllowUserToAddRows = false;
            this.dataGridHasta.AllowUserToDeleteRows = false;
            this.dataGridHasta.AllowUserToResizeColumns = false;
            this.dataGridHasta.AllowUserToResizeRows = false;
            this.dataGridHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHasta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HastaNumara,
            this.hastaName,
            this.hastaSurname,
            this.patientGender,
            this.patientAge,
            this.patientHeight,
            this.patientWeight,
            this.patientBlood,
            this.patientBirt,
            this.hastaEmail});
            this.dataGridHasta.Location = new System.Drawing.Point(12, 12);
            this.dataGridHasta.Name = "dataGridHasta";
            this.dataGridHasta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridHasta.Size = new System.Drawing.Size(376, 246);
            this.dataGridHasta.TabIndex = 0;
            this.dataGridHasta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHasta_CellContentClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Animated = true;
            this.buttonCancel.AutoRoundedCorners = true;
            this.buttonCancel.BorderRadius = 11;
            this.buttonCancel.CheckedState.Parent = this.buttonCancel;
            this.buttonCancel.CustomImages.Parent = this.buttonCancel;
            this.buttonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCancel.DisabledState.Parent = this.buttonCancel;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.HoverState.FillColor = System.Drawing.Color.Red;
            this.buttonCancel.HoverState.Parent = this.buttonCancel;
            this.buttonCancel.Location = new System.Drawing.Point(277, 279);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.ShadowDecoration.Parent = this.buttonCancel;
            this.buttonCancel.Size = new System.Drawing.Size(111, 24);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Animated = true;
            this.buttonEdit.AutoRoundedCorners = true;
            this.buttonEdit.BorderRadius = 11;
            this.buttonEdit.CheckedState.Parent = this.buttonEdit;
            this.buttonEdit.CustomImages.Parent = this.buttonEdit;
            this.buttonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEdit.DisabledState.Parent = this.buttonEdit;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.HoverState.Parent = this.buttonEdit;
            this.buttonEdit.Location = new System.Drawing.Point(143, 279);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.ShadowDecoration.Parent = this.buttonEdit;
            this.buttonEdit.Size = new System.Drawing.Size(111, 24);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Animated = true;
            this.buttonSelect.AutoRoundedCorners = true;
            this.buttonSelect.BorderRadius = 11;
            this.buttonSelect.CheckedState.Parent = this.buttonSelect;
            this.buttonSelect.CustomImages.Parent = this.buttonSelect;
            this.buttonSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSelect.DisabledState.Parent = this.buttonSelect;
            this.buttonSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSelect.ForeColor = System.Drawing.Color.White;
            this.buttonSelect.HoverState.FillColor = System.Drawing.Color.Lime;
            this.buttonSelect.HoverState.Parent = this.buttonSelect;
            this.buttonSelect.Location = new System.Drawing.Point(12, 279);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.ShadowDecoration.Parent = this.buttonSelect;
            this.buttonSelect.Size = new System.Drawing.Size(111, 24);
            this.buttonSelect.TabIndex = 6;
            this.buttonSelect.Text = "Select";
            // 
            // languageSwi
            // 
            this.languageSwi.Animated = true;
            this.languageSwi.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.languageSwi.CheckedState.InnerColor = System.Drawing.Color.White;
            this.languageSwi.CheckedState.Parent = this.languageSwi;
            this.languageSwi.Location = new System.Drawing.Point(12, 313);
            this.languageSwi.Name = "languageSwi";
            this.languageSwi.ShadowDecoration.Parent = this.languageSwi;
            this.languageSwi.Size = new System.Drawing.Size(35, 17);
            this.languageSwi.TabIndex = 8;
            this.languageSwi.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.languageSwi.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.languageSwi.UncheckedState.Parent = this.languageSwi;
            this.languageSwi.CheckedChanged += new System.EventHandler(this.languageSwi_CheckedChanged);
            // 
            // HastaNumara
            // 
            this.HastaNumara.HeaderText = "Patient Number";
            this.HastaNumara.Name = "HastaNumara";
            this.HastaNumara.Width = 108;
            // 
            // hastaName
            // 
            this.hastaName.HeaderText = "Name";
            this.hastaName.Name = "hastaName";
            this.hastaName.Width = 75;
            // 
            // hastaSurname
            // 
            this.hastaSurname.HeaderText = "Surname";
            this.hastaSurname.Name = "hastaSurname";
            this.hastaSurname.Width = 75;
            // 
            // patientGender
            // 
            this.patientGender.HeaderText = "Gender";
            this.patientGender.Name = "patientGender";
            this.patientGender.Width = 75;
            // 
            // patientAge
            // 
            this.patientAge.HeaderText = "Age";
            this.patientAge.Name = "patientAge";
            // 
            // patientHeight
            // 
            this.patientHeight.HeaderText = "Height";
            this.patientHeight.Name = "patientHeight";
            // 
            // patientWeight
            // 
            this.patientWeight.HeaderText = "Weight";
            this.patientWeight.Name = "patientWeight";
            // 
            // patientBlood
            // 
            this.patientBlood.HeaderText = "Blood Group";
            this.patientBlood.Name = "patientBlood";
            // 
            // patientBirt
            // 
            this.patientBirt.HeaderText = "Date of Birth";
            this.patientBirt.Name = "patientBirt";
            // 
            // hastaEmail
            // 
            this.hastaEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hastaEmail.FillWeight = 150F;
            this.hastaEmail.HeaderText = "Email";
            this.hastaEmail.Name = "hastaEmail";
            this.hastaEmail.Width = 57;
            // 
            // HastaSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 339);
            this.Controls.Add(this.languageSwi);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridHasta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaSec";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHasta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHasta;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonSelect;
        private Guna.UI2.WinForms.Guna2ToggleSwitch languageSwi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaNumara;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientBlood;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientBirt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaEmail;
    }
}