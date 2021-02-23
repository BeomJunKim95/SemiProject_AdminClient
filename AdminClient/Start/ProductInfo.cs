using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminClientDAC;
using AdminClientVO;
using AdminClient;
using System.Reflection;

namespace AdminClient.Start
{
    public partial class ProductInfo : Form
    {
        List<DivitionVO> divitionVOs;
        List<CategoriesVO> categoriesVOs;
        List<ProductinfoVO> productinfoVOs;     //첫 검색
        List<ProductinfoVO> SelectedProductvo;  //세부 검색
        List<IGrouping<int, ValuezConnProductVO>> connProductVOs;    //첫 검색의 Prop항목들
        List<CommonVO> commonVOs;


        class BaindingKey
        {
            public string Display { get; set; }
            public string Value { get; set; }

            public BaindingKey()
            {

            }

            public BaindingKey(string display, string value)
            {
                Display = display;
                Value = value;
            }
        }
        class Selectitem
        {
            public string Display { get; set; }
            public int Value { get; set; }

            public Selectitem()
            {

            }

            public Selectitem(string display, int value)
            {
                Display = display;
                Value = value;
            }
        }

        public ProductInfo()
        {
            InitializeComponent();
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            DataGridVewSet();
            ServiceAndDataSource();
            ControlsDataAndMember();
            CustomList();

            //물품 속성 값에 따른 데이터 선택
            productFeature.ChangedCombox += (send, evnet) =>
            {

                if (SelectedProductvo == null)  // 선택한 것이 없으면
                    return;
                var list = SelectedProductvo.ToList(); //현재 바인딩된 DataSource

                var ValuezIDs = CommonUtil.ControlFunc<Panel, int, ComboBox>(productFeature.PnlFeatures, (item) =>
                {
                    return (int)item.SelectedValue;
                });//선택한 Valuez

                var SelectProp = connProductVOs.Where((item) =>
                {
                    foreach (ProductinfoVO vo in list)
                    {
                        if (vo.Product_ID == item.Key)
                        {
                            return true;
                        }
                    }
                    return false;
                }).ToList();    // 검색한 list중에서 prop 검색

                var products = SelectProp.Where((item) =>
                {
                    bool result = true;
                    List<int> IDS = new List<int>();
                    foreach (var value in item)
                    {
                        IDS.Add(value.Value_ID);
                    }
                    foreach (int id in ValuezIDs)
                    {
                        if (id > 0) //id가 0보다 큰것만
                        {
                            if (!IDS.Contains(id))
                            {
                                result = false;
                            }
                        }

                    }
                    return result;
                }).ToList(); //해당 prop중에 value값이 있는 애들만

                var productID = (from item in products
                                 select item.Key).ToList(); //선택된 ID값들만 가져옴

                dgv_Products.DataSource = list.Where((item) =>
                {
                    foreach (int key in productID)
                    {
                        if (key == item.Product_ID)
                            return true;
                    }
                    return false;
                }).ToList(); //ID값에 따른 바인딩
            };
        }

        #region private 매서드
        private bool Stringcompare(string value, string search)//string 과 선택에 따른 value 바인딩
        {
            switch (cbo_keyword.SelectedValue)
            {
                case 1:
                    return value.Equals(search);
                case 2:
                    return search == value.Right(search.Length);
                case 3:
                    return search == value.Left(search.Length);
                case 4:
                    return value.Contains(search);
                default:
                    return false;
            }
        }

        private void CustomList()
        {
            List<BaindingKey> items = new List<BaindingKey>();
            items.Add(new BaindingKey("", ""));
            foreach (DataGridViewColumn dc in dgv_Products.Columns)
            {
                items.Add(new BaindingKey(dc.HeaderText, dc.DataPropertyName));
            }
            cbo_Key.DisplayMember = "Display";
            cbo_Key.ValueMember = "Value";
            cbo_Key.DataSource = items.ToList();
            cbo_Sortkey.DisplayMember = "Display";
            cbo_Sortkey.ValueMember = "Value";
            cbo_Sortkey.DataSource = items.ToList();

            List<Selectitem> select = new List<Selectitem>()
            { new Selectitem("선택" ,0), new Selectitem("Text" ,1), new Selectitem("%Text" ,2), new Selectitem("Text%" ,3), new Selectitem("%Text%" ,4) };
            cbo_keyword.DisplayMember = "Display";
            cbo_keyword.ValueMember = "Value";
            cbo_keyword.DataSource = select;



            cbo_detailCategory.ValueMember = "Category_ID";
            cbo_detailCategory.DisplayMember = "Category_Name";
            var list = (categoriesVOs.ToList());
            list.Insert(0, new CategoriesVO { Category_ID = 0, Category_Name = "선택" });
            cbo_detailCategory.DataSource = list;
        }

