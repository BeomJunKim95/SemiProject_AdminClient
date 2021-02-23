using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientDAC;
using AdminClientVO;

namespace AdminClient
{
    public class DivitionService
    {
        public List<DivitionVO> GetAllDivition()
        {
            using (DivitionDAC db = new DivitionDAC())
            {
                return db.GetAllDivition();
            }
        }
        public bool InsertDivition(int DivisionID, string DivisionName)
        {
            using (DivitionDAC db = new DivitionDAC())
            {
                return db.InsertDivition(DivisionID, DivisionName);
            }
        }


        public bool UpdateDivition(int DivisionID, string DivisionName)
        {
            using (DivitionDAC db = new DivitionDAC())
            {
                return db.UpdateDivition(DivisionID, DivisionName);
            }
        }

        public bool DeleteDivition(int DivisionID)
        {
            using (DivitionDAC db = new DivitionDAC())
            {
                return db.DeleteDivition(DivisionID);
            }
        }
    }
}
