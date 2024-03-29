﻿
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
    public partial class frmEditTeacher : Form
    {
        public string teacherInfo;
        public frmEditTeacher(string teacherInfo)
        {
            InitializeComponent();
            this.teacherInfo = teacherInfo;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxEmail.Clear();
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxPassword.Clear();
            tbxUsername.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditTeacher_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            btnBack.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBack.ForeColor = ColorTranslator.FromHtml("#191919");
            btnClear.BackColor = ColorTranslator.FromHtml("#F15025");
            btnClear.ForeColor = ColorTranslator.FromHtml("#191919");
            btnSubmit.BackColor = ColorTranslator.FromHtml("#F15025");
            btnSubmit.ForeColor = ColorTranslator.FromHtml("#191919");
            lblFirstName.ForeColor = ColorTranslator.FromHtml("#191919");
            lblLastName.ForeColor = ColorTranslator.FromHtml("#191919");
            lblEmail.ForeColor = ColorTranslator.FromHtml("#191919");
            lblUsername.ForeColor = ColorTranslator.FromHtml("#191919");
            lblPassword.ForeColor = ColorTranslator.FromHtml("#191919");
            mnuStrip.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            mnuStrip.ForeColor = ColorTranslator.FromHtml("#191919");


            string hold = teacherInfo;
            string[] holdSplit = hold.Split('-');
            string teacherID = holdSplit[0].Trim();
            clsDatabaseHandler.EditTeacherLoad(teacherID,tbxFirstName, tbxLastName, tbxEmail, tbxUsername, tbxPassword);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateEmail(tbxEmail.Text) && clsValidation.ValidateUsernameEdit(tbxUsername.Text) &&
                clsValidation.ValidatePassword(tbxPassword.Text) && clsValidation.ValidateFirstName(tbxFirstName.Text) &&
                clsValidation.ValidateLastName(tbxLastName.Text))
            {
                string hold = teacherInfo;
                string[] holdSplit = hold.Split('-');
                string teacherID = holdSplit[0].Trim();
                clsDatabaseHandler.EditTeacher(teacherID, tbxFirstName, tbxLastName, tbxEmail, tbxUsername, tbxPassword);
                lblNameWarning.Visible = false;
                lblEmailWarning.Visible = false;
                lblUsernameWarning.Visible = false;
                lblPasswordWarning.Visible = false;
                this.Close();
            }
            else
            {
                if (!clsValidation.ValidateEmail(tbxEmail.Text))
                {
                    tbxEmail.BackColor = Color.Red;
                    lblEmailWarning.Visible = true;    
                }
                else
                {
                    lblEmailWarning.Visible = false;
                    tbxEmail.BackColor = SystemColors.Window;
                }

                if (!clsValidation.ValidateUsername(tbxUsername.Text))
                {
                    tbxUsername.BackColor = Color.Red;
                    lblUsernameWarning.Visible = true;
                }
                else
                {
                    lblUsernameWarning.Visible = false;
                    tbxUsername.BackColor = SystemColors.Window;
                }

                if (!clsValidation.ValidatePassword(tbxPassword.Text))
                {
                    tbxPassword.BackColor = Color.Red;
                    lblPasswordWarning.Visible = true;  
                }
                else
                {
                    tbxPassword.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateFirstName(tbxFirstName.Text))
                {
                    tbxFirstName.BackColor = Color.Red;
                    lblNameWarning.Visible = true;
                }
                else
                {
                    lblNameWarning.Visible = false;
                    tbxFirstName.BackColor = SystemColors.Window;
                }
                if (!clsValidation.ValidateLastName(tbxLastName.Text))
                {
                    tbxLastName.BackColor = Color.Red;
                    lblNameWarning.Visible = true;
                }
                else
                {
                    lblNameWarning.Visible = false;
                    tbxLastName.BackColor = SystemColors.Window;
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("editTeacher.html");
        }
    }
}
