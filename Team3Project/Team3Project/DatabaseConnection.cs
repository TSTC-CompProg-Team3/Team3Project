﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team3Project
{
    internal class DatabaseConnection
    {
        List<Student> studentList = new List<Student>();
        public DatabaseConnection() {

            using (SqlConnection connection = new SqlConnection("Server=3.130.26.194;Database=inew2330gsp23;User Id=team3sp232330;password=fyMU9QpqmW\""))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Students", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int studentID = (int)reader["StudentID"];
                    int loginID = (int)reader["LoginID"];
                    string firstName = (string)reader["FirstName"];
                    string middleName = (string)reader["MiddleName"];
                    string lastName = (string)reader["LastName"];
                    string dateOfBirth = (string)reader["DateOfBirth"];
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
                    studentList.Add(new Student(studentID,loginID,firstName,middleName,lastName,dateOfBirth,mailingAddress,streetAddress,
                        city,state,zip,phoneNumber,emergencyContactName,emergencyContactPhone,guardian1Name,guardian1CellPhone,guardian1WorkPhone,guardian1WorkPlace));
                }
                connection.Close();
            }
        }
    }
}
