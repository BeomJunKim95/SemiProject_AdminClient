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

namespace AdminClient.Start
{
    public partial class ProductForProp : Form
    {
        List<DivitionVO> Divitions = null;
        List<CategoriesVO> categories = null;
        List<FeatureVO> features = null;
        List<ValuezVO> valuezs = null;

        CheckBox CheckBox = new CheckBox() { Name = "dgvValuechk", Size = new Size(15, 15) };
        public ProductForProp()
        {
            InitializeComponent();
        }

        private void ProductForProp_Load(object sender, EventArgs e)
        {
            DataLoad();
            DataGridViewSet();
            dgvDivitionSet();
            TextBoxKeyEvent();
        }

        #region Private 

        #region 카테고리 셋
        private void categoriesSet(int divitionID)
        {
            categories.Sort(); //정렬
            var list = (from item in categories
                        where item.Division_ID == divitionID
                        select item).ToList();//Division_ID 가 같은것만 가져옴
            dgvCategory.DataSource = list; //바인딩
        }
        #endregion

        # region features 셋
        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryID"></param>
        private void featuresSet(int categoryID)
        {
            features.Sort();
            var list = (from item in features
                        where item.Category_ID == categoryID
                        select item).ToList();
            dgvFeature.DataSource = list;
        }
        #endregion

        #region valuezs셋
        /// <summary>
        /// valuezsSet 셋
        /// </summary>
        /// <param name="Feature_ID"></param>
        private void valuezsSet(int Feature_ID)
        {
            valuezs.Sort();
            var list = (from item in valuezs
                        where item.Feature_ID == Feature_ID
                        select item).ToList();
            dgvValue.DataSource = list;

            foreach (DataGridViewRow row in dgvValue.Rows)  //체크박스 컬럼 값 초기화
            {
                if (row.Index > -1)
                {
                    row.Cells["chk"].Value = false;
                }
            }
        }
        #endregion

        #region Divition 셋
        private void dgvDivitionSet()
        {
            Divitions.Sort();
            dgvDivition.DataSource = Divitions;
            dgvDivition.RefreshGridView();
        }
        #endregion

        #region 텍스트 박스 
        private void TextBoxKeyEvent()
        {
            txtCDivitionID.KeyPress += UtilEvent.Handled_KeyPress;
            txtFCategoryID.KeyPress += UtilEvent.Handled_KeyPress;
            txtVFeatureID.KeyPress  += UtilEvent.Handled_KeyPress;

            txtCDivitionID.KeyPress += UtilEvent.TextBoxIsDigit;
            txtFCategoryID.KeyPress += UtilEvent.TextBoxIsDigit;
            txtVFeatureID.KeyPress  += UtilEvent.TextBoxIsDigit;

            txtDivitionID.KeyPress  += UtilEvent.TextBoxIsDigit;
            txtCategoryID.KeyPress  += UtilEvent.TextBoxIsDigit;
            txtFeatureID.KeyPress   += UtilEvent.TextBoxIsDigit;
            txtVFeatureID.KeyPress  += UtilEvent.TextBoxIsDigit;
            txtValueID.KeyPress     += UtilEvent.TextBoxIsDigit;

            txtDivitionName.KeyPress    += UtilEvent.isHangul_KeyPress;
            txtDivitionName.KeyPress    += UtilEvent.tbx_Trim;
            txtCategoryName.KeyPress    += UtilEvent.tbx_Trim;
        }
        #endregion

        #region 데이터 그리드 뷰
        private void DataGridViewSet()
        {
            CommonUtil.SetInitGridView(dgvDivition, false);
            CommonUtil.SetInitGridView(dgvCategory, false);
            CommonUtil.SetInitGridView(dgvFeature, false);
            CommonUtil.SetInitGridView(dgvValue, false);

            CommonUtil.AddGridTextColumn(dgvDivition, "DivisionID", "Division_ID", 80);
            CommonUtil.AddGridTextColumn(dgvDivition, "DivisionName", "Division_Name",80);

            CommonUtil.AddGridTextColumn(dgvCategory, "DivisionID", "Division_ID",80);
            CommonUtil.AddGridTextColumn(dgvCategory, "CategoryID", "Category_ID",80);
            CommonUtil.AddGridTextColumn(dgvCategory, "CategoryName", "Category_Name",100);

            CommonUtil.AddGridTextColumn(dgvFeature, "CategoryID", "Category_ID",80);
            CommonUtil.AddGridTextColumn(dgvFeature, "FeatureID", "Feature_ID",80);
            CommonUtil.AddGridTextColumn(dgvFeature, "FeatureName", "Feature_Name", 100);

            CommonUtil.AddGridCheckColumn(dgvValue, "", "chk", 30 );
            CommonUtil.AddGridTextColumn(dgvValue, "FeatureID", "Feature_ID", 80);
            CommonUtil.AddGridTextColumn(dgvValue, "ValueID", "Value_ID", 80);
            CommonUtil.AddGridTextColumn(dgvValue, "ValueName", "Value_Name", 100);

            int x = dgvValue.Location.X;
            int y = dgvValue.Location.Y;
            CheckBox.Location = new Point(x+5, y+ 3);   //체크박스 
            gpbValue.Controls.Add(CheckBox);
            CheckBox.BringToFront();
        }
        #endregion

