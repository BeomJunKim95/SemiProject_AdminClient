using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientVO;
using AdminClientDAC;

namespace AdminClient
{
    public class Categories_Service
    {

        public List<CategoriesVO> GetAllCategries()
        {
            using (Categories_DAC db = new Categories_DAC())
            {
                return db.GetAllCategries();
            }
        }


        public List<CategoriesVO> SelectCategoriesFromDivisionID(int DivisionID)
        {
            List<CategoriesVO> temp;
            Categories_DAC db = new Categories_DAC();
            temp = db.SelectCategoriesFromDivisionID(DivisionID);
            db.Dispose();
            return temp;

        }

        public bool UpdateCategories(int CategoryID, string CategoryName, int DivisionID)
        {
            using(Categories_DAC db = new Categories_DAC())
            {
                return db.UpdateCategories(CategoryID, CategoryName, DivisionID);
            }
        }

        public bool DeleteCategories(int CategoryID)
        {
            using (Categories_DAC db = new Categories_DAC())
            {
                return db.DeleteCategories(CategoryID);
            }
        }

        public bool InsertCategories(int CategoryID, string CategoryName, int DivisionID)
        {
            using (Categories_DAC db = new Categories_DAC())
            {
                return db.InsertCategories(CategoryID, CategoryName, DivisionID);
            }
        }


        public bool SP_CategoryInsert(int Category_ID, string Category_Name, int Division_ID)
        {
            using (Categories_DAC db = new Categories_DAC())
            {
                return db.SP_CategoryInsert(Category_ID, Category_Name, Division_ID);
            }
        }
    }
}
