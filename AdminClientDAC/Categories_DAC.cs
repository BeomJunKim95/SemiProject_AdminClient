using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientVO;

namespace AdminClientDAC
{
    public class Categories_DAC : ConnectionDB , IDisposable
    {
        SqlConnection conn;

        public Categories_DAC()
        {
            conn = new SqlConnection
            {
                ConnectionString = this.ConnectionDBs
            };

            conn.Open();
        }

        #region Select

        #region 카테고리에 따른 디비전 선택
        /// <summary>
        /// 카테고리를 디비전 아이디를 기준으로 찾아 리스트로 리턴
        /// 카테고리에 디비전 아이디는 넣지 않음
        /// </summary>
        /// <param name="Division_ID"></param>
        /// <returns></returns>
        public List<CategoriesVO> SelectCategoriesFromDivisionID(int Division_ID)
        {
            List<CategoriesVO> categories = new List<CategoriesVO>();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = "select Category_ID, Category_Name from Categories where Division_ID = @Division_ID;"
            };
            cmd.Parameters.AddWithValue("@Division_ID", Division_ID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CategoriesVO VO = new CategoriesVO();
                VO.Category_ID = Convert.ToInt32(reader["Category_ID"]);
                VO.Category_Name = reader["Category_Name"].ToString();
                categories.Add(VO);
            }

            return categories;
        }
        #endregion

        #region 모든 카테고리 목록 가져옴
        public List<CategoriesVO> GetAllCategries()
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = "select Category_ID, Category_Name, Division_ID from Categories"
            };

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                return Helper.DataReaderMapToList<CategoriesVO>(reader);
            }
        }

        #endregion

        #endregion

        #region Insert 
        public bool InsertCategories(int CategoryID,string CategoryName, int DivisionID)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = @" insert into Categories(Category_ID, Category_Name, Division_ID)
            values(@Category_ID, @Category_Name, @Division_ID)",
                Connection = conn
            };

            cmd.Parameters.AddWithValue("@Category_ID", CategoryID);
            cmd.Parameters.AddWithValue("@Category_Name", CategoryName);
            cmd.Parameters.AddWithValue("@Division_ID", DivisionID);

            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        #endregion

        #region Update 
        public bool UpdateCategories(int CategoryID, string CategoryName, int DivisionID)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = @"UPDATE Categories 
                set Division_ID = @DivisionID,
                Category_Name = @CategoryName
                where Category_ID = @CategoryID;",
                Connection = conn
            };

            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
            cmd.Parameters.AddWithValue("@DivisionID", DivisionID);

            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        #endregion

        #region delete
        public bool DeleteCategories(int CategoryID)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = @"delete from Categories
                where Category_ID = @CategoryID",
                Connection = conn
            };
            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);

            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        #endregion

        //@Category_ID, @Category_Name, @Division_ID
        #region 스토어드 프로시저
        public bool SP_CategoryInsert(int Category_ID, string Category_Name, int Division_ID)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "SP_CategoryInsert",
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                sql.Parameters.AddWithValue("@Category_ID", Category_ID);
                sql.Parameters.AddWithValue("@Category_Name", Category_Name);
                sql.Parameters.AddWithValue("@Division_ID", Division_ID);

                return sql.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception err)
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
