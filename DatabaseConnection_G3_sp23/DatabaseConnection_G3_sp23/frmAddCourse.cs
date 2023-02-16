﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection_G3_sp23
{
    public partial class frmAddCourse : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public frmAddCourse()
        {
            InitializeComponent();
        }

        private void frmAddCourse_Load(object sender, EventArgs e)
        {
            database.OpenDatabase(tssDatabaseConnection);
            database.LoadAddCourse(cbxTeacherID, cbxSubjectID);
            cbxClassSize.SelectedIndex = 0;
            cbxSubjectID.SelectedIndex = 0;
            cbxTeacherID.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxClassSize.SelectedIndex = 0;
            cbxSubjectID.SelectedIndex = 0;
            cbxTeacherID.SelectedIndex = 0;
            tbxClassID.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string classID = tbxClassID.Text;
            string hold = cbxTeacherID.Text.ToString();
            string[] holdSplit = hold.Split('-');
            string teacherID = holdSplit[0].Trim();
            hold = cbxSubjectID.Text.ToString();
            holdSplit = hold.Split('-');
            string subjectID = holdSplit[0].Trim();
            string classSize = cbxClassSize.Text;

            database.AddCourse(classID,teacherID,subjectID,classSize);
        }
    }
}
