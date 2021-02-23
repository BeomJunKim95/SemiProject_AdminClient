using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminClient;

namespace AdminClient.Start
{
	public partial class Company_Manager : Form
	{
		public enum ModeSelect { Insert, Update } //등록, 수정 모드를 구분하기 위한 열겨형 타입
		ModeSelect mode;

		CompanyVO selectedCompanyInfo;
		List<CompanyVO> allCompaniesList;
		List<CompanyDetailVO> comDetailList;

		List<OrderComboBindingVO> cbx_List;

		public Company_Manager()
		{
			InitializeComponent();
		}


		#region 이벤트

		private void Company_Manager_Load(object sender, EventArgs e)
		{
			#region dgv_CompanyInfo 컬럼바인딩
			CommonUtil.SetInitGridView(dgv_CompanyInfo, false);
			CommonUtil.AddGridTextColumn(dgv_CompanyInfo, "유통사 코드", "Company_ID"); //0
			CommonUtil.AddGridTextColumn(dgv_CompanyInfo, "유통사 명", "Company_Name"); //1
			CommonUtil.AddGridTextColumn(dgv_CompanyInfo, "대표 명", "Company_CEO"); //2
			CommonUtil.AddGridTextColumn(dgv_CompanyInfo, "전화번호", "Company_Tel");//3
			CommonUtil.AddGridTextColumn(dgv_CompanyInfo, "우편번호", "Company_PostCode", 10, false);//4
			CommonUtil.AddGridTextColumn(dgv_CompanyInfo, "주소", "Company_Addr_show", 400);//5
			CommonUtil.AddGridTextColumn(dgv_CompanyInfo, "주소", "Company_Addr", 10, false);//6
			CommonUtil.AddGridTextColumn(dgv_CompanyInfo, "주소", "Company_AddrDetail", 10, false);//7
			#endregion
			#region dgv_CompanyDetail 컬럼바인딩
			CommonUtil.SetInitGridView(dgv_CompanyDetail, false);
			CommonUtil.AddGridTextColumn(dgv_CompanyDetail, "유통사 코드", "Company_ID", 10, false); //0
			CommonUtil.AddGridTextColumn(dgv_CompanyDetail, "품목 명", "Product_Name", 300); //1
			CommonUtil.AddGridTextColumn(dgv_CompanyDetail, "품목 카테고리", "Categories"); //2
			CommonUtil.AddGridTextColumn(dgv_CompanyDetail, "납품 단가", "Order_Price");//3
			#endregion
			#region dgv_CompanyDetail_Manage 컬럼 바인딩
			CommonUtil.SetInitGridView(dgv_CompanyDetail_Manage, false);
			CommonUtil.AddGridTextColumn(dgv_CompanyDetail_Manage, "유통사 코드", "Company_ID", 10, false); //0
			CommonUtil.AddGridTextColumn(dgv_CompanyDetail_Manage, "품목ID", "Product_ID"); //1
			CommonUtil.AddGridTextColumn(dgv_CompanyDetail_Manage, "품목 명", "Product_Name"); //2
			CommonUtil.AddGridTextColumn(dgv_CompanyDetail_Manage, "납품 단가", "Order_Price");//3
			#endregion

			#region 콤보박스 바인딩

			Order_Service service = new Order_Service();
			cbx_List = service.GetComboBindingList();

			Dictionary<int, string> companyList = new Dictionary<int, string>();
			Dictionary<int, string> categoryList = new Dictionary<int, string>();
			companyList.Add(0, "전체"); // Dictionary 0번째 값 추가
			categoryList.Add(0, "전체"); // Dictionary 0번째 값 추가

			//각 Dictionary에 값넣기
			foreach (var item in cbx_List)
			{
				if (!companyList.ContainsKey(item.Company_ID))
					companyList.Add(item.Company_ID, item.Company_Name);

				if (!categoryList.ContainsKey(item.Category_ID))
					categoryList.Add(item.Category_ID, item.Category_Name);
			}

			CommonUtil.BindingComboBoxDictionary(cbo_cateCate, categoryList);
			CommonUtil.BindingComboBoxDictionary(cbo_compComp, companyList);


			#endregion

			gb_Category.Enabled = gb_Company.Enabled = false;

			//전체 유통사목록 조회
			//LoadAllCompanies();

			txt_ComDetail_Price.KeyPress += UtilEvent.TextBoxIsDigit;
		}

