using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.RightsManagement;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Team3MiddleSchool
{
    internal class clsValidation
    {
        static DatabaseConnection database = new DatabaseConnection();
        public static bool ValidateString(char input)
        {
            if (Char.IsLetter(input) || input == (char)Keys.Back || input == (char)Keys.Space)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidateCourseName(string courseName)
        {
            if (string.IsNullOrEmpty(courseName))
            {
                return true;
            }

            if (courseName.Any(char.IsWhiteSpace))
            {
                return true;
            }

            database.OpenDatabase();

            bool exists = database.ValidateCourse(courseName);

            database.CloseDatabase();

            return exists;

            
        }

        public static bool ValidateCourseNameEdit(string courseName)
        {
            if (string.IsNullOrEmpty(courseName))
            {
                return true;
            }

            if (courseName.Any(char.IsWhiteSpace))
            {
                return true;
            }

            return false;

        }

        public static bool CheckCourseDelete(string cbxCourseText)
        {

            string hold = cbxCourseText.ToString();
            string[] holdSplit = hold.Split('-');
            string courseID = holdSplit[0].Trim();


            bool okayDelete = database.CheckCourseDelete(courseID);

            return okayDelete;
        }

        internal static bool CheckTeacherDelete(string cbxTeacherText)
        {
            string hold = cbxTeacherText.ToString();
            string[] holdSplit = hold.Split('-');
            string teacherID = holdSplit[0].Trim();


            bool okayDelete = database.CheckTeacherDelete(teacherID);

            return okayDelete;
        }

        internal static bool CheckSubjectDelete(string cbxSubjectText)
        {
            string hold = cbxSubjectText.ToString();
            string[] holdSplit = hold.Split('-');
            string subjectID = holdSplit[0].Trim();


            bool okayDelete = database.CheckSubjectDelete(subjectID);

            return okayDelete;
        }

        internal static bool CheckStudentDelete(string cbxStudentText)
        {
            string hold = cbxStudentText.ToString();
            string[] holdSplit = hold.Split('-');
            string studentID = holdSplit[0].Trim();


            bool okayDelete = database.CheckStudentDelete(studentID);

            return okayDelete;
        }

        public static bool ValidateUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }

            if (username.Any(char.IsWhiteSpace))
            {
                return false;
            }

            foreach (char c in username)
            {
                if (!char.IsLetterOrDigit(c) && c != '_' && c != '-')
                {
                    return false;
                }
            }

            if (username.Length < 3 || username.Length > 20)
            {
                return false;
            }

            database.OpenDatabase();

            bool valid = !database.ValidateUsername(username);

            database.CloseDatabase();

            return valid;

        }

        public static bool ValidateUsernameEdit(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }

            if (username.Any(char.IsWhiteSpace))
            {
                return false;
            }

            foreach (char c in username)
            {
                if (!char.IsLetterOrDigit(c) && c != '_' && c != '-')
                {
                    return false;
                }
            }

            if (username.Length < 3 || username.Length > 20)
            {
                return false;
            }

            return true;

        }

        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            if (password.Length < 8 || password.Length > 20)
            {
                return false;
            }

            bool hasUppercase = false;
            bool hasLowercase = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUppercase = true;
                }
                else if (char.IsLower(c))
                {
                    hasLowercase = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }

                if (hasUppercase && hasLowercase && hasDigit)
                {
                    break;
                }
            }

            if (!hasUppercase || !hasLowercase || !hasDigit)
            {
                return false;
            }

            return true;
        }

        internal static bool ValidateFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                return false;
            }

            if (firstName.Any(char.IsWhiteSpace))
            {
                return false;
            }

            return true;
        }

        internal static bool ValidateMiddleName(string middleName)
        {
            if (string.IsNullOrEmpty(middleName))
            {
                return false;
            }

            if (middleName.Any(char.IsWhiteSpace))
            {
                return false;
            }

            return true;
        }

        internal static bool ValidateLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                return false;
            }

            if (lastName.Any(char.IsWhiteSpace))
            {
                return false;
            }

            return true;
        }

        internal static bool ValidateSubject(string subjectName)
        {
            if (string.IsNullOrEmpty(subjectName))
            {
                return false;
            }

            if (subjectName.Any(char.IsWhiteSpace))
            {
                return false;
            }

            database.OpenDatabase();

            bool exists = database.ValidateSubject(subjectName);

            database.CloseDatabase();

            return exists;
        }

        internal static bool ValidateSubjectEdit(string subjectName)
        {
            if (string.IsNullOrEmpty(subjectName))
            {
                return true;
            }

            if (subjectName.Any(char.IsWhiteSpace))
            {
                return true;
            }

            return false;
        }

        internal static bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^\d{3}-\d{3}-\d{4}$";

            bool isMatch = Regex.IsMatch(phoneNumber, pattern);

            return isMatch;
        }

        internal static bool ValidateAddress(string address)
        {
            string pattern = @"^\d+\s[A-z]+\s[A-z]+";

            bool isMatch = Regex.IsMatch(address, pattern);

            return isMatch;
        }

        internal static bool ValidateCity(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                return false;
            }

            return true;
        }

        internal static bool ValidateState(string state)
        {
            string[] validStates = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", 
                "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", 
                "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", 
                "VA", "WA", "WV", "WI", "WY" };

            state = state.ToUpper();

            bool validState = validStates.Contains(state);

            return validState;
        }

        internal static bool ValidateZip(string zip)
        {
            string pattern = @"^\d{5}(?:[-\s]\d{4})?$";

            bool isValidZip = Regex.IsMatch(zip, pattern);

            return isValidZip;
        }

        internal static bool ValidateFullName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }

            return true;
        }

        internal static bool ValidateWorkPlace(string workPlace)
        {
            if (string.IsNullOrEmpty(workPlace))
            {
                return false;
            }

            if (workPlace.Any(char.IsWhiteSpace))
            {
                return false;
            }

            return true;
        }

        
    }
}
