using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class FeatureDAC : ConnectionDB , IDisposable
    {
        SqlConnection conn = new SqlConnection();

        public FeatureDAC()
        {
            conn.ConnectionString = ConnectionDBs;
            conn.Open();
        }

        #region Select
        public List<FeatureVO> GetAllFeature()
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = "select Feature_ID, Feature_Name, Category_ID from Features;"
            };

            using (SqlDataReader reader = sql.ExecuteReader())
            {
                return Helper.DataReaderMapToList<FeatureVO>(reader);
            }
        }
        #endregion

        #region Insert
        public bool InsertFeature(int Feature_ID, string Feature_Name, int Category_ID)
        {
            SqlCommand sql = new SqlCommand() 
            {
                Connection = conn,
                CommandText = @"insert into Features(Feature_ID, Feature_Name, Category_ID)
                              values(@Feature_ID, @Feature_Name, @Category_ID)"
            };
            sql.Parameters.AddWithValue("@Feature_ID", Feature_ID);
            sql.Parameters.AddWithValue("@Feature_Name", Feature_Name);
            sql.Parameters.AddWithValue("@Category_ID", Category_ID);

            return sql.ExecuteNonQuery() > 0 ? true : false;
        }

        #endregion

        #region Update
        public bool UpdateFeature(int Category_ID, string Feature_Name, int Feature_ID)
        {
            SqlCommand sql = new SqlCommand()
            {
                Connection = conn,
                CommandText = @"Update Features 
                set     Category_ID = @Category_ID,
                        Feature_Name = @Feature_Name
                where   Feature_ID = @Feature_ID;"
            };

            sql.Parameters.AddWithValue("@Category_ID", Category_ID);
            sql.Parameters.AddWithValue("@Feature_Name", Feature_Name);
            sql.Parameters.AddWithValue("@Feature_ID", Feature_ID);

            return sql.ExecuteNonQuery() > 0 ? true : false;
        }

        #endregion

        #region delete
        public bool DeleteFeature(int Feature_ID)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"delete from Features 
                              where Feature_ID = @Feature_ID;"
            };

            sql.Parameters.AddWithValue("@Feature_ID", Feature_ID);

            return sql.ExecuteNonQuery() > 0 ? true : false;
        }

        #endregion
        
        //@FeatureID, @FeatureName, @CategoryID
        #region 리플렉션
        public bool SP_FeatureInsert(int FeatureID, string FeatureName, int CategoryID)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    CommandText = "SP_FeatureInsert",
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Connection = conn
                };
                sql.Parameters.AddWithValue("@FeatureID", FeatureID);
                sql.Parameters.AddWithValue("@FeatureName", FeatureName);
                sql.Parameters.AddWithValue("@CategoryID", CategoryID);

                return sql.ExecuteNonQuery() > 0 ? true : false;
            }catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        #endregion

        public void Dispose()
        {
            conn.Close();
        }
    }
}
