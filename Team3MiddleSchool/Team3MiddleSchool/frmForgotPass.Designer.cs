namespace Team3MiddleSchool
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
            this.lblEmailWarning = new System.Windows.Forms.Label();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(106, 124);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(350, 23);
            this.tbxEmail.TabIndex = 0;
            // 
            // tbxEnterCode
            // 
            this.tbxEnterCode.Location = new System.Drawing.Point(106, 228);
            this.tbxEnterCode.Name = "tbxEnterCode";
            this.tbxEnterCode.Size = new System.Drawing.Size(350, 23);
            this.tbxEnterCode.TabIndex = 2;
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
            this.btnSendCode.TabIndex = 1;
            this.btnSendCode.Text = "&Send Code";
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
            this.tbxNewPassword.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(471, 344);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 40);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Co&nfirm";
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
            this.tbxConfirmPassword.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(530, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEmailWarning
            // 
            this.lblEmailWarning.AutoSize = true;
            this.lblEmailWarning.BackColor = System.Drawing.Color.Red;
            this.lblEmailWarning.ForeColor = System.Drawing.Color.Black;
            this.lblEmailWarning.Location = new System.Drawing.Point(112, 150);
            this.lblEmailWarning.Name = "lblEmailWarning";
            this.lblEmailWarning.Size = new System.Drawing.Size(180, 15);
            this.lblEmailWarning.TabIndex = 33;
            this.lblEmailWarning.Text = "No user was found for that email";
            this.lblEmailWarning.Visible = false;
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(659, 24);
            this.mnuStrip.TabIndex = 34;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userManualToolStripMenuItem.Text = "&User Manual";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.userManualToolStripMenuItem_Click);
            // 
            // frmForgotPass
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 536);
            this.ControlBox = false;
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.lblEmailWarning);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmForgotPass_FormClosing);
            this.Load += new System.EventHandler(this.frmForgotPass_Load);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
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
        private System.Windows.Forms.Label lblEmailWarning;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
    }
}