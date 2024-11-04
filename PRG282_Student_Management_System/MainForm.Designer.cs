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
            this.txtAvgAge = new System.Windows.Forms.TextBox();
            this.txtTotalStudents = new System.Windows.Forms.TextBox();
            this.lblAveAge = new System.Windows.Forms.Label();
            this.lblSumText2 = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.lblSumText1 = new System.Windows.Forms.Label();
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
            this.dgvDisplay.Location = new System.Drawing.Point(625, 97);
            this.dgvDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowHeadersWidth = 62;
            this.dgvDisplay.RowTemplate.Height = 28;
            this.dgvDisplay.Size = new System.Drawing.Size(718, 240);
            this.dgvDisplay.TabIndex = 0;
            this.dgvDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellClick);
            this.dgvDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(133, 97);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(133, 168);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(164, 37);
            this.btnViewAll.TabIndex = 2;
            this.btnViewAll.Text = "View All Students";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(133, 246);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 36);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(133, 323);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(133, 405);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(164, 36);
            this.btnSummary.TabIndex = 5;
            this.btnSummary.Text = "Generate Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
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
            this.gpbInput.Location = new System.Drawing.Point(320, 97);
            this.gpbInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInput.Name = "gpbInput";
            this.gpbInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInput.Size = new System.Drawing.Size(275, 373);
            this.gpbInput.TabIndex = 6;
            this.gpbInput.TabStop = false;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(96, 268);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(136, 22);
            this.txtCourse.TabIndex = 11;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(96, 217);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(136, 22);
            this.txtAge.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 156);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(96, 92);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(136, 22);
            this.txtStudentID.TabIndex = 4;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(17, 270);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 16);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Course";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(17, 219);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 161);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(17, 92);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 16);
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
            this.grpbSummary.Location = new System.Drawing.Point(625, 414);
            this.grpbSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbSummary.Name = "grpbSummary";
            this.grpbSummary.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbSummary.Size = new System.Drawing.Size(718, 55);
            this.grpbSummary.TabIndex = 7;
            this.grpbSummary.TabStop = false;
            this.grpbSummary.Text = "Summary";
            this.grpbSummary.Visible = false;
            // 
            // txtAvgAge
            // 
            this.txtAvgAge.Location = new System.Drawing.Point(381, 12);
            this.txtAvgAge.Name = "txtAvgAge";
            this.txtAvgAge.Size = new System.Drawing.Size(93, 22);
            this.txtAvgAge.TabIndex = 5;
            // 
            // txtTotalStudents
            // 
            this.txtTotalStudents.Location = new System.Drawing.Point(105, 12);
            this.txtTotalStudents.Name = "txtTotalStudents";
            this.txtTotalStudents.Size = new System.Drawing.Size(93, 22);
            this.txtTotalStudents.TabIndex = 4;
            // 
            // lblAveAge
            // 
            this.lblAveAge.AutoSize = true;
            this.lblAveAge.Location = new System.Drawing.Point(383, 18);
            this.lblAveAge.Name = "lblAveAge";
            this.lblAveAge.Size = new System.Drawing.Size(0, 16);
            this.lblAveAge.TabIndex = 3;
            // 
            // lblSumText2
            // 
            this.lblSumText2.AutoSize = true;
            this.lblSumText2.Location = new System.Drawing.Point(286, 18);
            this.lblSumText2.Name = "lblSumText2";
            this.lblSumText2.Size = new System.Drawing.Size(89, 16);
            this.lblSumText2.TabIndex = 2;
            this.lblSumText2.Text = "Average age:";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(112, 18);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(0, 16);
            this.lblTotalStudents.TabIndex = 1;
            // 
            // lblSumText1
            // 
            this.lblSumText1.AutoSize = true;
            this.lblSumText1.Location = new System.Drawing.Point(3, 18);
            this.lblSumText1.Name = "lblSumText1";
            this.lblSumText1.Size = new System.Drawing.Size(96, 16);
            this.lblSumText1.TabIndex = 0;
            this.lblSumText1.Text = "Total Students:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(631, 358);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(164, 36);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(817, 358);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(164, 36);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 585);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox txtAvgAge;
        private System.Windows.Forms.TextBox txtTotalStudents;
    }
}

