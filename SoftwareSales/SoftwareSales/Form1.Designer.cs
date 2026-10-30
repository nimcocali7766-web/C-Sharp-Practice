namespace AssignmentSoftwareSales
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblNumberofpackage = new System.Windows.Forms.Label();
            this.lblPriceperpackage = new System.Windows.Forms.Label();
            this.txtnumberofpackage = new System.Windows.Forms.TextBox();
            this.txtpriceperpackage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listbox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.txtpriceperpackage);
            this.groupBox1.Controls.Add(this.txtnumberofpackage);
            this.groupBox1.Controls.Add(this.lblPriceperpackage);
            this.groupBox1.Controls.Add(this.lblNumberofpackage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1.Personal Information";
            // 
            // lblNumberofpackage
            // 
            this.lblNumberofpackage.AutoSize = true;
            this.lblNumberofpackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofpackage.Location = new System.Drawing.Point(19, 44);
            this.lblNumberofpackage.Name = "lblNumberofpackage";
            this.lblNumberofpackage.Size = new System.Drawing.Size(199, 25);
            this.lblNumberofpackage.TabIndex = 0;
            this.lblNumberofpackage.Text = "Number Of Packages";
            // 
            // lblPriceperpackage
            // 
            this.lblPriceperpackage.AutoSize = true;
            this.lblPriceperpackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceperpackage.Location = new System.Drawing.Point(19, 88);
            this.lblPriceperpackage.Name = "lblPriceperpackage";
            this.lblPriceperpackage.Size = new System.Drawing.Size(173, 25);
            this.lblPriceperpackage.TabIndex = 1;
            this.lblPriceperpackage.Text = "Price Per Package";
            // 
            // txtnumberofpackage
            // 
            this.txtnumberofpackage.Location = new System.Drawing.Point(246, 44);
            this.txtnumberofpackage.Name = "txtnumberofpackage";
            this.txtnumberofpackage.Size = new System.Drawing.Size(183, 30);
            this.txtnumberofpackage.TabIndex = 1;
            // 
            // txtpriceperpackage
            // 
            this.txtpriceperpackage.Location = new System.Drawing.Point(246, 88);
            this.txtpriceperpackage.Name = "txtpriceperpackage";
            this.txtpriceperpackage.Size = new System.Drawing.Size(183, 30);
            this.txtpriceperpackage.TabIndex = 2;
            this.txtpriceperpackage.TextChanged += new System.EventHandler(this.txtpriceperpackage_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.Location = new System.Drawing.Point(24, 153);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(168, 67);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(198, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 67);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(323, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 67);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listbox1
            // 
            this.listbox1.FormattingEnabled = true;
            this.listbox1.ItemHeight = 20;
            this.listbox1.Location = new System.Drawing.Point(532, 31);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(286, 444);
            this.listbox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 554);
            this.Controls.Add(this.listbox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtpriceperpackage;
        private System.Windows.Forms.TextBox txtnumberofpackage;
        private System.Windows.Forms.Label lblPriceperpackage;
        private System.Windows.Forms.Label lblNumberofpackage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listbox1;
    }
}

