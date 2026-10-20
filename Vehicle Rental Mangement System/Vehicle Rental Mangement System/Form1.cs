using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Vehicle_Rental_Mangement_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblYearsExperience_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string CustomerName = txtName.Text.Trim();

            if (CustomerName == "")
            {
                MessageBox.Show("Enter Customer Name");
                txtName.Focus();
                return;
            }

            int CustomerAge;
            int RentalDays;
            int drivingExperience;

            if (!int.TryParse(txtAge.Text, out CustomerAge))
            {
                MessageBox.Show("Enter A Customer Age");
                txtAge.Focus();
                return;
            }




            else if (!int.TryParse(txtdays.Text, out RentalDays))
            {
                MessageBox.Show("Enter Rentaldays ");
                txtdays.Focus();
                return;
            }
            else if(!int.TryParse(txtExperience.Text,out drivingExperience))
            {
                MessageBox.Show("Enter Driving Experience");
                txtExperience.Focus();
                return;
            }

            if (CustomerAge < 18 || CustomerAge > 80 )
            {
                MessageBox.Show("Age must be between 18 and 80.");
                return;
            }
            else if (RentalDays < 1 || RentalDays > 30)
            {
                MessageBox.Show("Rental days must be between 1 and 30");
                return;
            }

            else if (drivingExperience < 0)
            {
                MessageBox.Show("Driving experience cannot be negative");
                return;
            }
            if (CustomerAge < 21)
            {
                MessageBox.Show("Customers below 21 cannot rent a vehicle.");
                return;
            }

            else if(drivingExperience < 1)
            {
                MessageBox.Show("At least 1 year of driving experience is required");
                return;
            }
            decimal dailyrate = 0;
            string vehicletype = "";

            if (rdoeconomy.Checked)
            {
                dailyrate = 35;
                vehicletype = "Economy";
            }

            else if (rdosuv.Checked)
            {
                dailyrate = 60;
                vehicletype = "SUV";
            }

            else if (rdoluxury.Checked)
            {
               if(CustomerAge < 21 || drivingExperience < 3)
                {
                    MessageBox.Show("Luxury requires age 25 or older and 3 years of driving experience.");
                    return;
                }
                dailyrate = 100;
                vehicletype = "Luxury";
            }
            else
            {
                MessageBox.Show("Please select a vehicle type.");
                return;
            }
            decimal basicRentalCost = dailyrate * RentalDays;

            decimal discountRate = 0;

            if (RentalDays >= 14)
            {
                discountRate = 0.10m;
            }
            else if (RentalDays >= 7)
            {
                discountRate = 0.05m;
            }

            decimal discount = basicRentalCost * discountRate;

            decimal insuranceCost = 0;

            if (chkinsurance.Checked)
            {
                insuranceCost = 15 * RentalDays;
            }

            decimal youngDriverSurcharge = 0;

            if (CustomerAge >= 21 && CustomerAge <= 24)
            {
                youngDriverSurcharge = basicRentalCost * 0.10m;
            }

            decimal finalRentalCost =
                basicRentalCost - discount
                + insuranceCost + youngDriverSurcharge;

            lstresults.Items.Clear();

            lstresults.Items.Add("RENTAL DETAILS");
            lstresults.Items.Add("------------------------------");
            lstresults.Items.Add("Customer Name: " + CustomerName);
            lstresults.Items.Add("Customer Age: " + CustomerAge);
            lstresults.Items.Add("Driving Experience: " + drivingExperience + " years");
            lstresults.Items.Add("Vehicle Type: " + VehicleType);
            lstresults.Items.Add("Daily Rate: $" + dailyrate.ToString("F2"));
            lstresults.Items.Add("Rental Days: " + RentalDays);
            lstresults.Items.Add("Basic Rental Cost: $" + basicRentalCost.ToString("F2"));
            lstresults.Items.Add("Discount: -$" + discount.ToString("F2"));
            lstresults.Items.Add("Insurance Cost: $" + insuranceCost.ToString("F2"));
            lstresults.Items.Add("Young Driver Surcharge: $" + youngDriverSurcharge.ToString("F2"));
            lstresults.Items.Add("Final Rental Cost: $" + finalRentalCost.ToString("F2"));
            lstresults.Items.Add("------------------------------");
            lstresults.Items.Add("Rental Status: Eligible");
        }

        
        

        // Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtAge.Clear();
            txtName.Clear();
            txtdays.Clear();
            txtExperience.Clear();


            rdoeconomy.Checked = false;
            rdosuv.Checked = false;
            rdoluxury.Checked = false;

            chkinsurance.Checked = false;

            lstresults.Items.Clear();

            txtName.Focus();

        }

        private void rdoeconomy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

