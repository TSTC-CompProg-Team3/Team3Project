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
    public partial class frmAttendance : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        private BindingSource binding = new BindingSource();
        private string dateSelection = DateTime.Now.ToString("yyyy-MM-dd");
        private int loginID;
        private int classID;
        private int studentID;
        private string accountType;
        private string classSelect;
        private bool isStudent;
        

        public frmAttendance(int loginID, int studentID, string accountType, string classSelect, bool isStudent)
        {
            this.loginID = loginID;
            this.studentID = studentID;
            this.accountType = accountType;
            this.classSelect = classSelect;
            this.isStudent = isStudent;
            InitializeComponent();
        }

        //TODO: Filter query to current logged in teacher and selected class
        //TODO: Ensure edits made are pushed to database


        public frmAttendance()
        {
            InitializeComponent();
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            dgvAttendance.AllowUserToAddRows = false;
            database.OpenDatabase();
            binding.DataSource = database.AttendanceInfo(accountType, classSelect, loginID);
            classID = database.GetClassID(classSelect);
            DateTime day = DateTime.Now;
            studentID = database.GetStudentID(loginID);

            if ((accountType.Equals("Teacher") || accountType.Equals("Admin") || accountType.Equals("Officer")) && (day.DayOfWeek != DayOfWeek.Sunday || day.DayOfWeek != DayOfWeek.Saturday))
            {
                isStudent = false;
                btnEditAttend.Enabled = true;
                btnEditAttend.BackColor = ColorTranslator.FromHtml("#F15025");
                btnEditAttend.ForeColor = ColorTranslator.FromHtml("#191919");
                btnBackAttend.BackColor = ColorTranslator.FromHtml("#F15025");
                btnBackAttend.ForeColor = ColorTranslator.FromHtml("#191919");

                if (binding.Count < 1)
                {
                    DialogResult result = MessageBox.Show("No data exists for " + classSelect + " on " + DateTime.Now.ToString("dddd, MMMM dd yyyy") + "\n\nWould you like to enter today's attendance?", "Attendance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3);

                    if (result == DialogResult.Yes)
                    {
                        database.GenerateAttendance(classSelect);
                        MessageBox.Show("Attendance for " + classSelect + " on " + DateTime.Now.ToString("dddd, MMMM dd yyyy") + " has been generated." + "\n\nEnter student attendance and submit to save.");
                        NewQuery(day.ToString("yyyy-MM-dd"));
                    }

                    if (result == DialogResult.No)
                    {

                    }

                    if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                isStudent = true;
                btnEditAttend.Enabled = false;
                btnEditAttend.BackColor = Color.LightGray;
                btnBackAttend.BackColor = ColorTranslator.FromHtml("#F15025");
                btnBackAttend.ForeColor = ColorTranslator.FromHtml("#191919");
            }

            dgvAttendance.DataSource = binding;
            dgvAttendance.EditMode.Equals(false);

            FillUserInfo();
        }

        private void dgvAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //DGV Column header names
            dgvAttendance.Columns[0].HeaderCell.Value = "Student";
            dgvAttendance.Columns[1].HeaderCell.Value = "Student ID";
            dgvAttendance.Columns[2].HeaderCell.Value = "Class ID";
            dgvAttendance.Columns[3].HeaderCell.Value = "Date";
            dgvAttendance.Columns[4].HeaderCell.Value = "Present";

            //Loop and style each column
            foreach (DataGridViewColumn col in dgvAttendance.Columns)
            {
                if (col.Index == 0)
                {
                    col.Width = 155;
                }
                else
                {
                    col.Width = 82;
                }
                
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnBackAttend_Click(object sender, EventArgs e)
        {
            database.CloseDatabase();
            this.Close();
        }

        private void btnEditAttend_Click(object sender, EventArgs e)
        {
            frmAttendanceEdit edit = new frmAttendanceEdit(loginID, studentID, classID, accountType, classSelect, isStudent);
            edit.ShowDialog();
        }

        private void FillUserInfo()
        {
            int spaceIndex = classSelect.IndexOf("-");
            string className = classSelect.Substring(0, spaceIndex - 1);

            lblAttendTeacher.Text = "Teacher: " + database.LoggedTeacher(classID);
            lblAttendClass.Text = "Class: " + className;
        }

        private void dtpAttendance_ValueChanged(object sender, EventArgs e)
        {
            dateSelection = dtpAttendance.Value.Date.ToString("yyyy-MM-dd");
            NewQuery(dateSelection);
        }

        private void NewQuery(string date)
        {
            string newQuery = "";

            if (accountType.Equals("Parent") || accountType.Equals("Student"))
            {
                newQuery = "SELECT CONCAT(s.FirstName, ' ', s.LastName) AS \"Student\", s.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s JOIN team3sp232330.StudentSchedule ss ON s.StudentID = ss.StudentID JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.ClassID = " + classID + " AND a.StudentID = " + studentID + " AND a.AttendanceDate = '" + date + "';";
            }
            else if (accountType.Equals("Teacher") || accountType.Equals("Admin") || accountType.Equals("Officer"))
            {
                newQuery = "SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.StudentID = " + studentID + " AND a.ClassID = " + classID + " AND AttendanceDate = '" + date + "';";
            }

            //"SELECT CONCAT(FirstName, ' ', sLastName) AS \"Student\", s.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s JOIN team3sp232330.StudentSchedule ss ON s.StudentID = ss.StudentID JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.ClassID = " + classID + " AND a.AttendanceDate = '" + date + "';";


            binding.DataSource = database.AttendanceInfo(newQuery);
        }
    }
}


//"SELECT CONCAT(s.FirstName, ' ', s.LastName) AS \"Student\", s.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s JOIN team3sp232330.StudentSchedule ss ON s.StudentID = ss.StudentID JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.ClassID = " + classID + " AND a.AttendanceDate = '" + date + "';"
