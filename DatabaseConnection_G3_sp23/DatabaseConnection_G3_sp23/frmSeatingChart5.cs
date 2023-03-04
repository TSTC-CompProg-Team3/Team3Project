using DatabaseConnection_G3_sp23;
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
    public partial class frmSeatingChart5 : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public frmSeatingChart5()
        {
            InitializeComponent();

            // allow drag and drop needs to be their to work
            //dgvStudentSeats.AllowDrop = true;
            lstStudentsAvailable.AllowDrop = true;

            LoadStudentNames();
        }

        private void btnRan_Click(object sender, EventArgs e)
        {
            // Set the Random button color and text color
            btnRan.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnRan.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            Random random = new Random();

            int randomNum = random.Next(cbxStudentNames.Items.Count);
            cbxStudentNames.SelectedIndex = randomNum;

            int randomNum2 = random.Next(cbxStudentNames2.Items.Count);
            cbxStudentNames2.SelectedIndex = randomNum2;
            int randomNum3 = random.Next(cbxStudentNames3.Items.Count);
            cbxStudentNames3.SelectedIndex = randomNum3;
            int randomNum4 = random.Next(cbxStudentNames4.Items.Count);
            cbxStudentNames4.SelectedIndex = randomNum4;
            int randomNum5 = random.Next(cbxStudentNames5.Items.Count);
            cbxStudentNames5.SelectedIndex = randomNum5;
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
            //dgvStudentSeats.Rows.Add(e.Data.GetData(typeof(string)).ToString());
        }

        //private void dgvStudentSeats_DragEnter(object sender, DragEventArgs e)
        //{
        //    // Adds the dragged item to a new row in the DataGridView
        //    //dgvStudentSeats.Rows.Add(e.Data.GetData(typeof(string)).ToString());

        //    if (e.Data.GetDataPresent(typeof(string)))
        //    {
        //        string fullName = e.Data.GetData(typeof(string)).ToString();
        //        string[] nameParts = fullName.Split(' ');
        //        string firstName = nameParts[0];
        //        string lastName = nameParts[1];

        //        // Check if the student is already in the DataGridView
        //        bool isStudentAlreadyAdded = false;
        //        foreach (DataGridViewRow row in dgvStudentSeats.Rows)
        //        {
        //            if (row.Cells["FirstName"].Value != null &&
        //                row.Cells["LastName"].Value != null &&
        //                row.Cells["FirstName"].Value.ToString() == firstName &&
        //                row.Cells["LastName"].Value.ToString() == lastName)
        //            {
        //                isStudentAlreadyAdded = true;
        //                break;
        //            }
        //        }
        //        if (!isStudentAlreadyAdded)
        //        {
        //            // Add the new row to the DataTable
        //            DataTable dt = (DataTable)dgvStudentSeats.DataSource;
        //            DataRow newRow = dt.NewRow();
        //            newRow["FirstName"] = firstName;
        //            newRow["LastName"] = lastName;
        //            dt.Rows.Add(newRow);

        //            // Refresh the DataGridView to reflect the changes
        //            dgvStudentSeats.DataSource = null;
        //            dgvStudentSeats.DataSource = dt;
        //        }
        //    }
        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Set the Clear button color and text color
            btnClear.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnClear.ForeColor = ColorTranslator.FromHtml("#F2F2F2");


            cbxStudentNames.SelectedIndex = 1;
            cbxStudentNames2.SelectedIndex = 1;
            cbxStudentNames3.SelectedIndex = 1;
            cbxStudentNames4.SelectedIndex = 1;
            cbxStudentNames5.SelectedIndex = 1;


        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // Set the Menu button color and text color
            btnMain.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnMain.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            new frmLogin().Show();
            this.Hide();
        }

        private void frmSeatingChart5_Load(object sender, EventArgs e)
        {
            // Set the form background color and text color
            this.BackColor = ColorTranslator.FromHtml("#F2F2F2");
            this.ForeColor = ColorTranslator.FromHtml("#212121");

            // Set the listbox background color and text color
            lstStudentsAvailable.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            lstStudentsAvailable.ForeColor = ColorTranslator.FromHtml("#212121");

            // Set the datagridview background color and text color
           
            // Set the Random button color and text color
            btnRan.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnRan.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            // Set the Clear button color and text color
            btnClear.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnClear.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            // Set the Menu button color and text color
            btnMain.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnMain.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            

            database.PopulateStudentListBox(lstStudentsAvailable);
        }

        private void LoadStudentNames()
        {
            List<string> studentNames = database.GetStudentNames(cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5);

            // add students to cbx 
            foreach (string name in studentNames)
            {
                cbxStudentNames.Items.Add(name);
                cbxStudentNames2.Items.Add(name);
                cbxStudentNames3.Items.Add(name);
                cbxStudentNames4.Items.Add(name);
                cbxStudentNames5.Items.Add(name);
            }
        }

        
    }
}
