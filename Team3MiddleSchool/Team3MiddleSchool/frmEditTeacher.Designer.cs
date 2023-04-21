namespace Team3MiddleSchool
{
    partial class frmEditTeacher
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.gbxStudentContact = new System.Windows.Forms.GroupBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblNameWarning = new System.Windows.Forms.Label();
            this.lblPasswordWarning = new System.Windows.Forms.Label();
            this.lblUsernameWarning = new System.Windows.Forms.Label();
            this.lblEmailWarning = new System.Windows.Forms.Label();
            this.gbxLogin.SuspendLayout();
            this.gbxStudentContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(280, 291);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(34, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 40);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(157, 291);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(117, 40);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.lblPasswordWarning);
            this.gbxLogin.Controls.Add(this.tbxEmail);
            this.gbxLogin.Controls.Add(this.lblEmailWarning);
            this.gbxLogin.Controls.Add(this.lblUsernameWarning);
            this.gbxLogin.Controls.Add(this.tbxPassword);
            this.gbxLogin.Controls.Add(this.lblEmail);
            this.gbxLogin.Controls.Add(this.lblPassword);
            this.gbxLogin.Controls.Add(this.lblUsername);
            this.gbxLogin.Controls.Add(this.tbxUsername);
            this.gbxLogin.Location = new System.Drawing.Point(38, 129);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(354, 156);
            this.gbxLogin.TabIndex = 1;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Login Information";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(119, 22);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(218, 23);
            this.tbxEmail.TabIndex = 0;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(119, 108);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(218, 23);
            this.tbxPassword.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(7, 20);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 25);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(7, 106);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 25);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(7, 65);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 25);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Username";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(119, 65);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(218, 23);
            this.tbxUsername.TabIndex = 1;
            // 
            // gbxStudentContact
            // 
            this.gbxStudentContact.Controls.Add(this.lblNameWarning);
            this.gbxStudentContact.Controls.Add(this.tbxFirstName);
            this.gbxStudentContact.Controls.Add(this.lblFirstName);
            this.gbxStudentContact.Controls.Add(this.lblLastName);
            this.gbxStudentContact.Controls.Add(this.tbxLastName);
            this.gbxStudentContact.Location = new System.Drawing.Point(38, 14);
            this.gbxStudentContact.Name = "gbxStudentContact";
            this.gbxStudentContact.Size = new System.Drawing.Size(354, 99);
            this.gbxStudentContact.TabIndex = 0;
            this.gbxStudentContact.TabStop = false;
            this.gbxStudentContact.Text = "Contact Information";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(124, 22);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(218, 23);
            this.tbxFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(107, 25);
            this.lblFirstName.TabIndex = 25;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(12, 49);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(104, 25);
            this.lblLastName.TabIndex = 29;
            this.lblLastName.Text = "Last Name";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(124, 51);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(218, 23);
            this.tbxLastName.TabIndex = 1;
            // 
            // lblNameWarning
            // 
            this.lblNameWarning.AutoSize = true;
            this.lblNameWarning.BackColor = System.Drawing.Color.Red;
            this.lblNameWarning.ForeColor = System.Drawing.Color.Black;
            this.lblNameWarning.Location = new System.Drawing.Point(157, 77);
            this.lblNameWarning.Name = "lblNameWarning";
            this.lblNameWarning.Size = new System.Drawing.Size(127, 15);
            this.lblNameWarning.TabIndex = 33;
            this.lblNameWarning.Text = "Must Enter Valid Name";
            this.lblNameWarning.Visible = false;
            // 
            // lblPasswordWarning
            // 
            this.lblPasswordWarning.AutoSize = true;
            this.lblPasswordWarning.BackColor = System.Drawing.Color.Red;
            this.lblPasswordWarning.ForeColor = System.Drawing.Color.Black;
            this.lblPasswordWarning.Location = new System.Drawing.Point(157, 134);
            this.lblPasswordWarning.Name = "lblPasswordWarning";
            this.lblPasswordWarning.Size = new System.Drawing.Size(145, 15);
            this.lblPasswordWarning.TabIndex = 36;
            this.lblPasswordWarning.Text = "Must Enter Valid Password";
            this.lblPasswordWarning.Visible = false;
            // 
            // lblUsernameWarning
            // 
            this.lblUsernameWarning.AutoSize = true;
            this.lblUsernameWarning.BackColor = System.Drawing.Color.Red;
            this.lblUsernameWarning.ForeColor = System.Drawing.Color.Black;
            this.lblUsernameWarning.Location = new System.Drawing.Point(157, 91);
            this.lblUsernameWarning.Name = "lblUsernameWarning";
            this.lblUsernameWarning.Size = new System.Drawing.Size(148, 15);
            this.lblUsernameWarning.TabIndex = 35;
            this.lblUsernameWarning.Text = "Must Enter Valid Username";
            this.lblUsernameWarning.Visible = false;
            // 
            // lblEmailWarning
            // 
            this.lblEmailWarning.AutoSize = true;
            this.lblEmailWarning.BackColor = System.Drawing.Color.Red;
            this.lblEmailWarning.ForeColor = System.Drawing.Color.Black;
            this.lblEmailWarning.Location = new System.Drawing.Point(157, 48);
            this.lblEmailWarning.Name = "lblEmailWarning";
            this.lblEmailWarning.Size = new System.Drawing.Size(124, 15);
            this.lblEmailWarning.TabIndex = 34;
            this.lblEmailWarning.Text = "Must Enter Valid Email";
            this.lblEmailWarning.Visible = false;
            // 
            // frmEditTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 344);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxLogin);
            this.Controls.Add(this.gbxStudentContact);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEditTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Teacher";
            this.Load += new System.EventHandler(this.frmEditTeacher_Load);
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.gbxStudentContact.ResumeLayout(false);
            this.gbxStudentContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.GroupBox gbxStudentContact;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblEmailWarning;
        private System.Windows.Forms.Label lblUsernameWarning;
        private System.Windows.Forms.Label lblNameWarning;
        private System.Windows.Forms.Label lblPasswordWarning;
    }
}