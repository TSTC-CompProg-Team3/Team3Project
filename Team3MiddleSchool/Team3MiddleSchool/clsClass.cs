using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_G3_sp23
{
    internal class clsClass
    {
        public int classID { get; set; }

        public int teacherID { get; set; }

        public int subjectID { get; set; }

        public int classSize { get; set; }



        public clsClass(int classID, int teacherID, int subjectID, int classSize)
        {
            this.classID = classID;
            this.teacherID = teacherID;
            this.subjectID = subjectID;
            this.classSize = classSize;

        }

    }
}
