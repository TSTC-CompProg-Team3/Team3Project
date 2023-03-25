using DatabaseConnection_G3_sp23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data;
using System.Net.NetworkInformation;

namespace DatabaseConnection_G3_sp23
{
    internal class clsDatabaseHandler
    {
        static DatabaseConnection database = new DatabaseConnection();
        //Creates random number object -CS
        private static Random random = new Random();

        internal static void ConfirmResetPass(TextBox tbxEnterCode, TextBox tbxNewPassword, TextBox tbxConfirmPassword)
        {
            database.OpenDatabase();
            database.UserInfo();
            foreach (clsUser user in database.userList)
            {
                if (tbxEnterCode.Text.Equals(user.resetCode) && tbxNewPassword.Text.Equals(tbxConfirmPassword.Text))
                {
                    database.ResetPassword(tbxConfirmPassword.Text, user.resetCode);
                    MessageBox.Show("Password has been changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (!tbxNewPassword.Text.Equals(tbxConfirmPassword.Text))
            {
                MessageBox.Show("Please enter a valid password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            database.CloseDatabase();
        }

        internal static void Login(TextBox tbxUsername, TextBox tbxPassword, Label lblPasswordWarning, Label lblUsernameWarning)
        {
            database.OpenDatabase();
            database.UserInfo();
            //takes user input and checks against the data in the database connection -CS
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            List<clsUser> tempList = database.userList.ToList();
            bool usernameMatch = false;
            bool passwordMatch = false;

            foreach (clsUser item in tempList)
            {
                if (username.ToLower() == item.userName.ToLower() && password == item.passWord)
                {
                    int loginID = item.loginID;
                    string accountType = item.accountType;
                    lblPasswordWarning.Visible = false;
                    lblUsernameWarning.Visible = false;
                    database.CloseDatabase();
                    frmMenu menu = new frmMenu(loginID, accountType);
                    menu.ShowDialog();
                    return;
                }
                else if (username.ToLower() == item.userName.ToLower())
                {
                    usernameMatch = true;
                }
                else if (password == item.passWord)
                {
                    passwordMatch = true;
                }
            }

            if (usernameMatch && passwordMatch)
            {
                lblPasswordWarning.Visible = true;
                lblUsernameWarning.Visible = true;
            }
            else if (usernameMatch)
            {
                lblPasswordWarning.Visible = true;
            }
            else if (passwordMatch)
            {
                lblUsernameWarning.Visible = true;
            }

            database.CloseDatabase();
        }

        internal static void SendEmail(TextBox tbxEmail)
        {
            database.OpenDatabase();
            database.UserInfo();
            string email = tbxEmail.Text;

            foreach (clsUser user in database.userList)
            {
                if (tbxEmail.Text == user.email)
                {
                    try
                    {
                        string resetCode = "";
                        resetCode = GenerateResetCode(6);

                        database.StoreResetCodeInDatabase(email, resetCode);

                        MailMessage message = new MailMessage("noreply@example.com", email);
                        message.Subject = "Password Reset Code";
                        message.Body = $"Your password reset code is: {resetCode}";

                        using (SmtpClient smtp = new SmtpClient("smtp-relay.sendinblue.com", 587))
                        {
                            smtp.Credentials = new NetworkCredential("tstccompprogteam3@gmail.com", "CZ5dbGYKj6M17UvJ");
                            smtp.EnableSsl = true;
                            smtp.Send(message);
                        }


                        MessageBox.Show("Password reset code sent to email.");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while sending the reset code: " + ex.Message);


                    }


                }
            }
            database.CloseDatabase();
        }

        //generates the random reset code -CS
        private static string GenerateResetCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void LoadAdminOfficer(ComboBox cbxCourseSelect)
        {
            database.OpenDatabase();
            database.classList.Clear();
            // Get a list of all the classes for the specified admin
            database.AdminAccessClasses();
            // Add each class to the ComboBox
            foreach (string subject in database.classList)
            {
                cbxCourseSelect.Items.Add(subject);
            }

            // Select the first item in the ComboBox (if there is one)
            if (cbxCourseSelect.Items.Count > 0)
            {
                cbxCourseSelect.SelectedIndex = 0;
            }
            else
            {
              cbxCourseSelect.Visible = false;
            }
            database.CloseDatabase();
        }


        internal static void LoadMenu(ComboBox cbxCourseSelect, int loginID)
        {
            database.OpenDatabase();
            database.classList.Clear();
            database.TeacherClasses(loginID);
            foreach (string subject in database.classList)
            {
                cbxCourseSelect.Items.Add(subject);
            }

            if (cbxCourseSelect.Items.Count > 0)
            {
                cbxCourseSelect.SelectedIndex = 0;
            }
            else
            {
                cbxCourseSelect.Visible = false;
            }
            database.CloseDatabase();
        }

        internal static void LoadStudentMenu(ComboBox cbxCourseSelect, int loginID)
        {
            
        }

        internal static void LoadAdminMenu(ComboBox cbxCourseSelect, ComboBox cbxStudentSelect, ComboBox cbxTeacherSelect)
        {
            database.OpenDatabase();
            database.LoadAdminMenu(cbxCourseSelect, cbxTeacherSelect, cbxStudentSelect);
            if (cbxCourseSelect.Items.Count > 0)
            {
                cbxCourseSelect.SelectedIndex = 0;
            }
            if (cbxStudentSelect.Items.Count > 0)
            {
                cbxStudentSelect.SelectedIndex = 0;
            }
            if (cbxTeacherSelect.Items.Count > 0)
            {
                cbxTeacherSelect.SelectedIndex = 0;
            }

            database.CloseDatabase();
        }



        internal static void RemoveCourse(ComboBox cbxCourseSelect)
        {
            database.OpenDatabase();
            string courseID;
            //checks if something is selected -CS
            if (cbxCourseSelect.SelectedIndex > -1)
            {
                //confirms if admin wants to remove course -CS
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to remove the course?", "Course Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string hold = cbxCourseSelect.Text.ToString();
                    string[] holdSplit = hold.Split('-');
                    courseID = holdSplit[0].Trim();
                    database.RemoveCourse(courseID);
                    MessageBox.Show("Course Successfully Removed", "Course Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Please select a course for removal", "Course Removal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.CloseDatabase();
        }

        internal static void AddCourseLoad(ComboBox cbxTeacherID, ComboBox cbxSubjectID, ComboBox cbxClassSize)
        {
            database.OpenDatabase();

            database.LoadAddCourse(cbxTeacherID, cbxSubjectID);

            database.CloseDatabase();

            if (cbxClassSize.Items.Count > 0)
            {
                cbxClassSize.SelectedIndex = 0;
            }
            
            if (cbxSubjectID.Items.Count > 0)
            {
                cbxSubjectID.SelectedIndex = 0;
            }

            if (cbxTeacherID.Items.Count > 0)
            {
                cbxTeacherID.SelectedIndex = 0;
            }
            
        }

        internal static void AddCourse(TextBox tbxClassName, ComboBox cbxTeacherID, ComboBox cbxSubjectID, ComboBox cbxClassSize)
        {
            database.OpenDatabase();

            string classID = tbxClassName.Text;
            string hold = cbxTeacherID.Text.ToString();
            string[] holdSplit = hold.Split('-');
            string teacherID = holdSplit[0].Trim();
            hold = cbxSubjectID.Text.ToString();
            holdSplit = hold.Split('-');
            string subjectID = holdSplit[0].Trim();
            string classSize = cbxClassSize.Text;

            database.AddCourse(classID, teacherID, subjectID, classSize);

            database.CloseDatabase();

            MessageBox.Show("Course Successfully Created", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void LoadEditCourse(string courseName, TextBox tbxClassID, ComboBox cbxTeacherID, ComboBox cbxSubjectID, ComboBox cbxClassSize)
        {
            database.OpenDatabase();

            database.LoadEditCourse(courseName, tbxClassID, cbxTeacherID, cbxSubjectID);

            if (cbxSubjectID.Items.Count > 0)
            {
                cbxSubjectID.SelectedIndex = 0;
            }
            
            if (cbxTeacherID.Items.Count > 0)
            {
                cbxTeacherID.SelectedIndex = 0;
            }
            
            cbxClassSize.SelectedIndex = 0;

            database.CloseDatabase();
        }

        internal static void EditCourse(string classID, TextBox tbxClassName, ComboBox cbxTeacherID, ComboBox cbxSubjectID, ComboBox cbxClassSize)
        {
            database.OpenDatabase();

            string className = tbxClassName.Text;
            string hold = cbxTeacherID.Text.ToString();
            string[] holdSplit = hold.Split('-');
            string teacherID = holdSplit[0].Trim();
            hold = cbxSubjectID.Text.ToString();
            holdSplit = hold.Split('-');
            string subjectID = holdSplit[0].Trim();
            string classSize = cbxClassSize.Text;

            database.EditCourse(classID, className, teacherID, subjectID, classSize);

            database.CloseDatabase();

            MessageBox.Show("Course Successfully Editted", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void AddTeacher(TextBox tbxFirstName, TextBox tbxLastName, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxPassword)
        {
            database.OpenDatabase();

            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;
            string email = tbxEmail.Text;
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;


            database.AddTeacher(firstName,lastName,email, username, password);

            database.CloseDatabase();

            MessageBox.Show("Teacher Successfully Created", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void EditTeacherLoad(string teacherID, TextBox tbxFirstName, TextBox tbxLastName, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxPassword)
        {
            database.OpenDatabase();

            database.LoadEditTeacher(teacherID, tbxFirstName,tbxLastName,tbxEmail, tbxUsername, tbxPassword);

            database.CloseDatabase();
        }

        internal static void EditTeacher(string teacherID, TextBox tbxFirstName, TextBox tbxLastName, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxPassword)
        {
            database.OpenDatabase();

            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;
            string email = tbxEmail.Text;
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;


            database.EditTeacher(teacherID, firstName, lastName, email, username, password);

            database.CloseDatabase();

            MessageBox.Show("Teacher Successfully Editted", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        internal static void RemoveTeacher(ComboBox cbxTeacherSelect)
        {
            database.OpenDatabase();
            string teacherID;
            //checks if something is selected -CS
            if (cbxTeacherSelect.SelectedIndex > -1)
            {
                //confirms if admin wants to remove course -CS
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to remove the Teacher?", "Teacher Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string hold = cbxTeacherSelect.Text.ToString();
                    string[] holdSplit = hold.Split('-');
                    teacherID = holdSplit[0].Trim();
                    database.RemoveTeacher(teacherID);

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Please select a course for removal", "Course Removal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.CloseDatabase();
        }

        internal static void AddStudent(TextBox tbxFirstName, TextBox tbxMiddleName, TextBox tbxLastName, DateTimePicker dtpDateOfBirth, TextBox tbxPhoneNumber, TextBox tbxMailingAddress, TextBox tbxStreetAddress, TextBox tbxCity, TextBox tbxState, TextBox tbxZip, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxPassword, TextBox tbxEmerContactName, TextBox tbxEmerContactPhone, TextBox tbxGuardianName, TextBox tbxGuardianCell, TextBox tbxGuardianWork, TextBox tbxGuardianWorkPl)
        {
            database.OpenDatabase();

            string firstName = tbxFirstName.Text;
            string middleName = tbxMiddleName.Text;
            string lastName = tbxLastName.Text;
            DateTime dateValue = dtpDateOfBirth.Value;
            string phoneNumber = tbxPhoneNumber.Text;
            string mailingAddress = tbxMailingAddress.Text;
            string streetAddress = tbxStreetAddress.Text;
            string city = tbxCity.Text;
            string state = tbxState.Text;
            string zip = tbxZip.Text;
            string email = tbxEmail.Text;
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            string emerContactName = tbxEmerContactName.Text;
            string emerContactPhone = tbxEmerContactPhone.Text;
            string guardianName = tbxGuardianName.Text;
            string guardianCell = tbxGuardianCell.Text;
            string guardianWorkPhone = tbxGuardianWork.Text;
            string guardianWorkPl = tbxGuardianWorkPl.Text;


            database.AddStudent(firstName, middleName,lastName,dateValue,phoneNumber,mailingAddress,streetAddress,city,state,
                zip,email,username,password,emerContactName,emerContactPhone,guardianName,guardianCell,guardianWorkPhone,guardianWorkPl);

            database.CloseDatabase();

            MessageBox.Show("Student Successfully Created", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void RemoveStudent(ComboBox cbxStudentSelect)
        {
            database.OpenDatabase();
            string studentID;
            //checks if something is selected -CS
            if (cbxStudentSelect.SelectedIndex > -1)
            {
                //confirms if admin wants to remove course -CS
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to remove the student?", "Student Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string hold = cbxStudentSelect.Text.ToString();
                    string[] holdSplit = hold.Split('-');
                    studentID = holdSplit[0].Trim();
                    database.RemoveStudent(studentID);
                    MessageBox.Show("Student Successfully Removed", "Student Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Please select a student for removal", "Student Removal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.CloseDatabase();
        }

        internal static void LoadEditStudent(string studentID, TextBox tbxFirstName, TextBox tbxMiddleName, TextBox tbxLastName,
            DateTimePicker dtpDateOfBirth, TextBox tbxPhoneNumber, TextBox tbxMailingAddress, TextBox tbxStreetAddress, TextBox tbxCity,
            TextBox tbxState, TextBox tbxZip, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxPassword, TextBox tbxEmerContactName,
            TextBox tbxEmerContactPhone, TextBox tbxGuardianName, TextBox tbxGuardianCell, TextBox tbxGuardianWork, 
            TextBox tbxGuardianWorkPl)
        {
            database.OpenDatabase();

            database.LoadEditStudent(studentID,tbxFirstName,tbxMiddleName,tbxLastName,dtpDateOfBirth,tbxPhoneNumber,tbxMailingAddress,
                tbxStreetAddress,tbxCity,tbxState,tbxZip,tbxEmail,tbxUsername,tbxPassword,tbxEmerContactName,tbxEmerContactPhone,
                tbxGuardianName,tbxGuardianCell,tbxGuardianWork,tbxGuardianWorkPl);

            database.CloseDatabase();
        }

        internal static void LoadOfficerMenu(ComboBox cbxCourseSelect, ComboBox cbxStudentSelect, ComboBox cbxTeacherSelect, ComboBox cbxSubjectSelect)
        {
            database.OpenDatabase();
            database.GetOfficerMenu(cbxCourseSelect, cbxTeacherSelect, cbxStudentSelect, cbxSubjectSelect);
            if (cbxCourseSelect.Items.Count > 0)
            {
                cbxCourseSelect.SelectedIndex = 0;
            }
            if (cbxStudentSelect.Items.Count > 0)
            {
                cbxStudentSelect.SelectedIndex = 0;
            }
            if (cbxTeacherSelect.Items.Count > 0)
            {
                cbxTeacherSelect.SelectedIndex = 0;
            }
            if (cbxSubjectSelect.Items.Count > 0)
            {
                cbxSubjectSelect.SelectedIndex = 0;
            }

            database.CloseDatabase();

        }

        internal static void EditStudent(string studentID, TextBox tbxFirstName, TextBox tbxMiddleName, TextBox tbxLastName, 
            DateTimePicker dtpDateOfBirth, TextBox tbxPhoneNumber, TextBox tbxMailingAddress, TextBox tbxStreetAddress, TextBox tbxCity, 
            TextBox tbxState, TextBox tbxZip, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxPassword, TextBox tbxEmerContactName,
            TextBox tbxEmerContactPhone, TextBox tbxGuardianName, TextBox tbxGuardianCell, TextBox tbxGuardianWork, 
            TextBox tbxGuardianWorkPl)
        {
            database.OpenDatabase();

            string firstName = tbxFirstName.Text;
            string middleName = tbxMiddleName.Text;
            string lastName = tbxLastName.Text;
            DateTime dateValue = dtpDateOfBirth.Value;
            string phoneNumber = tbxPhoneNumber.Text;
            string mailingAddress = tbxMailingAddress.Text;
            string streetAddress = tbxStreetAddress.Text;
            string city = tbxCity.Text;
            string state = tbxState.Text;
            string zip = tbxZip.Text;
            string email = tbxEmail.Text;
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            string emerContactName = tbxEmerContactName.Text;
            string emerContactPhone = tbxEmerContactPhone.Text;
            string guardianName = tbxGuardianName.Text;
            string guardianCell = tbxGuardianCell.Text;
            string guardianWorkPhone = tbxGuardianWork.Text;
            string guardianWorkPl = tbxGuardianWorkPl.Text;


            database.EditStudent(studentID, firstName, middleName, lastName, dateValue, phoneNumber, mailingAddress, streetAddress, city, state,
                zip, email, username, password, emerContactName, emerContactPhone, guardianName, guardianCell, guardianWorkPhone, guardianWorkPl);

            database.CloseDatabase();

            MessageBox.Show("Student Successfully Editted", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void PopulateClassesLbx(ListBox lbxStudents)
        {
            database.PopulateStudentListBox(lbxStudents);
        }

        internal static void PopulateAvailableClasses(ComboBox cbxClass1, ComboBox cbxClass2, ComboBox cbxClass3, ComboBox cbxClass4, ComboBox cbxClass5, ComboBox cbxClass6)
        {
            List<string> classes = new List<string>();

            database.OpenDatabase();

            database.GetClasses(classes);

            database.CloseDatabase();

            foreach (string cl in classes)
            {
                cbxClass1.Items.Add(cl);
                cbxClass2.Items.Add(cl);
                cbxClass3.Items.Add(cl);
                cbxClass4.Items.Add(cl);
                cbxClass5.Items.Add(cl);
                cbxClass6.Items.Add(cl);
            }

        }

        internal static void SetCurrentClasses(int studentID, ComboBox cbxClass1, ComboBox cbxClass2, ComboBox cbxClass3, ComboBox cbxClass4, ComboBox cbxClass5, ComboBox cbxClass6)
        {
            database.OpenDatabase();

            cbxClass1.SelectedIndex = -1;
            cbxClass2.SelectedIndex = -1;
            cbxClass3.SelectedIndex = -1;
            cbxClass4.SelectedIndex = -1;
            cbxClass5.SelectedIndex = -1;
            cbxClass6.SelectedIndex = -1;

            database.GetCurrentClasses(studentID,cbxClass1,cbxClass2,cbxClass3,cbxClass4,cbxClass5,cbxClass6);

            database.CloseDatabase();

        }

        internal static void EditCourses(int studentID, ComboBox cbxClass1, ComboBox cbxClass2, ComboBox cbxClass3, ComboBox cbxClass4, ComboBox cbxClass5, ComboBox cbxClass6)
        {
            database.OpenDatabase();

            database.EditCurrentClasses(studentID,cbxClass1,cbxClass2,cbxClass3,cbxClass4,cbxClass5,cbxClass6);

            database.CloseDatabase();
        }

        
    }
}
