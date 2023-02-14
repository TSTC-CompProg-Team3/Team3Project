using DatabaseConnection_G3_sp23;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team3Project_Fixed
{
    public partial class frmSeatingChart10 : Form
    {
        DatabaseConnection database = new DatabaseConnection();

        public frmSeatingChart10()
        {
            InitializeComponent();

            // allow drag and drop needs to be their to work
            dgvStudentSeats.AllowDrop = true;

            // Adding four hard-coded columns to the DataGridView
            if (dgvStudentSeats.Columns.Count == 0)
            {
                dgvStudentSeats.Columns.Add("FirstName", "FirstName");
                dgvStudentSeats.Columns.Add("LastName", "LastName");
                dgvStudentSeats.Columns.Add("MiddleName", "MiddleName");
                dgvStudentSeats.Columns.Add("StudentID", "StudentID");
                dgvStudentSeats.Columns.Add("DateOfBirth", "DateOfBirth");
            }
        }

        private void btnRan_Click(object sender, EventArgs e)
        {
            // Create a random number generator 
            Random rnd = new Random();

            // Create a list to store the items in the listbox
            List<string> students = new List<string>();


            // Iterates through the items in the listbox and adds each one to the list
            foreach (string name in lstStudentsAvailable.Items)
            {
                // adds item
                students.Add(name);
            }

            // Clear any previous rows in the dgv if the random button is clicked again
            dgvStudentSeats.Rows.Clear();

            // Continues to add a random student to the dgv until there are no students left in the list
            while (students.Count > 0)
            {
                // Selects a rnd stored name from the student list
                int stored = rnd.Next(students.Count);

                // Grabs the students that are stored in the lstbox
                string student = students[stored];

                // Removes the selected item from the lstbox so no duplicated
                students.RemoveAt(stored);

                // Splits the student name into first and last name components
                string[] nameComponents = student.Split(' ');
                string firstName = nameComponents[0];
                string lastName = nameComponents[1];
                string middleName = nameComponents[2];
                string studentID = nameComponents[3];
                string dateOfBirth = nameComponents[4];

                // Adds the selected student to a new row in the dgv
                dgvStudentSeats.Rows.Add(firstName, lastName, middleName, studentID, dateOfBirth);

                // Adds the selected student to a new row in the dgv
                //dgvStudentSeats.Rows.Add(student);
            }
        }


        private void lstStudentsAvailable_MouseDown(object sender, MouseEventArgs e)
        {
            // Selects the item under the mouse cursor when the mouse button is pressed
            lstStudentsAvailable.SelectedIndex = lstStudentsAvailable.IndexFromPoint(e.X, e.Y);
            Console.WriteLine("Selected index: " + lstStudentsAvailable.SelectedIndex);
        }

        private void lstStudentsAvailable_MouseMove(object sender, MouseEventArgs e)
        {
            // Begins the drag and drop operation if an item is selected and the mouse is moved
            if (e.Button == MouseButtons.Left && lstStudentsAvailable.SelectedIndex != -1)
            {
                lstStudentsAvailable.DoDragDrop(lstStudentsAvailable.SelectedItem, DragDropEffects.Move);
            }
        }

        private void dgvStudentSeats_DragDrop(object sender, DragEventArgs e)
        {
            // Adds the dragged item to a new row in the DataGridView
            dgvStudentSeats.Rows.Add(e.Data.GetData(typeof(string)).ToString());
        }

        private void dgvStudentSeats_DragEnter(object sender, DragEventArgs e)
        {
            // Allows the drag and drop operation to continue if the data being dragged is a string
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear any previous rows in the dgv if the random button is clicked again
            dgvStudentSeats.Rows.Clear();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void frmSeatingChart10_Load(object sender, EventArgs e)
        {


            // database.LoadFirst10StudentsToListBox(lstStudentsAvailable);
            database.loadDataGridView(dgvStudentSeats);
            database.StudentInfo();

            // Loop through each student in the list
            foreach (clsStudent student in database.studentList)
            {
                // Create a string with the student information
                string studentInfo = string.Format("{0} {1} {2} {3} ",
                    student.firstName, student.lastName, student.middleName , student.studentID);

                // Add the string to the ListBox
                lstStudentsAvailable.Items.Add(studentInfo);
            }
        }

     

        private void lstStudentsAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
