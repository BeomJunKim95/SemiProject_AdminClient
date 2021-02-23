using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class DivitionVO : IComparable<DivitionVO>
    {
        public int Division_ID { get; set; }
        public string Division_Name { get; set; }

        public int CompareTo(DivitionVO other)
        {
            return this.Division_ID.CompareTo(other.Division_ID);
        }
    }
}
