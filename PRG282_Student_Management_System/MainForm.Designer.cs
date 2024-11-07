namespace PRG282_Project
{
    partial class frmMain
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
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.gpbInput = new System.Windows.Forms.GroupBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.grpbSummary = new System.Windows.Forms.GroupBox();
            this.txtAvgAge = new System.Windows.Forms.TextBox();
            this.txtTotalStudents = new System.Windows.Forms.TextBox();
            this.lblAveAge = new System.Windows.Forms.Label();
            this.lblSumText2 = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.lblSumText1 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.gpbInput.SuspendLayout();
            this.grpbSummary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(469, 79);
            this.dgvDisplay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowHeadersWidth = 62;
            this.dgvDisplay.RowTemplate.Height = 28;
            this.dgvDisplay.Size = new System.Drawing.Size(539, 195);
            this.dgvDisplay.TabIndex = 13;
            this.dgvDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellClick);
            this.dgvDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(40, 161);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnViewAll.Location = new System.Drawing.Point(40, 101);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(123, 30);
            this.btnViewAll.TabIndex = 0;
            this.btnViewAll.Text = "View All Students";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(40, 226);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 29);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(40, 291);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSummary.Location = new System.Drawing.Point(40, 350);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(123, 29);
            this.btnSummary.TabIndex = 10;
            this.btnSummary.Text = "Generate Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // gpbInput
            // 
            this.gpbInput.Controls.Add(this.cmbCourse);
            this.gpbInput.Controls.Add(this.txtAge);
            this.gpbInput.Controls.Add(this.txtName);
            this.gpbInput.Controls.Add(this.txtStudentID);
            this.gpbInput.Controls.Add(this.lblCourse);
            this.gpbInput.Controls.Add(this.lblAge);
            this.gpbInput.Controls.Add(this.lblName);
            this.gpbInput.Controls.Add(this.lblID);
            this.gpbInput.Location = new System.Drawing.Point(175, 157);
            this.gpbInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gpbInput.Name = "gpbInput";
            this.gpbInput.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gpbInput.Size = new System.Drawing.Size(279, 222);
            this.gpbInput.TabIndex = 6;
            this.gpbInput.TabStop = false;
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCourse.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "Bachelors of Computing",
            "Bachelors in IT",
            "Dimploma in IT",
            "Certidicate in IT"});
            this.cmbCourse.Location = new System.Drawing.Point(100, 158);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(139, 25);
            this.cmbCourse.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAge.Location = new System.Drawing.Point(100, 118);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(42, 25);
            this.txtAge.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(100, 68);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 25);
            this.txtName.TabIndex = 4;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtStudentID.Location = new System.Drawing.Point(100, 27);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(139, 25);
            this.txtStudentID.TabIndex = 3;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCourse.Location = new System.Drawing.Point(5, 160);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 17);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Course";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(5, 118);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 17);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(5, 72);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Full Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(5, 27);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "StudentID";
            // 
            // grpbSummary
            // 
            this.grpbSummary.Controls.Add(this.txtAvgAge);
            this.grpbSummary.Controls.Add(this.txtTotalStudents);
            this.grpbSummary.Controls.Add(this.lblAveAge);
            this.grpbSummary.Controls.Add(this.lblSumText2);
            this.grpbSummary.Controls.Add(this.lblTotalStudents);
            this.grpbSummary.Controls.Add(this.lblSumText1);
            this.grpbSummary.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpbSummary.Location = new System.Drawing.Point(469, 324);
            this.grpbSummary.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grpbSummary.Name = "grpbSummary";
            this.grpbSummary.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grpbSummary.Size = new System.Drawing.Size(539, 58);
            this.grpbSummary.TabIndex = 7;
            this.grpbSummary.TabStop = false;
            this.grpbSummary.Text = "Summary";
            this.grpbSummary.Visible = false;
            // 
            // txtAvgAge
            // 
            this.txtAvgAge.Location = new System.Drawing.Point(292, 26);
            this.txtAvgAge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAvgAge.Name = "txtAvgAge";
            this.txtAvgAge.Size = new System.Drawing.Size(71, 25);
            this.txtAvgAge.TabIndex = 5;
            // 
            // txtTotalStudents
            // 
            this.txtTotalStudents.Location = new System.Drawing.Point(107, 26);
            this.txtTotalStudents.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotalStudents.Name = "txtTotalStudents";
            this.txtTotalStudents.Size = new System.Drawing.Size(71, 25);
            this.txtTotalStudents.TabIndex = 4;
            // 
            // lblAveAge
            // 
            this.lblAveAge.AutoSize = true;
            this.lblAveAge.Location = new System.Drawing.Point(287, 14);
            this.lblAveAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAveAge.Name = "lblAveAge";
            this.lblAveAge.Size = new System.Drawing.Size(0, 17);
            this.lblAveAge.TabIndex = 3;
            // 
            // lblSumText2
            // 
            this.lblSumText2.AutoSize = true;
            this.lblSumText2.Location = new System.Drawing.Point(200, 32);
            this.lblSumText2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSumText2.Name = "lblSumText2";
            this.lblSumText2.Size = new System.Drawing.Size(88, 17);
            this.lblSumText2.TabIndex = 2;
            this.lblSumText2.Text = "Average age:";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(84, 14);
            this.lblTotalStudents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(0, 17);
            this.lblTotalStudents.TabIndex = 1;
            // 
            // lblSumText1
            // 
            this.lblSumText1.AutoSize = true;
            this.lblSumText1.Location = new System.Drawing.Point(2, 32);
            this.lblSumText1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSumText1.Name = "lblSumText1";
            this.lblSumText1.Size = new System.Drawing.Size(101, 17);
            this.lblSumText1.TabIndex = 0;
            this.lblSumText1.Text = "Total Students:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.Location = new System.Drawing.Point(473, 291);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(123, 29);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNext.Location = new System.Drawing.Point(613, 291);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(123, 29);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(197, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(79, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(114, 25);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(5, 16);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 17);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "StudentID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(175, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(290, 48);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1057, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpbSummary);
            this.Controls.Add(this.gpbInput);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.dgvDisplay);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRG282-Project-Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.gpbInput.ResumeLayout(false);
            this.gpbInput.PerformLayout();
            this.grpbSummary.ResumeLayout(false);
            this.grpbSummary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.GroupBox gpbInput;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtStudentID;
        public System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.GroupBox grpbSummary;
        private System.Windows.Forms.Label lblAveAge;
        private System.Windows.Forms.Label lblSumText2;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label lblSumText1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtAvgAge;
        private System.Windows.Forms.TextBox txtTotalStudents;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmbCourse;
    }
}

