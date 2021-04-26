
namespace BankAppliaction
{
    partial class home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.home_panel = new System.Windows.Forms.Panel();
            this.home_picture_pannel = new System.Windows.Forms.Panel();
            this.login_pannel = new System.Windows.Forms.Panel();
            this.login_email_txt = new System.Windows.Forms.TextBox();
            this.home_panel.SuspendLayout();
            this.login_pannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // home_panel
            // 
            this.home_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home_panel.Controls.Add(this.home_picture_pannel);
            this.home_panel.Controls.Add(this.login_pannel);
            this.home_panel.Location = new System.Drawing.Point(12, 12);
            this.home_panel.Name = "home_panel";
            this.home_panel.Size = new System.Drawing.Size(1218, 657);
            this.home_panel.TabIndex = 0;
            // 
            // home_picture_pannel
            // 
            this.home_picture_pannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.home_picture_pannel.Location = new System.Drawing.Point(19, 19);
            this.home_picture_pannel.Name = "home_picture_pannel";
            this.home_picture_pannel.Size = new System.Drawing.Size(708, 624);
            this.home_picture_pannel.TabIndex = 1;
            // 
            // login_pannel
            // 
            this.login_pannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_pannel.Controls.Add(this.login_email_txt);
            this.login_pannel.Location = new System.Drawing.Point(745, 19);
            this.login_pannel.Name = "login_pannel";
            this.login_pannel.Size = new System.Drawing.Size(459, 625);
            this.login_pannel.TabIndex = 0;
            this.login_pannel.Paint += new System.Windows.Forms.PaintEventHandler(this.login_pannel_Paint);
            // 
            // login_email_txt
            // 
            this.login_email_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_email_txt.Location = new System.Drawing.Point(39, 133);
            this.login_email_txt.Multiline = true;
            this.login_email_txt.Name = "login_email_txt";
            this.login_email_txt.Size = new System.Drawing.Size(388, 53);
            this.login_email_txt.TabIndex = 0;
            this.login_email_txt.TextChanged += new System.EventHandler(this.login_email_txt_TextChanged);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 681);
            this.Controls.Add(this.home_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.home_panel.ResumeLayout(false);
            this.login_pannel.ResumeLayout(false);
            this.login_pannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel home_panel;
        private System.Windows.Forms.Panel home_picture_pannel;
        private System.Windows.Forms.Panel login_pannel;
        private System.Windows.Forms.TextBox login_email_txt;
    }
}

