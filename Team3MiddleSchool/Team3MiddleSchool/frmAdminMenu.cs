using System;
using System.Drawing;
using System.Windows.Forms;
using Team3MiddleSchool;


namespace Team3MiddleSchool
{
    public partial class frmAdminMenu : Form
    {
        public string courseID;
        public string courseName;
        public string teacherID;
        public int loginID;
        public string accountType;
        public frmAdminMenu(int loginid, string accounttype)
        {
            InitializeComponent();
            loginID = loginid;
            accountType = accounttype;

        }

        private void frmAdminMenu_Load(object sender, EventArgs e)
        {
            clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect,cbxStudentSelect, cbxTeacherSelect);   

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
            btnBack.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBack.ForeColor = ColorTranslator.FromHtml("#191919");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmAddCourse addCourse = new frmAddCourse();
            addCourse.ShowDialog();
            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect);
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            //clsDatabaseHandler.RemoveCourse(cbxCourseSelect);
            //cbxCourseSelect.Items.Clear();
            //cbxStudentSelect.Items.Clear();
            //cbxTeacherSelect.Items.Clear();
            //clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect);

        }

        private void frmAdminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

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
            clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect);
        }

        private void btnRemoveTeacher_Click(object sender, EventArgs e)
        {
            //clsDatabaseHandler.RemoveTeacher(cbxTeacherSelect);
            //cbxCourseSelect.Items.Clear();
            //cbxStudentSelect.Items.Clear();
            //cbxTeacherSelect.Items.Clear();
            //clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect);
        }

        private void frmAdminMenu_Activated(object sender, EventArgs e)
        {
            
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            frmAddTeacher addTeacher = new frmAddTeacher();
            addTeacher.ShowDialog();
            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect);

        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            frmEditTeacher editTeacher = new frmEditTeacher(cbxTeacherSelect.Text);
            editTeacher.ShowDialog();
            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect, cbxTeacherSelect);
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            //clsDatabaseHandler.RemoveStudent(cbxStudentSelect);


            //cbxCourseSelect.Items.Clear();
            //cbxStudentSelect.Items.Clear();
            //cbxTeacherSelect.Items.Clear();
            //clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect,cbxTeacherSelect);
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            frmEditStudent EditStudent = new frmEditStudent(cbxStudentSelect.Text);
            EditStudent.ShowDialog();

            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect,cbxTeacherSelect);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent addStudent = new frmAddStudent();
            addStudent.ShowDialog();

            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect,cbxTeacherSelect);
        }

    }
}
