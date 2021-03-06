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
using System.IO;

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
            if (MessageBox.Show($"Are You Sure You Want to Logout", " Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                home newhome = new home();
                this.Hide();
                newhome.Show();
            }
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
            string line = data[data.Count - 1];
            //setting user data for dashboard
               string id = line.Split(",")[0];
               string Firstname = line.Split(",")[1];
               string  lastname = line.Split(",")[2];
               string email = line.Split(",")[3];
               string phonenumber= line.Split(",")[4];

            // displaying email
            username_lbl.Text = "user: "+email;
            DandT_txt.Text = DateTime.Now.ToString("f");

            //setting up name patch
            string initials1 = Firstname.Substring(0, 1);
            string initials2 = lastname.Substring(0, 1);
            namePatch.Text = initials1 + initials2;

            //getting account details of costumer
            List<string> accdits = new List<string>();
            accdits = AccountRepository.getAccountById(id);
            if (accdits.Count == 2)
            {
                create_acc_dash_btn.Enabled = false;
            }
            //displaying account details
            cst_nme_txt.Text = lastname+" !";

            foreach (var item in accdits)
            {
                string acctype = item.Split(",")[5];
                if (acctype == "Current Account")
                {
                    acd_txt1.Text = item.Split(",")[5];
                    acd_txt2.Text = item.Split(",")[4];
                }
                if (item.Split(",")[5] == "Saving Account")
                {
                    acd_txt3.Text = item.Split(",")[5];
                   acd_txt4.Text = item.Split(",")[4];
                }


            }
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


        }

        private void cost_fname_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void username_lbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            AccAcountForm acf = new AccAcountForm();
            acf.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (deposit_Amount_txt.Text == "")
            {
                MessageBox.Show("Please  Enter an Amount You Want To Deposit To");
                deposit_Amount_txt.Focus();
            }
            else if (deposit_Amount_txt.Text == "0")
            {
                MessageBox.Show("Please The Amount Is To Small ToMake");
                deposit_Amount_txt.Focus();
            }
            else if (deposit_acc_text.Text == "")
            {
                MessageBox.Show("Please Enter the account number You Want To Deposit TO");
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
                string accdetails = AccountRepository.confirmAccount(accNumber);
                if (accdetails != "")
                {
                    if (MessageBox.Show($"Confirm Deposit of {deposit_Amount_txt.Text} to {accdetails}", "Deposit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string reciever = accNumber;
                        string amount = deposit_Amount_txt.Text;
                        string remark =  deposit_remark_txt .Text;

                        if (TransactionRepository.DepositToAccount(reciever, amount, remark))
                        {
                            MessageBox.Show("Deposit was Successful");
                            deposit_Amount_txt.Text = "";
                            deposit_acc_text.Text = "";
                            deposit_remark_txt.Text = "";
                            deposit_Amount_txt.Focus();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Invalid Account number please check and correct it");
                    deposit_acc_text.Focus();
                }


            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string acctype = withdrawal_acount_type.Text;
            string amount = "-"+withdrawal_amnt_txt.Text;
            string remark = withdrawal_amount_txt.Text;
            string email = username_lbl.Text;


        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            string path = file.logpath;
            data = FileRepository.readFile(path);
            string line = data[data.Count - 1];
            //getting logged in costumer email
            string id = line.Split(",")[0]; ;
            //showing balance
            decimal savingbalance = AccountRepository.checkBalance(id, "Saving Account");
            decimal currentbalance = AccountRepository.checkBalance(id, "Current Account");
            Saving_acc_balance_lbl.Text = savingbalance.ToString();
            Current_acc_balance_lbl.Text = currentbalance.ToString();



        }

        private void acd_txt3_Click(object sender, EventArgs e)
        {

        }
    }
}
