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
            //string loggedIncostumerDits = setDashBoard(loginEmail);

            //string costID = loggedIncostumerDits.Split(",")[0];
            //string fname = loggedIncostumerDits.Split(",")[0];
            //string lname = loggedIncostumerDits.Split(",")[0];
            //string email = loggedIncostumerDits.Split(",")[0];
            //string phone = loggedIncostumerDits.Split(",")[0];
            //string address = loggedIncostumerDits.Split(",")[0];
            //Costumers loggedIncostumer = new Costumers(costID, fname, lname, email, phone, address);
            //return "";
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
    }
}
