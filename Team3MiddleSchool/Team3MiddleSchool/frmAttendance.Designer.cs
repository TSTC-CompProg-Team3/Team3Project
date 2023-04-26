namespace Team3MiddleSchool
{
    partial class frmAttendance
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
            this.pnlAttendance = new System.Windows.Forms.Panel();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.lblAttendTeacher = new System.Windows.Forms.Label();
            this.lblAttendClass = new System.Windows.Forms.Label();
            this.btnEditAttend = new System.Windows.Forms.Button();
            this.btnBackAttend = new System.Windows.Forms.Button();
            this.dtpAttendance = new System.Windows.Forms.DateTimePicker();
            this.btnSubmitAttend = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAttendance
            // 
            this.pnlAttendance.Controls.Add(this.dgvAttendance);
            this.pnlAttendance.Controls.Add(this.lblAttendTeacher);
            this.pnlAttendance.Controls.Add(this.lblAttendClass);
            this.pnlAttendance.Location = new System.Drawing.Point(13, 51);
            this.pnlAttendance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAttendance.Name = "pnlAttendance";
            this.pnlAttendance.Size = new System.Drawing.Size(742, 600);
            this.pnlAttendance.TabIndex = 18;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(8, 60);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.Size = new System.Drawing.Size(732, 518);
            this.dgvAttendance.TabIndex = 0;
            this.dgvAttendance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAttendance_CellFormatting);
            // 
            // lblAttendTeacher
            // 
            this.lblAttendTeacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendTeacher.Location = new System.Drawing.Point(2, 2);
            this.lblAttendTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendTeacher.Name = "lblAttendTeacher";
            this.lblAttendTeacher.Size = new System.Drawing.Size(400, 63);
            this.lblAttendTeacher.TabIndex = 19;
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
            this.lblAttendClass.TabIndex = 20;
            this.lblAttendClass.Text = "Class: ";
            this.lblAttendClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditAttend
            // 
            this.btnEditAttend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAttend.Location = new System.Drawing.Point(161, 671);
            this.btnEditAttend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditAttend.Name = "btnEditAttend";
            this.btnEditAttend.Size = new System.Drawing.Size(112, 43);
            this.btnEditAttend.TabIndex = 17;
            this.btnEditAttend.Text = "Edit";
            this.btnEditAttend.UseVisualStyleBackColor = true;
            this.btnEditAttend.Click += new System.EventHandler(this.btnEditAttend_Click);
            // 
            // btnBackAttend
            // 
            this.btnBackAttend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackAttend.Location = new System.Drawing.Point(21, 671);
            this.btnBackAttend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackAttend.Name = "btnBackAttend";
            this.btnBackAttend.Size = new System.Drawing.Size(112, 43);
            this.btnBackAttend.TabIndex = 16;
            this.btnBackAttend.Text = "Back";
            this.btnBackAttend.UseVisualStyleBackColor = true;
            this.btnBackAttend.Click += new System.EventHandler(this.btnBackAttend_Click);
            // 
            // dtpAttendance
            // 
            this.dtpAttendance.Location = new System.Drawing.Point(429, 681);
            this.dtpAttendance.Name = "dtpAttendance";
            this.dtpAttendance.Size = new System.Drawing.Size(309, 26);
            this.dtpAttendance.TabIndex = 19;
            this.dtpAttendance.ValueChanged += new System.EventHandler(this.dtpAttendance_ValueChanged);
            // 
            // btnSubmitAttend
            // 
            this.btnSubmitAttend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAttend.Location = new System.Drawing.Point(301, 671);
            this.btnSubmitAttend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitAttend.Name = "btnSubmitAttend";
            this.btnSubmitAttend.Size = new System.Drawing.Size(112, 43);
            this.btnSubmitAttend.TabIndex = 20;
            this.btnSubmitAttend.Text = "Submit";
            this.btnSubmitAttend.UseVisualStyleBackColor = true;
            this.btnSubmitAttend.Click += new System.EventHandler(this.btnSubmitAttend_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 33);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // attendanceReportsToolStripMenuItem
            // 
            this.attendanceReportsToolStripMenuItem.Name = "attendanceReportsToolStripMenuItem";
            this.attendanceReportsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.attendanceReportsToolStripMenuItem.Text = "Attendance Report";
            this.attendanceReportsToolStripMenuItem.Click += new System.EventHandler(this.attendanceReportsToolStripMenuItem_Click);
            // 
            // frmAttendance
            // 
            this.AcceptButton = this.btnEditAttend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 742);
            this.ControlBox = false;
            this.Controls.Add(this.btnSubmitAttend);
            this.Controls.Add(this.dtpAttendance);
            this.Controls.Add(this.pnlAttendance);
            this.Controls.Add(this.btnEditAttend);
            this.Controls.Add(this.btnBackAttend);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Activated += new System.EventHandler(this.frmAttendance_Activated);
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            this.pnlAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlAttendance;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Button btnEditAttend;
        private System.Windows.Forms.Button btnBackAttend;
        private System.Windows.Forms.Label lblAttendTeacher;
        private System.Windows.Forms.Label lblAttendClass;
        private System.Windows.Forms.DateTimePicker dtpAttendance;
        private System.Windows.Forms.Button btnSubmitAttend;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceReportsToolStripMenuItem;
    }
}