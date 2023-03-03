namespace DatabaseConnection_G3_sp23
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
            this.btnMidterm = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAdd.Location = new System.Drawing.Point(654, 354);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 44);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEdit.Location = new System.Drawing.Point(549, 354);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 44);
            this.btnEdit.TabIndex = 42;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRemove.Location = new System.Drawing.Point(447, 353);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 44);
            this.btnRemove.TabIndex = 41;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnNext.Location = new System.Drawing.Point(342, 354);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 44);
            this.btnNext.TabIndex = 40;
            this.btnNext.Text = "Ne&xt";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnPrev.Location = new System.Drawing.Point(237, 354);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(100, 44);
            this.btnPrev.TabIndex = 39;
            this.btnPrev.Text = "Pr&evious";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnMidterm
            // 
            this.btnMidterm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnMidterm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMidterm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnMidterm.Location = new System.Drawing.Point(132, 354);
            this.btnMidterm.Margin = new System.Windows.Forms.Padding(2);
            this.btnMidterm.Name = "btnMidterm";
            this.btnMidterm.Size = new System.Drawing.Size(100, 44);
            this.btnMidterm.TabIndex = 38;
            this.btnMidterm.Text = "Midterm &Grades";
            this.btnMidterm.UseVisualStyleBackColor = false;
            this.btnMidterm.Click += new System.EventHandler(this.btnMidterm_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(80)))), ((int)(((byte)(37)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnBack.Location = new System.Drawing.Point(27, 354);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 44);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "B&ack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotalCap
            // 
            this.lblTotalCap.BackColor = System.Drawing.Color.SeaShell;
            this.lblTotalCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCap.Location = new System.Drawing.Point(536, 292);
            this.lblTotalCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCap.Name = "lblTotalCap";
            this.lblTotalCap.Size = new System.Drawing.Size(102, 40);
            this.lblTotalCap.TabIndex = 36;
            this.lblTotalCap.Text = "Total Grade";
            this.lblTotalCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTestCap
            // 
            this.lblTestCap.BackColor = System.Drawing.Color.SeaShell;
            this.lblTestCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestCap.Location = new System.Drawing.Point(616, 246);
            this.lblTestCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestCap.Name = "lblTestCap";
            this.lblTestCap.Size = new System.Drawing.Size(57, 28);
            this.lblTestCap.TabIndex = 35;
            this.lblTestCap.Text = "Test";
            this.lblTestCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLabCap
            // 
            this.lblLabCap.BackColor = System.Drawing.Color.SeaShell;
            this.lblLabCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabCap.Location = new System.Drawing.Point(616, 207);
            this.lblLabCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabCap.Name = "lblLabCap";
            this.lblLabCap.Size = new System.Drawing.Size(57, 28);
            this.lblLabCap.TabIndex = 34;
            this.lblLabCap.Text = "Lab";
            this.lblLabCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuizCap
            // 
            this.lblQuizCap.BackColor = System.Drawing.Color.SeaShell;
            this.lblQuizCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizCap.Location = new System.Drawing.Point(616, 165);
            this.lblQuizCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuizCap.Name = "lblQuizCap";
            this.lblQuizCap.Size = new System.Drawing.Size(57, 28);
            this.lblQuizCap.TabIndex = 33;
            this.lblQuizCap.Text = "Quiz";
            this.lblQuizCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHomeworkCap
            // 
            this.lblHomeworkCap.BackColor = System.Drawing.Color.SeaShell;
            this.lblHomeworkCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeworkCap.Location = new System.Drawing.Point(583, 120);
            this.lblHomeworkCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeworkCap.Name = "lblHomeworkCap";
            this.lblHomeworkCap.Size = new System.Drawing.Size(89, 28);
            this.lblHomeworkCap.TabIndex = 32;
            this.lblHomeworkCap.Text = "Homework";
            this.lblHomeworkCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParticipationCap
            // 
            this.lblParticipationCap.BackColor = System.Drawing.Color.SeaShell;
            this.lblParticipationCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipationCap.Location = new System.Drawing.Point(574, 62);
            this.lblParticipationCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParticipationCap.Name = "lblParticipationCap";
            this.lblParticipationCap.Size = new System.Drawing.Size(100, 42);
            this.lblParticipationCap.TabIndex = 31;
            this.lblParticipationCap.Text = "Class Participation";
            this.lblParticipationCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(642, 292);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(138, 41);
            this.lblTotal.TabIndex = 30;
            // 
            // lblTest
            // 
            this.lblTest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTest.Location = new System.Drawing.Point(677, 246);
            this.lblTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(104, 29);
            this.lblTest.TabIndex = 29;
            // 
            // lblLab
            // 
            this.lblLab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLab.Location = new System.Drawing.Point(677, 207);
            this.lblLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(104, 29);
            this.lblLab.TabIndex = 28;
            // 
            // lblQuiz
            // 
            this.lblQuiz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuiz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuiz.Location = new System.Drawing.Point(677, 165);
            this.lblQuiz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuiz.Name = "lblQuiz";
            this.lblQuiz.Size = new System.Drawing.Size(104, 29);
            this.lblQuiz.TabIndex = 27;
            // 
            // lblHomework
            // 
            this.lblHomework.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHomework.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHomework.Location = new System.Drawing.Point(677, 120);
            this.lblHomework.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomework.Name = "lblHomework";
            this.lblHomework.Size = new System.Drawing.Size(104, 29);
            this.lblHomework.TabIndex = 26;
            // 
            // lblParticipation
            // 
            this.lblParticipation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblParticipation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblParticipation.Location = new System.Drawing.Point(677, 68);
            this.lblParticipation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParticipation.Name = "lblParticipation";
            this.lblParticipation.Size = new System.Drawing.Size(104, 29);
            this.lblParticipation.TabIndex = 25;
            // 
            // lblNameCap
            // 
            this.lblNameCap.BackColor = System.Drawing.Color.SeaShell;
            this.lblNameCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCap.Location = new System.Drawing.Point(546, 10);
            this.lblNameCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameCap.Name = "lblNameCap";
            this.lblNameCap.Size = new System.Drawing.Size(52, 28);
            this.lblNameCap.TabIndex = 24;
            this.lblNameCap.Text = "Name";
            this.lblNameCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvGradeBook
            // 
            this.dgvGradeBook.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvGradeBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradeBook.Location = new System.Drawing.Point(13, 13);
            this.dgvGradeBook.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGradeBook.Name = "dgvGradeBook";
            this.dgvGradeBook.RowHeadersWidth = 62;
            this.dgvGradeBook.RowTemplate.Height = 28;
            this.dgvGradeBook.Size = new System.Drawing.Size(518, 312);
            this.dgvGradeBook.TabIndex = 22;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(604, 8);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(176, 31);
            this.tbxName.TabIndex = 44;
            // 
            // frmGradebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Team3Project_Fixed.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 409);
            this.ControlBox = false;
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnMidterm);
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
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmGradebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gradebook";
            this.Load += new System.EventHandler(this.frmGradebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnMidterm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalCap;
        private System.Windows.Forms.Label lblTestCap;
        private System.Windows.Forms.Label lblLabCap;
        private System.Windows.Forms.Label lblQuizCap;
        private System.Windows.Forms.Label lblHomeworkCap;
        private System.Windows.Forms.Label lblParticipationCap;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Label lblQuiz;
        private System.Windows.Forms.Label lblHomework;
        private System.Windows.Forms.Label lblParticipation;
        private System.Windows.Forms.Label lblNameCap;
        private System.Windows.Forms.DataGridView dgvGradeBook;
        private System.Windows.Forms.TextBox tbxName;
    }
}