using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class CategoryVO
    {
        public string Category_Name { get; set; }
        public string Division_Name { get; set; }
    }

    public class CategoriesVO : IComparable<CategoriesVO>
    {
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        public int Division_ID { get; set; }

        public CategoriesVO()
        {

        }

        public CategoriesVO(int category_ID)
        {
            Category_ID = category_ID;
        }

        public CategoriesVO(int category_ID, string category_Name) : this(category_ID)
        {
            Category_Name = category_Name;
        }

        public CategoriesVO(int category_ID, string category_Name, int division_ID) : this(category_ID, category_Name)
        {
            Division_ID = division_ID;
        }

        public int CompareTo(CategoriesVO other)
        {
            return this.Category_ID.CompareTo(other.Category_ID);
        }
    }
}
