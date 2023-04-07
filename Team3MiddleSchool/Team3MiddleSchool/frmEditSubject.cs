﻿using System;
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
    public partial class frmEditSubject : Form
    {
        public string subjectInfo;
        public frmEditSubject(string subjectInfo)
        {
            this.subjectInfo = subjectInfo;
            InitializeComponent();
        }

        private void frmEditSubject_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            btnClear.BackColor = ColorTranslator.FromHtml("#F15025");
            btnClear.ForeColor = ColorTranslator.FromHtml("#191919");
            btnSubmit.BackColor = ColorTranslator.FromHtml("#F15025");
            btnSubmit.ForeColor = ColorTranslator.FromHtml("#191919");
            btnBack.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBack.ForeColor = ColorTranslator.FromHtml("#191919");


            string hold = subjectInfo;
            string[] holdSplit = hold.Split('-');
            string subjectName = holdSplit[1].Trim();
            tbxSubjectName.Text = subjectName;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxSubjectName.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateSubjectEdit(tbxSubjectName.Text))
            {
                string hold = subjectInfo;
                string[] holdSplit = hold.Split('-');
                string subjectID = holdSplit[0].Trim();
                clsDatabaseHandler.EditSubject(subjectID, tbxSubjectName.Text);
            }
            else
            {
                tbxSubjectName.BackColor = Color.Red;
            }

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxSubjectName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidation.ValidateString(e.KeyChar);
        }
    }
}
