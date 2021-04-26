using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AxisBank.lib.Core;
using AxisBank.lib.Model;

namespace BankAppliaction
{
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();

        }

        private void accnt_panel_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void create_login_lbl_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Proceed_btn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dashBoard_Load(object sender, EventArgs e)
        {
            // getting user data to display
            List<string> data = new List<string>();
            string path = file.logpath;
            data = FileRepository.readFile(path);

            string Firstname = "";
            string lasttname = "";
            string email = "";
            string phnoenumber = "";

            foreach (var item in data)
            {
               Firstname = item.Split(",")[0];
                 lasttname = item.Split(",")[1];
                 email = item.Split(",")[2];
                 phnoenumber = item.Split(",")[3];
            }

            username_lbl.Text = email;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void namePtach_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (deposit_Amount_txt.Text == "")
            {
                MessageBox.Show("Please Enter Account Number You Want To Deposit To");
                deposit_Amount_txt.Focus();
            }
            else if (deposit_acc_text.Text == "")
            {
                MessageBox.Show("Please Enter an Amount You Want To Deposit TO");
                deposit_acc_text.Focus();
            }
            else if (deposit_remark_txt.Text == "")
            {
                MessageBox.Show("Please Enter a Remark");
                deposit_remark_txt.Focus();
            }
            else
            {

                string accNumber = deposit_acc_text.Text;
                string accdetails =  AccountRepository.confirmAccount(accNumber);
                if (accdetails !="")
                {
                    if (MessageBox.Show($"Confirm Deposit of {deposit_Amount_txt.Text} to {accdetails}", "Deposit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //TransactionRepository.depositToAccount();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Account number please check and correct it");
                    deposit_acc_text.Focus();
                }


            }


        }

        private void cost_fname_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
