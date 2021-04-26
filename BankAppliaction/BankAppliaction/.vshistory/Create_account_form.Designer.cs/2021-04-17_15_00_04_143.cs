
namespace BankAppliaction
{
    partial class create_login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_login_Form));
            this.login_email_txt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.create_login_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createacc_lbl = new System.Windows.Forms.LinkLabel();
            this.Proceed_btn = new System.Windows.Forms.Button();
            this.crt_login_dit_email_lbl = new System.Windows.Forms.Label();
            this.crt_login_dit_pass_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_email_txt
            // 
            this.login_email_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_email_txt.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.login_email_txt.Location = new System.Drawing.Point(42, 254);
            this.login_email_txt.Name = "login_email_txt";
            this.login_email_txt.PasswordChar = '*';
            this.login_email_txt.Size = new System.Drawing.Size(513, 49);
            this.login_email_txt.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(42, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(513, 49);
            this.textBox1.TabIndex = 5;
            // 
            // create_login_lbl
            // 
            this.create_login_lbl.AutoSize = true;
            this.create_login_lbl.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create_login_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.create_login_lbl.Location = new System.Drawing.Point(143, 103);
            this.create_login_lbl.Name = "create_login_lbl";
            this.create_login_lbl.Size = new System.Drawing.Size(300, 23);
            this.create_login_lbl.TabIndex = 8;
            this.create_login_lbl.Text = "Set Up Your Login Details";
            this.create_login_lbl.Click += new System.EventHandler(this.create_login_lbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // createacc_lbl
            // 
            this.createacc_lbl.AutoSize = true;
            this.createacc_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.createacc_lbl.LinkColor = System.Drawing.Color.Maroon;
            this.createacc_lbl.Location = new System.Drawing.Point(203, 383);
            this.createacc_lbl.Name = "createacc_lbl";
            this.createacc_lbl.Size = new System.Drawing.Size(153, 25);
            this.createacc_lbl.TabIndex = 11;
            this.createacc_lbl.TabStop = true;
            this.createacc_lbl.Text = "Go Back To Home";
            this.createacc_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createacc_lbl_LinkClicked);
            // 
            // Proceed_btn
            // 
            this.Proceed_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.Proceed_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Proceed_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Proceed_btn.ForeColor = System.Drawing.Color.White;
            this.Proceed_btn.Location = new System.Drawing.Point(205, 322);
            this.Proceed_btn.Name = "Proceed_btn";
            this.Proceed_btn.Size = new System.Drawing.Size(151, 47);
            this.Proceed_btn.TabIndex = 3;
            this.Proceed_btn.Text = "Proceed";
            this.Proceed_btn.UseVisualStyleBackColor = false;
            this.Proceed_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // crt_login_dit_email_lbl
            // 
            this.crt_login_dit_email_lbl.AutoSize = true;
            this.crt_login_dit_email_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crt_login_dit_email_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.crt_login_dit_email_lbl.Location = new System.Drawing.Point(53, 161);
            this.crt_login_dit_email_lbl.Name = "crt_login_dit_email_lbl";
            this.crt_login_dit_email_lbl.Size = new System.Drawing.Size(139, 25);
            this.crt_login_dit_email_lbl.TabIndex = 12;
            this.crt_login_dit_email_lbl.Text = "Enter Your Email";
            // 
            // crt_login_dit_pass_lbl
            // 
            this.crt_login_dit_pass_lbl.AutoSize = true;
            this.crt_login_dit_pass_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crt_login_dit_pass_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.crt_login_dit_pass_lbl.Location = new System.Drawing.Point(56, 239);
            this.crt_login_dit_pass_lbl.Name = "crt_login_dit_pass_lbl";
            this.crt_login_dit_pass_lbl.Size = new System.Drawing.Size(159, 25);
            this.crt_login_dit_pass_lbl.TabIndex = 13;
            this.crt_login_dit_pass_lbl.Text = "Create A Password";
            // 
            // create_login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 444);
            this.Controls.Add(this.crt_login_dit_pass_lbl);
            this.Controls.Add(this.crt_login_dit_email_lbl);
            this.Controls.Add(this.createacc_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.create_login_lbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.login_email_txt);
            this.Controls.Add(this.Proceed_btn);
            this.Name = "create_login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox login_email_txt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label create_login_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel createacc_lbl;
        private System.Windows.Forms.Button Proceed_btn;
        private System.Windows.Forms.Label crt_login_dit_email_lbl;
        private System.Windows.Forms.Label crt_login_dit_pass_lbl;
    }
}