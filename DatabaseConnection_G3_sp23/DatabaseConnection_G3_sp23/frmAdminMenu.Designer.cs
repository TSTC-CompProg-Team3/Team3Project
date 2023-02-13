namespace DatabaseConnection_G3_sp23
{
    partial class frmAdminMenu
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.cbxCourseSelect = new System.Windows.Forms.ComboBox();
            this.tsStatus = new System.Windows.Forms.StatusStrip();
            this.tssDatabaseConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRemoveTeacher = new System.Windows.Forms.Button();
            this.cbxTeacherSelect = new System.Windows.Forms.ComboBox();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.cbxStudentSelect = new System.Windows.Forms.ComboBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.tsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(490, 438);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 40);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.Location = new System.Drawing.Point(25, 231);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(117, 40);
            this.btnAddTeacher.TabIndex = 11;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCourse.Location = new System.Drawing.Point(271, 94);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(117, 40);
            this.btnRemoveCourse.TabIndex = 10;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(25, 94);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(117, 40);
            this.btnAddCourse.TabIndex = 9;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // cbxCourseSelect
            // 
            this.cbxCourseSelect.FormattingEnabled = true;
            this.cbxCourseSelect.Location = new System.Drawing.Point(404, 105);
            this.cbxCourseSelect.Name = "cbxCourseSelect";
            this.cbxCourseSelect.Size = new System.Drawing.Size(203, 23);
            this.cbxCourseSelect.TabIndex = 8;
            // 
            // tsStatus
            // 
            this.tsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDatabaseConnection});
            this.tsStatus.Location = new System.Drawing.Point(0, 501);
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(659, 35);
            this.tsStatus.TabIndex = 13;
            this.tsStatus.Text = "statusStrip1";
            // 
            // tssDatabaseConnection
            // 
            this.tssDatabaseConnection.ActiveLinkColor = System.Drawing.Color.Red;
            this.tssDatabaseConnection.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssDatabaseConnection.ForeColor = System.Drawing.Color.Red;
            this.tssDatabaseConnection.Name = "tssDatabaseConnection";
            this.tssDatabaseConnection.Size = new System.Drawing.Size(81, 30);
            this.tssDatabaseConnection.Text = "Offline";
            // 
            // btnRemoveTeacher
            // 
            this.btnRemoveTeacher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTeacher.Location = new System.Drawing.Point(271, 231);
            this.btnRemoveTeacher.Name = "btnRemoveTeacher";
            this.btnRemoveTeacher.Size = new System.Drawing.Size(117, 40);
            this.btnRemoveTeacher.TabIndex = 15;
            this.btnRemoveTeacher.Text = "Remove Teacher";
            this.btnRemoveTeacher.UseVisualStyleBackColor = true;
            // 
            // cbxTeacherSelect
            // 
            this.cbxTeacherSelect.FormattingEnabled = true;
            this.cbxTeacherSelect.Location = new System.Drawing.Point(404, 242);
            this.cbxTeacherSelect.Name = "cbxTeacherSelect";
            this.cbxTeacherSelect.Size = new System.Drawing.Size(203, 23);
            this.cbxTeacherSelect.TabIndex = 14;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.Location = new System.Drawing.Point(271, 367);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(117, 40);
            this.btnRemoveStudent.TabIndex = 18;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            // 
            // cbxStudentSelect
            // 
            this.cbxStudentSelect.FormattingEnabled = true;
            this.cbxStudentSelect.Location = new System.Drawing.Point(404, 378);
            this.cbxStudentSelect.Name = "cbxStudentSelect";
            this.cbxStudentSelect.Size = new System.Drawing.Size(203, 23);
            this.cbxStudentSelect.TabIndex = 17;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(25, 367);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(117, 40);
            this.btnAddStudent.TabIndex = 16;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStudent.Location = new System.Drawing.Point(148, 367);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(117, 40);
            this.btnEditStudent.TabIndex = 19;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCourse.Location = new System.Drawing.Point(148, 94);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(117, 40);
            this.btnEditCourse.TabIndex = 20;
            this.btnEditCourse.Text = "Edit Course";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTeacher.Location = new System.Drawing.Point(148, 231);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(117, 40);
            this.btnEditTeacher.TabIndex = 21;
            this.btnEditTeacher.Text = "Edit Teacher";
            this.btnEditTeacher.UseVisualStyleBackColor = true;
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 536);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditTeacher);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.cbxStudentSelect);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnRemoveTeacher);
            this.Controls.Add(this.cbxTeacherSelect);
            this.Controls.Add(this.tsStatus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.cbxCourseSelect);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmAdminMenu_Load);
            this.tsStatus.ResumeLayout(false);
            this.tsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ComboBox cbxCourseSelect;
        private System.Windows.Forms.StatusStrip tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssDatabaseConnection;
        private System.Windows.Forms.Button btnRemoveTeacher;
        private System.Windows.Forms.ComboBox cbxTeacherSelect;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.ComboBox cbxStudentSelect;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Button btnEditTeacher;
    }
}