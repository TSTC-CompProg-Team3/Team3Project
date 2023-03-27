using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_G3_sp23
{
    internal class clsUser
    {
        public int loginID { get; set; }

        public string accountType { get; set; }

        public string userName { get; set; }

        public string passWord { get; set; }

        public string resetCode { get; set; }

        public string email { get; set; }



        public clsUser(int loginID, string accountType, string userName, string passWord, string resetCode, string email)
        {
            this.loginID = loginID;

            this.accountType = accountType;

            this.userName = userName;

            this.passWord = passWord;

            this.resetCode = resetCode;

            this.email = email;
            
        }
    }

}
