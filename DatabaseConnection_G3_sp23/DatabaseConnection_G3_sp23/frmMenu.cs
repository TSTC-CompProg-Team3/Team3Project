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
    public partial class frmMenu : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public int loginID;
        public string accountType;
        public frmMenu(int loginid, string accounttype)
        {
            loginID = loginid;
            accountType = accounttype;
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

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //gets subjects that teacher is teaching for the cbx -CS
            database.OpenDatabase(tssDatabaseConnection);
            frmLogin login = new frmLogin();
            database.TeacherClasses(loginID);

            foreach (string subject in database.classList)
            {
                cbxCourseSelect.Items.Add(subject);
            }

            cbxCourseSelect.SelectedIndex = 0;


            //Makes admin button visible if user is admin -CS
            if (accountType.Equals("Admin"))
            {
                btnAdmin.Visible = true;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //goes to admin menu -CS
            frmAdminMenu adminMenu = new frmAdminMenu();
            adminMenu.ShowDialog();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            database.CloseDatabase(tssDatabaseConnection);
        }
    }
}