        private void DataGridVewSet()
        {
            CommonUtil.SetInitGridView(dgv_Products, false);
            dgv_Products.SelectionMode = DataGridViewSelectionMode.CellSelect;
            CommonUtil.AddGridTextColumn(dgv_Products, "ID", "Product_ID", 80);
            CommonUtil.AddGridTextColumn(dgv_Products, "이름", "Product_Name", 200);
            CommonUtil.AddGridTextColumn(dgv_Products, "가격", "Product_Price", 100);
            CommonUtil.AddGridTextColumn(dgv_Products, "최소갯수", "Product_Min", 80);
            CommonUtil.AddGridTextColumn(dgv_Products, "최대갯수", "Product_Max", 80);
            CommonUtil.AddGridTextColumn(dgv_Products, "물리재고량", "Product_PsyCount", 90);
            CommonUtil.AddGridTextColumn(dgv_Products, "논리재고량", "Product_LogCount", 90);
            CommonUtil.AddGridTextColumn(dgv_Products, "물품상태", "Product_State", 80);
            CommonUtil.AddGridTextColumn(dgv_Products, "카테고리", "Category_Name");
            CommonUtil.AddGridTextColumn(dgv_Products, "규격", "Product__Stand");
            CommonUtil.AddGridButtonColumn(dgv_Products, "BOM 등록", "BOM", textAlign: DataGridViewContentAlignment.MiddleCenter); 
            CommonUtil.AddGridButtonColumn(dgv_Products, "정전개", "정전개", textAlign: DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridButtonColumn(dgv_Products, "역전개", "역전개", textAlign: DataGridViewContentAlignment.MiddleCenter);
        }
        #endregion

        #region event

        #region 컨트롤 데이터 바인딩 및 맴버 설정
        private void ControlsDataAndMember()
        {
            cbo_Common.ValueMember = "Common_Code";
            cbo_Common.DisplayMember = "Common_Name";
            cbo_Catagory.ValueMember = "Category_ID";
            cbo_Catagory.DisplayMember = "Category_Name";
            cbo_Divition.ValueMember = "Division_ID";
            cbo_Divition.DisplayMember = "Division_Name";
            cbo_CDivition.ValueMember = "Division_ID";
            cbo_CDivition.DisplayMember = "Division_Name";
            cbo_cateCate.ValueMember = "Category_ID";
            cbo_cateCate.DisplayMember = "Category_Name";

            cbo_Divition.DataSource = divitionVOs.ToList();
            cbo_CDivition.DataSource = divitionVOs.ToList();
        }
        #endregion

        #region 서비스 및 데이터소스 
        private void ServiceAndDataSource()
        {
            DivitionService divitionService = new DivitionService();
            Categories_Service categories_Service = new Categories_Service();
            Common_Service common_Service = new Common_Service();
            commonVOs = common_Service.SelctCommonForPcode("PS00");
            cbo_Common.DataSource = commonVOs.ToList();
            divitionVOs = divitionService.GetAllDivition();
            categoriesVOs = categories_Service.GetAllCategries();
            divitionVOs.Insert(0, new DivitionVO
            {
                Division_ID = 0,
                Division_Name = "선택"
            });
        }
        #endregion


        #region 콤보박스 박스 

        #region 구분 콤보박스 체크
        private void cbo_Divition_SelectedIndexChanged(object sender, EventArgs e)
        {
            int DivitionID = Convert.ToInt32(cbo_Divition.SelectedValue);
            var list = (from item in categoriesVOs
                        where item.Division_ID == DivitionID
                        select item).ToList();

            list.Insert(0, new CategoriesVO
            {
                Category_ID = 0,
                Division_ID = 0,
                Category_Name = ""
            });

            cbo_Catagory.DataSource = list;
        }
        #endregion

        #region 카테고리 콤보박스 
        private void cbo_Catagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CatagoryID = Convert.ToInt32(cbo_Catagory.SelectedValue);

            productFeature.BaindingCombox(CatagoryID);
        }
        #endregion

        #region 카테고리 선택의 구분 콤보박스
        private void cbo_CDivition_SelectedIndexChanged(object sender, EventArgs e)
        {
            int divitionID = (int)cbo_CDivition.SelectedValue;
            var list = (from item in categoriesVOs
                        where item.Division_ID == divitionID
                        select item).ToList();
            cbo_cateCate.DataSource = list;

        }
        #endregion

        #endregion

        #region 체크박스 카테고리 

        #region 카테고리 선택 체크박스
        private void cbx_Category_CheckedChanged(object sender, EventArgs e)
        {
            bool check = cbx_Category.Checked;
            gb_Category.Enabled = check;
            CommonUtil.ControlAction<GroupBox, ComboBox>(gb_Category, (item) =>
            {
                item.Text = "";
            });

        }
        #endregion

