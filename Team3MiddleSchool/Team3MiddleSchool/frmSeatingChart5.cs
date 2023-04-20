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
    public partial class frmSeatingChart5 : Form
    {
        DatabaseConnection database = new DatabaseConnection();

        int cbxCourseSelect;
        public frmSeatingChart5(int CourseSelect)
        {
            InitializeComponent();
            cbxCourseSelect = CourseSelect;
        }

        private void btnRan_Click(object sender, EventArgs e)
        {

            Random random = new Random();

            // Create an array to store the combo Boxes variables
            ComboBox[] comboBoxes = new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5 };

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
                    } 
                    while (usedNames.Contains(selectedName));

                    comboBox.SelectedItem = selectedName;
                    usedNames.Add(selectedName);
                }
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {

            // When youre clearing the selections you made, it makes the defaults different
            cbxStudentNames.SelectedIndex = -1;
            cbxStudentNames2.SelectedIndex = -1;
            cbxStudentNames3.SelectedIndex = -1;
            cbxStudentNames4.SelectedIndex = -1;
            cbxStudentNames5.SelectedIndex = -1;


        }

        private void btnMain_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmSeatingChart5_Load(object sender, EventArgs e)
        {
            // Set the form background color and text color
            this.BackColor = ColorTranslator.FromHtml("#F2F2F2");
            this.ForeColor = ColorTranslator.FromHtml("#212121");

            // Set the listbox background color and text color
            lstStudentsAvailable.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            lstStudentsAvailable.ForeColor = ColorTranslator.FromHtml("#212121");

            // Set the datagridview background color and text color
           
            // Set the Random button color and text color
            btnRan.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnRan.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            // Set the Clear button color and text color
            btnClear.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnClear.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            // Set the Menu button color and text color
            btnMain.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnMain.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            Console.WriteLine($"Selected index: {cbxCourseSelect}");

            if (cbxCourseSelect == 0)
            {
                database.PopulateStudentListBox(lstStudentsAvailable, 5);
                database.GetStudentNames(new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5 }, 5);
                // loads students in there seats
                cbxStudentNames.SelectedIndex = 0;
                cbxStudentNames2.SelectedIndex = 1;
                cbxStudentNames3.SelectedIndex = 2;
                cbxStudentNames4.SelectedIndex = 3;
                cbxStudentNames5.SelectedIndex = 4;

            }
            else if (cbxCourseSelect == 3)
            {
                database.PopulateStudentListBox11Through15(lstStudentsAvailable);
                database.GetStudentNames11Through15(new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5 });
                // loads students in there seats
                cbxStudentNames.SelectedIndex = 0;
                cbxStudentNames2.SelectedIndex = 1;
                cbxStudentNames3.SelectedIndex = 2;
                cbxStudentNames4.SelectedIndex = 3;
                cbxStudentNames5.SelectedIndex = 4;
            }
            else if (cbxCourseSelect == 4)
            {
                database.PopulateStudentListBox6Through10(lstStudentsAvailable);
                database.GetStudentNames6Through10(new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5 });
                // loads students in there seats
                cbxStudentNames.SelectedIndex = 0;
                cbxStudentNames2.SelectedIndex = 1;
                cbxStudentNames3.SelectedIndex = 2;
                cbxStudentNames4.SelectedIndex = 3;
                cbxStudentNames5.SelectedIndex = 4;
            }
            else if (cbxCourseSelect == 5)
            {
                database.PopulateStudentListBox16Through20(lstStudentsAvailable);
                database.GetStudentNames16Through20(new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5 });
                // loads students in there seats
                cbxStudentNames.SelectedIndex = 0;
                cbxStudentNames2.SelectedIndex = 1;
                cbxStudentNames3.SelectedIndex = 2;
                cbxStudentNames4.SelectedIndex = 3;
                cbxStudentNames5.SelectedIndex = 4;
            }
            else
            {
                // if its a 5 class
                database.PopulateStudentListBox(lstStudentsAvailable, 5);
                // Load top 5 student names
                database.GetStudentNames(new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5 }, 5);
                // loads students in there seats
                cbxStudentNames.SelectedIndex = 0;
                cbxStudentNames2.SelectedIndex = 1;
                cbxStudentNames3.SelectedIndex = 2;
                cbxStudentNames4.SelectedIndex = 3;
                cbxStudentNames5.SelectedIndex = 4;
            }
        }

        private void cbxStudentNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox currentComboBox = (ComboBox)sender;
            ComboBox[] comboBoxes = new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5 };


            // Check if the current ComboBox already has the selected student
            bool alreadySelected = false;
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox != currentComboBox && comboBox.SelectedItem != null && comboBox.SelectedItem.Equals(currentComboBox.SelectedItem))
                {
                    alreadySelected = true;
                    break;
                }
            }

            if (alreadySelected)
            {
                // Ask the user if they want to clear the selection of the other ComboBox
                DialogResult result = MessageBox.Show("This student is already selected in another seat. Clear the other seat and select this student?", "Duplicate Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Clear the selection of the other ComboBox
                    foreach (ComboBox comboBox in comboBoxes)
                    {
                        if (comboBox != currentComboBox && comboBox.SelectedItem != null && comboBox.SelectedItem.Equals(currentComboBox.SelectedItem))
                        {
                            comboBox.SelectedItem = null;
                        }
                    }
                }
                else
                {
                    // Clear the selection of the current ComboBox
                    currentComboBox.SelectedItem = null;
                }
            }
        }

        private void cbxStudentNames2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox currentComboBox = (ComboBox)sender;
            ComboBox[] comboBoxes = new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5 };


            // Check if the current ComboBox already has the selected student
            bool alreadySelected = false;
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox != currentComboBox && comboBox.SelectedItem != null && comboBox.SelectedItem.Equals(currentComboBox.SelectedItem))
                {
                    alreadySelected = true;
                    break;
                }
            }

            if (alreadySelected)
            {
                // Ask the user if they want to clear the selection of the other ComboBox
                DialogResult result = MessageBox.Show("This student is already selected in another seat. Clear the other seat and select this student?", "Duplicate Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Clear the selection of the other ComboBox
                    foreach (ComboBox comboBox in comboBoxes)
                    {
                        if (comboBox != currentComboBox && comboBox.SelectedItem != null && comboBox.SelectedItem.Equals(currentComboBox.SelectedItem))
                        {
                            comboBox.SelectedItem = null;
                        }
                    }
                }
                else
                {
                    // Clear the selection of the current ComboBox
                    currentComboBox.SelectedItem = null;
                }
            }
        }

        private void cbxStudentNames4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox currentComboBox = (ComboBox)sender;
            ComboBox[] comboBoxes = new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5 };


            // Check if the current ComboBox already has the selected student
            bool alreadySelected = false;
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox != currentComboBox && comboBox.SelectedItem != null && comboBox.SelectedItem.Equals(currentComboBox.SelectedItem))
                {
                    alreadySelected = true;
                    break;
                }
            }

            if (alreadySelected)
            {
                // Ask the user if they want to clear the selection of the other ComboBox
                DialogResult result = MessageBox.Show("This student is already selected in another seat. Clear the other seat and select this student?", "Duplicate Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Clear the selection of the other ComboBox
                    foreach (ComboBox comboBox in comboBoxes)
                    {
                        if (comboBox != currentComboBox && comboBox.SelectedItem != null && comboBox.SelectedItem.Equals(currentComboBox.SelectedItem))
                        {
                            comboBox.SelectedItem = null;
                        }
                    }
                }
                else
                {
                    // Clear the selection of the current ComboBox
                    currentComboBox.SelectedItem = null;
                }
            }
        }

        private void cbxStudentNames3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox currentComboBox = (ComboBox)sender;
            ComboBox[] comboBoxes = new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5 };


            // Check if the current ComboBox already has the selected student
            bool alreadySelected = false;
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox != currentComboBox && comboBox.SelectedItem != null && comboBox.SelectedItem.Equals(currentComboBox.SelectedItem))
                {
                    alreadySelected = true;
                    break;
                }
            }

            if (alreadySelected)
            {
                // Ask the user if they want to clear the selection of the other ComboBox
                DialogResult result = MessageBox.Show("This student is already selected in another seat. Clear the other seat and select this student?", "Duplicate Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Clear the selection of the other ComboBox
                    foreach (ComboBox comboBox in comboBoxes)
                    {
                        if (comboBox != currentComboBox && comboBox.SelectedItem != null && comboBox.SelectedItem.Equals(currentComboBox.SelectedItem))
                        {
                            comboBox.SelectedItem = null;
                        }
                    }
                }
                else
                {
                    // Clear the selection of the current ComboBox
                    currentComboBox.SelectedItem = null;
                }
            }
        }

        private void cbxStudentNames5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox currentComboBox = (ComboBox)sender;
            ComboBox[] comboBoxes = new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5 };


            // Check if the current ComboBox already has the selected student
            bool alreadySelected = false;
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox != currentComboBox && comboBox.SelectedItem != null && comboBox.SelectedItem.Equals(currentComboBox.SelectedItem))
                {
                    alreadySelected = true;
                    break;
                }
            }

            if (alreadySelected)
            {
                // Ask the user if they want to clear the selection of the other ComboBox
                DialogResult result = MessageBox.Show("This student is already selected in another seat. Clear the other seat and select this student?", "Duplicate Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Clear the selection of the other ComboBox
                    foreach (ComboBox comboBox in comboBoxes)
                    {
                        if (comboBox != currentComboBox && comboBox.SelectedItem != null && comboBox.SelectedItem.Equals(currentComboBox.SelectedItem))
                        {
                            comboBox.SelectedItem = null;
                        }
                    }
                }
                else
                {
                    // Clear the selection of the current ComboBox
                    currentComboBox.SelectedItem = null;
                }
            }
        }
    }
}
