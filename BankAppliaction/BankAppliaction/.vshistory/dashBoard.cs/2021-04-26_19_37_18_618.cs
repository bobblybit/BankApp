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
            string amount = withdrawal_amnt_txt.Text;
            string remark = withdrawal_remak_txt.Text;

            string id = AuthRepository.getLoginUserById();

            if (withdrawal_acount_type.Text != "Saving Account" && withdrawal_acount_type.Text != "Current Account")
            {
                MessageBox.Show("Invalid Account type selection");
                withdrawal_acount_type.Focus();
            }
            else if (amount == "0") { MessageBox.Show("the amount is too small to withdraw");withdrawal_amnt_txt.Focus();}
            else if (amount == "") { MessageBox.Show("Please specify an amount"); withdrawal_amnt_txt.Focus();}
            else if (remark == "") { MessageBox.Show("please enter a remark"); withdrawal_remak_txt.Focus();}
            else
            {
                //checking if user is over withdrawal limit
                decimal balance = AccountRepository.checkBalance(id, acctype);
                decimal amountToWithdraw = decimal.Parse(amount);

                if (amountToWithdraw > balance)
                {
                    MessageBox.Show("Insufficient Balance");
                }

                if ((balance - amountToWithdraw) < 1000)
                {
                    MessageBox.Show("Insufficient Balance the minimum balance is #1000");
                }
                else
                {
                    amount = "-" + amount;
                    amountToWithdraw = decimal.Parse(amount);
                    if (TransactionRepository.withdrawalFromAccount(id, amountToWithdraw, remark, acctype))
                    {
                        MessageBox.Show("withdrawal was successful");
                        withdrawal_amnt_txt.Text = "";
                        withdrawal_remak_txt.Text = "";
                        withdrawal_acount_type.Text = "Select Account";


                    }
                }

            }

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

        private void withdrawal_acount_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void transf_btn_Click(object sender, EventArgs e)
        {
            //getting costumer id
            List<string> data = new List<string>();
            string path = file.logpath;
            data = FileRepository.readFile(path);
            string line = data[data.Count - 1];
            string id = line.Split(",")[0];

            //verifying input
            if (trans_cmb.Text != "Saving Account" && trans_cmb.Text != "Current Account")
            {MessageBox.Show("Please select the account you want to transfer from");}
            else if (transf_recvr_txt.Text == ""){MessageBox.Show("please enter the receiver's account number");transf_recvr_txt.Focus();}
            else if (transf_amnt_txt.Text == "") { MessageBox.Show("please enter the amount you want to transfer"); transf_amnt_txt.Focus();}
            else if (transf_amnt_txt.Text == "0") { MessageBox.Show("The transfer amount is too small"); transf_amnt_txt.Focus(); }
            else if (tranfs_rmk_txt.Text == "") { MessageBox.Show("please enter a narrative");tranfs_rmk_txt.Focus();}


            //input is OK!
            else
            {
                decimal balance = AccountRepository.checkBalance(id, trans_cmb.Text);
                decimal amountToTransfer = decimal.Parse(transf_amnt_txt.Text);
                 // restricting minimum balance
                if (trans_cmb.Text == "Saving Account" && (balance - amountToTransfer) <= 1000)
                {
                        MessageBox.Show("Unable to transfer the minimum balance for savings account is 1000 Naira");
                        transf_amnt_txt.Focus();
                }
                else if (balance < amountToTransfer)
                {
                    MessageBox.Show("Unable to transfer Insufficient Balance");
                    transf_amnt_txt.Focus();
                }
                else
                {
                    if(MessageBox.Show($"Confirm the transfer of {transf_amnt_txt.Text} to {transf_recvr_txt.Text}", "Transfer Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string respond = TransactionRepository.transferFund(id, transf_recvr_txt.Text, amountToTransfer, tranfs_rmk_txt.Text, trans_cmb.Text);
                        if (respond == "OK")
                        {
                            MessageBox.Show("Transfer was successful ");
                            trans_cmb.Text = "";
                            transf_recvr_txt.Text = "";
                            transf_amnt_txt.Text = "";
                            tranfs_rmk_txt.Text = "";
                            trans_cmb.Focus();
                        }
                        else
                        {
                            MessageBox.Show(respond);
                        }
                    }

                }

            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            string path = file.logpath;
            data = FileRepository.readFile(path);
            string line = data[data.Count - 1];
            string id = line.Split(",")[0];
            string accType = sttmnt_cmb.Text;
            string statement = "";
            data.Clear();
            data = TransactionRepository.getAccountStatement(id , accType);



            foreach (var item in data)
            {
                sttmt_list.Items.Add(new ListViewItem(new string[] { item.Split(",")[4] }));
            }

        }
    }
}

