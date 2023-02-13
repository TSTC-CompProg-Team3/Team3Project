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

namespace Team3Project_Fixed
{
    public partial class frmSeatingChart20 : Form
    {
        public frmSeatingChart20()
        {
            InitializeComponent();
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
    }
}
