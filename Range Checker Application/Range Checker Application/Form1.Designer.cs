namespace Range_Checker_Application
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
            this.lblinteger = new System.Windows.Forms.Label();
            this.lblrangedecision = new System.Windows.Forms.Label();
            this.lblrangedecisions = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblinteger
            // 
            this.lblinteger.AutoSize = true;
            this.lblinteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinteger.Location = new System.Drawing.Point(164, 35);
            this.lblinteger.Name = "lblinteger";
            this.lblinteger.Size = new System.Drawing.Size(503, 26);
            this.lblinteger.TabIndex = 0;
            this.lblinteger.Text = "Enter an integer  in the range  of 1 throught 10";
            this.lblinteger.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblrangedecision
            // 
            this.lblrangedecision.AutoSize = true;
            this.lblrangedecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrangedecision.Location = new System.Drawing.Point(323, 150);
            this.lblrangedecision.Name = "lblrangedecision";
            this.lblrangedecision.Size = new System.Drawing.Size(180, 26);
            this.lblrangedecision.TabIndex = 2;
            this.lblrangedecision.Text = "Range Decision";
            // 
            // lblrangedecisions
            // 
            this.lblrangedecisions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrangedecisions.Location = new System.Drawing.Point(169, 191);
            this.lblrangedecisions.Name = "lblrangedecisions";
            this.lblrangedecisions.Size = new System.Drawing.Size(486, 39);
            this.lblrangedecisions.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(216, 253);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(158, 85);
            this.btncheck.TabIndex = 7;
            this.btncheck.Text = "Check Qualification";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(380, 253);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(123, 42);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear ";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(380, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.SystemColors.Menu;
            this.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumber.Location = new System.Drawing.Point(279, 77);
            this.txtnumber.Multiline = true;
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(245, 45);
            this.txtnumber.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblrangedecisions);
            this.Controls.Add(this.lblrangedecision);
            this.Controls.Add(this.lblinteger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinteger;
        private System.Windows.Forms.Label lblrangedecision;
        private System.Windows.Forms.Label lblrangedecisions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtnumber;
    }
}

