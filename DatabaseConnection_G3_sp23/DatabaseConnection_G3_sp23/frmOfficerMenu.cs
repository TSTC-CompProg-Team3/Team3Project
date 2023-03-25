using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team3Project_Fixed;

namespace DatabaseConnection_G3_sp23
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
            clsDatabaseHandler.LoadOfficerMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect, cbxSubjectSelect);

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
            btnBack.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBack.ForeColor = ColorTranslator.FromHtml("#191919");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            //clsDatabaseHandler.RemoveCourse(cbxCourseSelect);
            //cbxCourseSelect.Items.Clear();
            //cbxStudentSelect.Items.Clear();
            //cbxTeacherSelect.Items.Clear();
            //clsDatabaseHandler.LoadOfficerMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect, cbxSubjectSelect);
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            string hold = cbxCourseSelect.Text.ToString();
            string[] holdSplit = hold.Split('-');
            courseID = holdSplit[0].Trim();
            courseName = holdSplit[1].Trim();
            frmEditCourse editCourse = new frmEditCourse(courseID, courseName);
            editCourse.ShowDialog();

            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadOfficerMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect, cbxSubjectSelect);
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmAddCourse addCourse = new frmAddCourse();
            addCourse.ShowDialog();

            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadOfficerMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect, cbxSubjectSelect);
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

            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadOfficerMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect, cbxSubjectSelect);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            frmAddTeacher addTeacher = new frmAddTeacher();
            addTeacher.ShowDialog();

            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadOfficerMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect, cbxSubjectSelect);
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            clsDatabaseHandler.RemoveStudent(cbxStudentSelect);


            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect);
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            frmEditStudent EditStudent = new frmEditStudent(cbxStudentSelect.Text);
            EditStudent.ShowDialog();

            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent addStudent = new frmAddStudent();
            addStudent.ShowDialog();

            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect);
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {

        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {

        }
    }
}
