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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeatingChart5));
            this.btnMain = new System.Windows.Forms.Button();
            this.btnRan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstStudentsAvailable = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxStudentNames = new System.Windows.Forms.ComboBox();
            this.cbxStudentNames2 = new System.Windows.Forms.ComboBox();
            this.cbxStudentNames3 = new System.Windows.Forms.ComboBox();
            this.cbxStudentNames4 = new System.Windows.Forms.ComboBox();
            this.cbxStudentNames5 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // lstStudentsAvailable
            // 
            this.lstStudentsAvailable.FormattingEnabled = true;
            this.lstStudentsAvailable.ItemHeight = 15;
            this.lstStudentsAvailable.Location = new System.Drawing.Point(12, 32);
            this.lstStudentsAvailable.Name = "lstStudentsAvailable";
            this.lstStudentsAvailable.Size = new System.Drawing.Size(186, 379);
            this.lstStudentsAvailable.TabIndex = 15;
            this.lstStudentsAvailable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstStudentsAvailable_MouseDown);
            this.lstStudentsAvailable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstStudentsAvailable_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // cbxStudentNames
            // 
            this.cbxStudentNames.FormattingEnabled = true;
            this.cbxStudentNames.Location = new System.Drawing.Point(247, 135);
            this.cbxStudentNames.Name = "cbxStudentNames";
            this.cbxStudentNames.Size = new System.Drawing.Size(71, 23);
            this.cbxStudentNames.TabIndex = 22;
            // 
            // cbxStudentNames2
            // 
            this.cbxStudentNames2.FormattingEnabled = true;
            this.cbxStudentNames2.Location = new System.Drawing.Point(357, 135);
            this.cbxStudentNames2.Name = "cbxStudentNames2";
            this.cbxStudentNames2.Size = new System.Drawing.Size(71, 23);
            this.cbxStudentNames2.TabIndex = 23;
            // 
            // cbxStudentNames3
            // 
            this.cbxStudentNames3.FormattingEnabled = true;
            this.cbxStudentNames3.Location = new System.Drawing.Point(473, 135);
            this.cbxStudentNames3.Name = "cbxStudentNames3";
            this.cbxStudentNames3.Size = new System.Drawing.Size(71, 23);
            this.cbxStudentNames3.TabIndex = 24;
            // 
            // cbxStudentNames4
            // 
            this.cbxStudentNames4.FormattingEnabled = true;
            this.cbxStudentNames4.Location = new System.Drawing.Point(247, 208);
            this.cbxStudentNames4.Name = "cbxStudentNames4";
            this.cbxStudentNames4.Size = new System.Drawing.Size(71, 23);
            this.cbxStudentNames4.TabIndex = 25;
            // 
            // cbxStudentNames5
            // 
            this.cbxStudentNames5.FormattingEnabled = true;
            this.cbxStudentNames5.Location = new System.Drawing.Point(473, 208);
            this.cbxStudentNames5.Name = "cbxStudentNames5";
            this.cbxStudentNames5.Size = new System.Drawing.Size(71, 23);
            this.cbxStudentNames5.TabIndex = 26;
            // 
            // frmSeatingChart5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Team3Project_Fixed.Properties.Resources.Logo;
            this.ClientSize = new System.Drawing.Size(784, 436);
            this.ControlBox = false;
            this.Controls.Add(this.cbxStudentNames5);
            this.Controls.Add(this.cbxStudentNames4);
            this.Controls.Add(this.cbxStudentNames3);
            this.Controls.Add(this.cbxStudentNames2);
            this.Controls.Add(this.cbxStudentNames);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnRan);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstStudentsAvailable);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSeatingChart5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seating Chart";
            this.Load += new System.EventHandler(this.frmSeatingChart5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnRan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstStudentsAvailable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxStudentNames;
        private System.Windows.Forms.ComboBox cbxStudentNames2;
        private System.Windows.Forms.ComboBox cbxStudentNames3;
        private System.Windows.Forms.ComboBox cbxStudentNames4;
        private System.Windows.Forms.ComboBox cbxStudentNames5;
    }
}