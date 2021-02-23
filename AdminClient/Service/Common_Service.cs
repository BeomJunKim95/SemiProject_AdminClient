using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientDAC;
using AdminClientVO;

namespace AdminClient
{
    public class Common_Service
    {
        public List<CommonVO> SelctCommonForPcode(string pcode)
        {
            using (CommonDAC db = new CommonDAC())
            {
                return db.SelctCommonForPcode(pcode);
            }
        }

        #region 승원
        public bool Insert(CommonVO vo)
        {
            CommonDAC dac = new CommonDAC();
            return dac.Insert(vo);
        }

        public List<CommonVO> Research()
        {
            CommonDAC dac = new CommonDAC();
            List<CommonVO> list = dac.Research();
            dac.Dispose();
            return list;
        }

        public bool Update(CommonVO vo)
        {
            CommonDAC dac = new CommonDAC();
            bool result = dac.Update(vo);
            dac.Dispose();
            return result;
        }

        public bool Delete(string Common_Code)
        {
            CommonDAC dac = new CommonDAC();
            bool result = dac.Delete(Common_Code);
            dac.Dispose();
            return result;
        }
        #endregion
    }
}
