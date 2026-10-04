namespace Assignment_if_elseif
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
            this.lblscore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblaveragee = new System.Windows.Forms.Label();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblscore1
            // 
            this.lblscore1.Location = new System.Drawing.Point(37, 41);
            this.lblscore1.Name = "lblscore1";
            this.lblscore1.Size = new System.Drawing.Size(153, 45);
            this.lblscore1.TabIndex = 0;
            this.lblscore1.Text = "Test Score #1";
            // 
            // lblScore2
            // 
            this.lblScore2.Location = new System.Drawing.Point(37, 86);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(153, 45);
            this.lblScore2.TabIndex = 1;
            this.lblScore2.Text = "Test Score #2";
            // 
            // lblScore3
            // 
            this.lblScore3.Location = new System.Drawing.Point(37, 131);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(153, 45);
            this.lblScore3.TabIndex = 2;
            this.lblScore3.Text = "Test Score #3";
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(48, 175);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(119, 30);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Average";
            this.lblAverage.Click += new System.EventHandler(this.lblAverage_Click);
            // 
            // lblaveragee
            // 
            this.lblaveragee.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblaveragee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblaveragee.Location = new System.Drawing.Point(196, 174);
            this.lblaveragee.Name = "lblaveragee";
            this.lblaveragee.Size = new System.Drawing.Size(153, 30);
            this.lblaveragee.TabIndex = 4;
            // 
            // txtScore1
            // 
            this.txtScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore1.Location = new System.Drawing.Point(196, 39);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(158, 26);
            this.txtScore1.TabIndex = 5;
            // 
            // txtScore3
            // 
            this.txtScore3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore3.Location = new System.Drawing.Point(196, 129);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(158, 26);
            this.txtScore3.TabIndex = 6;
            // 
            // txtScore2
            // 
            this.txtScore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore2.Location = new System.Drawing.Point(196, 84);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(158, 26);
            this.txtScore2.TabIndex = 7;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncalculate.Location = new System.Drawing.Point(226, 286);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(123, 94);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "Calculate Average ";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Location = new System.Drawing.Point(385, 286);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(103, 44);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(385, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 44);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.txtScore3);
            this.groupbox1.Controls.Add(this.lblscore1);
            this.groupbox1.Controls.Add(this.lblScore2);
            this.groupbox1.Controls.Add(this.lblScore3);
            this.groupbox1.Controls.Add(this.txtScore2);
            this.groupbox1.Controls.Add(this.lblAverage);
            this.groupbox1.Controls.Add(this.lblaveragee);
            this.groupbox1.Controls.Add(this.txtScore1);
            this.groupbox1.Location = new System.Drawing.Point(159, 32);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(387, 248);
            this.groupbox1.TabIndex = 11;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Enter Three Text Scores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 539);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Name = "Form1";
            this.Text = "form1";
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblscore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore3;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblaveragee;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupbox1;
    }
}

