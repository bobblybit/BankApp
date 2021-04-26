using System;
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
            // getting user data to display
            List<string> data = new List<string>();
            string path = file.logpath;
            data = FileRepository.readFile(path);
            //setting user data for dashboard
            string custId = "";
            string acctId = "";

            foreach (var item in data)
            {
                custId = item.Split(",")[0];
            }
        }
    }
}
