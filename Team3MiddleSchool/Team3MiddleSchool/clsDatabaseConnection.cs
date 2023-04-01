using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Team3MiddleSchool
{
    internal class clsDatabaseConnection
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

                    userList.Add(new clsUser(loginID, accountType, userName, password, resetCode, email));
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

        public void AdminAccessClasses()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT ClassName, SubjectName, ClassSize FROM team3sp232330.Class c JOIN team3sp232330.Subject s ON c.SubjectID = s.SubjectID JOIN team3sp232330.Teacher t ON t.TeacherID = c.TeacherID ", connection);

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

        public void StudentClasses(int loginID)
        {

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

        public void GetOfficerMenu(ComboBox courseList, ComboBox teacherList, ComboBox studentList, ComboBox subjectList)
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
        public void LoadEditCourse(string courseName, TextBox tbxcourseName, ComboBox teacherList, ComboBox subjectList)
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

        public void AddTeacher(string firstName, string lastName, string email, string username, string password)
        {
            try
            {
                string query = "INSERT INTO team3sp232330.Login (Email, UserName, Password, AccountType) VALUES (@email, @userName, @password, 'Teacher')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@userName", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }

                query = "INSERT INTO team3sp232330.Teacher VALUES ((SELECT TOP 1 LoginID FROM team3sp232330.Login ORDER BY LoginID DESC), @firstName, @lastName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void LoadEditTeacher(string teacherID, TextBox tbxFirstName, TextBox tbxLastName, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxPassword)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Teacher WHERE TeacherID = " + teacherID, connection);
                SqlDataReader reader = command.ExecuteReader();

                int loginID = -1;

                while (reader.Read())
                {
                    tbxFirstName.Text = (string)reader["FirstName"];
                    tbxLastName.Text = (string)reader["LastName"];
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

        public void EditTeacher(string teacherID, string firstName, string lastName, string email, string username, string password)
        {
            try
            {


                string query = "UPDATE team3sp232330.Teacher SET FirstName = @firstName, LastName = @lastName WHERE TeacherID = " + teacherID;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.ExecuteNonQuery();
                }

                query = "UPDATE team3sp232330.Login SET Email = @email, UserName = @userName, Password = @password WHERE LoginID = (SELECT LoginID FROM team3sp232330.Teacher WHERE TeacherID = " + teacherID + ")";

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

        //removes teacher from the database -CS
        public void RemoveTeacher(string teacherID)
        {
            try
            {
                string query = "DELETE FROM Teacher WHERE t.TeacherID = @teacherID ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@teacherID", teacherID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        public void GetClasses(List<string> classes)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Class", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string className = ((int)reader["ClassID"]).ToString();
                    className += " - " + (string)reader["ClassName"];
                    classes.Add(className);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetCurrentClasses(int studentID, ComboBox cbxClass1, ComboBox cbxClass2, ComboBox cbxClass3, ComboBox cbxClass4, ComboBox cbxClass5, ComboBox cbxClass6)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT Class1, Class2, Class3, Class4, Class5, Class6 FROM " +
                    "team3sp232330.StudentSchedule ss WHERE ss.StudentID = " + studentID, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<ComboBox> comboBoxes = new List<ComboBox> { cbxClass1, cbxClass2, cbxClass3, cbxClass4, cbxClass5, cbxClass6 };

                while (reader.Read())
                {
                    for (int i = 1; i <= 6; i++)
                    {
                        string classID = reader["Class" + i].ToString();
                        ComboBox cbx = comboBoxes[i - 1];
                        foreach (var item in cbx.Items)
                        {
                            string cbxText = item.ToString();
                            if (string.IsNullOrEmpty(classID))
                            {
                                cbx.SelectedItem = "";
                                break;
                            }
                            else if (cbxText.StartsWith(classID))
                            {
                                cbx.SelectedItem = item;
                                break;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditCurrentClasses(int studentID, ComboBox cbxClass1, ComboBox cbxClass2, ComboBox cbxClass3, ComboBox cbxClass4, ComboBox cbxClass5, ComboBox cbxClass6)
        {
            try
            {
                SqlCommand command = new SqlCommand("IF EXISTS (SELECT * FROM team3sp232330.StudentSchedule WHERE StudentID = @StudentID) " +
                                                    "BEGIN " +
                                                    "UPDATE team3sp232330.StudentSchedule SET Class1 = @Class1, Class2 = @Class2, " +
                                                    "Class3 = @Class3, Class4 = @Class4, Class5 = @Class5, Class6 = @Class6 WHERE StudentID = @StudentID " +
                                                    "END " +
                                                    "ELSE " +
                                                    "BEGIN " +
                                                    "INSERT INTO team3sp232330.StudentSchedule (StudentID, Class1, Class2, Class3, Class4, Class5, Class6) " +
                                                    "VALUES (@StudentID, @Class1, @Class2, @Class3, @Class4, @Class5, @Class6) " +
                                                    "END", connection);

                command.Parameters.AddWithValue("@Class1", GetClassIDFromComboBox(cbxClass1) ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Class2", GetClassIDFromComboBox(cbxClass2) ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Class3", GetClassIDFromComboBox(cbxClass3) ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Class4", GetClassIDFromComboBox(cbxClass4) ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Class5", GetClassIDFromComboBox(cbxClass5) ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Class6", GetClassIDFromComboBox(cbxClass6) ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@StudentID", studentID);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Classes updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No rows were affected by the update.", "Update Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddSubject(string subjectName)
        {
            try
            {
                string query = "INSERT INTO team3sp232330.Subject (SubjectName) VALUES ('" + subjectName + "')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditSubject(int subjectID, string subjectText)
        {
            try
            {
                string query = "UPDATE team3sp232330.Subject SET SubjectName = @subject WHERE SubjectID = " + subjectID;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@subject", subjectText);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public string GetClassIDFromComboBox(ComboBox comboBox)
        {
            string selectedItemText = comboBox.SelectedItem?.ToString();
            if (selectedItemText == null)
            {
                return null;
            }
            else
            {
                return selectedItemText.Split('-')[0].Trim();
            }
        }

        public bool ValidateCourse(string courseName)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Class", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string className = (string)reader["ClassName"];

                    if (className == courseName)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                reader.Close();
                return false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CourseHasForeign(string courseID)
        {
            //try
            //{
            //    SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Class", connection);
            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        string className = (string)reader["ClassName"];

            //        if (className == courseName)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    reader.Close();
            //    return false;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
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

        /*
         int gradeStudentID;
         public void GradeCalculations(Label lbltotalGrade)
         {

             try
             {


                 SqlCommand cmdGradeInfo = new SqlCommand("Select StudentID,Grade from team3sp232330.Grades", connection);

                 SqlDataReader reader = cmdGradeInfo.ExecuteReader();


                 while (reader.Read())

                 {
                     gradeStudentID = Convert.ToInt32(reader["StudentID"]);
                     lbltotalGrade.Text = ((decimal)reader["Grade"]).ToString();
                 }
                 reader.Close();
                 SqlDataAdapter gradeAdapterInfo = new SqlDataAdapter(cmdGradeInfo);
                 _gradeTable = new DataTable();
                 gradeAdapterInfo.Fill(_gradeTable);
                 lbltotalGrade.DataBindings.Add("Text", _gradeTable, "Grade");
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

         }*/

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
                                              ComboBox cbxStudentNames6, ComboBox cbxStudnetNames7, ComboBox cbxStudentNames8, ComboBox cbxStudentNames9, ComboBox cbxStudentNames10)
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
                    string studentInfo = $"{reader["StudentID"]} - {reader["FirstName"]} {reader["MiddleName"]} {reader["LastName"]}";


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

        public DataTable AttendanceInfo(int loginID, string accountType, string classSelect)
        {
            string classID = "";
            int spaceIndex = classSelect.IndexOf(" ");
            string className = classSelect.Substring(0, spaceIndex);
            DataTable table = new DataTable();


            if (accountType.Equals("Teacher") || accountType.Equals("Admin") || accountType.Equals("Officer"))
            {
                SqlCommand commandID = new SqlCommand("SELECT ClassID FROM team3sp232330.Class WHERE ClassName = '" + className + "';", connection);
                SqlDataReader reader = commandID.ExecuteReader();

                while (reader.Read())
                {
                    classID = $"{reader["ClassID"]}";
                }

                SqlCommand command = new SqlCommand("SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.ClassID = " + classID + ";", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                reader.Close();

                adapter.Fill(table);
            }


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

        public void Next(TextBox tbxName/*,Label lblGrade*/)
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
                /*                lblGrade.Text = _gradeTable.Rows[counter]["Grade"].ToString();*/
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Previous(TextBox tbxName /*,Label lblGrade*/)
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
                /*                lblGrade.Text = _gradeTable.Rows[counter]["Grade"].ToString();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }

}


    
