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

namespace AdminClient.Start
{
    public partial class whmanagertest : Form
    {
        List<OrderComboBindingVO> cbx_List;
        List<WareHousingInfoVO> getlist;
        List<WareDetailInfo> detailList;
        public whmanagertest()
        {
            InitializeComponent();
        }

        #region Load
        private void whmanagertest_Load(object sender, EventArgs e)
        {
            pb_ProdImg.SizeMode = PictureBoxSizeMode.StretchImage;

            rb_Product.Checked = true;

            gb_Category.Enabled = gb_Company.Enabled = false;

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
        }
        #endregion

        #region 검색조건
        private void cbx_Limit_CheckedChanged(object sender, EventArgs e) //검색갯수제한 
        {
            nu_Limit.Enabled = cbx_Limit.Checked;
        }

        private void cbx_selectDate_CheckedChanged(object sender, EventArgs e) // 날짜조건
        {
            dtp_From.Enabled = dtp_To.Enabled = cbx_selectDate.Checked;
        }

        private void cbx_Category_CheckedChanged(object sender, EventArgs e) //카테고리별 
        {
            if (cbx_Category.Checked)
            {
                cbx_Company.Checked = false;
                gb_Category.Enabled = true;
            }
            else
            {
                gb_Category.Enabled = false;
            }
        }

        private void cbx_Company_CheckedChanged(object sender, EventArgs e) //유통사별 
        {
            if (cbx_Company.Checked)
            {
                cbx_Category.Checked = false;
                gb_Company.Enabled = true;
            }
            else
            {
                gb_Company.Enabled = false;
            }
        }

        private void cbo_cateCate_SelectedIndexChanged(object sender, EventArgs e) //카테고리 선택에 따른 유통사목록 
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

        private void cbo_compComp_SelectedIndexChanged(object sender, EventArgs e) //유통사목록 선택에 따른 카테고리목록 
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

        private void btn_Search_Click(object sender, EventArgs e) //검색버튼 
        {
            string compID, cateID, limit;
            compID = cateID = limit = string.Empty;

            if (cbx_Limit.Checked)
                limit = nu_Limit.Value.ToString();

            if(cbx_Category.Checked)
            {
                if (cbo_cateCate.SelectedIndex > 0)
                    cateID = cbo_cateCate.SelectedValue.ToString();
                if (cbo_cateComp.SelectedIndex > 0)
                    compID = cbo_cateComp.SelectedValue.ToString();
            }
            else if(cbx_Company.Checked)
            {
                if (cbo_compComp.SelectedIndex > 0)
                    compID = cbo_compComp.SelectedValue.ToString();
                if (cbo_compCate.SelectedIndex > 0)
                    cateID = cbo_compCate.SelectedValue.ToString();
            }

            Order_Service service = new Order_Service();
            getlist = service.GetWareList(compID, cateID, limit);

            if(cbx_selectDate.Checked)
            {
                getlist = (from item in getlist
                           where Convert.ToDateTime(item.Order_Date).CompareTo(dtp_From.Value) > 0 &&
                                       Convert.ToDateTime(item.Order_Date).CompareTo(dtp_To.Value) < 0 &&
                                       item.Order_Check.Trim() == "Y"
                           select item).ToList();
            }
            
            if (rb_Product.Checked)
                rb_Product_CheckedChanged(null, null);
            else if (rb_Date.Checked)
                rb_Date_CheckedChanged(null, null);
        }

