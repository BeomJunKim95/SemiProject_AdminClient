using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class EmpGroupConnDAC :ConnectionDB , IDisposable
    {
        SqlConnection conn = new SqlConnection();
        public EmpGroupConnDAC()
        {
            conn.ConnectionString = ConnectionDBs;
            conn.Open();
        }

        #region insert
        public bool InsertEmpGroupConn(int Emp_No, int Group_No)
        {
            SqlCommand sql = new SqlCommand
            {
                CommandText = @"insert into EmpGroupConn(Emp_No, Group_No)
                              values(@Emp_No, @Group_No); ",
                Connection = conn
            };
            sql.Parameters.AddWithValue("@Emp_No", Emp_No);
            sql.Parameters.AddWithValue("@Group_No", Group_No);

            return sql.ExecuteNonQuery() > 0 ? true : false ;
        }

        #endregion

        #region delete
        public bool DeleteEmpGroupConn(int Emp_No, int Group_No)
        {
            SqlCommand sql = new SqlCommand
            {
                CommandText = @"delete from EmpGroupConn
                              where Emp_No =  @Emp_No and
                              Group_No = @Group_No; ",
                Connection = conn
            };
            sql.Parameters.AddWithValue("@Emp_No", Emp_No);
            sql.Parameters.AddWithValue("@Group_No", Group_No);

            return sql.ExecuteNonQuery() > 0 ? true : false;
        }

        #endregion

        public void Dispose()
        {
            conn.Close();
        }
    }
}
