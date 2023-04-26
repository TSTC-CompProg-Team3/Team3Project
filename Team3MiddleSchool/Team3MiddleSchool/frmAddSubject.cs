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
    public partial class frmAddSubject : Form
    {
        public frmAddSubject()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxSubjectName.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateSubject(tbxSubjectName.Text))
            {
                clsDatabaseHandler.AddSubject(tbxSubjectName.Text);
                lblSubjectWarning.Visible = false;
                this.Close();
            }
            else
            {
                tbxSubjectName.BackColor = Color.Red;
                lblSubjectWarning.Visible = true;
            }
            
        }

        private void frmAddSubject_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            btnClear.BackColor = ColorTranslator.FromHtml("#F15025");
            btnClear.ForeColor = ColorTranslator.FromHtml("#191919");
            btnSubmit.BackColor = ColorTranslator.FromHtml("#F15025");
            btnSubmit.ForeColor = ColorTranslator.FromHtml("#191919");
            btnBack.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBack.ForeColor = ColorTranslator.FromHtml("#191919");
            mnuStrip.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            mnuStrip.ForeColor = ColorTranslator.FromHtml("#191919");
        }

        private void tbxSubjectName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidation.ValidateString(e.KeyChar);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("addSubject.html");
        }
    }
}
