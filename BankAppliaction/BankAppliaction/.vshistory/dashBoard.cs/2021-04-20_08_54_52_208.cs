using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            if (deposit_acc_text.Text == "")
            {
                MessageBox.Show("The Account Field is Empty Please enter Account an Number ");
                deposit_acc_text.Focus();
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
            if (true)
            {

            }
        }

        private void cost_fname_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