		#region 콤보박스 바인딩
		private void cbo_cateCate_SelectedIndexChanged(object sender, EventArgs e) // 카테고리선택후 해당 카테고리에 따른 유통사 바인딩
		{
			if (cbo_cateCate.SelectedIndex < 1)
				cbo_cateComp.DataSource = null;

			if (cbo_cateCate.SelectedIndex > 0)
			{
				int cateID = Convert.ToInt32(cbo_cateCate.SelectedValue);

				var CompList = (from comp in cbx_List
								where comp.Category_ID == cateID
								group comp by new { comp.Company_ID, comp.Company_Name } into complist
								select new
								{
									ID = complist.Key.Company_ID,
									Name = complist.Key.Company_Name
								}).ToList();

				CompList.Insert(0, new { ID = 0, Name = "전체" });

				cbo_cateComp.DataSource = new BindingSource(CompList, null);
				cbo_cateComp.DisplayMember = "Name";
				cbo_cateComp.ValueMember = "ID";
			}
		}

		private void cbo_compComp_SelectedIndexChanged(object sender, EventArgs e) // 유통사 선택 후 해당 유통사에 따른 카테고리 바인딩
		{
			if (cbo_compComp.SelectedIndex < 1)
				cbo_compCate.DataSource = null;

			if (cbo_compComp.SelectedIndex > 0)
			{
				int compID = Convert.ToInt32(cbo_compComp.SelectedValue);

				var CateList = (from cate in cbx_List
								where cate.Company_ID == compID
								group cate by new { cate.Category_ID, cate.Category_Name } into catelist
								select new
								{
									ID = catelist.Key.Category_ID,
									Name = catelist.Key.Category_Name
								}).ToList();

				CateList.Insert(0, new { ID = 0, Name = "전체" });

				cbo_compCate.DataSource = new BindingSource(CateList, null);
				cbo_compCate.DisplayMember = "Name";
				cbo_compCate.ValueMember = "ID";
			}
		}
		#endregion

		#region 검색조건 콤보박스 Checked 이벤트
		private void cbx_Company_CheckedChanged(object sender, EventArgs e)
		{
			if(cbx_Company.Checked)
            {
				gb_Company.Enabled = true;
				cbx_Category.Checked = false;
            }
			else
            {
				gb_Company.Enabled = false;
            }
		}

		private void cbx_Category_CheckedChanged(object sender, EventArgs e)
		{
			if(cbx_Category.Checked)
            {
				gb_Category.Enabled = true;
				cbx_Company.Checked = false;
            }else
            {
				gb_Category.Enabled = false;
            }
		}

		private void cbx_SearchLimit_CheckedChanged(object sender, EventArgs e)
		{
			if (cbx_SearchLimit.Checked == true)
				nu_SearchLimit.Enabled = true;
			else
				nu_SearchLimit.Enabled = false;
		}
		#endregion

		#region 버튼 이벤트

		private void btn_AddrSearch_Click(object sender, EventArgs e) //유통사정보에 주소찾기 버튼
		{
			frmSearchAddr frm = new frmSearchAddr();
			if (frm.ShowDialog() == DialogResult.OK) //주소찾기 팝업창을 띄우고 검색한 주소 받아오기
			{
				txt_CompanyPostCode.Text = frm.ZipCode.ToString();
				txt_CompanyAddr.Text = frm.Address1;
				txt_CompanyAddrDetail.Text = frm.Address2;
			}
		}

