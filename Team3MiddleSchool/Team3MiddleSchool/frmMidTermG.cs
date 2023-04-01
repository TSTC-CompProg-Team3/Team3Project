using Team3MiddleSchool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;
using System.Xml.Linq;

namespace Team3MiddleSchool
{
    public partial class frmMidTermG : Form
    {
        clsDatabaseConnection database = new clsDatabaseConnection();
        public DataGridView grade = new DataGridView();


        public string queryC = "SELECT ClassID FROM team3sp232330.Class ";

        public string QueryC
        {
            get { return queryC; }
            set { queryC = value; }
        }

        public frmMidTermG()
        {
            InitializeComponent();
            queryC = QueryC;


        }

        CurrencyManager midTermGradeManager;


        private void btnBack_Click(object sender, EventArgs e)
        {
           // btnBack.BackColor = ColorTranslator.FromHtml("#F15025");
            this.Close();
            
        }
        

        private void frmMidTermG_Load(object sender, EventArgs e)
        {
            int count = 0;
            grade = dgvMDG;
            clsDatabaseConnection.MidTermG(dgvMDG, count);
            clsDatabaseConnection.MidTermGName(tbxName);
           //DatabaseConnection.MidTermGClass(dgvMDG, count);
            midTermGradeManager = (CurrencyManager)this.BindingContext[clsDatabaseConnection.MidTermGDT];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //counter--;

            //btnPrevious.BackColor = ColorTranslator.FromHtml("#F15025");
            midTermGradeManager.Position--;
            database.Previous(tbxName);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           // counter++;

           // btnNext.BackColor = ColorTranslator.FromHtml("#F15025");
            midTermGradeManager.Position++;
            database.Next(tbxName);

        }
    }


}