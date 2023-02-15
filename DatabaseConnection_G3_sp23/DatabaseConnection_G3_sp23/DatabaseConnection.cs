using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        public List<clsStudent> studentList = new List<clsStudent>();
        public List<clsUser> userList = new List<clsUser>();
        public List<string> classList = new List<string>();
        public List<clsSubject> subjectList = new List<clsSubject>();


        //OpenDatabase Method to open database - CS
        public void OpenDatabase(ToolStripStatusLabel connect)
        {

            try
            {
                connection.Open();
                connect.Text = "Online";
                connect.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                connect.Text = "Offline";
                connect.ForeColor = Color.Red;
            }

        }

        //CloseDatabase method to close database - CS
        public void CloseDatabase(ToolStripStatusLabel connect)
        {

            try
            {
                connection.Close();
                connect.Text = "Offline";
                connect.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                connect.Text = "Online";
                connect.ForeColor = Color.Green;
            }


        }

        //Method to pull student info from database and put in array - CS
        public void StudentInfo()
        {
            try
            {
                connection.Open();
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

        public void loadDataGridView(DataGridView dgvStudentSeats)
        {
            try
            {
                
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT TOP 10 * FROM team3sp232330.Student", connection);
                DataTable dttable = new DataTable();
                // Use a SqlDataAdapter to fill the DataTable
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dttable);
                connection.Close();
                dgvStudentSeats.DataSource = dttable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    string fullName = $"{reader["FirstName"]} {reader["LastName"]}";
                    lstStudentsAvailable.Items.Add(fullName);
                }

                reader.Close();
                connection.Close();
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

        

        ////Method to grab classInfo from database and put in array -CS
        //public void ClassInfo()
        //{
        //    try
        //    {
        //        SqlCommand command = new SqlCommand("SELECT * FROM team3sp232330.Class", connection);
        //        SqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            int classID = (int)reader["ClassID"];
        //            int teacherID = (int)reader["TeacherID"];
        //            int subjectID = (int)reader["SubjectID"];
        //            int classSize = (int)reader["ClassSize"];

        //            classList.Add(new clsClass(classID, teacherID, subjectID, classSize));
        //        }
        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }


        //}

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

        //Updates the userlist after password reset -CS
        public void UpdateUserList()
        {
            userList.Clear();
            UserInfo();
        }

        //Gets teachers classes for Cbx -CS
        public void TeacherClasses(int loginID)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select ClassID, SubjectName FROM team3sp232330.Class c JOIN team3sp232330.Subject s ON c.SubjectID = s.SubjectID JOIN team3sp232330.Teacher t ON t.TeacherID = c.TeacherID WHERE LoginID =  " + loginID, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int classID = (int)reader["ClassID"];
                    string subjectName = (string)reader["SubjectName"];

                    classList.Add(classID + " - " + subjectName);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Gets all classes for Cbx -CS
        public void AllClasses()
        {
            try
            {
                SqlCommand command = new SqlCommand("Select ClassID, SubjectName FROM team3sp232330.Class c JOIN team3sp232330.Subject s ON c.SubjectID = s.SubjectID JOIN team3sp232330.Teacher t ON t.TeacherID = c.TeacherID", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int classID = (int)reader["ClassID"];
                    string subjectName = (string)reader["SubjectName"];

                    classList.Add(classID + " - " + subjectName);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Gets all classes for Cbx -CS
        public void UpdateAllClasses()
        {
            classList.Clear();
            AllClasses();
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

        //
        public void LoadAddCourse(ComboBox teacherID, ComboBox subjectID)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT TeacherID, LastName, FirstName FROM team3sp232330.Teacher", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string ID = (string)reader["TeacherID"];
                    string lastName = (string)reader["LastName"];
                    string firstName = (string)reader["FirstName"];

                    teacherID.Items.Add(teacherID + " - " + lastName + ", " + firstName);
                }
                reader.Close();

                command = new SqlCommand("SELECT SubjectID, LastName, FirstName FROM team3sp232330.Teacher", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string ID = (string)reader["TeacherID"];
                    string lastName = (string)reader["LastName"];
                    string firstName = (string)reader["FirstName"];

                    teacherID.Items.Add(teacherID + " - " + lastName + ", " + firstName);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Unsuccessful", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
