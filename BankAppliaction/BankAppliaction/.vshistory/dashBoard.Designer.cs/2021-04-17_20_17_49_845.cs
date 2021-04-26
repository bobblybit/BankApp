
namespace BankAppliaction
{
    partial class dashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashBoard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.create_login_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Proceed_btn = new System.Windows.Forms.Button();
            this.namePtach = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.namePtach);
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 328);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Proceed_btn);
            this.panel3.Controls.Add(this.create_login_lbl);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1242, 118);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // create_login_lbl
            // 
            this.create_login_lbl.AutoSize = true;
            this.create_login_lbl.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create_login_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.create_login_lbl.Location = new System.Drawing.Point(459, 22);
            this.create_login_lbl.Name = "create_login_lbl";
            this.create_login_lbl.Size = new System.Drawing.Size(300, 23);
            this.create_login_lbl.TabIndex = 9;
            this.create_login_lbl.Text = "Set Up Your Login Details";
            this.create_login_lbl.Click += new System.EventHandler(this.create_login_lbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(573, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 431);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 440);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(572, 239);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(573, 544);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(664, 135);
            this.panel5.TabIndex = 3;
            // 
            // Proceed_btn
            // 
            this.Proceed_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.Proceed_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Proceed_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Proceed_btn.ForeColor = System.Drawing.Color.White;
            this.Proceed_btn.Location = new System.Drawing.Point(775, 22);
            this.Proceed_btn.Name = "Proceed_btn";
            this.Proceed_btn.Size = new System.Drawing.Size(151, 47);
            this.Proceed_btn.TabIndex = 10;
            this.Proceed_btn.Text = "Proceed";
            this.Proceed_btn.UseVisualStyleBackColor = false;
            this.Proceed_btn.Click += new System.EventHandler(this.Proceed_btn_Click);
            // 
            // namePtach
            // 
            this.namePtach.AutoSize = true;
            this.namePtach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namePtach.Location = new System.Drawing.Point(216, 125);
            this.namePtach.Name = "namePtach";
            this.namePtach.Size = new System.Drawing.Size(38, 27);
            this.namePtach.TabIndex = 0;
            this.namePtach.Text = "DC";
            // 
            // dashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1242, 681);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "dashBoard";
            this.Text = "dashBoard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label create_login_lbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label namePtach;
        private System.Windows.Forms.Button Proceed_btn;
    }
}