using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientVO
{
	public class CompanyVO
	{
		public int Company_ID { get; set; }
		public string Company_Name { get; set; }
		public string Company_CEO { get; set; }
		public string Company_Tel { get; set; }
		public int Company_PostCode { get; set; }
		public string Company_Addr { get; set; }
		public string Company_AddrDetail { get; set; }
		public string Company_Deleted { get; set; }
		public string Company_Addr_show { get; set; }
	}

	public class CompanyDetailVO
	{
		public int Company_ID { get; set; }
		public int Product_ID { get; set; }
		public string Product_Name { get; set; }
		public string Categories { get; set; }
		public decimal Order_Price { get; set; }

	}
}
