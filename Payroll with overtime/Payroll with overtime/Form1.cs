using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculategross_Click(object sender, EventArgs e)
        {
            double hoursWorked;
            double hourlyPayRate;
            double grossPay;

            // Validation

            if (double.TryParse(txthoursworked.Text, out hoursWorked))
            {
                if (double.TryParse(txthourlypay.Text, out hourlyPayRate))
                {
                    // Check hours

                    if (hoursWorked <= 40)
                    {
                        grossPay = hoursWorked * hourlyPayRate;
                    }
                    else
                    {
                        // Overtime

                        double regularPay = 40 * hourlyPayRate;
                        double overtimeHours = hoursWorked - 40;
                        double overtimePay = overtimeHours * hourlyPayRate * 1.5;

                        grossPay = regularPay + overtimePay;
                    }

                    lblgross.Text = grossPay.ToString("C2");
                }
                else
                {
                    MessageBox.Show("Please enter a valid hourly pay rate.");
                    txthourlypay.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number of hours.");
                txthoursworked.Focus();
            }
        
    }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txthoursworked.Text = "";
            txthourlypay.Text = "";
            lblgross.Text = "";
            txthoursworked.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
