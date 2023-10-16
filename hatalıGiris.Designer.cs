
namespace HastaTakip
{
    partial class hatalıGiris
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
            this.securityQuest = new Guna.UI2.WinForms.Guna2ComboBox();
            this.securityAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonAccept = new Guna.UI2.WinForms.Guna2Button();
            this.butonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.labelSecure = new System.Windows.Forms.Label();
            this.textBoxMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.languageSwi = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labelLang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // securityQuest
            // 
            this.securityQuest.BackColor = System.Drawing.Color.Transparent;
            this.securityQuest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.securityQuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.securityQuest.DropDownWidth = 250;
            this.securityQuest.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.securityQuest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.securityQuest.FocusedState.Parent = this.securityQuest;
            this.securityQuest.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.securityQuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.securityQuest.HoverState.Parent = this.securityQuest;
            this.securityQuest.ItemHeight = 30;
            this.securityQuest.Items.AddRange(new object[] {
            "İlk evcil hayvanınızın adı?",
            "İlk öğretmeninizin adı nedir?",
            "İlk arkadaşınızın adı nedir?",
            "İlk işiniz nedir?"});
            this.securityQuest.ItemsAppearance.Parent = this.securityQuest;
            this.securityQuest.Location = new System.Drawing.Point(50, 84);
            this.securityQuest.Name = "securityQuest";
            this.securityQuest.ShadowDecoration.Parent = this.securityQuest;
            this.securityQuest.Size = new System.Drawing.Size(240, 36);
            this.securityQuest.TabIndex = 0;
            this.securityQuest.SelectedIndexChanged += new System.EventHandler(this.securityQuest_SelectedIndexChanged);
            // 
            // securityAnswer
            // 
            this.securityAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.securityAnswer.DefaultText = "";
            this.securityAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.securityAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.securityAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.securityAnswer.DisabledState.Parent = this.securityAnswer;
            this.securityAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.securityAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.securityAnswer.FocusedState.Parent = this.securityAnswer;
            this.securityAnswer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.securityAnswer.ForeColor = System.Drawing.Color.Black;
            this.securityAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.securityAnswer.HoverState.Parent = this.securityAnswer;
            this.securityAnswer.Location = new System.Drawing.Point(50, 126);
            this.securityAnswer.Name = "securityAnswer";
            this.securityAnswer.PasswordChar = '\0';
            this.securityAnswer.PlaceholderText = "";
            this.securityAnswer.SelectedText = "";
            this.securityAnswer.ShadowDecoration.Parent = this.securityAnswer;
            this.securityAnswer.Size = new System.Drawing.Size(240, 20);
            this.securityAnswer.TabIndex = 1;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Animated = true;
            this.buttonAccept.AutoRoundedCorners = true;
            this.buttonAccept.BorderRadius = 10;
            this.buttonAccept.CheckedState.Parent = this.buttonAccept;
            this.buttonAccept.CustomImages.Parent = this.buttonAccept;
            this.buttonAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAccept.DisabledState.Parent = this.buttonAccept;
            this.buttonAccept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAccept.ForeColor = System.Drawing.Color.White;
            this.buttonAccept.HoverState.Parent = this.buttonAccept;
            this.buttonAccept.Location = new System.Drawing.Point(50, 200);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.ShadowDecoration.Parent = this.buttonAccept;
            this.buttonAccept.Size = new System.Drawing.Size(110, 23);
            this.buttonAccept.TabIndex = 2;
            this.buttonAccept.Text = "Send";
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // butonCancel
            // 
            this.butonCancel.Animated = true;
            this.butonCancel.AutoRoundedCorners = true;
            this.butonCancel.BorderRadius = 10;
            this.butonCancel.CheckedState.Parent = this.butonCancel;
            this.butonCancel.CustomImages.Parent = this.butonCancel;
            this.butonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butonCancel.DisabledState.Parent = this.butonCancel;
            this.butonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butonCancel.ForeColor = System.Drawing.Color.White;
            this.butonCancel.HoverState.FillColor = System.Drawing.Color.Red;
            this.butonCancel.HoverState.Parent = this.butonCancel;
            this.butonCancel.Location = new System.Drawing.Point(180, 200);
            this.butonCancel.Name = "butonCancel";
            this.butonCancel.ShadowDecoration.Parent = this.butonCancel;
            this.butonCancel.Size = new System.Drawing.Size(110, 23);
            this.butonCancel.TabIndex = 3;
            this.butonCancel.Text = "Cancel";
            this.butonCancel.Click += new System.EventHandler(this.butonCancel_Click);
            // 
            // labelSecure
            // 
            this.labelSecure.AutoSize = true;
            this.labelSecure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelSecure.Location = new System.Drawing.Point(36, 9);
            this.labelSecure.Name = "labelSecure";
            this.labelSecure.Size = new System.Drawing.Size(264, 62);
            this.labelSecure.TabIndex = 4;
            this.labelSecure.Text = "Select and answer \r\nthe security question";
            this.labelSecure.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMail.DefaultText = "";
            this.textBoxMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMail.DisabledState.Parent = this.textBoxMail;
            this.textBoxMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMail.FocusedState.Parent = this.textBoxMail;
            this.textBoxMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxMail.ForeColor = System.Drawing.Color.Black;
            this.textBoxMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMail.HoverState.Parent = this.textBoxMail;
            this.textBoxMail.Location = new System.Drawing.Point(50, 170);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.PasswordChar = '\0';
            this.textBoxMail.PlaceholderText = "";
            this.textBoxMail.SelectedText = "";
            this.textBoxMail.ShadowDecoration.Parent = this.textBoxMail;
            this.textBoxMail.Size = new System.Drawing.Size(240, 20);
            this.textBoxMail.TabIndex = 5;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(47, 154);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 6;
            this.labelMail.Text = "Mail";
            // 
            // languageSwi
            // 
            this.languageSwi.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.languageSwi.CheckedState.InnerColor = System.Drawing.Color.White;
            this.languageSwi.CheckedState.Parent = this.languageSwi;
            this.languageSwi.Location = new System.Drawing.Point(9, 225);
            this.languageSwi.Name = "languageSwi";
            this.languageSwi.ShadowDecoration.Parent = this.languageSwi;
            this.languageSwi.Size = new System.Drawing.Size(35, 16);
            this.languageSwi.TabIndex = 8;
            this.languageSwi.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.languageSwi.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.languageSwi.UncheckedState.Parent = this.languageSwi;
            this.languageSwi.CheckedChanged += new System.EventHandler(this.languageSwi_CheckedChanged);
            this.languageSwi.MouseLeave += new System.EventHandler(this.languageSwi_MouseLeave);
            this.languageSwi.MouseHover += new System.EventHandler(this.languageSwi_MouseHover);
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.BackColor = System.Drawing.Color.Transparent;
            this.labelLang.Location = new System.Drawing.Point(12, 205);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(55, 13);
            this.labelLang.TabIndex = 9;
            this.labelLang.Text = "Language";
            this.labelLang.Visible = false;
            // 
            // hatalıGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(340, 249);
            this.Controls.Add(this.labelLang);
            this.Controls.Add(this.languageSwi);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelSecure);
            this.Controls.Add(this.butonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.securityAnswer);
            this.Controls.Add(this.securityQuest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hatalıGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hatalıGiris";
            this.Load += new System.EventHandler(this.hatalıGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox securityQuest;
        private Guna.UI2.WinForms.Guna2TextBox securityAnswer;
        private Guna.UI2.WinForms.Guna2Button buttonAccept;
        private Guna.UI2.WinForms.Guna2Button butonCancel;
        private System.Windows.Forms.Label labelSecure;
        private Guna.UI2.WinForms.Guna2TextBox textBoxMail;
        private System.Windows.Forms.Label labelMail;
        private Guna.UI2.WinForms.Guna2ToggleSwitch languageSwi;
        private System.Windows.Forms.Label labelLang;
    }
}