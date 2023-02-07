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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            //opens form attendance - CS
            frmAttendance frmAttendance = new frmAttendance();
            frmAttendance.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //closes this form - Might decide to clear frmLogin textboxes -CS
            this.Close();
        }
    }
}
