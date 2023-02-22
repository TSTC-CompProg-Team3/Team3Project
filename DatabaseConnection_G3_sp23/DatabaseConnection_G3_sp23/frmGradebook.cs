﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseConnection_G3_sp23
{
    public partial class frmGradebook : Form
    {
        DatabaseConnection database = new DatabaseConnection();
       public DataGridView grade= new DataGridView();
        public frmGradebook()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int dgvcounter = 1;

        private void frmGradebook_Load(object sender, EventArgs e)
        {
            grade = dgvGradeBook;
            DatabaseConnection.GradeBookDataGrid(dgvGradeBook, dgvcounter);
            database.GradeCalculations(dgvcounter, dgvGradeBook, lblTotal, lblQuiz, lblParticipation, lblHomework, lblLab, lblTest);
            database.GradeBookName(lblName);
        }

        int counter;

        private void btnNext_Click(object sender, EventArgs e)
        {
            dgvcounter++;
            counter++;
            DatabaseConnection.GradeBookDataGrid(dgvGradeBook, dgvcounter);
            database.Next(lblName, counter);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            dgvcounter--;
            counter--;
            DatabaseConnection.GradeBookDataGrid(dgvGradeBook, dgvcounter);
            database.Prev(lblName, counter);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                this.Hide();
                MessageBox.Show("Grade Removed");
                this.Show();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmEditGradebook frmEditGradebook = new frmEditGradebook(this);
            //frmEditGradebook.Show();
        }
    }
}
