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
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.grpbSummary = new System.Windows.Forms.GroupBox();
            this.lblSumText1 = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.lblSumText2 = new System.Windows.Forms.Label();
            this.lblAveAge = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.gpbInput.SuspendLayout();
            this.grpbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(703, 121);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowHeadersWidth = 62;
            this.dgvDisplay.RowTemplate.Height = 28;
            this.dgvDisplay.Size = new System.Drawing.Size(808, 300);
            this.dgvDisplay.TabIndex = 0;
            this.dgvDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(150, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(150, 210);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(185, 46);
            this.btnViewAll.TabIndex = 2;
            this.btnViewAll.Text = "View All Students";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(150, 307);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(185, 45);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(150, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(150, 506);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(185, 45);
            this.btnSummary.TabIndex = 5;
            this.btnSummary.Text = "Generate Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            // 
            // gpbInput
            // 
            this.gpbInput.Controls.Add(this.txtCourse);
            this.gpbInput.Controls.Add(this.txtAge);
            this.gpbInput.Controls.Add(this.txtName);
            this.gpbInput.Controls.Add(this.txtStudentID);
            this.gpbInput.Controls.Add(this.lblCourse);
            this.gpbInput.Controls.Add(this.lblAge);
            this.gpbInput.Controls.Add(this.lblName);
            this.gpbInput.Controls.Add(this.lblID);
            this.gpbInput.Location = new System.Drawing.Point(360, 121);
            this.gpbInput.Name = "gpbInput";
            this.gpbInput.Size = new System.Drawing.Size(309, 466);
            this.gpbInput.TabIndex = 6;
            this.gpbInput.TabStop = false;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(108, 335);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(152, 26);
            this.txtCourse.TabIndex = 11;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(108, 271);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(152, 26);
            this.txtAge.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 195);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(108, 115);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(152, 26);
            this.txtStudentID.TabIndex = 4;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(19, 338);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(60, 20);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Course";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(19, 274);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 201);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(19, 115);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(83, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "StudentID";
            // 
            // grpbSummary
            // 
            this.grpbSummary.Controls.Add(this.lblAveAge);
            this.grpbSummary.Controls.Add(this.lblSumText2);
            this.grpbSummary.Controls.Add(this.lblTotalStudents);
            this.grpbSummary.Controls.Add(this.lblSumText1);
            this.grpbSummary.Location = new System.Drawing.Point(703, 518);
            this.grpbSummary.Name = "grpbSummary";
            this.grpbSummary.Size = new System.Drawing.Size(808, 69);
            this.grpbSummary.TabIndex = 7;
            this.grpbSummary.TabStop = false;
            this.grpbSummary.Text = "Summary";
            this.grpbSummary.Visible = false;
            // 
            // lblSumText1
            // 
            this.lblSumText1.AutoSize = true;
            this.lblSumText1.Location = new System.Drawing.Point(3, 22);
            this.lblSumText1.Name = "lblSumText1";
            this.lblSumText1.Size = new System.Drawing.Size(117, 20);
            this.lblSumText1.TabIndex = 0;
            this.lblSumText1.Text = "Total Students:";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(126, 22);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(0, 20);
            this.lblTotalStudents.TabIndex = 1;
            // 
            // lblSumText2
            // 
            this.lblSumText2.AutoSize = true;
            this.lblSumText2.Location = new System.Drawing.Point(322, 22);
            this.lblSumText2.Name = "lblSumText2";
            this.lblSumText2.Size = new System.Drawing.Size(103, 20);
            this.lblSumText2.TabIndex = 2;
            this.lblSumText2.Text = "Average age:";
            // 
            // lblAveAge
            // 
            this.lblAveAge.AutoSize = true;
            this.lblAveAge.Location = new System.Drawing.Point(431, 22);
            this.lblAveAge.Name = "lblAveAge";
            this.lblAveAge.Size = new System.Drawing.Size(0, 20);
            this.lblAveAge.TabIndex = 3;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(710, 447);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(185, 45);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(919, 447);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(185, 45);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 731);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpbSummary);
            this.Controls.Add(this.gpbInput);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDisplay);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRG282-Project-Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.gpbInput.ResumeLayout(false);
            this.gpbInput.PerformLayout();
            this.grpbSummary.ResumeLayout(false);
            this.grpbSummary.PerformLayout();
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
        public System.Windows.Forms.TextBox txtCourse;
        public System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.GroupBox grpbSummary;
        private System.Windows.Forms.Label lblAveAge;
        private System.Windows.Forms.Label lblSumText2;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label lblSumText1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}

