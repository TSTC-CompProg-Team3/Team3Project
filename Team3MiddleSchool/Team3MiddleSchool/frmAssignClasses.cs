using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team3MiddleSchool
{
    public partial class frmAssignClasses : Form
    {
        public frmAssignClasses()
        {
            InitializeComponent();
        }

        private void frmAssignClasses_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#E6E8E6");
            btnEditCourses.BackColor = ColorTranslator.FromHtml("#F15025");
            btnEditCourses.ForeColor = ColorTranslator.FromHtml("#191919");
            btnBack.BackColor = ColorTranslator.FromHtml("#F15025");
            btnBack.ForeColor = ColorTranslator.FromHtml("#191919");
            btnReset.BackColor = ColorTranslator.FromHtml("#F15025");
            btnReset.ForeColor = ColorTranslator.FromHtml("#191919");
           

            clsDatabaseHandler.PopulateClassesLbx(lbxStudents);
            clsDatabaseHandler.PopulateAvailableClasses(cbxClass1,cbxClass2,cbxClass3,cbxClass4,cbxClass5,cbxClass6);
        }

        private void lbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxStudents.SelectedIndex != -1)
            {
                string hold = lbxStudents.SelectedItem.ToString();
                string[] holdSplit = hold.Split('-');
                int studentID = int.Parse(holdSplit[0].Trim());
                clsDatabaseHandler.SetCurrentClasses(studentID,cbxClass1,cbxClass2,cbxClass3,cbxClass4,cbxClass5,cbxClass6);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbxStudents.SelectedIndex = -1;
            cbxClass1.SelectedIndex = -1;
            cbxClass2.SelectedIndex = -1;
            cbxClass3.SelectedIndex = -1;
            cbxClass4.SelectedIndex = -1;
            cbxClass5.SelectedIndex = -1;
            cbxClass6.SelectedIndex = -1;
        }

        private void btnEditCourses_Click(object sender, EventArgs e)
        {
            if (lbxStudents.SelectedIndex != -1)
            {
                string hold = lbxStudents.SelectedItem.ToString();
                string[] holdSplit = hold.Split('-');
                int studentID = int.Parse(holdSplit[0].Trim());
                clsDatabaseHandler.EditCourses(studentID,cbxClass1,cbxClass2,cbxClass3,cbxClass4,cbxClass5,cbxClass6);
            }
            
        }
    }
}
