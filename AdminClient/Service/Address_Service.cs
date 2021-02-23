using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminClientDAC;
using AdminClientVO;

namespace AdminClient
{
	class Address_Service : IDisposable
	{
		AddressDAC dac;
		public Address_Service()
		{
			dac = new AddressDAC();
		}

		public List<AddressVO> GetAllAddress()
		{
			return dac.GetAllAddress();
		}

		public void Dispose()
		{
			dac.Dispose();
		}
	}
}
