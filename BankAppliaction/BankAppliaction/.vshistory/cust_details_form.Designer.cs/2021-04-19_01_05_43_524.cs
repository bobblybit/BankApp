﻿
namespace BankAppliaction
{
    partial class cust_details_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cust_details_form));
            this.login_pannel = new System.Windows.Forms.Panel();
            this.createacc_lbl = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cost_initamount_txt = new System.Windows.Forms.TextBox();
            this.gender_gbx_txt = new System.Windows.Forms.GroupBox();
            this.current_acc_rtn = new System.Windows.Forms.RadioButton();
            this.saving_acc_rtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cost_adress_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cost_Phone_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cost_lname_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cost_fname_txt = new System.Windows.Forms.TextBox();
            this.login_pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gender_gbx_txt.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_pannel
            // 
            this.login_pannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_pannel.BackColor = System.Drawing.Color.White;
            this.login_pannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_pannel.Controls.Add(this.createacc_lbl);
            this.login_pannel.Controls.Add(this.pictureBox2);
            this.login_pannel.Controls.Add(this.pictureBox1);
            this.login_pannel.Location = new System.Drawing.Point(26, 12);
            this.login_pannel.Name = "login_pannel";
            this.login_pannel.Size = new System.Drawing.Size(340, 715);
            this.login_pannel.TabIndex = 1;
            // 
            // createacc_lbl
            // 
            this.createacc_lbl.AutoSize = true;
            this.createacc_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.createacc_lbl.LinkColor = System.Drawing.Color.Maroon;
            this.createacc_lbl.Location = new System.Drawing.Point(85, 650);
            this.createacc_lbl.Name = "createacc_lbl";
            this.createacc_lbl.Size = new System.Drawing.Size(150, 25);
            this.createacc_lbl.TabIndex = 12;
            this.createacc_lbl.TabStop = true;
            this.createacc_lbl.Text = "Go To HomePage";
            this.createacc_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createacc_lbl_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(325, 424);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 8);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cost_initamount_txt);
            this.panel1.Controls.Add(this.gender_gbx_txt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cost_adress_txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cost_Phone_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cost_lname_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cost_fname_txt);
            this.panel1.Location = new System.Drawing.Point(372, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 715);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(58, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 63);
            this.button1.TabIndex = 24;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.label6.Location = new System.Drawing.Point(16, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Enter Initial Deposit Amount";
            // 
            // cost_initamount_txt
            // 
            this.cost_initamount_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cost_initamount_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cost_initamount_txt.Location = new System.Drawing.Point(16, 553);
            this.cost_initamount_txt.Name = "cost_initamount_txt";
            this.cost_initamount_txt.Size = new System.Drawing.Size(366, 34);
            this.cost_initamount_txt.TabIndex = 21;
            // 
            // gender_gbx_txt
            // 
            this.gender_gbx_txt.Controls.Add(this.current_acc_rtn);
            this.gender_gbx_txt.Controls.Add(this.saving_acc_rtn);
            this.gender_gbx_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.gender_gbx_txt.Location = new System.Drawing.Point(16, 394);
            this.gender_gbx_txt.Name = "gender_gbx_txt";
            this.gender_gbx_txt.Size = new System.Drawing.Size(366, 114);
            this.gender_gbx_txt.TabIndex = 20;
            this.gender_gbx_txt.TabStop = false;
            this.gender_gbx_txt.Text = "Select Type Of Account";
            this.gender_gbx_txt.Enter += new System.EventHandler(this.gender_gbx_txt_Enter);
            // 
            // current_acc_rtn
            // 
            this.current_acc_rtn.AutoSize = true;
            this.current_acc_rtn.Location = new System.Drawing.Point(6, 76);
            this.current_acc_rtn.Name = "current_acc_rtn";
            this.current_acc_rtn.Size = new System.Drawing.Size(165, 29);
            this.current_acc_rtn.TabIndex = 19;
            this.current_acc_rtn.Text = "Current Account";
            this.current_acc_rtn.UseVisualStyleBackColor = true;
            this.current_acc_rtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // saving_acc_rtn
            // 
            this.saving_acc_rtn.AutoSize = true;
            this.saving_acc_rtn.Checked = true;
            this.saving_acc_rtn.Location = new System.Drawing.Point(6, 41);
            this.saving_acc_rtn.Name = "saving_acc_rtn";
            this.saving_acc_rtn.Size = new System.Drawing.Size(168, 29);
            this.saving_acc_rtn.TabIndex = 18;
            this.saving_acc_rtn.TabStop = true;
            this.saving_acc_rtn.Text = "Savings Account";
            this.saving_acc_rtn.UseVisualStyleBackColor = true;
            this.saving_acc_rtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.label5.Location = new System.Drawing.Point(38, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Address";
            // 
            // cost_adress_txt
            // 
            this.cost_adress_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cost_adress_txt.Location = new System.Drawing.Point(16, 297);
            this.cost_adress_txt.Multiline = true;
            this.cost_adress_txt.Name = "cost_adress_txt";
            this.cost_adress_txt.Size = new System.Drawing.Size(366, 91);
            this.cost_adress_txt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.label3.Location = new System.Drawing.Point(16, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phone No:";
            // 
            // cost_Phone_txt
            // 
            this.cost_Phone_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cost_Phone_txt.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cost_Phone_txt.Location = new System.Drawing.Point(16, 242);
            this.cost_Phone_txt.Name = "cost_Phone_txt";
            this.cost_Phone_txt.Size = new System.Drawing.Size(366, 35);
            this.cost_Phone_txt.TabIndex = 14;
            this.cost_Phone_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(16, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Last Name";
            // 
            // cost_lname_txt
            // 
            this.cost_lname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cost_lname_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cost_lname_txt.Location = new System.Drawing.Point(16, 176);
            this.cost_lname_txt.Name = "cost_lname_txt";
            this.cost_lname_txt.Size = new System.Drawing.Size(366, 34);
            this.cost_lname_txt.TabIndex = 12;
            this.cost_lname_txt.TextChanged += new System.EventHandler(this.cust_lname_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(16, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(78, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Account Opening Foam";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cost_fname_txt
            // 
            this.cost_fname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cost_fname_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cost_fname_txt.Location = new System.Drawing.Point(16, 112);
            this.cost_fname_txt.Name = "cost_fname_txt";
            this.cost_fname_txt.Size = new System.Drawing.Size(366, 34);
            this.cost_fname_txt.TabIndex = 6;
            // 
            // cust_details_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login_pannel);
            this.Name = "cust_details_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costumers Details";
            this.login_pannel.ResumeLayout(false);
            this.login_pannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gender_gbx_txt.ResumeLayout(false);
            this.gender_gbx_txt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_pannel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cost_fname_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton current_acc_rtn;
        private System.Windows.Forms.RadioButton saving_acc_rtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cost_adress_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cost_Phone_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cost_lname_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cost_initamount_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel createacc_lbl;
        private System.Windows.Forms.GroupBox gender_gbx_txt;
    }
}