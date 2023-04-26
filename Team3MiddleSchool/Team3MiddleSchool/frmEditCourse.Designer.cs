namespace Team3MiddleSchool
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
            this.tbxClassName = new System.Windows.Forms.TextBox();
            this.lblClassSize = new System.Windows.Forms.Label();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.cbxClassSize = new System.Windows.Forms.ComboBox();
            this.cbxSubjectID = new System.Windows.Forms.ComboBox();
            this.cbxTeacherID = new System.Windows.Forms.ComboBox();
            this.lblClassNameWarning = new System.Windows.Forms.Label();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(381, 441);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 40);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(49, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(216, 441);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(117, 40);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbxClassName
            // 
            this.tbxClassName.Location = new System.Drawing.Point(261, 90);
            this.tbxClassName.Name = "tbxClassName";
            this.tbxClassName.Size = new System.Drawing.Size(157, 23);
            this.tbxClassName.TabIndex = 0;
            this.tbxClassName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxClassName_KeyPress);
            // 
            // lblClassSize
            // 
            this.lblClassSize.AutoSize = true;
            this.lblClassSize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassSize.Location = new System.Drawing.Point(129, 312);
            this.lblClassSize.Name = "lblClassSize";
            this.lblClassSize.Size = new System.Drawing.Size(95, 25);
            this.lblClassSize.TabIndex = 19;
            this.lblClassSize.Text = "Class Size";
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectID.Location = new System.Drawing.Point(129, 238);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(103, 25);
            this.lblSubjectID.TabIndex = 18;
            this.lblSubjectID.Text = "Subject ID";
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherID.Location = new System.Drawing.Point(129, 164);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(104, 25);
            this.lblTeacherID.TabIndex = 17;
            this.lblTeacherID.Text = "Teacher ID";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(129, 90);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(112, 25);
            this.lblClassName.TabIndex = 16;
            this.lblClassName.Text = "Class Name";
            // 
            // cbxClassSize
            // 
            this.cbxClassSize.FormattingEnabled = true;
            this.cbxClassSize.Items.AddRange(new object[] {
            "5",
            "10",
            "20"});
            this.cbxClassSize.Location = new System.Drawing.Point(261, 317);
            this.cbxClassSize.Name = "cbxClassSize";
            this.cbxClassSize.Size = new System.Drawing.Size(157, 23);
            this.cbxClassSize.TabIndex = 3;
            // 
            // cbxSubjectID
            // 
            this.cbxSubjectID.FormattingEnabled = true;
            this.cbxSubjectID.Location = new System.Drawing.Point(261, 243);
            this.cbxSubjectID.Name = "cbxSubjectID";
            this.cbxSubjectID.Size = new System.Drawing.Size(157, 23);
            this.cbxSubjectID.TabIndex = 2;
            // 
            // cbxTeacherID
            // 
            this.cbxTeacherID.FormattingEnabled = true;
            this.cbxTeacherID.Location = new System.Drawing.Point(261, 164);
            this.cbxTeacherID.Name = "cbxTeacherID";
            this.cbxTeacherID.Size = new System.Drawing.Size(157, 23);
            this.cbxTeacherID.TabIndex = 1;
            // 
            // lblClassNameWarning
            // 
            this.lblClassNameWarning.AutoSize = true;
            this.lblClassNameWarning.BackColor = System.Drawing.Color.Red;
            this.lblClassNameWarning.ForeColor = System.Drawing.Color.Black;
            this.lblClassNameWarning.Location = new System.Drawing.Point(261, 116);
            this.lblClassNameWarning.Name = "lblClassNameWarning";
            this.lblClassNameWarning.Size = new System.Drawing.Size(157, 15);
            this.lblClassNameWarning.TabIndex = 27;
            this.lblClassNameWarning.Text = "Must Enter Valid Class Name";
            this.lblClassNameWarning.Visible = false;
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(547, 24);
            this.mnuStrip.TabIndex = 28;
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
            // frmEditCourse
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 536);
            this.ControlBox = false;
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.lblClassNameWarning);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbxClassSize);
            this.Controls.Add(this.cbxSubjectID);
            this.Controls.Add(this.cbxTeacherID);
            this.Controls.Add(this.tbxClassName);
            this.Controls.Add(this.lblClassSize);
            this.Controls.Add(this.lblSubjectID);
            this.Controls.Add(this.lblTeacherID);
            this.Controls.Add(this.lblClassName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEditCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Course";
            this.Load += new System.EventHandler(this.frmEditCourse_Load);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxClassName;
        private System.Windows.Forms.Label lblClassSize;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.ComboBox cbxClassSize;
        private System.Windows.Forms.ComboBox cbxSubjectID;
        private System.Windows.Forms.ComboBox cbxTeacherID;
        private System.Windows.Forms.Label lblClassNameWarning;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
    }
}