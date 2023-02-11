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
            database.OpenDatabase();
            database.AllClasses();
            foreach (string subject in database.classList)
            {
                cbxCourseSelect.Items.Add(subject);
            }
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
            //if (cbxCourseSelect.SelectedIndex > -1)
            //{
            //    string course = database.subjectList[cbxCourseSelect.SelectedIndex].subjectName.ToString();
            //    database.RemoveCourse(course);
            //    cbxCourseSelect.Items.Clear();
            //}
            //else
            //{
            //    MessageBox.Show("REPLACE");
            //}
            
        }
    }
}
