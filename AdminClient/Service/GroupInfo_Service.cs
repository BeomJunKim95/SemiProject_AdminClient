using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient
{
    public class GroupInfo_Service
    {
        public List<GroupInfoVO> GetAllGroupInfo()
        {
            using(GroupInfoDAC db = new GroupInfoDAC()){
                return db.GetAllGroupInfo();  
            }
        }

        public bool InserGroupInfo(int Group_No, string GroupName)
        {
            using (GroupInfoDAC db = new GroupInfoDAC())
            {
                return db.InserGroupInfo(Group_No, GroupName);
            }
        }

        public bool DeleteGroupInfo(int Group_No)
        {
            using (GroupInfoDAC db = new GroupInfoDAC())
            {
                return db.DeleteGroupInfo(Group_No);
            }
        }


        public bool UpdateGroupInfo(int Group_No, string GroupName)
        {
            using (GroupInfoDAC db = new GroupInfoDAC())
            {
                return db.UpdateGroupInfo(Group_No, GroupName);
            }
        }
    }
}
