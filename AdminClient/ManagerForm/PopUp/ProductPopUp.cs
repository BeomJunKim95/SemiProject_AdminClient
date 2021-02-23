using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    public partial class ProductPopUp : Form
    {
        List<CommonVO> commonVOs;
        public ProductinfoVO vo = null;
        public IGrouping<int, ValuezConnProductVO> valuezConns;
        public IGrouping<int, ValuezConnProductVO> RetrunConns;
        public ProductPopUp()
        {
            InitializeComponent();
        }

        public ProductPopUp(List<CommonVO> commonVOs) : this()
        {
            this.commonVOs = commonVOs;
            btnDeleted.Enabled = btnUpdate.Enabled = false;
        }

        public ProductPopUp(List<CommonVO> commonVOs, int productID, IGrouping<int, ValuezConnProductVO> valuezConns) : this(commonVOs)
        {
            this.valuezConns = valuezConns;
            Product_Service db = new Product_Service();
            vo = db.SelectFromID(productID);
            btnDeleted.Enabled = btnUpdate.Enabled = true;
        }

        private void ProductPopUp_Load(object sender, EventArgs e)
        {
            TextBoxEvent();
            ComboBainding();

            if (vo == null) //vo설정된 것이 없으면 -> 바로 추가버튼으로오면
                return;
            
            cboState.SelectedItem = commonVOs.Where((item) => item.Common_Code.Trim() == vo.Product_State.Trim()).ToList()[0]; //물품상태 에따른 콤보바스 아이탬 선택
            ProductImage.Image = CommonUtil.ByteToImage(vo.Product_Img);    //이미지 바인딩

            txtID.Text = vo.Product_ID.ToString();
            txtName.Text = vo.Product_Name.ToString();
            txtMax.Text = vo.Product_Max.ToString();
            txtMin.Text = vo.Product_Min.ToString();
            txtPrice.Text = vo.Product_Price.ToString();
            txtLogCount.Text = vo.Product_LogCount.ToString();
            txtPsyCount.Text = vo.Product_PsyCount.ToString();
            txtCategory.Text = vo.Category_ID.ToString();
            //각  text설정

            if (vo.Product__Stand != null)
                txtStand.Text = vo.Product__Stand.ToString();
            productFeature.BaindingCombox(vo.Category_ID);

            CommonUtil.ControlAction<Panel, ComboBox>(productFeature.PnlFeatures, (combox) =>
            {
                var items = (List<ValuezcConnFeatureVO>)combox.DataSource;
                foreach (var Pvaluez in valuezConns)
                {
                    foreach (var Fvaluez in items)
                    {
                        if (Pvaluez.Value_ID == Fvaluez.Value_ID)
                        {
                            combox.SelectedItem = Fvaluez;
                            return;
                        }
                    }
                }
            });

            //CommonUtil.ControlFunc<Panel,int,ComboBox>(productFeature.PnlFeatures,(combox) =>
            //{
            //    combox.SelectedItem
            //})
        }

        private bool IsAllDataInput()
        {
            bool resultreturn = false;
            CommonUtil.ControlAction<Form, TextBox>(this, (box) => //data 입력 상태 확인
            {
                if (box.Name != "txtStand" && box.Name != "txtID")
                    if (string.IsNullOrWhiteSpace(box.Text))
                        resultreturn = true;
            });
            return resultreturn;
        }

        private ProductinfoVO GetTextBoxForProductVo()
        {
            return new ProductinfoVO() //vo생성
            {
                Product_ID = string.IsNullOrWhiteSpace(txtID.Text) ? 0 : txtID.Toint(),
                Product_Max = txtMax.Toint(),
                Product_Min = txtMin.Toint(),
                Product_LogCount = txtLogCount.Toint(),
                Product_PsyCount = txtPsyCount.Toint(),
                Product_Price = Convert.ToDecimal(txtPrice.ToTrimText()),
                Product__Stand = txtStand.ToTrimText() == "" ? null : txtStand.ToTrimText(),
                Category_ID = txtCategory.Toint(),
                Product_Name = txtName.ToTrimText(),
                Product_State = cboState.SelectedValue.ToString().Trim(),
                Product_Img = CommonUtil.ImageToByte(ProductImage.Image)
            };
        }

        private void ComboBainding()
        {
            DivitionService service = new DivitionService();
            cbo_divition.DisplayMember = "Division_Name";
            cbo_divition.ValueMember = "Division_ID";
            cbo_catagory.DisplayMember = "Category_Name";
            cbo_catagory.ValueMember = "Category_ID";
            cbo_divition.DataSource = service.GetAllDivition();
            cboState.DisplayMember = "Common_Name";
            cboState.ValueMember = "Common_Code";
            cboState.DataSource = commonVOs;
        }

        private void TextBoxEvent()
        {
            txtMax.KeyPress += UtilEvent.TextBoxIsDigit;
            txtMin.KeyPress += UtilEvent.TextBoxIsDigit;
            txtPrice.KeyPress += UtilEvent.TextBoxIsDigit;
            txtPsyCount.KeyPress += UtilEvent.TextBoxIsDigit;
            txtLogCount.KeyPress += UtilEvent.TextBoxIsDigit;
            txtCategory.KeyPress += UtilEvent.TextBoxIsDigit;
        }


        #region 버튼 클릭 이벤트

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool resultreturn = IsAllDataInput();
            if (resultreturn)
                return;
            ProductinfoVO Product = GetTextBoxForProductVo();

            string Props = "";
            List<ValuezcConnFeatureVO> list = new List<ValuezcConnFeatureVO>();
            CommonUtil.ControlAction<Panel, ComboBox>(productFeature.PnlFeatures, (combox) =>
            {
                if ((int)combox.SelectedValue > 0)
                {
                    Props += "/" + combox.SelectedValue.ToString();
                    list.Add((ValuezcConnFeatureVO)combox.SelectedItem);
                }
            });

            if (string.IsNullOrWhiteSpace(Props))
                return;

            Props = Props.Remove(0, 1);
            Product_Service service = new Product_Service();
            if (service.UpdateFromVo(Product, Props))
            {
                this.vo = Product;  //수정한vo를 리턴하기위해
                RetrunConns = list.GroupBy(key => Product.Product_ID, item => new ValuezConnProductVO
                {
                    Product_ID = Product.Product_ID,
                    Value_ID = item.Value_ID,
                    Value_Name = item.Value_Name
                }).ToList()[0];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("실패");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Bitmaps|*.bmp|PNG files|*.png|JPEG files|*.jpg|GIF files|*.gif|TIFF files|*.tif|Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream stream = openFileDialog.OpenFile();
                    byte[] vs = new byte[stream.Length];
                    stream.Read(vs, 0, (int)stream.Length);
                    ProductImage.Image = CommonUtil.ByteToImage(vs);
                    if (vo == null)
                        vo = new ProductinfoVO();
                    vo.Product_Img = vs;
                }
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool resultreturn = IsAllDataInput();
            if (resultreturn)
                return;
            ProductinfoVO Product = GetTextBoxForProductVo();

            string Props = "";
            List<ValuezcConnFeatureVO> list = new List<ValuezcConnFeatureVO>();
            CommonUtil.ControlAction<Panel, ComboBox>(productFeature.PnlFeatures, (combox) =>
            {
                if ((int)combox.SelectedValue > 0)
                {
                    Props += "/" + combox.SelectedValue.ToString();
                    list.Add((ValuezcConnFeatureVO)combox.SelectedItem);
                }
            });

            if (string.IsNullOrWhiteSpace(Props))
                return;

            Props = Props.Remove(0, 1);
            Product_Service service = new Product_Service();
            int ProductID = 0;
            if (service.InertFromVo(Product, Props, ref ProductID))
            {
                Product.Product_ID = ProductID;
                this.vo = Product;  //수정한vo를 리턴하기위해
                RetrunConns = list.GroupBy(key => Product.Product_ID, item => new ValuezConnProductVO
                {
                    Product_ID = ProductID,
                    Value_ID = item.Value_ID,
                    Value_Name = item.Value_Name
                }).ToList()[0];
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show("실패");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            Product_Service service = new Product_Service();

            if (service.deleteFromID(vo.Product_ID))
            {
                MessageBox.Show("성공");
                this.DialogResult = DialogResult.Ignore;
                this.Close();
            }
            else
            {
                MessageBox.Show("실패");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        #endregion


        #region Combobox이벤트
        private void cbo_divition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categories_Service service = new Categories_Service();
            cbo_catagory.DataSource = service.SelectCategoriesFromDivisionID((int)cbo_divition.SelectedValue);
        }

        private void cbo_catagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCategory.Text = cbo_catagory.SelectedValue.ToString();
            productFeature.BaindingCombox((int)cbo_catagory.SelectedValue);
        }

        #endregion
    }
}
