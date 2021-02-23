using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    class Purchase_Service
    {
        public List<PurchaseVO> GetAllPurchaseList(string limit, string from, string to)
        {
            PurchaseDAC dac = new PurchaseDAC();
            List<PurchaseVO> list = dac.GetAllPurchaseList(limit, from, to);
            dac.Dispose();
            return list;
        }

        public bool SendPurchase(List<int> pIDs)
        {
            PurchaseDAC dac = new PurchaseDAC();
            bool result = dac.SendPurchase(pIDs);
            dac.Dispose();
            return result;
        }
    }
}