        #region 데이터 로드
        private void DataLoad()
        {
            DivitionService Divisonservice = new DivitionService();
            Categories_Service categoriesService = new Categories_Service();
            FeatureService featureService = new FeatureService();
            Valuez_Service service = new Valuez_Service();
            Divitions = Divisonservice.GetAllDivition();
            categories = categoriesService.GetAllCategries();
            features = featureService.GetAllFeature();
            valuezs = service.GetAllValuez();
        }
        #endregion

        #region 셀렉트 하지 않은 텍스트박스
        /// <summary>
        /// 선택하지않은 그룹박스의 텍스트 박스의 텍스트를 빈값으로
        /// </summary>
        /// <param name="groupBox"></param>
        private void NonSelectGroupBoxTextEmpty(GroupBox groupBox)
        {
            CommonUtil.ControlAction<ProductForProp, GroupBox>(this, (gBox) =>
            {
                if (gBox != groupBox)
                {
                    CommonUtil.ControlAction<GroupBox, TextBox>(gBox, (txtbox) =>
                    {
                        txtbox.Text = string.Empty;
                    });
                }
            });
        }
        #endregion

        #endregion

        #region Event
        #region dgvSelect

        #region 디비전 선택
        /// <summary>
        /// 선택한 값 바인드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDivition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            string DivisionID = dgvDivition["Division_ID", e.RowIndex].Value.ToString();
            txtDivitionID.Text = DivisionID;
            txtDivitionName.Text = dgvDivition["Division_Name", e.RowIndex].Value.ToString();

            categoriesSet(Convert.ToInt32(DivisionID));
            NonSelectGroupBoxTextEmpty(gpbDivition); //해당 GroupBox
            txtCDivitionID.Text = DivisionID;        //카테고리 디비전 아이디 텍스트 할당

        }
        #endregion

        #region 카테고리 선택
        /// <summary>
        /// 카테고리 선택
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            string CategoryID = dgvCategory["Category_ID", e.RowIndex].Value.ToString();
            string DivitionID = dgvCategory["Division_ID", e.RowIndex].Value.ToString();
            txtCategoryID.Text = CategoryID;
            txtCDivitionID.Text = DivitionID;
            txtCategoryName.Text = dgvCategory["Category_Name", e.RowIndex].Value.ToString();

