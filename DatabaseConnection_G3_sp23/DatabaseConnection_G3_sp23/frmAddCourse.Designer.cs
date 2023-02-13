﻿namespace Team3Project_Fixed
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
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.lblClassSize = new System.Windows.Forms.Label();
            this.tbxClassID = new System.Windows.Forms.TextBox();
            this.cbxTeacherID = new System.Windows.Forms.ComboBox();
            this.cbxSubjectID = new System.Windows.Forms.ComboBox();
            this.cbxClassSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassID.Location = new System.Drawing.Point(178, 102);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(80, 25);
            this.lblClassID.TabIndex = 4;
            this.lblClassID.Text = "Class ID";
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherID.Location = new System.Drawing.Point(178, 176);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(104, 25);
            this.lblTeacherID.TabIndex = 5;
            this.lblTeacherID.Text = "Teacher ID";
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectID.Location = new System.Drawing.Point(178, 250);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(103, 25);
            this.lblSubjectID.TabIndex = 6;
            this.lblSubjectID.Text = "Subject ID";
            // 
            // lblClassSize
            // 
            this.lblClassSize.AutoSize = true;
            this.lblClassSize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassSize.Location = new System.Drawing.Point(178, 324);
            this.lblClassSize.Name = "lblClassSize";
            this.lblClassSize.Size = new System.Drawing.Size(95, 25);
            this.lblClassSize.TabIndex = 7;
            this.lblClassSize.Text = "Class Size";
            // 
            // tbxClassID
            // 
            this.tbxClassID.Location = new System.Drawing.Point(310, 102);
            this.tbxClassID.Name = "tbxClassID";
            this.tbxClassID.Size = new System.Drawing.Size(157, 23);
            this.tbxClassID.TabIndex = 8;
            // 
            // cbxTeacherID
            // 
            this.cbxTeacherID.FormattingEnabled = true;
            this.cbxTeacherID.Location = new System.Drawing.Point(310, 176);
            this.cbxTeacherID.Name = "cbxTeacherID";
            this.cbxTeacherID.Size = new System.Drawing.Size(157, 23);
            this.cbxTeacherID.TabIndex = 9;
            // 
            // cbxSubjectID
            // 
            this.cbxSubjectID.FormattingEnabled = true;
            this.cbxSubjectID.Location = new System.Drawing.Point(310, 255);
            this.cbxSubjectID.Name = "cbxSubjectID";
            this.cbxSubjectID.Size = new System.Drawing.Size(157, 23);
            this.cbxSubjectID.TabIndex = 10;
            // 
            // cbxClassSize
            // 
            this.cbxClassSize.FormattingEnabled = true;
            this.cbxClassSize.Location = new System.Drawing.Point(310, 329);
            this.cbxClassSize.Name = "cbxClassSize";
            this.cbxClassSize.Size = new System.Drawing.Size(157, 23);
            this.cbxClassSize.TabIndex = 11;
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 536);
            this.ControlBox = false;
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
            this.Name = "frmAddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.Label lblClassSize;
        private System.Windows.Forms.TextBox tbxClassID;
        private System.Windows.Forms.ComboBox cbxTeacherID;
        private System.Windows.Forms.ComboBox cbxSubjectID;
        private System.Windows.Forms.ComboBox cbxClassSize;
    }
}