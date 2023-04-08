namespace Team3MiddleSchool
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
            this.lblCount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbxGrade = new System.Windows.Forms.TextBox();
            this.tbxAssignType = new System.Windows.Forms.TextBox();
            this.tbxAssignName = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblassignType = new System.Windows.Forms.Label();
            this.lblAssignName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(326, 92);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 15);
            this.lblCount.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCancel.Location = new System.Drawing.Point(283, 102);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnSubmit.Location = new System.Drawing.Point(161, 102);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 32);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbxGrade
            // 
            this.tbxGrade.BackColor = System.Drawing.SystemColors.Control;
            this.tbxGrade.Location = new System.Drawing.Point(317, 62);
            this.tbxGrade.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGrade.Name = "tbxGrade";
            this.tbxGrade.Size = new System.Drawing.Size(51, 23);
            this.tbxGrade.TabIndex = 23;
            // 
            // tbxAssignType
            // 
            this.tbxAssignType.BackColor = System.Drawing.SystemColors.Control;
            this.tbxAssignType.Location = new System.Drawing.Point(170, 60);
            this.tbxAssignType.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAssignType.Name = "tbxAssignType";
            this.tbxAssignType.Size = new System.Drawing.Size(125, 23);
            this.tbxAssignType.TabIndex = 22;
            // 
            // tbxAssignName
            // 
            this.tbxAssignName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxAssignName.Location = new System.Drawing.Point(32, 62);
            this.tbxAssignName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAssignName.Name = "tbxAssignName";
            this.tbxAssignName.Size = new System.Drawing.Size(125, 23);
            this.tbxAssignName.TabIndex = 21;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(314, 29);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(52, 21);
            this.lblGrade.TabIndex = 20;
            this.lblGrade.Text = "Grade";
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblassignType
            // 
            this.lblassignType.AutoSize = true;
            this.lblassignType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassignType.Location = new System.Drawing.Point(166, 29);
            this.lblassignType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblassignType.Name = "lblassignType";
            this.lblassignType.Size = new System.Drawing.Size(128, 21);
            this.lblassignType.TabIndex = 19;
            this.lblassignType.Text = "Assignment Type\r\n";
            this.lblassignType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAssignName
            // 
            this.lblAssignName.AutoSize = true;
            this.lblAssignName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignName.Location = new System.Drawing.Point(23, 29);
            this.lblAssignName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssignName.Name = "lblAssignName";
            this.lblAssignName.Size = new System.Drawing.Size(138, 21);
            this.lblAssignName.TabIndex = 18;
            this.lblAssignName.Text = "Assignment Name";
            this.lblAssignName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEditGradebook
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 175);
            this.ControlBox = false;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbxGrade);
            this.Controls.Add(this.tbxAssignType);
            this.Controls.Add(this.tbxAssignName);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblassignType);
            this.Controls.Add(this.lblAssignName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEditGradebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxGrade;
        private System.Windows.Forms.TextBox tbxAssignType;
        private System.Windows.Forms.TextBox tbxAssignName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblassignType;
        private System.Windows.Forms.Label lblAssignName;
    }
}