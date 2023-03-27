
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
    public partial class frmAddGradebook : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        frmGradebook mainGradbook;
        public frmAddGradebook(frmGradebook grade)
        {
            InitializeComponent();
            mainGradbook = grade;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult confrimation = MessageBox.Show("Would You like to Add Another Grade?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confrimation == DialogResult.Yes)
            {
                DatabaseConnection.AddGradeBook(mainGradbook.dgvcounter, tbxAssignName, tbxAssignType, tbxGrade);

            }
            else
            {
                DatabaseConnection.AddGradeBook(mainGradbook.dgvcounter, tbxAssignName, tbxAssignType, tbxGrade);
                MessageBox.Show("Grade Added");
                this.Hide();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
