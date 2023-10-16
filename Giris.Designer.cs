
namespace HastaTakip
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.labelTC = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.exitbutt = new System.Windows.Forms.PictureBox();
            this.exitbuttnor = new System.Windows.Forms.PictureBox();
            this.labelWrong = new System.Windows.Forms.Label();
            this.changePass = new System.Windows.Forms.Label();
            this.passwrCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.languageSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.buttonSign = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxId = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.labelCountdown = new System.Windows.Forms.Label();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.pictureLoad = new System.Windows.Forms.PictureBox();
            this.labelLoad = new System.Windows.Forms.Label();
            this.formShape = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.exitbutt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbuttnor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Location = new System.Drawing.Point(68, 45);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(107, 13);
            this.labelTC.TabIndex = 2;
            this.labelTC.Text = "Identification Number";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(68, 94);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // exitbutt
            // 
            this.exitbutt.Image = ((System.Drawing.Image)(resources.GetObject("exitbutt.Image")));
            this.exitbutt.Location = new System.Drawing.Point(301, 0);
            this.exitbutt.Name = "exitbutt";
            this.exitbutt.Size = new System.Drawing.Size(40, 20);
            this.exitbutt.TabIndex = 7;
            this.exitbutt.TabStop = false;
            this.exitbutt.Click += new System.EventHandler(this.exitbutt_Click);
            this.exitbutt.MouseLeave += new System.EventHandler(this.exitbutt_MouseLeave);
            // 
            // exitbuttnor
            // 
            this.exitbuttnor.Image = ((System.Drawing.Image)(resources.GetObject("exitbuttnor.Image")));
            this.exitbuttnor.Location = new System.Drawing.Point(301, 0);
            this.exitbuttnor.Name = "exitbuttnor";
            this.exitbuttnor.Size = new System.Drawing.Size(40, 20);
            this.exitbuttnor.TabIndex = 8;
            this.exitbuttnor.TabStop = false;
            this.exitbuttnor.MouseHover += new System.EventHandler(this.exitbuttnor_MouseHover);
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.ForeColor = System.Drawing.Color.Red;
            this.labelWrong.Location = new System.Drawing.Point(68, 133);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(137, 13);
            this.labelWrong.TabIndex = 11;
            this.labelWrong.Text = "Wrong number or password";
            this.labelWrong.Visible = false;
            // 
            // changePass
            // 
            this.changePass.AutoSize = true;
            this.changePass.ForeColor = System.Drawing.Color.DimGray;
            this.changePass.Location = new System.Drawing.Point(172, 94);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(91, 13);
            this.changePass.TabIndex = 12;
            this.changePass.Text = "Forgot password?";
            this.changePass.Click += new System.EventHandler(this.changePass_Click);
            this.changePass.MouseLeave += new System.EventHandler(this.changePass_MouseLeave);
            this.changePass.MouseHover += new System.EventHandler(this.changePass_MouseHover);
            // 
            // passwrCheck
            // 
            this.passwrCheck.AutoSize = true;
            this.passwrCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwrCheck.CheckedState.BorderRadius = 0;
            this.passwrCheck.CheckedState.BorderThickness = 0;
            this.passwrCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwrCheck.Location = new System.Drawing.Point(248, 113);
            this.passwrCheck.Name = "passwrCheck";
            this.passwrCheck.Size = new System.Drawing.Size(15, 14);
            this.passwrCheck.TabIndex = 13;
            this.passwrCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.passwrCheck.UncheckedState.BorderRadius = 0;
            this.passwrCheck.UncheckedState.BorderThickness = 0;
            this.passwrCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.passwrCheck.CheckedChanged += new System.EventHandler(this.passwrCheck_CheckedChanged);
            // 
            // languageSwitch
            // 
            this.languageSwitch.Animated = true;
            this.languageSwitch.BackColor = System.Drawing.Color.Transparent;
            this.languageSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.languageSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.languageSwitch.CheckedState.Parent = this.languageSwitch;
            this.languageSwitch.Location = new System.Drawing.Point(149, 201);
            this.languageSwitch.Name = "languageSwitch";
            this.languageSwitch.ShadowDecoration.Parent = this.languageSwitch;
            this.languageSwitch.Size = new System.Drawing.Size(35, 17);
            this.languageSwitch.TabIndex = 14;
            this.languageSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.languageSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.languageSwitch.UncheckedState.Parent = this.languageSwitch;
            this.languageSwitch.UseTransparentBackground = true;
            this.languageSwitch.CheckedChanged += new System.EventHandler(this.languageSwitch_CheckedChanged);
            // 
            // buttonSign
            // 
            this.buttonSign.Animated = true;
            this.buttonSign.AutoRoundedCorners = true;
            this.buttonSign.BackColor = System.Drawing.Color.Transparent;
            this.buttonSign.BorderRadius = 13;
            this.buttonSign.CheckedState.Parent = this.buttonSign;
            this.buttonSign.CustomImages.Parent = this.buttonSign;
            this.buttonSign.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSign.DisabledState.Parent = this.buttonSign;
            this.buttonSign.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSign.ForeColor = System.Drawing.Color.White;
            this.buttonSign.HoverState.Parent = this.buttonSign;
            this.buttonSign.Location = new System.Drawing.Point(171, 158);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.ShadowDecoration.BorderRadius = 10;
            this.buttonSign.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.buttonSign.ShadowDecoration.Enabled = true;
            this.buttonSign.ShadowDecoration.Parent = this.buttonSign;
            this.buttonSign.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.buttonSign.Size = new System.Drawing.Size(92, 28);
            this.buttonSign.TabIndex = 4;
            this.buttonSign.Text = "Sign in";
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Animated = true;
            this.buttonLogin.AutoRoundedCorners = true;
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BorderRadius = 13;
            this.buttonLogin.CheckedState.Parent = this.buttonLogin;
            this.buttonLogin.CustomImages.Parent = this.buttonLogin;
            this.buttonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLogin.DisabledState.Parent = this.buttonLogin;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.HoverState.Parent = this.buttonLogin;
            this.buttonLogin.Location = new System.Drawing.Point(71, 158);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.ShadowDecoration.BorderRadius = 10;
            this.buttonLogin.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.buttonLogin.ShadowDecoration.Enabled = true;
            this.buttonLogin.ShadowDecoration.Parent = this.buttonLogin;
            this.buttonLogin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.buttonLogin.Size = new System.Drawing.Size(92, 28);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // textBoxId
            // 
            this.textBoxId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxId.DefaultText = "";
            this.textBoxId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxId.DisabledState.Parent = this.textBoxId;
            this.textBoxId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxId.FocusedState.Parent = this.textBoxId;
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxId.ForeColor = System.Drawing.Color.Black;
            this.textBoxId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxId.HoverState.Parent = this.textBoxId;
            this.textBoxId.Location = new System.Drawing.Point(71, 61);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.PasswordChar = '\0';
            this.textBoxId.PlaceholderText = "";
            this.textBoxId.SelectedText = "";
            this.textBoxId.ShadowDecoration.Parent = this.textBoxId;
            this.textBoxId.Size = new System.Drawing.Size(192, 20);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxId_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.Parent = this.textBoxPassword;
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.FocusedState.Parent = this.textBoxPassword;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.HoverState.Parent = this.textBoxPassword;
            this.textBoxPassword.Location = new System.Drawing.Point(71, 110);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '\0';
            this.textBoxPassword.PlaceholderText = "";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.ShadowDecoration.Parent = this.textBoxPassword;
            this.textBoxPassword.Size = new System.Drawing.Size(172, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // labelCountdown
            // 
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.Location = new System.Drawing.Point(68, 133);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(19, 13);
            this.labelCountdown.TabIndex = 15;
            this.labelCountdown.Text = "20";
            this.labelCountdown.Visible = false;
            // 
            // timerLoad
            // 
            this.timerLoad.Interval = 1000;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // pictureLoad
            // 
            this.pictureLoad.BackColor = System.Drawing.Color.Transparent;
            this.pictureLoad.Image = ((System.Drawing.Image)(resources.GetObject("pictureLoad.Image")));
            this.pictureLoad.Location = new System.Drawing.Point(95, 27);
            this.pictureLoad.Name = "pictureLoad";
            this.pictureLoad.Size = new System.Drawing.Size(150, 146);
            this.pictureLoad.TabIndex = 16;
            this.pictureLoad.TabStop = false;
            this.pictureLoad.Click += new System.EventHandler(this.pictureLoad_Click);
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Font = new System.Drawing.Font("Verdana", 20F);
            this.labelLoad.ForeColor = System.Drawing.Color.Teal;
            this.labelLoad.Location = new System.Drawing.Point(107, 176);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(137, 32);
            this.labelLoad.TabIndex = 17;
            this.labelLoad.Text = "Welcome";
            // 
            // formShape
            // 
            this.formShape.BorderRadius = 0;
            this.formShape.TargetControl = this;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(340, 230);
            this.Controls.Add(this.labelCountdown);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.languageSwitch);
            this.Controls.Add(this.passwrCheck);
            this.Controls.Add(this.changePass);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.exitbuttnor);
            this.Controls.Add(this.exitbutt);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.pictureLoad);
            this.Controls.Add(this.labelLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitbutt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbuttnor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox exitbutt;
        private System.Windows.Forms.PictureBox exitbuttnor;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Label changePass;
        private Guna.UI2.WinForms.Guna2CheckBox passwrCheck;
        private Guna.UI2.WinForms.Guna2ToggleSwitch languageSwitch;
        private Guna.UI2.WinForms.Guna2Button buttonSign;
        private Guna.UI2.WinForms.Guna2Button buttonLogin;
        private Guna.UI2.WinForms.Guna2TextBox textBoxId;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.Label labelCountdown;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.PictureBox pictureLoad;
        private System.Windows.Forms.Label labelLoad;
        private Guna.UI2.WinForms.Guna2Elipse formShape;
    }
}

