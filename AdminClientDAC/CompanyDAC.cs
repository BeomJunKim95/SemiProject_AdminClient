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
	public class CompanyDAC : ConnectionDB, IDisposable
	{
		SqlConnection conn = new SqlConnection();

		public CompanyDAC()
		{
			conn.ConnectionString = ConnectionDBs;
			conn.Open();
		}

		public void Dispose()
		{
			conn.Close();
		}

		/// <summary>
		/// Company_Info테이블에 모든 유통사 목록을 가져오는 메서드
		/// </summary>
		/// <returns> 유통사 객체 List </returns>
		public List<CompanyVO> GetAllCompanyList()
		{
			try
			{
				SqlCommand cmd = new SqlCommand
				{
					Connection = conn,
					CommandText = @"select Company_ID, Company_Name, Company_CEO, Company_Tel, Company_PostCode, 
										   ISNULL(concat(Company_Addr, Company_AddrDetail), '없음') Company_Addr_show,
										   Company_Addr, Company_AddrDetail
									  from Company_Info
									 where Company_Deleted = 'CD01' "
				};
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					var list = Helper.DataReaderMapToList<CompanyVO>(reader);
					if (list.Count == 0)
						return null;

					return list;
				}
			}
			catch
			{
				return null;
			}
		}

		/// <summary>
		/// Company_Detail테이블에 해당 유통사의 상세 목록을 가져오는 메서드
		/// </summary>
		/// <param name="comID"> 유통사 코드</param>
		/// <returns> 유통사 상세목록 객체 List </returns>
		public List<CompanyDetailVO> GetAllCompanyDetailList(int comID)
		{
			try
			{
				SqlCommand cmd = new SqlCommand
				{
					Connection = conn,
					CommandText = @"select Company_ID, CD.Product_ID, P.Product_Name, Categories, Order_Price
									  from Company_Detail CD, Products P
									 where CD.Product_ID = P.Product_ID
									   and Company_ID = @Company_ID "
				};
				cmd.Parameters.AddWithValue("@Company_ID", comID);

				using(SqlDataReader reader = cmd.ExecuteReader())
				{
					var list = Helper.DataReaderMapToList<CompanyDetailVO>(reader);
					if (list.Count == 0)
						return null;

					return list;
				}
			}
			catch
			{
				return null;
			}
		}

		/// <summary>
		/// Company_Info테이블에 새로운 유통사 정보를 Insert하는 메서드
		/// </summary>
		/// <param name="vo">유통사 정보 객체 List</param>
		/// <returns>성공 : true,	실패 : false </returns>
		public bool InsertCompanyInfo(CompanyVO vo)
		{
			try
			{
				SqlCommand cmd = new SqlCommand()
				{
					Connection = conn,
					CommandText = @"insert into Company_Info(Company_Name, Company_CEO, Company_Tel, Company_PostCode, Company_Addr, Company_AddrDetail)
										 values (@Company_Name, @Company_CEO, @Company_Tel, @Company_PostCode, @Company_Addr, @Company_AddrDetail)"
				};
				cmd.Parameters.AddWithValue("@Company_Name", vo.Company_Name);
				cmd.Parameters.AddWithValue("@Company_CEO", vo.Company_CEO);
				cmd.Parameters.AddWithValue("@Company_Tel", vo.Company_Tel);
				cmd.Parameters.AddWithValue("@Company_PostCode", vo.Company_PostCode);
				cmd.Parameters.AddWithValue("@Company_Addr", vo.Company_Addr);
				cmd.Parameters.AddWithValue("@Company_AddrDetail", vo.Company_AddrDetail);

				int iRowAffect = cmd.ExecuteNonQuery();
				if (iRowAffect > 0)
					return true;
				else
					return false;
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// Company_Info테이블에 기존의 정보를 Update하는 메서드
		/// </summary>
		/// <param name="vo">유통사 정보 객체</param>
		/// <returns>성공 : true,	실패 : false</returns>
		public bool UpdateCompanyInfo(CompanyVO vo)
		{
			try
			{
				SqlCommand cmd = new SqlCommand()
				{
					Connection = conn,
					CommandText = @"update Company_Info
									   set Company_Name = @Company_Name, 
										   Company_CEO = @Company_CEO, 
										   Company_Tel = @Company_Tel,
										   Company_PostCode = @Company_PostCode, 
										   Company_Addr = @Company_Addr, 
										   Company_AddrDetail = @Company_AddrDetail
									 where Company_ID = @Company_ID"
				};
				cmd.Parameters.AddWithValue("@Company_ID", vo.Company_ID);
				cmd.Parameters.AddWithValue("@Company_Name", vo.Company_Name);
				cmd.Parameters.AddWithValue("@Company_CEO", vo.Company_CEO);
				cmd.Parameters.AddWithValue("@Company_Tel", vo.Company_Tel);
				cmd.Parameters.AddWithValue("@Company_PostCode", vo.Company_PostCode);
				cmd.Parameters.AddWithValue("@Company_Addr", vo.Company_Addr);
				cmd.Parameters.AddWithValue("@Company_AddrDetail", vo.Company_AddrDetail);

				int iRowAffect = cmd.ExecuteNonQuery();
				if (iRowAffect > 0)
					return true;
				else
					return false;
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// Company_Info테이블에 기존의 유통사 정보의 Delete부분을 CD02로 변경해 삭제처리
		/// </summary>
		/// <param name="comID"> 유통사 ID </param>
		/// <returns> 성공 : true,	실패 : false </returns>
		public bool DeleteCompanyInfo(int comID)
		{
			try
			{
				SqlCommand cmd = new SqlCommand()
				{
					Connection = conn,
					CommandText = "SP_DeleteCompanyInfo",
					CommandType = CommandType.StoredProcedure
				};
				cmd.Parameters.AddWithValue("@Company_ID", comID);

				int iRowAffect = cmd.ExecuteNonQuery();
				if (iRowAffect > 0)
					return true;
				else
					return false;
			}
			catch
			{
				return false;
			}
		}

		//int comID,int prodID, string prodName, string category, decimal price
		public bool InsertCompanyDetail(CompanyDetailVO vo)
		{
			try
			{
				SqlCommand cmd = new SqlCommand()
				{
					Connection = conn,
					CommandText = @" insert into Company_Detail(Company_ID, Product_ID, Categories)
										  values (@Company_ID, @Product_ID, @Categories) "
				};
				cmd.Parameters.AddWithValue("@Company_ID", vo.Company_ID);
				cmd.Parameters.AddWithValue("@Product_ID", vo.Product_ID);
				cmd.Parameters.AddWithValue("@Categories", vo.Categories);
				

				int iRowAffect = cmd.ExecuteNonQuery();
				if (iRowAffect > 0)
					return true;
				else
					return false;
			}
			catch
			{
				return false;
			}
		}

		public bool UpdatePriceCompanyDetail(CompanyDetailVO vo)
		{
			try
			{
				SqlCommand cmd = new SqlCommand()
				{
					Connection = conn,
					CommandText = @"  update Company_Detail
									     set Order_Price = @Order_Price 
									   where Company_ID = @Company_ID
									   	 and Product_ID = @Product_ID "
				};
				cmd.Parameters.AddWithValue("@Company_ID", vo.Company_ID);
				cmd.Parameters.AddWithValue("@Product_ID", vo.Product_ID);
				cmd.Parameters.AddWithValue("@Order_Price", vo.Order_Price);

				int iRowAffect = cmd.ExecuteNonQuery();
				if (iRowAffect > 0)
					return true;
				else
					return false;
			}
			catch
			{
				return false;
			}
		}

		public bool DeleteCompanyDetail(int comID, int prodID)
		{
			try
			{
				SqlCommand cmd = new SqlCommand()
				{
					Connection = conn,
					CommandText = @"delete from Company_Detail
									 where Company_ID = @Company_ID
									   and Product_ID = @Product_ID "
				};
				cmd.Parameters.AddWithValue("@Company_ID", comID);
				cmd.Parameters.AddWithValue("@Product_ID", prodID);

				int iRowAffect = cmd.ExecuteNonQuery();
				if (iRowAffect > 0)
					return true;
				else
					return false;
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// 유통사 조건 검색을 위한 검색 메서드
		/// </summary>
		/// <param name="limit">검색수 제한 </param>
		/// <param name="company"> 유통사 이름 </param>
		/// <returns>검색 결과물 객체 List<CompanyVO> </returns>
		public List<CompanyVO> SearchCompanyList(int limit, string company, string category)
		{
			try
			{
				SqlCommand cmd = new SqlCommand()
				{
					Connection = conn,
					CommandText = "SP_SearchCompanyList",
					CommandType = CommandType.StoredProcedure
				};
				cmd.Parameters.AddWithValue("@limit", limit);
				cmd.Parameters.AddWithValue("@company", string.IsNullOrEmpty(company)? DBNull.Value : (object)company);
				cmd.Parameters.AddWithValue("@category", string.IsNullOrEmpty(category) ? DBNull.Value : (object)category);

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					var list = Helper.DataReaderMapToList<CompanyVO>(reader);
					if (list.Count == 0)
						return null;

					return list;
				}
			}
			catch
			{
				return null;
			}
		}

		/// <summary>
		/// 유통사 상세 조건 검색을 위한 메서드
		/// </summary>
		/// <param name="limit">검색 수 제한</param>
		/// <param name="company">유통사 이름</param>
		/// <param name="category">카테고리 이름</param>
		/// <returns>검색 결과물 객체 List<CompanyDetailVO></returns>
		public List<CompanyDetailVO> SearchCategoryList(int limit, string company, string category)
		{
			try
			{
				SqlCommand cmd = new SqlCommand()
				{
					Connection = conn,
					CommandText = "SP_SearchCategoryForComp",
					CommandType = CommandType.StoredProcedure
				};
				cmd.Parameters.AddWithValue("@limit", limit);
				cmd.Parameters.AddWithValue("@company", company);
				cmd.Parameters.AddWithValue("@category", category);

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					var list = Helper.DataReaderMapToList<CompanyDetailVO>(reader);
					if (list.Count == 0)
						return null;

					return list;
				}
			}
			catch
			{
				return null;
			}
		}
	}
}
