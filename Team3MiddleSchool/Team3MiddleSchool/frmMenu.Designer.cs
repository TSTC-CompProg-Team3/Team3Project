namespace Team3MiddleSchool
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
            this.btnReturnToLogin = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnOfficer = new System.Windows.Forms.Button();
            this.btnAssignClass = new System.Windows.Forms.Button();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).BeginInit();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxBanner
            // 
            this.pbxBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbxBanner.Image")));
            this.pbxBanner.Location = new System.Drawing.Point(12, 26);
            this.pbxBanner.Name = "pbxBanner";
            this.pbxBanner.Size = new System.Drawing.Size(635, 213);
            this.pbxBanner.TabIndex = 0;
            this.pbxBanner.TabStop = false;
            // 
            // cbxCourseSelect
            // 
            this.cbxCourseSelect.FormattingEnabled = true;
            this.cbxCourseSelect.Location = new System.Drawing.Point(147, 250);
            this.cbxCourseSelect.Name = "cbxCourseSelect";
            this.cbxCourseSelect.Size = new System.Drawing.Size(365, 23);
            this.cbxCourseSelect.TabIndex = 1;
            // 
            // btnGradeBook
            // 
            this.btnGradeBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeBook.Location = new System.Drawing.Point(271, 291);
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
            this.btnAttendance.Location = new System.Drawing.Point(271, 352);
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
            this.btnSeatingChart.Location = new System.Drawing.Point(271, 413);
            this.btnSeatingChart.Name = "btnSeatingChart";
            this.btnSeatingChart.Size = new System.Drawing.Size(117, 40);
            this.btnSeatingChart.TabIndex = 4;
            this.btnSeatingChart.Text = "&Seating Chart";
            this.btnSeatingChart.UseVisualStyleBackColor = true;
            this.btnSeatingChart.Click += new System.EventHandler(this.btnSeatingChart_Click);
            // 
            // btnReturnToLogin
            // 
            this.btnReturnToLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToLogin.Location = new System.Drawing.Point(271, 474);
            this.btnReturnToLogin.Name = "btnReturnToLogin";
            this.btnReturnToLogin.Size = new System.Drawing.Size(117, 40);
            this.btnReturnToLogin.TabIndex = 5;
            this.btnReturnToLogin.Text = "&Return to Login";
            this.btnReturnToLogin.UseVisualStyleBackColor = true;
            this.btnReturnToLogin.Click += new System.EventHandler(this.btnReturnToLogin_Click);
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
            this.btnOfficer.Location = new System.Drawing.Point(486, 291);
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
            this.btnAssignClass.Location = new System.Drawing.Point(486, 352);
            this.btnAssignClass.Name = "btnAssignClass";
            this.btnAssignClass.Size = new System.Drawing.Size(117, 40);
            this.btnAssignClass.TabIndex = 8;
            this.btnAssignClass.Text = "Assign &Classes";
            this.btnAssignClass.UseVisualStyleBackColor = true;
            this.btnAssignClass.Visible = false;
            this.btnAssignClass.Click += new System.EventHandler(this.btnAssignClass_Click);
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(659, 24);
            this.mnuStrip.TabIndex = 9;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userManualToolStripMenuItem.Text = "User Manual";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.userManualToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AcceptButton = this.btnReturnToLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(659, 536);
            this.ControlBox = false;
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.btnAssignClass);
            this.Controls.Add(this.btnOfficer);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnReturnToLogin);
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
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBanner;
        private System.Windows.Forms.Button btnGradeBook;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnSeatingChart;
        private System.Windows.Forms.Button btnReturnToLogin;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnOfficer;
        private System.Windows.Forms.ComboBox cbxCourseSelect;
        private System.Windows.Forms.Button btnAssignClass;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
    }
}