        private void rb_Product_CheckedChanged(object sender, EventArgs e) //물품별로 입고목록 보기 
        {
            if (rb_Product.Checked)
            {
                dgv_ResultInfo.DataSource = null;
                dgv_ProductList.Columns.Clear();
                dgv_ResultInfo.Columns.Clear();

                CommonUtil.SetInitGridView(dgv_ProductList);
                CommonUtil.AddGridTextColumn(dgv_ProductList, "코드", "Product_ID");
                CommonUtil.AddGridTextColumn(dgv_ProductList, "제품명", "Product_Name");
                CommonUtil.AddGridTextColumn(dgv_ProductList, "카테고리", "Category_Name");
                CommonUtil.AddGridTextColumn(dgv_ProductList, "유통사", "Company_Name");
                CommonUtil.AddGridTextColumn(dgv_ProductList, "최소", "Product_Min");
                CommonUtil.AddGridTextColumn(dgv_ProductList, "최대", "Product_Max");
                CommonUtil.AddGridTextColumn(dgv_ProductList, "물리", "Product_PsyCount");
                CommonUtil.AddGridTextColumn(dgv_ProductList, "논리", "Product_LogCount");

                CommonUtil.SetInitGridView(dgv_ResultInfo);
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "제품명", "Product_Name");
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "주문일자", "Order_Date");
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "주문수량", "Order_Count");
                CommonUtil.AddGridLinkColumn(dgv_ResultInfo, "입고상태", "Order_Result");
                CommonUtil.AddGridLinkColumn(dgv_ResultInfo, "Order_ID", "Order_ID", visibility: false);
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "Product_ID", "Product_ID", visibility: false);

                if (getlist != null)
                {
                    List<WareHousingInfoVO> wareList = (from item in getlist
                                                        group item by new
                                                        {
                                                            item.Product_ID,
                                                            item.Product_Name,
                                                            item.Category_Name,
                                                            item.Company_Name,
                                                            item.Product_Min,
                                                            item.Product_Max,
                                                            item.Product_PsyCount,
                                                            item.Product_LogCount
                                                        } into grp
                                                        select new WareHousingInfoVO
                                                        {
                                                            Product_ID = grp.Key.Product_ID,
                                                            Product_Name = grp.Key.Product_Name,
                                                            Category_Name = grp.Key.Category_Name,
                                                            Company_Name = grp.Key.Company_Name,
                                                            Product_Min = grp.Key.Product_Min,
                                                            Product_Max = grp.Key.Product_Max,
                                                            Product_PsyCount = grp.Key.Product_PsyCount,
                                                            Product_LogCount = grp.Key.Product_LogCount
                                                        }).ToList();

                    dgv_ProductList.DataSource = wareList;
                }
            }
        }

        private void rb_Date_CheckedChanged(object sender, EventArgs e) //발주건에 따라 보기(묶음으로보기) 
        {
            if (rb_Date.Checked)
            {
                dgv_ResultInfo.DataSource = null;
                dgv_ProductList.Columns.Clear();
                dgv_ResultInfo.Columns.Clear();

                CommonUtil.SetInitGridView(dgv_ProductList);
                CommonUtil.AddGridTextColumn(dgv_ProductList, "주문번호", "Order_ID");
                CommonUtil.AddGridTextColumn(dgv_ProductList, "주문일자", "Order_Date");
                CommonUtil.AddGridTextColumn(dgv_ProductList, "주문물품", "Order_ItemCount");
                CommonUtil.AddGridLinkColumn(dgv_ProductList, "입고상태", "Order_Result");

                CommonUtil.SetInitGridView(dgv_ResultInfo);
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "제품명", "Product_Name");
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "카테고리", "Category_Name");
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "유통사", "Company_Name");
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "주문수량", "Order_Count");
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "최소", "Product_Min");
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "최대", "Product_Max");
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "물리", "Product_PsyCount");
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "논리", "Product_LogCount");
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "Order_ID", "Order_ID", visibility: false);
                CommonUtil.AddGridTextColumn(dgv_ResultInfo, "Product_ID", "Product_ID", visibility: false);

                if (getlist != null)
                {
                    var wareList = (from item in getlist
                                    where item.Order_Check != null && item.Order_Check.Trim() == "Y"
                                    group item by new
                                    {
                                        item.Order_ID,
                                        item.Order_Date,
                                        item.Order_Result,
                                        item.Order_Check
                                    } into grp
                                    select new
                                    {
                                        Order_ID = grp.Key.Order_ID,
                                        Order_Date = grp.Key.Order_Date,
                                        Order_Result = grp.Key.Order_Result,
                                        Order_ItemCount = grp.Count(),
                                        Order_Check = grp.Key.Order_Check
                                    }).ToList();

                    dgv_ProductList.DataSource = wareList;
                }
            }
        }
        #endregion

        #region DataGridView
        private void dgv_ProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //DataGridView위에거 더블클릭(검색유형에 따라 내용 다르게) 
        {
            if(e.RowIndex > -1)
            {
                List<WareDetailInfo> dlist = new List<WareDetailInfo>();

                if (rb_Product.Checked)
                {
                    int pid = Convert.ToInt32(dgv_ProductList["Product_ID", e.RowIndex].Value);

                    for (int i = 0; i < getlist.Count; i++)
                    {
                        if (getlist[i].Product_ID == pid && getlist[i].Order_Date != null && getlist[i].Order_Check.Trim() == "Y")
                        {
                            dlist.Add(new WareDetailInfo
                            {
                                Order_ID = getlist[i].Order_ID, 
                                Product_ID = getlist[i].Product_ID, 
                                Product_Name = getlist[i].Product_Name,
                                Order_Date = getlist[i].Order_Date,
                                Order_Count = getlist[i].Order_Count,
                                Order_Result = getlist[i].Order_Result
                            });
                        }
                    }
                }
                else if(rb_Date.Checked)
                {
                    int oid = Convert.ToInt32(dgv_ProductList["Order_ID", e.RowIndex].Value);

                    for(int i = 0; i< getlist.Count; i++)
                    {
                        if(getlist[i].Order_ID == oid && getlist[i].Order_Check.Trim() == "Y")
                        {
                            dlist.Add(new WareDetailInfo 
                            {
                                Order_ID = getlist[i].Order_ID,
                                Product_ID = getlist[i].Product_ID, 
                                Product_Name = getlist[i].Product_Name, 
                                Category_Name = getlist[i].Category_Name, 
                                Company_Name = getlist[i].Company_Name, 
                                Order_Count = getlist[i].Order_Count, 
                                Product_Min = getlist[i].Product_Min, 
                                Product_Max = getlist[i].Product_Max, 
                                Product_PsyCount = getlist[i].Product_PsyCount, 
                                Product_LogCount = getlist[i].Product_LogCount
                            });

                        }
                    }
                }

                

                dgv_ResultInfo.DataSource = dlist;
            }
        }

        private void dgv_ResultInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //물품별로 검색했을시 물품정보표시 
        {
            if (e.RowIndex > -1)
            {
                int pid = Convert.ToInt32(dgv_ResultInfo["Product_ID", e.RowIndex].Value);
                int oid = Convert.ToInt32(dgv_ResultInfo["Order_ID", e.RowIndex].Value);

                Order_Service service = new Order_Service();
                OrderItemInfoVO itemInfo = service.GetOrderItemInfo(pid, oid);

                txt_ProdName.Text = itemInfo.Product_Name;
                txt_ProdName.Tag = pid;
                txt_Category.Text = itemInfo.Category_Name;
                txt_Company.Text = itemInfo.Company_Name;
                nu_OrderCount.Value = itemInfo.Order_Count;
                nu_PsyCount.Value = itemInfo.Product_PsyCount;
                nu_LogCount.Value = itemInfo.Product_LogCount;
                pb_ProdImg.Image = CommonUtil.ByteToImage(itemInfo.Product_Img);
                lbl_Valuez.Text = itemInfo.ValueNamez;
            }
        }

        private void dgv_ProductList_CellContentClick(object sender, DataGridViewCellEventArgs e) //묶음으로 봤을 때 그 발주건에 대한 모든 입고 Y 
        {
            if (rb_Date.Checked)
            {
                int oid = Convert.ToInt32(dgv_ProductList["Order_ID", e.RowIndex].Value);
                if (e.ColumnIndex == 3)
                {
                    if (dgv_ProductList["Order_Result", e.RowIndex].Value.ToString().Trim() == "N")
                    {
                        if (MessageBox.Show("입고를 확인하시겠습니까?", "입고확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Order_Service service = new Order_Service();
                            bool result = service.SetWareHousing(oid, 0);

                            if (result)
                                MessageBox.Show("입고가 확인되었습니다.");
                            else
                                MessageBox.Show("입고중 오류가 발생했습니다.");
                        }
                    }
                }
            }
        }

        private void dgv_ResultInfo_CellContentClick(object sender, DataGridViewCellEventArgs e) //단일품목으로 봤을 때 해당 발주건의 해당제품만 입고 Y 
        {
            if (rb_Product.Checked)
            {
                int oid = Convert.ToInt32(dgv_ResultInfo["Order_ID", e.RowIndex].Value);
                int pid = Convert.ToInt32(dgv_ResultInfo["Product_ID", e.RowIndex].Value);

                if (e.ColumnIndex == 3)
                {
                    if (dgv_ResultInfo["Order_Result", e.RowIndex].Value.ToString().Trim() == "N")
                    {
                        if (MessageBox.Show("입고를 확인하시겠습니까?", "입고확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Order_Service service = new Order_Service();
                            bool result = service.SetWareHousing(oid, pid);

                            if (result)
                                MessageBox.Show("입고가 확인되었습니다.");
                            else
                                MessageBox.Show("입고중 오류가 발생했습니다.");
                        }
                    }
                }
            }
        }

        #endregion

        #region 간편검색
        private void btn_NoResult_Click(object sender, EventArgs e) //입고되지않은 물품 목록 
        {
            rb_Date.Checked = true;

            Order_Service service = new Order_Service();
            getlist = service.GetWareList(null, null, null);

            var list = (from item in getlist
                            where item.Order_Check != null && item.Order_Check.Trim() == "Y"
                            group item by new
                            {
                                item.Order_ID,
                                item.Order_Date,
                                item.Order_Result,
                                item.Order_Check
                            } into grp
                            select new
                            {
                                Order_ID = grp.Key.Order_ID,
                                Order_Date = grp.Key.Order_Date,
                                Order_Result = grp.Key.Order_Result,
                                Order_ItemCount = grp.Count(),
                                Order_Check = grp.Key.Order_Check
                            }).ToList();

            dgv_ProductList.DataSource = list;
        }

        #endregion
    }
}
