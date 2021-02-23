using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class GroupInfoDAC : ConnectionDB, IDisposable
    {
        SqlConnection conn = new SqlConnection();

        public GroupInfoDAC()
        {
            conn.ConnectionString = ConnectionDBs;
            conn.Open();
        }

        #region select
        public List<GroupInfoVO> GetAllGroupInfo()
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = "select Group_No, GroupName from Group_Info"
            };
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                return Helper.DataReaderMapToList<GroupInfoVO>(reader);
            }
        }
        #endregion

        #region Insert
        public bool InserGroupInfo(int Group_No, string GroupName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"insert into Group_Info(Group_No, GroupName)
                               values(@Group_No, @GroupName);"
                };
                cmd.Parameters.AddWithValue("@Group_No", Group_No);
                cmd.Parameters.AddWithValue("@GroupName", GroupName);

                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception err)
            {
                return false;
            }
        }
        #endregion

        #region Upadate
        public bool UpdateGroupInfo(int Group_No, string GroupName)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = @"update Group_Info set GroupName = @GroupName
                                    where Group_No =@Group_No;"
            };
            cmd.Parameters.AddWithValue("@Group_No", Group_No);
            cmd.Parameters.AddWithValue("@GroupName", GroupName);

            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        #endregion

        #region Delete
        public bool DeleteGroupInfo(int Group_No)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = @"delete from Group_Info
                where Group_No =@Group_No;;"
            };
            cmd.Parameters.AddWithValue("@Group_No", Group_No);

            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        #endregion

        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
