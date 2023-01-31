using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team3Project_Fixed
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
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxPassword.Text = string.Empty;
            tbxUsername.Text = string.Empty;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            database.OpenDatabase();
            database.StudentInfo();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            database.CloseDatabase();
        }
    }
}
