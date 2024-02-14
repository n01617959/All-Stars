namespace RestaurantManagementSystem
{
    partial class SalaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtSalaryAmount = new System.Windows.Forms.TextBox();
            this.listViewSalaries = new System.Windows.Forms.ListView();
            this.btnAddSalary = new System.Windows.Forms.Button();
            this.btnUpdateSalary = new System.Windows.Forms.Button();
            this.btnCalculateGrossSalary = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTaxPercentage = new System.Windows.Forms.ComboBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment Date";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(413, 427);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeID.TabIndex = 4;
            // 
            // txtSalaryAmount
            // 
            this.txtSalaryAmount.Location = new System.Drawing.Point(413, 498);
            this.txtSalaryAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalaryAmount.Name = "txtSalaryAmount";
            this.txtSalaryAmount.Size = new System.Drawing.Size(100, 22);
            this.txtSalaryAmount.TabIndex = 5;
            // 
            // listViewSalaries
            // 
            this.listViewSalaries.HideSelection = false;
            this.listViewSalaries.Location = new System.Drawing.Point(260, 95);
            this.listViewSalaries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewSalaries.Name = "listViewSalaries";
            this.listViewSalaries.Size = new System.Drawing.Size(651, 258);
            this.listViewSalaries.TabIndex = 8;
            this.listViewSalaries.UseCompatibleStateImageBehavior = false;
            this.listViewSalaries.View = System.Windows.Forms.View.Details;
            this.listViewSalaries.SelectedIndexChanged += new System.EventHandler(this.listViewSalaries_SelectedIndexChanged);
            // 
            // btnAddSalary
            // 
            this.btnAddSalary.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAddSalary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSalary.Location = new System.Drawing.Point(269, 606);
            this.btnAddSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSalary.Name = "btnAddSalary";
            this.btnAddSalary.Size = new System.Drawing.Size(123, 43);
            this.btnAddSalary.TabIndex = 9;
            this.btnAddSalary.Text = "Add";
            this.btnAddSalary.UseVisualStyleBackColor = false;
            this.btnAddSalary.Click += new System.EventHandler(this.btnAddSalary_Click);
            // 
            // btnUpdateSalary
            // 
            this.btnUpdateSalary.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateSalary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateSalary.Location = new System.Drawing.Point(459, 606);
            this.btnUpdateSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateSalary.Name = "btnUpdateSalary";
            this.btnUpdateSalary.Size = new System.Drawing.Size(112, 43);
            this.btnUpdateSalary.TabIndex = 10;
            this.btnUpdateSalary.Text = "Update";
            this.btnUpdateSalary.UseVisualStyleBackColor = false;
            this.btnUpdateSalary.Click += new System.EventHandler(this.btnUpdateSalary_Click);
            // 
            // btnCalculateGrossSalary
            // 
            this.btnCalculateGrossSalary.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCalculateGrossSalary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculateGrossSalary.Location = new System.Drawing.Point(635, 606);
            this.btnCalculateGrossSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculateGrossSalary.Name = "btnCalculateGrossSalary";
            this.btnCalculateGrossSalary.Size = new System.Drawing.Size(101, 43);
            this.btnCalculateGrossSalary.TabIndex = 11;
            this.btnCalculateGrossSalary.Text = "Gross Salary";
            this.btnCalculateGrossSalary.UseVisualStyleBackColor = false;
            this.btnCalculateGrossSalary.Click += new System.EventHandler(this.btnCalculateGrossSalary_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(407, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Salary Management";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(720, 427);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(576, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tax Percentage";
            // 
            // cmbTaxPercentage
            // 
            this.cmbTaxPercentage.FormattingEnabled = true;
            this.cmbTaxPercentage.Items.AddRange(new object[] {
            "13",
            "18",
            "22",
            "28"});
            this.cmbTaxPercentage.Location = new System.Drawing.Point(720, 496);
            this.cmbTaxPercentage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTaxPercentage.Name = "cmbTaxPercentage";
            this.cmbTaxPercentage.Size = new System.Drawing.Size(121, 24);
            this.cmbTaxPercentage.TabIndex = 14;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoBack.Location = new System.Drawing.Point(28, 411);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(147, 53);
            this.btnGoBack.TabIndex = 15;
            this.btnGoBack.Text = "Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnGoBack);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 702);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 38);
            this.label6.TabIndex = 18;
            this.label6.Text = "WELCOME";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(28, 580);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 57);
            this.button1.TabIndex = 16;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.BackColor = System.Drawing.Color.DarkBlue;
            this.bttnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnClear.Location = new System.Drawing.Point(795, 606);
            this.bttnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(101, 43);
            this.bttnClear.TabIndex = 17;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = false;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 217);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 146);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(923, 706);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbTaxPercentage);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculateGrossSalary);
            this.Controls.Add(this.btnUpdateSalary);
            this.Controls.Add(this.btnAddSalary);
            this.Controls.Add(this.listViewSalaries);
            this.Controls.Add(this.txtSalaryAmount);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalaryForm";
            this.Text = "SalaryForm";
            this.Load += new System.EventHandler(this.SalaryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtSalaryAmount;
        private System.Windows.Forms.ListView listViewSalaries;
        private System.Windows.Forms.Button btnAddSalary;
        private System.Windows.Forms.Button btnUpdateSalary;
        private System.Windows.Forms.Button btnCalculateGrossSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTaxPercentage;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnClear;
    }
}