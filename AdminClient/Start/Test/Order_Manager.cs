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
    public partial class OrderManager : Form
    {
        List<OrderComboBindingVO> cbx_List;
        List<OrderInfoVO> orderList;
        List<OrderDetailInfoVO> dList;
        bool updateInfo = false;
        List<int> delList = new List<int>();
        public OrderManager()
        {
            InitializeComponent();
        }

        #region Load
        private void OrderManager_Load(object sender, EventArgs e)
        {
            #region DataGridView 초기화
            CommonUtil.SetInitGridView(dgv_OrderInfo);
            CommonUtil.AddGridTextColumn(dgv_OrderInfo, "유통사명", "Company_Name");
            CommonUtil.AddGridTextColumn(dgv_OrderInfo, "발주일자", "Order_Date");
            CommonUtil.AddGridLinkColumn(dgv_OrderInfo, "상태", "Order_Check", textAlign:DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_OrderInfo, "ID", "Order_ID", visibility: false) ;

            CommonUtil.SetInitGridView(dgv_DetailInfo);
            CommonUtil.AddGridTextColumn(dgv_DetailInfo, "카테고리", "Category_Name");
            CommonUtil.AddGridTextColumn(dgv_DetailInfo, "물품명", "Product_Name");
            CommonUtil.AddGridTextColumn(dgv_DetailInfo, "갯수", "Count");
            CommonUtil.AddGridTextColumn(dgv_DetailInfo, "가격", "Price");
            CommonUtil.AddGridTextColumn(dgv_DetailInfo, "Product_ID", "Product_ID", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_DetailInfo, "Check", "Check", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_DetailInfo, "ID", "Order_ID", visibility: true);
            #endregion


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

            dtp_From.Value = DateTime.Now.AddYears(-100);
            dtp_To.Value = DateTime.Now.AddDays(1);
        }
        #endregion

        #region 검색그룹박스

        #region 검색 버튼 클릭 ( 조건 설정시 포함 )
        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_OrderInfo.DataSource = null;

            string limit = string.Empty;
            if (cbx_Limit.Checked)
                limit = nu_Limit.Value.ToString();

            string category, company;
            category = company = string.Empty;

            if (cbx_Category.Checked)
            {
                if (cbo_cateCate.SelectedIndex > 0)
                    category = cbo_cateCate.SelectedValue.ToString();
                if (cbo_cateComp.SelectedIndex > 0)
                    company = cbo_cateComp.SelectedValue.ToString();
            }
            else if (cbx_Company.Checked)
            {
                if (cbo_compCate.SelectedIndex > 0)
                    category = cbo_compCate.SelectedValue.ToString();
                if (cbo_compComp.SelectedIndex > 0)
                    company = cbo_compComp.SelectedValue.ToString();
            }

            DateTime from = dtp_From.Value;
            DateTime to = dtp_To.Value;

            Order_Service service = new Order_Service();
            orderList = service.GetOrderList(limit, category, company, from, to);

            OrderInfoBindingDataGridView(orderList);
        }

        private void OrderInfoBindingDataGridView(List<OrderInfoVO> list)
        {
            var odList = (from order in list
                          group order by new { order.Order_ID, order.Company_Name, order.Order_Date, order.Order_Check} into grp
                          select new
                          {
                              Order_ID = grp.Key.Order_ID,
                              Company_Name = grp.Key.Company_Name,
                              Order_Date = grp.Key.Order_Date,
                              Order_Check = grp.Key.Order_Check.Trim()
                          }).ToList();

            dgv_OrderInfo.DataSource = null;
            dgv_OrderInfo.DataSource = odList;
        }
        #endregion

        #region 최대검색
        private void cbx_Limit_CheckedChanged(object sender, EventArgs e)
        {
            nu_Limit.Enabled = cbx_Limit.Checked;
        }
        #endregion

        #region ComboBox 바인딩

        #region GroupBoxEnabled 설정
        private void cbx_Category_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_Category.Checked)
            {
                cbx_Company.Checked = false;
                gb_Category.Enabled = true;
            }else
            {
                gb_Category.Enabled = false;
            }
        }

        private void cbx_Company_CheckedChanged(object sender, EventArgs e)
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
        #endregion

        #region 설정값에 따라 바인딩

        #region 카테고리 기준으로 정리
        private void cbo_cateCate_SelectedIndexChanged(object sender, EventArgs e)
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

                CompList.Insert(0, new { ID = 0, Name = "전체"}) ;

                cbo_cateComp.DataSource = new BindingSource(CompList, null);
                cbo_cateComp.DisplayMember = "Name";
                cbo_cateComp.ValueMember = "ID";
            }
        }
        #endregion

        #region 거래처 기준으로 정리
        private void cbo_compComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_compComp.SelectedIndex < 1)
                cbo_compCate.DataSource = null;

            if(cbo_compComp.SelectedIndex > 0)
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

        #endregion

        #endregion

        #region DateTimePicker 유효성검사
        private void dtp_From_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_From.Value > dtp_To.Value)
                dtp_From.Value = dtp_To.Value.AddDays(-1);
        }

        private void dtp_To_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_To.Value < dtp_From.Value)
                dtp_To.Value = dtp_From.Value.AddDays(1);
        }


        #endregion

        #endregion

        #region CRUD

        #region 전부조회
        private void btn_GetAllOrder_Click(object sender, EventArgs e)
        {
            Order_Service service = new Order_Service();
            List<OrderInfoVO> list = service.GetOrderList(null, null, null, DateTime.Now.AddYears(-200), DateTime.Now.AddDays(1));
            //200년 전에 이런게 있진 않았겠지

            OrderInfoBindingDataGridView(list);
        }

        #endregion

        #region 발주추가
        private void btn_OrderAdd_Click(object sender, EventArgs e)
        {
            List<SearchProductListVO> addlist = null;
            Product_SearchAdd addfrm = new Product_SearchAdd();
            if (addfrm.ShowDialog() == DialogResult.OK)
                addlist = addfrm.Add_List;

            if (addlist != null)
            {
                var grpList = (from comp in addlist
                               group comp by comp.Company_ID into grp
                               select new { ID = grp.Key, grp }).ToList();

                List<int> compList = new List<int>();
                foreach (var item in grpList)
                {
                    if (!compList.Contains(item.ID))
                        compList.Add(item.ID);
                }

                Dictionary<int, int> dic_order = new Dictionary<int, int>();
                foreach (var comp in grpList)
                {
                    foreach (var prodid in comp.grp)
                    {
                        dic_order.Add(prodid.Product_ID, comp.ID);
                    }
                }

                Order_Service service = new Order_Service();
                bool result = service.Order(dic_order, compList);

                if (result)
                    MessageBox.Show("발주 목록에 추가되었습니다. 신청은 버튼을 클릭해주세요");
                else
                    MessageBox.Show("발주 목록에 추가중 오류가 발생했습니다.");
            }
        }
        #endregion

        #region 발주삭제
        private void btn_OrderDel_Click(object sender, EventArgs e)
        {
            dgv_DetailInfo.DataSource = null;

            if (dgv_OrderInfo.DataSource != null)
            {
                int rownum = dgv_OrderInfo.CurrentRow.Index;

                if (dgv_OrderInfo["Order_Check", rownum].Value.ToString() == "Y")
                {
                    MessageBox.Show("이미 발주신청 됐으니까 안댐!");
                    return;
                }

                if (MessageBox.Show("발주 목록을 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int orderID = Convert.ToInt32(dgv_OrderInfo["Order_ID", rownum].Value);

                    Order_Service service = new Order_Service();
                    bool result = service.DeleteOrder(orderID);

                    if (result)
                    {
                        MessageBox.Show("주문정보를 삭제했습니다.");

                        OrderInfoVO delInfo = null;

                        orderList.ForEach((info) =>
                        {
                            if (info.Order_ID == orderID)
                                delInfo = info;
                        });

                        orderList.Remove(delInfo);


                        OrderInfoBindingDataGridView(orderList);
                    }
                    else
                        MessageBox.Show("주문정보 삭제중 오류가 발생했습니다");
                }
            }
            else
            {
                MessageBox.Show("목록이 없습니다.");
            }
        }
        #endregion

        #region 발주수정
        private void btn_OrderUpdate_Click(object sender, EventArgs e)
        {
            if(updateInfo)
            {
                UpdateDetailCountInfo();
            }

            dgv_DetailInfo.DataSource = null;
        }
        #endregion

        #endregion

        #region DataGridView

        #region 상세내역보기
        private void dgv_OrderInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(updateInfo)
            {
                if (MessageBox.Show("변경 기록이 있습니다 변경하시겠습니까? 변경하지 않으시려면 취소를 눌러주세요", "경고", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    UpdateDetailCountInfo();
                }
                else
                    updateInfo = false;
            }

            if(e.RowIndex > -1)
            {
                int id = Convert.ToInt32(dgv_OrderInfo["Order_ID", e.RowIndex].Value);
                dgv_DetailInfo.Tag = dgv_OrderInfo["Order_Check", e.RowIndex].Value;

                dList = (from detail in orderList
                             where detail.Order_ID == id
                             select new OrderDetailInfoVO
                             {
                                 Category_Name = detail.Category_Name,
                                 Product_Name = detail.Product_Name,
                                 Count = detail.Order_Count,
                                 Price = (int)detail.Order_Price,
                                 Product_ID = detail.Product_ID,
                                 Check = detail.Order_Check, 
                                 Order_ID = detail.Order_ID
                             }).ToList();

                dgv_DetailInfo.DataSource = dList;
            }
        }
        #endregion

        #region 발주신청클릭
        private void dgv_OrderInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderID = Convert.ToInt32(dgv_OrderInfo["Order_ID", e.RowIndex].Value);
            if (e.ColumnIndex == 2)
            {
                bool zeroitem = false;
                foreach (var item in orderList)
                {
                    if(item.Order_ID == orderID)
                    {
                        if(item.Order_Count == 0)
                        {
                            zeroitem = true;
                        }
                    }
                }

                if(zeroitem)
                {
                    MessageBox.Show("갯수가 설정되지 않은 물품이 있습니다. 설정해주세요");
                    return;
                }
                    

                if(dgv_OrderInfo["Order_Check", e.RowIndex].Value.ToString().Trim() == "N")
                {
                    if (MessageBox.Show("발주를 신청하시겠습니까?", "확인 메세지", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Order_Service service = new Order_Service();
                        bool result = service.SetOrderCheck(orderID);

                        if (result)
                            MessageBox.Show("발주를 신청했습니다.");
                        else
                            MessageBox.Show("발주신청중 오류가 발생하였습니다.");

                        btn_Search.PerformClick();
                    }
                }
            }
        }
        #endregion

        #region 물품 정보보기
        private void dgv_DetailInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                bool nuState = (dgv_DetailInfo["Check", e.RowIndex].Value.ToString().Trim() == "Y");

                nu_OrderCount.Enabled = !nuState;
                nu_OrderCount.ReadOnly = nuState;

                pb_ProdImg.SizeMode = PictureBoxSizeMode.Zoom;

                int id = Convert.ToInt32(dgv_DetailInfo["Product_ID", e.RowIndex].Value);
                int oid = Convert.ToInt32(dgv_DetailInfo["Order_ID", e.RowIndex].Value);
                string check = dgv_DetailInfo["Check", e.RowIndex].Value.ToString();

                if (check == "Y")
                {
                    nu_OrderCount.Enabled = false;
                    nu_OrderCount.ReadOnly = true;
                }



                Order_Service service = new Order_Service();
                OrderItemInfoVO itemInfo = service.GetOrderItemInfo(id, oid);

                txt_ProdName.Text = itemInfo.Product_Name;
                txt_ProdName.Tag = id;
                txt_Category.Text = itemInfo.Category_Name;
                txt_Company.Text = itemInfo.Company_Name;
                nu_OrderCount.Value = itemInfo.Order_Count;
                nu_PsyCount.Value = itemInfo.Product_PsyCount;
                nu_LogCount.Value = itemInfo.Product_LogCount;
                pb_ProdImg.Image = CommonUtil.ByteToImage(itemInfo.Product_Img);
                lbl_valuez.Text = itemInfo.ValueNamez;
            }
        }

        #endregion

        #endregion

        #region DetailOrder
        private void btn_DetailAdd_Click(object sender, EventArgs e)
        {
            if(dgv_DetailInfo.DataSource != null)
            {
                if(dgv_DetailInfo.Tag.ToString() == "Y")
                {
                    MessageBox.Show("이미 발주신청이 완료된 정보입니다?");
                    return;
                }

                int oid = Convert.ToInt32(dgv_DetailInfo["Order_ID", 1].Value);
                List<SearchProductListVO> list = null;

                Product_SearchAdd frm = new Product_SearchAdd();

                if(frm.ShowDialog() == DialogResult.OK)
                    list = frm.Add_List;

                if(list != null)
                {
                    Order_Service service = new Order_Service();
                    bool result = service.DetailOrderAdd(oid, list);

                    if (!result)
                    {
                        MessageBox.Show("추가중 오류가 발생했습니다.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("추가되었습니다.");

                        List<SearchProductListVO> dlist = new List<SearchProductListVO>();

                        for(int i = 0; i<dgv_DetailInfo.Rows.Count; i++)
                        {
                            dlist.Add(new SearchProductListVO
                            {
                                Product_ID = Convert.ToInt32(dgv_DetailInfo["ProdID", i].Value), 
                                Product_Name = dgv_DetailInfo["ProdName", i].Value.ToString(), 
                                Add_Count = Convert.ToInt32(dgv_DetailInfo["Count", i].Value), 
                                Category_Name = dgv_DetailInfo["Category", i].Value.ToString(), 
                                Order_Price = Convert.ToInt32(dgv_DetailInfo["Price", i].Value)
                            });
                        }

                        for(int i = 0; i<list.Count; i++)
                        {
                            dlist.Add(list[i]);
                        }

                        dgv_DetailInfo.DataSource = null;
                        dgv_DetailInfo.DataSource = dlist;

                        for (int i = 0; i < dgv_DetailInfo.Rows.Count; i++)
                        {
                            dgv_DetailInfo["Order_ID", i].Value = oid;
                        }
                    }
                }
            }
        }

        private void btn_DetailUpdate_Click(object sender, EventArgs e)
        {
            if(dgv_DetailInfo.Tag.ToString() == "Y")
            {
                MessageBox.Show("이미 발주 신청되어서 변경할 수 없습니다.");
                return;
            }

            int prodID = Convert.ToInt32(txt_ProdName.Tag);

            dList.ForEach((info) =>
            {
                if (info.Product_ID == prodID)
                {
                    info.Count = (int)nu_OrderCount.Value;
                    updateInfo = true;
                }
            });

            dgv_DetailInfo.DataSource = null;
            dgv_DetailInfo.DataSource = dList;
        }

        private void UpdateDetailCountInfo()
        {
            Order_Service service = new Order_Service();
            bool result = service.UpdateDetailOrderInfo(dList, delList);

            if (result)
            {
                MessageBox.Show("정보가 수정됐습니다.");
                updateInfo = false;

                dList.ForEach((dinfo) => 
                {
                    orderList.ForEach((oinfo) =>
                    {
                        if (oinfo.Order_ID == dinfo.Order_ID)
                        {
                            if (oinfo.Product_ID == dinfo.Product_ID)
                                oinfo.Order_Count = dinfo.Count;
                        }
                    });
                });
            }
            else
            {
                MessageBox.Show("수정중 오류가 발생했습니다.");
            }
        }

        private void btn_DetailDelete_Click(object sender, EventArgs e)
        {
            int oid = 0;
            for(int i = 0; i<dList.Count; i++)
            {
                if(dList[i].Product_ID == Convert.ToInt32(txt_ProdName.Tag))
                {
                    oid = dList[i].Order_ID;
                    delList.Add(dList[i].Product_ID);
                    dList.RemoveAt(i);
                    updateInfo = true;
                    break;
                }
            }

            if(delList.Count > 0)
            {
                for(int i = 0; i<delList.Count; i++)
                {
                    for(int j = 0; j<orderList.Count; j++)
                    {
                        if(orderList[j].Product_ID == delList[i] && orderList[j].Order_ID == oid)
                        {
                            orderList.RemoveAt(j);
                            break;
                        }
                    }
                }
            }

            OrderInfoBindingDataGridView(orderList);
            dgv_DetailInfo.DataSource = null;
            dgv_DetailInfo.DataSource = dList;
        }


        #endregion

        
    }
}
