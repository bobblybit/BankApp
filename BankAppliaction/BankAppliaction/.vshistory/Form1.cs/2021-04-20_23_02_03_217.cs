using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxisBank.lib.Core;
using AxisBank.lib.Model;

namespace BankAppliaction
{
    public partial class home : Form
    {

        public home()
        {
            InitializeComponent();
            Costumers loggedIncostumer = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void login_pannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_email_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string loginEmail =  login_email_txt.Text;
            string loginPassword = login_password_txt.Text;

            string  ret =  AuthRepository.loginIn(loginEmail, loginPassword);
            if (ret != "OK")
            {
                MessageBox.Show(ret);
            }
            else
            {
                string loggedIncostumerDits = CostumerRepository.getCostumerByEmail (loginEmail);
            }

        }

        private void createacc_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            create_login_Form create_login_cred = new create_login_Form();
            create_login_cred.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
