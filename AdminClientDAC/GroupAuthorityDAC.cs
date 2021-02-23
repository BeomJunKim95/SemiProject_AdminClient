using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class GroupAuthorityDAC : ConnectionDB, IDisposable
    {
        SqlConnection conn = new SqlConnection();
        public GroupAuthorityDAC()
        {
            conn.ConnectionString = ConnectionDBs;
            conn.Open();
        }
        #region select
        public List<GroupAuthorityAndMenuNameVO> GetAllAuthorityAndMenu()
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = @"select Group_No, G.Form_Name,F.Menu_Name from 
                GroupAuthority G join Form_Info F
                on G.Form_Name = F.Form_Name"
            };
            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                return Helper.DataReaderMapToList<GroupAuthorityAndMenuNameVO>(reader);
            }
        }
        #endregion

        #region Insert
        public bool InsertGroupAuthority(int Group_No, string Form_Name)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = @"insert into GroupAuthority(Group_No, Form_Name)
                                values (@Group_No, @Form_Name);"
            };
            cmd.Parameters.AddWithValue("@Group_No", Group_No);
            cmd.Parameters.AddWithValue("@Form_Name", Form_Name);

            return cmd.ExecuteNonQuery() > 0 ? true: false;
        }
        #endregion

        #region Deleted
        public bool DeletedGroupAuthority(int Group_No, string Form_Name)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = @"delete from GroupAuthority
                                where Group_No =@Group_No and Form_Name= @Form_Name;"
            };
            cmd.Parameters.AddWithValue("@Group_No", Group_No);
            cmd.Parameters.AddWithValue("@Form_Name", Form_Name);

            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        #endregion


        public void Dispose()
        {
            conn.Close();
        }
    }
}