        #region 물품 갯수
        private void cbx_ProductCount_CheckedChanged(object sender, EventArgs e)
        {
            bool check = cbx_ProductCount.Checked;
            gb_ProductCount.Enabled = check;
        }
        #endregion

        #region 리미트 체크박스
        private void cbx_Limit_CheckedChanged(object sender, EventArgs e)
        {
            bool check = cbx_Limit.Checked;
            nu_Limit.Enabled = check;
        }
        #endregion

        #endregion

        #region 버튼 이벤트

        #region 검색버튼
        private void btn_Search_Click(object sender, EventArgs e)
        {
            int CatagrisID = 0, LimitCount = 0;
            string Productsql = string.Empty;
            string ProductStat = cbo_Common.SelectedValue.ToString().Trim();
            if (cbx_Category.Checked)       //카테고리를 선택했다면
            {
                if (cbo_cateCate.SelectedIndex > -1)
                    CatagrisID = (int)cbo_cateCate.SelectedValue;
            }
            if (cbx_Limit.Checked)  //갯수제한을 선택했다면
            {
                LimitCount = Convert.ToInt32(nu_Limit.Value);
            }
            if (cbx_ProductCount.Checked)       //물품 갯수에 따른 조건을 선택했다면
            {
                CommonUtil.ControlAction<GroupBox, RadioButton>(gb_ProductCount, (item) =>
                {
                    if (item.Checked)
                    {
                        Productsql = item.Tag.ToString();
                    }
                });
            }

            Product_Service service = new Product_Service();
            productinfoVOs = service.SP_SelectProducts(CatagrisID, LimitCount, Productsql, ProductStat);//해당조건에 따른 db접속
            dgv_Products.DataSource = productinfoVOs.ToList();

            if (productinfoVOs.Count > 0)   //가져온것이 있으면 세부검색1 차 2차 을 enable
            {
                gbo_Serch.Enabled = gb_Excel.Enabled = pnl_Prop.Enabled = btn_add.Enabled = true;
            }
            else
            {
                gbo_Serch.Enabled = gb_Excel.Enabled = pnl_Prop.Enabled = btn_add.Enabled = false;
            }

            var list = (from item in productinfoVOs
                        group item by item.Category_ID into g
                        select new CategoriesVO(g.Key, g.First().Category_Name)).ToList();
            //가져온것중에 카테고리를 가져옴

            list.Insert(0, new CategoriesVO(0, "선택"));
            cbo_detailCategory.DataSource = list;   //해당 카테고리를 바인딩

            var IDlist = (from item in productinfoVOs
                          select item.Product_ID).ToList(); //검색된 ProductID를 가져옴


            Valuez_Service valuez_Service = new Valuez_Service();
            connProductVOs = valuez_Service.SP_SelectProductPropID(IDlist).GroupBy((item) => item.Product_ID).ToList(); //아이디에따른 PROP를 ID로 묶어 가져옴

        }
        #endregion

        #region 조건 검색 버튼
        private void btn_apply_Click(object sender, EventArgs e)
        {
            List<ProductinfoVO> list = null;
            if (cbo_detailCategory.SelectedIndex > 0) // 카테고리 선택 인덱스 가 0보다 크면
            {
                list = (productinfoVOs.Where(item => item.Category_ID == (int)cbo_detailCategory.SelectedValue)).ToList(); //선택한 카테고리만 가져옴
            }
            else
            {
                list = productinfoVOs;      //카테고리를 선택 안함
            }

            if (cbo_Key.SelectedIndex > 0 && cbo_keyword.SelectedIndex > 0 && !string.IsNullOrWhiteSpace(txt_keyword.Text) && list != null)
            {
                list = list.Where((item) =>
                {
                    Type type = item.GetType();
                    string value = string.Empty;            //선택한 값
                    string search = txt_keyword.Text.Trim();//검색 값
                    foreach (PropertyInfo prop in type.GetProperties()) //선택한 prop값에따라
                    {
                        if (prop.Name == cbo_Key.SelectedValue.ToString())
                        {
                            value = prop.GetValue(item).ToString();
                        }
                    }
                    return Stringcompare(value, search); //검색조건에ㅡ따른 검색
                }).ToList();
            }

            if (list == null) //선택된 list가 없으면
            {
                dgv_Products.DataSource = productinfoVOs;
                SelectedProductvo = productinfoVOs;
                return;
            }

            SelectedProductvo = list;
            dgv_Products.DataSource = list;
        }
        #endregion