		private void btn_InsertCompany_Click(object sender, EventArgs e) //추가 버튼 클릭
		{
			tab_CompanyManage.Enabled = true;
			tab_CompanyManage.SelectedTab = tabPage1;
			txt_CompanyName.Focus();
			mode = ModeSelect.Insert;
			label9.Visible = false;
			lbl_CompanyID.Visible = false;
			txt_CompanyName.Text = "";
			txt_CompanyCEO.Text = "";
			txt_CompanyTel.Text = "";
			txt_CompanyPostCode.Text = "";
			txt_CompanyAddr.Text = "";
			txt_CompanyAddrDetail.Text = "";
		}

		private void btn_UpdateCompany_Click(object sender, EventArgs e) //수정 버튼 클릭
		{
			
			if (selectedCompanyInfo == null)
			{
				MessageBox.Show("유통사 항목을 제대로 선택해주세요.");
				return;
			}
			else
			{
				tab_CompanyManage.Enabled = true;
				lbl_CompanyID.Visible = true;
				label9.Visible = true;
				tab_CompanyManage.SelectedTab = tabPage1;
				txt_CompanyName.Focus();
				mode = ModeSelect.Update;
				txt_CompanyName.Text = selectedCompanyInfo.Company_Name;
				txt_CompanyCEO.Text = selectedCompanyInfo.Company_CEO;
				txt_CompanyTel.Text = selectedCompanyInfo.Company_Tel;
				txt_CompanyPostCode.Text = selectedCompanyInfo.Company_PostCode.ToString();
				txt_CompanyAddr.Text = selectedCompanyInfo.Company_Addr;
				txt_CompanyAddrDetail.Text = selectedCompanyInfo.Company_AddrDetail;
				lbl_CompanyID.Text = selectedCompanyInfo.Company_ID.ToString();
			}
			
		}

