namespace HRManagementSystem
{
    partial class LeaveApplicationForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblLeaveType;
        private System.Windows.Forms.ComboBox cmbLeaveType;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnViewHistory;

        private System.Windows.Forms.ListView lvLeaveHistory;

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblLeaveType = new System.Windows.Forms.Label();
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.lvLeaveHistory = new System.Windows.Forms.ListView();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 30);
            this.lblTitle.Text = "Leave Application System";

            // lblEmployeeName
            this.lblEmployeeName.Text = "Employee Name:";
            this.lblEmployeeName.Location = new System.Drawing.Point(30, 70);

            // txtEmployeeName
            this.txtEmployeeName.Location = new System.Drawing.Point(150, 65);
            this.txtEmployeeName.Size = new System.Drawing.Size(200, 22);

            // lblLeaveType
            this.lblLeaveType.Text = "Leave Type:";
            this.lblLeaveType.Location = new System.Drawing.Point(30, 100);

            // cmbLeaveType
            this.cmbLeaveType.Location = new System.Drawing.Point(150, 95);
            this.cmbLeaveType.Size = new System.Drawing.Size(200, 24);
            this.cmbLeaveType.Items.AddRange(new object[] {
            "Annual",
            "Sick",
            "Emergency",
            "Other"});

            // lblStartDate
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.Location = new System.Drawing.Point(30, 130);

            // dtpStartDate
            this.dtpStartDate.Location = new System.Drawing.Point(150, 125);
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);

            // lblEndDate
            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.Location = new System.Drawing.Point(30, 160);

            // dtpEndDate
            this.dtpEndDate.Location = new System.Drawing.Point(150, 155);
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);

            // Buttons
            this.btnApply.Text = "Apply";
            this.btnApply.Location = new System.Drawing.Point(30, 190);
            this.btnApply.Size = new System.Drawing.Size(80, 30);

            this.btnApprove.Text = "Approve";
            this.btnApprove.Location = new System.Drawing.Point(130, 190);
            this.btnApprove.Size = new System.Drawing.Size(80, 30);

            this.btnReject.Text = "Reject";
            this.btnReject.Location = new System.Drawing.Point(230, 190);
            this.btnReject.Size = new System.Drawing.Size(80, 30);

            this.btnViewHistory.Text = "View History";
            this.btnViewHistory.Location = new System.Drawing.Point(330, 190);
            this.btnViewHistory.Size = new System.Drawing.Size(100, 30);

            // lvLeaveHistory
            this.lvLeaveHistory.Location = new System.Drawing.Point(30, 230);
            this.lvLeaveHistory.Size = new System.Drawing.Size(500, 150);
            this.lvLeaveHistory.View = System.Windows.Forms.View.Details;

            // Form Properties
            this.ClientSize = new System.Drawing.Size(600, 410);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblLeaveType);
            this.Controls.Add(this.cmbLeaveType);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.lvLeaveHistory);
            this.Text = "Leave Application System";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
