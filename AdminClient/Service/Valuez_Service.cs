using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientDAC;
using AdminClientVO;

namespace AdminClient
{
    public class Valuez_Service
    {
        public List<ValuezcConnFeatureVO> GetValuezcConns(int Category_ID)
        {

            Valuez_DAC db = new Valuez_DAC();
            List<ValuezcConnFeatureVO> temp = db.GetValuezcConns(Category_ID);
            db.Dispose();
            return temp;
        }

        public List<ValuezConnProductVO> SP_SelectProductPropID(List<int> IDS)
        {
            using (Valuez_DAC db = new Valuez_DAC())
            {
                return db.SP_SelectProductPropID(IDS);
            }
        }

        public List<ValuezVO> GetAllValuez()
        {
            using (Valuez_DAC db = new Valuez_DAC())
            {
                return db.GetAllValuez();
            }
        }

        public bool InsertValuez(int Value_ID, string Value_Name, int Feature_ID)
        {
            using (Valuez_DAC db = new Valuez_DAC())
            {
                return db.InsertValuez(Value_ID, Value_Name, Feature_ID);
            }
        }

        public bool deleteValuez(int Value_ID)
        {
            using (Valuez_DAC db = new Valuez_DAC())
            {
                return db.deleteValuez(Value_ID);
            }
        }

        public bool UpdateValuez(int Value_ID, string Value_Name, int Feature_ID)
        {
            using (Valuez_DAC db = new Valuez_DAC())
            {
                return db.UpdateValuez(Value_ID, Value_Name, Feature_ID);
            }
        }

        public bool SP_ValuezDeleted(List<int> IDS)
        {
            using (Valuez_DAC db = new Valuez_DAC())
            {
                return db.SP_ValuezDeleted(IDS);
            }
        }
    }
}
