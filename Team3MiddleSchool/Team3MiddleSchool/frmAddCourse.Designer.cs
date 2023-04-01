namespace Team3MiddleSchool
{
    partial class frmAddCourse
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
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.lblClassSize = new System.Windows.Forms.Label();
            this.tbxClassName = new System.Windows.Forms.TextBox();
            this.cbxTeacherID = new System.Windows.Forms.ComboBox();
            this.cbxSubjectID = new System.Windows.Forms.ComboBox();
            this.cbxClassSize = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(122, 102);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(112, 25);
            this.lblClassName.TabIndex = 4;
            this.lblClassName.Text = "Class Name";
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherID.Location = new System.Drawing.Point(122, 176);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(104, 25);
            this.lblTeacherID.TabIndex = 5;
            this.lblTeacherID.Text = "Teacher ID";
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectID.Location = new System.Drawing.Point(122, 250);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(103, 25);
            this.lblSubjectID.TabIndex = 6;
            this.lblSubjectID.Text = "Subject ID";
            // 
            // lblClassSize
            // 
            this.lblClassSize.AutoSize = true;
            this.lblClassSize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassSize.Location = new System.Drawing.Point(122, 324);
            this.lblClassSize.Name = "lblClassSize";
            this.lblClassSize.Size = new System.Drawing.Size(95, 25);
            this.lblClassSize.TabIndex = 7;
            this.lblClassSize.Text = "Class Size";
            // 
            // tbxClassName
            // 
            this.tbxClassName.Location = new System.Drawing.Point(254, 102);
            this.tbxClassName.Name = "tbxClassName";
            this.tbxClassName.Size = new System.Drawing.Size(157, 23);
            this.tbxClassName.TabIndex = 8;
            this.tbxClassName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxClassName_KeyPress);
            // 
            // cbxTeacherID
            // 
            this.cbxTeacherID.FormattingEnabled = true;
            this.cbxTeacherID.Location = new System.Drawing.Point(254, 176);
            this.cbxTeacherID.Name = "cbxTeacherID";
            this.cbxTeacherID.Size = new System.Drawing.Size(157, 23);
            this.cbxTeacherID.TabIndex = 9;
            // 
            // cbxSubjectID
            // 
            this.cbxSubjectID.FormattingEnabled = true;
            this.cbxSubjectID.Location = new System.Drawing.Point(254, 255);
            this.cbxSubjectID.Name = "cbxSubjectID";
            this.cbxSubjectID.Size = new System.Drawing.Size(157, 23);
            this.cbxSubjectID.TabIndex = 10;
            // 
            // cbxClassSize
            // 
            this.cbxClassSize.FormattingEnabled = true;
            this.cbxClassSize.Items.AddRange(new object[] {
            "5",
            "10",
            "20"});
            this.cbxClassSize.Location = new System.Drawing.Point(254, 329);
            this.cbxClassSize.Name = "cbxClassSize";
            this.cbxClassSize.Size = new System.Drawing.Size(157, 23);
            this.cbxClassSize.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(216, 454);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(117, 40);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(49, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 40);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(381, 454);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 40);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAddCourse
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 536);
            this.ControlBox = false;
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
            this.Name = "frmAddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.frmAddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.Label lblClassSize;
        private System.Windows.Forms.TextBox tbxClassName;
        private System.Windows.Forms.ComboBox cbxTeacherID;
        private System.Windows.Forms.ComboBox cbxSubjectID;
        private System.Windows.Forms.ComboBox cbxClassSize;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}