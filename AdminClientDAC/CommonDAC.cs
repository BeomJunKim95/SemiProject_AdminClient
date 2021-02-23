using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientVO;

namespace AdminClientDAC
{
    public class CommonDAC : ConnectionDB, IDisposable
    {
        SqlConnection conn = new SqlConnection();

        public CommonDAC()
        {
            conn.ConnectionString = "Server=whyfi8888.ddns.net,11433;Uid=team4;Pwd=team4;Database=TEAM4";
            conn.Open();
        }

        #region select
        public List<CommonVO> SelctCommonForPcode(string pcode)
        {
            SqlCommand sql = new SqlCommand
            {
                CommandText = @"select Common_Code, Common_Name, Common_Category, Common_Pcode from Common
                                where Common_Pcode = @Common_Pcode",
                Connection = conn
            };
            sql.Parameters.AddWithValue("@Common_Pcode", pcode);

            using (SqlDataReader reader = sql.ExecuteReader()) {
                return Helper.DataReaderMapToList<CommonVO>(reader);
            }
        }
        #endregion

        #region 승원
        public bool Insert(CommonVO vo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"insert into Common(Common_Code, Common_Name, Common_Category, Common_Pcode, Fst_Writer, Fst_WriteDate)
                                                  values (@Common_Code, @Common_Name, @Common_Category, @Common_Pcode, 'a', getdate())";

                cmd.Parameters.AddWithValue("@Common_Code", vo.Common_Code);
                cmd.Parameters.AddWithValue("@Common_Name", vo.Common_Name);
                cmd.Parameters.AddWithValue("@Common_Category", vo.Common_Category);
                cmd.Parameters.AddWithValue("@Common_Pcode", vo.Common_Pcode);

                int iRowAffect = cmd.ExecuteNonQuery();
                return iRowAffect > 0;
            }
        }

        public List<CommonVO> Research()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Common_Code, Common_Name, Common_Category, Common_Pcode
                                    from Common";

                List<CommonVO> list = Helper.DataReaderMapToList<CommonVO>(cmd.ExecuteReader());
                return list;
            }
        }

        public bool Update(CommonVO vo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"update Common set Common_Name = @Common_Name,
                                                      Common_Category = @Common_Category,
                                                      Common_Pcode = @Common_Pcode
		                                        where Common_Code = @Common_Code";

                cmd.Parameters.AddWithValue("@Common_Code", vo.Common_Code);
                cmd.Parameters.AddWithValue("@Common_Name", vo.Common_Name);
                cmd.Parameters.AddWithValue("@Common_Category", vo.Common_Category);
                cmd.Parameters.AddWithValue("@Common_Pcode", vo.Common_Pcode);

                int iRows = cmd.ExecuteNonQuery();
                if (iRows > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool Delete(string Common_Code)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from Common where Common_Code = @Common_Code";

                cmd.Parameters.AddWithValue("@Common_Code", Common_Code);
                int iRowAffect = cmd.ExecuteNonQuery();
                conn.Close();

                return iRowAffect > 0;

            };
        }
        #endregion

            public void Dispose()
        {
            conn.Close();
        }
    }
}
