using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientVO;

namespace AdminClientDAC
{
    public class Valuez_DAC : ConnectionDB, IDisposable
    {
        SqlConnection conn;

        public Valuez_DAC()
        {
            conn = new SqlConnection
            {
                ConnectionString = this.ConnectionDBs
            };

            conn.Open();
        }

        #region select

        #region 모든 벨류
        public List<ValuezVO> GetAllValuez()
        {
            SqlCommand sql = new SqlCommand()
            {
                Connection = conn,
                CommandText = $@"SELECT Value_Name, Value_ID, Feature_ID
                                FROM Valuez;"
            };

            using (SqlDataReader reader = sql.ExecuteReader())
            {
                return Helper.DataReaderMapToList<ValuezVO>(reader);
            }
        }
        #endregion

        #region 피처에 따른 벨류
        public List<ValuezVO> GetValuezConnFeature(int FeatureID)
        {
            SqlCommand sql = new SqlCommand()
            {
                Connection = conn,
                CommandText = $@"SELECT V.Value_Name, V.Value_ID, F.Feature_ID
                                FROM Valuez V join Features F 
	                            on V.Feature_ID = F.Feature_ID
                                where F.Feature_ID = @Feature_ID;"
            };
            sql.Parameters.AddWithValue("@Feature_ID", FeatureID);
            using (SqlDataReader reader = sql.ExecuteReader())
            {
                return Helper.DataReaderMapToList<ValuezVO>(reader);
            }
        }
        #endregion

        #region 카테고리에 따른 벨류 찾기
        public List<ValuezcConnFeatureVO> GetValuezcConns(int Category_ID)
        {
            SqlCommand sql = new SqlCommand()
            {
                Connection = conn,
                CommandText = $@"SELECT V.Value_Name, V.Value_ID, F.Feature_Name
                                FROM Valuez V join Features F 
	                            on V.Feature_ID = F.Feature_ID
	                            join Categories C 
                                on F.Category_ID = C.Category_ID
                                where C.Category_ID = @Category_ID;"
            };

            sql.Parameters.AddWithValue("@Category_ID", Category_ID);
            SqlDataReader reader = sql.ExecuteReader();

            List<ValuezcConnFeatureVO> vs = new List<ValuezcConnFeatureVO>();
            while (reader.Read())
            {
                vs.Add(new ValuezcConnFeatureVO
                {
                    Value_Name = reader["Value_Name"].ToString(),
                    Value_ID = Convert.ToInt32(reader["Value_ID"]),
                    Feature_Name = reader["Feature_Name"].ToString()
                });
            }

            return vs;

        }
        #endregion

        #endregion

        #region insert

        #endregion

        #region update
        public bool UpdateValuez(int Value_ID, string Value_Name, int Feature_ID)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"update Valuez set Value_Name = @Value_Name, Feature_ID = @Feature_ID
                                where Value_ID = @Value_ID"
            };
            sql.Parameters.AddWithValue("@Value_ID", Value_ID);
            sql.Parameters.AddWithValue("@Value_Name", Value_Name);
            sql.Parameters.AddWithValue("@Feature_ID", Feature_ID);

            return sql.ExecuteNonQuery() > 0 ? true : false;
        }
        #endregion

        #region delete
        public bool deleteValuez(int Value_ID)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"delete from Valuez
                                where Value_ID = @Value_ID"
            };
            sql.Parameters.AddWithValue("@Value_ID", Value_ID);

            return sql.ExecuteNonQuery() > 0 ? true : false;
        }
        #endregion

        #region 프로시저
        /// <summary>
        /// 만약 PF가 0이라면 (입력안되면) 오토 인크리먼트 대로 넣음 아니면 지정한 ID값에 넣음
        /// </summary>
        /// <param name="Value_ID">PF</param>
        /// <param name="Value_Name"></param>
        /// <param name="Feature_ID"></param>
        /// <returns></returns>
        public bool InsertValuez(int Value_ID, string Value_Name, int Feature_ID)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"SP_ValuezInsert",
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                sql.Parameters.AddWithValue("@ValuezID", Value_ID);
                sql.Parameters.AddWithValue("@ValueName", Value_Name);
                sql.Parameters.AddWithValue("@FeaturID", Feature_ID);

                return sql.ExecuteNonQuery() > 0 ? true : false;
            }catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
            
        }

        public bool SP_ValuezDeleted(List<int> IDS)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"SP_ValuezDeleted",
                CommandType = System.Data.CommandType.StoredProcedure
            };

            DataTable tvp = new DataTable();
            tvp.Columns.Add(new DataColumn("ID", typeof(int)));

            foreach (var id in IDS)
                tvp.Rows.Add(id);

            SqlParameter tvparam = sql.Parameters.AddWithValue("@List", tvp);
            // these next lines are important to map the C# DataTable object to the correct SQL User Defined Type
            tvparam.SqlDbType = SqlDbType.Structured;
            tvparam.TypeName = "IDList";

            //sql.ExecuteNonQuery();
            return sql.ExecuteNonQuery() > 0 ? true : false;

        }

        public List<ValuezConnProductVO> SP_SelectProductPropID(List<int> IDS)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"SP_SelectProductPropID",
                CommandType = System.Data.CommandType.StoredProcedure
            };

            DataTable tvp = new DataTable();
            tvp.Columns.Add(new DataColumn("ID", typeof(int)));

            foreach (var id in IDS)
                tvp.Rows.Add(id);

            SqlParameter tvparam = sql.Parameters.AddWithValue("@List", tvp);
            // these next lines are important to map the C# DataTable object to the correct SQL User Defined Type
            tvparam.SqlDbType = SqlDbType.Structured;
            tvparam.TypeName = "IDList";

            using (SqlDataReader reader = sql.ExecuteReader())
            {
                var list = Helper.DataReaderMapToList<ValuezConnProductVO>(reader);
                return list;
            }

        }
        #endregion

        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
