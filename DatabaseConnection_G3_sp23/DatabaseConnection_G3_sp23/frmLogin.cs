using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DatabaseConnection_G3_sp23
{
    public partial class frmLogin : Form
    {
        DatabaseConnection database = new DatabaseConnection();
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
            tbxPassword.Text = string.Empty;
            tbxUsername.Text = string.Empty;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            tsStatus.BackColor = ColorTranslator.FromHtml("#E6E8E6");
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
            //calls open database method from Database Connection -CS
            database.OpenDatabase(tssDatabaseConnection);
            database.UserInfo();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //calls close database method -CS
            isClosing = true;
            database.CloseDatabase(tssDatabaseConnection);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //takes user input and checks against the data in the database connection -CS
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            List<clsUser> tempList = database.userList.ToList();
            foreach (clsUser item in tempList)
            {
                if (username == item.userName && password == item.passWord)
                {
                    int loginID = item.loginID;
                    string accountType = item.accountType;
                    frmMenu menu = new frmMenu(loginID, accountType);
                    menu.ShowDialog();
                }
            }
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
                tbxPassword.Text = string.Empty;
                tbxUsername.Text = string.Empty;
                database.UpdateUserList();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            isClosing = false;
        }
    }
}
