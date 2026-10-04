using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssignmenthotel
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

        private void lblroomtype_Click(object sender, EventArgs e)
        {

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculatate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Declaring variables
                string guestName, roomType;
                int nights;
                double pricePerNight;
                double subtotal, serviceTax, discount, totalAmount;

                // 2. Initialisation value
                guestName = txtguestname.Text;
                roomType = txtroomtype.Text;

                nights = int.Parse(txtnumberofnights.Text);
                pricePerNight = double.Parse(txtpricepernight.Text);

                // 3. Calculation
                subtotal = nights * pricePerNight;

                // 4. Service Tax (10%)
                serviceTax = subtotal * 0.10;

                // 5. Discount (5%)
                discount = subtotal * 0.05;

                // 6. Total amount
                totalAmount = subtotal + serviceTax - discount;

                // 7. Display results
                txtservicetax.Text = serviceTax.ToString("F2");
                txtdiscount.Text = discount.ToString("F2");
                txttotalamount.Text = totalAmount.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Fadlan geli tiro sax ah (lambar kaliya) Nights iyo Price ku.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wax khalad ah ayaa dhacay: " + ex.Message);
            }
        
    }
    }
}
