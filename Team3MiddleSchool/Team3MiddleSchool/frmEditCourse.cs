using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team3MiddleSchool
{
    public partial class frmEditCourse : Form
    {
        public string courseID;
        public string courseName;
        public frmEditCourse(string courseID, string courseName)
        {
            this.courseID = courseID;
            this.courseName = courseName;
            InitializeComponent();
        }

        private void frmEditCourse_Load(object sender, EventArgs e)
        {
            clsDatabaseHandler.LoadEditCourse(courseName, tbxClassName, cbxTeacherID, cbxSubjectID, cbxClassSize);
            

            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            btnClear.BackColor = ColorTranslator.FromHtml("#F15025");
            btnClear.ForeColor = ColorTranslator.FromHtml("#191919");
            btnSubmit.BackColor = ColorTranslator.FromHtml("#F15025");
            btnSubmit.ForeColor = ColorTranslator.FromHtml("#191919");
            btnBack.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBack.ForeColor = ColorTranslator.FromHtml("#191919");
            lblClassName.ForeColor = ColorTranslator.FromHtml("#191919");
            lblTeacherID.ForeColor = ColorTranslator.FromHtml("#191919");
            lblSubjectID.ForeColor = ColorTranslator.FromHtml("#191919");
            lblClassSize.ForeColor = ColorTranslator.FromHtml("#191919");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxClassSize.Text = string.Empty;
            cbxSubjectID.Text = string.Empty;
            cbxTeacherID.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateCourseName(tbxClassName.Text))
            {
                clsDatabaseHandler.EditCourse(courseID, tbxClassName, cbxTeacherID, cbxSubjectID, cbxClassSize);
            }
            else
            {
                MessageBox.Show("Please enter a valid course name that is not in use", "Course Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void tbxClassName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidation.ValidateString(e.KeyChar);
        }
    }
}
