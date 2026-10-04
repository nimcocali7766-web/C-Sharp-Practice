using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblfood1_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Create variables
                string food1, food2;
                double foodPrice1, foodPrice2;
                double tax, totalAmount;

                // Get values from the text boxes
                food1 = txtfood1.Text;
                food2 = txtfood2.Text;

                foodPrice1 = double.Parse(txtfoodprice1.Text);
                foodPrice2 = double.Parse(txtfoodprice2.Text);

                // Add the two food prices
                double subtotal = foodPrice1 + foodPrice2;

                // Calculate 7% sales tax
                tax = subtotal * 0.07;

                // Find the final amount
                totalAmount = subtotal + tax;

                // Show sales tax
                lbltax.Text = tax.ToString("F2");

                // Show total price
                lblamount.Text = totalAmount.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fadlan geli qiimo sax ah oo tiro ah.");
            }
        }
    }
}