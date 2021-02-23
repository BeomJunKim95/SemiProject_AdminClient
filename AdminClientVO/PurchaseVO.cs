using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class PurchaseVO
    {
        public int Purchase_ID { get; set; }
        public string user_ID { get; set; }
        public string Purchase_Date { get; set; }
        public string Common_Code { get; set; }
        public string Common_Name { get; set; }
        public string user_Phone { get; set; }
        public string user_Email { get; set; }
        public string Addr_NickName { get; set; }
        public string Addr_Receiver { get; set; }
        public int Addr_No { get; set; }
        public int Addr_PostCode { get; set; }
        public string Addr { get; set; }
        public string Addr_Detail { get; set; }
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        public string Product__Stand { get; set; }
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public decimal Products_Price { get; set; }
        public int Purchase_Count { get; set; }


        /////////////////////////////////////////////////////////////////////
        public int SumPrice { get; set; }
        public int Cnt { get; set; }

    }
}
