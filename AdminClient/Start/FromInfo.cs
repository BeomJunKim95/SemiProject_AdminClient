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
    public partial class FromInfo : Form
    {
        List<string> typeList = new List<string>();
        Queue<PreviewKeyDownEventArgs> eventArgs = new Queue<PreviewKeyDownEventArgs>();
        public FromInfo()
        {
            InitializeComponent();
        }

        private void FromInfo_Load(object sender, EventArgs e)
        {
            txtFromName.Enabled = false;
            typeList = new List<string>();
            foreach (Type t in Assembly.GetExecutingAssembly().GetExportedTypes())  //모든 타입가져옴
            {
                if (t.Namespace == "AdminClient.Start") //해당 네임스페이스만
                {
                    if (Activator.CreateInstance(t) is Form) //폼인 클래스만
                    {
                        typeList.Add(t.Name);
                    }
                }
            }

            txtMenuName.KeyPress += UtilEvent.tbx_Trim;
            txtMenuName.KeyPress += UtilEvent.isHangul_KeyPress;

            DgvSet();
            Inited(); //초기상태
        }

        /// <summary>
        /// 초기상태
        /// </summary>
        private void Inited()
        {

            DgvDatSourceLoad();
            BtnAdd.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            txtFromName.Text = string.Empty;
            txtMenuName.Text = string.Empty;
        }

        #region
        /// <summary>
        /// 데이터 로드
        /// </summary>
        private void DgvDatSourceLoad()
        {
            //네임스페이스의 모든 폼이름 목록을 복사
            var AllFroms = (from item in typeList
                            select item).ToList();

            FormInfoService service = new FormInfoService();
            var list = service.GetAllFormInfo(); //db에서 모든 폼을 가져옴

            //네임스페이스에 해당 가져온 목록이 있으면 삭제 즉 아직 등록안됨 폼만 가져옴
            list.ForEach((item) =>
            {
                AllFroms.Remove(item.Form_Name);
            });

            //db의 목록을 복사해옴
            var templist = (from item in list
                            select item).ToList();

            //삭제해야할 항목 저장공간 할당
            List<FormInfoVO> remove = new List<FormInfoVO>();

            //삭제해야할 항목 확인
            templist.ForEach((item) =>
            {
                typeList.ForEach((type) =>
                {
                    if (item.Form_Name == type) //네임스페이스에 있는 항목 저장
                    {
                        remove.Add(item);
                    }
                });
            });

            //삭제할것을  삭제하여 네임스페이스에 없는데 할당된 폼
            //이미 삭제된 폼을 찾음
            remove.ForEach((index) =>
            {
                templist.Remove(index);
            });

            var items = (from item in AllFroms
                         select new { Form_Name = item }).ToList();

            dgvSelectForm.DataSource = list;     //바인딩된 폼
            dgvNonSelectForm.DataSource = items; //할당안된폼
            dgvdeleted.DataSource = templist;    //할당인 되있지만 네임스페이스에 없는폼
        }
        #endregion

        private void DgvSet()
        {
            CommonUtil.SetInitGridView(dgvSelectForm);
            CommonUtil.AddGridTextColumn(dgvSelectForm, "폼이름", "Form_Name", 150);
            CommonUtil.AddGridTextColumn(dgvSelectForm, "메뉴이름", "Menu_Name");
            CommonUtil.SetInitGridView(dgvNonSelectForm);
            CommonUtil.AddGridTextColumn(dgvNonSelectForm, "폼이름", "Form_Name", 150);
            CommonUtil.SetInitGridView(dgvdeleted);
            CommonUtil.AddGridTextColumn(dgvdeleted, "폼이름", "Form_Name", 150);
            CommonUtil.AddGridTextColumn(dgvdeleted, "메뉴이름", "Menu_Name", visibility: false);
        }

        private void dgvSelectForm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            BtnAdd.Enabled = false;
            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;

            txtFromName.Text = dgvSelectForm["Form_Name", e.RowIndex].Value.ToString();
            txtMenuName.Text = dgvSelectForm["Menu_Name", e.RowIndex].Value.ToString();

        }

        private void dgvNonSelectForm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            BtnAdd.Enabled = true;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;

            txtFromName.Text = dgvNonSelectForm["Form_Name", e.RowIndex].Value.ToString();
            txtMenuName.Text = string.Empty;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            FormInfoService service = new FormInfoService();
            if (service.DeleteFormInfo(txtFromName.Text))
            {
                Inited();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMenuName.Text))
                return;
            FormInfoService service = new FormInfoService();
            if (service.UpdateFormInfo(txtFromName.Text, txtMenuName.Text))
            {
                Inited();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormInfoService service = new FormInfoService();
            if (string.IsNullOrEmpty(txtMenuName.Text))
                return;
            if (service.InsertFormInfo(txtFromName.Text, txtMenuName.Text))
            {
                Inited();
            }
        }

        private void FromInfo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void dgvSelectForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.Alt)
            {
                if (timer1.Enabled)
                {
                    timer1.Stop();
                    foreach (DataGridViewRow row in dgvSelectForm.Rows)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSelectForm.Rows)
            {
                Random random = new Random();
                row.DefaultCellStyle.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            }
        }
    }
}
