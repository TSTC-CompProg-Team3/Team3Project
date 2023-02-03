using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team3Project_Fixed
{
    internal class Student
    {

        public int studentID { get; set; }

        public int loginID { get; set; }

        public string firstName { get; set; }

        public string middleName { get; set; }

        public string lastName { get; set; }

        public string dateOfBirth { get; set; }

        public string mailingAddress { get; set; }

        public string streetAddress { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string zip { get; set; }

        public string phoneNumber { get; set; }

        public string emergencyContactName { get; set; }

        public string emergencyContactPhone { get; set; }

        public string guardian1Name { get; set; }

        public string guardian1CellPhone { get; set; }

        public string guardian1WorkPhone { get; set; }

        public string guardian1WorkPlace { get; set; }


        public Student(int studentID, int loginID, string firstName, string middleName, string lastName, string dateOfBirth, string mailingAddress,
            string streetAddress, string city, string state, string zip, string phoneNumber, string emergencyContactName,
            string emergencyContactPhone, string guardian1Name, string guardian1CellPhone, string guardian1WorkPhone, string guardian1WorkPlace)
        {
            this.studentID = studentID;
            this.loginID = loginID;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.mailingAddress = mailingAddress;
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.emergencyContactName = emergencyContactName;
            this.emergencyContactPhone = emergencyContactPhone;
            this.guardian1Name = guardian1Name;
            this.guardian1CellPhone = guardian1CellPhone;
            this.guardian1WorkPhone = guardian1WorkPhone;
            this.guardian1WorkPlace = guardian1WorkPlace;
        }
    }
}
