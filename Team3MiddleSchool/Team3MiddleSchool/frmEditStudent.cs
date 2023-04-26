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
            cbxState.SelectedItem = null;
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
            mnuStrip.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            mnuStrip.ForeColor = ColorTranslator.FromHtml("#191919");

            string hold = studentInfo;
            string[] holdSplit = hold.Split('-');
            string studentID = holdSplit[0].Trim();
            clsDatabaseHandler.LoadEditStudent(studentID, tbxFirstName, tbxMiddleName, tbxLastName, dtpDateOfBirth, tbxPhoneNumber, tbxMailingAddress, tbxStreetAddress,
                tbxCity, cbxState, tbxZip, tbxEmail, tbxUsername, tbxPassword, tbxEmerContactName, tbxEmerContactPhone, tbxGuardianName, tbxGuardianCell,
                tbxGuardianWork, tbxGuardianWorkPl);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateEmail(tbxEmail.Text) && clsValidation.ValidateUsername(tbxUsername.Text) &&
                clsValidation.ValidatePassword(tbxPassword.Text) && clsValidation.ValidateFirstName(tbxFirstName.Text) &&
                clsValidation.ValidateLastName(tbxLastName.Text) && clsValidation.ValidatePhoneNumber(tbxPhoneNumber.Text) &&
                clsValidation.ValidateMiddleName(tbxMiddleName.Text) && clsValidation.ValidateAddress(tbxStreetAddress.Text) &&
                clsValidation.ValidateAddress(tbxMailingAddress.Text) && clsValidation.ValidateCity(tbxCity.Text) &&
                clsValidation.ValidateState(cbxState.Text) && clsValidation.ValidateZip(tbxZip.Text) &&
                clsValidation.ValidateFullName(tbxEmerContactName.Text) && clsValidation.ValidatePhoneNumber(tbxEmerContactPhone.Text) &&
                clsValidation.ValidateFullName(tbxGuardianName.Text) && clsValidation.ValidatePhoneNumber(tbxGuardianCell.Text) &&
                clsValidation.ValidatePhoneNumber(tbxGuardianWork.Text) && clsValidation.ValidateWorkPlace(tbxGuardianWorkPl.Text))
            {
                string hold = studentInfo;
                string[] holdSplit = hold.Split('-');
                string studentID = holdSplit[0].Trim();
                clsDatabaseHandler.EditStudent(studentID, tbxFirstName, tbxMiddleName, tbxLastName, dtpDateOfBirth, tbxPhoneNumber, tbxMailingAddress, tbxStreetAddress,
                tbxCity, cbxState, tbxZip, tbxEmail, tbxUsername, tbxPassword, tbxEmerContactName, tbxEmerContactPhone, tbxGuardianName, tbxGuardianCell,
                tbxGuardianWork, tbxGuardianWorkPl);
                lblPasswordWarning.Visible = false;
                lblNameWarning1.Visible = false;
                lblEmailWarning.Visible = false;
                lblCityWarning.Visible = false;
                lblPhoneNumberWarning1.Visible = false;
                lblPhoneNumberWarning2.Visible = false;
                lblPhoneNumberWarning3.Visible = false;
                lblPhoneNumberWarning4.Visible = false;
                lblAddressWarning.Visible = false;
                lblZipWarning.Visible = false;
                lblUsernameWarning.Visible = false;
                this.Close();
            }
            else
            {
                if (!clsValidation.ValidateEmail(tbxEmail.Text))
                {
                    tbxEmail.BackColor = Color.Red;
                    lblEmailWarning.Visible = true;
                }
                else
                {
                    tbxEmail.BackColor = SystemColors.Window;
                    lblEmailWarning.Visible = false;
                }

                if (!clsValidation.ValidateUsername(tbxUsername.Text))
                {
                    tbxUsername.BackColor = Color.Red;
                    lblUsernameWarning.Visible = true;
                }
                else
                {
                    tbxUsername.BackColor = SystemColors.Window;
                    lblUsernameWarning.Visible = false;
                }

                if (!clsValidation.ValidatePassword(tbxPassword.Text))
                {
                    tbxPassword.BackColor = Color.Red;
                    lblPasswordWarning.Visible = true;
                }
                else
                {
                    tbxPassword.BackColor = SystemColors.Window;
                    lblPasswordWarning.Visible = false;
                }
                if (!clsValidation.ValidateFirstName(tbxFirstName.Text))
                {
                    tbxFirstName.BackColor = Color.Red;
                    lblNameWarning1.Visible = true;
                }
                else
                {
                    tbxFirstName.BackColor = SystemColors.Window;
                    lblNameWarning1.Visible = false;
                }
                if (!clsValidation.ValidateLastName(tbxLastName.Text))
                {
                    tbxLastName.BackColor = Color.Red;
                    lblNameWarning1.Visible = true;
                }
                else
                {
                    tbxLastName.BackColor = SystemColors.Window;
                    lblNameWarning1.Visible = false;
                }
                if (!clsValidation.ValidatePhoneNumber(tbxPhoneNumber.Text))
                {
                    tbxPhoneNumber.BackColor = Color.Red;
                    lblPhoneNumberWarning1.Visible = true;
                }
                else
                {
                    tbxPhoneNumber.BackColor = SystemColors.Window;
                    lblPhoneNumberWarning1.Visible = false;
                }
                if (!clsValidation.ValidateMiddleName(tbxMiddleName.Text))
                {
                    tbxMiddleName.BackColor = Color.Red;
                    lblNameWarning1.Visible = true;
                }
                else
                {
                    tbxMiddleName.BackColor = SystemColors.Window;
                    lblNameWarning1.Visible = false;
                }
                if (!clsValidation.ValidateAddress(tbxMailingAddress.Text))
                {
                    tbxMailingAddress.BackColor = Color.Red;
                    lblAddressWarning.Visible = true;
                }
                else
                {
                    tbxMailingAddress.BackColor = SystemColors.Window;
                    lblAddressWarning.Visible = false;
                }
                if (!clsValidation.ValidateAddress(tbxStreetAddress.Text))
                {
                    tbxStreetAddress.BackColor = Color.Red;
                    lblAddressWarning.Visible = true;
                }
                else
                {
                    tbxStreetAddress.BackColor = SystemColors.Window;
                    lblAddressWarning.Visible = false;
                }
                if (!clsValidation.ValidateCity(tbxCity.Text))
                {
                    tbxCity.BackColor = Color.Red;
                    lblCityWarning.Visible = true;
                }
                else
                {
                    tbxCity.BackColor = SystemColors.Window;
                    lblCityWarning.Visible = false;
                }
                if (!clsValidation.ValidateState(cbxState.Text))
                {
                    cbxState.BackColor = Color.Red;
                }
                else
                {
                    cbxState.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateZip(tbxZip.Text))
                {
                    tbxZip.BackColor = Color.Red;
                    lblZipWarning.Visible = true;
                }
                else
                {
                    tbxZip.BackColor = SystemColors.Window;
                    lblZipWarning.Visible = false;
                }
                if (!clsValidation.ValidateFullName(tbxEmerContactName.Text))
                {
                    tbxEmerContactName.BackColor = Color.Red;
                    lblNameWarning2.Visible = true;
                }
                else
                {
                    tbxEmerContactName.BackColor = SystemColors.Window;
                    lblNameWarning2.Visible = false;
                }
                if (!clsValidation.ValidatePhoneNumber(tbxEmerContactPhone.Text))
                {
                    tbxEmerContactPhone.BackColor = Color.Red;
                    lblPhoneNumberWarning2.Visible = true;
                }
                else
                {
                    tbxEmerContactPhone.BackColor = SystemColors.Window;
                    lblPhoneNumberWarning2.Visible = false;
                }
                if (!clsValidation.ValidateFullName(tbxGuardianName.Text))
                {
                    tbxGuardianName.BackColor = Color.Red;
                    lblNameWarning3.Visible = true;
                }
                else
                {
                    tbxGuardianName.BackColor = SystemColors.Window;
                    lblNameWarning3.Visible = false;
                }
                if (!clsValidation.ValidatePhoneNumber(tbxGuardianCell.Text))
                {
                    tbxGuardianCell.BackColor = Color.Red;
                    lblPhoneNumberWarning3.Visible = true;
                }
                else
                {
                    tbxGuardianCell.BackColor = SystemColors.Window;
                    lblPhoneNumberWarning3.Visible = false;
                }
                if (!clsValidation.ValidatePhoneNumber(tbxGuardianWork.Text))
                {
                    tbxGuardianWork.BackColor = Color.Red;
                    lblPhoneNumberWarning4.Visible = true;
                }
                else
                {
                    tbxGuardianWork.BackColor = SystemColors.Window;
                    lblPhoneNumberWarning4.Visible = false;
                }
                if (!clsValidation.ValidateWorkPlace(tbxGuardianWorkPl.Text))
                {
                    tbxGuardianWorkPl.BackColor = Color.Red;
                    lblWorkplaceWarning.Visible = true;
                }
                else
                {
                    tbxGuardianWorkPl.BackColor = SystemColors.Window;
                    lblWorkplaceWarning.Visible = false;
                }
            }
        }

        private void tbxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidation.ValidateString(e.KeyChar);
        }

        private void tbxMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidation.ValidateString(e.KeyChar);
        }

        private void tbxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidation.ValidateString(e.KeyChar);
        }

        private void tbxEmerContactName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidation.ValidateString(e.KeyChar);
        }

        private void tbxGuardianName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidation.ValidateString(e.KeyChar);
        }

        private void tbxGuardianWorkPl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidation.ValidateString(e.KeyChar);
        }

        private void tbxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidation.ValidateString(e.KeyChar);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("editStudent.html");
        }
    }
}
