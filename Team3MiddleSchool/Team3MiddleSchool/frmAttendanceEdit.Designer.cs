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
            this.lblAttendClass = new System.Windows.Forms.Label();
            this.lblAttendTeacher = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceEdit)).BeginInit();
            this.pnlAttendanceEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackAttendEdit
            // 
            this.btnBackAttendEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackAttendEdit.Location = new System.Drawing.Point(309, 622);
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
            this.btnClearAttendEdit.Location = new System.Drawing.Point(174, 622);
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
            this.btnSubmitAttendEdit.Location = new System.Drawing.Point(39, 622);
            this.btnSubmitAttendEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitAttendEdit.Name = "btnSubmitAttendEdit";
            this.btnSubmitAttendEdit.Size = new System.Drawing.Size(112, 43);
            this.btnSubmitAttendEdit.TabIndex = 17;
            this.btnSubmitAttendEdit.Text = "Submit";
            this.btnSubmitAttendEdit.UseVisualStyleBackColor = true;
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
            this.dtpAttendanceEdit.Location = new System.Drawing.Point(450, 648);
            this.dtpAttendanceEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpAttendanceEdit.Name = "dtpAttendanceEdit";
            this.dtpAttendanceEdit.Size = new System.Drawing.Size(278, 26);
            this.dtpAttendanceEdit.TabIndex = 22;
            this.dtpAttendanceEdit.ValueChanged += new System.EventHandler(this.dtpAttendanceEdit_ValueChanged);
            // 
            // cmbNamesEdit
            // 
            this.cmbNamesEdit.FormattingEnabled = true;
            this.cmbNamesEdit.Location = new System.Drawing.Point(450, 611);
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
            this.pnlAttendanceEdit.Location = new System.Drawing.Point(12, 0);
            this.pnlAttendanceEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAttendanceEdit.Name = "pnlAttendanceEdit";
            this.pnlAttendanceEdit.Size = new System.Drawing.Size(742, 600);
            this.pnlAttendanceEdit.TabIndex = 20;
            // 
            // lblAttendClass
            // 
            this.lblAttendClass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendClass.Location = new System.Drawing.Point(410, 0);
            this.lblAttendClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendClass.Name = "lblAttendClass";
            this.lblAttendClass.Size = new System.Drawing.Size(328, 63);
            this.lblAttendClass.TabIndex = 24;
            this.lblAttendClass.Text = "Class: ";
            this.lblAttendClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAttendTeacher
            // 
            this.lblAttendTeacher.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendTeacher.Location = new System.Drawing.Point(2, 2);
            this.lblAttendTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendTeacher.Name = "lblAttendTeacher";
            this.lblAttendTeacher.Size = new System.Drawing.Size(400, 63);
            this.lblAttendTeacher.TabIndex = 23;
            this.lblAttendTeacher.Text = "Teacher: ";
            this.lblAttendTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAttendanceEdit
            // 
            this.AcceptButton = this.btnSubmitAttendEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 691);
            this.ControlBox = false;
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
        private System.Windows.Forms.Label lblAttendClass;
        private System.Windows.Forms.Label lblAttendTeacher;
    }
}