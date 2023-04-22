using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Team3MiddleSchool
{
    public partial class frmMenu : Form
    {
        public int studentID;
        public int loginID;
        public string accountType;
        public frmMenu(int loginid,string accounttype)
        {
            loginID = loginid;
            accountType = accounttype;
            InitializeComponent();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            //opens form attendance - CS
            string classSelect = cbxCourseSelect.SelectedItem as string;
            bool isStudent = true;

            if (accountType.Equals("Teacher") || accountType.Equals("Admin") || accountType.Equals("Officer"))
            {
                isStudent = false;
            }
            else if (accountType.Equals("Student") || accountType.Equals("Parent"))
            {
                isStudent = true;
            }

            frmAttendance frmAttendance = new frmAttendance(loginID, accountType, classSelect, isStudent);
            frmAttendance.ShowDialog();
        }

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            //closes this form - Might decide to clear frmLogin textboxes -CS
            this.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
            //Makes admin button visible if user is admin (Levels of Security) -CS
            switch (accountType)
            {
                case "Officer":
                    btnOfficer.Visible = true;

                    btnAssignClass.Visible = true;

                    clsDatabaseHandler.LoadAdminOfficer(cbxCourseSelect);

                    break;

                case "Admin":
                    btnAdmin.Visible = true;

                    btnAssignClass.Visible = true;

                    clsDatabaseHandler.LoadAdminOfficer(cbxCourseSelect);

                    break;

                case "Teacher":
                    btnAdmin.Visible = false;
                    btnOfficer.Visible = false;
                    clsDatabaseHandler.LoadMenu(cbxCourseSelect, loginID);
                    break;

                case "student":
                    btnAdmin.Visible = false;
                    btnOfficer.Visible = false;
                    
                    btnAttendance.Visible = false;
                    clsDatabaseHandler.LoadStudentMenu(cbxCourseSelect, loginID);
                    studentID = clsDatabaseHandler.GetStudentID(loginID);

                    // Change the location of the logout button and seating chart
                    // Move the button up by 150 pixels
                    btnSeatingChart.Location = new Point(btnSeatingChart.Location.X, btnSeatingChart.Location.Y - 90);
                    // Move the button up by 75 pixels
                    btnReturnToLogin.Location = new Point(btnReturnToLogin.Location.X, btnReturnToLogin.Location.Y - 75);

                    break;

                case "Parent":
                    btnAdmin.Visible = false;
                    btnOfficer.Visible = false;
                    clsDatabaseHandler.LoadParentMenu(cbxCourseSelect, loginID);
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
            btnReturnToLogin.BackColor = ColorTranslator.FromHtml("#F15025");
            btnReturnToLogin.ForeColor = ColorTranslator.FromHtml("#191919");
            btnAdmin.BackColor = ColorTranslator.FromHtml("#F15025");
            btnAdmin.ForeColor = ColorTranslator.FromHtml("#191919");
            btnOfficer.BackColor = ColorTranslator.FromHtml("#F15025");
            btnOfficer.ForeColor = ColorTranslator.FromHtml("#191919");
            btnAssignClass.BackColor = ColorTranslator.FromHtml("#F15025");
            btnAssignClass.ForeColor = ColorTranslator.FromHtml("#191919");

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
            string classSelect = cbxCourseSelect.SelectedItem as string;
            frmGradebook gradebook = new frmGradebook(loginID,classSelect,accountType);
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
                        frmSeatingChart5 chart5 = new frmSeatingChart5(cbxCourseSelect.SelectedIndex);
                        chart5.ShowDialog();
                        break;

                    case 10:
                        frmSeatingChart10 chart10 = new frmSeatingChart10(cbxCourseSelect.SelectedIndex);
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

        private void btnAssignClass_Click(object sender, EventArgs e)
        {
            frmAssignClasses assignClasses = new frmAssignClasses();
            assignClasses.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp("menu.html");
            help.ShowDialog();
        }
    }
}
