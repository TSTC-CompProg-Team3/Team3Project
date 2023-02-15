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
        private BindingSource binding1 = new BindingSource();


        public frmAttendance()
        {
            InitializeComponent();
        }

        public void SetupDataGrid()
        {
            binding1.DataSource = DatabaseQuery("SELECT * FROM team3sp232330.Attendance;");
            dgvAttendance.DataSource = binding1;
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
            SetupDataGrid();
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
                col.Width = 210;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
