namespace DatabaseConnection_G3_sp23
{
    partial class frmSeatingChart5
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
            this.btnMain.Location = new System.Drawing.Point(634, 370);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(134, 41);
            this.btnMain.TabIndex = 19;
            this.btnMain.Text = "&Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnRan
            // 
            this.btnRan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRan.Location = new System.Drawing.Point(268, 370);
            this.btnRan.Name = "btnRan";
            this.btnRan.Size = new System.Drawing.Size(121, 41);
            this.btnRan.TabIndex = 18;
            this.btnRan.Text = "&Random";
            this.btnRan.UseVisualStyleBackColor = true;
            this.btnRan.Click += new System.EventHandler(this.btnRan_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(451, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 41);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvStudentSeats
            // 
            this.dgvStudentSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentSeats.Location = new System.Drawing.Point(268, 30);
            this.dgvStudentSeats.Name = "dgvStudentSeats";
            this.dgvStudentSeats.Size = new System.Drawing.Size(501, 311);
            this.dgvStudentSeats.TabIndex = 16;
            this.dgvStudentSeats.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvStudentSeats_DragDrop);
            this.dgvStudentSeats.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvStudentSeats_DragEnter);
            // 
            // lstStudentsAvailable
            // 
            this.lstStudentsAvailable.FormattingEnabled = true;
            this.lstStudentsAvailable.ItemHeight = 15;
            this.lstStudentsAvailable.Location = new System.Drawing.Point(11, 30);
            this.lstStudentsAvailable.Name = "lstStudentsAvailable";
            this.lstStudentsAvailable.Size = new System.Drawing.Size(186, 379);
            this.lstStudentsAvailable.TabIndex = 15;
            this.lstStudentsAvailable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstStudentsAvailable_MouseDown);
            this.lstStudentsAvailable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstStudentsAvailable_MouseMove);
            // 
            // frmSeatingChart5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 436);
            this.ControlBox = false;
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnRan);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvStudentSeats);
            this.Controls.Add(this.lstStudentsAvailable);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSeatingChart5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seating Chart";
            this.Load += new System.EventHandler(this.frmSeatingChart5_Load);
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