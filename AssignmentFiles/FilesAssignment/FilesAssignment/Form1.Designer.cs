namespace FilesAssignment
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
            this.btndeleteitemfile = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btndeletefile = new System.Windows.Forms.Button();
            this.btnfunction = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btndeleteitemfile
            // 
            this.btndeleteitemfile.Location = new System.Drawing.Point(453, 231);
            this.btndeleteitemfile.Name = "btndeleteitemfile";
            this.btndeleteitemfile.Size = new System.Drawing.Size(182, 70);
            this.btndeleteitemfile.TabIndex = 0;
            this.btndeleteitemfile.Text = "Delete the item file";
            this.btndeleteitemfile.UseVisualStyleBackColor = true;
            this.btndeleteitemfile.Click += new System.EventHandler(this.btndeleteitemfile_Click);
            // 
            // btndeletefile
            // 
            this.btndeletefile.Location = new System.Drawing.Point(234, 231);
            this.btndeletefile.Name = "btndeletefile";
            this.btndeletefile.Size = new System.Drawing.Size(173, 70);
            this.btndeletefile.TabIndex = 1;
            this.btndeletefile.Text = "Delete the file";
            this.btndeletefile.UseVisualStyleBackColor = true;
            this.btndeletefile.Click += new System.EventHandler(this.btndeletefile_Click);
            // 
            // btnfunction
            // 
            this.btnfunction.Location = new System.Drawing.Point(12, 231);
            this.btnfunction.Name = "btnfunction";
            this.btnfunction.Size = new System.Drawing.Size(199, 70);
            this.btnfunction.TabIndex = 2;
            this.btnfunction.Text = "Reading other function";
            this.btnfunction.UseVisualStyleBackColor = true;
            this.btnfunction.Click += new System.EventHandler(this.btnfunction_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(690, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 384);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 483);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnfunction);
            this.Controls.Add(this.btndeletefile);
            this.Controls.Add(this.btndeleteitemfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndeleteitemfile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btndeletefile;
        private System.Windows.Forms.Button btnfunction;
        private System.Windows.Forms.ListBox listBox1;
    }
}

