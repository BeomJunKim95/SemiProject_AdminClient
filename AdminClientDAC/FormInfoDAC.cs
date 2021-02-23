using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class FormInfoDAC : ConnectionDB, IDisposable
    {
        SqlConnection conn;
        public FormInfoDAC()
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConnectionDBs;
            conn.Open();
        }
        #region select

        public List<FormInfoAndGNameVO> GetFormForEmp(int Emp_No)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = @"select fi.Form_Name ,fi.Menu_Name, gi.GroupName from Employees emp join EmpGroupConn egc
                on emp.Emp_No = egc.Emp_No join  Group_Info  gi
                on egc.Group_No = gi.Group_No join GroupAuthority ga
                on ga.Group_No = gi.Group_No join Form_Info fi
                on fi.Form_Name = ga.Form_Name
                where emp.Emp_No = @Emp_No;"
            };
            cmd.Parameters.AddWithValue("@Emp_No", Emp_No);
            using(SqlDataReader reader = cmd.ExecuteReader()) {
                var List = Helper.DataReaderMapToList<FormInfoAndGNameVO>(reader);
                if (List.Count == 0)
                    return null;
                return List;
            }
        }


        public List<FormInfoVO> GetAllFormInfo()
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = @"select Form_Name, Menu_Name from Form_Info"
            };
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                var List = Helper.DataReaderMapToList<FormInfoVO>(reader);
                if (List.Count == 0)
                    return null;
                return List;
            }
        }

        #endregion

        #region insert
        public bool InsertFormInfo(string FormName, string MenuName)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"insert into Form_Info(Form_Name,Menu_Name)
                values(@Form_Name, @Menu_Name)"
            };
            sql.Parameters.AddWithValue("@Form_Name", FormName);
            sql.Parameters.AddWithValue("@Menu_Name", MenuName);

            return sql.ExecuteNonQuery() > 0 ? true : false;
        }

        #endregion

        #region Delete
        public bool DeleteFormInfo(string FormName)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"delete from Form_Info
                where Form_Name = @Form_Name;"
            };
            sql.Parameters.AddWithValue("@Form_Name", FormName);

            return sql.ExecuteNonQuery() > 0 ? true : false;
        }

        #endregion

        #region Update
        public bool UpdateFormInfo(string FormName, string Menu_Name)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"Update Form_Info
				set Menu_Name = @Menu_Name
				where Form_Name = @Form_Name;"
            };
            sql.Parameters.AddWithValue("@Form_Name", FormName);
            sql.Parameters.AddWithValue("@Menu_Name", Menu_Name);

            return sql.ExecuteNonQuery() > 0 ? true : false;

        }

        #endregion

        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
