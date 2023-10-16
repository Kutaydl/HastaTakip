
namespace HastaTakip
{
    partial class Signin
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
            this.signInlabel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.idSign = new System.Windows.Forms.Label();
            this.signPassword = new System.Windows.Forms.Label();
            this.verifyPassword = new System.Windows.Forms.Label();
            this.notEqual = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxSurname = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxSignId = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxSignPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxVerifyPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkBoxSign = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBoxSignVerify = new Guna.UI2.WinForms.Guna2CheckBox();
            this.languageSwi = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.buttonSignfull = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.securityBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelSecure = new System.Windows.Forms.Label();
            this.secureAns = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelcheck = new System.Windows.Forms.Label();
            this.labelcheck1 = new System.Windows.Forms.Label();
            this.labelcheck2 = new System.Windows.Forms.Label();
            this.labelcheck3 = new System.Windows.Forms.Label();
            this.labelcheck5 = new System.Windows.Forms.Label();
            this.labelcheck6 = new System.Windows.Forms.Label();
            this.labelcheck7 = new System.Windows.Forms.Label();
            this.labelcheck8 = new System.Windows.Forms.Label();
            this.labelLang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signInlabel
            // 
            this.signInlabel.AutoSize = true;
            this.signInlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.signInlabel.Location = new System.Drawing.Point(113, 30);
            this.signInlabel.Name = "signInlabel";
            this.signInlabel.Size = new System.Drawing.Size(96, 31);
            this.signInlabel.TabIndex = 0;
            this.signInlabel.Text = "Sign in";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(47, 81);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // idSign
            // 
            this.idSign.AutoSize = true;
            this.idSign.Location = new System.Drawing.Point(47, 159);
            this.idSign.Name = "idSign";
            this.idSign.Size = new System.Drawing.Size(107, 13);
            this.idSign.TabIndex = 6;
            this.idSign.Text = "Identification Number";
            // 
            // signPassword
            // 
            this.signPassword.AutoSize = true;
            this.signPassword.Location = new System.Drawing.Point(47, 337);
            this.signPassword.Name = "signPassword";
            this.signPassword.Size = new System.Drawing.Size(53, 13);
            this.signPassword.TabIndex = 7;
            this.signPassword.Text = "Password";
            this.signPassword.Click += new System.EventHandler(this.signPassword_Click);
            // 
            // verifyPassword
            // 
            this.verifyPassword.AutoSize = true;
            this.verifyPassword.Location = new System.Drawing.Point(47, 376);
            this.verifyPassword.Name = "verifyPassword";
            this.verifyPassword.Size = new System.Drawing.Size(82, 13);
            this.verifyPassword.TabIndex = 8;
            this.verifyPassword.Text = "Verify Password";
            this.verifyPassword.Click += new System.EventHandler(this.verifyPassword_Click);
            // 
            // notEqual
            // 
            this.notEqual.AutoSize = true;
            this.notEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.notEqual.ForeColor = System.Drawing.Color.Red;
            this.notEqual.Location = new System.Drawing.Point(79, 415);
            this.notEqual.Name = "notEqual";
            this.notEqual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notEqual.Size = new System.Drawing.Size(201, 17);
            this.notEqual.TabIndex = 0;
            this.notEqual.Text = "your password does not match";
            this.notEqual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.notEqual.Visible = false;
            this.notEqual.Click += new System.EventHandler(this.notEqual_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(47, 120);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 15;
            this.labelSurname.Text = "Surname";
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.Parent = this.textBoxName;
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.FocusedState.Parent = this.textBoxName;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.HoverState.Parent = this.textBoxName;
            this.textBoxName.Location = new System.Drawing.Point(50, 97);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.SelectedText = "";
            this.textBoxName.ShadowDecoration.Parent = this.textBoxName;
            this.textBoxName.Size = new System.Drawing.Size(230, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSurname.DefaultText = "";
            this.textBoxSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSurname.DisabledState.Parent = this.textBoxSurname;
            this.textBoxSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSurname.FocusedState.Parent = this.textBoxSurname;
            this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSurname.ForeColor = System.Drawing.Color.Black;
            this.textBoxSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSurname.HoverState.Parent = this.textBoxSurname;
            this.textBoxSurname.Location = new System.Drawing.Point(50, 136);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.PasswordChar = '\0';
            this.textBoxSurname.PlaceholderText = "";
            this.textBoxSurname.SelectedText = "";
            this.textBoxSurname.ShadowDecoration.Parent = this.textBoxSurname;
            this.textBoxSurname.Size = new System.Drawing.Size(230, 20);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxSignId
            // 
            this.textBoxSignId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSignId.DefaultText = "";
            this.textBoxSignId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSignId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSignId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSignId.DisabledState.Parent = this.textBoxSignId;
            this.textBoxSignId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSignId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSignId.FocusedState.Parent = this.textBoxSignId;
            this.textBoxSignId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSignId.ForeColor = System.Drawing.Color.Black;
            this.textBoxSignId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSignId.HoverState.Parent = this.textBoxSignId;
            this.textBoxSignId.Location = new System.Drawing.Point(50, 175);
            this.textBoxSignId.Name = "textBoxSignId";
            this.textBoxSignId.PasswordChar = '\0';
            this.textBoxSignId.PlaceholderText = "";
            this.textBoxSignId.SelectedText = "";
            this.textBoxSignId.ShadowDecoration.Parent = this.textBoxSignId;
            this.textBoxSignId.Size = new System.Drawing.Size(230, 20);
            this.textBoxSignId.TabIndex = 3;
            // 
            // textBoxSignPassword
            // 
            this.textBoxSignPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSignPassword.DefaultText = "";
            this.textBoxSignPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSignPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSignPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSignPassword.DisabledState.Parent = this.textBoxSignPassword;
            this.textBoxSignPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSignPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSignPassword.FocusedState.Parent = this.textBoxSignPassword;
            this.textBoxSignPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSignPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxSignPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSignPassword.HoverState.Parent = this.textBoxSignPassword;
            this.textBoxSignPassword.Location = new System.Drawing.Point(50, 353);
            this.textBoxSignPassword.Name = "textBoxSignPassword";
            this.textBoxSignPassword.PasswordChar = '\0';
            this.textBoxSignPassword.PlaceholderText = "";
            this.textBoxSignPassword.SelectedText = "";
            this.textBoxSignPassword.ShadowDecoration.Parent = this.textBoxSignPassword;
            this.textBoxSignPassword.Size = new System.Drawing.Size(209, 20);
            this.textBoxSignPassword.TabIndex = 7;
            this.textBoxSignPassword.UseSystemPasswordChar = true;
            this.textBoxSignPassword.TextChanged += new System.EventHandler(this.textBoxSignPassword_TextChanged);
            // 
            // textBoxVerifyPassword
            // 
            this.textBoxVerifyPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxVerifyPassword.DefaultText = "";
            this.textBoxVerifyPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxVerifyPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxVerifyPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxVerifyPassword.DisabledState.Parent = this.textBoxVerifyPassword;
            this.textBoxVerifyPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxVerifyPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxVerifyPassword.FocusedState.Parent = this.textBoxVerifyPassword;
            this.textBoxVerifyPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxVerifyPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxVerifyPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxVerifyPassword.HoverState.Parent = this.textBoxVerifyPassword;
            this.textBoxVerifyPassword.Location = new System.Drawing.Point(50, 392);
            this.textBoxVerifyPassword.Name = "textBoxVerifyPassword";
            this.textBoxVerifyPassword.PasswordChar = '\0';
            this.textBoxVerifyPassword.PlaceholderText = "";
            this.textBoxVerifyPassword.SelectedText = "";
            this.textBoxVerifyPassword.ShadowDecoration.Parent = this.textBoxVerifyPassword;
            this.textBoxVerifyPassword.Size = new System.Drawing.Size(209, 20);
            this.textBoxVerifyPassword.TabIndex = 8;
            this.textBoxVerifyPassword.UseSystemPasswordChar = true;
            this.textBoxVerifyPassword.TextChanged += new System.EventHandler(this.textBoxVerifyPassword_TextChanged);
            // 
            // checkBoxSign
            // 
            this.checkBoxSign.AutoSize = true;
            this.checkBoxSign.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxSign.CheckedState.BorderRadius = 0;
            this.checkBoxSign.CheckedState.BorderThickness = 0;
            this.checkBoxSign.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxSign.Location = new System.Drawing.Point(265, 356);
            this.checkBoxSign.Name = "checkBoxSign";
            this.checkBoxSign.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSign.TabIndex = 21;
            this.checkBoxSign.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxSign.UncheckedState.BorderRadius = 0;
            this.checkBoxSign.UncheckedState.BorderThickness = 0;
            this.checkBoxSign.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxSign.CheckedChanged += new System.EventHandler(this.checkBoxSign_CheckedChanged);
            // 
            // checkBoxSignVerify
            // 
            this.checkBoxSignVerify.AutoSize = true;
            this.checkBoxSignVerify.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxSignVerify.CheckedState.BorderRadius = 0;
            this.checkBoxSignVerify.CheckedState.BorderThickness = 0;
            this.checkBoxSignVerify.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxSignVerify.Location = new System.Drawing.Point(265, 395);
            this.checkBoxSignVerify.Name = "checkBoxSignVerify";
            this.checkBoxSignVerify.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSignVerify.TabIndex = 22;
            this.checkBoxSignVerify.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxSignVerify.UncheckedState.BorderRadius = 0;
            this.checkBoxSignVerify.UncheckedState.BorderThickness = 0;
            this.checkBoxSignVerify.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxSignVerify.CheckedChanged += new System.EventHandler(this.checkBoxSignVerify_CheckedChanged);
            // 
            // languageSwi
            // 
            this.languageSwi.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.languageSwi.CheckedState.InnerColor = System.Drawing.Color.White;
            this.languageSwi.CheckedState.Parent = this.languageSwi;
            this.languageSwi.Location = new System.Drawing.Point(12, 476);
            this.languageSwi.Name = "languageSwi";
            this.languageSwi.ShadowDecoration.Parent = this.languageSwi;
            this.languageSwi.Size = new System.Drawing.Size(30, 17);
            this.languageSwi.TabIndex = 23;
            this.languageSwi.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.languageSwi.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.languageSwi.UncheckedState.Parent = this.languageSwi;
            this.languageSwi.CheckedChanged += new System.EventHandler(this.languageSwi_CheckedChanged);
            this.languageSwi.MouseLeave += new System.EventHandler(this.languageSwi_MouseLeave);
            this.languageSwi.MouseHover += new System.EventHandler(this.languageSwi_MouseHover);
            // 
            // buttonSignfull
            // 
            this.buttonSignfull.Animated = true;
            this.buttonSignfull.AutoRoundedCorners = true;
            this.buttonSignfull.BorderRadius = 14;
            this.buttonSignfull.CheckedState.Parent = this.buttonSignfull;
            this.buttonSignfull.CustomImages.Parent = this.buttonSignfull;
            this.buttonSignfull.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSignfull.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSignfull.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSignfull.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSignfull.DisabledState.Parent = this.buttonSignfull;
            this.buttonSignfull.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSignfull.ForeColor = System.Drawing.Color.White;
            this.buttonSignfull.HoverState.Parent = this.buttonSignfull;
            this.buttonSignfull.Location = new System.Drawing.Point(50, 444);
            this.buttonSignfull.Name = "buttonSignfull";
            this.buttonSignfull.ShadowDecoration.Parent = this.buttonSignfull;
            this.buttonSignfull.Size = new System.Drawing.Size(110, 30);
            this.buttonSignfull.TabIndex = 24;
            this.buttonSignfull.Text = "Sign in";
            this.buttonSignfull.Click += new System.EventHandler(this.buttonSignfull_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Animated = true;
            this.buttonCancel.AutoRoundedCorners = true;
            this.buttonCancel.BorderRadius = 14;
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
            this.buttonCancel.Location = new System.Drawing.Point(170, 444);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.ShadowDecoration.Parent = this.buttonCancel;
            this.buttonCancel.Size = new System.Drawing.Size(110, 30);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // securityBox
            // 
            this.securityBox.BackColor = System.Drawing.Color.Transparent;
            this.securityBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.securityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.securityBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.securityBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.securityBox.FocusedState.Parent = this.securityBox;
            this.securityBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.securityBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.securityBox.HoverState.Parent = this.securityBox;
            this.securityBox.ItemHeight = 30;
            this.securityBox.Items.AddRange(new object[] {
            "İlk evcil hayvanınızın adı?",
            "İlk öğretmeninizin adı nedir?",
            "İlk arkadaşınızın adı nedir?",
            "İlk işiniz nedir?"});
            this.securityBox.ItemsAppearance.Parent = this.securityBox;
            this.securityBox.Location = new System.Drawing.Point(50, 263);
            this.securityBox.Name = "securityBox";
            this.securityBox.ShadowDecoration.Parent = this.securityBox;
            this.securityBox.Size = new System.Drawing.Size(230, 36);
            this.securityBox.TabIndex = 5;
            // 
            // labelSecure
            // 
            this.labelSecure.AutoSize = true;
            this.labelSecure.Location = new System.Drawing.Point(47, 247);
            this.labelSecure.Name = "labelSecure";
            this.labelSecure.Size = new System.Drawing.Size(90, 13);
            this.labelSecure.TabIndex = 27;
            this.labelSecure.Text = "Security Question";
            // 
            // secureAns
            // 
            this.secureAns.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secureAns.DefaultText = "";
            this.secureAns.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.secureAns.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.secureAns.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secureAns.DisabledState.Parent = this.secureAns;
            this.secureAns.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secureAns.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secureAns.FocusedState.Parent = this.secureAns;
            this.secureAns.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.secureAns.ForeColor = System.Drawing.Color.Black;
            this.secureAns.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secureAns.HoverState.Parent = this.secureAns;
            this.secureAns.Location = new System.Drawing.Point(50, 305);
            this.secureAns.Name = "secureAns";
            this.secureAns.PasswordChar = '\0';
            this.secureAns.PlaceholderText = "";
            this.secureAns.SelectedText = "";
            this.secureAns.ShadowDecoration.Parent = this.secureAns;
            this.secureAns.Size = new System.Drawing.Size(230, 20);
            this.secureAns.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.DefaultText = "";
            this.textBoxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxEmail.DisabledState.Parent = this.textBoxEmail;
            this.textBoxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxEmail.FocusedState.Parent = this.textBoxEmail;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxEmail.HoverState.Parent = this.textBoxEmail;
            this.textBoxEmail.Location = new System.Drawing.Point(50, 214);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.PlaceholderText = "";
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.ShadowDecoration.Parent = this.textBoxEmail;
            this.textBoxEmail.Size = new System.Drawing.Size(230, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(47, 198);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 29;
            this.labelEmail.Text = "Email";
            // 
            // labelcheck
            // 
            this.labelcheck.AutoSize = true;
            this.labelcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelcheck.ForeColor = System.Drawing.Color.Red;
            this.labelcheck.Location = new System.Drawing.Point(286, 97);
            this.labelcheck.Name = "labelcheck";
            this.labelcheck.Size = new System.Drawing.Size(20, 25);
            this.labelcheck.TabIndex = 30;
            this.labelcheck.Text = "*";
            this.labelcheck.Visible = false;
            // 
            // labelcheck1
            // 
            this.labelcheck1.AutoSize = true;
            this.labelcheck1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelcheck1.ForeColor = System.Drawing.Color.Red;
            this.labelcheck1.Location = new System.Drawing.Point(286, 136);
            this.labelcheck1.Name = "labelcheck1";
            this.labelcheck1.Size = new System.Drawing.Size(20, 25);
            this.labelcheck1.TabIndex = 31;
            this.labelcheck1.Text = "*";
            this.labelcheck1.Visible = false;
            // 
            // labelcheck2
            // 
            this.labelcheck2.AutoSize = true;
            this.labelcheck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelcheck2.ForeColor = System.Drawing.Color.Red;
            this.labelcheck2.Location = new System.Drawing.Point(286, 175);
            this.labelcheck2.Name = "labelcheck2";
            this.labelcheck2.Size = new System.Drawing.Size(20, 25);
            this.labelcheck2.TabIndex = 32;
            this.labelcheck2.Text = "*";
            this.labelcheck2.Visible = false;
            // 
            // labelcheck3
            // 
            this.labelcheck3.AutoSize = true;
            this.labelcheck3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelcheck3.ForeColor = System.Drawing.Color.Red;
            this.labelcheck3.Location = new System.Drawing.Point(286, 214);
            this.labelcheck3.Name = "labelcheck3";
            this.labelcheck3.Size = new System.Drawing.Size(20, 25);
            this.labelcheck3.TabIndex = 33;
            this.labelcheck3.Text = "*";
            this.labelcheck3.Visible = false;
            // 
            // labelcheck5
            // 
            this.labelcheck5.AutoSize = true;
            this.labelcheck5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelcheck5.ForeColor = System.Drawing.Color.Red;
            this.labelcheck5.Location = new System.Drawing.Point(286, 263);
            this.labelcheck5.Name = "labelcheck5";
            this.labelcheck5.Size = new System.Drawing.Size(20, 25);
            this.labelcheck5.TabIndex = 34;
            this.labelcheck5.Text = "*";
            this.labelcheck5.Visible = false;
            // 
            // labelcheck6
            // 
            this.labelcheck6.AutoSize = true;
            this.labelcheck6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelcheck6.ForeColor = System.Drawing.Color.Red;
            this.labelcheck6.Location = new System.Drawing.Point(286, 305);
            this.labelcheck6.Name = "labelcheck6";
            this.labelcheck6.Size = new System.Drawing.Size(20, 25);
            this.labelcheck6.TabIndex = 35;
            this.labelcheck6.Text = "*";
            this.labelcheck6.Visible = false;
            // 
            // labelcheck7
            // 
            this.labelcheck7.AutoSize = true;
            this.labelcheck7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelcheck7.ForeColor = System.Drawing.Color.Red;
            this.labelcheck7.Location = new System.Drawing.Point(286, 353);
            this.labelcheck7.Name = "labelcheck7";
            this.labelcheck7.Size = new System.Drawing.Size(20, 25);
            this.labelcheck7.TabIndex = 36;
            this.labelcheck7.Text = "*";
            this.labelcheck7.Visible = false;
            // 
            // labelcheck8
            // 
            this.labelcheck8.AutoSize = true;
            this.labelcheck8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelcheck8.ForeColor = System.Drawing.Color.Red;
            this.labelcheck8.Location = new System.Drawing.Point(286, 395);
            this.labelcheck8.Name = "labelcheck8";
            this.labelcheck8.Size = new System.Drawing.Size(20, 25);
            this.labelcheck8.TabIndex = 37;
            this.labelcheck8.Text = "*";
            this.labelcheck8.Visible = false;
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.BackColor = System.Drawing.Color.Transparent;
            this.labelLang.Location = new System.Drawing.Point(12, 455);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(55, 13);
            this.labelLang.TabIndex = 38;
            this.labelLang.Text = "Language";
            this.labelLang.Visible = false;
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 509);
            this.Controls.Add(this.labelLang);
            this.Controls.Add(this.labelcheck8);
            this.Controls.Add(this.labelcheck7);
            this.Controls.Add(this.labelcheck6);
            this.Controls.Add(this.labelcheck5);
            this.Controls.Add(this.labelcheck3);
            this.Controls.Add(this.labelcheck2);
            this.Controls.Add(this.labelcheck1);
            this.Controls.Add(this.labelcheck);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.secureAns);
            this.Controls.Add(this.labelSecure);
            this.Controls.Add(this.securityBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSignfull);
            this.Controls.Add(this.languageSwi);
            this.Controls.Add(this.checkBoxSignVerify);
            this.Controls.Add(this.checkBoxSign);
            this.Controls.Add(this.textBoxVerifyPassword);
            this.Controls.Add(this.textBoxSignPassword);
            this.Controls.Add(this.textBoxSignId);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.notEqual);
            this.Controls.Add(this.verifyPassword);
            this.Controls.Add(this.signPassword);
            this.Controls.Add(this.idSign);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.signInlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signInlabel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label idSign;
        private System.Windows.Forms.Label signPassword;
        private System.Windows.Forms.Label verifyPassword;
        private System.Windows.Forms.Label notEqual;
        private System.Windows.Forms.Label labelSurname;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSurname;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSignId;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSignPassword;
        private Guna.UI2.WinForms.Guna2TextBox textBoxVerifyPassword;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxSign;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxSignVerify;
        private Guna.UI2.WinForms.Guna2ToggleSwitch languageSwi;
        private Guna.UI2.WinForms.Guna2Button buttonSignfull;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private Guna.UI2.WinForms.Guna2ComboBox securityBox;
        private System.Windows.Forms.Label labelSecure;
        private Guna.UI2.WinForms.Guna2TextBox secureAns;
        private Guna.UI2.WinForms.Guna2TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelcheck;
        private System.Windows.Forms.Label labelcheck1;
        private System.Windows.Forms.Label labelcheck2;
        private System.Windows.Forms.Label labelcheck3;
        private System.Windows.Forms.Label labelcheck5;
        private System.Windows.Forms.Label labelcheck6;
        private System.Windows.Forms.Label labelcheck7;
        private System.Windows.Forms.Label labelcheck8;
        private System.Windows.Forms.Label labelLang;
    }
}