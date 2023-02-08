using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection_G3_sp23
{
    internal class DatabaseConnection
    {
        //establish database connection - CS
        SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        public List<clsStudent> studentList = new List<clsStudent>();
        public List<clsUser> userList = new List<clsUser>();
        public List<clsClass> classList = new List<clsClass>();
        public List<clsSubject> subjectList = new List<clsSubject>();

        //OpenDatabase Method to open database - CS
        public void OpenDatabase()
        {

            try
            {
                connection.Open();
                MessageBox.Show("Database is Open", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //CloseDatabase method to close database - CS
        public void CloseDatabase()
        {

            try
            {
                connection.Close();
                MessageBox.Show("Database is Closed", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Method to pull student info from database and put in array - CS
        public void StudentInfo()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Student", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int studentID = (int)reader["StudentID"];
                    int loginID = (int)reader["LoginID"];
                    string firstName = (string)reader["FirstName"];
                    string middleName = (string)reader["MiddleName"];
                    string lastName = (string)reader["LastName"];
                    string dateOfBirth = (string)reader["DateOfBirth"].ToString();
                    string mailingAddress = (string)reader["MailingAddress"];
                    string streetAddress = (string)reader["StreetAddress"];
                    string city = (string)reader["City"];
                    string state = (string)reader["State"];
                    string zip = (string)reader["Zip"];
                    string phoneNumber = (string)reader["PhoneNumber"];
                    string emergencyContactName = (string)reader["EmergencyContactName"];
                    string emergencyContactPhone = (string)reader["EmergencyContactPhone"];
                    string guardian1Name = (string)reader["Guardian1Name"];
                    string guardian1CellPhone = (string)reader["Guardian1CellPhone"];
                    string guardian1WorkPhone = (string)reader["Guardian1WorkPhone"];
                    string guardian1WorkPlace = (string)reader["Guardian1WorkPlace"];
                    studentList.Add(new clsStudent(studentID, loginID, firstName, middleName, lastName, dateOfBirth, mailingAddress, streetAddress,
                        city, state, zip, phoneNumber, emergencyContactName, emergencyContactPhone, guardian1Name, guardian1CellPhone, guardian1WorkPhone, guardian1WorkPlace));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string resetCode = (string)reader["ResetCode"];
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

        //Method to grab classInfo from database and put in array -CS
        public void ClassInfo()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Class", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int classID = (int)reader["ClassID"];
                    int teacherID = (int)reader["TeacherID"];
                    int subjectID = (int)reader["SubjectID"];
                    int classSize = (int)reader["ClassSize"];

                    classList.Add(new clsClass(classID, teacherID, subjectID, classSize));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Method to grab subjectInfo from database and put in array -CS
        public void SubjectInfo()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Subject", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int subjectID = (int)reader["SubjectID"];
                    string subjectName = (string)reader["SubjectName"];

                    subjectList.Add(new clsSubject(subjectID, subjectName));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

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
    }
}
