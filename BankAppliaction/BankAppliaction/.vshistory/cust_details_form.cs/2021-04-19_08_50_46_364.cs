﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankAppliaction
{
    public partial class cust_details_form : Form
    {
        public cust_details_form()
        {
            InitializeComponent();
        }

        private void email_lbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
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

            string value = "";
            bool isChecked = current_acc_rtn.Checked;
            if (isChecked)
                value = current_acc_rtn.Text;
            else
                value = saving_acc_rtn.Text;

            List<string> costumerDits = new List<string>();
            costumerDits.Add(cost_fname_txt.Text);
            costumerDits.Add(cost_lname_txt.Text);
            costumerDits.Add(cost_Phone_txt.Text);
            costumerDits.Add(cost_adress_txt.Text);



            //costumerDits.Add(value);
            //ostumerDits.Add(cost_initamount_txt.Text);
            string name = AxisBank.lib.Core.authRepository.addNewCostumer(costumerDits);
            MessageBox.Show(name);



        }

        private void cust_lname_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_gbx_txt_Enter(object sender, EventArgs e)
        {

        }
    }
}
