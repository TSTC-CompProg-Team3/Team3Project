﻿namespace Team3MiddleSchool
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblAttendTeacher = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceEdit)).BeginInit();
            this.pnlAttendanceEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackAttendEdit
            // 
            this.btnBackAttendEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackAttendEdit.Location = new System.Drawing.Point(206, 404);
            this.btnBackAttendEdit.Name = "btnBackAttendEdit";
            this.btnBackAttendEdit.Size = new System.Drawing.Size(75, 28);
            this.btnBackAttendEdit.TabIndex = 19;
            this.btnBackAttendEdit.Text = "Back";
            this.btnBackAttendEdit.UseVisualStyleBackColor = true;
            this.btnBackAttendEdit.Click += new System.EventHandler(this.btnBackAttendEdit_Click);
            // 
            // btnClearAttendEdit
            // 
            this.btnClearAttendEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAttendEdit.Location = new System.Drawing.Point(116, 404);
            this.btnClearAttendEdit.Name = "btnClearAttendEdit";
            this.btnClearAttendEdit.Size = new System.Drawing.Size(75, 28);
            this.btnClearAttendEdit.TabIndex = 18;
            this.btnClearAttendEdit.Text = "Clear";
            this.btnClearAttendEdit.UseVisualStyleBackColor = true;
            this.btnClearAttendEdit.Click += new System.EventHandler(this.btnClearAttendEdit_Click);
            // 
            // btnSubmitAttendEdit
            // 
            this.btnSubmitAttendEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAttendEdit.Location = new System.Drawing.Point(26, 404);
            this.btnSubmitAttendEdit.Name = "btnSubmitAttendEdit";
            this.btnSubmitAttendEdit.Size = new System.Drawing.Size(75, 28);
            this.btnSubmitAttendEdit.TabIndex = 17;
            this.btnSubmitAttendEdit.Text = "Submit";
            this.btnSubmitAttendEdit.UseVisualStyleBackColor = true;
            // 
            // dgvAttendanceEdit
            // 
            this.dgvAttendanceEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceEdit.Location = new System.Drawing.Point(5, 39);
            this.dgvAttendanceEdit.Name = "dgvAttendanceEdit";
            this.dgvAttendanceEdit.RowHeadersVisible = false;
            this.dgvAttendanceEdit.RowHeadersWidth = 51;
            this.dgvAttendanceEdit.Size = new System.Drawing.Size(488, 337);
            this.dgvAttendanceEdit.TabIndex = 3;
            this.dgvAttendanceEdit.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAttendanceEdit_CellFormatting);
            // 
            // dtpAttendanceEdit
            // 
            this.dtpAttendanceEdit.Location = new System.Drawing.Point(300, 421);
            this.dtpAttendanceEdit.Name = "dtpAttendanceEdit";
            this.dtpAttendanceEdit.Size = new System.Drawing.Size(187, 20);
            this.dtpAttendanceEdit.TabIndex = 22;
            this.dtpAttendanceEdit.ValueChanged += new System.EventHandler(this.dtpAttendanceEdit_ValueChanged);
            // 
            // cmbNamesEdit
            // 
            this.cmbNamesEdit.FormattingEnabled = true;
            this.cmbNamesEdit.Location = new System.Drawing.Point(300, 397);
            this.cmbNamesEdit.Name = "cmbNamesEdit";
            this.cmbNamesEdit.Size = new System.Drawing.Size(187, 21);
            this.cmbNamesEdit.TabIndex = 21;
            this.cmbNamesEdit.SelectedValueChanged += new System.EventHandler(this.cmbNamesEdit_SelectedValueChanged);
            // 
            // pnlAttendanceEdit
            // 
            this.pnlAttendanceEdit.Controls.Add(this.label2);
            this.pnlAttendanceEdit.Controls.Add(this.dgvAttendanceEdit);
            this.pnlAttendanceEdit.Controls.Add(this.lblAttendTeacher);
            this.pnlAttendanceEdit.Location = new System.Drawing.Point(8, 0);
            this.pnlAttendanceEdit.Name = "pnlAttendanceEdit";
            this.pnlAttendanceEdit.Size = new System.Drawing.Size(495, 390);
            this.pnlAttendanceEdit.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 41);
            this.label2.TabIndex = 24;
            this.label2.Text = "Class: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAttendTeacher
            // 
            this.lblAttendTeacher.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendTeacher.Location = new System.Drawing.Point(1, 1);
            this.lblAttendTeacher.Name = "lblAttendTeacher";
            this.lblAttendTeacher.Size = new System.Drawing.Size(150, 41);
            this.lblAttendTeacher.TabIndex = 23;
            this.lblAttendTeacher.Text = "Teacher: ";
            this.lblAttendTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAttendanceEdit
            // 
            this.AcceptButton = this.btnSubmitAttendEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 449);
            this.ControlBox = false;
            this.Controls.Add(this.btnBackAttendEdit);
            this.Controls.Add(this.pnlAttendanceEdit);
            this.Controls.Add(this.btnSubmitAttendEdit);
            this.Controls.Add(this.cmbNamesEdit);
            this.Controls.Add(this.dtpAttendanceEdit);
            this.Controls.Add(this.btnClearAttendEdit);
            this.Name = "frmAttendanceEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Attendance";
            this.Load += new System.EventHandler(this.frmAttendanceEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceEdit)).EndInit();
            this.pnlAttendanceEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackAttendEdit;
        private System.Windows.Forms.Button btnClearAttendEdit;
        private System.Windows.Forms.Button btnSubmitAttendEdit;
        private System.Windows.Forms.DataGridView dgvAttendanceEdit;
        private System.Windows.Forms.DateTimePicker dtpAttendanceEdit;
        private System.Windows.Forms.ComboBox cmbNamesEdit;
        private System.Windows.Forms.Panel pnlAttendanceEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAttendTeacher;
    }
}