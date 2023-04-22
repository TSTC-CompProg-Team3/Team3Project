using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team3MiddleSchool;

namespace Team3MiddleSchool
{
    public partial class frmLogin : Form
    {
        private bool isClosing = false;

        public frmLogin()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit application - CS
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear textboxes - CS
            tbxPassword.Clear();
            tbxUsername.Clear();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            btnClear.BackColor = ColorTranslator.FromHtml("#F15025");
            btnClear.ForeColor = ColorTranslator.FromHtml("#191919");
            btnLogin.BackColor = ColorTranslator.FromHtml("#F15025");
            btnLogin.ForeColor = ColorTranslator.FromHtml("#191919");
            btnForgotPass.BackColor = ColorTranslator.FromHtml("#F15025");
            btnForgotPass.ForeColor = ColorTranslator.FromHtml("#191919");
            lblUsername.ForeColor = ColorTranslator.FromHtml("#191919");
            lblPassword.ForeColor = ColorTranslator.FromHtml("#191919");
            mnuStrip.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            mnuStrip.ForeColor = ColorTranslator.FromHtml("#191919");

            lblUsernameWarning.Visible = false;
            lblPasswordWarning.Visible = false;

            tbxPassword.UseSystemPasswordChar = true;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //calls close database method -CS
            isClosing = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Hides the warning labels at the beginning of the method
            lblUsernameWarning.Visible = false;
            lblPasswordWarning.Visible = false;

            clsDatabaseHandler.Login(tbxUsername, tbxPassword, lblPasswordWarning, lblUsernameWarning);
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            //open form for forgot password -CS
            frmForgotPass forgotPass = new frmForgotPass();
            forgotPass.ShowDialog();

        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            //clears textboxes and updates userlist when form is in focus and not closing -CS
            if (!isClosing)
            {
                tbxPassword.Clear();
                tbxUsername.Clear();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            isClosing = false;
        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                tbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp("login.html");
            help.ShowDialog();
        }
    }
}
