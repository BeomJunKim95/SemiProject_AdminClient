using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient
{
    public class EmployeesService
    {
        public EmployeesVO GetEmployeesFromIDPwd(string Emp_ID, string Emp_Pwd)
        {
            EmployeesDAC db = new EmployeesDAC();
            return db.GetEmployeesFromIDPwd(Emp_ID, Emp_Pwd);
        }

        internal List<EmployeesVO> GetAllEmployeeList(string limit, string grpNo, string now)
        {
            EmployeesDAC dac = new EmployeesDAC();
            List<EmployeesVO> list = dac.GetAllEmployeeList(limit, grpNo, now);
            dac.Dispose();
            return list;
        }

        internal int InsertNewEmp(EmployeesVO newEmp)
        {
            EmployeesDAC dac = new EmployeesDAC();
            int result = dac.InsertNewEmp(newEmp);
            dac.Dispose();
            return result;
        }

        internal bool EmpInfoUpdate(EmployeesVO info)
        {
            EmployeesDAC dac = new EmployeesDAC();
            bool result = dac.EmpInfoUpdate(info);
            dac.Dispose();
            return result;
        }

        internal bool DeleteEmp(int no)
        {
            EmployeesDAC dac = new EmployeesDAC();
            bool result = dac.DeleteEmp(no);
            dac.Dispose();
            return result;
        }
    }
}
