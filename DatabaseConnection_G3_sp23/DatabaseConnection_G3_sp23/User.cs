using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team3Project_Fixed
{
    internal class User
    {
        public int loginID { get; set; }

        public string accountType { get; set; }

        public string userName { get; set; }

        public string passWord { get; set; }



        public User(int loginID, string accountType, string userName, string passWord)
        {
            this.loginID = loginID;

            this.accountType = accountType;

            this.userName = userName;

            this.passWord = passWord;
            
        }
    }

}
