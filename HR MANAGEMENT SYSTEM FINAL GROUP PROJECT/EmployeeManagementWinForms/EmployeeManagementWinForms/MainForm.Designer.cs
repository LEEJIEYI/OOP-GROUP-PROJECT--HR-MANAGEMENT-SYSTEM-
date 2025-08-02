namespace EmployeeManagementWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView gridEmployees;

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
            txtName = new System.Windows.Forms.TextBox();
            txtJob = new System.Windows.Forms.TextBox();
            txtDept = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            gridEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridEmployees).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtName.Location = new System.Drawing.Point(20, 20);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new System.Drawing.Size(768, 35);
            txtName.TabIndex = 0;
            // 
            // txtJob
            // 
            txtJob.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtJob.Location = new System.Drawing.Point(20, 50);
            txtJob.Name = "txtJob";
            txtJob.PlaceholderText = "Job Title";
            txtJob.Size = new System.Drawing.Size(768, 35);
            txtJob.TabIndex = 1;
            // 
            // txtDept
            // 
            txtDept.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDept.Location = new System.Drawing.Point(20, 80);
            txtDept.Name = "txtDept";
            txtDept.PlaceholderText = "Department";
            txtDept.Size = new System.Drawing.Size(768, 35);
            txtDept.TabIndex = 2;
            txtDept.TextChanged += txtDept_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(20, 128);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(132, 42);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(20, 158);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(132, 42);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(20, 188);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(132, 42);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // gridEmployees
            // 
            gridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEmployees.Location = new System.Drawing.Point(20, 261);
            gridEmployees.Name = "gridEmployees";
            gridEmployees.RowHeadersWidth = 72;
            gridEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            gridEmployees.Size = new System.Drawing.Size(768, 200);
            gridEmployees.TabIndex = 6;
            gridEmployees.SelectionChanged += gridEmployees_SelectionChanged;
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(807, 600);
            Controls.Add(txtName);
            Controls.Add(txtJob);
            Controls.Add(txtDept);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(gridEmployees);
            Name = "MainForm";
            Text = "Employee Management";
            ((System.ComponentModel.ISupportInitialize)gridEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
