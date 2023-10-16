
namespace HastaTakip
{
    partial class loading
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
            this.gunaLoading = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gunaLoading
            // 
            this.gunaLoading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaLoading.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLoading.FillOffset = 12;
            this.gunaLoading.FillThickness = 15;
            this.gunaLoading.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.gunaLoading.ForeColor = System.Drawing.Color.White;
            this.gunaLoading.InnerColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaLoading.Location = new System.Drawing.Point(135, 60);
            this.gunaLoading.Minimum = 0;
            this.gunaLoading.Name = "gunaLoading";
            this.gunaLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaLoading.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaLoading.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.gunaLoading.ProgressOffset = 12;
            this.gunaLoading.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.gunaLoading.ProgressThickness = 18;
            this.gunaLoading.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaLoading.ShadowDecoration.Parent = this.gunaLoading;
            this.gunaLoading.ShowText = true;
            this.gunaLoading.Size = new System.Drawing.Size(130, 130);
            this.gunaLoading.TabIndex = 0;
            this.gunaLoading.Text = "progressBar";
            this.gunaLoading.ValueChanged += new System.EventHandler(this.gunaLoading_ValueChanged);
            // 
            // timerProgress
            // 
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.gunaLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loading";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaLoading;
        private System.Windows.Forms.Timer timerProgress;
    }
}