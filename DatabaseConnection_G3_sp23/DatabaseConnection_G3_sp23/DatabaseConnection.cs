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

        public DataTable AttendanceInfo()
        {
            SqlCommand command = new SqlCommand("SELECT CONCAT(FirstName, ' ', LastName) AS \"Student\", a.Date, a.Present FROM team3sp232330.Student s INNER JOIN team3sp232330.Attendance a ON s.StudentID = a.StudentID;", connection);
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

        //updates admin menu -CS
        public void UpdateAdminMenu(ComboBox courseList, ComboBox teacherList, ComboBox studentList)
        {
            courseList.Items.Clear();
            teacherList.Items.Clear();
            studentList.Items.Clear();
            LoadAdminMenu(courseList,teacherList,studentList);
        }


        //loads the admin menu info -CS
        public void LoadAdminMenu(ComboBox courseList, ComboBox teacherList, ComboBox studentList)
        {
            try
            {

                SqlCommand command = new SqlCommand("Select ClassID, SubjectName FROM team3sp232330.Class c JOIN team3sp232330.Subject s ON c.SubjectID = s.SubjectID JOIN team3sp232330.Teacher t ON t.TeacherID = c.TeacherID", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int classID = (int)reader["ClassID"];
                    string subjectName = (string)reader["SubjectName"];

                    courseList.Items.Add(classID + " - " + subjectName);
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
        public void LoadEditCourse(string courseID, TextBox ID,  ComboBox teacherList, ComboBox subjectList)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT SubjectID, SubjectName FROM team3sp232330.Subject", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int subjectID = (int)reader["SubjectID"];
                    string subjectName = (string)reader["SubjectName"];
                    ID.Text = courseID.ToString();
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
        public void EditCourse(string classID, string teacherID, string subjectID, string classSize)
        {
            try
            {
                string query = "UPDATE team3sp232330.Class SET ClassID = @classID, TeacherID = @teacherID, SubjectID = @subjectID, ClassSize = @classSize WHERE ClassID = " + classID;

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
    }
}
