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
            //calls open database method from Database Connection -CS
            database.OpenDatabase();
            database.UserInfo();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //calls close database method -CS
            database.CloseDatabase();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //takes user input and checks against the data in the database connection -CS
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            foreach (clsUser item in database.userList)
            {
                if (username == item.userName && password == item.passWord)
                {
                    frmMenu menu = new frmMenu();
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

        

        

    }
}
