﻿
namespace BankAppliaction
{
    partial class AccAcountForm
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
            this.add_acc_init_amt_txt = new System.Windows.Forms.TextBox();
            this.deposit_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_acc_init_amt_txt
            // 
            this.add_acc_init_amt_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_acc_init_amt_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_acc_init_amt_txt.Location = new System.Drawing.Point(74, 68);
            this.add_acc_init_amt_txt.Name = "add_acc_init_amt_txt";
            this.add_acc_init_amt_txt.Size = new System.Drawing.Size(366, 34);
            this.add_acc_init_amt_txt.TabIndex = 7;
            this.add_acc_init_amt_txt.TextChanged += new System.EventHandler(this.cost_fname_txt_TextChanged);
            // 
            // deposit_btn
            // 
            this.deposit_btn.BackColor = System.Drawing.Color.White;
            this.deposit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deposit_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deposit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.deposit_btn.Location = new System.Drawing.Point(173, 128);
            this.deposit_btn.Name = "deposit_btn";
            this.deposit_btn.Size = new System.Drawing.Size(160, 47);
            this.deposit_btn.TabIndex = 13;
            this.deposit_btn.Text = "Deposit";
            this.deposit_btn.UseVisualStyleBackColor = false;
            this.deposit_btn.Click += new System.EventHandler(this.deposit_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(149, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Enter Initial Deposit Amount";
            // 
            // AccAcountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 196);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deposit_btn);
            this.Controls.Add(this.add_acc_init_amt_txt);
            this.Name = "AccAcountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccAcountForm";
            this.Load += new System.EventHandler(this.AccAcountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox add_acc_init_amt_txt;
        private System.Windows.Forms.Button deposit_btn;
        private System.Windows.Forms.Label label4;
    }
}