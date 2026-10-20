using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AssigmentPersonalinfo
{
    public partial class Form1 : Form

    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpboxtravel_Enter(object sender, EventArgs e)
        {

        }



        private void btncalculate_Click(object sender, EventArgs e)
        {
           
            string PassengerName = txtName.Text.Trim();

            if(PassengerName == "")
            {
                MessageBox.Show("Enter Passenger  Name");
                return;
            }

            if(txtAge.Text == "" || txtTickets.Text == "" || txtWeight.Text == "")
            {
                MessageBox.Show("Please fill all information");
                return;
            }

            //convert input validate

            int passengerAge = Convert.ToInt32(txtAge.Text);
            int NumberOfTickets = Convert.ToInt32(txtTickets.Text);
            double baggageWeight = Convert.ToDouble(txtWeight.Text);

            //validate pessenger Age

            if (passengerAge < 1 || passengerAge > 100)
            {
                MessageBox.Show("Age must be between 1 and 100");
                return;
            }

            else if (NumberOfTickets < 1 || NumberOfTickets > 5)
            {
                MessageBox.Show("Tickets must be between 1 and 5");
                return;
            }
            else if (baggageWeight < 0 ||
                    baggageWeight > 50 * NumberOfTickets)
            {
                MessageBox.Show(
                    "Baggage cannot be negative or exceed 50 kg per ticket.");
                return;
            }

            // Check travel class

            string travelClass = "";

            if (radiobtnFirst.Checked)
            {
                travelClass = "First Class";
            }
            else if (radiobtnNormal.Checked)
            {
                travelClass = "Normal Class";
            }
            else if (radiobtnbusiness.Checked)
            {
                travelClass = "Business Class";
            }
            else
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            // Reject First Class for passengers below 12

            if (passengerAge < 12 && travelClass == "First Class")
            {
                MessageBox.Show(
                    "Passengers below 12 cannot book First Class.");
                return;
            }

            // Select ticket price using switch

            double ticketPrice = 0;

            switch (travelClass)
            {
                case "First Class":
                    ticketPrice = 200;
                    break;

                case "Normal Class":
                    ticketPrice = 100;
                    break;

                case "Business Class":
                    ticketPrice = 150;
                    break;

                default:
                    MessageBox.Show("Invalid travel class.");
                    return;
            }

            // Calculate basic ticket cost

            double basicCost = ticketPrice * NumberOfTickets;

            // Quantity discount using switch

            double quantityDiscountRate = 0;

            switch (NumberOfTickets)
            {
                case 1:
                case 2:
                    quantityDiscountRate = 0;
                    break;

                case 3:
                case 4:
                    quantityDiscountRate = 0.05;
                    break;

                case 5:
                    quantityDiscountRate = 0.10;
                    break;
            }

            double quantityDiscount =
                basicCost * quantityDiscountRate;

            double costAfterQuantityDiscount =
                basicCost - quantityDiscount;

            // Age discount
            double ageDiscountRate = 0;

            if (passengerAge < 12)
            {
                ageDiscountRate = 0.20;
            }
            else if (passengerAge >= 60)
            {
                ageDiscountRate = 0.10;
            }

            double ageDiscount =
                costAfterQuantityDiscount * ageDiscountRate;

            double discountedCost =
                costAfterQuantityDiscount - ageDiscount;

            // Travel insurance

            double insuranceCost = 0;

            if (chkinsurance.Checked)
            {
                insuranceCost = 25 * NumberOfTickets;
            }

            // Baggage allowance

            double freeBaggageLimit = 20 * NumberOfTickets;

            string baggageStatus;

            if (baggageWeight <= freeBaggageLimit)
            {
                baggageStatus = "Free";
            }
            else
            {
                baggageStatus = "Above free allowance";
            }

            // Final cost

            double finalCost = discountedCost + insuranceCost;





            // Display booking details


            listdisplay.Items.Clear();

            listdisplay.Items.Add("AIRLINE BOOKING DETAILS");
            listdisplay.Items.Add("------------------------------");
            listdisplay.Items.Add("Passenger Name: " + PassengerName);
            listdisplay.Items.Add("Passenger Age: " + passengerAge);
            listdisplay.Items.Add("Number of Tickets: " + NumberOfTickets);
            listdisplay.Items.Add("Travel Class: " + travelClass);
            listdisplay.Items.Add("Baggage Weight: " + baggageWeight + " kg");
            listdisplay.Items.Add("Baggage Status: " + baggageStatus);
            listdisplay.Items.Add("Ticket Price: $" + ticketPrice.ToString("F2"));
            listdisplay.Items.Add("Basic Ticket Cost: $" + basicCost.ToString("F2"));
            listdisplay.Items.Add("Quantity Discount: $" + quantityDiscount.ToString("F2"));
            listdisplay.Items.Add("Age Discount: $" + ageDiscount.ToString("F2"));
            listdisplay.Items.Add("Insurance Cost: $" + insuranceCost.ToString("F2"));
            listdisplay.Items.Add("Final Cost: $" + finalCost.ToString("F2"));
            listdisplay.Items.Add("------------------------------");
            listdisplay.Items.Add("Booking Status: Approved");




        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtTickets.Clear();
            txtWeight.Clear();
            radiobtnNormal.Checked = true;
            chkinsurance.Checked = false;
            listdisplay.Items.Clear();
            txtName.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


