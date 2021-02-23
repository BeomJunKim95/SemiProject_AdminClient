using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class FormInfoVO
    {
        public string Form_Name { get;   set; }
        public string Menu_Name { get;   set; }
    }

    public class FormInfoAndGNameVO
    {
        public string Form_Name { get; set; }
        public string Menu_Name { get; set; }
        public string GroupName { get; set; } 
    }
}
