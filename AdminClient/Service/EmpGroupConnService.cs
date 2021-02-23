using AdminClientDAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient
{
    public class EmpGroupConnService
    {
        public bool InsertEmpGroupConn(int Emp_No, int Group_No)
        {
            using (EmpGroupConnDAC db = new EmpGroupConnDAC())
            {
                return db.InsertEmpGroupConn(Emp_No, Group_No);
            }
        }

        public bool DeleteEmpGroupConn(int Emp_No, int Group_No)
        {
            using (EmpGroupConnDAC db = new EmpGroupConnDAC())
            {
                return db.DeleteEmpGroupConn(Emp_No, Group_No);
            }
        }
    }
}
