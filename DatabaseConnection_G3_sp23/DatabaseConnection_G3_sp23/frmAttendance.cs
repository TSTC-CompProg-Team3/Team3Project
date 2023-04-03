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
    public partial class frmAttendance : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        private BindingSource binding = new BindingSource();
        private int loginID;
        private string accountType;
        private string classSelect;

        public frmAttendance(int loginID, string accountType, string classSelect)
        {
            this.loginID = loginID;
            this.accountType = accountType;
            this.classSelect = classSelect;
            InitializeComponent();
        }

        //TODO: Filter query to current logged in teacher and selected class
        //TODO: Ensure edits made are pushed to database


        public frmAttendance()
        {
            InitializeComponent();
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            database.OpenDatabase();
            binding.DataSource = database.AttendanceInfo(loginID, accountType, classSelect);
            dgvAttendance.DataSource = binding;

            FillUserInfo();
            btnEditAttend.BackColor = ColorTranslator.FromHtml("#F15025");
            btnEditAttend.ForeColor = ColorTranslator.FromHtml("#191919");
            btnBackAttend.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBackAttend.ForeColor = ColorTranslator.FromHtml("#191919");
        }

        private void dgvAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //DGV Column header names
            dgvAttendance.Columns[0].HeaderCell.Value = "Student";
            dgvAttendance.Columns[1].HeaderCell.Value = "Student ID";
            dgvAttendance.Columns[2].HeaderCell.Value = "Class ID";
            dgvAttendance.Columns[3].HeaderCell.Value = "Date";
            dgvAttendance.Columns[4].HeaderCell.Value = "Present";

            //Loop and style each column
            foreach (DataGridViewColumn col in dgvAttendance.Columns)
            {
                if (col.Index == 0)
                {
                    col.Width = 155;
                }
                else
                {
                    col.Width = 82;
                }
                
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnBackAttend_Click(object sender, EventArgs e)
        {
            database.CloseDatabase();
            this.Close();
        }

        private void btnEditAttend_Click(object sender, EventArgs e)
        {
            frmAttendanceEdit edit = new frmAttendanceEdit(loginID, accountType, classSelect);
            edit.ShowDialog();
        }

        private void FillUserInfo()
        {
            int spaceIndex = classSelect.IndexOf(" ");
            string className = classSelect.Substring(0, spaceIndex);

            lblAttendTeacher.Text = "Teacher: " + database.LoggedTeacher(loginID);
            lblAttendClass.Text = "Class: " + className;
        }
    }
}
