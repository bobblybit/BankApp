﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            this.Hide();
            home home = new home();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
             cust_details_form custform = new cust_details_form();
            custform.Show();
        }
    }
}