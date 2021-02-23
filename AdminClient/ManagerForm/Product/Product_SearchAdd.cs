using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AdminClient
{
    public partial class Product_SearchAdd : Form
    {
        List<OrderComboBindingVO> cbx_List;
        List<SearchProductListVO> prod_List;
        List<SearchProductListVO> add_List = new List<SearchProductListVO>();
        List<ComboBoxBindingVO> combList;

        public List<SearchProductListVO> Add_List { get { return add_List; } }

        public Product_SearchAdd()
        {
            InitializeComponent();
        }

        #region Load
        private void Product_SearchAdd_Load(object sender, EventArgs e)
        {
            gb_Category.Enabled = gb_Company.Enabled = false;

            #region DataGridView 설정
            CommonUtil.SetInitGridView(dgv_SearchList, false);
            CommonUtil.AddGridCheckColumn(dgv_SearchList, "", "s_ck", 20);
            CommonUtil.AddGridTextColumn(dgv_SearchList, "코드", "Product_ID", 70);
            CommonUtil.AddGridTextColumn(dgv_SearchList, "물품명", "Product_Name");
            CommonUtil.AddGridTextColumn(dgv_SearchList, "구분", "Division_Name");
            CommonUtil.AddGridTextColumn(dgv_SearchList, "카테고리", "Category_Name");
            CommonUtil.AddGridTextColumn(dgv_SearchList, "대표속성", "Product__Stand");
            CommonUtil.AddGridTextColumn(dgv_SearchList, "판매가", "Product_Price");
            CommonUtil.AddGridTextColumn(dgv_SearchList, "유통사", "Company_Name");
            CommonUtil.AddGridTextColumn(dgv_SearchList, "단가", "Order_Price");
            CommonUtil.AddGridTextColumn(dgv_SearchList, "최소갯수", "Product_Min");
            CommonUtil.AddGridTextColumn(dgv_SearchList, "재고", "Product_PsyCount");
            CommonUtil.AddGridTextColumn(dgv_SearchList, "예상재고", "Product_LogCount");
            

            CommonUtil.SetInitGridView(dgv_AddList, false);
            CommonUtil.AddGridCheckColumn(dgv_AddList, "", "a_ck", 20);
            CommonUtil.AddGridTextColumn(dgv_AddList, "물품명", "Product_Name");
            CommonUtil.AddGridTextColumn(dgv_AddList, "카테고리", "Category_Name");
            CommonUtil.AddGridTextColumn(dgv_AddList, "단가", "Order_Price");
            CommonUtil.AddGridTextColumn(dgv_AddList, "최대갯수", "Product_Max");
            CommonUtil.AddGridTextColumn(dgv_AddList, "Product_ID", "Product_ID", visibility: false);
            #endregion

            #region 콤보박스 바인딩(기존)
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

            #region 콤보박스 바인딩(테스트)
            ComboService test = new ComboService();
            combList = test.GetComboList();

            var divlist = (from div in combList
                           where div._Gubun == "div"
                           select new
                           {
                               ID = div._ID, 
                               Name = div._Name
                           }).ToList();

            divlist.Insert(0, new { ID = "div0", Name = "전체" });
            cbo_gubunT.DataSource = divlist;
            cbo_gubunT.DisplayMember = "Name";
            cbo_gubunT.ValueMember = "ID";

            var categories = (from cate in combList
                              where cate._Gubun == "category"
                              select new
                              {
                                  ID = cate._ID, 
                                  Name = cate._Name, 
                                  Pcode = cate._Pcode
                              }).ToList();

            categories.Insert(0, new { ID = "cate0", Name = "전체", Pcode = "div0"});
            cbo_cateT.DataSource = categories;
            cbo_cateT.DisplayMember = "Name";
            cbo_cateT.ValueMember = "ID";

            cbo_compT.Enabled = false;

            #endregion

            cbo_keyword.SelectedIndex = 0;
        }
        #endregion

        #region 검색조건
        private void cbx_Limit_CheckedChanged(object sender, EventArgs e) //최대검색조건 체크박스 
        {
            nu_Limit.Enabled = cbx_Limit.Checked;
        }

        private void cbx_Category_CheckedChanged(object sender, EventArgs e) // 카테고리 체크박스 
        {
            if(cbx_Category.Checked)
            {
                cbx_Company.Checked = cbx_ProdInfo.Checked = false;
                gb_Category.Enabled = true;
            }
            else
                gb_Category.Enabled = false;
        }

        private void cbx_Company_CheckedChanged(object sender, EventArgs e) // 유통사 체크박스 
        {
            if (cbx_Company.Checked)
            {
                cbx_Category.Checked = cbx_ProdInfo.Checked = false;
                gb_Company.Enabled = true;
            }
            else
                gb_Company.Enabled = false;
        }

        private void cbx_ProdInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_ProdInfo.Checked)
            {
                cbx_Category.Checked = cbx_Company.Checked = false;
                gb_ProdInfo.Enabled = true;
            }
            else
                gb_ProdInfo.Enabled = false;
        }

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

        private void btn_Search_Click(object sender, EventArgs e) // 검색버튼 
        {
            string categoryID, companyID, divID;
            categoryID = companyID = divID = string.Empty;

            int limit = 0;

            if (cbx_Limit.Checked)
                limit = (int)nu_Limit.Value;

            if(cbx_Category.Checked)
            {
                if(cbo_cateCate.SelectedIndex > 0)
                    categoryID = cbo_cateCate.SelectedValue.ToString();
                if(cbo_cateComp.SelectedIndex > 0)
                    companyID = cbo_cateComp.SelectedValue.ToString();
            }
            else if(cbx_Company.Checked)
            {
                if (cbo_compComp.SelectedIndex > 0)
                    companyID = cbo_compComp.SelectedValue.ToString();
                if (cbo_compCate.SelectedIndex > 0)
                    categoryID = cbo_compCate.SelectedValue.ToString();
            }
            else
            {
                if (cbo_gubunT.SelectedIndex > 0)
                    divID = cbo_gubunT.SelectedValue.ToString().Replace("div", "");
                if (cbo_cateT.SelectedIndex > 0)
                    categoryID = cbo_cateT.SelectedValue.ToString().Replace("cate", "");
                if (cbo_compT.SelectedIndex > 0)
                    companyID = cbo_compT.SelectedValue.ToString().Replace("comp", "");
            }


            Product_Service service = new Product_Service();
            prod_List = service.GetSearchProductList(categoryID, companyID, limit, divID);

            prod_List.ForEach((item) =>
            {
                item.Order_Price = (int)item.Order_Price;
                item.Product_Price = (int)item.Product_Price;
            });

            dgv_SearchList.DataSource = prod_List;


            #region 검색결과에 따른 세부검색의 콤보박스에 바인딩
            var categorylist = (from item in prod_List
                                group item by new { item.Category_ID, item.Category_Name } into categories
                                select new
                                {
                                    ID = categories.Key.Category_ID, 
                                    Name = categories.Key.Category_Name
                                }).ToList();

            categorylist.Insert(0, new{ ID=0, Name="전체"});

            cbo_detailCategory.DataSource = new BindingSource(categorylist, null);
            cbo_detailCategory.DisplayMember = "Name";
            cbo_detailCategory.ValueMember = "ID";

            var companylist = (from item in prod_List
                               group item by new { item.Company_ID, item.Company_Name } into companies
                               select new
                               {
                                   ID = companies.Key.Company_ID,
                                   Name = companies.Key.Company_Name
                               }).ToList();

            companylist.Insert(0, new { ID = 0, Name = "전체" });

            cbo_detailCompany.DataSource = new BindingSource(companylist, null);
            cbo_detailCompany.DisplayMember = "Name";
            cbo_detailCompany.ValueMember = "ID";

            var divList = (from item in prod_List
                           group item by new { item.Division_ID, item.Division_Name } into divs
                           select new
                           {
                               ID = divs.Key.Division_ID,
                               Name = divs.Key.Division_Name
                           }).ToList();

            divList.Insert(0, new { ID = 0, Name = "전체"});
            cbo_Divs.DataSource = new BindingSource(divList, null);
            cbo_Divs.DisplayMember = "Name";
            cbo_Divs.ValueMember = "ID";


            var stateList = (from item in prod_List
                             group item by new { item.Product_State, item.Common_Name } into states
                             select new
                             {
                                 ID = states.Key.Product_State,
                                 Name = states.Key.Common_Name
                             }).ToList();

            stateList.Insert(0, new { ID = "PS00", Name = "전체" });
            cbo_state.DataSource = new BindingSource(stateList, null);
            cbo_state.DisplayMember = "Name";
            cbo_state.ValueMember = "ID";

            #endregion

            gb_detail.Enabled = true;
        }
        #endregion

        #region 추가 삭제
        private void RefreshAddGridViewData()
        {
            dgv_AddList.DataSource = null;
            dgv_AddList.DataSource = add_List;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rw in dgv_SearchList.Rows)
            {
                if (Convert.ToBoolean(rw.Cells[0].Value))
                {
                    prod_List.ForEach((item) =>
                    {
                        if (item.Product_ID == Convert.ToInt32(rw.Cells["Product_ID"].Value))
                        {
                            bool alr = false;

                            add_List.ForEach((already) =>
                            {
                                if (already.Product_ID == item.Product_ID)
                                {
                                    already.Add_Count += 1;
                                    alr = true;
                                }
                            });

                            if (!alr)
                                add_List.Add(item);

                            rw.Cells[0].Value = false;
                        }
                    });
                }
            }
            RefreshAddGridViewData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            List<SearchProductListVO> buff = new List<SearchProductListVO>();

            foreach(DataGridViewRow rw in dgv_AddList.Rows)
            {
                if(!Convert.ToBoolean(rw.Cells[0].Value))
                {
                    add_List.ForEach((item) =>
                    {
                        if (item.Product_ID == Convert.ToInt32(rw.Cells["Product_ID"].Value))
                        {
                            buff.Add(item);
                        }
                    });
                }
                else
                {
                    add_List.ForEach((item) =>
                    {
                        if (item.Product_ID == Convert.ToInt32(rw.Cells["Product_ID"].Value))
                            item.Add_Count = 0;
                    });
                }
            }

            add_List.Clear();
            add_List = buff;

            RefreshAddGridViewData();
        }

        #endregion

        #region 세부조건

        #region 정렬
        private void DataGridViewSort(IOrderedEnumerable<SearchProductListVO> orderlist)
        {
            var list = orderlist.ToList();
            dgv_SearchList.DataSource = null;
            dgv_SearchList.DataSource = list;
        }

        private void btn_SortPrice_Click(object sender, EventArgs e) //가격정렬 
        {
            if (btn_SortPrice.Tag.ToString() == "sort")
            {
                DataGridViewSort(prod_List.OrderBy(item => item.Order_Price));
                btn_SortPrice.Tag = "desort";
            }
            else
            {
                DataGridViewSort(prod_List.OrderByDescending(item => item.Order_Price));
                btn_SortPrice.Tag = "sort";
            }
        }

        private void btn_sortProdID_Click(object sender, EventArgs e) //제품아이디정렬 
        {
            if (btn_sortProdID.Tag.ToString() == "sort")
            {
                DataGridViewSort(prod_List.OrderBy(item => item.Product_ID));
                btn_sortProdID.Tag = "desort";
            }
            else
            {
                DataGridViewSort(prod_List.OrderByDescending(item => item.Product_ID));
                btn_sortProdID.Tag = "sort";
            }
        }

        private void btn_sortCategory_Click(object sender, EventArgs e) //카테고리별 정렬 
        {
            if (btn_sortCategory.Tag.ToString() == "sort")
            {
                DataGridViewSort(prod_List.OrderBy(item => item.Category_ID));
                btn_sortCategory.Tag = "desort";
            }
            else
            {
                DataGridViewSort(prod_List.OrderByDescending(item => item.Category_ID));
                btn_sortCategory.Tag = "sort";
            }
        }

        private void btn_sortCompany_Click(object sender, EventArgs e) //유통사별 정렬 
        {
            if (btn_sortCompany.Tag.ToString() == "sort")
            {
                DataGridViewSort(prod_List.OrderBy(item => item.Company_ID));
                btn_sortCompany.Tag = "desort";
            }
            else
            {
                DataGridViewSort(prod_List.OrderByDescending(item => item.Company_ID));
                btn_sortCompany.Tag = "sort";
            }
        }
        #endregion


        private void btn_apply_Click(object sender, EventArgs e) //검색, 카테고리, 유통사 등 세부검색 
        {
            if(prod_List != null)
            {
                string keyword, category, company, div, state;
                keyword = category = company = div = state = string.Empty;

                if (cbo_detailCategory.SelectedIndex > 0)
                    category = cbo_detailCategory.SelectedValue.ToString();

                if (cbo_detailCompany.SelectedIndex > 0)
                    company = cbo_detailCompany.SelectedValue.ToString();

                if (cbo_state.SelectedIndex > 0)
                    state = cbo_state.SelectedValue.ToString();

                if (cbo_Divs.SelectedIndex > 0)
                    div = cbo_Divs.SelectedValue.ToString();

                if (cbo_keyword.SelectedItem.ToString() == "ID")
                {
                    var list = (from item in prod_List
                                where item.Category_ID == (string.IsNullOrEmpty(category) ? item.Category_ID : Convert.ToInt32(category)) &&
                                            item.Company_ID == (string.IsNullOrEmpty(company) ? item.Company_ID : Convert.ToInt32(company)) &&
                                            item.Division_ID == (string.IsNullOrEmpty(div)? item.Division_ID : Convert.ToInt32(div)) &&
                                            item.Product_State == (string.IsNullOrEmpty(state)? item.Product_State:state) &&
                                            item.Product_ID.ToString().Contains(txt_keyword.Text)
                                select item).ToList();
                    dgv_SearchList.DataSource = null;
                    dgv_SearchList.DataSource = list;
                }
                else
                {
                    var list = (from item in prod_List
                                where item.Category_ID == (string.IsNullOrEmpty(category) ? item.Category_ID : Convert.ToInt32(category)) &&
                                            item.Company_ID == (string.IsNullOrEmpty(company) ? item.Company_ID : Convert.ToInt32(company)) &&
                                            item.Division_ID == (string.IsNullOrEmpty(div) ? item.Division_ID : Convert.ToInt32(div)) &&
                                            item.Product_State == (string.IsNullOrEmpty(state) ? item.Product_State : state) &&
                                            item.Product_Name.Contains(txt_keyword.Text)
                                select item).ToList();
                    dgv_SearchList.DataSource = null;
                    dgv_SearchList.DataSource = list;
                }
            }
        }
        #endregion

        private void btn_Close_Click(object sender, EventArgs e) //닫기버튼 
        {
            this.Close();
        }

        private void btn_AddApply_Click(object sender, EventArgs e) //적용버튼 
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_MinDanger_Click(object sender, EventArgs e)
        {
            Product_Service service = new Product_Service();
            prod_List = service.GetSearchProductList(null, null, 0, null);

            var list = (from item in prod_List
                        where item.Product_Min > item.Product_LogCount && item.Product_Min > item.Product_PsyCount
                        select item).ToList();

            dgv_SearchList.DataSource = list;
        }


        #region 테스트
        private void cbo_gubunT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_gubunT.SelectedIndex > 0)
            {
                var categories = (from ca in combList
                                  where ca._Gubun == "category"
                                         && ca._Pcode.Contains(cbo_gubunT.SelectedValue.ToString())
                                  select new
                                  {
                                      ID = ca._ID, 
                                      Name = ca._Name, 
                                      Pcode = ca._Pcode
                                  }).ToList();

                categories.Insert(0, new { ID = "cate0", Name = "전체", Pcode = "div0" });
                cbo_cateT.DataSource = categories;
                cbo_cateT.DisplayMember = "Name";
                cbo_cateT.ValueMember = "ID";

            }
            else
            {
                var categories = (from cate in combList
                                  where cate._Gubun == "category"
                                  select new
                                  {
                                      ID = cate._ID,
                                      Name = cate._Name,
                                      Pcode = cate._Pcode
                                  }).ToList();

                categories.Insert(0, new { ID = "cate0", Name = "전체", Pcode = "div0" });
                cbo_cateT.DataSource = categories;
                cbo_cateT.DisplayMember = "Name";
                cbo_cateT.ValueMember = "ID";

            }
        }

        private void cbo_cateT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_cateT.SelectedIndex > 0)
            {
                var comp = (from cat in combList
                             from comps in combList
                             where cat._ID == comps._Pcode
                                    && comps._Pcode.Contains(cbo_cateT.SelectedValue.ToString())
                            group comps by new { comps._ID, comps._Name } into grp
                             select new
                             {
                                 ID = grp.Key._ID,
                                 Name = grp.Key._Name
                             }).ToList();

                comp.Insert(0, new { ID = "comp0", Name = "전체" });
                cbo_compT.DataSource = comp;
                cbo_compT.DisplayMember = "Name";
                cbo_compT.ValueMember = "ID";

                cbo_compT.Enabled = true;

            }
            else
            {
                cbo_compT.DataSource = null;
                cbo_compT.Enabled = false;
            }

        }

        #endregion

        
    }
}
