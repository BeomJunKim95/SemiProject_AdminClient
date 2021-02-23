using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientVO;
using System.Data;
using System.Diagnostics;

namespace AdminClientDAC
{
	public class AddressDAC : ConnectionDB, IDisposable
	{
		string strConn;
		SqlConnection conn;

		public AddressDAC()
		{
			strConn = this.ConnectionDBs;
			conn = new SqlConnection(strConn);
			conn.Open();
		}

		/// <summary>
		/// DB에 모든 주소를 조회하는 메서드
		/// </summary>
		/// <returns>성공 : 주소목록 List, 실패 : null</returns>
		public List<AddressVO> GetAllAddress()
		{
			try
			{
				string sql = @"select user_ID, 
									  Addr_No, 
									  Addr_Receiver, 
									  Addr_Phone, 
									  concat(Addr, ' ', Addr_Detail) Addr,
									  Addr_NickName
								 from User_AddressInfo ";
				using(SqlCommand cmd = new SqlCommand(sql, conn))
				{
					SqlDataReader reader = cmd.ExecuteReader();
					List<AddressVO> list = Helper.DataReaderMapToList<AddressVO>(reader);

					return list;
				}
			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
				return null;
			}
		}

		public void Dispose()
		{
			conn.Close();
		}
	}
}
