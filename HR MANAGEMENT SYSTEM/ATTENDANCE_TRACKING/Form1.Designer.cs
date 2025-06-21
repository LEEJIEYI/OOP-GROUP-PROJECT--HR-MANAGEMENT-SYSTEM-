namespace AttendanceApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnShowRecords;
        private System.Windows.Forms.DataGridView dgvRecords;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnShowRecords = new System.Windows.Forms.Button();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();

            // lblEmployeeId
            this.lblEmployeeId.Location = new System.Drawing.Point(20, 20);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(85, 20);
            this.lblEmployeeId.Text = "Employee ID :";

            // txtEmployeeId
            this.txtEmployeeId.Location = new System.Drawing.Point(110, 20);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(155, 20);

            // btnCheckIn
            this.btnCheckIn.Location = new System.Drawing.Point(20, 60);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(80, 30);
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);

            // btnCheckOut
            this.btnCheckOut.Location = new System.Drawing.Point(110, 60);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(80, 30);
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);

            // btnShowRecords
            this.btnShowRecords.Location = new System.Drawing.Point(200, 60);
            this.btnShowRecords.Name = "btnShowRecords";
            this.btnShowRecords.Size = new System.Drawing.Size(100, 30);
            this.btnShowRecords.Text = "Show Records";
            this.btnShowRecords.UseVisualStyleBackColor = true;
            this.btnShowRecords.Click += new System.EventHandler(this.btnShowRecords_Click);

            // dgvRecords
            this.dgvRecords.Location = new System.Drawing.Point(20, 110);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.Size = new System.Drawing.Size(360, 200);
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 340);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnShowRecords);
            this.Controls.Add(this.dgvRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "HR Attendance Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
