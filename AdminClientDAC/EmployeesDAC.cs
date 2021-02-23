using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class EmployeesDAC : ConnectionDB , IDisposable
    {
        SqlConnection conn = new SqlConnection();
        public EmployeesDAC()
        {
            conn.ConnectionString = ConnectionDBs;
            conn.Open();
        }
        public void Dispose()
        {
            conn.Close();
        }
        public EmployeesVO GetEmployeesFromIDPwd(string Emp_ID, string Emp_Pwd)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = @"select Emp_No, Emp_ID, Emp_Pwd, Emp_Name, Emp_Phone, Emp_Email, Emp_HireDate, Emp_RetiredDate
                               from Employees
                               where Emp_ID = @Emp_ID and Emp_Pwd = @Emp_Pwd"
            };
            cmd.Parameters.AddWithValue("@Emp_ID", Emp_ID);
            cmd.Parameters.AddWithValue("@Emp_Pwd", Emp_Pwd);
            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                var list = Helper.DataReaderMapToList<EmployeesVO>(reader);
                if (list.Count == 0)
                    return null;
                EmployeesVO vo = list[0];
                return vo;
            }
        }

        public bool DeleteEmp(int no)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"update Employees set Emp_RetiredDate = getdate() where Emp_No = @no;
                                                            delete from EmpGroupConn where Emp_No = @no;";
                cmd.Parameters.AddWithValue("@no", no);

                int cnt = cmd.ExecuteNonQuery();

                if (cnt > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool EmpInfoUpdate(EmployeesVO info)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"update employees set Emp_Name = @name, Emp_Phone = @phn, Emp_Email = @email 
                                                                    where Emp_No = @id";

                cmd.Parameters.AddWithValue("@name", info.Emp_Name);
                cmd.Parameters.AddWithValue("@phn", string.IsNullOrEmpty(info.Emp_Phone)? DBNull.Value : (object)info.Emp_Phone);
                cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(info.Emp_Email) ? DBNull.Value : (object)info.Emp_Email);
                cmd.Parameters.AddWithValue("@id", info.Emp_No);

                int cnt = cmd.ExecuteNonQuery();

                if (cnt > 0)
                    return true;
                else
                    return false;

            }
        }

        public List<EmployeesVO> GetAllEmployeeList(string limit, string grpNo, string now)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select * 
	                                                            from(select emp.Emp_No, emp.Emp_ID, emp.Emp_Name, emp.Emp_Phone, emp.Emp_Email, 
	                                                            			           emp.Emp_HireDate, emp.Emp_RetiredDate, isnull(grp.Group_No, 0) as Group_No, isnull(grp.GroupName, '퇴사') as GroupName
	                                                            			   from Employees as emp
	                                                            			   left outer join (select egc.Emp_No, gi.Group_No, gi.GroupName 
	                                                            			   								from EmpGroupConn as egc, Group_Info as gi 
	                                                            			   								where egc.Group_No = gi.Group_No) as grp on emp.Emp_No = grp.Emp_No) as result
	                                                            			   where result.Emp_No <= isnull(@eNo, result.Emp_No)
	                                                            			   	   and result.Group_No = isnull(@gNo, result.Group_No)
	                                                            			   	   and result.Group_No <> isnull(@dates, -1)";

                cmd.Parameters.AddWithValue("@eNo", string.IsNullOrEmpty(limit)? DBNull.Value : (object)limit);
                cmd.Parameters.AddWithValue("@gNo", string.IsNullOrEmpty(grpNo)? DBNull.Value : (object)grpNo);
                cmd.Parameters.AddWithValue("@dates", string.IsNullOrEmpty(now)? DBNull.Value : (object)now);

                List<EmployeesVO> list = Helper.DataReaderMapToList<EmployeesVO>(cmd.ExecuteReader());

                return list;
            }
        }

        public int InsertNewEmp(EmployeesVO newEmp)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                Dictionary<int, bool> result = new Dictionary<int, bool>();

                cmd.Connection = conn;
                cmd.CommandText = "SP_CheckAlreadyEmp";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", newEmp.Emp_Name);
                cmd.Parameters.AddWithValue("@group", newEmp.Group_No);
                cmd.Parameters.AddWithValue("@phone", string.IsNullOrEmpty(newEmp.Emp_Phone) ? DBNull.Value : (object)newEmp.Emp_Phone);
                cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(newEmp.Emp_Email) ? DBNull.Value : (object)newEmp.Emp_Email);
                cmd.Parameters.Add("@empno", DbType.Int32);
                cmd.Parameters["@empno"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                int cnt = Convert.ToInt32(cmd.Parameters["@empno"].Value);

                return cnt;
            }
        }
    }
}
