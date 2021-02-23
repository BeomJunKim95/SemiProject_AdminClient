using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientDAC;
using AdminClientVO;

namespace AdminClient
{
    public class Product_Service
    {
        public List<ProductVO> GetProductList(string gubun, string category)
        {
            Product_DAC dac = new Product_DAC();
            return dac.GetProductList(gubun, category);
        }

        public bool InertFromVo(ProductinfoVO vo, string Props, ref int output)
        {
            using(Product_DAC dac = new Product_DAC())
            {
                return dac.InertFromVo(vo, Props, ref output);
            }
        }

        public bool UpdateFromVo(ProductinfoVO vo ,string Props)
        {
            using (Product_DAC db = new Product_DAC())
            {
                return db.UpdateFromVo(vo, Props);
            }
        }

        public bool deleteFromID(int productID)
        {
            using (Product_DAC db = new Product_DAC())
            {
                return db.deleteFromID(productID);
            }
        }

        public List<CategoryVO> GetCategoryList()
        {
            Product_DAC dac = new Product_DAC();
            return dac.GetCategoryList();
        }

        public List<ProductListVO> ProductJoinProp(int Category_ID)
        {
            List<ProductListVO> Result;
            Product_DAC db = new Product_DAC();
            Result =  db.ProductJoinProp(Category_ID);
            db.Dispose();

            return Result;
        }

        public ProductinfoVO SelectFromID(int ID)
        {
            using (Product_DAC db = new Product_DAC())
            {
                return db.SelectFromID(ID);
            }
        }

        public List<ProductinfoVO> SP_SelectProducts(int CatagrisID, int LimitCount, string Productsql, string ProductStat)
        {
            using(Product_DAC db = new Product_DAC())
            {
                return db.SP_SelectProducts(CatagrisID, LimitCount, Productsql, ProductStat);
            }
        }

        public List<SearchProductListVO> GetSearchProductList(string categoryID, string companyID, int limit, string div)
        {
            List<SearchProductListVO> list;
            Product_DAC dac = new Product_DAC();
            list = dac.GetSearchProductList(categoryID, companyID, limit, div);
            dac.Dispose();
            return list;
        }
    }
}
