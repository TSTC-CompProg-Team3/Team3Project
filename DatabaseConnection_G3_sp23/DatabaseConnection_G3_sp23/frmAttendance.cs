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
    public partial class frmAttendance : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        private BindingSource binding = new BindingSource();
        public frmAttendance()
        {
            InitializeComponent();
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            database.OpenDatabase();
            binding.DataSource = database.AttendanceInfo();
            dgvAttendance.DataSource = binding;
        }

        private void dgvAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //DGV Column header names
            dgvAttendance.Columns[0].HeaderCell.Value = "Student";
            dgvAttendance.Columns[1].HeaderCell.Value = "Student ID";
            dgvAttendance.Columns[2].HeaderCell.Value = "Class ID";
            dgvAttendance.Columns[3].HeaderCell.Value = "Date";

            //Loop and style each column
            foreach (DataGridViewColumn col in dgvAttendance.Columns)
            {
                col.Width = 220;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnBackAttend_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditAttend_Click(object sender, EventArgs e)
        {
            frmAttendanceEdit edit = new frmAttendanceEdit();
            edit.ShowDialog();
        }
    }
}
