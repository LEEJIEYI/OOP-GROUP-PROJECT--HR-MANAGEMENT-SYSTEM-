namespace Payroll_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtDeductions = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(42, 331);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(695, 96);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(175, 95);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 22);
            this.txtPosition.TabIndex = 9;
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Location = new System.Drawing.Point(175, 132);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(100, 22);
            this.txtBasicSalary.TabIndex = 10;
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(175, 167);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(100, 22);
            this.txtBonus.TabIndex = 11;
            // 
            // txtDeductions
            // 
            this.txtDeductions.Location = new System.Drawing.Point(175, 196);
            this.txtDeductions.Name = "txtDeductions";
            this.txtDeductions.Size = new System.Drawing.Size(100, 22);
            this.txtDeductions.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDeductions);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.txtBasicSalary);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtDeductions;
        private System.Windows.Forms.Label label7;
    }
}