		private void btn_DeleteCompany_Click(object sender, EventArgs e) //삭제 버튼 클릭
		{
			CompanyService service = new CompanyService();
			if (selectedCompanyInfo.Company_ID > 0)
			{
				if (MessageBox.Show("정말로 삭제 하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					bool bResult = service.DeleteCompanyInfo(selectedCompanyInfo.Company_ID);
					service.Dispose();
					if (bResult)
					{
						MessageBox.Show("유통사 정보 삭제가 완료됐습니다.");
						LoadAllCompanies();
						dgv_CompanyDetail_Manage.DataSource = null;
						dgv_CompanyDetail.DataSource = null;
					}
					else
					{
						MessageBox.Show("유통사 정보 삭제중 오류가 발생했습니다. 다시 시도하여 주십시오");
						return;
					}
				}
			}
			else
			{
				MessageBox.Show("삭제할 유통사를 선택하여 주십시오.");
				return;
			}
		}

		private void btn_AllCompanyList_Click(object sender, EventArgs e) //전체 유통사 목록 버튼
		{
			LoadAllCompanies();
		}

		private void btn_Search_Click(object sender, EventArgs e) //검색 버튼 클릭
		{
			string category, company;
			category = company = string.Empty;

			int limit = 0;

			if (cbx_SearchLimit.Checked)
				limit = (int)nu_SearchLimit.Value;

			if (cbx_Category.Checked)
			{
				if (cbo_cateCate.SelectedIndex > 0)
					category = cbo_cateCate.SelectedValue.ToString();
				if (cbo_cateComp.SelectedIndex > 0)
					company = cbo_cateComp.SelectedValue.ToString();
			}
			else if (cbx_Company.Checked)
			{
				if (cbo_compComp.SelectedIndex > 0)
					company = cbo_compComp.SelectedValue.ToString();
				if (cbo_compCate.SelectedIndex > 0)
					category = cbo_compCate.SelectedValue.ToString();
			}

			CompanyService service = new CompanyService();
			allCompaniesList = service.SearchCompanyList(limit, company, category);
			comDetailList = service.SearchCategoryList(limit, company, category);
			service.Dispose();

            var list = (from comp in allCompaniesList
                        group comp by new
                        {
                            comp.Company_ID,
                            comp.Company_Name,
                            comp.Company_CEO,
                            comp.Company_Tel,
                            comp.Company_PostCode,
                            comp.Company_Addr_show,
                            comp.Company_Addr,
                            comp.Company_AddrDetail
                        } into grp
                        select new
                        {
                            Company_ID = grp.Key.Company_ID,
                            Company_Name = grp.Key.Company_Name,
                            Company_CEO = grp.Key.Company_CEO,
                            Company_Tel = grp.Key.Company_Tel,
                            Company_PostCode = grp.Key.Company_PostCode,
                            Company_Addr_show = grp.Key.Company_Addr_show,
                            Company_Addr = grp.Key.Company_Addr,
                            Company_AddrDetail = grp.Key.Company_AddrDetail
                        }).ToList();

            dgv_CompanyInfo.DataSource = list;

            dgv_CompanyDetail.DataSource = dgv_CompanyDetail_Manage.DataSource = comDetailList;

			tab_CompanyManage.Enabled = true;
			tab_CompanyManage.SelectedTab = tabPage2;

		}


		private void btn_Insert_Click(object sender, EventArgs e) //유통사 정보 저장버튼
		{
			//유효성 체크
			StringBuilder sb = new StringBuilder(); //한번에 입력안된 부분을 출력해주기 위한 StringBuilder객체
			if (string.IsNullOrEmpty(txt_CompanyName.Text))
				sb.AppendLine("유통사 명");
			if (string.IsNullOrEmpty(txt_CompanyCEO.Text))
				sb.AppendLine("대표 명");
			if (string.IsNullOrEmpty(txt_CompanyPostCode.Text) || string.IsNullOrEmpty(txt_CompanyAddr.Text) || string.IsNullOrEmpty(txt_CompanyAddrDetail.Text))
				sb.AppendLine("주소");
			if (sb.Length > 0)
			{
				sb.Append("모두 입력해주세요");
				MessageBox.Show(sb.ToString());
				return;
			}

			try
			{
				bool bResult;
				CompanyService service = new CompanyService();
				CompanyVO comInfo = new CompanyVO
				{
					//Company_ID = Convert.ToInt32(lbl_CompanyID.Text),
					Company_Name = txt_CompanyName.Text,
					Company_CEO = txt_CompanyCEO.Text,
					Company_Tel = txt_CompanyTel.Text,
					Company_PostCode = Convert.ToInt32(txt_CompanyPostCode.Text),
					Company_Addr = txt_CompanyAddr.Text,
					Company_AddrDetail = txt_CompanyAddrDetail.Text
				};

				if (mode == ModeSelect.Insert)
				{
					bResult = service.InsertCompanyInfo(comInfo);
					service.Dispose();
					if (bResult)
					{
						MessageBox.Show("유통사 신규등록이 완료되었습니다.");
						tab_CompanyManage.Enabled = false;
						txt_CompanyName.Text = "";
						txt_CompanyCEO.Text = "";
						txt_CompanyTel.Text = "";
						txt_CompanyPostCode.Text = "";
						txt_CompanyAddr.Text = "";
						txt_CompanyAddrDetail.Text = "";

						LoadAllCompanies();
					}
					else
					{
						MessageBox.Show("유통사 신규등록중 오류가 발생했습니다. 다시 시도해 주십시오.");
						return;
					}
				}
				else //수정모드
				{
					bResult = service.UpdateCompanyInfo(comInfo);
					service.Dispose();
					if (bResult)
					{
						MessageBox.Show("유통사 정보수정이 완료되었습니다.");
						tab_CompanyManage.Enabled = false;
						txt_CompanyName.Text = "";
						txt_CompanyCEO.Text = "";
						txt_CompanyTel.Text = "";
						txt_CompanyPostCode.Text = "";
						txt_CompanyAddr.Text = "";
						txt_CompanyAddrDetail.Text = "";
						label9.Visible = false;
						lbl_CompanyID.Visible = false;

						LoadAllCompanies();
					}
					else
					{
						MessageBox.Show("유통사 정보수정중 오류가 발생했습니다. 다시 시도해 주십시오.");
						return;
					}
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

		private void btn_AddProduct_Click(object sender, EventArgs e) //물품 추가 버튼
		{
			Common_Service common_Service = new Common_Service();

			ProductPopUp prodPopup = new ProductPopUp(common_Service.SelctCommonForPcode("PS00"));
			if (prodPopup.ShowDialog() == DialogResult.Yes)
			{
				
				MessageBox.Show("유통사 품목 등록이 완료되었습니다.");
			}
			else
			{
				MessageBox.Show("유통사 품목 등록중 오류가 발생했습니다. 다시 시도해 주십시오.");
				return;
			}
		}

		private void btn_RegProduct_Click(object sender, EventArgs e) //물품 등록 버튼
		{
			Product_SearchAdd frm = new Product_SearchAdd();
			if(frm.ShowDialog()== DialogResult.OK)
            {
                List<SearchProductListVO> list = frm.Add_List;
				list.ForEach(p =>
				{
					CompanyDetailVO comDetail = new CompanyDetailVO
					{
						Company_ID = selectedCompanyInfo.Company_ID,
						Product_ID = p.Product_ID,
						Product_Name = p.Product_Name,
						Categories = p.Category_Name
					};

					CompanyService service = new CompanyService();
					bool bResult = service.InsertCompanyDetail(comDetail);
					service.Dispose();

					LoadCompanyDetailList(selectedCompanyInfo.Company_ID, dgv_CompanyDetail_Manage);
					LoadCompanyDetailList(selectedCompanyInfo.Company_ID, dgv_CompanyDetail);

				});
            }

		}

		private void btn_SaveOrderPrice_Click(object sender, EventArgs e) //가격 등록 버튼
		{
			CompanyDetailVO vo = new CompanyDetailVO
			{
				Company_ID = Convert.ToInt32(lbl_ComDetail_ID.Text),
				Product_ID = Convert.ToInt32(lbl_ComDetail_ProdID.Text),
				Order_Price = Convert.ToDecimal(txt_ComDetail_Price.Text)
			};
			CompanyService service = new CompanyService();
			if (vo.Company_ID.ToString().Length > 0 || vo.Product_ID.ToString().Length > 0 || vo.Order_Price.ToString().Length > 0)
			{
				bool bResult = service.UpdatePriceCompanyDetail(vo);
				service.Dispose();
				if (bResult)
				{
					MessageBox.Show("물품의 가격등록이 완료됐습니다.");
					LoadCompanyDetailList(vo.Company_ID, dgv_CompanyDetail);
					LoadCompanyDetailList(vo.Company_ID, dgv_CompanyDetail_Manage);
					txt_ComDetail_Price.Text = "가격입력/표시";
				}
				else
				{
					MessageBox.Show("물품의 가격등록중 오류가 발생했습니다. 다시 시도하여 주십시오");
					return;
				}
			}
			else
			{
				MessageBox.Show("가격을 등록할 물품을 선택하여 주십시오.");
				return;
			}
		}

		private void btn_DeleteComDetail_Click(object sender, EventArgs e) //물품 삭제 버튼
		{
			CompanyService service = new CompanyService();
			if (lbl_ComDetail_ID.Text.Length > 0 || lbl_ComDetail_ProdID.Text.Length > 0)
			{
				if (MessageBox.Show("정말로 삭제 하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					bool bResult = service.DeleteCompanyDetail(Convert.ToInt32(lbl_ComDetail_ID.Text), Convert.ToInt32(lbl_ComDetail_ProdID.Text));
					service.Dispose();
					if (bResult)
					{
						MessageBox.Show("물품의 삭제가 완료됐습니다.");
						LoadCompanyDetailList(Convert.ToInt32(lbl_ComDetail_ID.Text), dgv_CompanyDetail);
						LoadCompanyDetailList(Convert.ToInt32(lbl_ComDetail_ID.Text), dgv_CompanyDetail_Manage);
						txt_ComDetail_Price.Text = "가격입력/표시";
					}
					else
					{
						MessageBox.Show("물품의 가격등록중 오류가 발생했습니다. 다시 시도하여 주십시오");
						return;
					}
				}
			}
			else
			{
				MessageBox.Show("삭제할 물품을 선택하여 주십시오.");
				return;
			}
		}

		#endregion

		#region 셀 클릭 이벤트
		private void dgv_CompanyInfo_CellContentClick(object sender, DataGridViewCellEventArgs e) //셀을 눌렀을때 데이터 정보를 저장하기 위한 셀클릭 이벤트
		{
			if(e.RowIndex > -1)
            {
				selectedCompanyInfo = new CompanyVO
				{
					Company_ID = Convert.ToInt32(dgv_CompanyInfo[0, e.RowIndex].Value),
					Company_Name = dgv_CompanyInfo[1, e.RowIndex].Value.ToString(),
					Company_CEO = dgv_CompanyInfo[2, e.RowIndex].Value.ToString(),
					Company_Tel = dgv_CompanyInfo[3, e.RowIndex].Value.ToString(),
					Company_PostCode = (dgv_CompanyInfo[4, e.RowIndex].Value != null) ? Convert.ToInt32(dgv_CompanyInfo[4, e.RowIndex].Value) : 0,
					Company_Addr = (dgv_CompanyInfo[6, e.RowIndex].Value != null) ? dgv_CompanyInfo[6, e.RowIndex].Value.ToString() : "",
					Company_AddrDetail = (dgv_CompanyInfo[7, e.RowIndex].Value != null) ? dgv_CompanyInfo[7, e.RowIndex].Value.ToString() : ""
				};
			}
		}

		private void dgv_CompanyInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //dgv_CompanyInfo 항목 더블클릭
		{
			if (e.RowIndex > -1)
			{
				int companyID = Convert.ToInt32(dgv_CompanyInfo["Company_ID", e.RowIndex].Value); //선택한 주문ID 저장

				//더블클릭시 주문ID에 해당하는 유통사 상세 목록 dgv_CompanyDetail에 바인딩
				LoadCompanyDetailList(companyID, dgv_CompanyDetail);
				LoadCompanyDetailList(companyID, dgv_CompanyDetail_Manage);

				tab_CompanyManage.Enabled = true;
				tab_CompanyManage.SelectedTab = tabPage2;

			}
		}

		private void dgv_CompanyDetail_Manage_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //dgv_CompanyDetail_Manage 항목 더블클릭
		{
			if(e.RowIndex > -1)
			{
				lbl_ComDetail_ID.Text = dgv_CompanyDetail_Manage["Company_ID", e.RowIndex].Value.ToString();
				lbl_ComDetail_ProdID.Text = dgv_CompanyDetail_Manage["Product_ID", e.RowIndex].Value.ToString();
				txt_ComDetail_Price.Text = dgv_CompanyDetail_Manage["Order_Price", e.RowIndex].Value.ToString();
			}
		}

		#endregion

		#endregion

		#region 메서드

		/// <summary>
		/// 전체 유통사 목록 조회 메서드
		/// </summary>
		private void LoadAllCompanies()
		{
			CompanyService service = new CompanyService();
			allCompaniesList = service.GetAllCompanyList();
			service.Dispose();
			dgv_CompanyInfo.DataSource = allCompaniesList;
		}

		/// <summary>
		/// 유통사 상세 목록 조회 메서드
		/// </summary>
		/// <param name="companyID"> 유통사 ID </param>
		/// <param name="dgv"> 목록을 보여줄 dgv </param>
		private void LoadCompanyDetailList(int companyID, DataGridView dgv)
		{
			CompanyService service = new CompanyService();
			comDetailList = service.GetAllCompanyDetailList(companyID);
			service.Dispose();
			dgv.DataSource = comDetailList;
		}

        #endregion
    }
}
