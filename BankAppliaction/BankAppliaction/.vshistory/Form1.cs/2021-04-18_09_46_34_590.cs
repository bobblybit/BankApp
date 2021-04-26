using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using authRepository;

namespace BankAppliaction
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
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

            if (!String.IsNullOrEmpty(login_email_txt.Text))
            {
                if (!String.IsNullOrEmpty(login_password_txt.Text))
                {
                    authRepository.validateEmail(loginEmail);
                }
                else
                {
                    MessageBox.Show("The Password Field Is Empty Check And Try Again");
                    login_password_txt.Focus();
                }
            }
            else
            {
                MessageBox.Show("The Email Field Is Empty Check And Try Again");
                login_email_txt.Focus();
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
