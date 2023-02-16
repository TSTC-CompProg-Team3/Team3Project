namespace DatabaseConnection_G3_sp23
{
    partial class frmEditCourse
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbxClassID = new System.Windows.Forms.TextBox();
            this.lblClassSize = new System.Windows.Forms.Label();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.tsStatus = new System.Windows.Forms.StatusStrip();
            this.tssDatabaseConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbxClassSize = new System.Windows.Forms.ComboBox();
            this.cbxSubjectID = new System.Windows.Forms.ComboBox();
            this.cbxTeacherID = new System.Windows.Forms.ComboBox();
            this.tsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(501, 429);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 40);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(169, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 40);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(336, 429);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(117, 40);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbxClassID
            // 
            this.tbxClassID.Enabled = false;
            this.tbxClassID.Location = new System.Drawing.Point(296, 90);
            this.tbxClassID.Name = "tbxClassID";
            this.tbxClassID.Size = new System.Drawing.Size(157, 23);
            this.tbxClassID.TabIndex = 20;
            // 
            // lblClassSize
            // 
            this.lblClassSize.AutoSize = true;
            this.lblClassSize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassSize.Location = new System.Drawing.Point(164, 312);
            this.lblClassSize.Name = "lblClassSize";
            this.lblClassSize.Size = new System.Drawing.Size(95, 25);
            this.lblClassSize.TabIndex = 19;
            this.lblClassSize.Text = "Class Size";
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectID.Location = new System.Drawing.Point(164, 238);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(103, 25);
            this.lblSubjectID.TabIndex = 18;
            this.lblSubjectID.Text = "Subject ID";
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherID.Location = new System.Drawing.Point(164, 164);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(104, 25);
            this.lblTeacherID.TabIndex = 17;
            this.lblTeacherID.Text = "Teacher ID";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassID.Location = new System.Drawing.Point(164, 90);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(80, 25);
            this.lblClassID.TabIndex = 16;
            this.lblClassID.Text = "Class ID";
            // 
            // tsStatus
            // 
            this.tsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDatabaseConnection});
            this.tsStatus.Location = new System.Drawing.Point(0, 501);
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(659, 35);
            this.tsStatus.TabIndex = 27;
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
            // cbxClassSize
            // 
            this.cbxClassSize.FormattingEnabled = true;
            this.cbxClassSize.Items.AddRange(new object[] {
            "5",
            "10",
            "20"});
            this.cbxClassSize.Location = new System.Drawing.Point(296, 317);
            this.cbxClassSize.Name = "cbxClassSize";
            this.cbxClassSize.Size = new System.Drawing.Size(157, 23);
            this.cbxClassSize.TabIndex = 23;
            // 
            // cbxSubjectID
            // 
            this.cbxSubjectID.FormattingEnabled = true;
            this.cbxSubjectID.Location = new System.Drawing.Point(296, 243);
            this.cbxSubjectID.Name = "cbxSubjectID";
            this.cbxSubjectID.Size = new System.Drawing.Size(157, 23);
            this.cbxSubjectID.TabIndex = 22;
            // 
            // cbxTeacherID
            // 
            this.cbxTeacherID.FormattingEnabled = true;
            this.cbxTeacherID.Location = new System.Drawing.Point(296, 164);
            this.cbxTeacherID.Name = "cbxTeacherID";
            this.cbxTeacherID.Size = new System.Drawing.Size(157, 23);
            this.cbxTeacherID.TabIndex = 21;
            // 
            // frmEditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 536);
            this.Controls.Add(this.tsStatus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbxClassSize);
            this.Controls.Add(this.cbxSubjectID);
            this.Controls.Add(this.cbxTeacherID);
            this.Controls.Add(this.tbxClassID);
            this.Controls.Add(this.lblClassSize);
            this.Controls.Add(this.lblSubjectID);
            this.Controls.Add(this.lblTeacherID);
            this.Controls.Add(this.lblClassID);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEditCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Course";
            this.Load += new System.EventHandler(this.frmEditCourse_Load);
            this.tsStatus.ResumeLayout(false);
            this.tsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxClassID;
        private System.Windows.Forms.Label lblClassSize;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.StatusStrip tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssDatabaseConnection;
        private System.Windows.Forms.ComboBox cbxClassSize;
        private System.Windows.Forms.ComboBox cbxSubjectID;
        private System.Windows.Forms.ComboBox cbxTeacherID;
    }
}