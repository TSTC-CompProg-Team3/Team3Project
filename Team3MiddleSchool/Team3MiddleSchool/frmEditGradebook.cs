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
        DatabaseConnection database = new DatabaseConnection();
        public frmGradebook gradebook;
        public string studentID;
        public int classID;

        public frmEditGradebook(frmGradebook grade,string studentID,int classID)
        {
            gradebook = grade;
            this.studentID = studentID;
            this.classID = classID;
            InitializeComponent();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DatabaseConnection.EditGradeBook(gradebook.grade, studentID, classID, tbxAssignName, tbxAssignType, tbxGrade);
            database.GradeBookDataGrid(gradebook.grade, studentID.ToString(), classID);


            database.getHomework(studentID, gradebook.lblHomework, classID);
            database.getFinal(studentID, gradebook.lblFinal, classID);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
