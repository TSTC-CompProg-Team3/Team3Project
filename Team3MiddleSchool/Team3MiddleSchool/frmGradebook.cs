using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
using System.IO;

namespace Team3MiddleSchool
{


    //*Need to put the names of the students in alphabetical order.  If they are not in that course, the students do not need to be in the gradebook.

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


        CurrencyManager  NameManager;
        private void frmGradebook_Load(object sender, EventArgs e)
        {
            
            
            parentID = 3;
            mnuStrip.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            mnuStrip.ForeColor = ColorTranslator.FromHtml("#191919");
            




            switch (accountType.ToLower())
            {
                case "officer":
                    classID = database.GetClassID(classSelect);
                    database.GetClass(classID, lblClass);
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
                 //   database.getmidTerm(lblID.Text, lblmidTerm, classID);


                    database.getHomeworkGrade(lblID.Text, classID);
                    database.getTestGrade(lblID.Text, classID);
                    database.getQuizGrade(lblID.Text, classID);
                    database.getFinalGrade(lblID.Text, classID);
                    database.getLabGrade(lblID.Text, classID);
                    database.getParticipationGrade(lblID.Text, classID);
                 //   database.getMidTermGrade(lblID.Text, classID);


                    database.getHomeworkCount(lblID.Text, classID);
                    database.getFinalCount(lblID.Text, classID);
                    database.getQuizCount(lblID.Text, classID);
                    database.getTestCount(lblID.Text, classID);
                    database.getLabCount(lblID.Text, classID);
                  //  database.getMidtermCount(lblID.Text, classID);
                    database.getParticipationCount(lblID.Text, classID);
                    database.displayGrade(lblTotal);
                    database.displayMidtermGrade(lblmidTerm);
                    break;

                case "admin":

                    classID = database.GetClassID(classSelect);
                    database.GetClass(classID, lblClass);
                    database.GradeBookDataGrid(dgvGradeBook, lblID.Text, classID);
                    database.MidTermGName(tbxName, lblID);




                    btnRemove.Visible = true;
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;

             

                    database.getHomeworkGrade(lblID.Text, classID);
                    database.getTestGrade(lblID.Text, classID);
                    database.getQuizGrade(lblID.Text, classID);
                    database.getFinalGrade(lblID.Text, classID);
                  //  database.getMidTermGrade(lblID.Text, classID);
                    database.getLabGrade(lblID.Text, classID);
                    database.getParticipationGrade(lblID.Text, classID);


                    database.getHomeworkCount(lblID.Text, classID);
                    database.getFinalCount(lblID.Text, classID);
                    database.getQuizCount(lblID.Text, classID);
                    database.getTestCount(lblID.Text, classID);
                    database.getLabCount(lblID.Text, classID);
                  //  database.getMidtermCount(lblID.Text, classID);
                    database.getParticipationCount(lblID.Text, classID);

                    database.getHomework(lblID.Text, lblHomework, classID);
                    database.getFinal(lblID.Text, lblFinal, classID);
                    database.getQuiz(lblID.Text, lblQuiz, classID);
                    database.getTest(lblID.Text, lblTest, classID);
                    database.getLab(lblID.Text, lblLab, classID);
                  //  database.getmidTerm(lblID.Text, lblLab, classID);
                    database.getParticipation(lblID.Text, lblParticipation, classID);


                    
                    database.displayGrade(lblTotal);
                    database.displayMidtermGrade(lblmidTerm);
                    break;

                case "teacher":
                    classID = database.GetClassID(classSelect);
                    database.GetClass(classID, lblClass);

                    btnRemove.Visible = true;
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;
                    database.GradeBookDataGrid(dgvGradeBook, lblID.Text, classID);
                    database.MidTermGName(tbxName, lblID);
                    database.getHomework(lblID.Text, lblHomework, classID);
                    database.getQuiz(lblID.Text, lblQuiz, classID);
                    database.getTest(lblID.Text, lblTest, classID);
                    database.getLab(lblID.Text, lblLab, classID);
                   // database.getmidTerm(lblID.Text, lblLab, classID);
                    database.getParticipation(lblID.Text, lblParticipation, classID);


                    database.getHomeworkGrade(lblID.Text, classID);
                    database.getTestGrade(lblID.Text, classID);
                    database.getQuizGrade(lblID.Text, classID);
                    database.getFinalGrade(lblID.Text, classID);
                   // database.getMidTermGrade(lblID.Text, classID);
                    database.getLabGrade(lblID.Text, classID);
                    database.getParticipationGrade(lblID.Text, classID);


                    database.getHomeworkCount(lblID.Text, classID);
                    database.getFinalCount(lblID.Text, classID);
                    database.getQuizCount(lblID.Text, classID);
                    database.getTestCount(lblID.Text, classID);
                    database.getLabCount(lblID.Text, classID);
                   // database.getMidtermCount(lblID.Text, classID);
                    database.getParticipationCount(lblID.Text, classID);
                    database.displayGrade(lblTotal);
                    database.displayMidtermGrade(lblmidTerm);
                    break;
                case "student":
                    studentID = database.GetStudentID(loginID);
                    classID = database.GetClassID(classSelect);
                    database.GetClass(classID, lblClass);
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
                   // database.getmidTerm(studentID.ToString(), lblmidTerm, classID);
                    database.getParticipation(studentID.ToString(), lblParticipation, classID);

                    database.getHomeworkGrade(studentID.ToString(), classID);
                    database.getTestGrade(studentID.ToString(), classID);
                    database.getQuizGrade(studentID.ToString(), classID);
                    database.getFinalGrade(studentID.ToString(), classID);
                    database.getLabGrade(studentID.ToString(), classID);
                   // database.getMidTermGrade(studentID.ToString(), classID);
                    database.getParticipationGrade(studentID.ToString(), classID);

                    database.getHomeworkCount(studentID.ToString(), classID);
                    database.getFinalCount(studentID.ToString(), classID);
                    database.getQuizCount(studentID.ToString(), classID);
                    database.getTestCount(studentID.ToString(), classID);
                    database.getLabCount(studentID.ToString(), classID);
                   // database.getMidtermCount(studentID.ToString(), classID);
                    database.getParticipationCount(studentID.ToString(), classID);
                    database.displayGrade(lblTotal);
                    database.displayMidtermGrade(lblmidTerm);

                    break;
                case "parent":
                    studentID = 11;
                    classID = database.GetClassID(classSelect);
                    database.GetClass(classID, lblClass);
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
                  //  database.getmidTerm(studentID.ToString(), lblmidTerm, classID);
                    database.getParticipation(studentID.ToString(), lblParticipation, classID);

                    database.getHomeworkGrade(studentID.ToString(), classID);
                    database.getTestGrade(studentID.ToString(), classID);
                    database.getQuizGrade(studentID.ToString(), classID);
                    database.getFinalGrade(studentID.ToString(), classID);
                    database.getLabGrade(studentID.ToString(), classID);
                 //   database.getMidTermGrade(studentID.ToString(), classID);
                    database.getParticipationGrade(studentID.ToString(), classID);

                    database.getHomeworkCount(studentID.ToString(), classID);
                    database.getFinalCount(studentID.ToString(), classID);
                    database.getQuizCount(studentID.ToString(), classID);
                    database.getTestCount(studentID.ToString(), classID);
                    database.getLabCount(studentID.ToString(), classID);
                   // database.getMidtermCount(studentID.ToString(), classID);
                    database.getParticipationCount(studentID.ToString(), classID);
                    database.displayGrade(lblTotal);
                    database.displayMidtermGrade(lblmidTerm);



                    break;
                default:
                    break;
            }
            
            grade = dgvGradeBook;

            NameManager = (CurrencyManager)this.BindingContext[DatabaseConnection._nameeTable];

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (NameManager.Position == NameManager.Count - 1)
            {
                SystemSounds.Beep.Play();
            }
            else
            {
                NameManager.Position++;

                database.GradeBookDataGrid(dgvGradeBook, lblID.Text, classID);
                database.MidTermGName(tbxName, lblID);


                database.getHomeworkGrade(lblID.Text, classID);
                database.getTestGrade(lblID.Text, classID);
                database.getQuizGrade(lblID.Text, classID);
                database.getFinalGrade(lblID.Text, classID);
               // database.getMidTermGrade(lblID.Text, classID);
                database.getLabGrade(lblID.Text, classID);
                database.getParticipationGrade(lblID.Text, classID);


                database.getHomeworkCount(lblID.Text, classID);
                database.getFinalCount(lblID.Text, classID);
                database.getQuizCount(lblID.Text, classID);
                database.getTestCount(lblID.Text, classID);
                database.getLabCount(lblID.Text, classID);
              //  database.getMidtermCount(lblID.Text, classID);
                database.getParticipationCount(lblID.Text, classID);

                database.getHomework(lblID.Text, lblHomework, classID);
                database.getFinal(lblID.Text, lblFinal, classID);
                database.getQuiz(lblID.Text, lblQuiz, classID);
                database.getTest(lblID.Text, lblTest, classID);
              //  database.getmidTerm(lblID.Text, lblmidTerm, classID);
                database.getLab(lblID.Text, lblLab, classID);
                database.getParticipation(lblID.Text, lblParticipation, classID);



                database.displayGrade(lblTotal);
                database.displayMidtermGrade(lblmidTerm);
            }

            


        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

            if (NameManager.Position == 0)
            {
                SystemSounds.Beep.Play();
            }
            else
            {
                NameManager.Position--;
                database.GradeBookDataGrid(dgvGradeBook, lblID.Text, classID);
                database.MidTermGName(tbxName, lblID);

                database.getHomeworkGrade(lblID.Text, classID);
                database.getTestGrade(lblID.Text, classID);
                database.getQuizGrade(lblID.Text, classID);
                database.getFinalGrade(lblID.Text, classID);
               // database.getMidTermGrade(lblID.Text, classID);
                database.getLabGrade(lblID.Text, classID);
                database.getParticipationGrade(lblID.Text, classID);


                database.getHomeworkCount(lblID.Text, classID);
                database.getFinalCount(lblID.Text, classID);
                database.getQuizCount(lblID.Text, classID);
                database.getTestCount(lblID.Text, classID);
                database.getLabCount(lblID.Text, classID);
              //  database.getMidtermCount(lblID.Text, classID);
                database.getParticipationCount(lblID.Text, classID);

                database.getHomework(lblID.Text, lblHomework, classID);
                database.getFinal(lblID.Text, lblFinal, classID);
                database.getQuiz(lblID.Text, lblQuiz, classID);
                database.getTest(lblID.Text, lblTest, classID);
                database.getLab(lblID.Text, lblLab, classID);
                database.getParticipation(lblID.Text, lblParticipation, classID);



                database.displayGrade(lblTotal);
                database.displayMidtermGrade(lblmidTerm);
            }
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

                database.getHomeworkGrade(lblID.Text, classID);
                database.getTestGrade(lblID.Text, classID);
                database.getQuizGrade(lblID.Text, classID);
                database.getFinalGrade(lblID.Text, classID);
                database.getLabGrade(lblID.Text, classID);
                //database.getMidTermGrade(lblID.Text, classID);
                database.getParticipationGrade(lblID.Text, classID);


                database.getHomeworkCount(lblID.Text, classID);
                database.getFinalCount(lblID.Text, classID);
                database.getQuizCount(lblID.Text, classID);
                database.getTestCount(lblID.Text, classID);
               // database.getMidtermCount(lblID.Text, classID);
                database.getLabCount(lblID.Text, classID);
                database.getParticipationCount(lblID.Text, classID);

                database.getHomework(lblID.Text, lblHomework, classID);
                database.getFinal(lblID.Text, lblFinal, classID);
                database.getQuiz(lblID.Text, lblQuiz, classID);
                database.getTest(lblID.Text, lblTest, classID);
               // database.getmidTerm(lblID.Text, lblmidTerm, classID);
                database.getLab(lblID.Text, lblLab, classID);
                database.getParticipation(lblID.Text, lblParticipation, classID);



                database.displayGrade(lblTotal);
                database.displayMidtermGrade(lblmidTerm);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditGradebook frmEditGradebook = new frmEditGradebook(this,lblID.Text,classID);
            frmEditGradebook.Show();
        }

