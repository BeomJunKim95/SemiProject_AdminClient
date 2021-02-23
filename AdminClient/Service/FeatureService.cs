using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientDAC;

namespace AdminClient
{
    public class FeatureService
    {
        public List<FeatureVO> GetAllFeature()
        {
            using(FeatureDAC db = new FeatureDAC())
            {
                return db.GetAllFeature();
            }
        }

        public bool InsertFeature(int Feature_ID, string Feature_Name, int Category_ID)
        {
            using (FeatureDAC db = new FeatureDAC())
            {
                return db.InsertFeature(Feature_ID, Feature_Name, Category_ID);
            }
        }

        public bool UpdateFeature(int Category_ID, string Feature_Name, int Feature_ID)
        {
            using (FeatureDAC db = new FeatureDAC())
            {
                return db.UpdateFeature(Category_ID, Feature_Name, Feature_ID);
            }
        }

        public bool SP_FeatureInsert(int FeatureID, string FeatureName, int CategoryID)
        {
            using (FeatureDAC db = new FeatureDAC())
            {
                return db.SP_FeatureInsert(FeatureID, FeatureName, CategoryID);
            }
        }

        public bool DeleteFeature(int Feature_ID)
        {
            using (FeatureDAC db = new FeatureDAC())
            {
                return db.DeleteFeature(Feature_ID);
            }
        }

    }
}
