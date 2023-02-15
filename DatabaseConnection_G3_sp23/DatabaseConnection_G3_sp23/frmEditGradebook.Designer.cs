namespace DatabaseConnection_G3_sp23
{
    partial class frmEditGradebook
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
            this.lblAssignName = new System.Windows.Forms.Label();
            this.lblassignType = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.tbxAssignName = new System.Windows.Forms.TextBox();
            this.tbxAssignType = new System.Windows.Forms.TextBox();
            this.tbxGrade = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAssignName
            // 
            this.lblAssignName.AutoSize = true;
            this.lblAssignName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignName.Location = new System.Drawing.Point(3, 9);
            this.lblAssignName.Name = "lblAssignName";
            this.lblAssignName.Size = new System.Drawing.Size(209, 29);
            this.lblAssignName.TabIndex = 0;
            this.lblAssignName.Text = "Assignment Name";
            this.lblAssignName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblassignType
            // 
            this.lblassignType.AutoSize = true;
            this.lblassignType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassignType.Location = new System.Drawing.Point(218, 9);
            this.lblassignType.Name = "lblassignType";
            this.lblassignType.Size = new System.Drawing.Size(199, 29);
            this.lblassignType.TabIndex = 1;
            this.lblassignType.Text = "Assignment Type\r\n";
            this.lblassignType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(439, 9);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(80, 29);
            this.lblGrade.TabIndex = 2;
            this.lblGrade.Text = "Grade";
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxAssignName
            // 
            this.tbxAssignName.Location = new System.Drawing.Point(17, 60);
            this.tbxAssignName.Name = "tbxAssignName";
            this.tbxAssignName.Size = new System.Drawing.Size(185, 26);
            this.tbxAssignName.TabIndex = 3;
            // 
            // tbxAssignType
            // 
            this.tbxAssignType.Location = new System.Drawing.Point(223, 57);
            this.tbxAssignType.Name = "tbxAssignType";
            this.tbxAssignType.Size = new System.Drawing.Size(185, 26);
            this.tbxAssignType.TabIndex = 4;
            // 
            // tbxGrade
            // 
            this.tbxGrade.Location = new System.Drawing.Point(444, 60);
            this.tbxGrade.Name = "tbxGrade";
            this.tbxGrade.Size = new System.Drawing.Size(75, 26);
            this.tbxGrade.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(127, 92);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 49);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(310, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 49);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(457, 106);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 20);
            this.lblCount.TabIndex = 8;
            // 
            // frmEditGradebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 150);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbxGrade);
            this.Controls.Add(this.tbxAssignType);
            this.Controls.Add(this.tbxAssignName);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblassignType);
            this.Controls.Add(this.lblAssignName);
            this.Name = "frmEditGradebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Grade";
            this.Load += new System.EventHandler(this.frmAddGradebook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssignName;
        private System.Windows.Forms.Label lblassignType;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox tbxAssignName;
        private System.Windows.Forms.TextBox tbxAssignType;
        private System.Windows.Forms.TextBox tbxGrade;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCount;
    }
}