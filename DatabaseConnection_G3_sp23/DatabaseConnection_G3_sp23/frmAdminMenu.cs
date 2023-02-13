using System;
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
    public partial class frmAdminMenu : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void frmAdminMenu_Load(object sender, EventArgs e)
        {
            //load cbx for all classes -CS
            database.OpenDatabase(tssDatabaseConnection);
            database.AllClasses();
            foreach (string subject in database.classList)
            {
                cbxCourseSelect.Items.Add(subject);
            }
            cbxCourseSelect.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            
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
                    string course = cbxCourseSelect.Text.ToString();
                    string[] courseSplit = course.Split('-');
                    string courseTrim = courseSplit[0].Trim();
                    database.RemoveCourse(courseTrim);
                    cbxCourseSelect.Items.Clear();
                    cbxCourseSelect.Text = "";
                    database.UpdateAllClasses();
                    foreach (string subject in database.classList)
                    {
                        cbxCourseSelect.Items.Add(subject);
                    }
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
    }
}
