namespace DatabaseConnection_G3_sp23
{
    partial class frmForgotPass
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
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxEnterCode = new System.Windows.Forms.TextBox();
            this.lblEnterEmail = new System.Windows.Forms.Label();
            this.lblEnterCode = new System.Windows.Forms.Label();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(106, 124);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(350, 23);
            this.tbxEmail.TabIndex = 6;
            // 
            // tbxEnterCode
            // 
            this.tbxEnterCode.Location = new System.Drawing.Point(106, 228);
            this.tbxEnterCode.Name = "tbxEnterCode";
            this.tbxEnterCode.Size = new System.Drawing.Size(350, 23);
            this.tbxEnterCode.TabIndex = 7;
            // 
            // lblEnterEmail
            // 
            this.lblEnterEmail.AutoSize = true;
            this.lblEnterEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterEmail.Location = new System.Drawing.Point(101, 91);
            this.lblEnterEmail.Name = "lblEnterEmail";
            this.lblEnterEmail.Size = new System.Drawing.Size(66, 30);
            this.lblEnterEmail.TabIndex = 8;
            this.lblEnterEmail.Text = "Email";
            // 
            // lblEnterCode
            // 
            this.lblEnterCode.AutoSize = true;
            this.lblEnterCode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCode.Location = new System.Drawing.Point(101, 195);
            this.lblEnterCode.Name = "lblEnterCode";
            this.lblEnterCode.Size = new System.Drawing.Size(120, 30);
            this.lblEnterCode.TabIndex = 9;
            this.lblEnterCode.Text = "Enter Code";
            // 
            // btnSendCode
            // 
            this.btnSendCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.Location = new System.Drawing.Point(471, 113);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(117, 40);
            this.btnSendCode.TabIndex = 10;
            this.btnSendCode.Text = "Send Code";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(101, 262);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(156, 30);
            this.lblNewPassword.TabIndex = 12;
            this.lblNewPassword.Text = "New Password";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Location = new System.Drawing.Point(106, 295);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(350, 23);
            this.tbxNewPassword.TabIndex = 11;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(471, 344);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 40);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(101, 322);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(191, 30);
            this.lblConfirmPassword.TabIndex = 15;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(106, 355);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(350, 23);
            this.tbxConfirmPassword.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(530, 484);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 536);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.lblEnterCode);
            this.Controls.Add(this.lblEnterEmail);
            this.Controls.Add(this.tbxEnterCode);
            this.Controls.Add(this.tbxEmail);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.frmForgotPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxEnterCode;
        private System.Windows.Forms.Label lblEnterEmail;
        private System.Windows.Forms.Label lblEnterCode;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Button btnCancel;
    }
}