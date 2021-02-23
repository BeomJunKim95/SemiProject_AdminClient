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

namespace AdminClient
{
    public partial class BOMSet : Form
    {
        public enum Selected { BOM, Forward, Reverse }
        Selected selected;
        public ProductinfoVO selectProduct { get; set; }
        List<BOMSelectVO> AllList;
        public BOMSet()
        {
            InitializeComponent();
        }

        public BOMSet(Selected selected, ProductinfoVO vo) : this()
        {
            this.selected = selected;
            BOMService service = new BOMService();
            selectProduct = vo;
            service.IsBOMChild(vo.Product_ID);
            lbl_ProductName.Text = vo.Product_Name;
            if (selected != Selected.Reverse)
            {
                AllList = service.BOM_Child(vo.Product_ID);
            }
            else
            {
                CommonUtil.SetInitGridView(dgv_BOMList, false);
                CommonUtil.AddGridTextColumn(dgv_BOMList, "상품명", "Product_Name", 500);
                CommonUtil.AddGridTextColumn(dgv_BOMList, "가격", "Product_Price", 150);
                var list = service.BOMReverse(vo.Product_ID);
                dgv_BOMList.DataSource = list;
            }

            if(selected != Selected.BOM)
            {
                CommonUtil.ControlAction<Form, Button>(this, (item) =>
                {
                    if(item.Name != "ben_Close")
                    item.Enabled = false;
                });
            }
        }

        private void BOMSet_Load(object sender, EventArgs e)
        {
            if (selected != Selected.Reverse)
            {
                CommonUtil.SetInitGridView(dgv_BOMList, false);
                dgv_BOMList.SelectionMode = DataGridViewSelectionMode.CellSelect;
                CommonUtil.AddGridLinkColumn(dgv_BOMList, "전개", "전개");
                CommonUtil.AddGridTextColumn(dgv_BOMList, "트리", "INFO", 250);
                CommonUtil.AddGridTextColumn(dgv_BOMList, "상품명", "Product_Name", 150);
                CommonUtil.AddGridTextColumn(dgv_BOMList, "번호", "BOM_Child");
                CommonUtil.AddGridTextColumn(dgv_BOMList, "부모번호", "BOM_Parents");
                CommonUtil.AddGridTextColumn(dgv_BOMList, "숫자", "BOM_Count");
                CommonUtil.AddGridTextColumn(dgv_BOMList, "level", "level", visibility: false);
                CommonUtil.AddGridTextColumn(dgv_BOMList, "정렬", "sortOrder", visibility: false);

                dgv_BOMList.DataSource = AllList;
            }
        }

        private void dgv_BOMList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (selected != Selected.Reverse)
            {
                List<BOMSelectVO> list = (List<BOMSelectVO>)dgv_BOMList.DataSource;
                foreach (DataGridViewRow row in dgv_BOMList.Rows)
                {
                    var ProductID = row.Cells["BOM_Child"].Value.ToString();
                    //현재 list에 자식인 것이 있으면
                    int count = list.Where(item => item.BOM_Parents == Convert.ToInt32(row.Cells["BOM_Child"].Value)).Count();
                    if (count > 0)
                    {
                        row.Cells["전개"].Value = "접기";
                        continue;
                    }
                    foreach (var item in AllList)
                    {
                        var Orders = item.sortOrder.Split('>');
                        var Last = Orders.Last();
                        if (Orders.Contains(ProductID) && Last != ProductID)
                        {
                            row.Cells["전개"].Value = "펼치기";
                            continue;
                        }
                    }

                }
            }
        }

