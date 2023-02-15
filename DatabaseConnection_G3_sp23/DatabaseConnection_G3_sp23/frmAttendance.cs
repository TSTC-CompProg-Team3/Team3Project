using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection_G3_sp23
{
    public partial class frmAttendance : Form
    {
        //private DataGridView dgvAttendance= new DataGridView();
        private BindingSource binding = new BindingSource();


        public frmAttendance()
        {
            InitializeComponent();
        }

        public DataTable DatabaseQuery(String SQLcom)
        {
            String connectionString = "Data Source=3.130.26.194;Initial Catalog=inew2330gsp23;User ID=team3sp232330;Password=fyMU9QpqmW";
            SqlConnection dBConnect = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(SQLcom, dBConnect);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            binding.DataSource = DatabaseQuery("SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.Date, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID;");
            dgvAttendance.DataSource = binding;

            NameDropdown();
        }

        private void NameDropdown()
        {
            List<string> students = new List<string>();

            foreach (DataRowView row in binding)
            {
                string student = row["Student"].ToString();
                int position = students.IndexOf(student);
                if (position == -1)
                {
                    students.Add(student);
                }
            }

            foreach (string student in students)
            {
                cmbNames.Items.Add(student);
            }
        }



        private void dgvAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //DGV Column header names
            dgvAttendance.Columns[0].HeaderCell.Value = "Student";
            dgvAttendance.Columns[1].HeaderCell.Value = "Date";
            dgvAttendance.Columns[2].HeaderCell.Value = "Present";

            //Loop and style each column
            foreach (DataGridViewColumn col in dgvAttendance.Columns)
            {
                col.Width = 220;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnBackAttend_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditAttend_Click(object sender, EventArgs e)
        {

        }
    }
}
