namespace HRManagementSystem
{
    partial class AdminPanelForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Button btnDepartmentPosition;
        private System.Windows.Forms.Button btnLeaveSystem;
        private System.Windows.Forms.Button btnAttendanceTracking;
        private System.Windows.Forms.Button btnPayrollSystem;
        private System.Windows.Forms.Button btnLogout;

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.btnDepartmentPosition = new System.Windows.Forms.Button();
            this.btnLeaveSystem = new System.Windows.Forms.Button();
            this.btnAttendanceTracking = new System.Windows.Forms.Button();
            this.btnPayrollSystem = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(100, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(250, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Admin Dashboard";

            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.Location = new System.Drawing.Point(100, 80);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(250, 30);
            this.btnEmployeeManagement.TabIndex = 1;
            this.btnEmployeeManagement.Text = "Employee Management";
            this.btnEmployeeManagement.UseVisualStyleBackColor = true;

            // 
            // btnDepartmentPosition
            // 
            this.btnDepartmentPosition.Location = new System.Drawing.Point(100, 120);
            this.btnDepartmentPosition.Name = "btnDepartmentPosition";
            this.btnDepartmentPosition.Size = new System.Drawing.Size(250, 30);
            this.btnDepartmentPosition.TabIndex = 2;
            this.btnDepartmentPosition.Text = "Department & Position";
            this.btnDepartmentPosition.UseVisualStyleBackColor = true;

            // 
            // btnLeaveSystem
            // 
            this.btnLeaveSystem.Location = new System.Drawing.Point(100, 160);
            this.btnLeaveSystem.Name = "btnLeaveSystem";
            this.btnLeaveSystem.Size = new System.Drawing.Size(250, 30);
            this.btnLeaveSystem.TabIndex = 3;
            this.btnLeaveSystem.Text = "Leave System";
            this.btnLeaveSystem.UseVisualStyleBackColor = true;

            // 
            // btnAttendanceTracking
            // 
            this.btnAttendanceTracking.Location = new System.Drawing.Point(100, 200);
            this.btnAttendanceTracking.Name = "btnAttendanceTracking";
            this.btnAttendanceTracking.Size = new System.Drawing.Size(250, 30);
            this.btnAttendanceTracking.TabIndex = 4;
            this.btnAttendanceTracking.Text = "Attendance Tracking";
            this.btnAttendanceTracking.UseVisualStyleBackColor = true;

            // 
            // btnPayrollSystem
            // 
            this.btnPayrollSystem.Location = new System.Drawing.Point(100, 240);
            this.btnPayrollSystem.Name = "btnPayrollSystem";
            this.btnPayrollSystem.Size = new System.Drawing.Size(250, 30);
            this.btnPayrollSystem.TabIndex = 5;
            this.btnPayrollSystem.Text = "Payroll System";
            this.btnPayrollSystem.UseVisualStyleBackColor = true;

            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(100, 280);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 30);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;

            // 
            // AdminPanelForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnEmployeeManagement);
            this.Controls.Add(this.btnDepartmentPosition);
            this.Controls.Add(this.btnLeaveSystem);
            this.Controls.Add(this.btnAttendanceTracking);
            this.Controls.Add(this.btnPayrollSystem);
            this.Controls.Add(this.btnLogout);
            this.Name = "AdminPanelForm";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            this.ResumeLayout(false);
        }
    }
}
