using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient
{
    public class ComboService
    {
        internal List<ComboBoxBindingVO> GetComboList()
        {
            ComboDAC dac = new ComboDAC();
            List<ComboBoxBindingVO> list = dac.GetComboList();
            dac.Dispose();
            return list;
        }
    }
}
