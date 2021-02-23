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
    public class PurchaseDAC : ConnectionDB, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public PurchaseDAC()
        {
            strConn = this.ConnectionDBs;
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        public void Dispose()
        {
            conn.Close();
        }

        public List<PurchaseVO> GetAllPurchaseList(string limit, string from, string to)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SP_GetAllPurchaseList";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? DBNull.Value : (object)limit);
                cmd.Parameters.AddWithValue("@from", string.IsNullOrEmpty(from) ? DBNull.Value : (object)from);
                cmd.Parameters.AddWithValue("@to", string.IsNullOrEmpty(to) ? DBNull.Value : (object)to);

                List<PurchaseVO> list = Helper.DataReaderMapToList<PurchaseVO>(cmd.ExecuteReader());

                return list;
            }
        }

        public bool SendPurchase(List<int> pIDs)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SP_SetSendList";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlTransaction trans = conn.BeginTransaction();

                cmd.Transaction = trans;

                try
                {
                    for(int i = 0; i<pIDs.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@pchID", pIDs[i]);
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    return false;
                }
            }
        }

    }
}
