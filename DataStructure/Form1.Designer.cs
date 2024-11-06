namespace DataStructure
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
            this.lblenter = new System.Windows.Forms.Label();
            this.txtenter = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtprogram = new System.Windows.Forms.TextBox();
            this.txtextension = new System.Windows.Forms.TextBox();
            this.lblprogram = new System.Windows.Forms.Label();
            this.lblextension = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblenter
            // 
            this.lblenter.AutoSize = true;
            this.lblenter.Location = new System.Drawing.Point(17, 13);
            this.lblenter.Name = "lblenter";
            this.lblenter.Size = new System.Drawing.Size(100, 13);
            this.lblenter.TabIndex = 0;
            this.lblenter.Text = "Enter File Extension";
            // 
            // txtenter
            // 
            this.txtenter.Location = new System.Drawing.Point(16, 40);
            this.txtenter.Name = "txtenter";
            this.txtenter.Size = new System.Drawing.Size(100, 20);
            this.txtenter.TabIndex = 1;
            this.txtenter.TextChanged += new System.EventHandler(this.txtenter_TextChanged);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(140, 38);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(108, 23);
            this.btnfind.TabIndex = 2;
            this.btnfind.Text = "Find Detail Program";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(27, 72);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(75, 23);
            this.btnlist.TabIndex = 3;
            this.btnlist.Text = "List All";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // txtdisplay
            // 
            this.txtdisplay.Location = new System.Drawing.Point(16, 120);
            this.txtdisplay.Multiline = true;
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.Size = new System.Drawing.Size(256, 131);
            this.txtdisplay.TabIndex = 4;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(254, 121);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 129);
            this.vScrollBar1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtprogram);
            this.groupBox1.Controls.Add(this.txtextension);
            this.groupBox1.Controls.Add(this.lblprogram);
            this.groupBox1.Controls.Add(this.lblextension);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Location = new System.Drawing.Point(292, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Entry";
            // 
            // txtprogram
            // 
            this.txtprogram.Location = new System.Drawing.Point(73, 53);
            this.txtprogram.Name = "txtprogram";
            this.txtprogram.Size = new System.Drawing.Size(100, 20);
            this.txtprogram.TabIndex = 4;
            // 
            // txtextension
            // 
            this.txtextension.Location = new System.Drawing.Point(73, 21);
            this.txtextension.Name = "txtextension";
            this.txtextension.Size = new System.Drawing.Size(100, 20);
            this.txtextension.TabIndex = 3;
            // 
            // lblprogram
            // 
            this.lblprogram.AutoSize = true;
            this.lblprogram.Location = new System.Drawing.Point(17, 56);
            this.lblprogram.Name = "lblprogram";
            this.lblprogram.Size = new System.Drawing.Size(46, 13);
            this.lblprogram.TabIndex = 2;
            this.lblprogram.Text = "Program";
            // 
            // lblextension
            // 
            this.lblextension.AutoSize = true;
            this.lblextension.Location = new System.Drawing.Point(14, 24);
            this.lblextension.Name = "lblextension";
            this.lblextension.Size = new System.Drawing.Size(53, 13);
            this.lblextension.TabIndex = 1;
            this.lblextension.Text = "Extension";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(59, 84);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(89, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add New Entry";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnclear);
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Location = new System.Drawing.Point(292, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Entry";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(55, 61);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(85, 23);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Clear All Entry";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(60, 28);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "Delete Entry";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 263);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.txtdisplay);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtenter);
            this.Controls.Add(this.lblenter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblenter;
        private System.Windows.Forms.TextBox txtenter;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtprogram;
        private System.Windows.Forms.TextBox txtextension;
        private System.Windows.Forms.Label lblprogram;
        private System.Windows.Forms.Label lblextension;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
    }
}

