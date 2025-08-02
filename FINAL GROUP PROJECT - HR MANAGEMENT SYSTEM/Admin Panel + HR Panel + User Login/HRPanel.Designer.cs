namespace HRManagementSystem
{
    partial class HRPanel
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Button btnLeaveSystem;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnLogout;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.btnLeaveSystem = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(212, 74);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HR Dashboard";
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.Location = new System.Drawing.Point(212, 125);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(160, 30);
            this.btnEmployeeManagement.TabIndex = 1;
            this.btnEmployeeManagement.Text = "Employee Management";
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // btnLeaveSystem
            // 
            this.btnLeaveSystem.Location = new System.Drawing.Point(212, 165);
            this.btnLeaveSystem.Name = "btnLeaveSystem";
            this.btnLeaveSystem.Size = new System.Drawing.Size(160, 30);
            this.btnLeaveSystem.TabIndex = 2;
            this.btnLeaveSystem.Text = "Leave System";
            this.btnLeaveSystem.Click += new System.EventHandler(this.btnLeaveSystem_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Location = new System.Drawing.Point(212, 205);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(160, 30);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.Text = "Attendance Tracking";
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(212, 245);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 30);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // HRPanel
            // 
            this.ClientSize = new System.Drawing.Size(625, 369);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnEmployeeManagement);
            this.Controls.Add(this.btnLeaveSystem);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnLogout);
            this.Name = "HRPanel";
            this.Text = "HR Panel";
            this.Load += new System.EventHandler(this.HRPanel_Load);
            this.ResumeLayout(false);

        }
    }
}
