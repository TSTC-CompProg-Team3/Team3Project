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
            string hold = parentInfo;
            string[] holdSplit = hold.Split('-');
            string parentID = holdSplit[0].Trim();
            clsDatabaseHandler.EditParent(tbxEmail, tbxFirstName, tbxLastName, tbxPassword, tbxUsername, cbxStudentSelect, parentID);
        }
    }
}
