namespace DatabaseConnection_G3_sp23
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pbxBanner = new System.Windows.Forms.PictureBox();
            this.cbxCourseSelect = new System.Windows.Forms.ComboBox();
            this.btnGradeBook = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnSeatingChart = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnOfficer = new System.Windows.Forms.Button();
            this.btnAssignClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxBanner
            // 
            this.pbxBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbxBanner.Image")));
            this.pbxBanner.Location = new System.Drawing.Point(12, 12);
            this.pbxBanner.Name = "pbxBanner";
            this.pbxBanner.Size = new System.Drawing.Size(635, 213);
            this.pbxBanner.TabIndex = 0;
            this.pbxBanner.TabStop = false;
            // 
            // cbxCourseSelect
            // 
            this.cbxCourseSelect.FormattingEnabled = true;
            this.cbxCourseSelect.Location = new System.Drawing.Point(228, 236);
            this.cbxCourseSelect.Name = "cbxCourseSelect";
            this.cbxCourseSelect.Size = new System.Drawing.Size(203, 23);
            this.cbxCourseSelect.TabIndex = 1;
            // 
            // btnGradeBook
            // 
            this.btnGradeBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeBook.Location = new System.Drawing.Point(271, 277);
            this.btnGradeBook.Name = "btnGradeBook";
            this.btnGradeBook.Size = new System.Drawing.Size(117, 40);
            this.btnGradeBook.TabIndex = 2;
            this.btnGradeBook.Text = "&Grade Book";
            this.btnGradeBook.UseVisualStyleBackColor = true;
            this.btnGradeBook.Click += new System.EventHandler(this.btnGradeBook_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Location = new System.Drawing.Point(271, 338);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(117, 40);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.Text = "&Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnSeatingChart
            // 
            this.btnSeatingChart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeatingChart.Location = new System.Drawing.Point(271, 399);
            this.btnSeatingChart.Name = "btnSeatingChart";
            this.btnSeatingChart.Size = new System.Drawing.Size(117, 40);
            this.btnSeatingChart.TabIndex = 4;
            this.btnSeatingChart.Text = "&Seating Chart";
            this.btnSeatingChart.UseVisualStyleBackColor = true;
            this.btnSeatingChart.Click += new System.EventHandler(this.btnSeatingChart_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(271, 460);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(117, 40);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "&Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(486, 277);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(117, 40);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "A&dministrator";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnOfficer
            // 
            this.btnOfficer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfficer.Location = new System.Drawing.Point(486, 277);
            this.btnOfficer.Name = "btnOfficer";
            this.btnOfficer.Size = new System.Drawing.Size(117, 40);
            this.btnOfficer.TabIndex = 7;
            this.btnOfficer.Text = "&Officer";
            this.btnOfficer.UseVisualStyleBackColor = true;
            this.btnOfficer.Visible = false;
            this.btnOfficer.Click += new System.EventHandler(this.btnOfficer_Click);
            // 
            // btnAssignClass
            // 
            this.btnAssignClass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignClass.Location = new System.Drawing.Point(486, 338);
            this.btnAssignClass.Name = "btnAssignClass";
            this.btnAssignClass.Size = new System.Drawing.Size(117, 40);
            this.btnAssignClass.TabIndex = 8;
            this.btnAssignClass.Text = "Assign &Classes";
            this.btnAssignClass.UseVisualStyleBackColor = true;
            this.btnAssignClass.Visible = false;
            this.btnAssignClass.Click += new System.EventHandler(this.btnAssignClass_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(659, 536);
            this.ControlBox = false;
            this.Controls.Add(this.btnAssignClass);
            this.Controls.Add(this.btnOfficer);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnSeatingChart);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnGradeBook);
            this.Controls.Add(this.cbxCourseSelect);
            this.Controls.Add(this.pbxBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBanner;
        private System.Windows.Forms.Button btnGradeBook;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnSeatingChart;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnOfficer;
        private System.Windows.Forms.ComboBox cbxCourseSelect;
        private System.Windows.Forms.Button btnAssignClass;
    }
}