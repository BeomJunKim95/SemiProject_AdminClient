using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient
{
    public class BOMService
    {
        public void IsBOMChild(int ProductID)
        {
            using(BOMDAC db = new BOMDAC())
            {
                db.IsBOMChild(ProductID);
            }
        }

        public List<BOMSelectVO> BOM_Child(int ProductID)
        {
            using (BOMDAC db = new BOMDAC())
            {
               return db.BOM_Child(ProductID);
            }
        }

        public bool BOMUpdate(int BOM_Child, int BOM_Parents, int Count)
        {
            using (BOMDAC db = new BOMDAC())
            {
                return db.BOMUpdate(BOM_Child, BOM_Parents, Count);
            }
        }

        public bool BOMdelete(int BOM_Child, int BOM_Parents)
        {
            using (BOMDAC db = new BOMDAC())
            {
                return db.BOMdelete(BOM_Child, BOM_Parents);
            }
        }

        public List<BOMVO> BOMAllList()
        {
            using (BOMDAC db = new BOMDAC())
            {
                return db.BOMAllList();
            }
        }
        public bool SP_InsertBOM(int BOMID, List<int> List)
        {
            using (BOMDAC db = new BOMDAC())
            {
                return db.SP_InsertBOM(BOMID, List);
            }
        }

        public List<BOMReverseVO> BOMReverse(int Parents)
        {
            using (BOMDAC db = new BOMDAC())
            {
                return db.BOMReverse(Parents);
            }

        }
    }
}
