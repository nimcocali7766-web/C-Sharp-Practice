namespace Assignment2
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
            this.txtfood1 = new System.Windows.Forms.TextBox();
            this.txtfoodprice2 = new System.Windows.Forms.TextBox();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.txtfoodprice1 = new System.Windows.Forms.TextBox();
            this.lblfood1 = new System.Windows.Forms.Label();
            this.lblfoodprice2 = new System.Windows.Forms.Label();
            this.lblfood2 = new System.Windows.Forms.Label();
            this.lblfoodprice1 = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.lblsalestax = new System.Windows.Forms.Label();
            this.lblsalesamount = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfood1
            // 
            this.txtfood1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfood1.Location = new System.Drawing.Point(332, 21);
            this.txtfood1.Multiline = true;
            this.txtfood1.Name = "txtfood1";
            this.txtfood1.Size = new System.Drawing.Size(269, 41);
            this.txtfood1.TabIndex = 3;
            // 
            // txtfoodprice2
            // 
            this.txtfoodprice2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfoodprice2.Location = new System.Drawing.Point(332, 177);
            this.txtfoodprice2.Multiline = true;
            this.txtfoodprice2.Name = "txtfoodprice2";
            this.txtfoodprice2.Size = new System.Drawing.Size(269, 46);
            this.txtfoodprice2.TabIndex = 5;
            // 
            // txtfood2
            // 
            this.txtfood2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfood2.Location = new System.Drawing.Point(332, 121);
            this.txtfood2.Multiline = true;
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(269, 49);
            this.txtfood2.TabIndex = 6;
            // 
            // txtfoodprice1
            // 
            this.txtfoodprice1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfoodprice1.Location = new System.Drawing.Point(332, 68);
            this.txtfoodprice1.Multiline = true;
            this.txtfoodprice1.Name = "txtfoodprice1";
            this.txtfoodprice1.Size = new System.Drawing.Size(269, 47);
            this.txtfoodprice1.TabIndex = 7;
            // 
            // lblfood1
            // 
            this.lblfood1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood1.Location = new System.Drawing.Point(139, 32);
            this.lblfood1.Name = "lblfood1";
            this.lblfood1.Size = new System.Drawing.Size(187, 46);
            this.lblfood1.TabIndex = 8;
            this.lblfood1.Text = "Enter Food 1";
            this.lblfood1.Click += new System.EventHandler(this.lblfood1_Click);
            // 
            // lblfoodprice2
            // 
            this.lblfoodprice2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfoodprice2.Location = new System.Drawing.Point(139, 177);
            this.lblfoodprice2.Name = "lblfoodprice2";
            this.lblfoodprice2.Size = new System.Drawing.Size(187, 46);
            this.lblfoodprice2.TabIndex = 11;
            this.lblfoodprice2.Text = "Enter Food Price";
            // 
            // lblfood2
            // 
            this.lblfood2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood2.Location = new System.Drawing.Point(139, 124);
            this.lblfood2.Name = "lblfood2";
            this.lblfood2.Size = new System.Drawing.Size(187, 46);
            this.lblfood2.TabIndex = 12;
            this.lblfood2.Text = "Enter Food 2";
            // 
            // lblfoodprice1
            // 
            this.lblfoodprice1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfoodprice1.Location = new System.Drawing.Point(139, 78);
            this.lblfoodprice1.Name = "lblfoodprice1";
            this.lblfoodprice1.Size = new System.Drawing.Size(187, 46);
            this.lblfoodprice1.TabIndex = 13;
            this.lblfoodprice1.Text = "Enter Food Price";
            // 
            // lbltax
            // 
            this.lbltax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltax.Location = new System.Drawing.Point(255, 330);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(464, 53);
            this.lbltax.TabIndex = 14;
            // 
            // lblamount
            // 
            this.lblamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblamount.Location = new System.Drawing.Point(255, 396);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(464, 53);
            this.lblamount.TabIndex = 15;
            // 
            // lblsalestax
            // 
            this.lblsalestax.AutoSize = true;
            this.lblsalestax.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalestax.Location = new System.Drawing.Point(131, 345);
            this.lblsalestax.Name = "lblsalestax";
            this.lblsalestax.Size = new System.Drawing.Size(108, 23);
            this.lblsalestax.TabIndex = 16;
            this.lblsalestax.Text = "Sales Tax is";
            // 
            // lblsalesamount
            // 
            this.lblsalesamount.AutoSize = true;
            this.lblsalesamount.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalesamount.Location = new System.Drawing.Point(97, 415);
            this.lblsalesamount.Name = "lblsalesamount";
            this.lblsalesamount.Size = new System.Drawing.Size(142, 23);
            this.lblsalesamount.TabIndex = 17;
            this.lblsalesamount.Text = "Sales Amount is";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(367, 243);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(189, 65);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 568);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblsalesamount);
            this.Controls.Add(this.lblsalestax);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lbltax);
            this.Controls.Add(this.lblfoodprice1);
            this.Controls.Add(this.lblfood2);
            this.Controls.Add(this.lblfoodprice2);
            this.Controls.Add(this.lblfood1);
            this.Controls.Add(this.txtfoodprice1);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.txtfoodprice2);
            this.Controls.Add(this.txtfood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfood1;
        private System.Windows.Forms.TextBox txtfoodprice2;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.TextBox txtfoodprice1;
        private System.Windows.Forms.Label lblfood1;
        private System.Windows.Forms.Label lblfoodprice2;
        private System.Windows.Forms.Label lblfood2;
        private System.Windows.Forms.Label lblfoodprice1;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label lblsalestax;
        private System.Windows.Forms.Label lblsalesamount;
        private System.Windows.Forms.Button btnCalculate;
    }
}

