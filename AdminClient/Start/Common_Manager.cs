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
    public partial class Common_Manager : Form
    {
        List<CommonVO> CommonList;

        public Common_Manager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetEvent();
            btnResearch.PerformClick();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CommonVO emp = new CommonVO()
            {
                Common_Code = txt_code.Text,
                Common_Name = txt_name.Text,
                Common_Category = txt_category.Text,
                Common_Pcode = txt_pcode.Text
            };

            Common_Service service = new Common_Service();
            bool bResult = service.Insert(emp);

            if (bResult)
            {
                MessageBox.Show("저장되었습니다.");
                CommonList.Add(emp);
                TextBoxClear();

                dgv_Common.DataSource = null;
                dgv_Common.DataSource = CommonList.OrderBy(x => x.Common_Code).ToList();
            }
            else
            {
                MessageBox.Show("저장실패하였습니다.");
            }
        }

        private void TextBoxClear()
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox txt)
                    txt.Text = "";
            }
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            Common_Service service = new Common_Service();
            CommonList = service.Research();

            dgv_Common.DataSource = CommonList;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CommonVO emp = new CommonVO()
            {
                Common_Code = txt_code.Text,
                Common_Name = txt_name.Text,
                Common_Category = txt_category.Text,
                Common_Pcode = txt_pcode.Text
            };

            Common_Service service = new Common_Service();
            bool update = service.Update(emp);

            if(update)
                MessageBox.Show("변경되었습니다.");
            else
                MessageBox.Show("실패하였습니다.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txt_codedel.Text.Length < 1)
                return;

            if (MessageBox.Show("정말로 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.No)
                return;


            Common_Service service = new Common_Service();
            bool bFlag = service.Delete(txt_codedel.Text);

            if (bFlag)
            {
                MessageBox.Show("삭제되었습니다.");

                CommonList.Remove(CommonList.First(x => x.Common_Code == txt_code.Text));
                dgv_Common.DataSource = null;
                dgv_Common.DataSource = CommonList;

                TextBoxClear();
            }
            else
            {
                MessageBox.Show("삭제실패하였습니다.");
            }
        }

        private void SetEvent()
        {
        }

        private void dgv_Common_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                txt_code.Enabled = false;

                txt_code.Text = txt_codedel.Text = dgv_Common["Common_Code", e.RowIndex].Value.ToString();
                txt_name.Text = dgv_Common["Common_Name", e.RowIndex].Value.ToString();
                txt_category.Text = dgv_Common["Common_Category", e.RowIndex].Value.ToString();

                if(dgv_Common["Common_Pcode", e.RowIndex].Value != null)
                    txt_pcode.Text = dgv_Common["Common_Pcode", e.RowIndex].Value.ToString();

                dgv_Common["Common_Code", e.RowIndex].Value = txt_code.Text;
                dgv_Common["Common_Name", e.RowIndex].Value = txt_name.Text;
                dgv_Common["Common_Category", e.RowIndex].Value = txt_category.Text;
                dgv_Common["Common_Pcode", e.RowIndex].Value = txt_pcode.Text;

            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            txt_code.Enabled = true;
            TextBoxClear();
        }
    }
}
