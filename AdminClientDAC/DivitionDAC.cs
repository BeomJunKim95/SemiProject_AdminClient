using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AdminClientVO;
using System.Diagnostics;

namespace AdminClientDAC
{
    public class DivitionDAC : ConnectionDB ,IDisposable
    {
        SqlConnection conn = new SqlConnection();

        public DivitionDAC()
        {
            conn.ConnectionString = ConnectionDBs;
            conn.Open();
        }
        #region select
        public List<DivitionVO>  GetAllDivition()
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = "select Division_ID, Division_Name from Divisions"
            };
            using(SqlDataReader reader = sql.ExecuteReader())
            {
                return Helper.DataReaderMapToList<DivitionVO>(reader);
            }
        }
        #endregion

        #region insert
        public bool InsertDivition(int DivisionID,string DivisionName)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"Insert into Divisions(Division_ID, Division_Name)
                                values (@Division_ID, @Division_Name)"
                };
                sql.Parameters.AddWithValue("@Division_ID", DivisionID);
                sql.Parameters.AddWithValue("@Division_Name", DivisionName);


                return sql.ExecuteNonQuery() > 0 ? true : false;
            }catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        #endregion

        #region Update
        public bool UpdateDivition(int DivisionID, string DivisionName)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"Update Divisions set Division_Name = @Division_Name
                                where Division_ID = @Division_ID;"
            };
            sql.Parameters.AddWithValue("@Division_ID", DivisionID);
            sql.Parameters.AddWithValue("@Division_Name", DivisionName);


            return sql.ExecuteNonQuery() > 0 ? true : false;
        }
        #endregion


        #region delete
        public bool DeleteDivition(int DivisionID)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"delete from Divisions where Division_ID = @Division_ID"
            };
            sql.Parameters.AddWithValue("@Division_ID", DivisionID);

            return sql.ExecuteNonQuery() > 0 ? true : false;
        }


        #endregion

        public void Dispose()
        {
            conn.Close();
        }
    }
}
