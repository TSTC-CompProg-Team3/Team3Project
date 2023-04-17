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

namespace Team3MiddleSchool
{
    public partial class frmSeatingChart20 : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public frmSeatingChart20()
        {
            InitializeComponent();

            // Load top 20 student names
            database.GetStudentNames(new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5,
                                     cbxStudentNames6,cbxStudentNames7,cbxStudentNames8, cbxStudentNames9, cbxStudentNames10, cbxStudentNames11,
                                     cbxStudentNames12, cbxStudentNames13, cbxStudentNames14, cbxStudentNames15, cbxStudentNames16, cbxStudentNames17,
                                     cbxStudentNames18, cbxStudentNames19, cbxStudentNames20}, 20);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {

            // When youre clearing the selections you made, it makes the defaults different
            cbxStudentNames.SelectedIndex = 0;
            cbxStudentNames2.SelectedIndex = 1;
            cbxStudentNames3.SelectedIndex = 2;
            cbxStudentNames4.SelectedIndex = 3;
            cbxStudentNames5.SelectedIndex = 4;
            cbxStudentNames6.SelectedIndex = 5;
            cbxStudentNames7.SelectedIndex = 6;
            cbxStudentNames8.SelectedIndex = 7;
            cbxStudentNames9.SelectedIndex = 8;
            cbxStudentNames10.SelectedIndex = 9;
            cbxStudentNames11.SelectedIndex = 10;
            cbxStudentNames12.SelectedIndex = 11;
            cbxStudentNames13.SelectedIndex = 12;
            cbxStudentNames14.SelectedIndex = 13;
            cbxStudentNames15.SelectedIndex = 14;
            cbxStudentNames16.SelectedIndex = 15;
            cbxStudentNames17.SelectedIndex = 16;
            cbxStudentNames18.SelectedIndex = 17;
            cbxStudentNames19.SelectedIndex = 18;
            cbxStudentNames20.SelectedIndex = 19;

        }

        private void btnMain_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmSeatingChart20_Load(object sender, EventArgs e)
        {
            // Set the form background color and text color
            this.BackColor = ColorTranslator.FromHtml("#F2F2F2");
            this.ForeColor = ColorTranslator.FromHtml("#212121");

            // Set the listbox background color and text color
            lstStudentsAvailable.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            lstStudentsAvailable.ForeColor = ColorTranslator.FromHtml("#212121");


            // Set the Random button color and text color
            btnRan.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnRan.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            // Set the Clear button color and text color
            btnClear.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnClear.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            // Set the Menu button color and text color
            btnMain.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnMain.ForeColor = ColorTranslator.FromHtml("#F2F2F2");



            database.PopulateStudentListBox(lstStudentsAvailable, 20);
        }

        private void btnRan_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            // Create an array to store the combo Boxes variables
            ComboBox[] comboBoxes = new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5, cbxStudentNames6, cbxStudentNames7, cbxStudentNames8, 
                                                     cbxStudentNames9, cbxStudentNames10, cbxStudentNames11, cbxStudentNames12, cbxStudentNames13, cbxStudentNames14, cbxStudentNames15, cbxStudentNames16, 
                                                     cbxStudentNames17, cbxStudentNames18, cbxStudentNames19, cbxStudentNames20 };

            // Get a list of all the available student names
            List<string> allNames = new List<string>();
            foreach (string name in cbxStudentNames.Items)
            {
                allNames.Add(name);
            }

            HashSet<string> usedNames = new HashSet<string>();

            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.Items.Count > 0)
                {
                    string selectedName;
                    do
                    {
                        int randomIndex = random.Next(allNames.Count);
                        selectedName = allNames[randomIndex];
                    } while (usedNames.Contains(selectedName));

                    comboBox.SelectedItem = selectedName;
                    usedNames.Add(selectedName);
                }
            }
        }

       

    }
}
