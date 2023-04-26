using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        

        public frmAttendance(int loginID, string accountType, string classSelect, bool isStudent)
        {
            this.loginID = loginID;
            this.accountType = accountType;
            this.classSelect = classSelect;
            this.isStudent = isStudent;
            InitializeComponent();
        }


        public frmAttendance()
        {
            InitializeComponent();
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            DateTime day = DateTime.Now;

            if (accountType.Equals("Teacher") || accountType.Equals("Admin") || accountType.Equals("Officer") || accountType.Equals("Parent"))
            {
                database.OpenDatabase();
            }

            if (accountType.Equals("student") || accountType.Equals("Parent"))
            {
                studentID = database.GetStudentID(loginID, accountType);
            }
            binding.DataSource = database.AttendanceInfo(accountType, classSelect, loginID);
            classID = database.GetClassID(classSelect);
            if (accountType.Equals("Teacher") || accountType.Equals("Admin") || accountType.Equals("Officer"))
            {
                isStudent = false;
                btnEditAttend.Enabled = true;
                btnSubmitAttend.Enabled = true;
                btnEditAttend.BackColor = ColorTranslator.FromHtml("#F15025");
                btnEditAttend.ForeColor = ColorTranslator.FromHtml("#191919");
                btnBackAttend.BackColor = ColorTranslator.FromHtml("#F15025");
                btnBackAttend.ForeColor = ColorTranslator.FromHtml("#191919");
                btnSubmitAttend.BackColor = ColorTranslator.FromHtml("#F15025");
                btnSubmitAttend.ForeColor = ColorTranslator.FromHtml("#191919");
                mnuStrip.BackColor = ColorTranslator.FromHtml("#E6E8E6");
                mnuStrip.ForeColor = ColorTranslator.FromHtml("#191919");

                if (binding.Count < 1 && (day.DayOfWeek != DayOfWeek.Sunday && day.DayOfWeek != DayOfWeek.Saturday))
                {
                    DialogResult result = MessageBox.Show("No data exists for " + classSelect + " on " + DateTime.Now.ToString("dddd, MMMM dd yyyy") + "\n\nWould you like to enter today's attendance?", "Attendance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3);

                    if (result == DialogResult.Yes)
                    {
                        database.GenerateAttendance(classSelect);
                        MessageBox.Show("Attendance for " + classSelect + " on " + DateTime.Now.ToString("dddd, MMMM dd yyyy") + " has been generated." + "\n\nEnter student attendance and submit to save.");
                        NewQuery(day.ToString("yyyy-MM-dd"), accountType);
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
                btnSubmitAttend.Enabled = false;
                btnEditAttend.BackColor = Color.LightGray;
                btnSubmitAttend.BackColor = Color.LightGray;
                btnBackAttend.BackColor = ColorTranslator.FromHtml("#F15025");
                btnBackAttend.ForeColor = ColorTranslator.FromHtml("#191919");
            }

            dgvAttendance.DataSource = binding;
            dgvAttendance.EditMode.Equals(false);
            dgvAttendance.AllowUserToAddRows = false;

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
            frmAttendanceEdit edit = new frmAttendanceEdit(loginID, studentID, classID, accountType, classSelect, dateSelection, isStudent);
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
            NewQuery(dateSelection, accountType);
        }

        private void NewQuery(string date, string accountType)
        {
            string newQuery = "";
            

            if (accountType.Equals("Parent") || accountType.Equals("student"))
            {
                newQuery = "SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.ClassID = " + classID + " AND a.StudentID = " + studentID + " AND AttendanceDate = '" + date + "';";
            }
            else if (accountType.Equals("Teacher") || accountType.Equals("Admin") || accountType.Equals("Officer"))
            {
                newQuery = "SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.ClassID = " + classID + " AND AttendanceDate = '" + date + "';";
            }

            binding.DataSource = database.AttendanceInfo(newQuery);
        }

        private void btnSubmitAttend_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dateSelection);

            if (date.ToString("yyyy-MM-dd") != DateTime.Now.ToString("yyyy-MM-dd"))
            {  
                MessageBox.Show("Only updates for the current day can be made from this window.\n\nPlease use the 'Edit' window to make changes to specific dates.", "Records Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                database.UpdateAttendance(dgvAttendance);

                MessageBox.Show("Today's attendance has been updated.", "Attendance Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                NewQuery(dateSelection, accountType);
                dtpAttendance.Value = date;
            }
        }

        private void frmAttendance_Activated(object sender, EventArgs e)
        {
            NewQuery(dateSelection, accountType);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("attendance.html");
        }

        private void attendanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (accountType.Equals("student") || accountType.Equals("Parent"))
            {
                string studentName = database.GetStudentName(studentID);
                int spaceIndex = classSelect.IndexOf("-");
                string className = classSelect.Substring(0, spaceIndex - 1);
                string teacher = database.LoggedTeacher(classID);
                List<string> attendanceData = database.GetTotalAttendance(studentID, classID);
                float totalDays = float.Parse(attendanceData[0]);
                float absentDays = 0;
                if (attendanceData[1].Equals("none"))
                {
                    absentDays = 0;
                }
                else
                {
                    absentDays = float.Parse(attendanceData[1]);
                }

                float presentDays = totalDays - absentDays;
                float percentageDays = (presentDays / totalDays) * 100;
                string percentage = (totalDays - absentDays) + " of " + totalDays + " - " + percentageDays.ToString("#.##");
                List<string> daysMissed = new List<string>();
                if (attendanceData.Count > 2)
                {
                    for (int i = 2; i < attendanceData.Count; i++)
                    {
                        spaceIndex = attendanceData[i].IndexOf(" ");
                        string addDay = attendanceData[i].Substring(0, spaceIndex);
                        daysMissed.Add(addDay);
                    }
                }
                generateAttendanceReport(studentName, className, teacher, percentage, daysMissed);
            }
            else
            {
                MessageBox.Show("Please select a student from the 'Edit' window to generate an attendance report.");
            }
        }

        private void generateAttendanceReport(string studentName, string className, string teacher, string attendance, List<string> daysMissed)
        {
            string template = "attendanceReportTemplate.html";

            StreamReader sr = new StreamReader(template);
            string content = sr.ReadToEnd();
            sr.Close();


            string daysMissedString = "";

            foreach (string day in daysMissed)
            {
                daysMissedString += "<br>&emsp;&emsp;" + day;
            }

            string search = "<h2 id=\"studentNameHeader\">Student Name</h2>";
            string replace = "<h2 id=\"studentNameHeader\">" + studentName + "</h2>";
            content = content.Replace(search, replace);

            search = "<dt id=\"c1\"></dt>";
            replace = "<dt id=\"c1\">Class: " + className + "</dt>";
            content = content.Replace(search, replace);

            search = "<dt id=\"t1\"></dt>";
            replace = "<dt id=\"t1\">Teacher: " + teacher + "</dt>";
            content = content.Replace(search, replace);

            search = "<dt id=\"a1\"></dt>";
            replace = "<dt id=\"a1\">Attendance: " + attendance + "%</dt>";
            content = content.Replace(search, replace);

            search = "<dt id=\"d1\"></dt>";
            replace = "<dt id=\"d1\">Days Missed: " + daysMissedString + "</dt>";
            content = content.Replace(search, replace);



            string report = "reportGenerator.html";
            StreamWriter sw = new StreamWriter(report, false);
            sw.Write(content);
            sw.Close();

            System.Diagnostics.Process.Start("reportGenerator.html");

        }
    }
}