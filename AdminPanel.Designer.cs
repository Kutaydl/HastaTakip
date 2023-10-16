
namespace HastaTakip
{
    partial class AdminPanel
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
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.panelShape = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
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
            this.textBoxName.Location = new System.Drawing.Point(81, 118);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.SelectedText = "";
            this.textBoxName.ShadowDecoration.Parent = this.textBoxName;
            this.textBoxName.Size = new System.Drawing.Size(238, 22);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPass.DefaultText = "";
            this.textBoxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPass.DisabledState.Parent = this.textBoxPass;
            this.textBoxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPass.FocusedState.Parent = this.textBoxPass;
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPass.ForeColor = System.Drawing.Color.Black;
            this.textBoxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPass.HoverState.Parent = this.textBoxPass;
            this.textBoxPass.Location = new System.Drawing.Point(81, 168);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '\0';
            this.textBoxPass.PlaceholderText = "";
            this.textBoxPass.SelectedText = "";
            this.textBoxPass.ShadowDecoration.Parent = this.textBoxPass;
            this.textBoxPass.Size = new System.Drawing.Size(238, 22);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.UseSystemPasswordChar = true;
            this.textBoxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPass_KeyDown);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 24F);
            this.labelTitle.Location = new System.Drawing.Point(100, 43);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(216, 38);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Admin Panel";
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Animated = true;
            this.buttonAdmin.AutoRoundedCorners = true;
            this.buttonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdmin.BorderRadius = 13;
            this.buttonAdmin.CheckedState.Parent = this.buttonAdmin;
            this.buttonAdmin.CustomImages.Parent = this.buttonAdmin;
            this.buttonAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdmin.DisabledState.Parent = this.buttonAdmin;
            this.buttonAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.HoverState.Parent = this.buttonAdmin;
            this.buttonAdmin.Location = new System.Drawing.Point(96, 220);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.ShadowDecoration.BorderRadius = 10;
            this.buttonAdmin.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.buttonAdmin.ShadowDecoration.Enabled = true;
            this.buttonAdmin.ShadowDecoration.Parent = this.buttonAdmin;
            this.buttonAdmin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.buttonAdmin.Size = new System.Drawing.Size(90, 28);
            this.buttonAdmin.TabIndex = 6;
            this.buttonAdmin.Text = "Login";
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Animated = true;
            this.buttonCancel.AutoRoundedCorners = true;
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.BorderRadius = 13;
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
            this.buttonCancel.Location = new System.Drawing.Point(214, 220);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.ShadowDecoration.BorderRadius = 10;
            this.buttonCancel.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.buttonCancel.ShadowDecoration.Enabled = true;
            this.buttonCancel.ShadowDecoration.Parent = this.buttonCancel;
            this.buttonCancel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.buttonCancel.Size = new System.Drawing.Size(90, 28);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelName.Location = new System.Drawing.Point(78, 102);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelPass.Location = new System.Drawing.Point(78, 152);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(61, 13);
            this.labelPass.TabIndex = 9;
            this.labelPass.Text = "Password";
            // 
            // panelShape
            // 
            this.panelShape.BorderRadius = 400;
            this.panelShape.TargetControl = this;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPass;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2Button buttonAdmin;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPass;
        private Guna.UI2.WinForms.Guna2Elipse panelShape;
    }
}