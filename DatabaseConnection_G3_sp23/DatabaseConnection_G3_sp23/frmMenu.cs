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
            clsDatabaseHandler.LoadMenu(cbxCourseSelect, loginID);
            
            //Makes admin button visible if user is admin (Levels of Security) -CS
            switch (accountType)
            {
                case "Officer":
                    btnOfficer.Visible = true;
                    break;

                case "Admin":
                    btnAdmin.Visible = true;
                    // Load classes from all the teacher database
                    clsDatabaseHandler.LoadAdminMenu(cbxCourseSelect, 0);
                    break;

                case "Teacher":
                    btnAdmin.Visible = false;
                    btnOfficer.Visible = false;
                    break;

                case "student":
                    btnAdmin.Visible = false;
                    btnOfficer.Visible = false;
                    break;

                default:
                    break;
            }

            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            btnGradeBook.BackColor = ColorTranslator.FromHtml("#F15025");
            btnGradeBook.ForeColor = ColorTranslator.FromHtml("#191919");
            btnAttendance.BackColor = ColorTranslator.FromHtml("#F15025");
            btnAttendance.ForeColor = ColorTranslator.FromHtml("#191919");
            btnSeatingChart.BackColor = ColorTranslator.FromHtml("#F15025");
            btnSeatingChart.ForeColor = ColorTranslator.FromHtml("#191919");
            btnLogOut.BackColor = ColorTranslator.FromHtml("#F15025");
            btnLogOut.ForeColor = ColorTranslator.FromHtml("#191919");
            btnAdmin.BackColor = ColorTranslator.FromHtml("#F15025");
            btnAdmin.ForeColor = ColorTranslator.FromHtml("#191919");
            btnOfficer.BackColor = ColorTranslator.FromHtml("#F15025");
            btnOfficer.ForeColor = ColorTranslator.FromHtml("#191919");

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //goes to admin menu -CS
            frmAdminMenu adminMenu = new frmAdminMenu(loginID, accountType);
            adminMenu.ShowDialog();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnGradeBook_Click(object sender, EventArgs e)
        {
            frmGradebook gradebook = new frmGradebook();
            gradebook.ShowDialog();
        }

        private void btnSeatingChart_Click(object sender, EventArgs e)
        {
            if (cbxCourseSelect.Items.Count > 0)
            {
                string hold = cbxCourseSelect.Text.ToString();
                string[] holdSplit = hold.Split(':');
                string holdTrim = holdSplit[1].Trim();
                int classSize = int.Parse(holdTrim);

                switch (classSize)
                {
                    case 5:
                        frmSeatingChart5 chart5 = new frmSeatingChart5();
                        chart5.ShowDialog();
                        break;

                    case 10:
                        frmSeatingChart10 chart10 = new frmSeatingChart10();
                        chart10.ShowDialog();
                        break;

                    case 20:
                        frmSeatingChart20 chart20 = new frmSeatingChart20();
                        chart20.ShowDialog();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Officer and Admin Functionality are under construction", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void btnOfficer_Click(object sender, EventArgs e)
        {
            //goes to admin menu -CS
            frmOfficerMenu officerMenu = new frmOfficerMenu(loginID, accountType);
            officerMenu.ShowDialog();
        }

    }
}
