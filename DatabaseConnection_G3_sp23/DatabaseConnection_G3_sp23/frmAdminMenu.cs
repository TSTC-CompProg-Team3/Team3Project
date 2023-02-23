using System;
using System.Drawing;
using System.Windows.Forms;


namespace DatabaseConnection_G3_sp23
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
            clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect,cbxStudentSelect,cbxSubjectSelect, cbxTeacherSelect);   

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


            if (accountType.Equals("Officer"))
            {
                btnAddSubject.Visible = true;
                btnEditSubject.Visible = true;
                btnRemoveSubject.Visible = true;
                cbxSubjectSelect.Visible = true;
                MessageBox.Show("Officer Functionality under construction", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            clsDatabaseHandler.RemoveCourse(cbxCourseSelect);
            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxSubjectSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect, cbxSubjectSelect, cbxTeacherSelect);

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
        }

        private void btnRemoveTeacher_Click(object sender, EventArgs e)
        {
            clsDatabaseHandler.RemoveTeacher(cbxTeacherSelect);
            cbxCourseSelect.Items.Clear();
            cbxStudentSelect.Items.Clear();
            cbxSubjectSelect.Items.Clear();
            cbxTeacherSelect.Items.Clear();
            clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect, cbxSubjectSelect, cbxTeacherSelect);
        }

        private void frmAdminMenu_Activated(object sender, EventArgs e)
        {
            //Trying to find best way to update data
            //cbxCourseSelect.Items.Clear();
            //cbxStudentSelect.Items.Clear();
            //cbxSubjectSelect.Items.Clear();
            //cbxTeacherSelect.Items.Clear();
            //clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, cbxStudentSelect, cbxSubjectSelect, cbxTeacherSelect);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Teacher under construction", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Teacher under construction", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Remove Student under construction", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Student under construction", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Student under construction", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Remove Subject under construction", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Subject under construction", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Subject under construction", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
