using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data.SqlClient;
using AdminClientVO;
using System.Data;
using System.Diagnostics;

namespace AdminClientDAC
{
    public class Product_DAC : ConnectionDB, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public Product_DAC()
        {
            strConn = this.ConnectionDBs;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        /// <summary>
        /// 구분 및 카테고리를 통해 제품의 목록을 불러옴
        /// </summary>
        /// <param name="gubun">완제품, 부품등 제품의 구분</param>
        /// <param name="category">CPU, GPU등 제품의 카테고리</param>
        /// <returns>제품목록 리스트</returns>
        public List<ProductVO> GetProductList(string gubun, string category)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SP_GetProductList";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@Division", string.IsNullOrEmpty(gubun) ? DBNull.Value : (object)gubun);
                cmd.Parameters.AddWithValue("@CategoryName", string.IsNullOrEmpty(category) ? DBNull.Value : (object)category);

                List<ProductVO> list = Helper.DataReaderMapToList<ProductVO>(cmd.ExecuteReader());
                conn.Close();
                return list;
            }
        }

        /// <summary>
        /// 카테고리 목록을 불러옴
        /// </summary>
        /// <returns>카테고리 목록 리스트</returns>
        public List<CategoryVO> GetCategoryList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = @"select Category_Name, Division_Name
	                                                                from Categories as cg, Divisions as dv
	                                                                where cg.Division_ID = dv.Division_ID";
                cmd.Connection = conn;

                List<CategoryVO> list = Helper.DataReaderMapToList<CategoryVO>(cmd.ExecuteReader());
                conn.Close();
                return list;
            }
        }

        /// <summary>
        /// 물품 검색 (조건) 결과 리스트
        /// </summary>
        /// <param name="categoryID">카테고리 아이디</param>
        /// <param name="companyID">유통사 아이디</param>
        /// <param name="limit">최대검색 갯수제한</param>
        /// <returns></returns>
        public List<SearchProductListVO> GetSearchProductList(string categoryID, string companyID, int limit, string div)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_SearchProductList";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@category", string.IsNullOrEmpty(categoryID) ? DBNull.Value : (object)categoryID);
                cmd.Parameters.AddWithValue("@company", string.IsNullOrEmpty(companyID) ? DBNull.Value : (object)companyID);
                cmd.Parameters.AddWithValue("@limit", limit);
                cmd.Parameters.AddWithValue("@div", string.IsNullOrEmpty(div)? DBNull.Value : (object)div);

                List<SearchProductListVO> list = Helper.DataReaderMapToList<SearchProductListVO>(cmd.ExecuteReader());

                return list;
            }
        }


        #region 이용현
        #region 스토어드 프로시저

        #region Product과 Prop를 조합한 것을 리턴

        public List<ProductListVO> ProductJoinProp(int Category_ID)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = "SP_ProductJoinProp",
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sql.Parameters.AddWithValue("@Category_ID", Category_ID);

            SqlDataReader reader = sql.ExecuteReader();
            List<ProductListVO> ProductLists = new List<ProductListVO>();
            while (reader.Read())
            {
                ProductListVO temp = new ProductListVO();
                temp.Product_ID = Convert.ToInt32(reader["Product_ID"]);
                temp.Product_Info = reader["Product_Info"].ToString();
                temp.Product_Info_ID = reader["Product_Info_ID"].ToString();
                temp.Product_Name = reader["Product_Name"].ToString();
                temp.Product_Price = reader["Product_Price"].ToString();
                temp.Product_Img = (byte[])reader["Product_Img"];
                ProductLists.Add(temp);
            }

            return ProductLists;
        }
        #endregion

        #region 검색 조건에 따른 Products 조회

        public List<ProductinfoVO> SP_SelectProducts(int CatagrisID, int LimitCount, string Productsql, string ProductStat)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = "SP_SelectProducts",
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sql.Parameters.AddWithValue("@CatagrisID", CatagrisID);
            sql.Parameters.AddWithValue("@LimitCount", LimitCount);
            sql.Parameters.AddWithValue("@Productsql", Productsql);
            sql.Parameters.AddWithValue("@ProductStat", ProductStat);

            using (SqlDataReader reader = sql.ExecuteReader())
            {
                return Helper.DataReaderMapToList<ProductinfoVO>(reader);
            }
        }

        #endregion
        #endregion

        #region 스토어드 프로시저
        public void test(byte[] bs, int prode)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"update Products set Product_Img  = @Product_Img
        where Product_ID = @Product_ID; "
            };
            sql.Parameters.Add("@Product_Img", SqlDbType.Image);
            sql.Parameters["@Product_Img"].Value = bs;
            sql.Parameters.Add("@Product_ID", SqlDbType.Int);
            sql.Parameters["@Product_ID"].Value = prode;

            sql.ExecuteNonQuery();
        }

        public void test(byte[] bs)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"update Products set Product_Img  = @Product_Img"
            };
            sql.Parameters.Add("@Product_Img", SqlDbType.Image);
            sql.Parameters["@Product_Img"].Value = bs;

            sql.ExecuteNonQuery();
        }

        #endregion
        #endregion

        #region select
        public ProductinfoVO SelectFromID(int ID)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"select Product_ID, Product_Name, Product_Price, Product_Min, Product_Max,
                Product_PsyCount,
                Product_LogCount,
                Product_State,
                Category_ID,
                Product__Stand,
                Product_Img
                from Products where Product_ID = @Product_ID"
            };
            sql.Parameters.AddWithValue("@Product_ID", ID);

            using (SqlDataReader reader = sql.ExecuteReader())
            {
                return Helper.DataReaderMapToList<ProductinfoVO>(reader)[0];
            }
        }
        #endregion

        #region Update
        public bool UpdateFromVo(ProductinfoVO vo, string Props)
        {
            SqlTransaction transaction = conn.BeginTransaction();
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"Update Products
                Set Product_Name = @Product_Name,
                Product_Price = @Product_Price,
                Product_Min = @Product_Min,
                Product_Max = @Product_Max,
                Product_PsyCount = @Product_PsyCount,
                Product_LogCount = @Product_LogCount,
                Product_State = @Product_State,
                Category_ID = @Category_ID,
                Product__Stand = @Product__Stand,
                Product_Img = @Product_Img
                where Product_ID = @Product_ID",
                    Transaction = transaction
                };
                sql.Parameters.AddWithValue("@Product_ID", vo.Product_ID);
                sql.Parameters.AddWithValue("@Product_Name", vo.Product_Name);
                sql.Parameters.AddWithValue("@Product_Price", vo.Product_Price);
                sql.Parameters.AddWithValue("@Product_Min", vo.Product_Min);
                sql.Parameters.AddWithValue("@Product_Max", vo.Product_Max);
                sql.Parameters.AddWithValue("@Product_PsyCount", vo.Product_PsyCount);
                sql.Parameters.AddWithValue("@Product_State", vo.Product_State);
                sql.Parameters.AddWithValue("@Category_ID", vo.Category_ID);
                sql.Parameters.AddWithValue("@Product_LogCount", vo.Product_LogCount);
                sql.Parameters.AddWithValue("@Product__Stand", vo.Product__Stand == null ? DBNull.Value : (object)vo.Product__Stand);
                sql.Parameters.Add("@Product_Img", SqlDbType.Image);
                sql.Parameters["@Product_Img"].Value = vo.Product_Img;

                bool Try = sql.ExecuteNonQuery() > 0 ? true : false;

                if (!Try)
                {
                    transaction.Rollback();
                    return false;
                }

                sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "SP_UpdateProduct",
                    CommandType = CommandType.StoredProcedure,
                    Transaction = transaction
                };
                sql.Parameters.AddWithValue("@ProductID", vo.Product_ID);
                sql.Parameters.AddWithValue("@Props", Props);
                Try = sql.ExecuteNonQuery() > 0 ? true : false;
                if (Try)
                {
                    transaction.Commit();
                    return true;
                }
                else
                {
                    transaction.Rollback();
                    return false;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                transaction.Rollback();
                return false;
            }

        }

        #endregion

        #region Insert
        public bool InertFromVo(ProductinfoVO vo, string Props, ref int outint)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"SP_InsertProduct",
                    CommandType = CommandType.StoredProcedure
                };
                sql.Parameters.AddWithValue("@Product_ID", vo.Product_ID);
                sql.Parameters.AddWithValue("@Product_Name", vo.Product_Name);
                sql.Parameters.AddWithValue("@Product_Price", vo.Product_Price);
                sql.Parameters.AddWithValue("@Product_Min", vo.Product_Min);
                sql.Parameters.AddWithValue("@Product_Max", vo.Product_Max);
                sql.Parameters.AddWithValue("@Product_PsyCount", vo.Product_PsyCount);
                sql.Parameters.AddWithValue("@Product_State", vo.Product_State);
                sql.Parameters.AddWithValue("@Category_ID", vo.Category_ID);
                sql.Parameters.AddWithValue("@Product_LogCount", vo.Product_LogCount);
                sql.Parameters.AddWithValue("@Product__Stand", vo.Product__Stand == null ? DBNull.Value : (object)vo.Product__Stand);
                sql.Parameters.Add("@Product_Img", SqlDbType.Image);
                sql.Parameters["@Product_Img"].Value = vo.Product_Img;
                sql.Parameters.AddWithValue("@Props", Props);
                SqlParameter oPrameter = new SqlParameter("@ID", SqlDbType.Int);
                oPrameter.Direction = ParameterDirection.Output;
                sql.Parameters.Add(oPrameter);
                bool result = sql.ExecuteNonQuery() > 0 ? true : false;
                if(result)
                outint = (int)oPrameter.Value;
                return result;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }
        #endregion

        #region delete
        public bool deleteFromID(int productID)
        {
            SqlCommand sql = new SqlCommand
            {
                Connection = conn,
                CommandText = @"delete from Product_Prop
                where Product_ID =@Product_ID;
                delete from Products
                where Product_ID =@Product_ID;"
            };

            sql.Parameters.AddWithValue("@Product_ID", productID);

            return sql.ExecuteNonQuery() > 0 ? true : false;
        }


        #endregion

        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
