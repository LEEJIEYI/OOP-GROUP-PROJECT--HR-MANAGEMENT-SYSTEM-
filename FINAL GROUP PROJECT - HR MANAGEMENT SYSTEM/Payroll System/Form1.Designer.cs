namespace PayrollSystem_
{
    partial class groupBoxEmployee
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.groupBoxSalary = new System.Windows.Forms.GroupBox();
            this.labelBasic = new System.Windows.Forms.Label();
            this.labelOTRate = new System.Windows.Forms.Label();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.txtOvertimeHours = new System.Windows.Forms.TextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.labelOT = new System.Windows.Forms.Label();
            this.labelAllowance = new System.Windows.Forms.Label();
            this.labelBonus = new System.Windows.Forms.Label();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.groupBoxDeduction = new System.Windows.Forms.GroupBox();
            this.txtLateDeduction = new System.Windows.Forms.TextBox();
            this.txtTaxDeduction = new System.Windows.Forms.TextBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelLate = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxSalary.SuspendLayout();
            this.groupBoxDeduction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelPosition);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtPosition);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Full Name:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(6, 65);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(69, 20);
            this.labelPosition.TabIndex = 1;
            this.labelPosition.Text = "Position:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtName.Location = new System.Drawing.Point(132, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(284, 26);
            this.txtName.TabIndex = 10;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPosition.Location = new System.Drawing.Point(132, 62);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(284, 26);
            this.txtPosition.TabIndex = 11;
            // 
            // groupBoxSalary
            // 
            this.groupBoxSalary.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxSalary.Controls.Add(this.labelBasic);
            this.groupBoxSalary.Controls.Add(this.labelOTRate);
            this.groupBoxSalary.Controls.Add(this.txtAllowance);
            this.groupBoxSalary.Controls.Add(this.txtOvertimeHours);
            this.groupBoxSalary.Controls.Add(this.txtBonus);
            this.groupBoxSalary.Controls.Add(this.labelOT);
            this.groupBoxSalary.Controls.Add(this.labelAllowance);
            this.groupBoxSalary.Controls.Add(this.labelBonus);
            this.groupBoxSalary.Controls.Add(this.txtBasicSalary);
            this.groupBoxSalary.Location = new System.Drawing.Point(460, 18);
            this.groupBoxSalary.Name = "groupBoxSalary";
            this.groupBoxSalary.Size = new System.Drawing.Size(490, 215);
            this.groupBoxSalary.TabIndex = 0;
            this.groupBoxSalary.TabStop = false;
            this.groupBoxSalary.Text = " Salary & Earnings";
            // 
            // labelBasic
            // 
            this.labelBasic.AutoSize = true;
            this.labelBasic.Location = new System.Drawing.Point(6, 33);
            this.labelBasic.Name = "labelBasic";
            this.labelBasic.Size = new System.Drawing.Size(139, 20);
            this.labelBasic.TabIndex = 2;
            this.labelBasic.Text = "Basic Salary (RM):";
            // 
            // labelOTRate
            // 
            this.labelOTRate.AutoSize = true;
            this.labelOTRate.Location = new System.Drawing.Point(6, 192);
            this.labelOTRate.Name = "labelOTRate";
            this.labelOTRate.Size = new System.Drawing.Size(98, 20);
            this.labelOTRate.TabIndex = 6;
            this.labelOTRate.Text = "(RM20/hour)";
            this.labelOTRate.Click += new System.EventHandler(this.labelOTRate_Click);
            // 
            // txtAllowance
            // 
            this.txtAllowance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAllowance.Location = new System.Drawing.Point(151, 121);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(315, 26);
            this.txtAllowance.TabIndex = 14;
            this.txtAllowance.TextChanged += new System.EventHandler(this.txtAllowance_TextChanged);
            // 
            // txtOvertimeHours
            // 
            this.txtOvertimeHours.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOvertimeHours.Location = new System.Drawing.Point(151, 166);
            this.txtOvertimeHours.Name = "txtOvertimeHours";
            this.txtOvertimeHours.Size = new System.Drawing.Size(315, 26);
            this.txtOvertimeHours.TabIndex = 15;
            this.txtOvertimeHours.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtBonus
            // 
            this.txtBonus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBonus.Location = new System.Drawing.Point(151, 77);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(315, 26);
            this.txtBonus.TabIndex = 13;
            this.txtBonus.TextChanged += new System.EventHandler(this.txtBonus_TextChanged);
            // 
            // labelOT
            // 
            this.labelOT.AutoSize = true;
            this.labelOT.Location = new System.Drawing.Point(6, 172);
            this.labelOT.Name = "labelOT";
            this.labelOT.Size = new System.Drawing.Size(123, 20);
            this.labelOT.TabIndex = 5;
            this.labelOT.Text = "Overtime Hours:";
            this.labelOT.Click += new System.EventHandler(this.labelOT_Click);
            // 
            // labelAllowance
            // 
            this.labelAllowance.AutoSize = true;
            this.labelAllowance.Location = new System.Drawing.Point(6, 124);
            this.labelAllowance.Name = "labelAllowance";
            this.labelAllowance.Size = new System.Drawing.Size(124, 20);
            this.labelAllowance.TabIndex = 4;
            this.labelAllowance.Text = "Allowance (RM):";
            this.labelAllowance.Click += new System.EventHandler(this.labelAllowance_Click);
            // 
            // labelBonus
            // 
            this.labelBonus.AutoSize = true;
            this.labelBonus.Location = new System.Drawing.Point(6, 80);
            this.labelBonus.Name = "labelBonus";
            this.labelBonus.Size = new System.Drawing.Size(98, 20);
            this.labelBonus.TabIndex = 3;
            this.labelBonus.Text = "Bonus (RM):";
            this.labelBonus.Click += new System.EventHandler(this.labelBonus_Click);
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBasicSalary.Location = new System.Drawing.Point(151, 30);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(315, 26);
            this.txtBasicSalary.TabIndex = 12;
            // 
            // groupBoxDeduction
            // 
            this.groupBoxDeduction.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxDeduction.Controls.Add(this.txtLateDeduction);
            this.groupBoxDeduction.Controls.Add(this.txtTaxDeduction);
            this.groupBoxDeduction.Controls.Add(this.labelTax);
            this.groupBoxDeduction.Controls.Add(this.labelLate);
            this.groupBoxDeduction.Location = new System.Drawing.Point(12, 133);
            this.groupBoxDeduction.Name = "groupBoxDeduction";
            this.groupBoxDeduction.Size = new System.Drawing.Size(422, 100);
            this.groupBoxDeduction.TabIndex = 0;
            this.groupBoxDeduction.TabStop = false;
            this.groupBoxDeduction.Text = "Deductions";
            // 
            // txtLateDeduction
            // 
            this.txtLateDeduction.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLateDeduction.Location = new System.Drawing.Point(173, 62);
            this.txtLateDeduction.Name = "txtLateDeduction";
            this.txtLateDeduction.Size = new System.Drawing.Size(229, 26);
            this.txtLateDeduction.TabIndex = 18;
            this.txtLateDeduction.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtTaxDeduction
            // 
            this.txtTaxDeduction.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTaxDeduction.Location = new System.Drawing.Point(173, 26);
            this.txtTaxDeduction.Name = "txtTaxDeduction";
            this.txtTaxDeduction.Size = new System.Drawing.Size(229, 26);
            this.txtTaxDeduction.TabIndex = 17;
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(6, 32);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(154, 20);
            this.labelTax.TabIndex = 7;
            this.labelTax.Text = "Tax Deduction (RM):";
            // 
            // labelLate
            // 
            this.labelLate.AutoSize = true;
            this.labelLate.Location = new System.Drawing.Point(6, 62);
            this.labelLate.Name = "labelLate";
            this.labelLate.Size = new System.Drawing.Size(161, 20);
            this.labelLate.TabIndex = 8;
            this.labelLate.Text = "Late Deduction (RM):";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(12, 293);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(122, 20);
            this.labelOutput.TabIndex = 9;
            this.labelOutput.Text = "Pay Slip Output:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(12, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(422, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Generate Pay Slip";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtOutput.Location = new System.Drawing.Point(12, 316);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(938, 374);
            this.txtOutput.TabIndex = 17;
            this.txtOutput.Text = "";
            this.txtOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBoxEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 702);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxSalary);
            this.Controls.Add(this.groupBoxDeduction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelOutput);
            this.Name = "groupBoxEmployee";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSalary.ResumeLayout(false);
            this.groupBoxSalary.PerformLayout();
            this.groupBoxDeduction.ResumeLayout(false);
            this.groupBoxDeduction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxSalary;
        private System.Windows.Forms.GroupBox groupBoxDeduction;
        private System.Windows.Forms.TextBox txtOvertimeHours;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelLate;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelOTRate;
        private System.Windows.Forms.Label labelOT;
        private System.Windows.Forms.Label labelAllowance;
        private System.Windows.Forms.Label labelBonus;
        private System.Windows.Forms.Label labelBasic;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLateDeduction;
        private System.Windows.Forms.TextBox txtTaxDeduction;
        private System.Windows.Forms.RichTextBox txtOutput;
    }
}

