using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class GroupInfoVO : IEquatable<GroupInfoVO>, IComparable<GroupInfoVO>
    {
        public int Group_No { get; set; }
        public string GroupName { get; set; }


        public int CompareTo(GroupInfoVO other)
        {
            return this.Group_No.CompareTo(other.Group_No);
        }

        public bool Equals(GroupInfoVO other)
        {
            if (other == null) return false;
            return this.Group_No == other.Group_No;
        }
    }
}
