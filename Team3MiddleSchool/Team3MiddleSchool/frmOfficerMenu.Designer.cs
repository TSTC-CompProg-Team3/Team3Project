namespace Team3MiddleSchool
{
    partial class frmOfficerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOfficerMenu));
            this.btnEditSubject = new System.Windows.Forms.Button();
            this.btnRemoveSubject = new System.Windows.Forms.Button();
            this.cbxSubjectSelect = new System.Windows.Forms.ComboBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.cbxStudentSelect = new System.Windows.Forms.ComboBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveTeacher = new System.Windows.Forms.Button();
            this.cbxTeacherSelect = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.cbxCourseSelect = new System.Windows.Forms.ComboBox();
            this.pbxOfficerMenu = new System.Windows.Forms.PictureBox();
            this.btnEditParent = new System.Windows.Forms.Button();
            this.cbxParentSelect = new System.Windows.Forms.ComboBox();
            this.btnAddParent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOfficerMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditSubject
            // 
            this.btnEditSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSubject.Location = new System.Drawing.Point(161, 313);
            this.btnEditSubject.Name = "btnEditSubject";
            this.btnEditSubject.Size = new System.Drawing.Size(117, 40);
            this.btnEditSubject.TabIndex = 30;
            this.btnEditSubject.Text = "Edit Subject";
            this.btnEditSubject.UseVisualStyleBackColor = true;
            this.btnEditSubject.Click += new System.EventHandler(this.btnEditSubject_Click);
            // 
            // btnRemoveSubject
            // 
            this.btnRemoveSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSubject.Location = new System.Drawing.Point(513, 313);
            this.btnRemoveSubject.Name = "btnRemoveSubject";
            this.btnRemoveSubject.Size = new System.Drawing.Size(117, 40);
            this.btnRemoveSubject.TabIndex = 31;
            this.btnRemoveSubject.Text = "Remove Subject";
            this.btnRemoveSubject.UseVisualStyleBackColor = true;
            this.btnRemoveSubject.Visible = false;
            this.btnRemoveSubject.Click += new System.EventHandler(this.btnRemoveSubject_Click);
            // 
            // cbxSubjectSelect
            // 
            this.cbxSubjectSelect.FormattingEnabled = true;
            this.cbxSubjectSelect.Location = new System.Drawing.Point(294, 324);
            this.cbxSubjectSelect.Name = "cbxSubjectSelect";
            this.cbxSubjectSelect.Size = new System.Drawing.Size(203, 23);
            this.cbxSubjectSelect.TabIndex = 32;
            this.cbxSubjectSelect.SelectedIndexChanged += new System.EventHandler(this.cbxSubjectSelect_SelectedIndexChanged);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.Location = new System.Drawing.Point(38, 313);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(117, 40);
            this.btnAddSubject.TabIndex = 29;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTeacher.Location = new System.Drawing.Point(161, 255);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(117, 40);
            this.btnEditTeacher.TabIndex = 22;
            this.btnEditTeacher.Text = "Edit Teacher";
            this.btnEditTeacher.UseVisualStyleBackColor = true;
            this.btnEditTeacher.Click += new System.EventHandler(this.btnEditTeacher_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCourse.Location = new System.Drawing.Point(161, 197);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(117, 40);
            this.btnEditCourse.TabIndex = 18;
            this.btnEditCourse.Text = "Edit Course";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStudent.Location = new System.Drawing.Point(161, 371);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(117, 40);
            this.btnEditStudent.TabIndex = 26;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.Location = new System.Drawing.Point(513, 371);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(117, 40);
            this.btnRemoveStudent.TabIndex = 27;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Visible = false;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // cbxStudentSelect
            // 
            this.cbxStudentSelect.FormattingEnabled = true;
            this.cbxStudentSelect.Location = new System.Drawing.Point(294, 382);
            this.cbxStudentSelect.Name = "cbxStudentSelect";
            this.cbxStudentSelect.Size = new System.Drawing.Size(203, 23);
            this.cbxStudentSelect.TabIndex = 28;
            this.cbxStudentSelect.SelectedIndexChanged += new System.EventHandler(this.cbxStudentSelect_SelectedIndexChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(38, 371);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(117, 40);
            this.btnAddStudent.TabIndex = 25;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveTeacher
            // 
            this.btnRemoveTeacher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTeacher.Location = new System.Drawing.Point(513, 255);
            this.btnRemoveTeacher.Name = "btnRemoveTeacher";
            this.btnRemoveTeacher.Size = new System.Drawing.Size(117, 40);
            this.btnRemoveTeacher.TabIndex = 23;
            this.btnRemoveTeacher.Text = "Remove Teacher";
            this.btnRemoveTeacher.UseVisualStyleBackColor = true;
            this.btnRemoveTeacher.Visible = false;
            this.btnRemoveTeacher.Click += new System.EventHandler(this.btnRemoveTeacher_Click);
            // 
            // cbxTeacherSelect
            // 
            this.cbxTeacherSelect.FormattingEnabled = true;
            this.cbxTeacherSelect.Location = new System.Drawing.Point(294, 266);
            this.cbxTeacherSelect.Name = "cbxTeacherSelect";
            this.cbxTeacherSelect.Size = new System.Drawing.Size(203, 23);
            this.cbxTeacherSelect.TabIndex = 24;
            this.cbxTeacherSelect.SelectedIndexChanged += new System.EventHandler(this.cbxTeacherSelect_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(530, 484);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 40);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.Location = new System.Drawing.Point(38, 255);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(117, 40);
            this.btnAddTeacher.TabIndex = 21;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCourse.Location = new System.Drawing.Point(513, 197);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(117, 40);
            this.btnRemoveCourse.TabIndex = 19;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Visible = false;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(38, 197);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(117, 40);
            this.btnAddCourse.TabIndex = 17;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // cbxCourseSelect
            // 
            this.cbxCourseSelect.FormattingEnabled = true;
            this.cbxCourseSelect.Location = new System.Drawing.Point(294, 208);
            this.cbxCourseSelect.Name = "cbxCourseSelect";
            this.cbxCourseSelect.Size = new System.Drawing.Size(203, 23);
            this.cbxCourseSelect.TabIndex = 20;
            this.cbxCourseSelect.SelectedIndexChanged += new System.EventHandler(this.cbxCourseSelect_SelectedIndexChanged);
            // 
            // pbxOfficerMenu
            // 
            this.pbxOfficerMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbxOfficerMenu.Image")));
            this.pbxOfficerMenu.Location = new System.Drawing.Point(38, 12);
            this.pbxOfficerMenu.Name = "pbxOfficerMenu";
            this.pbxOfficerMenu.Size = new System.Drawing.Size(582, 163);
            this.pbxOfficerMenu.TabIndex = 34;
            this.pbxOfficerMenu.TabStop = false;
            // 
            // btnEditParent
            // 
            this.btnEditParent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditParent.Location = new System.Drawing.Point(161, 429);
            this.btnEditParent.Name = "btnEditParent";
            this.btnEditParent.Size = new System.Drawing.Size(117, 40);
            this.btnEditParent.TabIndex = 36;
            this.btnEditParent.Text = "Edit Parent";
            this.btnEditParent.UseVisualStyleBackColor = true;
            this.btnEditParent.Click += new System.EventHandler(this.btnEditParent_Click);
            // 
            // cbxParentSelect
            // 
            this.cbxParentSelect.FormattingEnabled = true;
            this.cbxParentSelect.Location = new System.Drawing.Point(294, 440);
            this.cbxParentSelect.Name = "cbxParentSelect";
            this.cbxParentSelect.Size = new System.Drawing.Size(203, 23);
            this.cbxParentSelect.TabIndex = 38;
            // 
            // btnAddParent
            // 
            this.btnAddParent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParent.Location = new System.Drawing.Point(38, 429);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.Size = new System.Drawing.Size(117, 40);
            this.btnAddParent.TabIndex = 35;
            this.btnAddParent.Text = "Add Parent";
            this.btnAddParent.UseVisualStyleBackColor = true;
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            // 
            // frmOfficerMenu
            // 
            this.AcceptButton = this.btnBack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(659, 536);
            this.ControlBox = false;
            this.Controls.Add(this.pbxOfficerMenu);
            this.Controls.Add(this.btnRemoveSubject);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnRemoveTeacher);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.btnEditParent);
            this.Controls.Add(this.btnAddParent);
            this.Controls.Add(this.btnEditSubject);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.btnEditTeacher);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.cbxParentSelect);
            this.Controls.Add(this.cbxSubjectSelect);
            this.Controls.Add(this.cbxStudentSelect);
            this.Controls.Add(this.cbxTeacherSelect);
            this.Controls.Add(this.cbxCourseSelect);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmOfficerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Officer Menu";
            this.Load += new System.EventHandler(this.frmOfficerMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxOfficerMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditSubject;
        private System.Windows.Forms.Button btnRemoveSubject;
        private System.Windows.Forms.ComboBox cbxSubjectSelect;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.ComboBox cbxStudentSelect;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveTeacher;
        private System.Windows.Forms.ComboBox cbxTeacherSelect;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ComboBox cbxCourseSelect;
        private System.Windows.Forms.PictureBox pbxOfficerMenu;
        private System.Windows.Forms.Button btnEditParent;
        private System.Windows.Forms.ComboBox cbxParentSelect;
        private System.Windows.Forms.Button btnAddParent;
    }
}