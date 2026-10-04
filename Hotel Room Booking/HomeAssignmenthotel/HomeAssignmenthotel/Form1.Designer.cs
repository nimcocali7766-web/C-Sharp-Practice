namespace HomeAssignmenthotel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblguestname = new System.Windows.Forms.Label();
            this.lblroomtype = new System.Windows.Forms.Label();
            this.lblnumbernights = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtguestname = new System.Windows.Forms.TextBox();
            this.txtpricepernight = new System.Windows.Forms.TextBox();
            this.txtnumberofnights = new System.Windows.Forms.TextBox();
            this.txtroomtype = new System.Windows.Forms.TextBox();
            this.btncalculatate = new System.Windows.Forms.Button();
            this.lblServiceTax = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.txtservicetax = new System.Windows.Forms.TextBox();
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblguestname
            // 
            this.lblguestname.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguestname.Location = new System.Drawing.Point(70, 56);
            this.lblguestname.Name = "lblguestname";
            this.lblguestname.Size = new System.Drawing.Size(168, 43);
            this.lblguestname.TabIndex = 0;
            this.lblguestname.Text = "Enter Guest Name";
            this.lblguestname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblroomtype
            // 
            this.lblroomtype.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomtype.Location = new System.Drawing.Point(70, 106);
            this.lblroomtype.Name = "lblroomtype";
            this.lblroomtype.Size = new System.Drawing.Size(168, 30);
            this.lblroomtype.TabIndex = 1;
            this.lblroomtype.Text = "Enter Room Type";
            this.lblroomtype.Click += new System.EventHandler(this.lblroomtype_Click);
            // 
            // lblnumbernights
            // 
            this.lblnumbernights.AutoSize = true;
            this.lblnumbernights.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumbernights.Location = new System.Drawing.Point(69, 154);
            this.lblnumbernights.Name = "lblnumbernights";
            this.lblnumbernights.Size = new System.Drawing.Size(217, 23);
            this.lblnumbernights.TabIndex = 2;
            this.lblnumbernights.Text = "Enter Number Of Nights";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(69, 211);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(193, 23);
            this.lblprice.TabIndex = 3;
            this.lblprice.Text = "Enter Price Per Night";
            this.lblprice.Click += new System.EventHandler(this.lblprice_Click);
            // 
            // txtguestname
            // 
            this.txtguestname.Location = new System.Drawing.Point(292, 55);
            this.txtguestname.Multiline = true;
            this.txtguestname.Name = "txtguestname";
            this.txtguestname.Size = new System.Drawing.Size(232, 42);
            this.txtguestname.TabIndex = 4;
            // 
            // txtpricepernight
            // 
            this.txtpricepernight.Location = new System.Drawing.Point(292, 201);
            this.txtpricepernight.Multiline = true;
            this.txtpricepernight.Name = "txtpricepernight";
            this.txtpricepernight.Size = new System.Drawing.Size(232, 42);
            this.txtpricepernight.TabIndex = 5;
            // 
            // txtnumberofnights
            // 
            this.txtnumberofnights.Location = new System.Drawing.Point(292, 153);
            this.txtnumberofnights.Multiline = true;
            this.txtnumberofnights.Name = "txtnumberofnights";
            this.txtnumberofnights.Size = new System.Drawing.Size(232, 42);
            this.txtnumberofnights.TabIndex = 6;
            // 
            // txtroomtype
            // 
            this.txtroomtype.Location = new System.Drawing.Point(292, 105);
            this.txtroomtype.Multiline = true;
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(232, 42);
            this.txtroomtype.TabIndex = 7;
            // 
            // btncalculatate
            // 
            this.btncalculatate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncalculatate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculatate.Location = new System.Drawing.Point(292, 272);
            this.btncalculatate.Name = "btncalculatate";
            this.btncalculatate.Size = new System.Drawing.Size(192, 56);
            this.btncalculatate.TabIndex = 8;
            this.btncalculatate.Text = "Calculate Booking";
            this.btncalculatate.UseVisualStyleBackColor = false;
            this.btncalculatate.Click += new System.EventHandler(this.btncalculatate_Click);
            // 
            // lblServiceTax
            // 
            this.lblServiceTax.Location = new System.Drawing.Point(69, 390);
            this.lblServiceTax.Name = "lblServiceTax";
            this.lblServiceTax.Size = new System.Drawing.Size(169, 32);
            this.lblServiceTax.TabIndex = 9;
            this.lblServiceTax.Text = "Service Tax(10%)    :";
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Location = new System.Drawing.Point(70, 422);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(149, 20);
            this.lbldiscount.TabIndex = 10;
            this.lbldiscount.Text = "Discount(5%)          :";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Location = new System.Drawing.Point(70, 464);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(148, 20);
            this.lblamount.TabIndex = 11;
            this.lblamount.Text = "Total Amount          :";
            // 
            // txtservicetax
            // 
            this.txtservicetax.Location = new System.Drawing.Point(283, 390);
            this.txtservicetax.Name = "txtservicetax";
            this.txtservicetax.Size = new System.Drawing.Size(268, 26);
            this.txtservicetax.TabIndex = 12;
            this.txtservicetax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txttotalamount
            // 
            this.txttotalamount.Location = new System.Drawing.Point(283, 454);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.Size = new System.Drawing.Size(268, 26);
            this.txttotalamount.TabIndex = 13;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(283, 422);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(268, 26);
            this.txtdiscount.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 550);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txttotalamount);
            this.Controls.Add(this.txtservicetax);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.lblServiceTax);
            this.Controls.Add(this.btncalculatate);
            this.Controls.Add(this.txtroomtype);
            this.Controls.Add(this.txtnumberofnights);
            this.Controls.Add(this.txtpricepernight);
            this.Controls.Add(this.txtguestname);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblnumbernights);
            this.Controls.Add(this.lblroomtype);
            this.Controls.Add(this.lblguestname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblguestname;
        private System.Windows.Forms.Label lblroomtype;
        private System.Windows.Forms.Label lblnumbernights;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtguestname;
        private System.Windows.Forms.TextBox txtpricepernight;
        private System.Windows.Forms.TextBox txtnumberofnights;
        private System.Windows.Forms.TextBox txtroomtype;
        private System.Windows.Forms.Button btncalculatate;
        private System.Windows.Forms.Label lblServiceTax;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox txtservicetax;
        private System.Windows.Forms.TextBox txttotalamount;
        private System.Windows.Forms.TextBox txtdiscount;
    }
}

