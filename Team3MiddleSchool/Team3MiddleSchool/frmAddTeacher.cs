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
    public partial class frmAddTeacher : Form
    {
        public frmAddTeacher()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxEmail.Clear();
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxPassword.Clear();
            tbxUsername.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clsDatabaseHandler.AddTeacher(tbxFirstName,tbxLastName,tbxEmail,tbxUsername,tbxPassword);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddTeacher_Load(object sender, EventArgs e)
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
        }
    }
}
