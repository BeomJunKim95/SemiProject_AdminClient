using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class OrderInfoVO
    {
        public int Order_ID { get; set; }
        public int Company_ID { get; set; }
        public string Company_Name { get; set; }
        public string Order_Date { get; set; }
        public string Order_Check { get; set; }
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public decimal Order_Price { get; set; }
        public int Order_Count { get; set; }

    }

    public class OrderDetailInfoVO
    {
        public string Category_Name { get; set; }
        public string Product_Name { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public int Order_Result { get; set; }
        public int Product_ID { get; set; }
        public string Check { get; set; }
        public int Order_ID { get; set; }
    }

    public class OrderItemInfoVO
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public byte[] Product_Img { get; set; }
        public string Category_Name { get; set; }
        public string Company_Name { get; set; }
        public int Product_LogCount { get; set; }
        public int Product_PsyCount { get; set; }
        public int Order_Count { get; set; }
        public string ValueNamez { get; set; }
    }

    public class OrderComboBindingVO
    {
        public int Company_ID { get; set; }
        public string Company_Name { get; set; }
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
    }

    public class WareHousingInfoVO 
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        public int Product_PsyCount { get; set; }
        public int Product_LogCount { get; set; }
        public int Product_Min { get; set; }
        public int Product_Max { get; set; }
        public int Company_ID { get; set; }
        public string Company_Name { get; set; }
        public int Order_ID { get; set; }
        public string Order_Date { get; set; }
        public int Order_Count { get; set; }
        public string Order_Check { get; set; }
        public string Order_Result { get; set; }
        public string Valuez { get; set; }
        public string ValuezNames { get; set; }

    }

    public class WareDetailInfo
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public int Order_ID { get; set; }
        public string Order_Date { get; set; }
        public int Order_Count { get; set; }
        public string Order_Result { get; set; }
        public int Company_ID { get; set; }
        public string Company_Name { get; set; }
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        public int Product_PsyCount { get; set; }
        public int Product_LogCount { get; set; }
        public int Product_Min { get; set; }
        public int Product_Max { get; set; }
        public string ValuezNames { get; set; }
    }
}
