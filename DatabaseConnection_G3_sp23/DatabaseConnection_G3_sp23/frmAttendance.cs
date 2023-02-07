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
        public frmAttendance()
        {
            InitializeComponent();
        }

        public void SetupDataGrid()
        {
            dgvAttendance.Name = "Attendance";
            dgvAttendance.Columns[0].Name = "Student";
            dgvAttendance.Columns[1].Name = "Date";
            dgvAttendance.Columns[2].Name = "Attendance";
        }
    }
}
