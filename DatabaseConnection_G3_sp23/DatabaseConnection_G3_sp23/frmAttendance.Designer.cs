namespace DatabaseConnection_G3_sp23
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
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.btnBackAttend = new System.Windows.Forms.Button();
            this.btnEditAttend = new System.Windows.Forms.Button();
            this.pnlAttendance = new System.Windows.Forms.Panel();
            this.tsStatus = new System.Windows.Forms.StatusStrip();
            this.tssDatabaseConnection = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlAttendance.SuspendLayout();
            this.tsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(20, 20);
            this.dgvAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.Size = new System.Drawing.Size(800, 600);
            this.dgvAttendance.TabIndex = 0;
            this.dgvAttendance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAttendance_CellFormatting);
            // 
            // btnBackAttend
            // 
            this.btnBackAttend.Location = new System.Drawing.Point(692, 718);
            this.btnBackAttend.Name = "btnBackAttend";
            this.btnBackAttend.Size = new System.Drawing.Size(172, 55);
            this.btnBackAttend.TabIndex = 1;
            this.btnBackAttend.Text = "Back";
            this.btnBackAttend.UseVisualStyleBackColor = true;
            this.btnBackAttend.Click += new System.EventHandler(this.btnBackAttend_Click);
            // 
            // btnEditAttend
            // 
            this.btnEditAttend.Location = new System.Drawing.Point(248, 718);
            this.btnEditAttend.Name = "btnEditAttend";
            this.btnEditAttend.Size = new System.Drawing.Size(158, 55);
            this.btnEditAttend.TabIndex = 2;
            this.btnEditAttend.Text = "Edit";
            this.btnEditAttend.UseVisualStyleBackColor = true;
            this.btnEditAttend.Click += new System.EventHandler(this.btnEditAttend_Click);
            // 
            // pnlAttendance
            // 
            this.pnlAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAttendance.Controls.Add(this.dgvAttendance);
            this.pnlAttendance.Location = new System.Drawing.Point(127, 30);
            this.pnlAttendance.Name = "pnlAttendance";
            this.pnlAttendance.Size = new System.Drawing.Size(840, 640);
            this.pnlAttendance.TabIndex = 3;
            // 
            // tsStatus
            // 
            this.tsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDatabaseConnection});
            this.tsStatus.Location = new System.Drawing.Point(0, 831);
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(1095, 35);
            this.tsStatus.TabIndex = 15;
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
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 866);
            this.Controls.Add(this.tsStatus);
            this.Controls.Add(this.pnlAttendance);
            this.Controls.Add(this.btnEditAttend);
            this.Controls.Add(this.btnBackAttend);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.pnlAttendance.ResumeLayout(false);
            this.tsStatus.ResumeLayout(false);
            this.tsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Button btnBackAttend;
        private System.Windows.Forms.Button btnEditAttend;
        private System.Windows.Forms.Panel pnlAttendance;
        private System.Windows.Forms.StatusStrip tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssDatabaseConnection;
    }
}