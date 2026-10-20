namespace Hotel_Room_Booking_Systen
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
            this.groupboxpersonalinfo = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblguestname = new System.Windows.Forms.Label();
            this.lblnumberofnights = new System.Windows.Forms.Label();
            this.lblgustAge = new System.Windows.Forms.Label();
            this.lblnumberofguests = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.groupBoxroomtype = new System.Windows.Forms.GroupBox();
            this.radiostandard = new System.Windows.Forms.RadioButton();
            this.radionormal = new System.Windows.Forms.RadioButton();
            this.radiohight = new System.Windows.Forms.RadioButton();
            this.groupBoxaditional = new System.Windows.Forms.GroupBox();
            this.chkbreakfast = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.listdisplay = new System.Windows.Forms.ListBox();
            this.groupboxpersonalinfo.SuspendLayout();
            this.groupBoxroomtype.SuspendLayout();
            this.groupBoxaditional.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxpersonalinfo
            // 
            this.groupboxpersonalinfo.BackColor = System.Drawing.SystemColors.Control;
            this.groupboxpersonalinfo.Controls.Add(this.txtAge);
            this.groupboxpersonalinfo.Controls.Add(this.txtGuests);
            this.groupboxpersonalinfo.Controls.Add(this.txtnights);
            this.groupboxpersonalinfo.Controls.Add(this.txtName);
            this.groupboxpersonalinfo.Controls.Add(this.lblnumberofguests);
            this.groupboxpersonalinfo.Controls.Add(this.lblgustAge);
            this.groupboxpersonalinfo.Controls.Add(this.lblnumberofnights);
            this.groupboxpersonalinfo.Controls.Add(this.lblguestname);
            this.groupboxpersonalinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxpersonalinfo.Location = new System.Drawing.Point(22, 25);
            this.groupboxpersonalinfo.Name = "groupboxpersonalinfo";
            this.groupboxpersonalinfo.Size = new System.Drawing.Size(478, 247);
            this.groupboxpersonalinfo.TabIndex = 0;
            this.groupboxpersonalinfo.TabStop = false;
            this.groupboxpersonalinfo.Text = "Personal Information";
            // 
            // lblguestname
            // 
            this.lblguestname.AutoSize = true;
            this.lblguestname.Location = new System.Drawing.Point(85, 48);
            this.lblguestname.Name = "lblguestname";
            this.lblguestname.Size = new System.Drawing.Size(132, 22);
            this.lblguestname.TabIndex = 0;
            this.lblguestname.Text = "Guest Name :";
            // 
            // lblnumberofnights
            // 
            this.lblnumberofnights.AutoSize = true;
            this.lblnumberofnights.Location = new System.Drawing.Point(36, 131);
            this.lblnumberofnights.Name = "lblnumberofnights";
            this.lblnumberofnights.Size = new System.Drawing.Size(181, 22);
            this.lblnumberofnights.TabIndex = 1;
            this.lblnumberofnights.Text = "Number Of Nights :";
            // 
            // lblgustAge
            // 
            this.lblgustAge.AutoSize = true;
            this.lblgustAge.Location = new System.Drawing.Point(101, 92);
            this.lblgustAge.Name = "lblgustAge";
            this.lblgustAge.Size = new System.Drawing.Size(116, 22);
            this.lblgustAge.TabIndex = 2;
            this.lblgustAge.Text = "Guest Age :";
            // 
            // lblnumberofguests
            // 
            this.lblnumberofguests.AutoSize = true;
            this.lblnumberofguests.Location = new System.Drawing.Point(30, 178);
            this.lblnumberofguests.Name = "lblnumberofguests";
            this.lblnumberofguests.Size = new System.Drawing.Size(187, 22);
            this.lblnumberofguests.TabIndex = 3;
            this.lblnumberofguests.Text = "Number Of Guests :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(232, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 28);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnights
            // 
            this.txtnights.Location = new System.Drawing.Point(232, 128);
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(240, 28);
            this.txtnights.TabIndex = 5;
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(232, 175);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(240, 28);
            this.txtGuests.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(232, 89);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(240, 28);
            this.txtAge.TabIndex = 7;
            // 
            // groupBoxroomtype
            // 
            this.groupBoxroomtype.Controls.Add(this.radiohight);
            this.groupBoxroomtype.Controls.Add(this.radionormal);
            this.groupBoxroomtype.Controls.Add(this.radiostandard);
            this.groupBoxroomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxroomtype.Location = new System.Drawing.Point(22, 288);
            this.groupBoxroomtype.Name = "groupBoxroomtype";
            this.groupBoxroomtype.Size = new System.Drawing.Size(540, 108);
            this.groupBoxroomtype.TabIndex = 1;
            this.groupBoxroomtype.TabStop = false;
            this.groupBoxroomtype.Text = "Room Type";
            // 
            // radiostandard
            // 
            this.radiostandard.AutoSize = true;
            this.radiostandard.Location = new System.Drawing.Point(22, 51);
            this.radiostandard.Name = "radiostandard";
            this.radiostandard.Size = new System.Drawing.Size(116, 26);
            this.radiostandard.TabIndex = 0;
            this.radiostandard.TabStop = true;
            this.radiostandard.Text = "Standard";
            this.radiostandard.UseVisualStyleBackColor = true;
            // 
            // radionormal
            // 
            this.radionormal.AutoSize = true;
            this.radionormal.Location = new System.Drawing.Point(219, 55);
            this.radionormal.Name = "radionormal";
            this.radionormal.Size = new System.Drawing.Size(98, 26);
            this.radionormal.TabIndex = 1;
            this.radionormal.TabStop = true;
            this.radionormal.Text = "Normal";
            this.radionormal.UseVisualStyleBackColor = true;
            // 
            // radiohight
            // 
            this.radiohight.AutoSize = true;
            this.radiohight.Location = new System.Drawing.Point(393, 55);
            this.radiohight.Name = "radiohight";
            this.radiohight.Size = new System.Drawing.Size(82, 26);
            this.radiohight.TabIndex = 2;
            this.radiohight.TabStop = true;
            this.radiohight.Text = "Hight";
            this.radiohight.UseVisualStyleBackColor = true;
            // 
            // groupBoxaditional
            // 
            this.groupBoxaditional.Controls.Add(this.chkbreakfast);
            this.groupBoxaditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxaditional.Location = new System.Drawing.Point(22, 413);
            this.groupBoxaditional.Name = "groupBoxaditional";
            this.groupBoxaditional.Size = new System.Drawing.Size(540, 83);
            this.groupBoxaditional.TabIndex = 2;
            this.groupBoxaditional.TabStop = false;
            this.groupBoxaditional.Text = "Aditional Options";
            // 
            // chkbreakfast
            // 
            this.chkbreakfast.AutoSize = true;
            this.chkbreakfast.Location = new System.Drawing.Point(16, 49);
            this.chkbreakfast.Name = "chkbreakfast";
            this.chkbreakfast.Size = new System.Drawing.Size(323, 24);
            this.chkbreakfast.TabIndex = 0;
            this.chkbreakfast.Text = "Breakfast(10 per Guest Per Nights) ";
            this.chkbreakfast.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(56, 539);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(138, 46);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(424, 539);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(138, 46);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(254, 539);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(138, 46);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // listdisplay
            // 
            this.listdisplay.FormattingEnabled = true;
            this.listdisplay.ItemHeight = 20;
            this.listdisplay.Location = new System.Drawing.Point(590, 59);
            this.listdisplay.Name = "listdisplay";
            this.listdisplay.Size = new System.Drawing.Size(521, 464);
            this.listdisplay.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1123, 680);
            this.Controls.Add(this.listdisplay);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBoxaditional);
            this.Controls.Add(this.groupBoxroomtype);
            this.Controls.Add(this.groupboxpersonalinfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupboxpersonalinfo.ResumeLayout(false);
            this.groupboxpersonalinfo.PerformLayout();
            this.groupBoxroomtype.ResumeLayout(false);
            this.groupBoxroomtype.PerformLayout();
            this.groupBoxaditional.ResumeLayout(false);
            this.groupBoxaditional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxpersonalinfo;
        private System.Windows.Forms.Label lblnumberofguests;
        private System.Windows.Forms.Label lblgustAge;
        private System.Windows.Forms.Label lblnumberofnights;
        private System.Windows.Forms.Label lblguestname;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.GroupBox groupBoxroomtype;
        private System.Windows.Forms.RadioButton radiohight;
        private System.Windows.Forms.RadioButton radionormal;
        private System.Windows.Forms.RadioButton radiostandard;
        private System.Windows.Forms.GroupBox groupBoxaditional;
        private System.Windows.Forms.CheckBox chkbreakfast;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ListBox listdisplay;
    }
}

