using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient
{
    public class GroupAuthority_Service
    {
        public List<GroupAuthorityAndMenuNameVO> GetAllAuthorityAndMenu()
        {
            using (GroupAuthorityDAC db = new GroupAuthorityDAC())
            {
                return db.GetAllAuthorityAndMenu();
            }
        }

        public bool InsertGroupAuthority(int Group_No, string Form_Name)
        {
            using (GroupAuthorityDAC db = new GroupAuthorityDAC())
            {
                return db.InsertGroupAuthority(Group_No, Form_Name);
            }
        }

        public bool DeletedGroupAuthority(int Group_No, string Form_Name)
        {
            using (GroupAuthorityDAC db = new GroupAuthorityDAC())
            {
                return db.DeletedGroupAuthority(Group_No, Form_Name);
            }
        }
    }
}
