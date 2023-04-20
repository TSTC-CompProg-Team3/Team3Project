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
    public partial class frmAddCourse : Form
    {
        public frmAddCourse()
        {
            InitializeComponent();
        }

        private void frmAddCourse_Load(object sender, EventArgs e)
        {
            clsDatabaseHandler.AddCourseLoad(cbxTeacherID, cbxSubjectID, cbxClassSize);
            

            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            btnClear.BackColor = ColorTranslator.FromHtml("#F15025");
            btnClear.ForeColor = ColorTranslator.FromHtml("#191919");
            btnSubmit.BackColor = ColorTranslator.FromHtml("#F15025");
            btnSubmit.ForeColor = ColorTranslator.FromHtml("#191919");
            btnBack.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBack.ForeColor = ColorTranslator.FromHtml("#191919");
            lblClassName.ForeColor = ColorTranslator.FromHtml("#191919");
            lblTeacherID.ForeColor = ColorTranslator.FromHtml("#191919");
            lblSubjectID.ForeColor = ColorTranslator.FromHtml("#191919");
            lblClassSize.ForeColor = ColorTranslator.FromHtml("#191919");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxClassSize.SelectedIndex = 0;
            cbxSubjectID.SelectedIndex = 0;
            cbxTeacherID.SelectedIndex = 0;
            tbxClassName.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateCourseName(tbxClassName.Text))
            {
                clsDatabaseHandler.AddCourse(tbxClassName, cbxTeacherID, cbxSubjectID, cbxClassSize);
                lblClassNameWarning.Visible = false;
                this.Close();
            }
            else
            {
                tbxClassName.BackColor = Color.Red;
                lblClassNameWarning.Visible = true;
            }



        }

        private void tbxClassName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidation.ValidateString(e.KeyChar);
        }
    }
}
