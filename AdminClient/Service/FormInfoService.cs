using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient
{
    public class FormInfoService
    {
        public List<FormInfoAndGNameVO> GetFormForEmp(int Emp_No)
        {
            using (FormInfoDAC db = new FormInfoDAC())
            {
                return db.GetFormForEmp(Emp_No);
            }
        }

        public List<FormInfoVO> GetAllFormInfo()
        {
            using (FormInfoDAC db = new FormInfoDAC())
            {
                return db.GetAllFormInfo();
            }
        }

        public bool InsertFormInfo(string FormName, string MenuName)
        {
            using (FormInfoDAC db = new FormInfoDAC())
            {
                return db.InsertFormInfo(FormName, MenuName);
            }
        }

        public bool DeleteFormInfo(string FormName)
        {
            using (FormInfoDAC db = new FormInfoDAC())
            {
                return db.DeleteFormInfo(FormName);
            }
        }


        public bool UpdateFormInfo(string FormName, string Menu_Name)
        {
            using (FormInfoDAC db = new FormInfoDAC())
            {
                return db.UpdateFormInfo(FormName, Menu_Name);
            }
        }
    }
}
