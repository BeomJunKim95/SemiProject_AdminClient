using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
	class CompanyService : IDisposable
	{
		CompanyDAC dac;
		public CompanyService()
		{
			dac = new CompanyDAC();
		}

		public void Dispose()
		{
			dac.Dispose();
		}

		public List<CompanyVO> GetAllCompanyList()
		{
			return dac.GetAllCompanyList();
		}

		public List<CompanyDetailVO> GetAllCompanyDetailList(int comID)
		{
			return dac.GetAllCompanyDetailList(comID);
		}

		public bool InsertCompanyInfo(CompanyVO vo)
		{
			return dac.InsertCompanyInfo(vo);
		}
		public bool UpdateCompanyInfo(CompanyVO vo)
		{
			return dac.UpdateCompanyInfo(vo);
		}
		public bool InsertCompanyDetail(CompanyDetailVO vo)
		{
			return dac.InsertCompanyDetail(vo);
		}
		public List<CompanyVO> SearchCompanyList(int limit, string company, string category)
		{
			return dac.SearchCompanyList(limit, company, category);
		}
		public List<CompanyDetailVO> SearchCategoryList(int limit, string company, string category)
		{
			return dac.SearchCategoryList(limit, company, category);
		}
		public bool UpdatePriceCompanyDetail(CompanyDetailVO vo)
		{
			return dac.UpdatePriceCompanyDetail(vo);
		}
		public bool DeleteCompanyDetail(int comID, int prodID)
		{
			return dac.DeleteCompanyDetail(comID, prodID);
		}
		public bool DeleteCompanyInfo(int comID)
		{
			return dac.DeleteCompanyInfo(comID);
		}
	}
}
