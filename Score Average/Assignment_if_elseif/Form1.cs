using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Assignment_if_elseif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblAverage_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            double Score1, Score2, Score3;
            double average;

            if (double.TryParse(txtScore1.Text, out Score1) &&
                double.TryParse(txtScore2.Text, out Score2) &&
                double.TryParse(txtScore3.Text, out Score3))
            {
                if (Score1 < 0 || Score1 > 100)
                {
                    MessageBox.Show("Score #1 must be between 0 and 100");
                }
                else if (Score2 < 0 || Score2 > 100)
                {
                    MessageBox.Show("Score #2 must be between 0 and 100");
                }
                else if (Score3 < 0 || Score3 > 100)
                {
                    MessageBox.Show("Score #3 must be between 0 and 100");
                }
                else
                {
                    average = (Score1 + Score2 + Score3) / 3;

                    lblaveragee.Text = average.ToString("0.0");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
        

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            lblaveragee.Text = string.Empty;
            txtScore1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
