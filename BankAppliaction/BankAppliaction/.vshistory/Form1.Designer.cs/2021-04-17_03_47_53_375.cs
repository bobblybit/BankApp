﻿
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.login_email_txt = new System.Windows.Forms.TextBox();
            this.createacc_lbl = new System.Windows.Forms.LinkLabel();
            this.email_lbl = new System.Windows.Forms.Label();
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
            this.home_picture_pannel.Size = new System.Drawing.Size(739, 624);
            this.home_picture_pannel.TabIndex = 1;
            // 
            // login_pannel
            // 
            this.login_pannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_pannel.Controls.Add(this.email_lbl);
            this.login_pannel.Controls.Add(this.createacc_lbl);
            this.login_pannel.Controls.Add(this.button1);
            this.login_pannel.Controls.Add(this.textBox1);
            this.login_pannel.Controls.Add(this.login_email_txt);
            this.login_pannel.Location = new System.Drawing.Point(764, 19);
            this.login_pannel.Name = "login_pannel";
            this.login_pannel.Size = new System.Drawing.Size(440, 625);
            this.login_pannel.TabIndex = 0;
            this.login_pannel.Paint += new System.Windows.Forms.PaintEventHandler(this.login_pannel_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(45, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(48, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 48);
            this.textBox1.TabIndex = 1;
            // 
            // login_email_txt
            // 
            this.login_email_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_email_txt.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.login_email_txt.Location = new System.Drawing.Point(45, 236);
            this.login_email_txt.Name = "login_email_txt";
            this.login_email_txt.Size = new System.Drawing.Size(354, 42);
            this.login_email_txt.TabIndex = 0;
            this.login_email_txt.TextChanged += new System.EventHandler(this.login_email_txt_TextChanged);
            // 
            // createacc_lbl
            // 
            this.createacc_lbl.AutoSize = true;
            this.createacc_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.createacc_lbl.Location = new System.Drawing.Point(48, 498);
            this.createacc_lbl.Name = "createacc_lbl";
            this.createacc_lbl.Size = new System.Drawing.Size(189, 25);
            this.createacc_lbl.TabIndex = 3;
            this.createacc_lbl.TabStop = true;
            this.createacc_lbl.Text = "Create A New Account";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.email_lbl.Location = new System.Drawing.Point(45, 176);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(101, 43);
            this.email_lbl.TabIndex = 4;
            this.email_lbl.Text = "E-Mail";
            this.email_lbl.Click += new System.EventHandler(this.label1_Click_1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.LinkLabel createacc_lbl;
    }
}