        private void dgv_BOMList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selected != Selected.Reverse)
            {
                if (dgv_BOMList[e.ColumnIndex, e.RowIndex].Value.ToString() == "접기")
                {
                    int ProducetID = Convert.ToInt32(dgv_BOMList["BOM_Child", e.RowIndex].Value);
                    List<BOMSelectVO> list = (List<BOMSelectVO>)dgv_BOMList.DataSource;
                    dgv_BOMList.DataSource = list.Where(item =>
                    {
                        var Orders = item.sortOrder.Split('>');
                        var Last = Orders.Last();
                        if (Orders.Contains(ProducetID.ToString()) && Last != ProducetID.ToString())
                        {
                            return false;
                        }
                        return true;
                    }).ToList();
                    dgv_BOMList.RefreshGridView();
                }
                else if (dgv_BOMList[e.ColumnIndex, e.RowIndex].Value.ToString() == "펼치기")
                {
                    int ProducetID = Convert.ToInt32(dgv_BOMList["BOM_Child", e.RowIndex].Value);
                    List<BOMSelectVO> list = (List<BOMSelectVO>)dgv_BOMList.DataSource;
                    var AddList = AllList.Where(item =>
                    {
                        var Orders = item.sortOrder.Split('>');
                        var Last = Orders.Last();
                        if (Orders.Contains(ProducetID.ToString()) && Last != ProducetID.ToString())
                        {
                            return true;
                        }
                        return false;
                    }).ToList();

                    AddList.ForEach(item =>
                    {
                        list.Add(item);
                    });

                    dgv_BOMList.DataSource = list.OrderBy(item => item.sortOrder).ToList();
                    dgv_BOMList.RefreshGridView();
                }
            }
        }

        private void btn_sherch_Click(object sender, EventArgs e)
        {
            Product_SearchAdd product_Search = new Product_SearchAdd();
            if (product_Search.ShowDialog() == DialogResult.OK)
            {
                BOMService service = new BOMService();
                var AllBomList = service.BOMAllList();

                //조건에 맞는 id를 찾음(무한루프에 빠지지 않으며, 이미 추가 되지 않았으며 )
                var va = product_Search.Add_List.Where((add) =>
                {
                    if (add.Product_ID == selectProduct.Product_ID) //해당 품목이 자신인지 확인
                    {
                        return false;
                    }
                    foreach(var item in AllBomList) //해당 품목의 부모가 자신인지를 확인
                    {
                        if (item.BOM_Child == selectProduct.Product_ID && item.BOM_Parents == add.Product_ID)
                        {
                            return false;
                        }
                    };
                    foreach(var item in AllList) //해당 품목이 이미 추가되었는지 확인
                    {
                       var list  = item.sortOrder.Split('>');
                       foreach(var ID in list)
                       {
                            if(ID == add.Product_ID.ToString())
                            {
                               return false;
                            }
                       }
                    }
                    return true;
                }).ToList();

                var AddList = (from item in va //해당 id값만 가져옴
                              select item.Product_ID).ToList();
                
                if(service.SP_InsertBOM(selectProduct.Product_ID, AddList))
                {
                    dgv_BOMList.DataSource = service.BOM_Child(selectProduct.Product_ID);
                }
            }
        }

        private void dgv_BOMList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selected != Selected.Reverse)
            {
                var list = dgv_BOMList["sortOrder", e.RowIndex].Value.ToString().Split('>');
                if (list.Length <= 1 || list[list.Length - 2] != selectProduct.Product_ID.ToString())
                {
                    return;
                }

                txt_ProductID.Text = dgv_BOMList["BOM_Child", e.RowIndex].Value.ToString();
                txtProductName.Text = dgv_BOMList["Product_Name", e.RowIndex].Value.ToString();
            }
        }

        private void btnCountUpdate_Click(object sender, EventArgs e)
        {
            int BOM_Child = Convert.ToInt32(txt_ProductID.Text);
            int BOM_Parents = selectProduct.Product_ID;
            int Count = Convert.ToInt32(numericUpDown1.Value);

            BOMService service = new BOMService();
            if(service.BOMUpdate(BOM_Child, BOM_Parents, Count))
            {
                dgv_BOMList.DataSource = service.BOM_Child(selectProduct.Product_ID);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int BOM_Child = Convert.ToInt32(txt_ProductID.Text);
            int BOM_Parents = selectProduct.Product_ID;

            BOMService service = new BOMService();
            if (service.BOMdelete(BOM_Child, BOM_Parents))
            {
                dgv_BOMList.DataSource = service.BOM_Child(selectProduct.Product_ID);
            }
        }

        private void ben_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}