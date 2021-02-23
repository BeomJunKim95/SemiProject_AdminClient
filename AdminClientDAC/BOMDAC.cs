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
    public class BOMDAC : ConnectionDB, IDisposable
    {
        SqlConnection conn;

        public BOMDAC()
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConnectionDBs;
            conn.Open();
        }

        #region Update
        public bool BOMUpdate(int BOM_Child, int BOM_Parents, int Count)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"Update BOM set BOM_Count = @BOM_Count
                where BOM_Child = @BOM_Child and BOM_Parents = @BOM_Parents; "
            };

            sql.Parameters.AddWithValue("@BOM_Count", Count);
            sql.Parameters.AddWithValue("@BOM_Child", BOM_Child);
            sql.Parameters.AddWithValue("@BOM_Parents", BOM_Parents);

            return sql.ExecuteNonQuery() > 0 ? true : false;
        }
        #endregion

        #region delete
        public bool BOMdelete(int BOM_Child, int BOM_Parents)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"delete from  BOM
                where BOM_Child = @BOM_Child and BOM_Parents = @BOM_Parents; "
            };
            sql.Parameters.AddWithValue("@BOM_Child", BOM_Child);
            sql.Parameters.AddWithValue("@BOM_Parents", BOM_Parents);

            return sql.ExecuteNonQuery() > 0 ? true : false;
        }
        #endregion

        #region select
        public List<BOMVO> BOMAllList()
        {
            SqlCommand sql = new SqlCommand()
            {
                Connection = conn,
                CommandText = "select BOM_Child, BOM_Parents, BOM_Count from BOM;"
            };

            using (SqlDataReader reader = sql.ExecuteReader())
            {
                return Helper.DataReaderMapToList<BOMVO>(reader);
            }
        }

        public List<BOMReverseVO> BOMReverse(int Parents)
        {
            try
            {
                SqlCommand sql = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = @"select P.Product_Name, p.Product_Price from BOM B join Products P
                on B.BOM_Child = P.Product_ID
                where BOM_Parents = @BOM_Parents; "
                };
                sql.Parameters.AddWithValue("@BOM_Parents", Parents);
                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<BOMReverseVO>(reader);
                }
            }catch (Exception err)
            {

                return null;
            }
        }


        
        #endregion

        #region 스토어드 프로시저

        public void IsBOMChild(int ProductID)
        {
            SqlCommand sql = new SqlCommand()
            {
                Connection = conn,
                CommandText = "IsBOMChild",
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sql.Parameters.AddWithValue("@ProductNo", ProductID);

            sql.ExecuteNonQuery();
        }

        public List<BOMSelectVO> BOM_Child(int ProductID)
        {
            SqlCommand sql = new SqlCommand()
            {
                Connection = conn,
                CommandText = "BOM_Child",
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sql.Parameters.AddWithValue("@BOM_Child", ProductID);

            using (SqlDataReader reader = sql.ExecuteReader())
            {
                return Helper.DataReaderMapToList<BOMSelectVO>(reader);
            }
        }

        public bool SP_InsertBOM(int BOMID, List<int> List)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"SP_InsertBOM",
                CommandType = System.Data.CommandType.StoredProcedure
            };

            DataTable tvp = new DataTable();
            tvp.Columns.Add(new DataColumn("ID", typeof(int)));

            foreach (var id in List)
                tvp.Rows.Add(id);

            SqlParameter tvparam = sql.Parameters.AddWithValue("@List", tvp);
            // these next lines are important to map the C# DataTable object to the correct SQL User Defined Type
            tvparam.SqlDbType = SqlDbType.Structured;
            tvparam.TypeName = "IDList";

            sql.Parameters.AddWithValue("@BOMID", BOMID);

            return sql.ExecuteNonQuery() > 0 ? true : false;
        }

        #endregion

        public void Dispose()
        {
            conn.Close();
        }
    }
}
