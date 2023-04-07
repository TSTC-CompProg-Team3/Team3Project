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
            if (clsValidation.ValidateEmail(tbxEmail.Text) && clsValidation.ValidateUsernameEdit(tbxUsername.Text) &&
               clsValidation.ValidatePassword(tbxPassword.Text) && clsValidation.ValidateFirstName(tbxFirstName.Text) &&
               clsValidation.ValidateLastName(tbxLastName.Text))
            {
                string hold = parentInfo;
                string[] holdSplit = hold.Split('-');
                string parentID = holdSplit[0].Trim();
                clsDatabaseHandler.EditParent(tbxEmail, tbxFirstName, tbxLastName, tbxPassword, tbxUsername, cbxStudentSelect, parentID);
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
            }

            
        }
    }
}
