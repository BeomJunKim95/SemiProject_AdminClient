using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class EmployeesVO
    {
        public int Emp_No { get; set; }
        public string Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Phone { get; set; }
        public string Emp_Email { get; set; }
        public DateTime Emp_HireDate { get; set; }
        public DateTime Emp_RetiredDate { get; set; }
        public int Group_No { get; set; }
        public string GroupName { get; set; }

        public List<GRP> EmpGroup { get; set; }


    }

    public class GRP
    {
        public int No { get; set; }
        public string Name { get; set; }
    }

}
