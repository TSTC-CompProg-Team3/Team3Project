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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateEmail(tbxEmail.Text) && clsValidation.ValidateUsername(tbxUsername.Text) && 
                clsValidation.ValidatePassword(tbxPassword.Text) && clsValidation.ValidateFirstName(tbxFirstName.Text) &&
                clsValidation.ValidateLastName(tbxLastName.Text) && clsValidation.ValidatePhoneNumber(tbxPhoneNumber.Text) && 
                clsValidation.ValidateMiddleName(tbxMiddleName.Text) && clsValidation.ValidateAddress(tbxStreetAddress.Text) &&
                clsValidation.ValidateAddress(tbxMailingAddress.Text) && clsValidation.ValidateCity(tbxCity.Text) && 
                clsValidation.ValidateState(tbxState.Text) && clsValidation.ValidateZip(tbxZip.Text) && 
                clsValidation.ValidateFullName(tbxEmerContactName.Text) && clsValidation.ValidatePhoneNumber(tbxEmerContactPhone.Text) &&
                clsValidation.ValidateFullName(tbxGuardianName.Text) && clsValidation.ValidatePhoneNumber(tbxGuardianCell.Text) &&
                clsValidation.ValidatePhoneNumber(tbxGuardianWork.Text) && clsValidation.ValidateWorkPlace(tbxGuardianWorkPl.Text))
            {
                tbxState.Text = tbxState.Text.ToUpper();
                clsDatabaseHandler.AddStudent(tbxFirstName, tbxMiddleName, tbxLastName, dtpDateOfBirth, tbxPhoneNumber, tbxMailingAddress, tbxStreetAddress,
                tbxCity, tbxState, tbxZip, tbxEmail, tbxUsername, tbxPassword, tbxEmerContactName, tbxEmerContactPhone, tbxGuardianName, tbxGuardianCell,
                tbxGuardianWork, tbxGuardianWorkPl);
            }
            else
            {
                if (!clsValidation.ValidateEmail(tbxEmail.Text))
                {
                    tbxEmail.BackColor = Color.Red;
                }
                else
                {
                    tbxEmail.BackColor = SystemColors.Window;
                }

                if (!clsValidation.ValidateUsername(tbxUsername.Text))
                {
                    tbxUsername.BackColor = Color.Red;
                }
                else
                {
                    tbxUsername.BackColor = SystemColors.Window;
                }

                if (!clsValidation.ValidatePassword(tbxPassword.Text))
                {
                    tbxPassword.BackColor = Color.Red;
                }
                else
                {
                    tbxPassword.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateFirstName(tbxFirstName.Text))
                {
                    tbxFirstName.BackColor = Color.Red;
                }
                else
                {
                    tbxFirstName.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateLastName(tbxLastName.Text))
                {
                    tbxLastName.BackColor = Color.Red;
                }
                else
                {
                    tbxLastName.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidatePhoneNumber(tbxPhoneNumber.Text))
                {
                    tbxPhoneNumber.BackColor = Color.Red;
                }
                else
                {
                    tbxPhoneNumber.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateMiddleName(tbxMiddleName.Text))
                {
                    tbxMiddleName.BackColor = Color.Red;
                }
                else
                {
                    tbxMiddleName.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateAddress(tbxMailingAddress.Text))
                {
                    tbxMailingAddress.BackColor = Color.Red;
                }
                else
                {
                    tbxMailingAddress.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateAddress(tbxStreetAddress.Text))
                {
                    tbxStreetAddress.BackColor = Color.Red;
                }
                else
                {
                    tbxStreetAddress.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateCity(tbxCity.Text))
                {
                    tbxCity.BackColor = Color.Red;
                }else
                {
                    tbxCity.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateState(tbxState.Text))
                {
                    tbxState.BackColor = Color.Red;
                }
                else
                {
                    tbxState.Text = tbxState.Text.ToUpper();
                    tbxState.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateZip(tbxZip.Text))
                {
                    tbxZip.BackColor = Color.Red;
                }
                else
                {
                    tbxZip.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateFullName(tbxEmerContactName.Text))
                {
                    tbxEmerContactName.BackColor = Color.Red;
                }
                else
                {
                    tbxEmerContactName.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidatePhoneNumber(tbxEmerContactPhone.Text))
                {
                    tbxEmerContactPhone.BackColor = Color.Red;
                }
                else
                {
                    tbxEmerContactPhone.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateFullName(tbxGuardianName.Text))
                {
                    tbxGuardianName.BackColor = Color.Red;
                }
                else
                {
                    tbxGuardianName.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidatePhoneNumber(tbxGuardianCell.Text))
                {
                    tbxGuardianCell.BackColor = Color.Red;
                }
                else
                {
                    tbxGuardianCell.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidatePhoneNumber(tbxGuardianWork.Text))
                {
                    tbxGuardianWork.BackColor = Color.Red;
                }
                else
                {
                    tbxGuardianWork.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateWorkPlace(tbxGuardianWorkPl.Text))
                {
                    tbxGuardianWorkPl.BackColor = Color.Red;
                }
                else
                {
                    tbxGuardianWorkPl.BackColor = SystemColors.Window;
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
    }
}
