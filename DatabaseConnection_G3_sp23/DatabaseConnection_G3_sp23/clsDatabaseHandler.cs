using DatabaseConnection_G3_sp23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    MessageBox.Show("Password has been changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    database.ResetPassword(tbxConfirmPassword.Text, user.resetCode);
                }
            }

            if (!tbxNewPassword.Text.Equals(tbxConfirmPassword.Text))
            {
                MessageBox.Show("Please enter a valid password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            database.CloseDatabase();
        }

        internal static void Login(TextBox tbxUsername, TextBox tbxPassword)
        {
            database.OpenDatabase();
            database.UserInfo();
            //takes user input and checks against the data in the database connection -CS
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            List<clsUser> tempList = database.userList.ToList();
            foreach (clsUser item in tempList)
            {

                if (username.ToLower() == item.userName.ToLower() && password == item.passWord)
                {
                    int loginID = item.loginID;
                    string accountType = item.accountType;
                    database.CloseDatabase();
                    frmMenu menu = new frmMenu(loginID, accountType);
                    menu.ShowDialog();
                    return;
                }
                //else if (username.ToLower() == item.userName.ToLower() && password != item.passWord)
                //{
                //    lblPasswordWarning.Visible = true;
                //}
                //else if (password == item.passWord && username.ToLower() != item.userName.ToLower())
                //{
                //    lblUsernameWarning.Visible = true;
                //}

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

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.Credentials = new NetworkCredential("tstccompprogteam3@gmail.com", "ibhkovptxxlrtndr");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        smtp.Send(message);

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

        internal static void LoadMenu(ComboBox cbxCourseSelect, int loginID)
        {
            database.OpenDatabase();
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

        internal static void LoadAdminMenu(ComboBox cbxCourseSelect, ComboBox cbxStudentSelect, ComboBox cbxSubjectSelect, ComboBox cbxTeacherSelect)
        {
            database.OpenDatabase();
            database.LoadAdminMenu(cbxCourseSelect, cbxTeacherSelect, cbxStudentSelect);

            cbxCourseSelect.SelectedIndex = 0;
            cbxStudentSelect.SelectedIndex = 0;
            cbxTeacherSelect.SelectedIndex = 0;
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

            cbxClassSize.SelectedIndex = 0;
            cbxSubjectID.SelectedIndex = 0;
            cbxTeacherID.SelectedIndex = 0;
        }

        internal static void AddCourse(TextBox tbxClassID, ComboBox cbxTeacherID, ComboBox cbxSubjectID, ComboBox cbxClassSize)
        {
            database.OpenDatabase();

            string classID = tbxClassID.Text;
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

        internal static void LoadEditCourse(string courseID, TextBox tbxClassID, ComboBox cbxTeacherID, ComboBox cbxSubjectID, ComboBox cbxClassSize)
        {
            database.OpenDatabase();

            database.LoadEditCourse(courseID, tbxClassID, cbxTeacherID, cbxSubjectID);

            cbxSubjectID.SelectedIndex = 0;
            cbxTeacherID.SelectedIndex = 0;
            cbxClassSize.SelectedIndex = 0;

            database.CloseDatabase();
        }

        internal static void EditCourse(TextBox tbxClassID, ComboBox cbxTeacherID, ComboBox cbxSubjectID, ComboBox cbxClassSize)
        {
            database.OpenDatabase();

            string classID = tbxClassID.Text;
            string hold = cbxTeacherID.Text.ToString();
            string[] holdSplit = hold.Split('-');
            string teacherID = holdSplit[0].Trim();
            hold = cbxSubjectID.Text.ToString();
            holdSplit = hold.Split('-');
            string subjectID = holdSplit[0].Trim();
            string classSize = cbxClassSize.Text;

            database.EditCourse(classID, teacherID, subjectID, classSize);

            database.CloseDatabase();

            MessageBox.Show("Course Successfully Editted", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
