using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AxisBank.lib.Core;

namespace BankAppliaction
{
    public partial class create_login_Form : Form
    {
        public create_login_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void create_login_lbl_Click(object sender, EventArgs e)
        {

        }

        private void createacc_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Abort Account Creation?....", "And Go To Home", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                home home = new home();
                home.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login_email = create_login_email_txt.Text;
            string login_password = create_login_password_txt.Text;
            string message = authRepository.registerUser(login_email, login_password);

            if(message != "OK")
            {
                MessageBox.Show(message);
                create_login_email_txt.Text = "";
                create_login_email_txt.Focus();
            }
            else
            {
                this.Hide();
                cust_details_form custform = new cust_details_form();
                custform.Show();
            }

        }
    }
}
