using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class ValuezVO : IComparable<ValuezVO>
    {
        public int Value_ID { get; set; }
        public string Value_Name { get; set; }
        public int Feature_ID { get; set; }

        public int CompareTo(ValuezVO other)
        {
           return this.Value_ID.CompareTo(other.Value_ID);
        }
    }

    public class ValuezConnProductVO : IComparable<ValuezVO>
    {
        public int Value_ID { get; set; }
        public string Value_Name { get; set; }
        public int Product_ID { get; set; }

        public int CompareTo(ValuezVO other)
        {
            return this.Value_ID.CompareTo(other.Value_ID);
        }
    }

    public class ValuezcConnFeatureVO
    {
        public int Value_ID { get; set; }
        public string Value_Name { get; set; }
        public string Feature_Name { get; set; }
    }
}
