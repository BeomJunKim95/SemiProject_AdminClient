using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class ProductVO
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public decimal Product_Price { get; set; }
        public int Product_PsyCount { get; set; }
        public string Product__Stand { get; set; }
        public string Category_Name { get; set; }
        public string Division_Name { get; set; }
        public byte[] Product_Img { get; set; }
    }

    public class ProductinfoVO
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public decimal Product_Price { get; set; }
        public int Product_Min { get; set; }
        public int Product_Max { get; set; }
        public int Product_PsyCount { get; set; }
        public int Product_LogCount { get; set; }
        public string Product_State { get; set; }
        public string Category_Name { get; set; }
        public string Product__Stand { get; set; }
        public int Category_ID { get; set; }
        public byte[] Product_Img { get; set; }
    }

    public class ProductListVO
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Price { get; set; }
        public string Product_Info { get; set; }
        public string Product_Info_ID { get; set; }
        public byte[] Product_Img { get; set; }
    }

    public class BOMReverseVO
    {
        public string Product_Name { get; set; }
        public decimal Product_Price { get; set; }
    }

    public class WishListVO
    {
        public Dictionary<int, int> ItemList { get; set; } // Key : 제품번호, Value : 갯수
        public string User_ID { get; set; }
        public string NickName { get; set; }
    }

    public class SearchProductListVO : IComparable<SearchProductListVO>
    {
        int comp = 0;

        //불러오기
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public decimal Product_Price { get; set; }
        public string Product__Stand { get; set; }
        public string Product_State { get; set; }
        public string Common_Name { get; set; }
        public int Company_ID { get; set; }
        public string Company_Name { get; set; }
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        public int Product_PsyCount { get; set; }
        public int Product_LogCount { get; set; }
        public int Product_Min { get; set; }
        public int Product_Max { get; set; }
        public decimal Order_Price { get; set; }
        public int Division_ID { get; set; }
        public string Division_Name { get; set; }

        //저장용
        public int Add_Count { get; set; }

        //정렬용
        public int Comp 
        {
            set { comp = value; }
        }

        public int CompareTo(SearchProductListVO other)
        {
            switch(comp)
            {
                case 2:
                    return this.Product_Name.CompareTo(other.Product_Name);
                case 3:
                    return this.Category_ID.CompareTo(other.Category_ID);
                case 4:
                    return this.Order_Price.CompareTo(other.Order_Price);
                default:
                    return this.Product_ID.CompareTo(other.Product_ID);
            }
        }
    }
}
