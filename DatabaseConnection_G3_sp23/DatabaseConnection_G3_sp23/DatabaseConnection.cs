using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DatabaseConnection_G3_sp23
{
    internal class DatabaseConnection
    {
        //establish database connection - CS
        static SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        public List<clsStudent> studentList = new List<clsStudent>();
        public List<clsUser> userList = new List<clsUser>();
        public List<string> classList = new List<string>();
        public List<clsSubject> subjectList = new List<clsSubject>();

        //OpenDatabase Method to open database - CS
        public void OpenDatabase()
        {

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //CloseDatabase method to close database - CS
        public void CloseDatabase()
        {

            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Method to grab userinfo from database and put in array -CS
        public void UserInfo()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Login", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int loginID = (int)reader["LoginID"];
                    string accountType = (string)reader["AccountType"];
                    string userName = (string)reader["UserName"];
                    string password = (string)reader["Password"];
                    string resetCode = reader.IsDBNull(reader.GetOrdinal("ResetCode")) ? null : (string)reader["ResetCode"];
                    string email = (string)reader["Email"];

                    userList.Add(new clsUser(loginID,accountType,userName,password, resetCode, email));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Stores the reset password in database -CS
        public void StoreResetCodeInDatabase(string email, string resetCode)
        {
            try
            {
                string query = "UPDATE team3sp232330.Login SET ResetCode = @resetCode WHERE Email = @email";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@resetCode", resetCode);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Resets the password in database -CS
        public void ResetPassword(string newPass, string resetCode)
        {
            try
            {
                string query = "UPDATE team3sp232330.Login SET Password = @password WHERE ResetCode = @resetCode";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@password", newPass);
                    command.Parameters.AddWithValue("@resetCode", resetCode);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AdminAccessClasses(int teacherID)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT ClassName, SubjectName, ClassSize FROM team3sp232330.Class c JOIN team3sp232330.Subject s ON c.SubjectID = s.SubjectID JOIN team3sp232330.Teacher t ON t.TeacherID = c.TeacherID WHERE c.TeacherID = @TeacherID", connection);
                command.Parameters.AddWithValue("@TeacherID", teacherID);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string className = (string)reader["ClassName"];
                    string subjectName = (string)reader["SubjectName"];
                    int classSize = (int)reader["ClassSize"];
                    classList.Add(className + " - " + subjectName + " - Class Size: " + classSize);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        //Gets teachers classes for Cbx -CS
        public void TeacherClasses(int loginID)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select ClassName, SubjectName, ClassSize FROM team3sp232330.Class c JOIN team3sp232330.Subject s ON c.SubjectID = s.SubjectID JOIN team3sp232330.Teacher t ON t.TeacherID = c.TeacherID WHERE LoginID = " + loginID, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string className = (string)reader["ClassName"];
                    string subjectName = (string)reader["SubjectName"];
                    int classSize = (int)reader["ClassSize"];
                    classList.Add(className + " - " + subjectName + " - Class Size: " + classSize);
                }
                
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       


        //loads the admin menu info -CS
        public void LoadAdminMenu(ComboBox courseList, ComboBox teacherList, ComboBox studentList)
        {
            try
            {

                SqlCommand command = new SqlCommand("Select ClassID, ClassName, SubjectName FROM team3sp232330.Class c JOIN team3sp232330.Subject s ON c.SubjectID = s.SubjectID JOIN team3sp232330.Teacher t ON t.TeacherID = c.TeacherID", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int classID = (int)reader["ClassID"];
                    string className = (string)reader["ClassName"];
                    string subjectName = (string)reader["SubjectName"];

                    courseList.Items.Add(classID.ToString() + " - " + className + " - " + subjectName);
                }
                reader.Close();


                command = new SqlCommand("SELECT TeacherID, LastName, FirstName FROM team3sp232330.Teacher", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ID = (int)reader["TeacherID"];
                    string lastName = (string)reader["LastName"];
                    string firstName = (string)reader["FirstName"];

                    teacherList.Items.Add(ID + " - " + lastName + ", " + firstName);
                }
                reader.Close();

                command = new SqlCommand("SELECT StudentID, LastName, FirstName FROM team3sp232330.Student", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ID = (int)reader["StudentID"];
                    string lastName = (string)reader["LastName"];
                    string firstName = (string)reader["FirstName"];

                    studentList.Items.Add(ID + " - " + lastName + ", " + firstName);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //loads the add course info -CS
        public void LoadAddCourse(ComboBox teacherList, ComboBox subjectList)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT TeacherID, LastName, FirstName FROM team3sp232330.Teacher", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ID = (int)reader["TeacherID"];
                    string lastName = (string)reader["LastName"];
                    string firstName = (string)reader["FirstName"];

                    teacherList.Items.Add(ID + " - " + lastName + ", " + firstName);
                }
                reader.Close();

                command = new SqlCommand("SELECT SubjectID, SubjectName FROM team3sp232330.Subject", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ID = (int)reader["SubjectID"];
                    string subjectName = (string)reader["SubjectName"];

                    subjectList.Items.Add(ID + " - " + subjectName);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Removes selected course in admin menu -CS
        public void RemoveCourse(string classID)
        {
            try
            {
                string query = "DELETE team3sp232330.Class WHERE ClassID = @classID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@classID", classID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Adds the course entered into the database
        public void AddCourse(string classID, string teacherID, string subjectID, string classSize)
        {
            try
            {
                string query = "INSERT INTO team3sp232330.Class VALUES (@classID, @teacherID, @subjectID, @classSize)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@classID", classID);
                    command.Parameters.AddWithValue("@teacherID", teacherID);
                    command.Parameters.AddWithValue("@subjectID", subjectID);
                    command.Parameters.AddWithValue("@classSize", classSize);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //loads the edit course info -CS
        public void LoadEditCourse(string courseName, TextBox tbxcourseName,  ComboBox teacherList, ComboBox subjectList)
        {
            try
            {
                tbxcourseName.Text = courseName;

                SqlCommand command = new SqlCommand("SELECT SubjectID, SubjectName FROM team3sp232330.Subject", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int subjectID = (int)reader["SubjectID"];
                    string subjectName = (string)reader["SubjectName"];
                    subjectList.Items.Add(subjectID + " - " + subjectName);
                }
                reader.Close();

                command = new SqlCommand("SELECT TeacherID, LastName, FirstName FROM team3sp232330.Teacher", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int teacherID = (int)reader["TeacherID"];
                    string lastName = (string)reader["LastName"];
                    string firstName = (string)reader["FirstName"];
                    teacherList.Items.Add(teacherID + " - " + lastName + ", " + firstName);
                }
                reader.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Edits the course in the database -CS
        public void EditCourse(string classID, string className, string teacherID, string subjectID, string classSize)
        {
            try
            {
                string query = "UPDATE team3sp232330.Class SET ClassName = @className, TeacherID = @teacherID, SubjectID = @subjectID, ClassSize = @classSize WHERE ClassID = " + classID;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@className", className);
                    command.Parameters.AddWithValue("@teacherID", teacherID);
                    command.Parameters.AddWithValue("@subjectID", subjectID);
                    command.Parameters.AddWithValue("@classSize", classSize);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //removes teacher from the database -CS
        public void RemoveTeacher(string teacherID)
        {
            //try
            //{
            //    string query = "DELETE c FROM team3sp232330.Class c WHERE c.TeacherID = @teacherID DELETE t FROM team3sp232330.Teacher t INNER JOIN team3sp232330.Class c ON t.TeacherID = c.TeacherID WHERE t.TeacherID = @teacherID ";

            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@teacherID", teacherID);
            //        command.ExecuteNonQuery();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            MessageBox.Show("Remove Teacher under construction due to database foreign keys", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AddStudent(string firstName, string middleName, string lastName, DateTime dateOfBirth, string phoneNumber, string mailingAddress, string streetAddress, string city, string state, string zip, string email, string username, string password, string emerContactName, string emerContactPhone, string guardianName, string guardianCell, string guardianWorkPhone, string guardianWorkPl)
        {
            try
            {
                string query = "INSERT INTO team3sp232330.Login (Email, UserName, Password, AccountType) VALUES (@email, @userName, @password, 'student')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@userName", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }

                query = "INSERT INTO team3sp232330.Student VALUES ((SELECT TOP 1 LoginID FROM team3sp232330.Login ORDER BY LoginID DESC), @firstName, @middleName, @lastName, @dateOfBirth," +
                    "@mailingAddress, @streetAddress, @city, @state, @zip, @phoneNumber, @emergencyContactName, @emergencyContactPhone," +
                    "@guardian1Name, @guardian1CellPhone, @guardian1WorkPhone, @guardian1WorkPlace)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@middleName", middleName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@mailingAddress", mailingAddress);
                    command.Parameters.AddWithValue("@streetAddress", streetAddress);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@zip", zip);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@emergencyContactName", emerContactName);
                    command.Parameters.AddWithValue("@emergencyContactPhone", emerContactPhone);
                    command.Parameters.AddWithValue("@guardian1Name", guardianName);
                    command.Parameters.AddWithValue("@guardian1CellPhone", guardianCell);
                    command.Parameters.AddWithValue("@guardian1WorkPhone", guardianWorkPhone);
                    command.Parameters.AddWithValue("@guardian1WorkPlace", guardianWorkPl);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveStudent(string studentID)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT LoginID FROM team3sp232330.Student WHERE StudentID = " + studentID, connection);
                SqlDataReader reader = command.ExecuteReader();

                int loginID = -1;

                while (reader.Read())
                {
                     loginID = (int)reader["LoginID"];
                }
                reader.Close();

                string query = "DELETE team3sp232330.Student WHERE StudentID = @studentID DELETE team3sp232330.Login WHERE LoginID = " + loginID;

                using (command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadEditStudent(string studentID, TextBox tbxFirstName, TextBox tbxMiddleName, TextBox tbxLastName, 
            DateTimePicker dtpDateOfBirth, TextBox tbxPhoneNumber, TextBox tbxMailingAddress, TextBox tbxStreetAddress, TextBox tbxCity, 
            TextBox tbxState, TextBox tbxZip, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxPassword, TextBox tbxEmerContactName, 
            TextBox tbxEmerContactPhone, TextBox tbxGuardianName, TextBox tbxGuardianCell, TextBox tbxGuardianWork, 
            TextBox tbxGuardianWorkPl)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Student WHERE StudentID = " + studentID, connection);
                SqlDataReader reader = command.ExecuteReader();

                int loginID = -1;

                while (reader.Read())
                {
                    tbxFirstName.Text = (string)reader["FirstName"];
                    tbxMiddleName.Text = (string)reader["MiddleName"];
                    tbxLastName.Text = (string)reader["LastName"];
                    dtpDateOfBirth.Value = (DateTime)reader["DateOfBirth"];
                    tbxPhoneNumber.Text = (string)reader["PhoneNumber"];
                    tbxMailingAddress.Text = (string)reader["MailingAddress"];
                    tbxStreetAddress.Text = (string)reader["StreetAddress"];
                    tbxCity.Text = (string)reader["City"];
                    tbxState.Text = (string)reader["State"];
                    tbxZip.Text = (string)reader["Zip"];
                    tbxEmerContactName.Text = (string)reader["EmergencyContactName"];
                    tbxEmerContactPhone.Text = (string)reader["EmergencyContactPhone"];
                    tbxGuardianName.Text = (string)reader["Guardian1Name"];
                    tbxGuardianCell.Text = (string)reader["Guardian1CellPhone"];
                    tbxGuardianWork.Text = (string)reader["Guardian1WorkPhone"];
                    tbxGuardianWorkPl.Text = (string)reader["Guardian1WorkPlace"];
                    loginID = (int)reader["LoginID"];
                }
                reader.Close();

                command = new SqlCommand("SELECT * FROM team3sp232330.Login WHERE LoginID = " + loginID, connection);
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    tbxEmail.Text = (string)reader["Email"];
                    tbxUsername.Text = (string)reader["UserName"];
                    tbxPassword.Text = (string)reader["Password"];

                }
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditStudent(string studentID, string firstName, string middleName, string lastName, DateTime dateOfBirth, string phoneNumber, string mailingAddress, string streetAddress, string city, string state, string zip, string email, string username, string password, string emerContactName, string emerContactPhone, string guardianName, string guardianCell, string guardianWorkPhone, string guardianWorkPl)
        {
            try
            {
                

                string query = "UPDATE team3sp232330.Student SET FirstName = @firstName, MiddleName = @middleName, LastName = @lastName," +
                    " DateOfBirth = @dateOfBirth, MailingAddress = @mailingAddress, StreetAddress = @streetAddress, City = @city," +
                    " State = @state, Zip = @zip, PhoneNumber = @phoneNumber, EmergencyContactName = @emergencyContactName, " +
                    "EmergencyContactPhone = @emergencyContactPhone, Guardian1Name = @guardian1Name, Guardian1CellPhone = @guardian1CellPhone," +
                    " Guardian1WorkPhone = @guardian1WorkPhone, Guardian1WorkPlace = @guardian1WorkPlace WHERE StudentID = " + studentID;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@middleName", middleName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@mailingAddress", mailingAddress);
                    command.Parameters.AddWithValue("@streetAddress", streetAddress);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@zip", zip);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@emergencyContactName", emerContactName);
                    command.Parameters.AddWithValue("@emergencyContactPhone", emerContactPhone);
                    command.Parameters.AddWithValue("@guardian1Name", guardianName);
                    command.Parameters.AddWithValue("@guardian1CellPhone", guardianCell);
                    command.Parameters.AddWithValue("@guardian1WorkPhone", guardianWorkPhone);
                    command.Parameters.AddWithValue("@guardian1WorkPlace", guardianWorkPl);
                    command.ExecuteNonQuery();
                }

                query = "UPDATE team3sp232330.Login SET Email = @email, UserName = @userName, Password = @password WHERE LoginID = (SELECT LoginID FROM team3sp232330.Student WHERE StudentID = " + studentID + ")";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@userName", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static DataTable _gradeBookDataTable;

        public static DataTable gradeBookDataTable
        {
            get { return _gradeBookDataTable; }
        }
        public static void GradeBookDataGrid(DataGridView dgvGradeBook, int counter)
        {
            try
            {
                SqlDataAdapter gradeBookDataAdapter = new SqlDataAdapter("Select AssignmentName ,AssignmentType,Grade From team3sp232330.Grades Where StudentID=" + counter + ";", connection);

                _gradeBookDataTable = new DataTable();
                gradeBookDataAdapter.Fill(_gradeBookDataTable);


                dgvGradeBook.DataSource = gradeBookDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable _gradeTable;

        public void GradeCalculations(int counter, DataGridView dgvGradebook, Label lbltotalGrade, Label lblQuiz, Label lblParticipation, Label lblHomework, Label lblLab, Label lblTest)
        {
            string query = "Select Grade From team3sp232330.Grades Where StudentID=" + counter + "";

            SqlCommand cmdGrade = new SqlCommand(query, connection);

            SqlDataAdapter gradeAdapter = new SqlDataAdapter(cmdGrade);

            _gradeTable = new DataTable();
            gradeAdapter.Fill(_gradeTable);

        }

        private static DataTable _nameTable;
        public static void GradeBookName(Label lblName)
        {
            try
            {
                string query = "Select CONCAT(FirstName,' ',LastName) as studentName from team3sp232330.Student";

                SqlCommand cmdName = new SqlCommand(query, connection);

                SqlDataAdapter nameAdapter = new SqlDataAdapter(cmdName);

                _nameTable = new DataTable();
                nameAdapter.Fill(_nameTable);
                lblName.DataBindings.Add("Text", _nameTable, "studentName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
     
        static frmGradebook frmGradebook = new frmGradebook();
        public static void RemoveGradeBook(DataGridView dgvGradebook, int counter)
        {
            try
            {
                string query = "Delete From team3sp232330.Grades Where AssignmentName='" + dgvGradebook.CurrentCell.FormattedValue + "' And StudentID=" + counter + "";

                SqlCommand cmdRemove = new SqlCommand(query, connection);
                SqlDataAdapter removeAdapter = new SqlDataAdapter(cmdRemove);

                removeAdapter.Fill(_gradeBookDataTable);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void AddGradeBook(int counter, TextBox tbxAssignName, TextBox tbxAssignType, TextBox tbxGrade)
        {
            try
            {
                string query = "Insert Into team3sp232330.Grades(StudentID,AssignmentName,AssignmentType,Grade) Values(" + counter + ",'" + tbxAssignName.Text + "','" + tbxAssignType.Text + "'," + tbxGrade.Text + ")";
                SqlCommand cmdAdd = new SqlCommand(query, connection);

                SqlDataAdapter addAdapter = new SqlDataAdapter(cmdAdd);

                addAdapter.Fill(_gradeBookDataTable);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void EditGradeBook(DataGridView dgvGradebook, int counter, TextBox tbxAssignName, TextBox tbxAssignType, TextBox tbxGrade)
        {
            try
            {
                string query = "Update team3sp232330.Grades set AssignmentName='" + tbxAssignName.Text + "', AssignmentType='" + tbxAssignType.Text + "',Grade=" + tbxGrade.Text + " Where AssignmentName='" + dgvGradebook.CurrentCell.FormattedValue + "' And StudentID=" + counter + "";
                SqlCommand cmdEdit = new SqlCommand(query, connection);


                SqlDataAdapter editAdapter = new SqlDataAdapter(cmdEdit);
                editAdapter.Fill(_gradeBookDataTable);
                MessageBox.Show("Edit Successful");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public List<string> GetStudentNames20(ComboBox cbxStudentNames, ComboBox cbxStudentNames2, ComboBox cbxStudentNames3, ComboBox cbxStudentNames4, ComboBox cbxStudentNames5,
                                              ComboBox cbxStudentNames6, ComboBox cbxStudnetNames7, ComboBox cbxStudentNames8, ComboBox cbxStudentNames9, ComboBox cbxStudentNames10,
                                              ComboBox cbxStudentNames11, ComboBox cbxStudentNames12, ComboBox cbxStudentNames13, ComboBox cbxStudentNames14, ComboBox cbxStudentNames15,
                                              ComboBox cbxStudentNames16, ComboBox cbxStudentNames17, ComboBox cbxStudentNames18, ComboBox cbxStudentNames19, ComboBox cbxStudentNames20)
        {
            List<string> studentNames = new List<string>();

            try
            {
                using (SqlCommand command = new SqlCommand("SELECT FirstName, LastName FROM team3sp232330.Student", connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();
                            string fullName = $"{firstName} {lastName}";
                            studentNames.Add(fullName);

                            // Add the item to each ComboBox
                            cbxStudentNames.Items.Add(fullName);
                            cbxStudentNames2.Items.Add(fullName);
                            cbxStudentNames3.Items.Add(fullName);
                            cbxStudentNames4.Items.Add(fullName);
                            cbxStudentNames5.Items.Add(fullName);
                            cbxStudentNames6.Items.Add(fullName);
                            cbxStudnetNames7.Items.Add(fullName);
                            cbxStudentNames8.Items.Add(fullName);
                            cbxStudentNames9.Items.Add(fullName);
                            cbxStudentNames10.Items.Add(fullName);
                            cbxStudentNames11.Items.Add(fullName);
                            cbxStudentNames12.Items.Add(fullName);
                            cbxStudentNames13.Items.Add(fullName);
                            cbxStudentNames14.Items.Add(fullName);
                            cbxStudentNames15.Items.Add(fullName);
                            cbxStudentNames16.Items.Add(fullName);
                            cbxStudentNames17.Items.Add(fullName);
                            cbxStudentNames18.Items.Add(fullName);  
                            cbxStudentNames19.Items.Add(fullName);
                            cbxStudentNames20.Items.Add(fullName);
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return studentNames;
        }

        public List<string> GetStudentNames10(ComboBox cbxStudentNames, ComboBox cbxStudentNames2, ComboBox cbxStudentNames3, ComboBox cbxStudentNames4, ComboBox cbxStudentNames5,
                                              ComboBox cbxStudentNames6, ComboBox cbxStudnetNames7, ComboBox cbxStudentNames8, ComboBox cbxStudentNames9, ComboBox cbxStudentNames10 )
        {
            List<string> studentNames = new List<string>();

            try
            {
                using (SqlCommand command = new SqlCommand("SELECT FirstName, LastName FROM team3sp232330.Student", connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();
                            string fullName = $"{firstName} {lastName}";
                            studentNames.Add(fullName);

                            // Add the item to each ComboBox
                            cbxStudentNames.Items.Add(fullName);
                            cbxStudentNames2.Items.Add(fullName);
                            cbxStudentNames3.Items.Add(fullName);
                            cbxStudentNames4.Items.Add(fullName);
                            cbxStudentNames5.Items.Add(fullName);
                            cbxStudentNames6.Items.Add(fullName);
                            cbxStudnetNames7.Items.Add(fullName);
                            cbxStudentNames8.Items.Add(fullName);
                            cbxStudentNames9.Items.Add(fullName);
                            cbxStudentNames10.Items.Add(fullName);
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return studentNames;
        }


        public List<string> GetStudentNames(ComboBox cbxStudentNames, ComboBox cbxStudentNames2, ComboBox cbxStudentName3, ComboBox cbxStudentName4, ComboBox cbxStudentName5)
        {
            List<string> studentNames = new List<string>();

            try
            {
                using (SqlCommand command = new SqlCommand("SELECT FirstName, LastName FROM team3sp232330.Student", connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();
                            string fullName = $"{firstName} {lastName}";
                            studentNames.Add(fullName);

                            // Add the item to each ComboBox
                            cbxStudentNames.Items.Add(fullName);
                            cbxStudentNames2.Items.Add(fullName);
                            cbxStudentName3.Items.Add(fullName);
                            cbxStudentName4.Items.Add(fullName);
                            cbxStudentName5.Items.Add(fullName);
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return studentNames;
        }



        public void PopulateStudentListBox(ListBox lstStudentsAvailable)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Student", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Create a string representation of the student's information
                    string studentInfo = $"{reader["FirstName"]} {reader["MiddleName"]} {reader["LastName"]},";
                                         

                    // Add the student's information to the ListBox
                    lstStudentsAvailable.Items.Add(studentInfo);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable AttendanceInfo()
        {
            SqlCommand command = new SqlCommand("SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.StudentID, a.ClassID, a.AttendanceDate,  a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID;", connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);


            return table;
        }

        public DataTable AttendanceInfo(String editCommand)
        {
            SqlCommand command = new SqlCommand(editCommand, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);


            return table;
        }


        //add the command object
        private static SqlCommand _midTermGCommand;

        //data adapter
        private static SqlDataAdapter _midTermG = new SqlDataAdapter();
        //data tables
        private static DataTable _midTermGTable = new DataTable();

        public static DataTable MidTermGDT
        {
            get { return _midTermGTable; }
            // set { _midTermGTable = value; }
        }
        public static void MidTermG(DataGridView dgvMDG, int counter)
        {


            try
            {


                string query = "Select AssignmentName, AssignmentType, Grade From team3sp232330.Grades ";
                //est command obj
                _midTermGCommand = new SqlCommand(query, connection);
                //est data adapter
                //_midTermG = new SqlDataAdapter();
                _midTermG.SelectCommand = _midTermGCommand;
                //fill data table
                //_midTermGTable = new DataTable();
                _midTermG.Fill(_midTermGTable);
                dgvMDG.DataSource = _midTermGTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Processing SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //add the command object
        private static SqlCommand _nameCommand;

        //data adapter
        private static SqlDataAdapter _nameAD = new SqlDataAdapter();
        //data tables
        private static DataTable _nameeTable = new DataTable();

        public static void MidTermGName(TextBox tbxName)
        {
            try
            {
                string query = "Select CONCAT(FirstName,' ',LastName) as studentName FROM team3sp232330.Student";
                _nameCommand = new SqlCommand(query, connection);
                _nameAD.SelectCommand = _nameCommand;
                _nameAD.Fill(_nameeTable);
                tbxName.DataBindings.Add("Text", _nameeTable, "studentName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Processing SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static int counter = 0;

        public void Next(TextBox tbxName)
        {

            try
            {
                if (counter >= _nameeTable.Rows.Count - 1)
                {
                    counter = _nameeTable.Rows.Count - 1;
                }
                else
                {
                    counter++;
                }
                tbxName.Text = _nameeTable.Rows[counter]["studentName"].ToString();
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Previous(TextBox tbxName)
        {
           
            try
            {
                if (counter <= 0)
                {
                    counter = 0;
                }
                else
                {
                    counter--;
                }
                tbxName.Text = _nameeTable.Rows[counter]["studentName"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }


}


    
