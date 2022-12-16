namespace CaseStudy_juhee_2546152
{
    partial class EmployeeDetails
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
            this.btnEmployeeList = new System.Windows.Forms.Button();
            this.grdEmployee = new System.Windows.Forms.DataGridView();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnserachby = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmployeeList
            // 
            this.btnEmployeeList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmployeeList.Font = new System.Drawing.Font("Segoe UI Black", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeList.Location = new System.Drawing.Point(895, 97);
            this.btnEmployeeList.Name = "btnEmployeeList";
            this.btnEmployeeList.Size = new System.Drawing.Size(351, 58);
            this.btnEmployeeList.TabIndex = 0;
            this.btnEmployeeList.Text = "Get All Employee";
            this.btnEmployeeList.UseVisualStyleBackColor = false;
            this.btnEmployeeList.Click += new System.EventHandler(this.btnEmployeeList_Click);
            // 
            // grdEmployee
            // 
            this.grdEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.grdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployee.Location = new System.Drawing.Point(705, 194);
            this.grdEmployee.Name = "grdEmployee";
            this.grdEmployee.RowHeadersWidth = 102;
            this.grdEmployee.RowTemplate.Height = 49;
            this.grdEmployee.Size = new System.Drawing.Size(1349, 598);
            this.grdEmployee.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(33, 321);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(107, 46);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(33, 425);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(136, 46);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(33, 530);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 46);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(335, 190);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 47);
            this.txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(335, 321);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 47);
            this.txtEmail.TabIndex = 7;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(335, 425);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(250, 47);
            this.txtGender.TabIndex = 8;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(335, 530);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(250, 47);
            this.txtStatus.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(33, 196);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 46);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(92, 641);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(281, 58);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert Data";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(705, 934);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 47);
            this.txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(1549, 922);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(304, 58);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete By ID";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.900001F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(622, 868);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter Id for Search/Delate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(115, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 41);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter Data for insert new record";
            // 
            // btnserachby
            // 
            this.btnserachby.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnserachby.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnserachby.Location = new System.Drawing.Point(1227, 927);
            this.btnserachby.Name = "btnserachby";
            this.btnserachby.Size = new System.Drawing.Size(271, 58);
            this.btnserachby.TabIndex = 18;
            this.btnserachby.Text = "Search By ID";
            this.btnserachby.UseVisualStyleBackColor = false;
            this.btnserachby.Click += new System.EventHandler(this.btnserachby_Click);
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2088, 1034);
            this.Controls.Add(this.btnserachby);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.grdEmployee);
            this.Controls.Add(this.btnEmployeeList);
            this.Name = "EmployeeDetails";
            this.Text = "EmployeeDetails";
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEmployeeList;
        private DataGridView grdEmployee;
        private Label lblEmail;
        private Label lblGender;
        private Label lblStatus;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtGender;
        private TextBox txtStatus;
        private Label lblName;
        private Button btnInsert;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Button btnserachby;
    }
}