        #region 정렬버튼
        private void btn_SortPrice_Click(object sender, EventArgs e)
        {
            if (!(cbo_Sortkey.SelectedIndex > 0))
                return;
            var list = ((List<ProductinfoVO>)dgv_Products.DataSource).ToList(); //데이터 소스를가져옴
            list.Sort((x, y) =>
            {
                dynamic xValue = 1, yValue = 1;    //각 형변환 형태에 따라
                Type type = x.GetType();
                foreach (PropertyInfo info in type.GetProperties())
                {
                    if (info.Name == cbo_Sortkey.SelectedValue.ToString()) //선택한 프로퍼티
                    {
                        xValue = info.GetValue(x);      //해당 값을 저장
                        yValue = info.GetValue(y);
                    }
                }
                if (rd_ascending.Checked)       //오름차 내림차에 따른 정렬
                {
                    if (xValue == null)         //NULL정렬조건
                        if (yValue == null)
                            return 0; 
                        else
                            return -1;
                    else if (yValue == null)
                        return 1;  
                    else
                        return xValue.CompareTo(yValue);
                }
                else
                {
                    if (yValue == null)
                        if (xValue == null)
                            return 0;
                        else
                            return -1;
                    else if (xValue == null)
                        return 1;
                    else
                        return yValue.CompareTo(xValue);
                }
            });
            dgv_Products.DataSource = list; //해당 값을 바인딩
        }
        #endregion

        #region  추가 버튼
        private void btn_add_Click(object sender, EventArgs e)
        {
            ProductPopUp popUp = new ProductPopUp(commonVOs);
            DialogResult result = popUp.ShowDialog();
            if (result == DialogResult.Yes)    //추가
            {
                var data = (List<ProductinfoVO>)dgv_Products.DataSource;
                data.Add(popUp.vo);
                connProductVOs.Add(popUp.RetrunConns);
                data = data.OrderBy((x) => x.Product_ID).ToList();
                dgv_Products.DataSource = data;
            }
        }

        #endregion

        #endregion

        #endregion

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dgv_Products_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int ProductID = Convert.ToInt32(dgv_Products["Product_ID", e.RowIndex].Value);
            ProductPopUp popUp = new ProductPopUp(commonVOs, ProductID, connProductVOs.Find(x => x.Key == ProductID));
            DialogResult result = popUp.ShowDialog();
            if (result == DialogResult.OK)  //수정
            {
                var data = (List<ProductinfoVO>)dgv_Products.DataSource;
                var item = data.Find(x => x.Product_ID == ProductID);
                data.Remove(item);
                data.Add(popUp.vo);
                connProductVOs.Remove(popUp.valuezConns);
                connProductVOs.Add(popUp.RetrunConns);
                data = data.OrderBy((x) => x.Product_ID).ToList();
                dgv_Products.DataSource = data;
            }
            else if(result == DialogResult.Yes)    //추가
            {
                var data = (List<ProductinfoVO>)dgv_Products.DataSource;
                data.Add(popUp.vo);
                connProductVOs.Add(popUp.RetrunConns);
                data = data.OrderBy((x) => x.Product_ID).ToList();
                dgv_Products.DataSource = data;
            }
            else if(result == DialogResult.Ignore) //삭제
            {
                var data = (List<ProductinfoVO>)dgv_Products.DataSource;
                var item = data.Find(x => x.Product_ID == ProductID);
                data.Remove(item);
                data = data.OrderBy((x) => x.Product_ID).ToList();
                dgv_Products.DataSource = data;
            }
        }

        private void dgv_Products_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           foreach(DataGridViewRow row in dgv_Products.Rows)
            {
                row.Cells["BOM 등록"].Value = "BOM";
                row.Cells["정전개"].Value = "정전개";
                row.Cells["역전개"].Value = "역전개";
            }
        }

        private void dgv_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int seletedID = Convert.ToInt32(dgv_Products["Product_ID", e.RowIndex].Value);
            if (dgv_Products.SelectedCells[0].Value.ToString() == "BOM")
            {
                List<ProductinfoVO> products = (List<ProductinfoVO>)dgv_Products.DataSource;
                var Product = products.First(item => item.Product_ID == seletedID);
                BOMSet bOM = new BOMSet(BOMSet.Selected.BOM, Product);
                bOM.ShowDialog();
            }
            else if (dgv_Products.SelectedCells[0].Value.ToString() == "정전개")
            {
                List<ProductinfoVO> products = (List<ProductinfoVO>)dgv_Products.DataSource;
                var Product = products.First(item => item.Product_ID == seletedID);
                BOMSet bOM = new BOMSet(BOMSet.Selected.Forward, Product);
                bOM.ShowDialog();
            }
            else if (dgv_Products.SelectedCells[0].Value.ToString() == "역전개")
            {
                List<ProductinfoVO> products = (List<ProductinfoVO>)dgv_Products.DataSource;
                var Product = products.First(item => item.Product_ID == seletedID);
                BOMSet bOM = new BOMSet(BOMSet.Selected.Reverse, Product);
                bOM.ShowDialog();
            }

        }
    }

}
