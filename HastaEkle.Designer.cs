
namespace HastaTakip
{
    partial class HastaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaEkle));
            this.labelHastaEkName = new System.Windows.Forms.Label();
            this.labelHastaEkSurname = new System.Windows.Forms.Label();
            this.labelHastaEkEmail = new System.Windows.Forms.Label();
            this.checkPicture = new System.Windows.Forms.PictureBox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.timerNum = new System.Windows.Forms.Timer(this.components);
            this.hastaEkName = new Guna.UI2.WinForms.Guna2TextBox();
            this.hastaEkSurname = new Guna.UI2.WinForms.Guna2TextBox();
            this.hastaEkEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonHasCancel = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSave = new Guna.UI2.WinForms.Guna2Button();
            this.labelN = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.hastaEkId = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelHastaEkId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checkPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHastaEkName
            // 
            this.labelHastaEkName.AutoSize = true;
            this.labelHastaEkName.Location = new System.Drawing.Point(109, 38);
            this.labelHastaEkName.Name = "labelHastaEkName";
            this.labelHastaEkName.Size = new System.Drawing.Size(35, 13);
            this.labelHastaEkName.TabIndex = 1;
            this.labelHastaEkName.Text = "Name";
            // 
            // labelHastaEkSurname
            // 
            this.labelHastaEkSurname.AutoSize = true;
            this.labelHastaEkSurname.Location = new System.Drawing.Point(109, 77);
            this.labelHastaEkSurname.Name = "labelHastaEkSurname";
            this.labelHastaEkSurname.Size = new System.Drawing.Size(49, 13);
            this.labelHastaEkSurname.TabIndex = 3;
            this.labelHastaEkSurname.Text = "Surname";
            // 
            // labelHastaEkEmail
            // 
            this.labelHastaEkEmail.AutoSize = true;
            this.labelHastaEkEmail.Location = new System.Drawing.Point(109, 177);
            this.labelHastaEkEmail.Name = "labelHastaEkEmail";
            this.labelHastaEkEmail.Size = new System.Drawing.Size(32, 13);
            this.labelHastaEkEmail.TabIndex = 7;
            this.labelHastaEkEmail.Text = "Email";
            // 
            // checkPicture
            // 
            this.checkPicture.BackColor = System.Drawing.Color.Transparent;
            this.checkPicture.Image = ((System.Drawing.Image)(resources.GetObject("checkPicture.Image")));
            this.checkPicture.Location = new System.Drawing.Point(119, 38);
            this.checkPicture.Name = "checkPicture";
            this.checkPicture.Size = new System.Drawing.Size(150, 150);
            this.checkPicture.TabIndex = 16;
            this.checkPicture.TabStop = false;
            this.checkPicture.Visible = false;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelRegister.ForeColor = System.Drawing.Color.Teal;
            this.labelRegister.Location = new System.Drawing.Point(91, 204);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(203, 25);
            this.labelRegister.TabIndex = 17;
            this.labelRegister.Text = "Patient was registered";
            this.labelRegister.Visible = false;
            // 
            // timerNum
            // 
            this.timerNum.Interval = 1000;
            this.timerNum.Tick += new System.EventHandler(this.timerNum_Tick);
            // 
            // hastaEkName
            // 
            this.hastaEkName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hastaEkName.DefaultText = "";
            this.hastaEkName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hastaEkName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hastaEkName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hastaEkName.DisabledState.Parent = this.hastaEkName;
            this.hastaEkName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hastaEkName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hastaEkName.FocusedState.Parent = this.hastaEkName;
            this.hastaEkName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hastaEkName.ForeColor = System.Drawing.Color.Black;
            this.hastaEkName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hastaEkName.HoverState.Parent = this.hastaEkName;
            this.hastaEkName.Location = new System.Drawing.Point(112, 54);
            this.hastaEkName.Name = "hastaEkName";
            this.hastaEkName.PasswordChar = '\0';
            this.hastaEkName.PlaceholderText = "";
            this.hastaEkName.SelectedText = "";
            this.hastaEkName.ShadowDecoration.Parent = this.hastaEkName;
            this.hastaEkName.Size = new System.Drawing.Size(163, 20);
            this.hastaEkName.TabIndex = 1;
            // 
            // hastaEkSurname
            // 
            this.hastaEkSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hastaEkSurname.DefaultText = "";
            this.hastaEkSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hastaEkSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hastaEkSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hastaEkSurname.DisabledState.Parent = this.hastaEkSurname;
            this.hastaEkSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hastaEkSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hastaEkSurname.FocusedState.Parent = this.hastaEkSurname;
            this.hastaEkSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hastaEkSurname.ForeColor = System.Drawing.Color.Black;
            this.hastaEkSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hastaEkSurname.HoverState.Parent = this.hastaEkSurname;
            this.hastaEkSurname.Location = new System.Drawing.Point(112, 93);
            this.hastaEkSurname.Name = "hastaEkSurname";
            this.hastaEkSurname.PasswordChar = '\0';
            this.hastaEkSurname.PlaceholderText = "";
            this.hastaEkSurname.SelectedText = "";
            this.hastaEkSurname.ShadowDecoration.Parent = this.hastaEkSurname;
            this.hastaEkSurname.Size = new System.Drawing.Size(163, 20);
            this.hastaEkSurname.TabIndex = 2;
            // 
            // hastaEkEmail
            // 
            this.hastaEkEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hastaEkEmail.DefaultText = "";
            this.hastaEkEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hastaEkEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hastaEkEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hastaEkEmail.DisabledState.Parent = this.hastaEkEmail;
            this.hastaEkEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hastaEkEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hastaEkEmail.FocusedState.Parent = this.hastaEkEmail;
            this.hastaEkEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hastaEkEmail.ForeColor = System.Drawing.Color.Black;
            this.hastaEkEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hastaEkEmail.HoverState.Parent = this.hastaEkEmail;
            this.hastaEkEmail.Location = new System.Drawing.Point(112, 191);
            this.hastaEkEmail.Name = "hastaEkEmail";
            this.hastaEkEmail.PasswordChar = '\0';
            this.hastaEkEmail.PlaceholderText = "";
            this.hastaEkEmail.SelectedText = "";
            this.hastaEkEmail.ShadowDecoration.Parent = this.hastaEkEmail;
            this.hastaEkEmail.Size = new System.Drawing.Size(163, 20);
            this.hastaEkEmail.TabIndex = 4;
            // 
            // buttonHasCancel
            // 
            this.buttonHasCancel.Animated = true;
            this.buttonHasCancel.AutoRoundedCorners = true;
            this.buttonHasCancel.BorderRadius = 10;
            this.buttonHasCancel.CheckedState.Parent = this.buttonHasCancel;
            this.buttonHasCancel.CustomImages.Parent = this.buttonHasCancel;
            this.buttonHasCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonHasCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonHasCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonHasCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonHasCancel.DisabledState.Parent = this.buttonHasCancel;
            this.buttonHasCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHasCancel.ForeColor = System.Drawing.Color.White;
            this.buttonHasCancel.HoverState.FillColor = System.Drawing.Color.Red;
            this.buttonHasCancel.HoverState.Parent = this.buttonHasCancel;
            this.buttonHasCancel.Location = new System.Drawing.Point(200, 235);
            this.buttonHasCancel.Name = "buttonHasCancel";
            this.buttonHasCancel.ShadowDecoration.Parent = this.buttonHasCancel;
            this.buttonHasCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonHasCancel.TabIndex = 22;
            this.buttonHasCancel.Text = "Cancel";
            this.buttonHasCancel.Click += new System.EventHandler(this.buttonHasCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Animated = true;
            this.buttonSave.AutoRoundedCorners = true;
            this.buttonSave.BorderRadius = 10;
            this.buttonSave.CheckedState.Parent = this.buttonSave;
            this.buttonSave.CustomImages.Parent = this.buttonSave;
            this.buttonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSave.DisabledState.Parent = this.buttonSave;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.HoverState.Parent = this.buttonSave;
            this.buttonSave.Location = new System.Drawing.Point(112, 235);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.ShadowDecoration.Parent = this.buttonSave;
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Save";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelN.ForeColor = System.Drawing.Color.Red;
            this.labelN.Location = new System.Drawing.Point(281, 54);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(15, 20);
            this.labelN.TabIndex = 25;
            this.labelN.Text = "*";
            this.labelN.Visible = false;
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelS.ForeColor = System.Drawing.Color.Red;
            this.labelS.Location = new System.Drawing.Point(281, 93);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(15, 20);
            this.labelS.TabIndex = 26;
            this.labelS.Text = "*";
            this.labelS.Visible = false;
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelE.ForeColor = System.Drawing.Color.Red;
            this.labelE.Location = new System.Drawing.Point(281, 191);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(15, 20);
            this.labelE.TabIndex = 28;
            this.labelE.Text = "*";
            this.labelE.Visible = false;
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelI.ForeColor = System.Drawing.Color.Red;
            this.labelI.Location = new System.Drawing.Point(279, 144);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(15, 20);
            this.labelI.TabIndex = 27;
            this.labelI.Text = "*";
            this.labelI.Visible = false;
            // 
            // hastaEkId
            // 
            this.hastaEkId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hastaEkId.DefaultText = "";
            this.hastaEkId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hastaEkId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hastaEkId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hastaEkId.DisabledState.Parent = this.hastaEkId;
            this.hastaEkId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hastaEkId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hastaEkId.FocusedState.Parent = this.hastaEkId;
            this.hastaEkId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hastaEkId.ForeColor = System.Drawing.Color.Black;
            this.hastaEkId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hastaEkId.HoverState.Parent = this.hastaEkId;
            this.hastaEkId.Location = new System.Drawing.Point(112, 144);
            this.hastaEkId.Name = "hastaEkId";
            this.hastaEkId.PasswordChar = '\0';
            this.hastaEkId.PlaceholderText = "";
            this.hastaEkId.SelectedText = "";
            this.hastaEkId.ShadowDecoration.Parent = this.hastaEkId;
            this.hastaEkId.Size = new System.Drawing.Size(163, 20);
            this.hastaEkId.TabIndex = 3;
            // 
            // labelHastaEkId
            // 
            this.labelHastaEkId.AutoSize = true;
            this.labelHastaEkId.Location = new System.Drawing.Point(109, 128);
            this.labelHastaEkId.Name = "labelHastaEkId";
            this.labelHastaEkId.Size = new System.Drawing.Size(107, 13);
            this.labelHastaEkId.TabIndex = 5;
            this.labelHastaEkId.Text = "Identification Number";
            // 
            // HastaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 289);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.labelI);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonHasCancel);
            this.Controls.Add(this.hastaEkEmail);
            this.Controls.Add(this.hastaEkId);
            this.Controls.Add(this.hastaEkSurname);
            this.Controls.Add(this.hastaEkName);
            this.Controls.Add(this.labelHastaEkEmail);
            this.Controls.Add(this.labelHastaEkId);
            this.Controls.Add(this.labelHastaEkSurname);
            this.Controls.Add(this.labelHastaEkName);
            this.Controls.Add(this.checkPicture);
            this.Controls.Add(this.labelRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaEkle";
            this.Load += new System.EventHandler(this.HastaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHastaEkName;
        private System.Windows.Forms.Label labelHastaEkSurname;
        private System.Windows.Forms.Label labelHastaEkEmail;
        private System.Windows.Forms.PictureBox checkPicture;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Timer timerNum;
        private Guna.UI2.WinForms.Guna2TextBox hastaEkName;
        private Guna.UI2.WinForms.Guna2TextBox hastaEkSurname;
        private Guna.UI2.WinForms.Guna2TextBox hastaEkEmail;
        private Guna.UI2.WinForms.Guna2Button buttonHasCancel;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelI;
        private Guna.UI2.WinForms.Guna2TextBox hastaEkId;
        private System.Windows.Forms.Label labelHastaEkId;
    }
}