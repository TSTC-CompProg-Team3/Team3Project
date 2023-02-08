using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_G3_sp23
{
    internal class clsSubject
    {

        public int subjectID { get; set; }

        public string subjectName { get; set; }



        public clsSubject(int subjectID, string subjectName)
        {
            this.subjectID = subjectID;
            this.subjectName = subjectName;

        }
    }
}
