using System.Configuration;

namespace Team3Project
{
    public partial class frmLogin : Form
    {

        DatabaseConnection database = new DatabaseConnection();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxPassword.Text = string.Empty;
            tbxUsername.Text = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            database.OpenDatabase();

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            database.CloseDatabase();
        }
    }
}