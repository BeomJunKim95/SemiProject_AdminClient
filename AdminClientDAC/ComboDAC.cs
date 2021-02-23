using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientVO;

namespace AdminClientDAC
{
    public class ComboDAC : ConnectionDB, IDisposable
    {
        SqlConnection conn = new SqlConnection();
        public ComboDAC()
        {
            conn.ConnectionString = ConnectionDBs;
            conn.Open();
        }

        public List<ComboBoxBindingVO> GetComboList()
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_GetComboBindingList";
                cmd.CommandType = CommandType.StoredProcedure;

                List<ComboBoxBindingVO> list = Helper.DataReaderMapToList<ComboBoxBindingVO>(cmd.ExecuteReader());

                return list;
            }
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
