using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AdminClientDAC
{
    public class Order_DAC : ConnectionDB, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public Order_DAC()
        {
            strConn = this.ConnectionDBs;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        /// <summary>
        /// 콤보박스에 바인딩할 목록 불러오기
        /// </summary>
        /// <returns></returns>
        public List<OrderComboBindingVO> GetComboBindingList()
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select ci.Company_ID, ci.Company_Name, ct.Category_ID, ct.Category_Name
	                                                                from Company_Info as ci, Company_Detail as cd, Products as pd, Categories as ct
	                                                                where ci.Company_ID = cd.Company_ID
	                                                                    and cd.Product_ID = pd.Product_ID
		                                                                and pd.Category_ID = ct.Category_ID";

                List<OrderComboBindingVO> list = Helper.DataReaderMapToList<OrderComboBindingVO>(cmd.ExecuteReader());

                return list;
            }
        }

        /// <summary>
        /// 발주목록 삭제 ( 이미 발주신청된것은 삭제불가 )
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public bool DeleteOrder(int orderID)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"delete from Order_Detail where Order_ID = @id;
                                                            delete from Orders where Order_ID = @id;";
                cmd.Parameters.AddWithValue("@id", orderID);

                int cnt = cmd.ExecuteNonQuery();

                if (cnt > 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// 입고관리 목록 불러오기
        /// </summary>
        /// <param name="compID"></param>
        /// <param name="cateID"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<WareHousingInfoVO> GetWareList(string compID, string cateID, string limit)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_GetWareHousingList";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@compID", string.IsNullOrEmpty(compID) ? DBNull.Value : (object)compID);
                cmd.Parameters.AddWithValue("@cateID", string.IsNullOrEmpty(cateID) ? DBNull.Value : (object)cateID);
                cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit) ? DBNull.Value : (object)limit);

                List<WareHousingInfoVO> list = Helper.DataReaderMapToList<WareHousingInfoVO>(cmd.ExecuteReader());

                return list;
            }
        }

        /// <summary>
        /// 입고확인
        /// </summary>
        /// <param name="oid"></param>
        /// <param name="pid"></param>
        /// <returns></returns>
        public bool SetWareHousing(int oid, int pid)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_WareHousingResultSet";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@oid", oid);
                cmd.Parameters.AddWithValue("@pid", pid);

                int cnt = cmd.ExecuteNonQuery();

                if (cnt > 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// 주문상세정보 변경
        /// </summary>
        /// <param name="dList"></param>
        /// <returns></returns>
        public bool UpdateDetailOrderInfo(List<OrderDetailInfoVO> dList, List<int> delList)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"delete from Order_Detail where Order_ID = @oid and Product_ID = @pid;
                                                            insert into Order_Detail(Order_ID, Product_ID, Order_Count, Order_Price) 
                                                                                           values(@oid, @pid, @cnt, (select Order_Price 
                                                                                                                                                from Company_Detail 
                                                                                                                                                where Product_ID = @pid))";

                SqlTransaction trans = conn.BeginTransaction();
                cmd.Transaction = trans;

                try
                {
                    for(int i = 0; i<dList.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@oid", dList[i].Order_ID);
                        cmd.Parameters.AddWithValue("@pid", dList[i].Product_ID);
                        cmd.Parameters.AddWithValue("@cnt", dList[i].Count);

                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = @"delete from Order_Detail where Order_ID = @oid and Product_ID = @pid;";

                    for(int i =0; i<delList.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@oid", dList[0].Order_ID);
                        cmd.Parameters.AddWithValue("@pid", delList[i]);

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

        /// <summary>
        /// 이미 작성되어있는 발주목록에 아이템 추가(이미 발주신청된것을 추가불가)
        /// </summary>
        /// <param name="oid"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool DetailOrderAdd(int oid, List<SearchProductListVO> list)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"insert into Order_Detail(Order_ID, Product_ID, Order_Count, Order_Price)
			                                                                                values(@oid, @pid, @cnt, ( select Order_Price 
                                                                                                                                                    from Company_Detail 
                                                                                                                                                    where Product_ID = @pid))";
                SqlTransaction trans = conn.BeginTransaction();

                cmd.Transaction = trans;

                try
                {
                    for(int i = 0; i<list.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@oid", oid);
                        cmd.Parameters.AddWithValue("@pid", list[i].Product_ID);
                        cmd.Parameters.AddWithValue("@cnt", list[i].Add_Count);

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


        /// <summary>
        /// 발주 목록 추가하기
        /// </summary>
        /// <param name="grpList"></param>
        /// <returns></returns>
        public bool Order(Dictionary<int, int> orderlist, List<int> complist)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                SqlTransaction trans = conn.BeginTransaction();

                cmd.Transaction = trans;

                try
                {
                    foreach(int compid in complist)
                    {
                        cmd.CommandText = @"insert into Orders(Company_ID, Order_Date, Order_Check) 
                                                                                         values(@compID, getdate(), 'N');
                                                                    select @@IDENTITY;";

                        cmd.Parameters.AddWithValue("@compID", compid);
                        int cnt = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach(var item in orderlist)
                        {
                            cmd.CommandText = @"insert into Order_Detail(Order_ID, Product_ID, Order_Count, Order_Price, Order_Result) 
								                                                                       values(@orderID, @prodID, 0, (select Order_Price 
																								                                                                    from Company_Detail 
																								                                                                    where Product_ID = @prodID), 'N');";

                            if(item.Value == compid)
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@orderID", cnt);
                                cmd.Parameters.AddWithValue("@prodID", item.Key);
                                cmd.ExecuteNonQuery();
                            }
                        }
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

        /// <summary>
        /// 추가되어있는 발주 신청하기
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public bool SetOrderCheck(int orderID)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_SetOrderCheck";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", orderID);

                int cnt = cmd.ExecuteNonQuery();

                if (cnt > 0)
                    return true;
                else
                    return false;

            }
        }


        /// <summary>
        /// 발주정보 불러오기
        /// </summary>
        /// <param name="limit">최대갯수 제한</param>
        /// <param name="category">카테고리번호</param>
        /// <param name="company">거래처번호</param>
        /// <param name="from">발주일자</param>
        /// <param name="to">발주일자</param>
        /// <returns></returns>
        public List<OrderInfoVO> GetOrderList(string limit, string category, string company, DateTime from, DateTime to)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_GetOrderList";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@category", string.IsNullOrEmpty(category)? DBNull.Value:(object)category);
                cmd.Parameters.AddWithValue("@company", string.IsNullOrEmpty(company) ? DBNull.Value : (object)company);
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);
                cmd.Parameters.AddWithValue("@limit", string.IsNullOrEmpty(limit)? 999999 : int.Parse(limit));

                List<OrderInfoVO> list = Helper.DataReaderMapToList<OrderInfoVO>(cmd.ExecuteReader());

                return list;
            }
        }

        /// <summary>
        /// 발주한 물품 정보 불러오기 (논리, 물리갯수, 발주갯수)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderItemInfoVO GetOrderItemInfo(int id, int oid)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"SP_GetProductInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@oid", oid);
                List<OrderItemInfoVO> info = Helper.DataReaderMapToList<OrderItemInfoVO>(cmd.ExecuteReader());

                return info[0];
            }
        }
    }
}
