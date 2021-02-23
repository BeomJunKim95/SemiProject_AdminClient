using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient
{
    class Order_Service
    {
        internal List<OrderComboBindingVO> GetComboBindingList()
        {
            Order_DAC dac = new Order_DAC();
            List<OrderComboBindingVO> list = dac.GetComboBindingList();
            dac.Dispose();
            return list;
        }

        internal List<OrderInfoVO> GetOrderList(string limit, string category, string company, DateTime from, DateTime to)
        {
            Order_DAC dac = new Order_DAC();
            List<OrderInfoVO> list = dac.GetOrderList(limit, category, company, from, to);
            dac.Dispose();
            return list;
        }

        internal OrderItemInfoVO GetOrderItemInfo(int id, int oid)
        {
            Order_DAC dac = new Order_DAC();
            OrderItemInfoVO info = dac.GetOrderItemInfo(id, oid);
            dac.Dispose();
            return info;

        }

        internal bool SetOrderCheck(int orderID)
        {
            Order_DAC dac = new Order_DAC();
            bool result = dac.SetOrderCheck(orderID);
            dac.Dispose();
            return result;
        }

        internal bool Order(Dictionary<int, int> orderlist, List<int> complist)
        {
            Order_DAC dac = new Order_DAC();
            bool result = dac.Order(orderlist, complist);
            dac.Dispose();
            return result;
        }

        internal bool DeleteOrder(int orderID)
        {
            Order_DAC dac = new Order_DAC();
            bool result = dac.DeleteOrder(orderID);
            dac.Dispose();
            return result;
        }

        internal bool DetailOrderAdd(int oid, List<SearchProductListVO> list)
        {
            Order_DAC dac = new Order_DAC();
            bool result = dac.DetailOrderAdd(oid, list);
            dac.Dispose();
            return result;
        }

        internal bool UpdateDetailOrderInfo(List<OrderDetailInfoVO> dList, List<int> delList)
        {
            Order_DAC dac = new Order_DAC();
            bool result = dac.UpdateDetailOrderInfo(dList, delList);
            dac.Dispose();
            return result;
        }

        internal List<WareHousingInfoVO> GetWareList(string compID, string cateID, string limit)
        {
            Order_DAC dac = new Order_DAC();
            List<WareHousingInfoVO> list = dac.GetWareList(compID, cateID, limit);
            dac.Dispose();
            return list;
        }

        internal bool SetWareHousing(int oid, int pid)
        {
            Order_DAC dac = new Order_DAC();
            bool result = dac.SetWareHousing(oid, pid);
            dac.Dispose();
            return result;
        }
    }
}
