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
        public int studentID;
        public string accountType;
        DatabaseConnection database = new DatabaseConnection();
       public DataGridView grade= new DataGridView();
        public frmGradebook(int loginid,int studentID, string accounttype)
        {
            loginID = loginid;
            this.studentID = studentID;
            accountType = accounttype;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public int dgvcounter;

        CurrencyManager  NameManager;
        private void frmGradebook_Load(object sender, EventArgs e)
        {
            /*            database.getHomework(lblID.Text, lblHomework);
                        database.displayGrade(lblTotal);*/

            /*            database.getFinal(lblID.Text);
                        database.getTest(lblID.Text);
                        database.getLab(lblID.Text);
                        database.getParticipation(lblID.Text);*/
            switch (accountType.ToLower())
            {
                case "officer":
                    btnRemove.Visible = true;
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;
                    DatabaseConnection.GradeBookDataGrid(dgvGradeBook, lblID.Text);
                    DatabaseConnection.MidTermGName(tbxName, lblID);
                    break;

                case "admin":
                    btnRemove.Visible = true;
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;
                    DatabaseConnection.GradeBookDataGrid(dgvGradeBook, lblID.Text);
                    DatabaseConnection.MidTermGName(tbxName, lblID);
                    break;

                case "teacher":
                    btnRemove.Visible = true;
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;
                    DatabaseConnection.GradeBookDataGrid(dgvGradeBook, lblID.Text);
                    DatabaseConnection.MidTermGName(tbxName, lblID);
                    break;
                case "student":
                    btnRemove.Visible = false;
                    btnEdit.Visible = false;
                    btnAdd.Visible = false;
                    btnNext.Visible = false;
                    btnPrev.Visible = false;
                    DatabaseConnection.GradeBookDataGridStudent(dgvGradeBook, studentID);
                    DatabaseConnection.MidTermGNameStudent(tbxName, loginID);

                    break;
                default:
                    break;
            }

            grade = dgvGradeBook;

            NameManager = (CurrencyManager)this.BindingContext[DatabaseConnection._nameeTable];

        }


        private void btnNext_Click(object sender, EventArgs e)
        {

            NameManager.Position++;
            DatabaseConnection.GradeBookDataGrid(dgvGradeBook, lblID.Text);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

            NameManager.Position--;
            DatabaseConnection.GradeBookDataGrid(dgvGradeBook, lblID.Text);
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
                DatabaseConnection.RemoveGradeBook(dgvGradeBook,lblID.Text);
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
