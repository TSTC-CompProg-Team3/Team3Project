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
    public partial class frmSeatingChart5 : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public frmSeatingChart5()
        {
            InitializeComponent();
            LoadStudentNames();
        }

        private void btnRan_Click(object sender, EventArgs e)
        {
            // Set the Random button color and text color
            btnRan.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnRan.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            Random random = new Random();

            // Create an array to store the combo Boxes variables
            ComboBox[] comboBoxes = new ComboBox[] { cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5};

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
            int randomNum = random.Next(allNames.Count);
            int randomNum2 = random.Next(allNames.Count - 1);
            int randomNum3 = random.Next(allNames.Count - 2);
            int randomNum4 = random.Next(allNames.Count - 3);
            int randomNum5 = random.Next(allNames.Count - 4);

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


        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // Set the Menu button color and text color
            btnMain.BackColor = ColorTranslator.FromHtml("#FF5733");
            btnMain.ForeColor = ColorTranslator.FromHtml("#F2F2F2");

            new frmLogin().Show();
            this.Hide();
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

            

            database.PopulateStudentListBox(lstStudentsAvailable);
        }

        private void LoadStudentNames()
        {
            List<string> studentNames = database.GetStudentNames(cbxStudentNames, cbxStudentNames2, cbxStudentNames3, cbxStudentNames4, cbxStudentNames5);

            // add students to cbx 
            foreach (string name in studentNames)
            {
                cbxStudentNames.Items.Add(name);
                cbxStudentNames2.Items.Add(name);
                cbxStudentNames3.Items.Add(name);
                cbxStudentNames4.Items.Add(name);
                cbxStudentNames5.Items.Add(name);
            }
        }

        
    }
}
