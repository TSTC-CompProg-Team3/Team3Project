namespace Team3Project_Fixed
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
            this.components = new System.ComponentModel.Container();
            this.btnSubmitAttendEdit = new System.Windows.Forms.Button();
            this.btnClearAttendEdit = new System.Windows.Forms.Button();
            this.btnBackAttendEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inew2330gsp23DataSet = new Team3Project_Fixed.inew2330gsp23DataSet();
            this.inew2330gsp23DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330gsp23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330gsp23DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmitAttendEdit
            // 
            this.btnSubmitAttendEdit.Location = new System.Drawing.Point(617, 536);
            this.btnSubmitAttendEdit.Name = "btnSubmitAttendEdit";
            this.btnSubmitAttendEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAttendEdit.TabIndex = 0;
            this.btnSubmitAttendEdit.Text = "Submit";
            this.btnSubmitAttendEdit.UseVisualStyleBackColor = true;
            // 
            // btnClearAttendEdit
            // 
            this.btnClearAttendEdit.Location = new System.Drawing.Point(617, 592);
            this.btnClearAttendEdit.Name = "btnClearAttendEdit";
            this.btnClearAttendEdit.Size = new System.Drawing.Size(75, 23);
            this.btnClearAttendEdit.TabIndex = 1;
            this.btnClearAttendEdit.Text = "Clear";
            this.btnClearAttendEdit.UseVisualStyleBackColor = true;
            // 
            // btnBackAttendEdit
            // 
            this.btnBackAttendEdit.Location = new System.Drawing.Point(617, 652);
            this.btnBackAttendEdit.Name = "btnBackAttendEdit";
            this.btnBackAttendEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBackAttendEdit.TabIndex = 2;
            this.btnBackAttendEdit.Text = "Back";
            this.btnBackAttendEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.inew2330gsp23DataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(189, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 353);
            this.dataGridView1.TabIndex = 3;
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
            // frmAttedanceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 710);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBackAttendEdit);
            this.Controls.Add(this.btnClearAttendEdit);
            this.Controls.Add(this.btnSubmitAttendEdit);
            this.Name = "frmAttedanceEdit";
            this.Text = "frmAttedanceEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330gsp23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330gsp23DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitAttendEdit;
        private System.Windows.Forms.Button btnClearAttendEdit;
        private System.Windows.Forms.Button btnBackAttendEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource inew2330gsp23DataSetBindingSource;
        private inew2330gsp23DataSet inew2330gsp23DataSet;
    }
}