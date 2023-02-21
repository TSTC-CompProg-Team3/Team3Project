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

        public frmAttendanceEdit()
        {
            InitializeComponent();
        }

        private void frmAttendanceEdit_Load(object sender, EventArgs e)
        {
            database.OpenDatabase();
            binding.DataSource = database.AttendanceInfo();
            dgvAttendanceEdit.DataSource = binding;

            NameDropdown();
        }

        //Populate dropdown list of students to edit specific student
        private void NameDropdown()
        {
            List<string> students = new List<string>();

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

        private void btnBackAttendEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAttendanceEdit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //DGV Column header names
            dgvAttendanceEdit.Columns[0].HeaderCell.Value = "Student";
            dgvAttendanceEdit.Columns[1].HeaderCell.Value = "Date";
            dgvAttendanceEdit.Columns[2].HeaderCell.Value = "Present";

            //Loop and style each column
            foreach (DataGridViewColumn col in dgvAttendanceEdit.Columns)
            {
                col.Width = 220;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void cmbNamesEdit_SelectedValueChanged(object sender, EventArgs e)
        {
            ViewStudent();
        }

        //Select and display single student in data grid
        private void ViewStudent()
        {
            int space;
            string first, last, selection = cmbNamesEdit.SelectedItem.ToString();
            space = selection.IndexOf(" ");
            first = selection.Substring(0, space);
            last = selection.Substring(space + 1);

            string singleStudent = "SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.Date, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE s.FirstName = '" + first + "' AND s.LastName = '" + last + "';";
            binding.DataSource = database.AttendanceInfo(singleStudent);
        }
    }
}
