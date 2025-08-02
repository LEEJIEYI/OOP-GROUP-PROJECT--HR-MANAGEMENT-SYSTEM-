namespace HRManagementSystem
{
    partial class Department_and_Position
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtPositionName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnAssignPosition;
        private System.Windows.Forms.Button btnLinkEmployee;

        /// <summary>
        /// Disposes the resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtPositionName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnAssignPosition = new System.Windows.Forms.Button();
            this.btnLinkEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Department & Position";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(30, 70);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(100, 25);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "Department:";
            // 
            // lblPosition
            // 
            this.lblPosition.Location = new System.Drawing.Point(30, 110);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(100, 25);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.Location = new System.Drawing.Point(30, 150);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(100, 25);
            this.lblEmployeeID.TabIndex = 3;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(150, 70);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(160, 20);
            this.txtDepartmentName.TabIndex = 4;
            // 
            // txtPositionName
            // 
            this.txtPositionName.Location = new System.Drawing.Point(150, 110);
            this.txtPositionName.Name = "txtPositionName";
            this.txtPositionName.Size = new System.Drawing.Size(160, 20);
            this.txtPositionName.TabIndex = 5;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(150, 150);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(160, 20);
            this.txtEmployeeID.TabIndex = 6;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(30, 190);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(130, 30);
            this.btnAddDepartment.TabIndex = 7;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnAssignPosition
            // 
            this.btnAssignPosition.Location = new System.Drawing.Point(180, 190);
            this.btnAssignPosition.Name = "btnAssignPosition";
            this.btnAssignPosition.Size = new System.Drawing.Size(130, 30);
            this.btnAssignPosition.TabIndex = 8;
            this.btnAssignPosition.Text = "Assign Position";
            this.btnAssignPosition.UseVisualStyleBackColor = true;
            this.btnAssignPosition.Click += new System.EventHandler(this.btnAssignPosition_Click);
            // 
            // btnLinkEmployee
            // 
            this.btnLinkEmployee.Location = new System.Drawing.Point(30, 230);
            this.btnLinkEmployee.Name = "btnLinkEmployee";
            this.btnLinkEmployee.Size = new System.Drawing.Size(280, 30);
            this.btnLinkEmployee.TabIndex = 9;
            this.btnLinkEmployee.Text = "Link Employee";
            this.btnLinkEmployee.UseVisualStyleBackColor = true;
            this.btnLinkEmployee.Click += new System.EventHandler(this.btnLinkEmployee_Click);
            // 
            // Department_and_Position
            // 
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.txtPositionName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.btnAssignPosition);
            this.Controls.Add(this.btnLinkEmployee);
            this.Name = "Department_and_Position";
            this.Text = "Department & Position";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
