using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Team3MiddleSchool
{
    public partial class frmGradebook : Form
    {
        public int loginID;
        public string accountType;
        DatabaseConnection database = new DatabaseConnection();
       public DataGridView grade= new DataGridView();
        public frmGradebook(int loginid, string accounttype)
        {
            loginID = loginid;
            accountType = accounttype;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int dgvcounter = 1;

        private void frmGradebook_Load(object sender, EventArgs e)
        {
            switch (accountType.ToLower())
            {
                case "officer":
                    btnRemove.Visible = true;
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;
                    break;

                case "admin":
                    btnRemove.Visible = true;
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;
                    break;

                case "teacher":
                    btnRemove.Visible = true;
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;
                    break;
                case "student":
                    btnRemove.Visible = false;
                    btnEdit.Visible = false;
                    btnAdd.Visible = false;
                    break;
                default:
                    break;
            }
            grade = dgvGradeBook;
            DatabaseConnection.GradeBookDataGrid(dgvGradeBook, dgvcounter);
/*            database.GradeCalculations(lblTotal);*/
            DatabaseConnection.MidTermGName(tbxName);
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            dgvcounter++;
            DatabaseConnection.GradeBookDataGrid(dgvGradeBook, dgvcounter);
            database.Next(tbxName);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            dgvcounter--;
            DatabaseConnection.GradeBookDataGrid(dgvGradeBook, dgvcounter);
            database.Previous(tbxName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddGradebook frmAddGradebook = new frmAddGradebook(this);
            frmAddGradebook.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult confrimation = MessageBox.Show("Are you Sure you Want to Remove this Grade?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confrimation == DialogResult.No)
            {

            }
            else
            {
                DatabaseConnection.RemoveGradeBook(dgvGradeBook, dgvcounter);
                MessageBox.Show("Grade Removed");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //frmEditGradebook frmEditGradebook = new frmEditGradebook(this);
            //frmEditGradebook.Show();
        }

        private void btnMidterm_Click(object sender, EventArgs e)
        {
            frmMidTermG midterm = new frmMidTermG();
            midterm.ShowDialog();
        }

      
    }
}
