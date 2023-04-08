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
        public int parentID;
        public int classID;
        public string classSelect;
        public string accountType;
        DatabaseConnection database = new DatabaseConnection();
       public DataGridView grade= new DataGridView();
        public frmGradebook(int loginid,string classSelect,string accounttype)
        {
            this.classSelect = classSelect;
            loginID = loginid;
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
            studentID = database.GetStudentID(loginID);
            parentID = database.GradeParentID(loginID);
            classID = database.GetClassID(classSelect);
            switch (accountType.ToLower())
            {
                case "officer":
                    btnRemove.Visible = true;
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;
                    database.GradeBookDataGrid(dgvGradeBook, lblID.Text,classID);
                    database.MidTermGName(tbxName, lblID);
                    database.getHomework(lblID.Text, lblHomework, classID);
                    database.getQuiz(lblID.Text, lblQuiz, classID);
                    database.getTest(lblID.Text, lblTest, classID);
                    database.getLab(lblID.Text, lblLab, classID);
                    database.getParticipation(lblID.Text, lblParticipation, classID);


                    database.getHomeworkGrade(lblID.Text, classID);
                    database.getTestGrade(lblID.Text, classID);
                    database.getQuizGrade(lblID.Text, classID);
                    database.getFinalGrade(lblID.Text, classID);
                    database.getLabGrade(lblID.Text, classID);
                    database.getParticipationGrade(lblID.Text, classID);


                    database.getHomeworkCount(lblID.Text, classID);
                    database.getQuizCount(lblID.Text, classID);
                    database.getTestCount(lblID.Text, classID);
                    database.getLabCount(lblID.Text, classID);
                    database.getParticipationCount(lblID.Text, classID);
                    database.displayGrade(lblTotal);
                    break;

                case "admin":

                    btnRemove.Visible = true;
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;
                    database.GradeBookDataGrid(dgvGradeBook, lblID.Text, classID);
                    database.MidTermGName(tbxName, lblID);
                    database.getHomework(lblID.Text, lblHomework, classID);
                    database.getQuiz(lblID.Text, lblQuiz, classID);
                    database.getTest(lblID.Text, lblTest, classID);
                    database.getLab(lblID.Text, lblLab, classID);
                    database.getParticipation(lblID.Text, lblParticipation, classID);


                    database.getHomeworkGrade(lblID.Text, classID);
                    database.getTestGrade(lblID.Text, classID);
                    database.getQuizGrade(lblID.Text, classID);
                    database.getFinalGrade(lblID.Text, classID);
                    database.getLabGrade(lblID.Text, classID);
                    database.getParticipationGrade(lblID.Text, classID);


                    database.getHomeworkCount(lblID.Text, classID);
                    database.getQuizCount(lblID.Text, classID);
                    database.getTestCount(lblID.Text, classID);
                    database.getLabCount(lblID.Text, classID);
                    database.getParticipationCount(lblID.Text, classID);
                    database.displayGrade(lblTotal);
                    break;

                case "teacher":
                    btnRemove.Visible = true;
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;
                    database.GradeBookDataGrid(dgvGradeBook, lblID.Text, classID);
                    database.MidTermGName(tbxName, lblID);
                    database.getHomework(lblID.Text, lblHomework, classID);
                    database.getQuiz(lblID.Text, lblQuiz, classID);
                    database.getTest(lblID.Text, lblTest, classID);
                    database.getLab(lblID.Text, lblLab, classID);
                    database.getParticipation(lblID.Text, lblParticipation, classID);


                    database.getHomeworkGrade(lblID.Text, classID);
                    database.getTestGrade(lblID.Text, classID);
                    database.getQuizGrade(lblID.Text, classID);
                    database.getFinalGrade(lblID.Text, classID);
                    database.getLabGrade(lblID.Text, classID);
                    database.getParticipationGrade(lblID.Text, classID);


                    database.getHomeworkCount(lblID.Text, classID);
                    database.getQuizCount(lblID.Text, classID);
                    database.getTestCount(lblID.Text, classID);
                    database.getLabCount(lblID.Text, classID);
                    database.getParticipationCount(lblID.Text, classID);
                    database.displayGrade(lblTotal);
                    break;
                case "student":
                    btnRemove.Visible = false;
                    btnEdit.Visible = false;
                    btnAdd.Visible = false;
                    btnNext.Visible = false;
                    btnPrev.Visible = false;
                    database.GradeBookDataGridStudent(dgvGradeBook, studentID, classID);
                    database.MidTermGNameStudent(tbxName, loginID);
                    database.getHomework(studentID.ToString(), lblHomework, classID);
                    database.getQuiz(studentID.ToString(), lblQuiz, classID);
                    database.getTest(studentID.ToString(), lblTest, classID);
                    database.getLab(studentID.ToString(), lblLab, classID);
                    database.getParticipation(studentID.ToString(), lblParticipation, classID);

                    database.getHomeworkGrade(studentID.ToString(), classID);
                    database.getTestGrade(studentID.ToString(), classID);
                    database.getQuizGrade(studentID.ToString(), classID);
                    database.getFinalGrade(studentID.ToString(), classID);
                    database.getLabGrade(studentID.ToString(), classID);
                    database.getParticipationGrade(studentID.ToString(), classID);

                    database.getHomeworkCount(studentID.ToString(), classID);
                    database.getQuizCount(studentID.ToString(), classID);
                    database.getTestCount(studentID.ToString(), classID);
                    database.getLabCount(studentID.ToString(), classID);
                    database.getParticipationCount(studentID.ToString(), classID);
                    database.displayGrade(lblTotal);

                    break;
                case "parent":
                    
                    btnRemove.Visible = false;
                    btnEdit.Visible = false;
                    btnAdd.Visible = false;
                    btnNext.Visible = false;
                    btnPrev.Visible = false;
                    database.GradeBookDataGridParent(dgvGradeBook,parentID, classID);
                    database.MidTermGNameParent(tbxName, parentID);
                    database.getHomework(studentID.ToString(), lblHomework, classID);
                    database.getQuiz(studentID.ToString(), lblQuiz, classID);
                    database.getTest(studentID.ToString(), lblTest, classID);
                    database.getLab(studentID.ToString(), lblLab, classID);
                    database.getParticipation(studentID.ToString(), lblParticipation, classID);

                    database.getHomeworkGrade(studentID.ToString(), classID);
                    database.getTestGrade(studentID.ToString(), classID);
                    database.getQuizGrade(studentID.ToString(), classID);
                    database.getFinalGrade(studentID.ToString(), classID);
                    database.getLabGrade(studentID.ToString(), classID);
                    database.getParticipationGrade(studentID.ToString(), classID);

                    database.getHomeworkCount(studentID.ToString(), classID);
                    database.getQuizCount(studentID.ToString(), classID);
                    database.getTestCount(studentID.ToString(), classID);
                    database.getLabCount(studentID.ToString(), classID);
                    database.getParticipationCount(studentID.ToString(), classID);
                    database.displayGrade(lblTotal);



                    break;
                default:
                    break;
            }

            grade = dgvGradeBook;

            NameManager = (CurrencyManager)this.BindingContext[DatabaseConnection._nameeTable];

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            lblTotal.Text ="";

            NameManager.Position++;
            database.GradeBookDataGrid(dgvGradeBook, lblID.Text, classID);
            database.MidTermGName(tbxName, lblID);
            database.getHomework(lblID.Text, lblHomework, classID);
            database.getQuiz(lblID.Text, lblQuiz, classID);
            database.getTest(lblID.Text, lblTest, classID);
            database.getLab(lblID.Text, lblLab, classID);
            database.getParticipation(lblID.Text, lblParticipation, classID);


            database.getHomeworkGrade(lblID.Text, classID);
            database.getTestGrade(lblID.Text, classID);
            database.getQuizGrade(lblID.Text, classID);
            database.getFinalGrade(lblID.Text, classID);
            database.getLabGrade(lblID.Text, classID);
            database.getParticipationGrade(lblID.Text, classID);


            database.getHomeworkCount(lblID.Text, classID);
            database.getQuizCount(lblID.Text, classID);
            database.getTestCount(lblID.Text, classID);
            database.getLabCount(lblID.Text, classID);
            database.getParticipationCount(lblID.Text, classID);

            database.displayGrade(lblTotal);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "";

            NameManager.Position--;
            database.GradeBookDataGrid(dgvGradeBook, lblID.Text, classID);
            database.MidTermGName(tbxName, lblID);
            database.getHomework(lblID.Text, lblHomework, classID);
            database.getQuiz(lblID.Text, lblQuiz, classID);
            database.getTest(lblID.Text, lblTest, classID);
            database.getLab(lblID.Text, lblLab, classID);
            database.getParticipation(lblID.Text, lblParticipation, classID);


            database.getHomeworkGrade(lblID.Text, classID);
            database.getTestGrade(lblID.Text, classID);
            database.getQuizGrade(lblID.Text, classID);
            database.getFinalGrade(lblID.Text, classID);
            database.getLabGrade(lblID.Text, classID);
            database.getParticipationGrade(lblID.Text, classID);


            database.getHomeworkCount(lblID.Text, classID);
            database.getQuizCount(lblID.Text, classID);
            database.getTestCount(lblID.Text, classID);
            database.getLabCount(lblID.Text, classID);
            database.getParticipationCount(lblID.Text, classID);

            database.displayGrade(lblTotal);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddGradebook frmAddGradebook = new frmAddGradebook(lblID.Text,classID,this);
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
                DatabaseConnection.RemoveGradeBook(dgvGradeBook,lblID.Text,classID);

                MessageBox.Show("Grade Removed");
                database.GradeBookDataGrid(dgvGradeBook, lblID.Text, classID);
                database.MidTermGName(tbxName, lblID);
                database.getHomework(lblID.Text, lblHomework, classID);
                database.getQuiz(lblID.Text, lblQuiz, classID);
                database.getTest(lblID.Text, lblTest, classID);
                database.getLab(lblID.Text, lblLab, classID);
                database.getParticipation(lblID.Text, lblParticipation, classID);


                database.getHomeworkGrade(lblID.Text, classID);
                database.getTestGrade(lblID.Text, classID);
                database.getQuizGrade(lblID.Text, classID);
                database.getFinalGrade(lblID.Text, classID);
                database.getLabGrade(lblID.Text, classID);
                database.getParticipationGrade(lblID.Text, classID);


                database.getHomeworkCount(lblID.Text, classID);
                database.getQuizCount(lblID.Text, classID);
                database.getTestCount(lblID.Text, classID);
                database.getLabCount(lblID.Text, classID);
                database.getParticipationCount(lblID.Text, classID);
                database.displayGrade(lblTotal);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditGradebook frmEditGradebook = new frmEditGradebook(this,lblID.Text,classID);
            frmEditGradebook.Show();
        }

        private void btnMidterm_Click(object sender, EventArgs e)
        {
            frmMidTermG midterm = new frmMidTermG();
            midterm.ShowDialog();
        }

      
    }
}
