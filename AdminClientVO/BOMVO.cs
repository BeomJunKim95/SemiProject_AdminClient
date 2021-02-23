using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
    public class BOMVO
    {
        public int BOM_Child { get; set; }
        public int BOM_Parents { get; set; }
        public int BOM_Count { get; set; }
    }

    public class BOMSelectVO
    {
        public string   INFO            { get; set; }
        public string   Product_Name    { get; set; }
        public int      BOM_Child       { get; set; }
        public int      BOM_Parents     { get; set; }
        public int      BOM_Count       { get; set; }
        public int      level           { get; set; }
        public string   sortOrder       { get; set; }
    }
}
