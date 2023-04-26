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
    public partial class frmEditParent : Form
    {
        string parentInfo;
        public frmEditParent(string parentInfo)
        {
            this.parentInfo = parentInfo;
            InitializeComponent();
        }

        private void frmEditParent_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            btnBack.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBack.ForeColor = ColorTranslator.FromHtml("#191919");
            btnClear.BackColor = ColorTranslator.FromHtml("#F15025");
            btnClear.ForeColor = ColorTranslator.FromHtml("#191919");
            btnSubmit.BackColor = ColorTranslator.FromHtml("#F15025");
            btnSubmit.ForeColor = ColorTranslator.FromHtml("#191919");
            lblFirstName.ForeColor = ColorTranslator.FromHtml("#191919");
            lblLastName.ForeColor = ColorTranslator.FromHtml("#191919");
            lblEmail.ForeColor = ColorTranslator.FromHtml("#191919");
            lblUsername.ForeColor = ColorTranslator.FromHtml("#191919");
            lblPassword.ForeColor = ColorTranslator.FromHtml("#191919");
            lblAssignStudent.ForeColor = ColorTranslator.FromHtml("#191919");
            mnuStrip.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            mnuStrip.ForeColor = ColorTranslator.FromHtml("#191919");


            string hold = parentInfo;
            string[] holdSplit = hold.Split('-');
            string parentID = holdSplit[0].Trim();
            clsDatabaseHandler.LoadEditParent(tbxEmail, tbxFirstName, tbxLastName, tbxPassword, tbxUsername, cbxStudentSelect, parentID);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxEmail.Clear();
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxPassword.Clear();
            tbxUsername.Clear();
            cbxStudentSelect.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateEmail(tbxEmail.Text) && clsValidation.ValidateUsername(tbxUsername.Text) &&
                clsValidation.ValidatePassword(tbxPassword.Text) && clsValidation.ValidateFirstName(tbxFirstName.Text) &&
                clsValidation.ValidateLastName(tbxLastName.Text) && cbxStudentSelect.Text != "")
            {
                string hold = parentInfo;
                string[] holdSplit = hold.Split('-');
                string parentID = holdSplit[0].Trim();
                clsDatabaseHandler.EditParent(tbxEmail, tbxFirstName, tbxLastName, tbxPassword, tbxUsername, cbxStudentSelect, parentID);
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
                    lblNameWarning.Visible = true;
                }
                else
                {
                    tbxFirstName.BackColor = SystemColors.Window;
                    lblNameWarning.Visible = false;
                }
                if (!clsValidation.ValidateLastName(tbxLastName.Text))
                {
                    tbxLastName.BackColor = Color.Red;
                    lblNameWarning.Visible = true;
                }
                else
                {
                    tbxLastName.BackColor = SystemColors.Window;
                    lblNameWarning.Visible = false;
                }
                if (cbxStudentSelect.Text == "")
                {
                    cbxStudentSelect.BackColor = Color.Red;
                    lblAssignStudentWarning.Visible = true;
                }
                else
                {
                    cbxStudentSelect.BackColor = SystemColors.Window;
                    lblAssignStudentWarning.Visible = false;
                }


            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("editParent.html");
        }
    }
}
