namespace Team3MiddleSchool
{
    partial class frmGradebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGradebook));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalCap = new System.Windows.Forms.Label();
            this.lblTestCap = new System.Windows.Forms.Label();
            this.lblLabCap = new System.Windows.Forms.Label();
            this.lblQuizCap = new System.Windows.Forms.Label();
            this.lblHomeworkCap = new System.Windows.Forms.Label();
            this.lblParticipationCap = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblLab = new System.Windows.Forms.Label();
            this.lblQuiz = new System.Windows.Forms.Label();
            this.lblHomework = new System.Windows.Forms.Label();
            this.lblParticipation = new System.Windows.Forms.Label();
            this.lblNameCap = new System.Windows.Forms.Label();
            this.dgvGradeBook = new System.Windows.Forms.DataGridView();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblFinalCap = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMidtermGrades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeBook)).BeginInit();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAdd.Location = new System.Drawing.Point(706, 445);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 44);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEdit.Location = new System.Drawing.Point(585, 445);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 44);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRemove.Location = new System.Drawing.Point(465, 445);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(119, 44);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnNext.Location = new System.Drawing.Point(355, 445);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 44);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Ne&xt";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnPrev.Location = new System.Drawing.Point(243, 445);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(111, 44);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "Pr&evious";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnBack.Location = new System.Drawing.Point(18, 445);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 44);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "B&ack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotalCap
            // 
            this.lblTotalCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.lblTotalCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCap.CausesValidation = false;
            this.lblTotalCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalCap.Location = new System.Drawing.Point(681, 378);
            this.lblTotalCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCap.Name = "lblTotalCap";
            this.lblTotalCap.Size = new System.Drawing.Size(149, 35);
            this.lblTotalCap.TabIndex = 36;
            this.lblTotalCap.Text = "Total Grade";
            this.lblTotalCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTestCap
            // 
            this.lblTestCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.lblTestCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestCap.CausesValidation = false;
            this.lblTestCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTestCap.Location = new System.Drawing.Point(681, 286);
            this.lblTestCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestCap.Name = "lblTestCap";
            this.lblTestCap.Size = new System.Drawing.Size(149, 35);
            this.lblTestCap.TabIndex = 35;
            this.lblTestCap.Text = "Test";
            this.lblTestCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLabCap
            // 
            this.lblLabCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.lblLabCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLabCap.CausesValidation = false;
            this.lblLabCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabCap.Location = new System.Drawing.Point(680, 242);
            this.lblLabCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabCap.Name = "lblLabCap";
            this.lblLabCap.Size = new System.Drawing.Size(149, 35);
            this.lblLabCap.TabIndex = 34;
            this.lblLabCap.Text = "Lab";
            this.lblLabCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuizCap
            // 
            this.lblQuizCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.lblQuizCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuizCap.CausesValidation = false;
            this.lblQuizCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuizCap.Location = new System.Drawing.Point(681, 198);
            this.lblQuizCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuizCap.Name = "lblQuizCap";
            this.lblQuizCap.Size = new System.Drawing.Size(149, 35);
            this.lblQuizCap.TabIndex = 33;
            this.lblQuizCap.Text = "Quiz";
            this.lblQuizCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHomeworkCap
            // 
            this.lblHomeworkCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.lblHomeworkCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHomeworkCap.CausesValidation = false;
            this.lblHomeworkCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeworkCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHomeworkCap.Location = new System.Drawing.Point(681, 151);
            this.lblHomeworkCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeworkCap.Name = "lblHomeworkCap";
            this.lblHomeworkCap.Size = new System.Drawing.Size(149, 35);
            this.lblHomeworkCap.TabIndex = 32;
            this.lblHomeworkCap.Text = "Homework";
            this.lblHomeworkCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParticipationCap
            // 
            this.lblParticipationCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.lblParticipationCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblParticipationCap.CausesValidation = false;
            this.lblParticipationCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipationCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblParticipationCap.Location = new System.Drawing.Point(680, 109);
            this.lblParticipationCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParticipationCap.Name = "lblParticipationCap";
            this.lblParticipationCap.Size = new System.Drawing.Size(149, 35);
            this.lblParticipationCap.TabIndex = 31;
            this.lblParticipationCap.Text = "Class Participation";
            this.lblParticipationCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(501, 378);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(176, 35);
            this.lblTotal.TabIndex = 30;
            // 
            // lblTest
            // 
            this.lblTest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTest.Location = new System.Drawing.Point(572, 286);
            this.lblTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(104, 29);
            this.lblTest.TabIndex = 29;
            // 
            // lblLab
            // 
            this.lblLab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLab.Location = new System.Drawing.Point(571, 245);
            this.lblLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(104, 29);
            this.lblLab.TabIndex = 28;
            // 
            // lblQuiz
            // 
            this.lblQuiz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuiz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuiz.Location = new System.Drawing.Point(572, 201);
            this.lblQuiz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuiz.Name = "lblQuiz";
            this.lblQuiz.Size = new System.Drawing.Size(104, 29);
            this.lblQuiz.TabIndex = 27;
            // 
            // lblHomework
            // 
            this.lblHomework.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHomework.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHomework.Location = new System.Drawing.Point(572, 151);
            this.lblHomework.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomework.Name = "lblHomework";
            this.lblHomework.Size = new System.Drawing.Size(104, 29);
            this.lblHomework.TabIndex = 26;
            // 
            // lblParticipation
            // 
            this.lblParticipation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblParticipation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblParticipation.Location = new System.Drawing.Point(571, 109);
            this.lblParticipation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParticipation.Name = "lblParticipation";
            this.lblParticipation.Size = new System.Drawing.Size(104, 29);
            this.lblParticipation.TabIndex = 25;
            // 
            // lblNameCap
            // 
            this.lblNameCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.lblNameCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameCap.CausesValidation = false;
            this.lblNameCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNameCap.Location = new System.Drawing.Point(681, 59);
            this.lblNameCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameCap.Name = "lblNameCap";
            this.lblNameCap.Size = new System.Drawing.Size(149, 35);
            this.lblNameCap.TabIndex = 24;
            this.lblNameCap.Text = "Name";
            this.lblNameCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvGradeBook
            // 
            this.dgvGradeBook.AllowUserToDeleteRows = false;
            this.dgvGradeBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGradeBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGradeBook.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvGradeBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradeBook.Location = new System.Drawing.Point(11, 59);
            this.dgvGradeBook.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGradeBook.Name = "dgvGradeBook";
            this.dgvGradeBook.ReadOnly = true;
            this.dgvGradeBook.RowHeadersWidth = 62;
            this.dgvGradeBook.RowTemplate.Height = 28;
            this.dgvGradeBook.Size = new System.Drawing.Size(448, 375);
            this.dgvGradeBook.TabIndex = 0;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(500, 63);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(176, 23);
            this.tbxName.TabIndex = 44;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.SeaShell;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(13, 244);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 28);
            this.lblID.TabIndex = 45;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.Transparent;
            this.lblClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass.CausesValidation = false;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClass.Location = new System.Drawing.Point(12, 25);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(38, 22);
            this.lblClass.TabIndex = 46;
            this.lblClass.Text = "Null";
            // 
            // lblFinalCap
            // 
            this.lblFinalCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.lblFinalCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinalCap.CausesValidation = false;
            this.lblFinalCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinalCap.Location = new System.Drawing.Point(680, 332);
            this.lblFinalCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinalCap.Name = "lblFinalCap";
            this.lblFinalCap.Size = new System.Drawing.Size(149, 35);
            this.lblFinalCap.TabIndex = 48;
            this.lblFinalCap.Text = "Final";
            this.lblFinalCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinal
            // 
            this.lblFinal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinal.Location = new System.Drawing.Point(571, 332);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(104, 29);
            this.lblFinal.TabIndex = 47;
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(852, 24);
            this.mnuStrip.TabIndex = 49;
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
            // btnMidtermGrades
            // 
            this.btnMidtermGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnMidtermGrades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMidtermGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnMidtermGrades.Location = new System.Drawing.Point(131, 445);
            this.btnMidtermGrades.Margin = new System.Windows.Forms.Padding(2);
            this.btnMidtermGrades.Name = "btnMidtermGrades";
            this.btnMidtermGrades.Size = new System.Drawing.Size(111, 44);
            this.btnMidtermGrades.TabIndex = 2;
            this.btnMidtermGrades.Text = "&MidTerm Grades";
            this.btnMidtermGrades.UseVisualStyleBackColor = false;
            // 
            // frmGradebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Team3MiddleSchool.Properties.Resources.Logo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 503);
            this.ControlBox = false;
            this.Controls.Add(this.btnMidtermGrades);
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.lblFinalCap);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTotalCap);
            this.Controls.Add(this.lblTestCap);
            this.Controls.Add(this.lblLabCap);
            this.Controls.Add(this.lblQuizCap);
            this.Controls.Add(this.lblHomeworkCap);
            this.Controls.Add(this.lblParticipationCap);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.lblQuiz);
            this.Controls.Add(this.lblHomework);
            this.Controls.Add(this.lblParticipation);
            this.Controls.Add(this.lblNameCap);
            this.Controls.Add(this.dgvGradeBook);
            this.Controls.Add(this.lblID);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmGradebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gradebook";
            this.Load += new System.EventHandler(this.frmGradebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeBook)).EndInit();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalCap;
        private System.Windows.Forms.Label lblTestCap;
        private System.Windows.Forms.Label lblLabCap;
        private System.Windows.Forms.Label lblQuizCap;
        private System.Windows.Forms.Label lblHomeworkCap;
        private System.Windows.Forms.Label lblParticipationCap;
        private System.Windows.Forms.Label lblNameCap;
        private System.Windows.Forms.DataGridView dgvGradeBook;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblTest;
        public System.Windows.Forms.Label lblLab;
        public System.Windows.Forms.Label lblQuiz;
        public System.Windows.Forms.Label lblHomework;
        public System.Windows.Forms.Label lblParticipation;
        public System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblFinalCap;
        public System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.Button btnMidtermGrades;
    }
}