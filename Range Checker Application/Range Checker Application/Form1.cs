using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Checker_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(txtnumber.Text, out number))
            {
                if (number >= 1 && number <= 10)
                {
                    lblrangedecisions.Text = "The number is in the range.";
                }
                else
                {
                    lblrangedecisions.Text = "The number is NOT in the range.";
                }
            }
            else
            {
                lblrangedecisions.Text = "Please enter an integer.";
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnumber.Text = "";
            lblrangedecision.Text = "";
            txtnumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
