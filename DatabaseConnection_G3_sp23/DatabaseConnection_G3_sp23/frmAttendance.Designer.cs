namespace Team3Project_Fixed
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
            this.components = new System.ComponentModel.Container();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.inew2330gsp23DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inew2330gsp23DataSet = new Team3Project_Fixed.inew2330gsp23DataSet();
            this.btnBackAttend = new System.Windows.Forms.Button();
            this.btnEditAttend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330gsp23DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330gsp23DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AutoGenerateColumns = false;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.DataSource = this.inew2330gsp23DataSetBindingSource;
            this.dgvAttendance.Location = new System.Drawing.Point(95, 58);
            this.dgvAttendance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.Size = new System.Drawing.Size(496, 322);
            this.dgvAttendance.TabIndex = 0;
            // 
            // inew2330gsp23DataSetBindingSource
            // 
            this.inew2330gsp23DataSetBindingSource.DataSource = this.inew2330gsp23DataSet;
            this.inew2330gsp23DataSetBindingSource.Position = 0;
            // 
            // inew2330gsp23DataSet
            // 
            this.inew2330gsp23DataSet.DataSetName = "inew2330gsp23DataSet";
            this.inew2330gsp23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBackAttend
            // 
            this.btnBackAttend.Location = new System.Drawing.Point(132, 408);
            this.btnBackAttend.Name = "btnBackAttend";
            this.btnBackAttend.Size = new System.Drawing.Size(172, 55);
            this.btnBackAttend.TabIndex = 1;
            this.btnBackAttend.Text = "Back";
            this.btnBackAttend.UseVisualStyleBackColor = true;
            // 
            // btnEditAttend
            // 
            this.btnEditAttend.Location = new System.Drawing.Point(393, 408);
            this.btnEditAttend.Name = "btnEditAttend";
            this.btnEditAttend.Size = new System.Drawing.Size(158, 55);
            this.btnEditAttend.TabIndex = 2;
            this.btnEditAttend.Text = "Edit";
            this.btnEditAttend.UseVisualStyleBackColor = true;
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 497);
            this.Controls.Add(this.btnEditAttend);
            this.Controls.Add(this.btnBackAttend);
            this.Controls.Add(this.dgvAttendance);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAttendance";
            this.Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330gsp23DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330gsp23DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.BindingSource inew2330gsp23DataSetBindingSource;
        private inew2330gsp23DataSet inew2330gsp23DataSet;
        private System.Windows.Forms.Button btnBackAttend;
        private System.Windows.Forms.Button btnEditAttend;
    }
}