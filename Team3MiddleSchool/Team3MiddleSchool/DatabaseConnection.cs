﻿using System;
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

                    userList.Add(new clsUser(loginID,accountType, userName, password, resetCode, email));
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
            try
            {
                SqlCommand command = new SqlCommand("SELECT Class1, Class2, Class3, Class4, Class5, Class6 FROM team3sp232330.StudentSchedule sc JOIN team3sp232330.Student s ON sc.StudentID = s.StudentID WHERE LoginID = " + loginID, connection);
                SqlDataReader reader = command.ExecuteReader();
                List<int> classes = new List<int>();

                while (reader.Read())
                {
                    classes.Add(reader.IsDBNull(reader.GetOrdinal("Class1")) ? -1 : (int)reader["Class1"]);
                    classes.Add(reader.IsDBNull(reader.GetOrdinal("Class2")) ? -1 : (int)reader["Class2"]);
                    classes.Add(reader.IsDBNull(reader.GetOrdinal("Class3")) ? -1 : (int)reader["Class3"]);
                    classes.Add(reader.IsDBNull(reader.GetOrdinal("Class4")) ? -1 : (int)reader["Class4"]);
                    classes.Add(reader.IsDBNull(reader.GetOrdinal("Class5")) ? -1 : (int)reader["Class5"]);
                    classes.Add(reader.IsDBNull(reader.GetOrdinal("Class6")) ? -1 : (int)reader["Class6"]);

                }

                reader.Close();

                if (classes.Count > 0) {

                    command = new SqlCommand("SELECT ClassName, SubjectName, ClassSize FROM team3sp232330.Class c JOIN team3sp232330.Subject s on c.SubjectID = s.SubjectID WHERE ClassID IN (@id1,@id2,@id3,@id4,@id5,@id6)", connection);


                    command.Parameters.AddWithValue("@id1", classes[0]);
                    command.Parameters.AddWithValue("@id2", classes[1]);
                    command.Parameters.AddWithValue("@id3", classes[2]);
                    command.Parameters.AddWithValue("@id4", classes[3]);
                    command.Parameters.AddWithValue("@id5", classes[4]);
                    command.Parameters.AddWithValue("@id6", classes[5]);

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string className = (string)reader["ClassName"];
                        string subjectName = (string)reader["SubjectName"];
                        int classSize = (int)reader["ClassSize"];
                        classList.Add(className + " - " + subjectName + " - Class Size: " + classSize);
                    }
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ParentClasses(int loginID)
        {
            try
            {
                int parentID = GetParentID(loginID);

                SqlCommand command = new SqlCommand("SELECT Class1, Class2, Class3, Class4, Class5, Class6 FROM team3sp232330.StudentSchedule sc JOIN team3sp232330.StudentParent s ON sc.StudentID = s.StudentID WHERE ParentID = " + parentID, connection);
                SqlDataReader reader = command.ExecuteReader();
                List<int> classes = new List<int>();

                while (reader.Read())
                {
                    classes.Add(reader.IsDBNull(reader.GetOrdinal("Class1")) ? -1 : (int)reader["Class1"]);
                    classes.Add(reader.IsDBNull(reader.GetOrdinal("Class2")) ? -1 : (int)reader["Class2"]);
                    classes.Add(reader.IsDBNull(reader.GetOrdinal("Class3")) ? -1 : (int)reader["Class3"]);
                    classes.Add(reader.IsDBNull(reader.GetOrdinal("Class4")) ? -1 : (int)reader["Class4"]);
                    classes.Add(reader.IsDBNull(reader.GetOrdinal("Class5")) ? -1 : (int)reader["Class5"]);
                    classes.Add(reader.IsDBNull(reader.GetOrdinal("Class6")) ? -1 : (int)reader["Class6"]);

                }

                reader.Close();

                if (classes.Count > 0)
                {
                    command = new SqlCommand("SELECT ClassName, SubjectName, ClassSize FROM team3sp232330.Class c JOIN team3sp232330.Subject s on c.SubjectID = s.SubjectID WHERE ClassID IN (@id1,@id2,@id3,@id4,@id5,@id6)", connection);


                    command.Parameters.AddWithValue("@id1", classes[0]);
                    command.Parameters.AddWithValue("@id2", classes[1]);
                    command.Parameters.AddWithValue("@id3", classes[2]);
                    command.Parameters.AddWithValue("@id4", classes[3]);
                    command.Parameters.AddWithValue("@id5", classes[4]);
                    command.Parameters.AddWithValue("@id6", classes[5]);

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string className = (string)reader["ClassName"];
                        string subjectName = (string)reader["SubjectName"];
                        int classSize = (int)reader["ClassSize"];
                        classList.Add(className + " - " + subjectName + " - Class Size: " + classSize);
                    }
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetParentID(int loginID)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT ParentID FROM team3sp232330.Parent WHERE LoginID = " + loginID, connection);
                SqlDataReader reader = command.ExecuteReader();
                int parentID = -1;

                while (reader.Read())
                {
                    parentID = (int)reader["ParentID"];
                }

                reader.Close();
                return parentID;

            }
            catch (Exception ex)
            {
                return -1;
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

        public void GetOfficerMenu(ComboBox courseList, ComboBox teacherList, ComboBox studentList, ComboBox subjectList, ComboBox parentList)
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

                command = new SqlCommand("SELECT ParentID, LastName, FirstName FROM team3sp232330.Parent", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ID = (int)reader["ParentID"];
                    string lastName = (string)reader["LastName"];
                    string firstName = (string)reader["FirstName"];

                    parentList.Items.Add(ID + " - " + lastName + ", " + firstName);
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

        public void RemoveSubject(string subjectID)
        {
            try
            {
                string query = "DELETE team3sp232330.Subject WHERE SubjectID = @subjectID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@subjectID", subjectID);
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
                string query = "DELETE FROM team3sp232330.Teacher WHERE TeacherID = @teacherID; DELETE FROM team3sp232330.Login WHERE LoginID IN (SELECT l.LoginID FROM team3sp232330.Login l INNER JOIN team3sp232330.Teacher t ON l.LoginID = t.LoginID WHERE t.TeacherID = @teacherID)";

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

        public void AddParent(string email, string firstname, string lastname, string password, string username, string studentID)
        {
            try
            {
                string query = "INSERT INTO team3sp232330.Login (Email, UserName, Password, AccountType) VALUES (@email, @userName, @password, 'Parent')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@userName", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }

                query = "INSERT INTO team3sp232330.Parent VALUES ((SELECT TOP 1 LoginID FROM team3sp232330.Login ORDER BY LoginID DESC), @firstName, @lastName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstname);
                    command.Parameters.AddWithValue("@lastName", lastname);
                    command.ExecuteNonQuery();
                }

                query = "INSERT INTO team3sp232330.StudentParent VALUES (@studentID, (SELECT TOP 1 ParentID FROM team3sp232330.Parent ORDER BY ParentID DESC))";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadEditParent(TextBox tbxEmail, TextBox tbxFirstName, TextBox tbxLastName, TextBox tbxPassword, TextBox tbxUsername, ComboBox cbxStudentSelect, string parentID)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Parent WHERE ParentID = " + parentID, connection);
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

                command = new SqlCommand("SELECT * FROM team3sp232330.StudentParent WHERE ParentID = " + parentID, connection);
                reader = command.ExecuteReader();
                int studentID = -1;

                while (reader.Read())
                {
                    studentID = (int)reader["StudentID"];

                }
                reader.Close();

                LoadStudents(cbxStudentSelect);

                foreach (string item in cbxStudentSelect.Items)
                {
                    string currentItem = (string)item;
                    string[] currentItemSplit = currentItem.Split('-');
                    int id = int.Parse(currentItemSplit[0].Trim());

                    if (id == studentID)
                    {
                        cbxStudentSelect.SelectedItem = item;
                        break;
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditParent(TextBox tbxEmail, TextBox tbxFirstName, TextBox tbxLastName, TextBox tbxPassword, TextBox tbxUsername, ComboBox cbxStudentSelect, string parentID)
        {
            try
            {
                string query = "UPDATE team3sp232330.Login SET Email = @email, UserName = @userName, Password = @password WHERE LoginID = (SELECT LoginID FROM team3sp232330.Parent WHERE ParentID = @parentID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", tbxEmail.Text);
                    command.Parameters.AddWithValue("@userName", tbxUsername.Text);
                    command.Parameters.AddWithValue("@password", tbxPassword.Text);
                    command.Parameters.AddWithValue("@parentID", parentID);
                    command.ExecuteNonQuery();
                }

                query = "UPDATE team3sp232330.Parent SET FirstName = @firstName, LastName = @lastName WHERE ParentID = @parentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", tbxFirstName.Text);
                    command.Parameters.AddWithValue("@lastName", tbxLastName.Text);
                    command.Parameters.AddWithValue("@parentID", parentID);
                    command.ExecuteNonQuery();
                }

                query = "UPDATE team3sp232330.StudentParent SET StudentID = @studentID WHERE ParentID = @parentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string selectedItem = cbxStudentSelect.SelectedItem.ToString();
                    int studentID = int.Parse(selectedItem.Split('-')[0].Trim());
                    command.Parameters.AddWithValue("@studentID", studentID);
                    command.Parameters.AddWithValue("@parentID", parentID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        internal bool ValidateSubject(string subjectName)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Subject", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string subjectname = (string)reader["SubjectName"];

                    if (subjectName == subjectname)
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

        public bool ValidateUsername(string username)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Login", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string userName = (string)reader["UserName"];

                    if (username == userName)
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

        internal bool CheckCourseDelete(string courseID)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM team3sp232330.Attendance a JOIN team3sp232330.Grades g ON a.ClassID = a.ClassID WHERE a.ClassID = @CourseID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseID", courseID);

                    int count = (int)command.ExecuteScalar();

                    connection.Close();
                    return count == 0;
                }
            }
        }

        internal bool CheckTeacherDelete(string teacherID)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM team3sp232330.Class WHERE TeacherID = @teacherID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@teacherID", teacherID);

                    int count = (int)command.ExecuteScalar();

                    connection.Close();
                    return count == 0;
                }
            }
        }

        internal bool CheckSubjectDelete(string subjectID)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM team3sp232330.Class WHERE SubjectID = @subjectID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@subjectID", subjectID);

                    int count = (int)command.ExecuteScalar();

                    connection.Close();
                    return count == 0;
                }
            }
        }

        internal bool CheckStudentDelete(string studentID)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM team3sp232330.Attendance a JOIN team3sp232330.StudentSchedule ss ON" +
                    " a.StudentID = ss.StudentID JOIN team3sp232330.StudentParent sp ON a.StudentID = ss.StudentID JOIN " +
                    "team3sp232330.Grades g ON a.TeacherID = g.StudentID WHERE a.StudentID =  @studentID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);

                    int count = (int)command.ExecuteScalar();

                    connection.Close();
                    return count == 0;
                }
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

        //Load attendance table for logged in user and selected class from drop down menu
        public DataTable AttendanceInfo(string accountType, string classSelect, int loginID)
        {
            int classID = GetClassID(classSelect);
            int studentID = GetStudentID(loginID);
            string date = DateTime.Now.ToString("yyyyMMdd");
            DataTable table = new DataTable();


            if (accountType.Equals("Teacher") || accountType.Equals("Admin") || accountType.Equals("Officer"))
            {
                
                SqlCommand command = new SqlCommand("SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.ClassID = " + classID + " AND AttendanceDate = '" + date + "';" ,  connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                adapter.Fill(table);
            }
            else if (accountType.Equals("Student") || accountType.Equals("Parent"))
            {
                SqlCommand command = new SqlCommand("SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.StudentID, a.ClassID, a.AttendanceDate, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID WHERE a.StudentID = " + studentID + " AND a.ClassID = " + classID + ";", connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                adapter.Fill(table);
            }

            return table;
        }

        //Reload attendance table with new query
        public DataTable AttendanceInfo(String editCommand)
        {
            SqlCommand command = new SqlCommand(editCommand, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);


            return table;
        }

        //Generate days attendance if none exists and user confirms
        public DataTable GenerateAttendance(string classSelect)
        {
            int classID = GetClassID(classSelect);
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("CREATE TABLE #tempAttendance "
                                                    + "(StudentID INT PRIMARY KEY, " 
                                                    + "ClassID INT, "
                                                    + "AttendanceDate DATE, "
                                                    + "Present BIT, "
                                                    + "TeacherID INT) "
                                                + "INSERT INTO #tempAttendance (StudentID) SELECT StudentID FROM team3sp232330.StudentSchedule WHERE Class1 = " + classID + " OR Class2 = " + classID + " OR Class3 = " + classID + " OR Class4 = " + classID + " OR Class5 = " + classID + " OR Class6 = " + classID
                                                + "UPDATE #tempAttendance SET ClassID = " + classID + ", AttendanceDate = CAST(GETDATE() AT TIME ZONE 'UTC' AT TIME ZONE 'Central Standard Time' AS Date), Present = 0, TeacherID = (SELECT TeacherID FROM team3sp232330.Class WHERE ClassID = " + classID + ") "
                                                + "INSERT INTO team3sp232330.Attendance (StudentID, ClassID, AttendanceDate, Present, TeacherID) SELECT StudentID, ClassID, AttendanceDate, Present, TeacherID FROM #tempAttendance;", connection);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            adapter.Fill(table);

            return table;
        }

        //Retrieve name of teacher of selected class from menu drop down
        public string LoggedTeacher(int classID)
        {
            string teacher = "";

            SqlCommand command = new SqlCommand("SELECT CONCAT(t.FirstName, ' ', t.LastName) AS \"Teacher\" FROM team3sp232330.Class c JOIN team3sp232330.Teacher t ON c.TeacherID = t.TeacherID WHERE c.ClassID = " + classID, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                teacher = (string)reader["Teacher"];
            }
            reader.Close();

            return teacher;
        }

        //Retrieve classID for given class from menu drop down
        public int GetClassID(string classSelect)
        {
            int classID = 0;
            int spaceIndex = classSelect.IndexOf("-");
            string className = classSelect.Substring(0, spaceIndex - 1);

            SqlCommand commandID = new SqlCommand("SELECT ClassID FROM team3sp232330.Class WHERE ClassName = '" + className + "';", connection);
            SqlDataReader reader = commandID.ExecuteReader();

            while (reader.Read())
            {
                classID = Int32.Parse($"{reader["ClassID"]}");
            }

            reader.Close();

            return classID;
        }

        public int GetStudentID(int loginID)
        {
            int studentID = 0;

            SqlCommand commandID = new SqlCommand("SELECT StudentID FROM team3sp232330.StudentParent sp JOIN team3sp232330.Parent p ON sp.ParentID = p.ParentID WHERE p.LoginID = " + loginID + ";", connection);
            SqlDataReader reader = commandID.ExecuteReader();

            while (reader.Read())
            {
                studentID = Int32.Parse($"{reader["StudentID"]}");
            }

            reader.Close();

            return studentID;
        }

        public void UpdateAttendance(DataGridView dgv, string date)
        {
            List<string> studentID = new List<string>();
            List<int> present = new List<int>();

            string updateQuery = "";

            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                studentID.Add(dgv.Rows[i].Cells[1].Value.ToString());
                string convertPresent = dgv.Rows[i].Cells[4].Value.ToString().ToLower();
                if (convertPresent.Equals("true"))
                {
                    present.Add(1);
                }
                else
                {
                    present.Add(0);
                }
            }

            for (int i = 0; i < studentID.Count; i++)
            {
                updateQuery += "UPDATE team3sp232330.Attendance SET Present = " + present[i] + " WHERE StudentId = " + studentID[i] + " AND AttendanceDate = '" + date + "';";
            }

            SqlCommand command = new SqlCommand(updateQuery, connection);

            command.ExecuteNonQuery();
        }


        private static DataTable _gradeBookDataTable;

        public static DataTable gradeBookDataTable
        {
            get { return _gradeBookDataTable; }
        }

        public static void GradeBookDataGrid(DataGridView dgvGradeBook, string StudentID)
        {
            try
            {
                SqlDataAdapter gradeBookDataAdapter = new SqlDataAdapter("Select AssignmentName ,AssignmentType,Grade From team3sp232330.Grades Where StudentID='" + StudentID + "'", connection);

                _gradeBookDataTable = new DataTable();
                gradeBookDataAdapter.Fill(_gradeBookDataTable);


                dgvGradeBook.DataSource = gradeBookDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void GradeBookDataGridStudent(DataGridView dgvGradeBook, int studentID)
        {
            try
            {
                SqlDataAdapter gradeBookDataAdapter = new SqlDataAdapter("Select AssignmentName,AssignmentType,Grade from team3sp232330.Grades Where StudentID=" + studentID + " ", connection);

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

        public void GradeCalculationsStudent(Label lbltotalGrade, int studentID)
        {

            try
            {

                OpenDatabase();
                SqlCommand cmdGradeInfo = new SqlCommand("Select Grade from team3sp232330.Grades Where StudentID=" + studentID + "", connection);

                SqlDataReader reader = cmdGradeInfo.ExecuteReader();


                while (reader.Read())

                {
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

        }

        decimal decHomework, test, quiz, lab, code, final, par;

        public void getHomework(string studentID, Label test)
        {

            try
            {


                using (SqlCommand cmdGradeInfo = new SqlCommand("Select Format(avg(Grade),'#.##') as homework From team3sp232330.Grades Where AssignmentType='Homework' and StudentID=" + studentID + " ", connection))
                {
                    OpenDatabase();
                    var homework = cmdGradeInfo.ExecuteScalar();

                    if (homework == null)
                    {
                        test.Text = "0";
                    }
                    else
                    {
                        test.Text = homework.ToString();
                        decHomework = (decimal)homework;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void getQuiz(string studentID)
        {

            try
            {

                OpenDatabase();
                SqlCommand cmdGradeInfo = new SqlCommand("Select Format(avg(Grade),'#.##') as quiz From team3sp232330.Grades Where AssignmentType='Quiz' and StudentID=" + studentID + " ", connection);

                SqlDataReader reader = cmdGradeInfo.ExecuteReader();


                while (reader.Read())

                {
                    quiz = ((decimal)reader["quiz"]);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void getTest(string studentID)
        {

            try
            {

                OpenDatabase();
                SqlCommand cmdGradeInfo = new SqlCommand("Select Format(avg(Grade),'#.##') as test From team3sp232330.Grades Where AssignmentType='Test' and StudentID=" + studentID + " ", connection);

                SqlDataReader reader = cmdGradeInfo.ExecuteReader();


                while (reader.Read())

                {
                    test = ((decimal)reader["test"]);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void getLab(string studentID)
        {

            try
            {

                OpenDatabase();
                SqlCommand cmdGradeInfo = new SqlCommand("Select Format(avg(Grade),'#.##') as lab From team3sp232330.Grades Where AssignmentType='Lab' and StudentID=" + studentID + " ", connection);

                SqlDataReader reader = cmdGradeInfo.ExecuteReader();


                while (reader.Read())

                {
                    lab = ((decimal)reader["lab"]);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void getCode(string studentID)
        {

            try
            {

                OpenDatabase();
                SqlCommand cmdGradeInfo = new SqlCommand("Select Format(avg(Grade),'#.##') as code From team3sp232330.Grades Where AssignmentType='Code' and StudentID=" + studentID + " ", connection);

                SqlDataReader reader = cmdGradeInfo.ExecuteReader();


                while (reader.Read())

                {
                    code = ((decimal)reader["code"]);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void getFinal(string studentID)
        {

            try
            {

                OpenDatabase();
                SqlCommand cmdGradeInfo = new SqlCommand("Select Format(avg(Grade),'#.##') as final From team3sp232330.Grades Where AssignmentType='Final' and StudentID=" + studentID + " ", connection);

                SqlDataReader reader = cmdGradeInfo.ExecuteReader();


                while (reader.Read())

                {
                    final = ((decimal)reader["final"]);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void getParticipation(string studentID)
        {

            try
            {

                OpenDatabase();
                SqlCommand cmdGradeInfo = new SqlCommand("Select Format(avg(Grade),'#.##') as par From team3sp232330.Grades Where AssignmentType='Participation' and StudentID=" + studentID + " ", connection);

                SqlDataReader reader = cmdGradeInfo.ExecuteReader();


                while (reader.Read())

                {
                    par = ((decimal)reader["par"]);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void displayGrade(Label lbltotalGrades)
        {
            try
            {
                decimal totalGrade = 0;

                decHomework = decHomework / 10;
                /*                quiz= quiz / 15;
                                lab= lab / 25;
                                code= code / 25;
                                final= final / 20;
                                par= par / 5;*/

                totalGrade = decHomework; /*+ quiz + lab + code + final + par;*/

                lbltotalGrades.Text = totalGrade.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Displaying Grade", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void RemoveGradeBook(DataGridView dgvGradebook, string studentID)
        {
            try
            {
                string query = "Delete From team3sp232330.Grades Where AssignmentName='" + dgvGradebook.CurrentCell.FormattedValue + "' And StudentID=" + studentID + "";

                SqlCommand cmdRemove = new SqlCommand(query, connection);
                SqlDataAdapter removeAdapter = new SqlDataAdapter(cmdRemove);

                removeAdapter.Fill(_gradeBookDataTable);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void AddGradeBook(int studentID, TextBox tbxAssignName, TextBox tbxAssignType, TextBox tbxGrade)
        {
            try
            {
                string query = "Insert Into team3sp232330.Grades(AssignmentName,AssignmentType,Grade) Values('" + tbxAssignName.Text + "','" + tbxAssignType.Text + "'," + tbxGrade.Text + ")Where StudentID=" + studentID + "";
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


        //add the command object
        private static SqlCommand _nameCommand;

        //data adapter
        private static SqlDataAdapter _nameAD = new SqlDataAdapter();
        //data tables
        public static DataTable _nameeTable = new DataTable();

        public static void MidTermGName(TextBox tbxName,Label ID)
        {
            try
            {
                string query = "Select CONCAT(FirstName,' ',LastName)as studentName,StudentID as ID from team3sp232330.Student ";
                _nameCommand = new SqlCommand(query, connection);
                _nameAD.SelectCommand = _nameCommand;
                _nameAD.Fill(_nameeTable);
                tbxName.DataBindings.Add("Text", _nameeTable, "studentName");
                ID.DataBindings.Add("Text", _nameeTable, "ID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Processing SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void MidTermGNameStudent(TextBox tbxName, int loginID)
        {
            try
            {
                string query = "Select CONCAT(FirstName,' ',LastName) as studentName FROM team3sp232330.Student Where LoginID=" + loginID + "";
                _nameCommand = new SqlCommand(query, connection);
                _nameAD.SelectCommand = _nameCommand;
                _nameAD.Fill(_nameeTable);
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

        public void LoadStudents(ComboBox cbxStudentSelect)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Student", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string studentInfo = $"{reader["StudentID"]} - {reader["FirstName"]} {reader["LastName"]}";
                    cbxStudentSelect.Items.Add(studentInfo);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal int GetStudentID(int loginID)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT StudentID FROM team3sp232330.Student WHERE LoginID = " + loginID, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int studentID = (int)reader["StudentID"];
                    return studentID;
                }
                return -1;
                reader.Close();
            }
            catch (Exception ex)
            {
                return -1;
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}


    
