﻿using System;
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
    public partial class frmAttendanceEdit : Form
    {
        private BindingSource binding = new BindingSource();
        private DatabaseConnection database = new DatabaseConnection();
        private string dateSelection = DateTime.Now.ToString("yyyy-MM-dd");
        private string firstName = "All", lastName = "All";
        private int loginID;
        private int studentID;
        private int classID;
        private string accountType;
        private string classSelect;

        public frmAttendanceEdit(int loginID, int studentID, int classID, string accountType, string classSelect, string date, bool isStudent)
        {
            this.loginID = loginID;
            this.studentID = studentID;
            this.classID = database.GetClassID(classSelect);
            this.accountType = accountType;
            this.dateSelection = date;
            this.classSelect = classSelect;
            InitializeComponent();
        }


        public frmAttendanceEdit()
        {
            InitializeComponent();
        }


        //Intial query and formatting on form load
        private void frmAttendanceEdit_Load(object sender, EventArgs e)
        {
            dgvAttendanceEdit.AllowUserToAddRows = false;
            binding.DataSource = database.AttendanceInfo(accountType, classSelect, dateSelection, loginID);
            dgvAttendanceEdit.DataSource = binding;
            FillUserInfo();


            btnSubmitAttendEdit.BackColor = ColorTranslator.FromHtml("#F15025");
            btnSubmitAttendEdit.ForeColor = ColorTranslator.FromHtml("#191919");
            btnClearAttendEdit.BackColor = ColorTranslator.FromHtml("#F15025");
            btnClearAttendEdit.ForeColor = ColorTranslator.FromHtml("#191919");
            btnBackAttendEdit.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBackAttendEdit.ForeColor = ColorTranslator.FromHtml("#191919");


            NameDropdown();
        }


        //Populate dropdown list of students to edit specific student
        private void NameDropdown()
        {

            NewQuery("All", "All", null);

            List<string> students = new List<string>();

            cmbNamesEdit.Items.Add("All Students");

            foreach (DataRowView row in binding)
            {
                string student = row["Student"].ToString();
                int position = students.IndexOf(student);
                if (position == -1)
                {
                    students.Add(student);
                }
            }

            foreach (string student in students)
            {
                cmbNamesEdit.Items.Add(student);
            }

            NewQuery("All", "All", dateSelection);
        }


        //Close edit form
        private void btnBackAttendEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Data grid cell formatting
        private void dgvAttendanceEdit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //DGV Column header names
            dgvAttendanceEdit.Columns[0].HeaderCell.Value = "Student";
            dgvAttendanceEdit.Columns[1].HeaderCell.Value = "Student ID";
            dgvAttendanceEdit.Columns[2].HeaderCell.Value = "Class ID";
            dgvAttendanceEdit.Columns[3].HeaderCell.Value = "Date";
            dgvAttendanceEdit.Columns[4].HeaderCell.Value = "Present";

            //Loop and style each column
            foreach (DataGridViewColumn col in dgvAttendanceEdit.Columns)
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


        //Query database for selected student
        private void cmbNamesEdit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbNamesEdit.SelectedIndex == 0)
            {
                NewQuery("All", "All", dateSelection);
            }
            else 
            {
                int space;
                string selection = cmbNamesEdit.SelectedItem.ToString();
                space = selection.IndexOf(" ");
                firstName = selection.Substring(0, space);
                lastName = selection.Substring(space + 1);

                NewQuery(firstName, lastName, null);
            }
        }


        //Query database for selected date
        private void dtpAttendanceEdit_ValueChanged(object sender, EventArgs e)
        {
            dateSelection = dtpAttendanceEdit.Value.Date.ToString("yyyy-MM-dd");
            NewQuery(firstName, lastName, dateSelection);
        }


        //Clear all current selctions and set to all students at current date
        private void btnClearAttendEdit_Click(object sender, EventArgs e)
        {
            cmbNamesEdit.SelectedIndex = 0;
            dtpAttendanceEdit.Value = DateTime.Now;
            dateSelection = DateTime.Now.ToString("yyyy-MM-dd");
            firstName = "All";
            lastName = "All";
            NewQuery(firstName, lastName, dateSelection);
        }


        //Query database with default or selected names and date
        private void NewQuery(string first, string last, string date)
        {
            string newQuery;

            if ((first.Equals("All") || last.Equals("All") || first == null || last == null) && date == null)
            {
                newQuery = "SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.ClassID = " + classID + ";";
            }
            else if (date == null)
            {
                newQuery = "SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE s.FirstName = '" + first + "' AND s.LastName = '" + last + "' AND a.ClassID = " + classID + ";";
            }
            else if ((first.Equals("All") && last.Equals("All")) || first == null || last == null)
            {
                newQuery = "SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.AttendanceDate = '" + date + "' AND a.ClassID = " + classID + ";";
            }
            else 
            {
                newQuery = "SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.AttendanceDate = '" + date + "' AND s.FirstName = '" + first + "' AND s.LastName = '" + last + "' AND a.ClassID = " + classID + ";";
            }

            binding.DataSource = database.AttendanceInfo(newQuery);
            dgvAttendanceEdit.DataSource = binding;
        }

        private void btnSubmitAttendEdit_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dateSelection);
            database.UpdateAttendance(dgvAttendanceEdit);

            MessageBox.Show("The records have been updated.", "Records Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            NewQuery(firstName, lastName, dateSelection);
            dtpAttendanceEdit.Value = date;
        }

        private void attendanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbNamesEdit.SelectedIndex < 1)
            {
                MessageBox.Show("Please select a student from the drop down box to generate a report");
            }
            else
            {
                string studentName = cmbNamesEdit.SelectedItem.ToString();

                studentID = database.GetStudentIDByName(studentName);
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
        }

        private void FillUserInfo()
        {
            int spaceIndex = classSelect.IndexOf(" ");
            string className = classSelect.Substring(0, spaceIndex);

            lblAttendTeacher.Text = "Teacher: " + database.LoggedTeacher(classID);
            lblAttendClass.Text = "Class: " + className;
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
