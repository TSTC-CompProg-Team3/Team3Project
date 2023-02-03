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
            this.inew2330gsp23DataSet = new Team3Project_Fixed.inew2330gsp23DataSet();
            this.inew2330gsp23DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330gsp23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330gsp23DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AutoGenerateColumns = false;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.DataSource = this.inew2330gsp23DataSetBindingSource;
            this.dgvAttendance.Location = new System.Drawing.Point(127, 71);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.Size = new System.Drawing.Size(661, 396);
            this.dgvAttendance.TabIndex = 0;
            // 
            // inew2330gsp23DataSet
            // 
            this.inew2330gsp23DataSet.DataSetName = "inew2330gsp23DataSet";
            this.inew2330gsp23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inew2330gsp23DataSetBindingSource
            // 
            this.inew2330gsp23DataSetBindingSource.DataSource = this.inew2330gsp23DataSet;
            this.inew2330gsp23DataSetBindingSource.Position = 0;
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 612);
            this.Controls.Add(this.dgvAttendance);
            this.Name = "frmAttendance";
            this.Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330gsp23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330gsp23DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.BindingSource inew2330gsp23DataSetBindingSource;
        private inew2330gsp23DataSet inew2330gsp23DataSet;
    }
}