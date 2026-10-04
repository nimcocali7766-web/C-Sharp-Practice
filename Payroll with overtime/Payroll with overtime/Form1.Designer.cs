namespace Payroll_with_overtime
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
            this.lblHourse = new System.Windows.Forms.Label();
            this.lblGrosspay = new System.Windows.Forms.Label();
            this.lblhourlypayrate = new System.Windows.Forms.Label();
            this.txthoursworked = new System.Windows.Forms.TextBox();
            this.txthourlypay = new System.Windows.Forms.TextBox();
            this.lblgross = new System.Windows.Forms.Label();
            this.btncalculategross = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHourse
            // 
            this.lblHourse.AutoSize = true;
            this.lblHourse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourse.Location = new System.Drawing.Point(148, 62);
            this.lblHourse.Name = "lblHourse";
            this.lblHourse.Size = new System.Drawing.Size(123, 20);
            this.lblHourse.TabIndex = 0;
            this.lblHourse.Text = "Hours Worked";
            // 
            // lblGrosspay
            // 
            this.lblGrosspay.AutoSize = true;
            this.lblGrosspay.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrosspay.Location = new System.Drawing.Point(165, 178);
            this.lblGrosspay.Name = "lblGrosspay";
            this.lblGrosspay.Size = new System.Drawing.Size(88, 20);
            this.lblGrosspay.TabIndex = 1;
            this.lblGrosspay.Text = "Gross Pay";
            // 
            // lblhourlypayrate
            // 
            this.lblhourlypayrate.AutoSize = true;
            this.lblhourlypayrate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhourlypayrate.Location = new System.Drawing.Point(148, 119);
            this.lblhourlypayrate.Name = "lblhourlypayrate";
            this.lblhourlypayrate.Size = new System.Drawing.Size(132, 20);
            this.lblhourlypayrate.TabIndex = 2;
            this.lblhourlypayrate.Text = "Hourly pay rate";
            // 
            // txthoursworked
            // 
            this.txthoursworked.Location = new System.Drawing.Point(302, 62);
            this.txthoursworked.Multiline = true;
            this.txthoursworked.Name = "txthoursworked";
            this.txthoursworked.Size = new System.Drawing.Size(180, 36);
            this.txthoursworked.TabIndex = 3;
            // 
            // txthourlypay
            // 
            this.txthourlypay.Location = new System.Drawing.Point(302, 116);
            this.txthourlypay.Multiline = true;
            this.txthourlypay.Name = "txthourlypay";
            this.txthourlypay.Size = new System.Drawing.Size(180, 36);
            this.txthourlypay.TabIndex = 6;
            // 
            // lblgross
            // 
            this.lblgross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblgross.Location = new System.Drawing.Point(302, 178);
            this.lblgross.Name = "lblgross";
            this.lblgross.Size = new System.Drawing.Size(180, 39);
            this.lblgross.TabIndex = 7;
            // 
            // btncalculategross
            // 
            this.btncalculategross.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncalculategross.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculategross.Location = new System.Drawing.Point(98, 217);
            this.btncalculategross.Name = "btncalculategross";
            this.btncalculategross.Size = new System.Drawing.Size(135, 88);
            this.btncalculategross.TabIndex = 8;
            this.btncalculategross.Text = "Calculate Gross Pay";
            this.btncalculategross.UseVisualStyleBackColor = false;
            this.btncalculategross.Click += new System.EventHandler(this.btncalculategross_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(248, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 65);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(418, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 65);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btncalculategross);
            this.Controls.Add(this.lblgross);
            this.Controls.Add(this.txthourlypay);
            this.Controls.Add(this.txthoursworked);
            this.Controls.Add(this.lblhourlypayrate);
            this.Controls.Add(this.lblGrosspay);
            this.Controls.Add(this.lblHourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHourse;
        private System.Windows.Forms.Label lblGrosspay;
        private System.Windows.Forms.Label lblhourlypayrate;
        private System.Windows.Forms.TextBox txthoursworked;
        private System.Windows.Forms.TextBox txthourlypay;
        private System.Windows.Forms.Label lblgross;
        private System.Windows.Forms.Button btncalculategross;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

