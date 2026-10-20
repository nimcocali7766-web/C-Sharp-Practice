using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking_Systen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

        
            string guestName = txtName.Text.Trim();

            if (guestName == "")
            {
                MessageBox.Show("Please enter guest name.");
                return;
            }

            int guestAge, nights, guests;

            if (!int.TryParse(txtAge.Text, out guestAge) ||
                !int.TryParse(txtnights.Text, out nights) ||
                !int.TryParse(txtGuests.Text, out guests))
            {
                MessageBox.Show("Please enter valid numeric information.");
                return;
            }

            if (guestAge < 18 || guestAge > 90)
            {
                MessageBox.Show("Guest age must be between 18 and 90.");
                return;
            }
            else if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Number of nights must be between 1 and 30.");
                return;
            }
            else if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Number of guests must be between 1 and 6.");
                return;
            }

            string roomType = "";
            double ratePerNight = 0;
            int maxGuests = 0;

            switch (true)
            {
                case true when radiostandard.Checked:
                    roomType = "Standard";
                    ratePerNight = 50;
                    maxGuests = 2;
                    break;

                case true when radionormal.Checked:
                    roomType = "Normal";
                    ratePerNight = 80;
                    maxGuests = 4;
                    break;

                case true when radiohight.Checked:
                    roomType = "Hight";
                    ratePerNight = 130;
                    maxGuests = 6;
                    break;

                default:
                    MessageBox.Show("Please select a room type.");
                    return;
            }

            if (guests > maxGuests)
            {
                MessageBox.Show(roomType + " room allows a maximum of "
                    + maxGuests + " guests.");
                return;
            }

            double basicCost = ratePerNight * nights;
            double discountRate = 0;

            if (nights >= 1 && nights <= 4)
            {
                discountRate = 0;
            }
            else if (nights >= 5 && nights <= 9)
            {
                discountRate = 0.05;
            }
            else if (nights >= 10)
            {
                discountRate = 0.12;
            }

            double discount = basicCost * discountRate;
            double costAfterDiscount = basicCost - discount;

            double breakfastCost = 0;

            if (chkbreakfast.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            double serviceCharge = 0;

            if (guests > 4)
            {
                serviceCharge = costAfterDiscount * 0.05;
            }

            double seniorDiscount = 0;

            if (guestAge >= 60)
            {
                seniorDiscount = costAfterDiscount * 0.05;
            }

            double finalCost = costAfterDiscount
                             + breakfastCost
                             + serviceCharge
                             - seniorDiscount;

            bool bookingApproved = true;

           

            listdisplay.Items.Add("HOTEL BOOKING DETAILS");
            listdisplay.Items.Add("------------------------------");
            listdisplay.Items.Add("Guest Name: " + guestName);
            listdisplay.Items.Add("Guest Age: " + guestAge);
            listdisplay.Items.Add("Number of Nights: " + nights);
            listdisplay.Items.Add("Number of Guests: " + guests);
            listdisplay.Items.Add("Room Type: " + roomType);
            listdisplay.Items.Add("Rate Per Night: $" + ratePerNight.ToString("F2"));
            listdisplay.Items.Add("Basic Cost: $" + basicCost.ToString("F2"));
            listdisplay.Items.Add("Discount: -$" + discount.ToString("F2"));
            listdisplay.Items.Add("Breakfast Cost: $" + breakfastCost.ToString("F2"));
            listdisplay.Items.Add("Service Charge: $" + serviceCharge.ToString("F2"));
            listdisplay.Items.Add("Senior Discount: -$" + seniorDiscount.ToString("F2"));
            listdisplay.Items.Add("Final Cost: $" + finalCost.ToString("F2"));
            listdisplay.Items.Add("------------------------------");
            listdisplay.Items.Add("Booking Status: " +
                (bookingApproved ? "Approved" : "Rejected"));
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtnights.Clear();
            txtGuests.Clear();

            radiostandard.Checked = false;
            radionormal.Checked = false;
            radiohight.Checked = false;
            chkbreakfast.Checked = false;

            listdisplay.Items.Clear();


        }
    }
}

