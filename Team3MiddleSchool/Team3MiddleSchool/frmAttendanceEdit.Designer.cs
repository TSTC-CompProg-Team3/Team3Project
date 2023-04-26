namespace Team3MiddleSchool
{
    partial class frmAttendanceEdit
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
            this.btnBackAttendEdit = new System.Windows.Forms.Button();
            this.btnClearAttendEdit = new System.Windows.Forms.Button();
            this.btnSubmitAttendEdit = new System.Windows.Forms.Button();
            this.dgvAttendanceEdit = new System.Windows.Forms.DataGridView();
            this.dtpAttendanceEdit = new System.Windows.Forms.DateTimePicker();
            this.cmbNamesEdit = new System.Windows.Forms.ComboBox();
            this.pnlAttendanceEdit = new System.Windows.Forms.Panel();
            this.lblAttendTeacher = new System.Windows.Forms.Label();
            this.lblAttendClass = new System.Windows.Forms.Label();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceEdit)).BeginInit();
            this.pnlAttendanceEdit.SuspendLayout();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackAttendEdit
            // 
            this.btnBackAttendEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackAttendEdit.Location = new System.Drawing.Point(40, 662);
            this.btnBackAttendEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackAttendEdit.Name = "btnBackAttendEdit";
            this.btnBackAttendEdit.Size = new System.Drawing.Size(112, 43);
            this.btnBackAttendEdit.TabIndex = 19;
            this.btnBackAttendEdit.Text = "Back";
            this.btnBackAttendEdit.UseVisualStyleBackColor = true;
            this.btnBackAttendEdit.Click += new System.EventHandler(this.btnBackAttendEdit_Click);
            // 
            // btnClearAttendEdit
            // 
            this.btnClearAttendEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAttendEdit.Location = new System.Drawing.Point(175, 662);
            this.btnClearAttendEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearAttendEdit.Name = "btnClearAttendEdit";
            this.btnClearAttendEdit.Size = new System.Drawing.Size(112, 43);
            this.btnClearAttendEdit.TabIndex = 18;
            this.btnClearAttendEdit.Text = "Clear";
            this.btnClearAttendEdit.UseVisualStyleBackColor = true;
            this.btnClearAttendEdit.Click += new System.EventHandler(this.btnClearAttendEdit_Click);
            // 
            // btnSubmitAttendEdit
            // 
            this.btnSubmitAttendEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAttendEdit.Location = new System.Drawing.Point(310, 662);
            this.btnSubmitAttendEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitAttendEdit.Name = "btnSubmitAttendEdit";
            this.btnSubmitAttendEdit.Size = new System.Drawing.Size(112, 43);
            this.btnSubmitAttendEdit.TabIndex = 17;
            this.btnSubmitAttendEdit.Text = "Submit";
            this.btnSubmitAttendEdit.UseVisualStyleBackColor = true;
            this.btnSubmitAttendEdit.Click += new System.EventHandler(this.btnSubmitAttendEdit_Click);
            // 
            // dgvAttendanceEdit
            // 
            this.dgvAttendanceEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceEdit.Location = new System.Drawing.Point(8, 60);
            this.dgvAttendanceEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAttendanceEdit.Name = "dgvAttendanceEdit";
            this.dgvAttendanceEdit.RowHeadersVisible = false;
            this.dgvAttendanceEdit.RowHeadersWidth = 51;
            this.dgvAttendanceEdit.Size = new System.Drawing.Size(732, 518);
            this.dgvAttendanceEdit.TabIndex = 3;
            this.dgvAttendanceEdit.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAttendanceEdit_CellFormatting);
            // 
            // dtpAttendanceEdit
            // 
            this.dtpAttendanceEdit.Location = new System.Drawing.Point(451, 688);
            this.dtpAttendanceEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpAttendanceEdit.Name = "dtpAttendanceEdit";
            this.dtpAttendanceEdit.Size = new System.Drawing.Size(278, 26);
            this.dtpAttendanceEdit.TabIndex = 22;
            this.dtpAttendanceEdit.ValueChanged += new System.EventHandler(this.dtpAttendanceEdit_ValueChanged);
            // 
            // cmbNamesEdit
            // 
            this.cmbNamesEdit.FormattingEnabled = true;
            this.cmbNamesEdit.Location = new System.Drawing.Point(451, 651);
            this.cmbNamesEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNamesEdit.Name = "cmbNamesEdit";
            this.cmbNamesEdit.Size = new System.Drawing.Size(278, 28);
            this.cmbNamesEdit.TabIndex = 21;
            this.cmbNamesEdit.SelectedValueChanged += new System.EventHandler(this.cmbNamesEdit_SelectedValueChanged);
            // 
            // pnlAttendanceEdit
            // 
            this.pnlAttendanceEdit.Controls.Add(this.dgvAttendanceEdit);
            this.pnlAttendanceEdit.Controls.Add(this.lblAttendTeacher);
            this.pnlAttendanceEdit.Controls.Add(this.lblAttendClass);
            this.pnlAttendanceEdit.Location = new System.Drawing.Point(13, 40);
            this.pnlAttendanceEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAttendanceEdit.Name = "pnlAttendanceEdit";
            this.pnlAttendanceEdit.Size = new System.Drawing.Size(742, 600);
            this.pnlAttendanceEdit.TabIndex = 20;
            // 
            // lblAttendTeacher
            // 
            this.lblAttendTeacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendTeacher.Location = new System.Drawing.Point(2, 2);
            this.lblAttendTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendTeacher.Name = "lblAttendTeacher";
            this.lblAttendTeacher.Size = new System.Drawing.Size(400, 63);
            this.lblAttendTeacher.TabIndex = 23;
            this.lblAttendTeacher.Text = "Teacher: ";
            this.lblAttendTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAttendClass
            // 
            this.lblAttendClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendClass.Location = new System.Drawing.Point(410, 2);
            this.lblAttendClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendClass.Name = "lblAttendClass";
            this.lblAttendClass.Size = new System.Drawing.Size(328, 63);
            this.lblAttendClass.TabIndex = 24;
            this.lblAttendClass.Text = "Class: ";
            this.lblAttendClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuStrip
            // 
            this.mnuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(768, 35);
            this.mnuStrip.TabIndex = 23;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.userManualToolStripMenuItem.Text = "User Manual";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // attendanceReportToolStripMenuItem
            // 
            this.attendanceReportToolStripMenuItem.Name = "attendanceReportToolStripMenuItem";
            this.attendanceReportToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.attendanceReportToolStripMenuItem.Text = "Attendance Report";
            this.attendanceReportToolStripMenuItem.Click += new System.EventHandler(this.attendanceReportToolStripMenuItem_Click);
            // 
            // frmAttendanceEdit
            // 
            this.AcceptButton = this.btnSubmitAttendEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 729);
            this.ControlBox = false;
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.btnBackAttendEdit);
            this.Controls.Add(this.pnlAttendanceEdit);
            this.Controls.Add(this.btnSubmitAttendEdit);
            this.Controls.Add(this.cmbNamesEdit);
            this.Controls.Add(this.dtpAttendanceEdit);
            this.Controls.Add(this.btnClearAttendEdit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAttendanceEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Attendance";
            this.Load += new System.EventHandler(this.frmAttendanceEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceEdit)).EndInit();
            this.pnlAttendanceEdit.ResumeLayout(false);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackAttendEdit;
        private System.Windows.Forms.Button btnClearAttendEdit;
        private System.Windows.Forms.Button btnSubmitAttendEdit;
        private System.Windows.Forms.DataGridView dgvAttendanceEdit;
        private System.Windows.Forms.DateTimePicker dtpAttendanceEdit;
        private System.Windows.Forms.ComboBox cmbNamesEdit;
        private System.Windows.Forms.Panel pnlAttendanceEdit;
        private System.Windows.Forms.Label lblAttendClass;
        private System.Windows.Forms.Label lblAttendTeacher;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceReportToolStripMenuItem;
    }
}