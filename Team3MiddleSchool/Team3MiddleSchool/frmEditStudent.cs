using Team3MiddleSchool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team3MiddleSchool
{
    public partial class frmEditStudent : Form
    {
        public string studentInfo;
        public frmEditStudent(string studentInfo)
        {
            this.studentInfo = studentInfo;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxFirstName.Clear();
            tbxMiddleName.Clear();
            tbxLastName.Clear();
            dtpDateOfBirth.ResetText();
            tbxPhoneNumber.Clear();
            tbxMailingAddress.Clear();
            tbxStreetAddress.Clear();
            tbxCity.Clear();
            tbxState.Clear();
            tbxZip.Clear();
            tbxEmail.Clear();
            tbxUsername.Clear();
            tbxPassword.Clear();
            tbxEmerContactName.Clear();
            tbxEmerContactPhone.Clear();
            tbxGuardianName.Clear();
            tbxGuardianCell.Clear();
            tbxGuardianWork.Clear();
            tbxGuardianWorkPl.Clear();
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            btnBack.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBack.ForeColor = ColorTranslator.FromHtml("#191919");
            btnClear.BackColor = ColorTranslator.FromHtml("#F15025");
            btnClear.ForeColor = ColorTranslator.FromHtml("#191919");
            btnSubmit.BackColor = ColorTranslator.FromHtml("#F15025");
            btnSubmit.ForeColor = ColorTranslator.FromHtml("#191919");
            lblFirstName.ForeColor = ColorTranslator.FromHtml("#191919");
            lblMiddleName.ForeColor = ColorTranslator.FromHtml("#191919");
            lblLastName.ForeColor = ColorTranslator.FromHtml("#191919");
            lblDateOfBirth.ForeColor = ColorTranslator.FromHtml("#191919");
            lblPhoneNumber.ForeColor = ColorTranslator.FromHtml("#191919");
            lblMailingAddress.ForeColor = ColorTranslator.FromHtml("#191919");
            lblStreetAddress.ForeColor = ColorTranslator.FromHtml("#191919");
            lblCity.ForeColor = ColorTranslator.FromHtml("#191919");
            lblState.ForeColor = ColorTranslator.FromHtml("#191919");
            lblZip.ForeColor = ColorTranslator.FromHtml("#191919");
            lblEmail.ForeColor = ColorTranslator.FromHtml("#191919");
            lblUsername.ForeColor = ColorTranslator.FromHtml("#191919");
            lblPassword.ForeColor = ColorTranslator.FromHtml("#191919");
            lblEmerContactName.ForeColor = ColorTranslator.FromHtml("#191919");
            lblEmerContactPhone.ForeColor = ColorTranslator.FromHtml("#191919");
            lblGuardianName.ForeColor = ColorTranslator.FromHtml("#191919");
            lblGuardianCell.ForeColor = ColorTranslator.FromHtml("#191919");
            lblGuardianWork.ForeColor = ColorTranslator.FromHtml("#191919");
            lblGuardianWorkPl.ForeColor = ColorTranslator.FromHtml("#191919");

            string hold = studentInfo;
            string[] holdSplit = hold.Split('-');
            string studentID = holdSplit[0].Trim();
            clsDatabaseHandler.LoadEditStudent(studentID, tbxFirstName, tbxMiddleName, tbxLastName, dtpDateOfBirth, tbxPhoneNumber, tbxMailingAddress, tbxStreetAddress,
                tbxCity, tbxState, tbxZip, tbxEmail, tbxUsername, tbxPassword, tbxEmerContactName, tbxEmerContactPhone, tbxGuardianName, tbxGuardianCell,
                tbxGuardianWork, tbxGuardianWorkPl);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string hold = studentInfo;
            string[] holdSplit = hold.Split('-');
            string studentID = holdSplit[0].Trim();
            clsDatabaseHandler.EditStudent(studentID, tbxFirstName, tbxMiddleName, tbxLastName, dtpDateOfBirth, tbxPhoneNumber, tbxMailingAddress, tbxStreetAddress,
                tbxCity, tbxState, tbxZip, tbxEmail, tbxUsername, tbxPassword, tbxEmerContactName, tbxEmerContactPhone, tbxGuardianName, tbxGuardianCell,
                tbxGuardianWork, tbxGuardianWorkPl);
        }
    }
}
