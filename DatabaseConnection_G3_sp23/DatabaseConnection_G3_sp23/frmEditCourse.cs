using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection_G3_sp23
{
    public partial class frmEditCourse : Form
    {
        public string courseID;
        public frmEditCourse(string courseID)
        {
            this.courseID = courseID;
            InitializeComponent();
        }

        private void frmEditCourse_Load(object sender, EventArgs e)
        {
            clsDatabaseHandler.LoadEditCourse(courseID, tbxClassID, cbxTeacherID, cbxSubjectID, cbxClassSize);
            

            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            btnClear.BackColor = ColorTranslator.FromHtml("#F15025");
            btnClear.ForeColor = ColorTranslator.FromHtml("#191919");
            btnSubmit.BackColor = ColorTranslator.FromHtml("#F15025");
            btnSubmit.ForeColor = ColorTranslator.FromHtml("#191919");
            btnBack.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBack.ForeColor = ColorTranslator.FromHtml("#191919");
            lblClassID.ForeColor = ColorTranslator.FromHtml("#191919");
            lblTeacherID.ForeColor = ColorTranslator.FromHtml("#191919");
            lblSubjectID.ForeColor = ColorTranslator.FromHtml("#191919");
            lblClassSize.ForeColor = ColorTranslator.FromHtml("#191919");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxClassSize.Text = string.Empty;
            cbxSubjectID.Text = string.Empty;
            cbxTeacherID.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clsDatabaseHandler.EditCourse(tbxClassID, cbxTeacherID, cbxSubjectID, cbxClassSize);

        }
    }
}
