using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient.Start
{
    public partial class SendProduct : Form
    {
        List<PurchaseVO> allList;
        List<PurchaseVO> pch_List;
        public SendProduct()
        {
            InitializeComponent();
        }
        private void SendProduct_Load(object sender, EventArgs e)
        {
            dtp_From.Value = DateTime.Now.AddDays(-1);
            btn_Send.Enabled = btn_SendAll.Enabled = false;

            CommonUtil.SetInitGridView(dgv_Purchase, false);
            CommonUtil.AddGridCheckColumn(dgv_Purchase, "", "", 30, textAlign:DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_Purchase, "Purchase_ID", "Purchase_ID", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Purchase, "구매자", "user_ID");
            CommonUtil.AddGridTextColumn(dgv_Purchase, "구매일자", "Purchase_Date");
            CommonUtil.AddGridTextColumn(dgv_Purchase, "총 물품 갯수", "Cnt", textAlign:DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_Purchase, "총 가격", "SumPrice", textAlign: DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_Purchase, "state", "Common_Code", visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Purchase, "배송상태", "Common_Name");
            CommonUtil.AddGridTextColumn(dgv_Purchase, "핸드폰", "user_Phone");
            CommonUtil.AddGridTextColumn(dgv_Purchase, "이메일", "user_Email", 200);

            //productid, productname, categoryid, categoryname, product__stand, count, price
            CommonUtil.SetInitGridView(dgv_ProductList);
            CommonUtil.AddGridTextColumn(dgv_ProductList, "물품번호", "Product_ID");
            CommonUtil.AddGridTextColumn(dgv_ProductList, "물품명", "Product_Name", 300);
            CommonUtil.AddGridTextColumn(dgv_ProductList, "Category_ID", "Category_ID", visibility:false);
            CommonUtil.AddGridTextColumn(dgv_ProductList, "카테고리", "Category_Name", 150);
            CommonUtil.AddGridTextColumn(dgv_ProductList, "요약정보", "Product__Stand", 200);
            CommonUtil.AddGridTextColumn(dgv_ProductList, "주문갯수", "Purchase_Count");
            CommonUtil.AddGridTextColumn(dgv_ProductList, "단일가격", "Products_Price");

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string limit = string.Empty;
            string from = string.Empty;
            string to = string.Empty;

            if (cbx_Limit.Checked)
                limit = nu_Limit.Value.ToString();

            if (cbx_SetDate.Checked)
            {
                from = dtp_From.Value.ToString("yyyy-MM-dd");
                to = dtp_To.Value.ToString("yyyy-MM-dd");
            }

            Purchase_Service service = new Purchase_Service();
            allList = service.GetAllPurchaseList(limit, from, to);

            SetDataGridView();

            btn_SendAll.Enabled = true;
        }

        private void SetDataGridView()
        {
            dgv_Purchase.DataSource = null;

            pch_List = (from pinfo in allList
                            group pinfo by new { pinfo.Purchase_ID, pinfo.user_ID, pinfo.Purchase_Date, pinfo.Common_Code, pinfo.Common_Name, pinfo.user_Email, pinfo.user_Phone } into grp
                            select new PurchaseVO
                            {
                                Purchase_ID = grp.Key.Purchase_ID,
                                user_ID = grp.Key.user_ID,
                                Purchase_Date = grp.Key.Purchase_Date,
                                Common_Code = grp.Key.Common_Code,
                                Common_Name = grp.Key.Common_Name,
                                Cnt = grp.Count(),
                                user_Email = grp.Key.user_Email,
                                user_Phone = grp.Key.user_Phone,
                                SumPrice = grp.Sum(x => (int)x.Products_Price * x.Purchase_Count)
                            }).ToList();

            if (cbx_SetDate.Checked)
            {
                allList = (from pinfo in allList
                           where Convert.ToDateTime(pinfo.Purchase_Date) >= dtp_From.Value &&
                                        Convert.ToDateTime(pinfo.Purchase_Date) <= dtp_To.Value
                           select pinfo).ToList();
            }

            dgv_Purchase.DataSource = pch_List;
        }

        private void cbx_Limit_CheckedChanged(object sender, EventArgs e)
        {
            nu_Limit.Enabled = cbx_Limit.Checked;
        }

        private void cbx_SetDate_CheckedChanged(object sender, EventArgs e)
        {
            dtp_From.Enabled = dtp_To.Enabled = cbx_SetDate.Checked;
        }

        private void dgv_Purchase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pchID = Convert.ToInt32(dgv_Purchase["Purchase_ID", e.RowIndex].Value);

            List<PurchaseVO> prodList = (from item in allList
                                         where item.Purchase_ID == pchID
                                         select item).ToList();

            dgv_ProductList.DataSource = prodList;

            prodList.ForEach(x =>
            {
                if (x.Purchase_ID == pchID)
                {
                    lbl_pID.Text = $"{x.Purchase_ID}번 주문정보";
                    lbl_pID.Tag = x.Purchase_ID;
                    txt_infoID.Text = x.user_ID;
                    txt_infoTel.Text = x.user_Phone;
                    txt_infoEmail.Text = x.user_Email;
                    txt_infoReceiver.Text = x.Addr_Receiver;
                    txt_infoPostcode.Text = x.Addr_PostCode.ToString();
                    txt_infoAddr.Text = x.Addr;
                    txt_infoDetailAddr.Text = x.Addr_Detail;

                    if (x.Common_Code.Trim() == "SS01")
                        btn_Send.Enabled = true;
                    else
                        btn_Send.Enabled = false;

                }
            });
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            int pID = Convert.ToInt32(lbl_pID.Tag);
            List<int> pList = new List<int>();
            pList.Add(pID);

            Purchase_Service service = new Purchase_Service();
            bool result = service.SendPurchase(pList);

            if(result)
            {
                allList.ForEach(item =>
                {
                    if(item.Purchase_ID == pID)
                    {
                        item.Common_Code = "SS02";
                        item.Common_Name = "상품배송전";
                    }
                });

                SetDataGridView();

                MessageBox.Show("배송 상태를 변경하였습니다.");
            }
            else
                MessageBox.Show("배송처리중 오류가 발생했습니다");

        }

        private void btn_SendAll_Click(object sender, EventArgs e)
        {
            List<int> pIDs = new List<int>();

            foreach(DataGridViewRow dr in dgv_Purchase.Rows)
            {
                DataGridViewCheckBoxCell dgvc = dr.Cells[0] as DataGridViewCheckBoxCell;
                
                if(Convert.ToBoolean(dgvc.Value))
                {
                    if (dr.Cells["Common_Code"].Value.ToString().Trim() != "SS01")
                    {
                        MessageBox.Show("이미 배송이 완료된 주문건이 있습니다");
                        return;
                    }

                    pIDs.Add(Convert.ToInt32(dr.Cells["Purchase_ID"].Value));
                }
            }

            Purchase_Service service = new Purchase_Service();
            bool result = service.SendPurchase(pIDs);

            if (result)
            {
                foreach (int id in pIDs)
                {
                    allList.ForEach(item =>
                    {
                        if (id == item.Purchase_ID)
                        {
                            item.Common_Code = "SS02";
                            item.Common_Name = "상품배송전";
                        }
                    });

                    SetDataGridView();
                }
                MessageBox.Show("배송 상태를 변경하였습니다.");
            }
            else
                MessageBox.Show("배송처리중 오류가 발생했습니다.");

        }

        private void btn_Sorts(object sender, EventArgs e)
        {
            string[] sortinfo = ((Control)sender).Tag.ToString().Split('|');

            Type type = typeof(PurchaseVO);
            PropertyInfo pinfo = type.GetProperty($"{sortinfo[1]}");

            dgv_Purchase.DataSource = null;

            if(Convert.ToBoolean(sortinfo[0]))
            {
                dgv_Purchase.DataSource = pch_List.OrderBy(info => pinfo.GetValue(info, null)).ThenBy(info => info.Purchase_ID).ToList();
                sortinfo[0] = "false";
            }
            else
            {
                dgv_Purchase.DataSource = pch_List.OrderByDescending(info => pinfo.GetValue(info, null)).ThenByDescending(info => info.Purchase_ID).ToList();
                sortinfo[0] = "true";
            }

            string sorts = sortinfo[0] + "|" + sortinfo[1];
            ((Control)sender).Tag = sorts;

        }

        private void btn_Today_Click(object sender, EventArgs e)
        {
            Purchase_Service service = new Purchase_Service();
            allList = service.GetAllPurchaseList(null, null, null);

            allList = (from info in allList
                       where info.Purchase_Date.Trim() == DateTime.Now.ToString("yyyy-MM-dd")
                       select info).ToList();

            SetDataGridView();
        }

        private void btn_NoSend_Click(object sender, EventArgs e)
        {
            Purchase_Service service = new Purchase_Service();
            allList = service.GetAllPurchaseList(null, null, null);

            allList = (from info in allList
                       where info.Common_Code.Trim() == "SS01"
                       select info).ToList();

            SetDataGridView();
        }
    }
}
