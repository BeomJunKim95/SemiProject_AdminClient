using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class FeatureVO : IComparable<FeatureVO>
    {
        public int Feature_ID { get; set; }
        public string Feature_Name { get; set; }
        public int Category_ID { get; set; }


        public int CompareTo(FeatureVO other)
        {
            return this.Feature_ID.CompareTo(other.Feature_ID);
        }
    }
}
