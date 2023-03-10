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
    public partial class frmAttendanceEdit : Form
    {
        private BindingSource binding = new BindingSource();
        private DatabaseConnection database = new DatabaseConnection();
        private string dateSelection = DateTime.Now.ToString("yyyy-MM-dd");
        private string firstName = "All", lastName = "All";

        //TODO: Filter query to current logged in teacher and selected class
        //TODO: Ensure edits made are pushed to database


        public frmAttendanceEdit()
        {
            InitializeComponent();
        }


        //Intial query and formatting on form load
        private void frmAttendanceEdit_Load(object sender, EventArgs e)
        {
            binding.DataSource = database.AttendanceInfo();
            dgvAttendanceEdit.DataSource = binding;

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

                NewQuery(firstName, lastName, dateSelection);
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


            if ((first.Equals("All") && last.Equals("All")) || first == null || last == null)
            {
                newQuery = "SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.AttendanceDate = '" + date + "';";
            }
            else 
            {
                newQuery = "SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.AttendanceDate = '" + date + "' AND s.FirstName = '" + first + "' AND s.LastName = '" + last + "';";
            }

            binding.DataSource = database.AttendanceInfo(newQuery);
        }
    }
}
