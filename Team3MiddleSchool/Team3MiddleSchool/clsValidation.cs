﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team3MiddleSchool
{
    internal class clsValidation
    {
        static clsDatabaseConnection database = new clsDatabaseConnection();
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
            database.OpenDatabase();

            bool exists = database.ValidateCourse(courseName);

            database.CloseDatabase();

            return exists;

            
        }

        //public static bool CheckCourseForeign(string course)
        //{
        //    //string hold = course;
        //    //string[] holdSplit = hold.Split('-');
        //    //string courseID = holdSplit[0].Trim();

        //    //database.OpenDatabase();

        //    //bool hasForeign = database.CourseHasForeign(courseID);

        //    //database.CloseDatabase();

        //    //return hasForeign;
        //}
    }
}
