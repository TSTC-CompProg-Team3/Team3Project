using DatabaseConnection_G3_sp23;
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
    public partial class frmSeatingChart20 : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public frmSeatingChart20()
        {
            InitializeComponent();

            LoadStudentNames();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // Set the Clear button color and text color
            btnClear.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnClear.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

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
            // Set the Menu button color and text color
            btnMain.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnMain.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            new frmLogin().Show();
            this.Hide();
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



            database.PopulateStudentListBox(lstStudentsAvailable);
        }

        private void btnRan_Click(object sender, EventArgs e)
        {
            // Set the Random button color and text color
            btnRan.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnRan.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            Random random = new Random();
            // Create an array to store the combo Boxes variables
            ComboBox[] comboBoxes = new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5, cbxStudentNames6, cbxStudentNames7, cbxStudentNames8, 
                                                     cbxStudentNames9, cbxStudentNames10, cbxStudentNames11, cbxStudentNames12, cbxStudentNames13, cbxStudentNames14, cbxStudentNames15, cbxStudentNames16, 
                                                     cbxStudentNames17, cbxStudentNames18, cbxStudentNames19, cbxStudentNames20 };

            List<string> selectedNames = new List<string>();

            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.SelectedItem != null)
                {
                    selectedNames.Add(comboBox.SelectedItem.ToString());
                }
            }


            // get a list of all the available student names
            List<string> allNames = new List<string>();
            foreach (string name in cbxStudentNames.Items)
            {
                if (!selectedNames.Contains(name))
                {
                    allNames.Add(name);
                }
            }

            // get a new random index for each combo box based on the available student names
            // With the class of 20 it will throw an error when you want every box not to repeat for some reason
            int maxIndex = allNames.Count - 1;
            int randomNum = random.Next(maxIndex);
            int randomNum2 = random.Next(maxIndex);
            int randomNum3 = random.Next(maxIndex);
            int randomNum4 = random.Next(maxIndex);
            int randomNum5 = random.Next(maxIndex);
            int randomNum6 = random.Next(maxIndex);
            int randomNum7 = random.Next(maxIndex);
            int randomNum8 = random.Next(maxIndex);
            int randomNum9 = random.Next(maxIndex);
            int randomNum10 = random.Next(maxIndex);
            int randomNum11 = random.Next(maxIndex);
            int randomNum12 = random.Next(maxIndex);
            int randomNum13 = random.Next(maxIndex);
            int randomNum14 = random.Next(maxIndex);
            int randomNum15 = random.Next(maxIndex);
            int randomNum16 = random.Next(maxIndex);
            int randomNum17 = random.Next(maxIndex);    
            int randomNum18 = random.Next(maxIndex);
            int randomNum19 = random.Next(maxIndex);
            int randomNum20 = random.Next(maxIndex);

            // set the selected item for each combo box based on the new random index
            if (cbxStudentNames.Items.Count > 0)
            {
                cbxStudentNames.SelectedItem = allNames[randomNum];
            }
            if (cbxStudentNames2.Items.Count > 0)
            {
                cbxStudentNames2.SelectedItem = allNames[randomNum2];
            }
            if (cbxStudentNames3.Items.Count > 0)
            {
                cbxStudentNames3.SelectedItem = allNames[randomNum3];
            }
            if (cbxStudentNames4.Items.Count > 0)
            {
                cbxStudentNames4.SelectedItem = allNames[randomNum4];
            }
            if (cbxStudentNames5.Items.Count > 0)
            {
                cbxStudentNames5.SelectedItem = allNames[randomNum5];
            }
            if (cbxStudentNames6.Items.Count > 0)
            {
                cbxStudentNames6.SelectedItem = allNames[randomNum6];
            }
            if (cbxStudentNames7.Items.Count > 0)
            {
                cbxStudentNames7.SelectedItem = allNames[randomNum7];
            }
            if (cbxStudentNames8.Items.Count > 0)
            {
                cbxStudentNames8.SelectedItem = allNames[randomNum8];
            }
            if (cbxStudentNames9.Items.Count > 0)
            {
                cbxStudentNames9.SelectedItem = allNames[randomNum9];
            }
            if (cbxStudentNames10.Items.Count > 0)
            {
                cbxStudentNames10.SelectedItem = allNames[randomNum10];
            }
            if (cbxStudentNames11.Items.Count > 0)
            {
                cbxStudentNames11.SelectedItem = allNames[randomNum11];
            }
            if (cbxStudentNames12.Items.Count > 0)
            {
                cbxStudentNames12.SelectedItem = allNames[randomNum12];
            }
            if (cbxStudentNames13.Items.Count > 0)
            {
                cbxStudentNames13.SelectedItem = allNames[randomNum13];
            }    
            if (cbxStudentNames14.Items.Count > 0)
            {
                cbxStudentNames14.SelectedItem = allNames[randomNum14];
            }
            if (cbxStudentNames15.Items.Count > 0)
            {
                cbxStudentNames15.SelectedItem = allNames[randomNum15];
            }
            if (cbxStudentNames16.Items.Count > 0)
            {
                cbxStudentNames16.SelectedItem = allNames[randomNum16]; 
            }
            if (cbxStudentNames17.Items.Count > 0)
            {
                cbxStudentNames17.SelectedItem = allNames[randomNum17];
            }
            if (cbxStudentNames18.Items.Count > 0)
            {
                cbxStudentNames18.SelectedItem = allNames[randomNum18];
            }
            if (cbxStudentNames19.Items.Count > 0)
            {
                cbxStudentNames19.SelectedItem = allNames[randomNum19];
            }
            if (cbxStudentNames20.Items.Count > 0)
            {
                cbxStudentNames20.SelectedItem = allNames[randomNum20];
            }
        }

        private void LoadStudentNames()
        {
            List<string> studentNames = database.GetStudentNames20(cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5, cbxStudentNames6,
                                                                   cbxStudentNames7, cbxStudentNames8, cbxStudentNames9, cbxStudentNames10, cbxStudentNames11, cbxStudentNames12,
                                                                   cbxStudentNames13, cbxStudentNames14, cbxStudentNames15, cbxStudentNames16, cbxStudentNames17, cbxStudentNames18,
                                                                   cbxStudentNames19, cbxStudentNames20);

            // add students to cbx 
            foreach (string name in studentNames)
            {
                cbxStudentNames.Items.Add(name);
                cbxStudentNames2.Items.Add(name);
                cbxStudentNames3.Items.Add(name);
                cbxStudentNames4.Items.Add(name);
                cbxStudentNames5.Items.Add(name);
                cbxStudentNames6.Items.Add(name);
                cbxStudentNames7.Items.Add(name);
                cbxStudentNames8.Items.Add(name);
                cbxStudentNames9.Items.Add(name);
                cbxStudentNames10.Items.Add(name);
                cbxStudentNames11.Items.Add(name);
                cbxStudentNames12.Items.Add(name);
                cbxStudentNames13.Items.Add(name);
                cbxStudentNames14.Items.Add(name);
                cbxStudentNames15.Items.Add(name);
                cbxStudentNames16.Items.Add(name);
                cbxStudentNames17.Items.Add(name);
                cbxStudentNames18.Items.Add(name);
                cbxStudentNames19.Items.Add(name);
                cbxStudentNames20.Items.Add(name);
            }
        }


    }
}
