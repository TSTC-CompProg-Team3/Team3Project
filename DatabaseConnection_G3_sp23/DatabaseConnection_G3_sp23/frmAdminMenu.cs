﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnection_G3_sp23;

namespace DatabaseConnection_G3_sp23
{
    public partial class frmAdminMenu : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public string courseID;
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void frmAdminMenu_Load(object sender, EventArgs e)
        {
            //load cbx for all classes -CS
            database.OpenDatabase(tssDatabaseConnection);
            
            database.LoadAdminMenu(cbxCourseSelect,cbxTeacherSelect, cbxStudentSelect);

            cbxCourseSelect.SelectedIndex = 0;
            cbxStudentSelect.SelectedIndex = 0;
            cbxTeacherSelect.SelectedIndex = 0;

            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            tsStatus.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            btnAddCourse.BackColor = ColorTranslator.FromHtml("#F15025");
            btnAddCourse.ForeColor = ColorTranslator.FromHtml("#191919");
            btnEditCourse.BackColor = ColorTranslator.FromHtml("#F15025");
            btnEditCourse.ForeColor = ColorTranslator.FromHtml("#191919");
            btnRemoveCourse.BackColor = ColorTranslator.FromHtml("#F15025");
            btnRemoveCourse.ForeColor = ColorTranslator.FromHtml("#191919");
            btnAddTeacher.BackColor = ColorTranslator.FromHtml("#F15025");
            btnAddTeacher.ForeColor = ColorTranslator.FromHtml("#191919");
            btnEditTeacher.BackColor = ColorTranslator.FromHtml("#F15025");
            btnEditTeacher.ForeColor = ColorTranslator.FromHtml("#191919");
            btnRemoveTeacher.BackColor = ColorTranslator.FromHtml("#F15025");
            btnRemoveTeacher.ForeColor = ColorTranslator.FromHtml("#191919");
            btnAddStudent.BackColor = ColorTranslator.FromHtml("#F15025");
            btnAddStudent.ForeColor = ColorTranslator.FromHtml("#191919");
            btnEditStudent.BackColor = ColorTranslator.FromHtml("#F15025");
            btnEditStudent.ForeColor = ColorTranslator.FromHtml("#191919");
            btnRemoveStudent.BackColor = ColorTranslator.FromHtml("#F15025");
            btnRemoveStudent.ForeColor = ColorTranslator.FromHtml("#191919");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmAddCourse addCourse = new frmAddCourse();
            addCourse.ShowDialog();
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            //checks if something is selected -CS
            if (cbxCourseSelect.SelectedIndex > -1)
            {
                //confirms if admin wants to remove course -CS
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to remove the course?", "Course Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string hold = cbxCourseSelect.Text.ToString();
                    string[] holdSplit = hold.Split('-');
                    courseID = holdSplit[0].Trim();
                    database.RemoveCourse(courseID);
                    cbxCourseSelect.Items.Clear();
                    cbxCourseSelect.Text = "";
                    database.UpdateAdminMenu(cbxCourseSelect,cbxTeacherSelect,cbxStudentSelect);
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Please select a course for removal", "Course Removal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmAdminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            database.CloseDatabase(tssDatabaseConnection);
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            string hold = cbxCourseSelect.Text.ToString();
            string[] holdSplit = hold.Split('-');
            courseID = holdSplit[0].Trim();
            frmEditCourse editCourse = new frmEditCourse(courseID);
            editCourse.ShowDialog();
        }
    }
}
