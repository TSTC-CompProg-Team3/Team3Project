﻿namespace DatabaseConnection_G3_sp23
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditAttend = new System.Windows.Forms.Button();
            this.btnBackAttend = new System.Windows.Forms.Button();
            this.pnlAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAttendance
            // 
            this.pnlAttendance.Controls.Add(this.dgvAttendance);
            this.pnlAttendance.Controls.Add(this.lblAttendTeacher);
            this.pnlAttendance.Controls.Add(this.label2);
            this.pnlAttendance.Location = new System.Drawing.Point(8, 0);
            this.pnlAttendance.Name = "pnlAttendance";
            this.pnlAttendance.Size = new System.Drawing.Size(495, 390);
            this.pnlAttendance.TabIndex = 18;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(5, 39);
            this.dgvAttendance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.Size = new System.Drawing.Size(488, 337);
            this.dgvAttendance.TabIndex = 0;
            this.dgvAttendance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAttendance_CellFormatting);
            // 
            // lblAttendTeacher
            // 
            this.lblAttendTeacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendTeacher.Location = new System.Drawing.Point(1, 1);
            this.lblAttendTeacher.Name = "lblAttendTeacher";
            this.lblAttendTeacher.Size = new System.Drawing.Size(150, 41);
            this.lblAttendTeacher.TabIndex = 19;
            this.lblAttendTeacher.Text = "Teacher: ";
            this.lblAttendTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 41);
            this.label2.TabIndex = 20;
            this.label2.Text = "Class: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditAttend
            // 
            this.btnEditAttend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAttend.Location = new System.Drawing.Point(166, 410);
            this.btnEditAttend.Name = "btnEditAttend";
            this.btnEditAttend.Size = new System.Drawing.Size(75, 28);
            this.btnEditAttend.TabIndex = 17;
            this.btnEditAttend.Text = "Edit";
            this.btnEditAttend.UseVisualStyleBackColor = true;
            this.btnEditAttend.Click += new System.EventHandler(this.btnEditAttend_Click);
            // 
            // btnBackAttend
            // 
            this.btnBackAttend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackAttend.Location = new System.Drawing.Point(271, 410);
            this.btnBackAttend.Name = "btnBackAttend";
            this.btnBackAttend.Size = new System.Drawing.Size(75, 28);
            this.btnBackAttend.TabIndex = 16;
            this.btnBackAttend.Text = "Back";
            this.btnBackAttend.UseVisualStyleBackColor = true;
            this.btnBackAttend.Click += new System.EventHandler(this.btnBackAttend_Click);
            // 
            // frmAttendance
            // 
            this.AcceptButton = this.btnEditAttend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 449);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAttendance);
            this.Controls.Add(this.btnEditAttend);
            this.Controls.Add(this.btnBackAttend);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            this.pnlAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAttendance;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Button btnEditAttend;
        private System.Windows.Forms.Button btnBackAttend;
        private System.Windows.Forms.Label lblAttendTeacher;
        private System.Windows.Forms.Label label2;
    }
}