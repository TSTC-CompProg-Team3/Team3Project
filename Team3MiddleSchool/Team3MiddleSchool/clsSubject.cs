using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team3MiddleSchool
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
