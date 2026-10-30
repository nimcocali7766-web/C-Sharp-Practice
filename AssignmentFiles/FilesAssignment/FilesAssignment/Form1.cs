using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilesAssignment
{
    public partial class Form1 : Form
        
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfunction_Click(object sender, EventArgs e)
        {


            string FilePath = @"D:\C##\first-exaple\FilesAssignment\FilesAssignment\name.txt.txt"; 

            try
            {
                if (!File.Exists(FilePath))
                {
              
                    MessageBox.Show("Faylka lama helin: " + FilePath);
                    return;
                }

                listBox1.Items.Clear();

                string[] lines = File.ReadAllLines(FilePath);
                foreach (string line in lines)
                {
                    listBox1.Items.AddRange(lines);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Ma haysatid ogolaansho aad ku akhrido faylkan.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Khalad akhrinta: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khalad aan la fileyn: " + ex.Message);
            }
        }

        private void btndeletefile_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("Liiska waa madhan yahay.");
                    return;
                }

                listBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khalad: " + ex.Message);
            }
        }
        

            
        private void btndeleteitemfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Fadlan marka hore dooro item ka mid ah liiska.");
                    return;
                }

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khalad: " + ex.Message);
            }
        }
    }
}
   

    
    

    
    

