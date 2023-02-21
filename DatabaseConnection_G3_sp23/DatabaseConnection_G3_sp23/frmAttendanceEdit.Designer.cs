namespace DatabaseConnection_G3_sp23
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceEdit)).BeginInit();
            this.pnlAttendanceEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackAttendEdit
            // 
            this.btnBackAttendEdit.Location = new System.Drawing.Point(366, 790);
            this.btnBackAttendEdit.Name = "btnBackAttendEdit";
            this.btnBackAttendEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBackAttendEdit.TabIndex = 19;
            this.btnBackAttendEdit.Text = "Back";
            this.btnBackAttendEdit.UseVisualStyleBackColor = true;
            this.btnBackAttendEdit.Click += new System.EventHandler(this.btnBackAttendEdit_Click);
            // 
            // btnClearAttendEdit
            // 
            this.btnClearAttendEdit.Location = new System.Drawing.Point(235, 790);
            this.btnClearAttendEdit.Name = "btnClearAttendEdit";
            this.btnClearAttendEdit.Size = new System.Drawing.Size(75, 23);
            this.btnClearAttendEdit.TabIndex = 18;
            this.btnClearAttendEdit.Text = "Clear";
            this.btnClearAttendEdit.UseVisualStyleBackColor = true;
            // 
            // btnSubmitAttendEdit
            // 
            this.btnSubmitAttendEdit.Location = new System.Drawing.Point(109, 790);
            this.btnSubmitAttendEdit.Name = "btnSubmitAttendEdit";
            this.btnSubmitAttendEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAttendEdit.TabIndex = 17;
            this.btnSubmitAttendEdit.Text = "Submit";
            this.btnSubmitAttendEdit.UseVisualStyleBackColor = true;
            // 
            // dgvAttendanceEdit
            // 
            this.dgvAttendanceEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceEdit.Location = new System.Drawing.Point(20, 20);
            this.dgvAttendanceEdit.Name = "dgvAttendanceEdit";
            this.dgvAttendanceEdit.Size = new System.Drawing.Size(800, 600);
            this.dgvAttendanceEdit.TabIndex = 3;
            this.dgvAttendanceEdit.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAttendanceEdit_CellFormatting);
            // 
            // dtpAttendanceEdit
            // 
            this.dtpAttendanceEdit.Location = new System.Drawing.Point(627, 712);
            this.dtpAttendanceEdit.Name = "dtpAttendanceEdit";
            this.dtpAttendanceEdit.Size = new System.Drawing.Size(207, 20);
            this.dtpAttendanceEdit.TabIndex = 22;
            // 
            // cmbNamesEdit
            // 
            this.cmbNamesEdit.FormattingEnabled = true;
            this.cmbNamesEdit.Location = new System.Drawing.Point(244, 698);
            this.cmbNamesEdit.Name = "cmbNamesEdit";
            this.cmbNamesEdit.Size = new System.Drawing.Size(121, 21);
            this.cmbNamesEdit.TabIndex = 21;
            this.cmbNamesEdit.SelectedValueChanged += new System.EventHandler(this.cmbNamesEdit_SelectedValueChanged);
            // 
            // pnlAttendanceEdit
            // 
            this.pnlAttendanceEdit.Controls.Add(this.dgvAttendanceEdit);
            this.pnlAttendanceEdit.Location = new System.Drawing.Point(127, 15);
            this.pnlAttendanceEdit.Name = "pnlAttendanceEdit";
            this.pnlAttendanceEdit.Size = new System.Drawing.Size(840, 640);
            this.pnlAttendanceEdit.TabIndex = 20;
            // 
            // frmAttendanceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 866);
            this.Controls.Add(this.btnBackAttendEdit);
            this.Controls.Add(this.btnClearAttendEdit);
            this.Controls.Add(this.btnSubmitAttendEdit);
            this.Controls.Add(this.dtpAttendanceEdit);
            this.Controls.Add(this.cmbNamesEdit);
            this.Controls.Add(this.pnlAttendanceEdit);
            this.Name = "frmAttendanceEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Edit";
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
    }
}