using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Team3MiddleSchool
{
    public partial class frmOfficerMenu : Form
    {
        public int loginID;
        public string accountType;
        public string courseID;
        public string courseName;
        public frmOfficerMenu(int loginid, string accounttype)
        {
            loginID = loginid;
            accountType = accounttype;
            InitializeComponent();
        }

        private void frmOfficerMenu_Load(object sender, EventArgs e)
        {
            clsDatabaseHandler.LoadOfficerMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect, cbxSubjectSelect, cbxParentSelect);

            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
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
            btnAddSubject.BackColor = ColorTranslator.FromHtml("#F15025");
            btnAddSubject.ForeColor = ColorTranslator.FromHtml("#191919");
            btnEditSubject.BackColor = ColorTranslator.FromHtml("#F15025");
            btnEditSubject.ForeColor = ColorTranslator.FromHtml("#191919");
            btnRemoveSubject.BackColor = ColorTranslator.FromHtml("#F15025");
            btnRemoveSubject.ForeColor = ColorTranslator.FromHtml("#191919");
            btnAddParent.BackColor = ColorTranslator.FromHtml("#F15025");
            btnAddParent.ForeColor = ColorTranslator.FromHtml("#191919");
            btnEditParent.BackColor = ColorTranslator.FromHtml("#F15025");
            btnEditParent.ForeColor = ColorTranslator.FromHtml("#191919");
            btnRemoveParent.BackColor = ColorTranslator.FromHtml("#F15025");
            btnRemoveParent.ForeColor = ColorTranslator.FromHtml("#191919");
            btnBack.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBack.ForeColor = ColorTranslator.FromHtml("#191919");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            clsDatabaseHandler.RemoveCourse(cbxCourseSelect);

            updateCbx();
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            string hold = cbxCourseSelect.Text.ToString();
            string[] holdSplit = hold.Split('-');
            courseID = holdSplit[0].Trim();
            courseName = holdSplit[1].Trim();
            frmEditCourse editCourse = new frmEditCourse(courseID, courseName);
            editCourse.ShowDialog();

            updateCbx();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmAddCourse addCourse = new frmAddCourse();
            addCourse.ShowDialog();

            updateCbx();
        }

        private void btnRemoveTeacher_Click(object sender, EventArgs e)
        {
            //clsDatabaseHandler.RemoveTeacher(cbxTeacherSelect);
            //cbxCourseSelect.Items.Clear();
            //cbxStudentSelect.Items.Clear();
            //cbxTeacherSelect.Items.Clear();
            //clsDatabaseHandler.LoadOfficerMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect, cbxSubjectSelect);
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            frmEditTeacher editTeacher = new frmEditTeacher(cbxTeacherSelect.Text);
            editTeacher.ShowDialog();

            updateCbx();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            frmAddTeacher addTeacher = new frmAddTeacher();
            addTeacher.ShowDialog();

            updateCbx();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            clsDatabaseHandler.RemoveStudent(cbxStudentSelect);


            updateCbx();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            frmEditStudent EditStudent = new frmEditStudent(cbxStudentSelect.Text);
            EditStudent.ShowDialog();

            updateCbx();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent addStudent = new frmAddStudent();
            addStudent.ShowDialog();

            updateCbx();
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {

        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            frmEditSubject editSubject = new frmEditSubject(cbxSubjectSelect.Text);
            editSubject.ShowDialog();

            updateCbx();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            frmAddSubject addSubject = new frmAddSubject();
            addSubject.ShowDialog();

            updateCbx();
        }

        private void cbxCourseSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clsValidation.CheckCourseDelete(cbxCourseSelect.Text))
            {
                btnRemoveCourse.Visible = true;
            }
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            frmAddParent addParent = new frmAddParent();
            addParent.ShowDialog();

            updateCbx();
        }

        private void btnEditParent_Click(object sender, EventArgs e)
        {
            frmEditParent editParent = new frmEditParent(cbxParentSelect.Text);
            editParent.ShowDialog();

            updateCbx();
        }

        private void updateCbx()
        {
            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            cbxSubjectSelect.Items.Clear();
            cbxParentSelect.Items.Clear();
            clsDatabaseHandler.LoadOfficerMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect, cbxSubjectSelect, cbxParentSelect);
        }
    }
}
