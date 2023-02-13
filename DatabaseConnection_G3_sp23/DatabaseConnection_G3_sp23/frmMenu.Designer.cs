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
            this.pbxBanner = new System.Windows.Forms.PictureBox();
            this.cbxCourseSelect = new System.Windows.Forms.ComboBox();
            this.btnGradeBook = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnSeatingChart = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.tsStatus = new System.Windows.Forms.StatusStrip();
            this.tssDatabaseConnection = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).BeginInit();
            this.tsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxBanner
            // 
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
            this.btnGradeBook.Location = new System.Drawing.Point(271, 265);
            this.btnGradeBook.Name = "btnGradeBook";
            this.btnGradeBook.Size = new System.Drawing.Size(117, 40);
            this.btnGradeBook.TabIndex = 2;
            this.btnGradeBook.Text = "Grade Book";
            this.btnGradeBook.UseVisualStyleBackColor = true;
            // 
            // btnAttendance
            // 
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Location = new System.Drawing.Point(271, 326);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(117, 40);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnSeatingChart
            // 
            this.btnSeatingChart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeatingChart.Location = new System.Drawing.Point(271, 387);
            this.btnSeatingChart.Name = "btnSeatingChart";
            this.btnSeatingChart.Size = new System.Drawing.Size(117, 40);
            this.btnSeatingChart.TabIndex = 4;
            this.btnSeatingChart.Text = "Seating Chart";
            this.btnSeatingChart.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(271, 448);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(117, 40);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(460, 265);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(117, 40);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Administrator";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // tsStatus
            // 
            this.tsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDatabaseConnection});
            this.tsStatus.Location = new System.Drawing.Point(0, 501);
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(659, 35);
            this.tsStatus.TabIndex = 9;
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
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 536);
            this.ControlBox = false;
            this.Controls.Add(this.tsStatus);
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
            this.Text = "frmMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).EndInit();
            this.tsStatus.ResumeLayout(false);
            this.tsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBanner;
        private System.Windows.Forms.ComboBox cbxCourseSelect;
        private System.Windows.Forms.Button btnGradeBook;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnSeatingChart;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.StatusStrip tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssDatabaseConnection;
    }
}