            featuresSet(Convert.ToInt32(CategoryID));
            NonSelectGroupBoxTextEmpty(gpbCategory); // 해당 guopbox가아닌 모든 텍스트 박스 string.Empty
            txtFCategoryID.Text = CategoryID;
        }
        #endregion

        #region 피처선택
        private void dgvFeature_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            string FeatureID = dgvFeature["Feature_ID", e.RowIndex].Value.ToString();
            string CategoryID = dgvFeature["Category_ID", e.RowIndex].Value.ToString();
            txtFeatureID.Text = FeatureID;
            txtFCategoryID.Text = CategoryID;
            txtFeatureName.Text = dgvFeature["Feature_Name", e.RowIndex].Value.ToString();

            valuezsSet(Convert.ToInt32(FeatureID));
            NonSelectGroupBoxTextEmpty(gpbFeature);
            txtVFeatureID.Text = FeatureID;
        }
        #endregion

        #region 밸류 셀 더블클릭
        /// <summary>
        /// 밸류 셀 더블클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvValue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtValueID.Text = dgvValue["Value_ID", e.RowIndex].Value.ToString();
            txtValueName.Text = dgvValue["Value_Name", e.RowIndex].Value.ToString();
            txtVFeatureID.Text = dgvValue["Feature_ID", e.RowIndex].Value.ToString();

            NonSelectGroupBoxTextEmpty(gpbValue);
        }
        #endregion

        #endregion

        #region AddEvents

        #region Divition ADD이벤트
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDivistionadd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDivitionID.Text) || string.IsNullOrEmpty(txtDivitionName.Text))
                return;
            DivitionService service = new DivitionService();
            int DivitionID = Convert.ToInt32(txtDivitionID.Text);
            string DivitionName = txtDivitionName.Text.Trim();

            if (service.InsertDivition(DivitionID, DivitionName)) //ADD가 성공하면
            {
                Divitions.Add(new DivitionVO    //List add
                {
                    Division_ID = DivitionID,
                    Division_Name = DivitionName
                });

                dgvDivitionSet();       //dgv다시 셋 및 정렬
            }
        }
        #endregion

        #region Category add 이벤트
        /// <summary>
        /// 카테고리 ADD 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCategoryadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text) || string.IsNullOrEmpty(txtCDivitionID.Text))
                return;

            int CategoryID = 0;
            if (!string.IsNullOrWhiteSpace(txtCategoryID.Text))
                CategoryID = Convert.ToInt32(txtCategoryID.Text);
            string CategoryName = txtCategoryName.Text.Trim();
            int CDivitionID = Convert.ToInt32(txtCDivitionID.Text);

            Categories_Service service = new Categories_Service();
            if(service.SP_CategoryInsert(CategoryID, CategoryName, CDivitionID))
            {
                if (CategoryID == 0)    //만약 자동 증가 id값으로 넣으면
                {
                    var vo = categories.Max();     //가장큰 id값을 찾음
                    CategoryID = vo.Category_ID + 1;  //해당 id값 +1
                }

                categories.Add(new CategoriesVO
                {
                    Category_ID = CategoryID,
                    Category_Name = CategoryName,
                    Division_ID = CDivitionID
                });

                categoriesSet(CDivitionID);
            }
        }
        #endregion

        #region Feature Add 이벤트
        private void btnFeatureAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFCategoryID.Text) || string.IsNullOrWhiteSpace(txtFeatureName.Text))
                return;
            FeatureService service = new FeatureService();
            int FeatureID = 0;
            if (txtFeatureID.Text != string.Empty)
                FeatureID = Convert.ToInt32(txtFeatureID.Text);
            int CategoryID = Convert.ToInt32(txtFCategoryID.Text);
            string FeatureName = txtFeatureName.Text.Trim();
            if (service.SP_FeatureInsert(FeatureID, FeatureName, CategoryID))
            {
                if (FeatureID == 0)    //만약 자동 증가 id값으로 넣으면
                {
                    var vo = features.Max();     //가장큰 id값을 찾음
                    FeatureID = vo.Feature_ID + 1;  //해당 id값 +1
                }

                features.Add(new FeatureVO
                {
                    Category_ID = CategoryID,
                    Feature_ID = FeatureID,
                    Feature_Name = FeatureName
                });
                featuresSet(CategoryID);
            }
        }
        #endregion

        #region Value Add 이벤트
        /// <summary>
        /// 값 add 이벤트 검색조건을 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValueAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVFeatureID.Text) || string.IsNullOrWhiteSpace(txtValueName.Text))
                return;
            Valuez_Service service = new Valuez_Service();
            int ValueID = 0;
            if (txtValueID.Text != string.Empty)
                ValueID = Convert.ToInt32(txtValueID.Text);
            int FeatureID = Convert.ToInt32(txtVFeatureID.Text);
            string ValueName = txtValueName.Text.Trim();
            if(service.InsertValuez(ValueID,ValueName, FeatureID))
            {
                if(ValueID == 0)    //만약 자동 증가 id값으로 넣으면
                {
                    var vo = valuezs.Max();     //가장큰 id값을 찾음
                    ValueID = vo.Value_ID + 1;  //해당 id값 +1
                }

                valuezs.Add(new ValuezVO        //Valurezs add
                {
                    Value_ID = ValueID,
                    Feature_ID =  FeatureID,
                    Value_Name = ValueName
                });

                valuezsSet(FeatureID);      //valuezSet
            }
        }
        #endregion

        #endregion

        #region UpdateEvents

        #region Divistion Update
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDivistionUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDivitionID.Text) || string.IsNullOrEmpty(txtDivitionName.Text))
                return;
            DivitionService service = new DivitionService();
            int DivitionID = Convert.ToInt32(txtDivitionID.Text);
            string DivitionName = txtDivitionName.Text;

            if (service.UpdateDivition(DivitionID, DivitionName)) //Update 
            {
                Divitions.Find( x => x.Division_ID == DivitionID).Division_Name = DivitionName; // 이름 변경
                dgvDivitionSet();
            }
        }
        #endregion

        #region Category Update
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryID.Text) || string.IsNullOrWhiteSpace(txtCategoryName.Text) || string.IsNullOrEmpty(txtCDivitionID.Text))
                return;
            Categories_Service service = new Categories_Service();
            int CategoryID = Convert.ToInt32(txtCategoryID.Text);
            int DivitionID = Convert.ToInt32(txtCDivitionID.Text);
            string CategoryName = txtCategoryName.Text.Trim();

            if (service.UpdateCategories(CategoryID, CategoryName, DivitionID)) //Update가 성공하면
            {
                var vo = categories.Find(x => x.Category_ID == CategoryID); //해당 vo찾음
                vo.Category_Name = CategoryName;    //변경
                vo.Division_ID = DivitionID;
                categoriesSet(DivitionID);          //변경점 반영
            }
        }
        #endregion

        #region Feature Update
        /// <summary>
        /// Feature 업데이트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFeatureUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFCategoryID.Text) || string.IsNullOrWhiteSpace(txtFeatureName.Text) || string.IsNullOrEmpty(txtFeatureID.Text))
                return;
            FeatureService service = new FeatureService();
            int CategoryID =Convert.ToInt32(txtFCategoryID.Text);
            int FeatureID = Convert.ToInt32(txtFeatureID.Text);
            string FeatureName = txtFeatureName.Text;

            if (service.UpdateFeature(CategoryID, FeatureName , FeatureID))
            {
                var vo = features.Find(x => x.Feature_ID == FeatureID);
                vo.Feature_Name = FeatureName;
                vo.Category_ID = CategoryID;
                featuresSet(CategoryID);
            }
        }
        #endregion

        #region 밸류 업데이트
        private void btnValueUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVFeatureID.Text) || string.IsNullOrWhiteSpace(txtValueName.Text) || string.IsNullOrEmpty(txtValueID.Text))
                return;
            Valuez_Service service = new Valuez_Service();
            int ValueID = Convert.ToInt32(txtValueID.Text);
            int FeatureID = Convert.ToInt32(txtVFeatureID.Text);
            string ValueName = txtValueName.Text.Trim();
            if (service.UpdateValuez(ValueID, ValueName, FeatureID))
            {
                var vo = valuezs.Find(x => x.Value_ID == ValueID);
                vo.Feature_ID = FeatureID;
                vo.Value_Name = ValueName;

                valuezsSet(FeatureID);
            }
        }
        #endregion
        #endregion

        #region DeletesEvent
        private void btnDivistionDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDivitionID.Text))
                return;
            DivitionService service = new DivitionService();
            int DivitionID = Convert.ToInt32(txtDivitionID.Text);

            if (service.DeleteDivition(DivitionID))
            {
                Divitions.Remove(Divitions.Find(x => x.Division_ID == DivitionID));
                dgvDivitionSet();
            }
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryID.Text))
                return;
            Categories_Service service = new Categories_Service();
            int CategoryID = Convert.ToInt32(txtCategoryID.Text);

            if (service.DeleteCategories(CategoryID))
            {
                categories.Remove(categories.Find(x => x.Category_ID == CategoryID));
                categoriesSet(Convert.ToInt32(txtCDivitionID.Text));
            }
        }

        private void btnFeatureDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFeatureID.Text))
                return;
            FeatureService service = new FeatureService();
            int FeatureID = Convert.ToInt32(txtFeatureID.Text);

            if (service.DeleteFeature(FeatureID))
            {
                features.Remove(features.Find(x => x.Feature_ID == FeatureID));
                featuresSet(Convert.ToInt32(txtFCategoryID.Text));
            }
        }

        private void btnValueDelete_Click(object sender, EventArgs e)
        {
            List<int> IDS = new List<int>();
            foreach(DataGridViewRow row in dgvValue.Rows)
            {
                if (row.Index > -1)
                {
                    if ((bool)row.Cells["chk"].Value)
                    {
                        IDS.Add(Convert.ToInt32(row.Cells["Value_ID"].Value));
                    }
                }
            }


            if (IDS.Count < 1)
                return;
            Valuez_Service service = new Valuez_Service();

            if (service.SP_ValuezDeleted(IDS))
            {
                int Feature_ID = valuezs[0].Feature_ID;
                List<ValuezVO> Delects = new List<ValuezVO>();
                IDS.ForEach((ID) =>
                {
                    valuezs.ForEach((item) =>
                    {
                        if(item.Value_ID == ID)
                        {
                            Delects.Add(item);
                        }
                    });
                });

                Delects.ForEach((item) =>
                {
                    valuezs.Remove(item);
                });

                valuezsSet(Feature_ID);
            }
        }

        #endregion
        #endregion
    }
}
