
namespace HastaTakip
{
    partial class cikis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cikis));
            this.unlem = new System.Windows.Forms.PictureBox();
            this.labelcikis = new System.Windows.Forms.Label();
            this.buttonRed = new System.Windows.Forms.PictureBox();
            this.buttonNorm = new System.Windows.Forms.PictureBox();
            this.cancelbutt = new Guna.UI2.WinForms.Guna2Button();
            this.acceptbutt = new Guna.UI2.WinForms.Guna2Button();
            this.languageSwi = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.unlem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNorm)).BeginInit();
            this.SuspendLayout();
            // 
            // unlem
            // 
            this.unlem.Image = ((System.Drawing.Image)(resources.GetObject("unlem.Image")));
            this.unlem.Location = new System.Drawing.Point(25, 30);
            this.unlem.Name = "unlem";
            this.unlem.Size = new System.Drawing.Size(59, 59);
            this.unlem.TabIndex = 0;
            this.unlem.TabStop = false;
            // 
            // labelcikis
            // 
            this.labelcikis.AutoSize = true;
            this.labelcikis.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelcikis.Location = new System.Drawing.Point(90, 50);
            this.labelcikis.Name = "labelcikis";
            this.labelcikis.Size = new System.Drawing.Size(110, 26);
            this.labelcikis.TabIndex = 1;
            this.labelcikis.Text = "Are you sure you \r\nwant to exit?\r\n";
            // 
            // buttonRed
            // 
            this.buttonRed.Image = ((System.Drawing.Image)(resources.GetObject("buttonRed.Image")));
            this.buttonRed.Location = new System.Drawing.Point(164, 0);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(40, 20);
            this.buttonRed.TabIndex = 6;
            this.buttonRed.TabStop = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            this.buttonRed.MouseLeave += new System.EventHandler(this.buttonRed_MouseLeave);
            // 
            // buttonNorm
            // 
            this.buttonNorm.Image = ((System.Drawing.Image)(resources.GetObject("buttonNorm.Image")));
            this.buttonNorm.Location = new System.Drawing.Point(164, 0);
            this.buttonNorm.Name = "buttonNorm";
            this.buttonNorm.Size = new System.Drawing.Size(40, 20);
            this.buttonNorm.TabIndex = 7;
            this.buttonNorm.TabStop = false;
            this.buttonNorm.Click += new System.EventHandler(this.buttonNorm_Click);
            this.buttonNorm.MouseHover += new System.EventHandler(this.buttonNorm_MouseHover);
            // 
            // cancelbutt
            // 
            this.cancelbutt.Animated = true;
            this.cancelbutt.AutoRoundedCorners = true;
            this.cancelbutt.BorderRadius = 10;
            this.cancelbutt.CheckedState.Parent = this.cancelbutt;
            this.cancelbutt.CustomImages.Parent = this.cancelbutt;
            this.cancelbutt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelbutt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelbutt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelbutt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelbutt.DisabledState.Parent = this.cancelbutt;
            this.cancelbutt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelbutt.ForeColor = System.Drawing.Color.White;
            this.cancelbutt.HoverState.FillColor = System.Drawing.Color.Red;
            this.cancelbutt.HoverState.Parent = this.cancelbutt;
            this.cancelbutt.Location = new System.Drawing.Point(109, 95);
            this.cancelbutt.Name = "cancelbutt";
            this.cancelbutt.ShadowDecoration.Parent = this.cancelbutt;
            this.cancelbutt.Size = new System.Drawing.Size(73, 23);
            this.cancelbutt.TabIndex = 8;
            this.cancelbutt.Text = "No";
            this.cancelbutt.Click += new System.EventHandler(this.cancelbutt_Click_1);
            // 
            // acceptbutt
            // 
            this.acceptbutt.Animated = true;
            this.acceptbutt.AutoRoundedCorners = true;
            this.acceptbutt.BorderRadius = 10;
            this.acceptbutt.CheckedState.Parent = this.acceptbutt;
            this.acceptbutt.CustomImages.Parent = this.acceptbutt;
            this.acceptbutt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.acceptbutt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.acceptbutt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.acceptbutt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.acceptbutt.DisabledState.Parent = this.acceptbutt;
            this.acceptbutt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.acceptbutt.ForeColor = System.Drawing.Color.White;
            this.acceptbutt.HoverState.Parent = this.acceptbutt;
            this.acceptbutt.Location = new System.Drawing.Point(30, 95);
            this.acceptbutt.Name = "acceptbutt";
            this.acceptbutt.ShadowDecoration.Parent = this.acceptbutt;
            this.acceptbutt.Size = new System.Drawing.Size(73, 23);
            this.acceptbutt.TabIndex = 9;
            this.acceptbutt.Text = "Yes";
            this.acceptbutt.Click += new System.EventHandler(this.acceptbutt_Click_1);
            // 
            // languageSwi
            // 
            this.languageSwi.Animated = true;
            this.languageSwi.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.languageSwi.CheckedState.InnerColor = System.Drawing.Color.White;
            this.languageSwi.CheckedState.Parent = this.languageSwi;
            this.languageSwi.Location = new System.Drawing.Point(12, 127);
            this.languageSwi.Name = "languageSwi";
            this.languageSwi.ShadowDecoration.Parent = this.languageSwi;
            this.languageSwi.Size = new System.Drawing.Size(31, 17);
            this.languageSwi.TabIndex = 11;
            this.languageSwi.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.languageSwi.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.languageSwi.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.languageSwi.UncheckedState.Parent = this.languageSwi;
            this.languageSwi.CheckedChanged += new System.EventHandler(this.languageSwi_CheckedChanged);
            // 
            // cikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(204, 156);
            this.Controls.Add(this.languageSwi);
            this.Controls.Add(this.acceptbutt);
            this.Controls.Add(this.cancelbutt);
            this.Controls.Add(this.buttonNorm);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.labelcikis);
            this.Controls.Add(this.unlem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cikis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit?";
            ((System.ComponentModel.ISupportInitialize)(this.unlem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNorm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox unlem;
        private System.Windows.Forms.Label labelcikis;
        private System.Windows.Forms.PictureBox buttonRed;
        private System.Windows.Forms.PictureBox buttonNorm;
        private Guna.UI2.WinForms.Guna2Button cancelbutt;
        private Guna.UI2.WinForms.Guna2Button acceptbutt;
        private Guna.UI2.WinForms.Guna2ToggleSwitch languageSwi;
    }
}