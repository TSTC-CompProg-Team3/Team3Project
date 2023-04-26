namespace Team3MiddleSchool
{
    partial class frmEditStudent
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
            this.gbxAddress = new System.Windows.Forms.GroupBox();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.lblZipWarning = new System.Windows.Forms.Label();
            this.lblCityWarning = new System.Windows.Forms.Label();
            this.lblAddressWarning = new System.Windows.Forms.Label();
            this.tbxMailingAddress = new System.Windows.Forms.TextBox();
            this.lblMailingAddress = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.tbxStreetAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxZip = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.lblPasswordWarning = new System.Windows.Forms.Label();
            this.lblUsernameWarning = new System.Windows.Forms.Label();
            this.lblEmailWarning = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.gbxStudentContact = new System.Windows.Forms.GroupBox();
            this.lblPhoneNumberWarning1 = new System.Windows.Forms.Label();
            this.lblNameWarning1 = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.gbxEmergencyContact = new System.Windows.Forms.GroupBox();
            this.lblWorkplaceWarning = new System.Windows.Forms.Label();
            this.lblNameWarning3 = new System.Windows.Forms.Label();
            this.lblNameWarning2 = new System.Windows.Forms.Label();
            this.lblPhoneNumberWarning4 = new System.Windows.Forms.Label();
            this.lblPhoneNumberWarning3 = new System.Windows.Forms.Label();
            this.lblPhoneNumberWarning2 = new System.Windows.Forms.Label();
            this.lblEmerContactName = new System.Windows.Forms.Label();
            this.tbxGuardianWorkPl = new System.Windows.Forms.TextBox();
            this.lblEmerContactPhone = new System.Windows.Forms.Label();
            this.tbxGuardianWork = new System.Windows.Forms.TextBox();
            this.lblGuardianWorkPl = new System.Windows.Forms.Label();
            this.tbxGuardianCell = new System.Windows.Forms.TextBox();
            this.lblGuardianName = new System.Windows.Forms.Label();
            this.tbxGuardianName = new System.Windows.Forms.TextBox();
            this.lblGuardianCell = new System.Windows.Forms.Label();
            this.tbxEmerContactPhone = new System.Windows.Forms.TextBox();
            this.lblGuardianWork = new System.Windows.Forms.Label();
            this.tbxEmerContactName = new System.Windows.Forms.TextBox();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxAddress.SuspendLayout();
            this.gbxLogin.SuspendLayout();
            this.gbxStudentContact.SuspendLayout();
            this.gbxEmergencyContact.SuspendLayout();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAddress
            // 
            this.gbxAddress.Controls.Add(this.cbxState);
            this.gbxAddress.Controls.Add(this.lblZipWarning);
            this.gbxAddress.Controls.Add(this.lblCityWarning);
            this.gbxAddress.Controls.Add(this.lblAddressWarning);
            this.gbxAddress.Controls.Add(this.tbxMailingAddress);
            this.gbxAddress.Controls.Add(this.lblMailingAddress);
            this.gbxAddress.Controls.Add(this.lblStreetAddress);
            this.gbxAddress.Controls.Add(this.tbxStreetAddress);
            this.gbxAddress.Controls.Add(this.lblCity);
            this.gbxAddress.Controls.Add(this.lblState);
            this.gbxAddress.Controls.Add(this.lblZip);
            this.gbxAddress.Controls.Add(this.tbxCity);
            this.gbxAddress.Controls.Add(this.tbxZip);
            this.gbxAddress.Location = new System.Drawing.Point(16, 257);
            this.gbxAddress.Name = "gbxAddress";
            this.gbxAddress.Size = new System.Drawing.Size(354, 232);
            this.gbxAddress.TabIndex = 2;
            this.gbxAddress.TabStop = false;
            this.gbxAddress.Text = "Address";
            // 
            // cbxState
            // 
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "AS",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "GU",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NC",
            "ND",
            "MP",
            "OH",
            "OK",
            "OR",
            "PA",
            "PR",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "TT",
            "UT",
            "VT",
            "VA",
            "VI",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cbxState.Location = new System.Drawing.Point(185, 150);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(157, 23);
            this.cbxState.TabIndex = 3;
            // 
            // lblZipWarning
            // 
            this.lblZipWarning.AutoSize = true;
            this.lblZipWarning.BackColor = System.Drawing.Color.Red;
            this.lblZipWarning.ForeColor = System.Drawing.Color.Black;
            this.lblZipWarning.Location = new System.Drawing.Point(197, 212);
            this.lblZipWarning.Name = "lblZipWarning";
            this.lblZipWarning.Size = new System.Drawing.Size(112, 15);
            this.lblZipWarning.TabIndex = 61;
            this.lblZipWarning.Text = "Must Enter Valid Zip";
            this.lblZipWarning.Visible = false;
            // 
            // lblCityWarning
            // 
            this.lblCityWarning.AutoSize = true;
            this.lblCityWarning.BackColor = System.Drawing.Color.Red;
            this.lblCityWarning.ForeColor = System.Drawing.Color.Black;
            this.lblCityWarning.Location = new System.Drawing.Point(197, 126);
            this.lblCityWarning.Name = "lblCityWarning";
            this.lblCityWarning.Size = new System.Drawing.Size(116, 15);
            this.lblCityWarning.TabIndex = 60;
            this.lblCityWarning.Text = "Must Enter Valid City";
            this.lblCityWarning.Visible = false;
            // 
            // lblAddressWarning
            // 
            this.lblAddressWarning.AutoSize = true;
            this.lblAddressWarning.BackColor = System.Drawing.Color.Red;
            this.lblAddressWarning.ForeColor = System.Drawing.Color.Black;
            this.lblAddressWarning.Location = new System.Drawing.Point(197, 76);
            this.lblAddressWarning.Name = "lblAddressWarning";
            this.lblAddressWarning.Size = new System.Drawing.Size(137, 15);
            this.lblAddressWarning.TabIndex = 59;
            this.lblAddressWarning.Text = "Must Enter Valid Address";
            this.lblAddressWarning.Visible = false;
            // 
            // tbxMailingAddress
            // 
            this.tbxMailingAddress.Location = new System.Drawing.Point(185, 22);
            this.tbxMailingAddress.Name = "tbxMailingAddress";
            this.tbxMailingAddress.Size = new System.Drawing.Size(157, 23);
            this.tbxMailingAddress.TabIndex = 0;
            // 
            // lblMailingAddress
            // 
            this.lblMailingAddress.AutoSize = true;
            this.lblMailingAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailingAddress.Location = new System.Drawing.Point(12, 20);
            this.lblMailingAddress.Name = "lblMailingAddress";
            this.lblMailingAddress.Size = new System.Drawing.Size(155, 25);
            this.lblMailingAddress.TabIndex = 33;
            this.lblMailingAddress.Text = "Mailing Address";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.Location = new System.Drawing.Point(12, 50);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(141, 25);
            this.lblStreetAddress.TabIndex = 35;
            this.lblStreetAddress.Text = "Street Address";
            // 
            // tbxStreetAddress
            // 
            this.tbxStreetAddress.Location = new System.Drawing.Point(185, 50);
            this.tbxStreetAddress.Name = "tbxStreetAddress";
            this.tbxStreetAddress.Size = new System.Drawing.Size(157, 23);
            this.tbxStreetAddress.TabIndex = 1;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(12, 98);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 25);
            this.lblCity.TabIndex = 37;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(12, 145);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(57, 25);
            this.lblState.TabIndex = 39;
            this.lblState.Text = "State";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(12, 184);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(41, 25);
            this.lblZip.TabIndex = 41;
            this.lblZip.Text = "Zip";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(185, 100);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(157, 23);
            this.tbxCity.TabIndex = 2;
            this.tbxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCity_KeyPress);
            // 
            // tbxZip
            // 
            this.tbxZip.Location = new System.Drawing.Point(185, 186);
            this.tbxZip.Name = "tbxZip";
            this.tbxZip.Size = new System.Drawing.Size(157, 23);
            this.tbxZip.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(548, 495);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 40);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(216, 495);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(383, 495);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(117, 40);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.lblPasswordWarning);
            this.gbxLogin.Controls.Add(this.lblUsernameWarning);
            this.gbxLogin.Controls.Add(this.lblEmailWarning);
            this.gbxLogin.Controls.Add(this.tbxEmail);
            this.gbxLogin.Controls.Add(this.tbxPassword);
            this.gbxLogin.Controls.Add(this.lblEmail);
            this.gbxLogin.Controls.Add(this.lblPassword);
            this.gbxLogin.Controls.Add(this.lblUsername);
            this.gbxLogin.Controls.Add(this.tbxUsername);
            this.gbxLogin.Location = new System.Drawing.Point(385, 25);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(354, 162);
            this.gbxLogin.TabIndex = 1;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Login Information";
            // 
            // lblPasswordWarning
            // 
            this.lblPasswordWarning.AutoSize = true;
            this.lblPasswordWarning.BackColor = System.Drawing.Color.Red;
            this.lblPasswordWarning.ForeColor = System.Drawing.Color.Black;
            this.lblPasswordWarning.Location = new System.Drawing.Point(194, 142);
            this.lblPasswordWarning.Name = "lblPasswordWarning";
            this.lblPasswordWarning.Size = new System.Drawing.Size(145, 15);
            this.lblPasswordWarning.TabIndex = 37;
            this.lblPasswordWarning.Text = "Must Enter Valid Password";
            this.lblPasswordWarning.Visible = false;
            // 
            // lblUsernameWarning
            // 
            this.lblUsernameWarning.AutoSize = true;
            this.lblUsernameWarning.BackColor = System.Drawing.Color.Red;
            this.lblUsernameWarning.ForeColor = System.Drawing.Color.Black;
            this.lblUsernameWarning.Location = new System.Drawing.Point(194, 95);
            this.lblUsernameWarning.Name = "lblUsernameWarning";
            this.lblUsernameWarning.Size = new System.Drawing.Size(148, 15);
            this.lblUsernameWarning.TabIndex = 36;
            this.lblUsernameWarning.Text = "Must Enter Valid Username";
            this.lblUsernameWarning.Visible = false;
            // 
            // lblEmailWarning
            // 
            this.lblEmailWarning.AutoSize = true;
            this.lblEmailWarning.BackColor = System.Drawing.Color.Red;
            this.lblEmailWarning.ForeColor = System.Drawing.Color.Black;
            this.lblEmailWarning.Location = new System.Drawing.Point(194, 48);
            this.lblEmailWarning.Name = "lblEmailWarning";
            this.lblEmailWarning.Size = new System.Drawing.Size(124, 15);
            this.lblEmailWarning.TabIndex = 35;
            this.lblEmailWarning.Text = "Must Enter Valid Email";
            this.lblEmailWarning.Visible = false;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(180, 22);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(157, 23);
            this.tbxEmail.TabIndex = 0;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(180, 116);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(157, 23);
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
            this.lblPassword.Location = new System.Drawing.Point(7, 114);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 25);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(7, 69);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 25);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Username";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(180, 69);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(157, 23);
            this.tbxUsername.TabIndex = 1;
            // 
            // gbxStudentContact
            // 
            this.gbxStudentContact.Controls.Add(this.lblPhoneNumberWarning1);
            this.gbxStudentContact.Controls.Add(this.lblNameWarning1);
            this.gbxStudentContact.Controls.Add(this.tbxFirstName);
            this.gbxStudentContact.Controls.Add(this.lblFirstName);
            this.gbxStudentContact.Controls.Add(this.lblMiddleName);
            this.gbxStudentContact.Controls.Add(this.tbxMiddleName);
            this.gbxStudentContact.Controls.Add(this.lblLastName);
            this.gbxStudentContact.Controls.Add(this.tbxLastName);
            this.gbxStudentContact.Controls.Add(this.dtpDateOfBirth);
            this.gbxStudentContact.Controls.Add(this.lblDateOfBirth);
            this.gbxStudentContact.Controls.Add(this.lblPhoneNumber);
            this.gbxStudentContact.Controls.Add(this.tbxPhoneNumber);
            this.gbxStudentContact.Location = new System.Drawing.Point(16, 25);
            this.gbxStudentContact.Name = "gbxStudentContact";
            this.gbxStudentContact.Size = new System.Drawing.Size(354, 226);
            this.gbxStudentContact.TabIndex = 0;
            this.gbxStudentContact.TabStop = false;
            this.gbxStudentContact.Text = "Contact Information";
            // 
            // lblPhoneNumberWarning1
            // 
            this.lblPhoneNumberWarning1.AutoSize = true;
            this.lblPhoneNumberWarning1.BackColor = System.Drawing.Color.Red;
            this.lblPhoneNumberWarning1.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumberWarning1.Location = new System.Drawing.Point(197, 204);
            this.lblPhoneNumberWarning1.Name = "lblPhoneNumberWarning1";
            this.lblPhoneNumberWarning1.Size = new System.Drawing.Size(129, 15);
            this.lblPhoneNumberWarning1.TabIndex = 45;
            this.lblPhoneNumberWarning1.Text = "Must Enter Valid Phone";
            this.lblPhoneNumberWarning1.Visible = false;
            // 
            // lblNameWarning1
            // 
            this.lblNameWarning1.AutoSize = true;
            this.lblNameWarning1.BackColor = System.Drawing.Color.Red;
            this.lblNameWarning1.ForeColor = System.Drawing.Color.Black;
            this.lblNameWarning1.Location = new System.Drawing.Point(197, 107);
            this.lblNameWarning1.Name = "lblNameWarning1";
            this.lblNameWarning1.Size = new System.Drawing.Size(127, 15);
            this.lblNameWarning1.TabIndex = 44;
            this.lblNameWarning1.Text = "Must Enter Valid Name";
            this.lblNameWarning1.Visible = false;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(185, 22);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(157, 23);
            this.tbxFirstName.TabIndex = 0;
            this.tbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFirstName_KeyPress);
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
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(12, 50);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(131, 25);
            this.lblMiddleName.TabIndex = 27;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Location = new System.Drawing.Point(185, 52);
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(157, 23);
            this.tbxMiddleName.TabIndex = 1;
            this.tbxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMiddleName_KeyPress);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(12, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(104, 25);
            this.lblLastName.TabIndex = 29;
            this.lblLastName.Text = "Last Name";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(185, 81);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(157, 23);
            this.tbxLastName.TabIndex = 2;
            this.tbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastName_KeyPress);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(185, 139);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(157, 23);
            this.dtpDateOfBirth.TabIndex = 3;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(12, 137);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(128, 25);
            this.lblDateOfBirth.TabIndex = 31;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 176);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(148, 25);
            this.lblPhoneNumber.TabIndex = 43;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(185, 178);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(157, 23);
            this.tbxPhoneNumber.TabIndex = 4;
            // 
            // gbxEmergencyContact
            // 
            this.gbxEmergencyContact.Controls.Add(this.lblWorkplaceWarning);
            this.gbxEmergencyContact.Controls.Add(this.lblNameWarning3);
            this.gbxEmergencyContact.Controls.Add(this.lblNameWarning2);
            this.gbxEmergencyContact.Controls.Add(this.lblPhoneNumberWarning4);
            this.gbxEmergencyContact.Controls.Add(this.lblPhoneNumberWarning3);
            this.gbxEmergencyContact.Controls.Add(this.lblPhoneNumberWarning2);
            this.gbxEmergencyContact.Controls.Add(this.lblEmerContactName);
            this.gbxEmergencyContact.Controls.Add(this.tbxGuardianWorkPl);
            this.gbxEmergencyContact.Controls.Add(this.lblEmerContactPhone);
            this.gbxEmergencyContact.Controls.Add(this.tbxGuardianWork);
            this.gbxEmergencyContact.Controls.Add(this.lblGuardianWorkPl);
            this.gbxEmergencyContact.Controls.Add(this.tbxGuardianCell);
            this.gbxEmergencyContact.Controls.Add(this.lblGuardianName);
            this.gbxEmergencyContact.Controls.Add(this.tbxGuardianName);
            this.gbxEmergencyContact.Controls.Add(this.lblGuardianCell);
            this.gbxEmergencyContact.Controls.Add(this.tbxEmerContactPhone);
            this.gbxEmergencyContact.Controls.Add(this.lblGuardianWork);
            this.gbxEmergencyContact.Controls.Add(this.tbxEmerContactName);
            this.gbxEmergencyContact.Location = new System.Drawing.Point(385, 193);
            this.gbxEmergencyContact.Name = "gbxEmergencyContact";
            this.gbxEmergencyContact.Size = new System.Drawing.Size(483, 296);
            this.gbxEmergencyContact.TabIndex = 3;
            this.gbxEmergencyContact.TabStop = false;
            this.gbxEmergencyContact.Text = "Emergency Contact Information";
            // 
            // lblWorkplaceWarning
            // 
            this.lblWorkplaceWarning.AutoSize = true;
            this.lblWorkplaceWarning.BackColor = System.Drawing.Color.Red;
            this.lblWorkplaceWarning.ForeColor = System.Drawing.Color.Black;
            this.lblWorkplaceWarning.Location = new System.Drawing.Point(314, 278);
            this.lblWorkplaceWarning.Name = "lblWorkplaceWarning";
            this.lblWorkplaceWarning.Size = new System.Drawing.Size(151, 15);
            this.lblWorkplaceWarning.TabIndex = 65;
            this.lblWorkplaceWarning.Text = "Must Enter Valid Workplace";
            this.lblWorkplaceWarning.Visible = false;
            // 
            // lblNameWarning3
            // 
            this.lblNameWarning3.AutoSize = true;
            this.lblNameWarning3.BackColor = System.Drawing.Color.Red;
            this.lblNameWarning3.ForeColor = System.Drawing.Color.Black;
            this.lblNameWarning3.Location = new System.Drawing.Point(314, 140);
            this.lblNameWarning3.Name = "lblNameWarning3";
            this.lblNameWarning3.Size = new System.Drawing.Size(127, 15);
            this.lblNameWarning3.TabIndex = 64;
            this.lblNameWarning3.Text = "Must Enter Valid Name";
            this.lblNameWarning3.Visible = false;
            // 
            // lblNameWarning2
            // 
            this.lblNameWarning2.AutoSize = true;
            this.lblNameWarning2.BackColor = System.Drawing.Color.Red;
            this.lblNameWarning2.ForeColor = System.Drawing.Color.Black;
            this.lblNameWarning2.Location = new System.Drawing.Point(312, 48);
            this.lblNameWarning2.Name = "lblNameWarning2";
            this.lblNameWarning2.Size = new System.Drawing.Size(127, 15);
            this.lblNameWarning2.TabIndex = 60;
            this.lblNameWarning2.Text = "Must Enter Valid Name";
            this.lblNameWarning2.Visible = false;
            // 
            // lblPhoneNumberWarning4
            // 
            this.lblPhoneNumberWarning4.AutoSize = true;
            this.lblPhoneNumberWarning4.BackColor = System.Drawing.Color.Red;
            this.lblPhoneNumberWarning4.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumberWarning4.Location = new System.Drawing.Point(312, 232);
            this.lblPhoneNumberWarning4.Name = "lblPhoneNumberWarning4";
            this.lblPhoneNumberWarning4.Size = new System.Drawing.Size(129, 15);
            this.lblPhoneNumberWarning4.TabIndex = 63;
            this.lblPhoneNumberWarning4.Text = "Must Enter Valid Phone";
            this.lblPhoneNumberWarning4.Visible = false;
            // 
            // lblPhoneNumberWarning3
            // 
            this.lblPhoneNumberWarning3.AutoSize = true;
            this.lblPhoneNumberWarning3.BackColor = System.Drawing.Color.Red;
            this.lblPhoneNumberWarning3.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumberWarning3.Location = new System.Drawing.Point(312, 186);
            this.lblPhoneNumberWarning3.Name = "lblPhoneNumberWarning3";
            this.lblPhoneNumberWarning3.Size = new System.Drawing.Size(129, 15);
            this.lblPhoneNumberWarning3.TabIndex = 62;
            this.lblPhoneNumberWarning3.Text = "Must Enter Valid Phone";
            this.lblPhoneNumberWarning3.Visible = false;
            // 
            // lblPhoneNumberWarning2
            // 
            this.lblPhoneNumberWarning2.AutoSize = true;
            this.lblPhoneNumberWarning2.BackColor = System.Drawing.Color.Red;
            this.lblPhoneNumberWarning2.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumberWarning2.Location = new System.Drawing.Point(312, 94);
            this.lblPhoneNumberWarning2.Name = "lblPhoneNumberWarning2";
            this.lblPhoneNumberWarning2.Size = new System.Drawing.Size(129, 15);
            this.lblPhoneNumberWarning2.TabIndex = 61;
            this.lblPhoneNumberWarning2.Text = "Must Enter Valid Phone";
            this.lblPhoneNumberWarning2.Visible = false;
            // 
            // lblEmerContactName
            // 
            this.lblEmerContactName.AutoSize = true;
            this.lblEmerContactName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmerContactName.Location = new System.Drawing.Point(17, 20);
            this.lblEmerContactName.Name = "lblEmerContactName";
            this.lblEmerContactName.Size = new System.Drawing.Size(241, 25);
            this.lblEmerContactName.TabIndex = 45;
            this.lblEmerContactName.Text = "Emergency Contact Name";
            // 
            // tbxGuardianWorkPl
            // 
            this.tbxGuardianWorkPl.Location = new System.Drawing.Point(298, 252);
            this.tbxGuardianWorkPl.Name = "tbxGuardianWorkPl";
            this.tbxGuardianWorkPl.Size = new System.Drawing.Size(157, 23);
            this.tbxGuardianWorkPl.TabIndex = 5;
            this.tbxGuardianWorkPl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGuardianWorkPl_KeyPress);
            // 
            // lblEmerContactPhone
            // 
            this.lblEmerContactPhone.AutoSize = true;
            this.lblEmerContactPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmerContactPhone.Location = new System.Drawing.Point(17, 66);
            this.lblEmerContactPhone.Name = "lblEmerContactPhone";
            this.lblEmerContactPhone.Size = new System.Drawing.Size(246, 25);
            this.lblEmerContactPhone.TabIndex = 47;
            this.lblEmerContactPhone.Text = "Emergency Contact Phone";
            // 
            // tbxGuardianWork
            // 
            this.tbxGuardianWork.Location = new System.Drawing.Point(298, 206);
            this.tbxGuardianWork.Name = "tbxGuardianWork";
            this.tbxGuardianWork.Size = new System.Drawing.Size(157, 23);
            this.tbxGuardianWork.TabIndex = 4;
            // 
            // lblGuardianWorkPl
            // 
            this.lblGuardianWorkPl.AutoSize = true;
            this.lblGuardianWorkPl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianWorkPl.Location = new System.Drawing.Point(17, 250);
            this.lblGuardianWorkPl.Name = "lblGuardianWorkPl";
            this.lblGuardianWorkPl.Size = new System.Drawing.Size(200, 25);
            this.lblGuardianWorkPl.TabIndex = 55;
            this.lblGuardianWorkPl.Text = "Guardian Work Place";
            // 
            // tbxGuardianCell
            // 
            this.tbxGuardianCell.Location = new System.Drawing.Point(298, 160);
            this.tbxGuardianCell.Name = "tbxGuardianCell";
            this.tbxGuardianCell.Size = new System.Drawing.Size(157, 23);
            this.tbxGuardianCell.TabIndex = 3;
            // 
            // lblGuardianName
            // 
            this.lblGuardianName.AutoSize = true;
            this.lblGuardianName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianName.Location = new System.Drawing.Point(17, 112);
            this.lblGuardianName.Name = "lblGuardianName";
            this.lblGuardianName.Size = new System.Drawing.Size(152, 25);
            this.lblGuardianName.TabIndex = 49;
            this.lblGuardianName.Text = "Guardian Name";
            // 
            // tbxGuardianName
            // 
            this.tbxGuardianName.Location = new System.Drawing.Point(298, 114);
            this.tbxGuardianName.Name = "tbxGuardianName";
            this.tbxGuardianName.Size = new System.Drawing.Size(157, 23);
            this.tbxGuardianName.TabIndex = 2;
            this.tbxGuardianName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGuardianName_KeyPress);
            // 
            // lblGuardianCell
            // 
            this.lblGuardianCell.AutoSize = true;
            this.lblGuardianCell.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianCell.Location = new System.Drawing.Point(17, 158);
            this.lblGuardianCell.Name = "lblGuardianCell";
            this.lblGuardianCell.Size = new System.Drawing.Size(194, 25);
            this.lblGuardianCell.TabIndex = 51;
            this.lblGuardianCell.Text = "Guardian Cell Phone";
            // 
            // tbxEmerContactPhone
            // 
            this.tbxEmerContactPhone.Location = new System.Drawing.Point(298, 68);
            this.tbxEmerContactPhone.Name = "tbxEmerContactPhone";
            this.tbxEmerContactPhone.Size = new System.Drawing.Size(157, 23);
            this.tbxEmerContactPhone.TabIndex = 1;
            // 
            // lblGuardianWork
            // 
            this.lblGuardianWork.AutoSize = true;
            this.lblGuardianWork.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianWork.Location = new System.Drawing.Point(17, 204);
            this.lblGuardianWork.Name = "lblGuardianWork";
            this.lblGuardianWork.Size = new System.Drawing.Size(211, 25);
            this.lblGuardianWork.TabIndex = 53;
            this.lblGuardianWork.Text = "Guardian Work Phone";
            // 
            // tbxEmerContactName
            // 
            this.tbxEmerContactName.Location = new System.Drawing.Point(298, 22);
            this.tbxEmerContactName.Name = "tbxEmerContactName";
            this.tbxEmerContactName.Size = new System.Drawing.Size(157, 23);
            this.tbxEmerContactName.TabIndex = 0;
            this.tbxEmerContactName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEmerContactName_KeyPress);
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(884, 24);
            this.mnuStrip.TabIndex = 8;
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
            // frmEditStudent
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ControlBox = false;
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.gbxAddress);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxLogin);
            this.Controls.Add(this.gbxStudentContact);
            this.Controls.Add(this.gbxEmergencyContact);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Student";
            this.Load += new System.EventHandler(this.frmEditStudent_Load);
            this.gbxAddress.ResumeLayout(false);
            this.gbxAddress.PerformLayout();
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.gbxStudentContact.ResumeLayout(false);
            this.gbxStudentContact.PerformLayout();
            this.gbxEmergencyContact.ResumeLayout(false);
            this.gbxEmergencyContact.PerformLayout();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAddress;
        private System.Windows.Forms.TextBox tbxMailingAddress;
        private System.Windows.Forms.Label lblMailingAddress;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox tbxStreetAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxZip;
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
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.GroupBox gbxEmergencyContact;
        private System.Windows.Forms.TextBox tbxGuardianWorkPl;
        private System.Windows.Forms.Label lblNameWarning1;
        private System.Windows.Forms.Label lblPhoneNumberWarning1;
        private System.Windows.Forms.Label lblAddressWarning;
        private System.Windows.Forms.Label lblCityWarning;
        private System.Windows.Forms.Label lblZipWarning;
        private System.Windows.Forms.Label lblEmailWarning;
        private System.Windows.Forms.Label lblUsernameWarning;
        private System.Windows.Forms.Label lblPasswordWarning;
        private System.Windows.Forms.Label lblWorkplaceWarning;
        private System.Windows.Forms.Label lblNameWarning3;
        private System.Windows.Forms.Label lblNameWarning2;
        private System.Windows.Forms.Label lblPhoneNumberWarning4;
        private System.Windows.Forms.Label lblPhoneNumberWarning3;
        private System.Windows.Forms.Label lblPhoneNumberWarning2;
        private System.Windows.Forms.Label lblEmerContactName;
        private System.Windows.Forms.Label lblEmerContactPhone;
        private System.Windows.Forms.TextBox tbxGuardianWork;
        private System.Windows.Forms.Label lblGuardianWorkPl;
        private System.Windows.Forms.TextBox tbxGuardianCell;
        private System.Windows.Forms.Label lblGuardianName;
        private System.Windows.Forms.TextBox tbxGuardianName;
        private System.Windows.Forms.Label lblGuardianCell;
        private System.Windows.Forms.TextBox tbxEmerContactPhone;
        private System.Windows.Forms.Label lblGuardianWork;
        private System.Windows.Forms.TextBox tbxEmerContactName;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
    }
}