        private void btnMidterm_Click(object sender, EventArgs e)
        {
        
        }


        private void generateMidtermReport(Label lblmidTerm, TextBox tbxName, Label lblParticipation, Label lblHomework, Label lblQuiz, Label lblLab, Label lblTest, Label lblFinal, Label lblTotal)
        {
            string template = "midtermReportTemplate.html";
            string report = "reportGenerator.html";

            StreamReader sr = new StreamReader(template);
            string content = sr.ReadToEnd();
            sr.Close();

            string search = "<h2 id=\"studentNameHeader\">Student Name</h2>";
            string replace = "<h2 id=\"studentNameHeader\">This Midterm Report is for the parents of " + tbxName.Text + "</h2>";
            content = content.Replace(search, replace);


            search = "<dt id=\"classP\">Class Participation: </dt>";
            replace = "<dt id=\"classP\">Class Participation: " + lblParticipation.Text + "</dt>";
            content = content.Replace(search, replace);

            search = "<dt id=\"homework\">Homework: </dt>";
            replace = "<dt id=\"homework\">Homework: " + lblHomework.Text + "</dt>";
            content = content.Replace(search, replace);

            search = "<dt id=\"quiz\">Quiz: </dt>";
            replace = "<dt id=\"quiz\">Quiz: " + lblQuiz.Text + "</dt>";
            content = content.Replace(search, replace);

            search = "<dt id=\"lab\">Lab: </dt>";
            replace = "<dt id=\"lab\">Lab: " + lblLab.Text + "</dt>";
            content = content.Replace(search, replace);


            search = "<dt id=\"test\">Test: </dt>";
            replace = "<dt id=\"test\">Test: " + lblTest.Text + "</dt>";
            content = content.Replace(search, replace);

            search = "<dt id=\"final\">Final: </dt>";
            replace = "<dt id=\"final\">Final: " + lblFinal.Text + "</dt>";
            content = content.Replace(search, replace);

            search = "<dt id=\"totalG\">Total Grade: </dt>";
            replace = "<dt id=\"totalG\">Total Grade: " + lblTotal.Text + "</dt>";
            content = content.Replace(search, replace);




            search = "<dt id=\"midtermGradeHeader\">Midterm: </dt>";
            replace = "<dt id=\"midtermGradeHeader\">Midterm Grade: " + lblmidTerm.Text + "</dt>";
            content = content.Replace(search, replace);

    

            // content = content.Replace("[midterm]", lblmidTerm.Text);

            StreamWriter sw = new StreamWriter(report, false);
            sw.Write(content);
            sw.Close();

            System.Diagnostics.Process.Start("reportGenerator.html");

        }

        private void btnmidTRep_Click(object sender, EventArgs e)
        {
            generateMidtermReport(lblmidTerm, tbxName, lblParticipation, lblHomework, lblQuiz, lblLab, lblTest, lblFinal, lblTotal);

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("gradebook.html");

        }
    }
}
