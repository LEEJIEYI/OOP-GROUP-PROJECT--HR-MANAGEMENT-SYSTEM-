namespace HRManagementSystem
{
    partial class ViewSelectorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnHR;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(80, 50);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(120, 40);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin View";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnHR
            // 
            this.btnHR.Location = new System.Drawing.Point(80, 110);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(120, 40);
            this.btnHR.TabIndex = 1;
            this.btnHR.Text = "HR View";
            this.btnHR.UseVisualStyleBackColor = true;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // ViewSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnHR);
            this.Name = "ViewSelectorForm";
            this.Text = "Choose View";
            this.Load += new System.EventHandler(this.ViewSelectorForm_Load);
            this.ResumeLayout(false);
        }
    }
}
