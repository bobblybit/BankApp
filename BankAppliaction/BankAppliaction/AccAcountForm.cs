﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AxisBank.lib.Model;
using AxisBank.lib.Core;

namespace BankAppliaction
{
    public partial class AccAcountForm : Form
    {
        public AccAcountForm()
        {
            InitializeComponent();
        }

        private void deposit_btn_Click(object sender, EventArgs e)
        {
            //setting variables
            List<string> data = new List<string>();
            string path = file.logpath;
            string custId = "";
            string acctId = "";
            string initailAmount = add_acc_init_amt_txt.Text;

            // getting login user data
            data = FileRepository.readFile(path);
            foreach (var item in data)
            {
                custId = item.Split(",")[0];
            }

            //getting setting account type
            data = AccountRepository.getAccountById(custId);
            string accType = "";
            foreach (var item in data)
            {
                accType = item.Split(",")[5];
            }
            if (accType == "Saving Account")
            {
                accType = "Current Account";
            }
            else
            {
                accType = "Saving Account";
            }

            //creating a new account
            if (MessageBox.Show($"Confirm The Opening of {accType} with sum {initailAmount}", "Deposit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (AccountRepository.createNewAccount(custId, initailAmount, accType))
                {
                    MessageBox.Show("Was created Successfully Login Again to see newly created account");
                    this.Hide();
                }
            }






        }

        private void cost_fname_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccAcountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
