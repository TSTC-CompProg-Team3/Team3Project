using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Team3MiddleSchool;

namespace Team3MiddleSchool
{
    public partial class frmForgotPass : Form
    {

        public frmForgotPass()
        {
            InitializeComponent();
        }

        private void frmForgotPass_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            btnCancel.BackColor = ColorTranslator.FromHtml("#F15025");
            btnCancel.ForeColor = ColorTranslator.FromHtml("#191919");
            btnConfirm.BackColor = ColorTranslator.FromHtml("#F15025");
            btnConfirm.ForeColor = ColorTranslator.FromHtml("#191919");
            btnSendCode.BackColor = ColorTranslator.FromHtml("#F15025");
            btnSendCode.ForeColor = ColorTranslator.FromHtml("#191919");
            lblConfirmPassword.ForeColor = ColorTranslator.FromHtml("#191919");
            lblConfirmPassword.ForeColor = ColorTranslator.FromHtml("#191919");
            lblEnterCode.ForeColor = ColorTranslator.FromHtml("#191919");
            lblEnterCode.ForeColor = ColorTranslator.FromHtml("#191919");
            lblEnterEmail.ForeColor = ColorTranslator.FromHtml("#191919");
            lblEnterEmail.ForeColor = ColorTranslator.FromHtml("#191919");
            lblNewPassword.ForeColor = ColorTranslator.FromHtml("#191919");
            lblNewPassword.ForeColor = ColorTranslator.FromHtml("#191919");
            mnuStrip.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            mnuStrip.ForeColor = ColorTranslator.FromHtml("#191919");
        }

        //sends code to email and stores in database -CS
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            clsDatabaseHandler.SendEmail(tbxEmail, lblEmailWarning);

        }


        //resets the password if the reset code is correct and the password fields match -CS
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidatePassword(tbxNewPassword.Text))
            {
                clsDatabaseHandler.ConfirmResetPass(tbxEnterCode, tbxNewPassword, tbxConfirmPassword);
            }
            else
            {
                tbxNewPassword.BackColor = Color.Red;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmForgotPass_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("forgotPassword.html");
        }
    }


}
