namespace Team3Project_Fixed
{
    partial class frmSeatingChart
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
            this.btnMain = new System.Windows.Forms.Button();
            this.btnRan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvStudentSeats = new System.Windows.Forms.DataGridView();
            this.lstStudentsAvailable = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(658, 375);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(121, 41);
            this.btnMain.TabIndex = 14;
            this.btnMain.Text = "&MainMenu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnRan
            // 
            this.btnRan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRan.Location = new System.Drawing.Point(278, 375);
            this.btnRan.Name = "btnRan";
            this.btnRan.Size = new System.Drawing.Size(121, 41);
            this.btnRan.TabIndex = 13;
            this.btnRan.Text = "&Random";
            this.btnRan.UseVisualStyleBackColor = true;
            this.btnRan.Click += new System.EventHandler(this.btnRan_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(468, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 41);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvStudentSeats
            // 
            this.dgvStudentSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentSeats.Location = new System.Drawing.Point(278, 35);
            this.dgvStudentSeats.Name = "dgvStudentSeats";
            this.dgvStudentSeats.Size = new System.Drawing.Size(501, 311);
            this.dgvStudentSeats.TabIndex = 11;
            this.dgvStudentSeats.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvStudentSeats_DragDrop);
            this.dgvStudentSeats.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvStudentSeats_DragEnter);
            // 
            // lstStudentsAvailable
            // 
            this.lstStudentsAvailable.FormattingEnabled = true;
            this.lstStudentsAvailable.Location = new System.Drawing.Point(21, 35);
            this.lstStudentsAvailable.Name = "lstStudentsAvailable";
            this.lstStudentsAvailable.Size = new System.Drawing.Size(186, 381);
            this.lstStudentsAvailable.TabIndex = 10;
            this.lstStudentsAvailable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstStudentsAvailable_MouseDown);
            this.lstStudentsAvailable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstStudentsAvailable_MouseMove);
            // 
            // frmSeatingChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnRan);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvStudentSeats);
            this.Controls.Add(this.lstStudentsAvailable);
            this.Name = "frmSeatingChart";
            this.Text = "SeatingChart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSeatingChart_FormClosing);
            this.Load += new System.EventHandler(this.frmSeatingChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSeats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnRan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvStudentSeats;
        private System.Windows.Forms.ListBox lstStudentsAvailable;
    }
}