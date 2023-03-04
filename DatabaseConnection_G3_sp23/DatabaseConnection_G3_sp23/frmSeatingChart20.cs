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
    public partial class frmSeatingChart20 : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public frmSeatingChart20()
        {
            InitializeComponent();

            // allow drag and drop needs to be their to work
            dgvStudentSeats.AllowDrop = true;
            lstStudentsAvailable.AllowDrop = true;
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

            // Adds the dragged item to a new row in the DataGridView
            //dgvStudentSeats.Rows.Add(e.Data.GetData(typeof(string)).ToString());
            if (e.Data.GetDataPresent(typeof(string)))
            {
                string fullName = e.Data.GetData(typeof(string)).ToString();
                string[] nameParts = fullName.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts[1];

                // Check if the student is already in the DataGridView
                bool isStudentAlreadyAdded = false;
                foreach (DataGridViewRow row in dgvStudentSeats.Rows)
                {
                    if (row.Cells["FirstName"].Value != null &&
                        row.Cells["LastName"].Value != null &&
                        row.Cells["FirstName"].Value.ToString() == firstName &&
                        row.Cells["LastName"].Value.ToString() == lastName)
                    {
                        isStudentAlreadyAdded = true;
                        break;
                    }
                }
                if (!isStudentAlreadyAdded)
                {
                    // Add the new row to the DataTable
                    DataTable dt = (DataTable)dgvStudentSeats.DataSource;
                    DataRow newRow = dt.NewRow();
                    newRow["FirstName"] = firstName;
                    newRow["LastName"] = lastName;
                    dt.Rows.Add(newRow);

                    // Refresh the DataGridView to reflect the changes
                    dgvStudentSeats.DataSource = null;
                    dgvStudentSeats.DataSource = dt;
                }
            }
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
            // Set the Clear button color and text color
            btnClear.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnClear.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            // This clears the data source, since dgv is being called from the database
            dgvStudentSeats.DataSource = null;

            // Now you need to recall the database back, and this will reset it back in order base on how its set up inside the database
            database.loadDataGridView20(dgvStudentSeats);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // Set the Menu button color and text color
            btnMain.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnMain.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            new frmLogin().Show();
            this.Hide();
        }

        private void frmSeatingChart20_Load(object sender, EventArgs e)
        {
            // Set the form background color and text color
            this.BackColor = ColorTranslator.FromHtml("#F2F2F2");
            this.ForeColor = ColorTranslator.FromHtml("#212121");

            // Set the listbox background color and text color
            lstStudentsAvailable.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            lstStudentsAvailable.ForeColor = ColorTranslator.FromHtml("#212121");

            // Set the datagridview background color and text color
            dgvStudentSeats.BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
            dgvStudentSeats.ForeColor = ColorTranslator.FromHtml("#212121");

            // Set the Random button color and text color
            btnRan.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnRan.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            // Set the Clear button color and text color
            btnClear.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnClear.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            // Set the Menu button color and text color
            btnMain.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnMain.ForeColor = ColorTranslator.FromHtml("#F2F2F2");


            database.loadDataGridView20(dgvStudentSeats);

            database.PopulateStudentListBox(lstStudentsAvailable);
        }

        private void btnRan_Click(object sender, EventArgs e)
        {
            // Set the Random button color and text color
            btnRan.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnRan.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            Random random = new Random();
            DataTable dttable = (DataTable)dgvStudentSeats.DataSource;

            // Create a new DataTable with the same structure as the original one
            DataTable shuffledTable = dttable.Clone();

            // Shuffle the rows
            DataRow[] rows = dttable.Select();
            for (int i = rows.Length - 1; i >= 0; i--)
            {
                int j = random.Next(i + 1);
                DataRow row = rows[j];
                rows[j] = rows[i];
                rows[i] = row;

                // Add the shuffled row to the new DataTable
                shuffledTable.ImportRow(row);
            }

            // Set the shuffled DataTable as the new DataSource of the DataGridView
            dgvStudentSeats.DataSource = shuffledTable;
        }

        private void dgvStudentSeats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
