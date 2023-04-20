
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
    public partial class frmAddGradebook : Form
    {
        public string studentID;
        public int classID;
        public frmGradebook gradebook;
        DatabaseConnection database = new DatabaseConnection();
        public frmAddGradebook(string studentID,int classID, frmGradebook gradebook)
        {
            this.classID = classID;
            this.studentID = studentID;
            this.gradebook = gradebook;
            InitializeComponent();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            DialogResult confrimation = MessageBox.Show("Would You like to Add Another Grade?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confrimation == DialogResult.Yes)
            {
                DatabaseConnection.AddGradeBook(studentID,classID, tbxAssignName, tbxAssignType, tbxGrade);


                //clears data if user would like to enter another grade
                tbxAssignName.Clear();
                tbxAssignType.Clear();
                tbxGrade.Clear();

            }
            else
            {
                DatabaseConnection.AddGradeBook(studentID,classID, tbxAssignName, tbxAssignType, tbxGrade);

                MessageBox.Show("Grade Added");
                database.GradeBookDataGrid(gradebook.grade, studentID.ToString(), classID);


                database.getHomework(studentID, gradebook.lblHomework, classID);
                database.getFinal(studentID,gradebook.lblFinal,classID);
                database.getQuiz(studentID, gradebook.lblQuiz, classID);
                database.getTest(studentID, gradebook.lblTest, classID);
                database.getLab(studentID, gradebook.lblLab, classID);
                database.getParticipation(studentID, gradebook.lblParticipation, classID);


                database.getHomeworkGrade(studentID, classID);
                database.getTestGrade(studentID, classID);
                database.getQuizGrade(studentID, classID);
                database.getFinalGrade(studentID, classID);
                database.getLabGrade(studentID, classID);
                database.getParticipationGrade(studentID, classID);


                database.getHomeworkCount(studentID, classID);
                database.getFinalCount(studentID, classID);
                database.getQuizCount(studentID, classID);
                database.getTestCount(studentID, classID);
                database.getLabCount(studentID, classID);
                database.getParticipationCount(studentID, classID);

                database.displayGrade(gradebook.lblTotal);
                this.Hide();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
