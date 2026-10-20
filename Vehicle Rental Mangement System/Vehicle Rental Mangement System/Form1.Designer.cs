namespace Vehicle_Rental_Mangement_System
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
            this.lblName = new System.Windows.Forms.Label();
            this.lbldays = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.VehicleType = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rdoeconomy = new System.Windows.Forms.RadioButton();
            this.rdosuv = new System.Windows.Forms.RadioButton();
            this.rdoluxury = new System.Windows.Forms.RadioButton();
            this.grpboxinsurance = new System.Windows.Forms.GroupBox();
            this.chkinsurance = new System.Windows.Forms.CheckBox();
            this.lstresults = new System.Windows.Forms.ListBox();
            this.VehicleType.SuspendLayout();
            this.grpboxinsurance.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(133, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(226, 34);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Customer Name";
            // 
            // lbldays
            // 
            this.lbldays.Location = new System.Drawing.Point(133, 134);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(226, 34);
            this.lbldays.TabIndex = 1;
            this.lbldays.Text = "Enter Number Of Rental Days";
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(133, 96);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(226, 34);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Enter Cuatomer Age";
            // 
            // lblExperience
            // 
            this.lblExperience.Location = new System.Drawing.Point(133, 184);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(226, 34);
            this.lblExperience.TabIndex = 3;
            this.lblExperience.Text = "Enter Years of Driving Experience";
            this.lblExperience.Click += new System.EventHandler(this.lblYearsExperience_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(397, 47);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 36);
            this.txtName.TabIndex = 6;
            // 
            // txtExperience
            // 
            this.txtExperience.Location = new System.Drawing.Point(397, 184);
            this.txtExperience.Multiline = true;
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(287, 36);
            this.txtExperience.TabIndex = 8;
            // 
            // txtdays
            // 
            this.txtdays.Location = new System.Drawing.Point(397, 131);
            this.txtdays.Multiline = true;
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(287, 36);
            this.txtdays.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(397, 89);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(287, 36);
            this.txtAge.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(165, 501);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(151, 63);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(347, 501);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 63);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(533, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 63);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // VehicleType
            // 
            this.VehicleType.Controls.Add(this.rdoluxury);
            this.VehicleType.Controls.Add(this.rdosuv);
            this.VehicleType.Controls.Add(this.rdoeconomy);
            this.VehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.VehicleType.Location = new System.Drawing.Point(137, 259);
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.Size = new System.Drawing.Size(547, 113);
            this.VehicleType.TabIndex = 15;
            this.VehicleType.TabStop = false;
            this.VehicleType.Text = "Vehicle Type";
            // 
            // rdoeconomy
            // 
            this.rdoeconomy.AutoSize = true;
            this.rdoeconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoeconomy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoeconomy.Location = new System.Drawing.Point(18, 50);
            this.rdoeconomy.Name = "rdoeconomy";
            this.rdoeconomy.Size = new System.Drawing.Size(109, 26);
            this.rdoeconomy.TabIndex = 0;
            this.rdoeconomy.TabStop = true;
            this.rdoeconomy.Text = "Economy";
            this.rdoeconomy.UseVisualStyleBackColor = true;
            this.rdoeconomy.CheckedChanged += new System.EventHandler(this.rdoeconomy_CheckedChanged);
            // 
            // rdosuv
            // 
            this.rdosuv.AutoSize = true;
            this.rdosuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdosuv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdosuv.Location = new System.Drawing.Point(210, 50);
            this.rdosuv.Name = "rdosuv";
            this.rdosuv.Size = new System.Drawing.Size(66, 26);
            this.rdosuv.TabIndex = 1;
            this.rdosuv.TabStop = true;
            this.rdosuv.Text = "Suv";
            this.rdosuv.UseVisualStyleBackColor = true;
            // 
            // rdoluxury
            // 
            this.rdoluxury.AutoSize = true;
            this.rdoluxury.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoluxury.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoluxury.Location = new System.Drawing.Point(386, 50);
            this.rdoluxury.Name = "rdoluxury";
            this.rdoluxury.Size = new System.Drawing.Size(89, 26);
            this.rdoluxury.TabIndex = 2;
            this.rdoluxury.TabStop = true;
            this.rdoluxury.Text = "Luxury";
            this.rdoluxury.UseVisualStyleBackColor = true;
            // 
            // grpboxinsurance
            // 
            this.grpboxinsurance.Controls.Add(this.chkinsurance);
            this.grpboxinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxinsurance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpboxinsurance.Location = new System.Drawing.Point(137, 394);
            this.grpboxinsurance.Name = "grpboxinsurance";
            this.grpboxinsurance.Size = new System.Drawing.Size(490, 85);
            this.grpboxinsurance.TabIndex = 16;
            this.grpboxinsurance.TabStop = false;
            this.grpboxinsurance.Text = "Insurance Option";
            // 
            // chkinsurance
            // 
            this.chkinsurance.AutoSize = true;
            this.chkinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkinsurance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkinsurance.Location = new System.Drawing.Point(18, 40);
            this.chkinsurance.Name = "chkinsurance";
            this.chkinsurance.Size = new System.Drawing.Size(265, 26);
            this.chkinsurance.TabIndex = 0;
            this.chkinsurance.Text = "Add Insurance($ 15 Per day)";
            this.chkinsurance.UseVisualStyleBackColor = true;
            // 
            // lstresults
            // 
            this.lstresults.FormattingEnabled = true;
            this.lstresults.ItemHeight = 20;
            this.lstresults.Location = new System.Drawing.Point(864, 49);
            this.lstresults.Name = "lstresults";
            this.lstresults.Size = new System.Drawing.Size(278, 424);
            this.lstresults.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 646);
            this.Controls.Add(this.lstresults);
            this.Controls.Add(this.grpboxinsurance);
            this.Controls.Add(this.VehicleType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtdays);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lbldays);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.VehicleType.ResumeLayout(false);
            this.VehicleType.PerformLayout();
            this.grpboxinsurance.ResumeLayout(false);
            this.grpboxinsurance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox VehicleType;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdoeconomy;
        private System.Windows.Forms.RadioButton rdoluxury;
        private System.Windows.Forms.RadioButton rdosuv;
        private System.Windows.Forms.GroupBox grpboxinsurance;
        private System.Windows.Forms.CheckBox chkinsurance;
        private System.Windows.Forms.ListBox lstresults;
    }
}

