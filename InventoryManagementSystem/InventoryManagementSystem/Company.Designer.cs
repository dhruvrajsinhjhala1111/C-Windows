namespace InventoryManagementSystem
{
    partial class Company
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.txtcompanyname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.txtdescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ADD);
            this.panel1.Controls.Add(this.txtcompanyname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(52, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 261);
            this.panel1.TabIndex = 0;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(145, 106);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(202, 20);
            this.txtdescription.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESCRIPTION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(145, 171);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 53);
            this.ADD.TabIndex = 2;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // txtcompanyname
            // 
            this.txtcompanyname.Location = new System.Drawing.Point(145, 48);
            this.txtcompanyname.Name = "txtcompanyname";
            this.txtcompanyname.Size = new System.Drawing.Size(202, 20);
            this.txtcompanyname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPANY NAME";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Company";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox txtcompanyname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}