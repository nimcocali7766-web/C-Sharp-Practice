using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentSoftwareSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtpriceperpackage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //variables

            int quantity;
            int priceperpackage;
          

            if (!int.TryParse(txtnumberofpackage.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid number ");
                txtnumberofpackage.Focus();
                return;
            }

            if(!int.TryParse(txtpriceperpackage.Text, out priceperpackage) || priceperpackage < 0)
            {
                MessageBox.Show("fadlan gali number sax ah");
                txtpriceperpackage.Focus();
                return;
            }



            double packagePrice = 99.00;
            double discountRate = 0.0;

            //parts of discount

            if (quantity >= 10 && quantity <= 19)
            {
                discountRate = 0.20;
            }
            else if (quantity >= 20 && quantity <= 49)
            {
                discountRate = 0.30;
            }
            else if (quantity >= 50 && quantity <= 99)
            {
                discountRate = 0.40;
            }
            else if (quantity >= 100)
            {
                discountRate = 0.50;
            }
            else
            {
                discountRate = 0.0;
            }

            

            double subtotal = quantity * packagePrice;
            double discountAmount = subtotal * discountRate;
            double totalAmount = subtotal - discountAmount;


            // list display  OUTPUT

            listbox1.Items.Clear();
            listbox1.Items.Add("SOFTWARE SALES RESULTS");
            listbox1.Items.Add("------------------------------");
            listbox1.Items.Add("Number of Packages: " + quantity);
            listbox1.Items.Add("Price per Package: $" + packagePrice.ToString("f2"));
            listbox1.Items.Add("Subtotal (Before Discount): $" + subtotal.ToString("f2"));
            listbox1.Items.Add("Discount Rate: " + (discountRate * 100) + "%");
            listbox1.Items.Add("Discount Amount: $" + discountAmount.ToString("F2"));
            listbox1.Items.Add("Total Amount (After Discount: $" + totalAmount.ToString("f2"));


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtnumberofpackage.Clear();
            txtpriceperpackage.Clear();
            txtnumberofpackage.Clear();
            

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
