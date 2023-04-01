using Team3MiddleSchool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team3MiddleSchool
{
    public partial class frmEditGradebook : Form
    {
        clsDatabaseConnection database = new clsDatabaseConnection();
        frmGradebook mainGradbook;

        public frmEditGradebook(frmGradebook grade)
        {
            InitializeComponent();
            mainGradbook = grade;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            clsDatabaseConnection.EditGradeBook(mainGradbook.grade, mainGradbook.dgvcounter, tbxAssignName, tbxAssignType, tbxGrade);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
