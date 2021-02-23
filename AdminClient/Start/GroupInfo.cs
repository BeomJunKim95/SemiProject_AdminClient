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
    public partial class GroupInfo : Form
    {
        List<GroupAuthorityAndMenuNameVO> authorityVO = null;
        List<FormInfoVO> fromVO = null;
        List<GroupInfoVO> GroupVo = null;
        int no = int.MaxValue;
        bool enabled = false;
        public GroupInfo()
        {
            InitializeComponent();
        }

        private void GroupInfo_Load(object sender, EventArgs e)
        {
            DgvSet();
            Fromsreference();
            Groupference();
            Authorityference();
            TextBoxSet();

            dgvGroup.DataSource = GroupVo;
            btnAdd.Enabled = btnDelete.Enabled = btnGruopUpadte.Enabled = btnGruopDelete.Enabled = enabled;
        }
        #region Privet 메서드

        #region 텍스트 박스 이벤트 셋
        private void TextBoxSet()
        {
            txtNo.KeyPress += UtilEvent.tbx_Trim;
            txtName.KeyPress += UtilEvent.tbx_Trim;
            txtNo.KeyPress += UtilEvent.TextBoxIsDigit;
            txtName.KeyPress += UtilEvent.isHangul_KeyPress;
        }
        #endregion

        #region 권한 연결 구조 조회
        private void Authorityference()
        {
            GroupAuthority_Service service = new GroupAuthority_Service();
            authorityVO = service.GetAllAuthorityAndMenu();
        }
        #endregion

        #region 권한 그룹 조회
        private void Groupference()
        {
            GroupInfo_Service service = new GroupInfo_Service();
            GroupVo = service.GetAllGroupInfo();
        }
        #endregion

        #region 폼 재조회
        private void Fromsreference()
        {
            FormInfoService infoService = new FormInfoService();
            fromVO = infoService.GetAllFormInfo();
            dgvFormInfo.DataSource = fromVO;
            if (no != int.MaxValue)
            SetAuthority(no);
        }
        #endregion

        #region 선택한 그룹에 따른 폼과 할당된 폼 확인
        private void SetAuthority(int GroupID)
        {
            var List = (from item in authorityVO
                        where item.Group_No == GroupID
                        select item).ToList(); //선택한 권한 그룹폼만 가져옴

            // fromVO를 복사
            var temp = (from item in fromVO
                        select item).ToList();

            //삭제해야할 From저장장소
            List<FormInfoVO> Deleteds = new List<FormInfoVO>();

            //권한 그룹에 있는 폼들을 가져옴
            fromVO.ForEach((from) =>
            {
                List.ForEach((item) =>
                {
                    if (from.Form_Name == item.Form_Name)
                    {
                        Deleteds.Add(from);
                    }
                });
            });

            //권한그룹에 있는 폼을 삭제
            Deleteds.ForEach((item) =>
            {
                temp.Remove(item);
            });

            //삭제함으로써 해당 권한그룹에 할당안된 폼만 가져와 바인딩
            dgvFormInfo.DataSource = temp;
            //해당 그룹 권한 폼 가져옴
            dgvGroupAuthority.DataSource = List;
        }
        #endregion

        #region dgv설정
        private void DgvSet()
        {
            CommonUtil.SetInitGridView(dgvFormInfo, false);
            CommonUtil.AddGridTextColumn(dgvFormInfo, "폼이름", "Form_Name", 150);
            CommonUtil.AddGridTextColumn(dgvFormInfo, "메뉴이름", "Menu_Name");
            CommonUtil.SetInitGridView(dgvGroup, false);
            CommonUtil.AddGridTextColumn(dgvGroup, "그룹번호", "Group_No", 80);
            CommonUtil.AddGridTextColumn(dgvGroup, "그룹이름", "GroupName", 150);
            CommonUtil.SetInitGridView(dgvGroupAuthority, false);
            CommonUtil.AddGridTextColumn(dgvGroupAuthority, "그룹번호", "Group_No", 80);
            CommonUtil.AddGridTextColumn(dgvGroupAuthority, "폼이름", "Form_Name", 150);
            CommonUtil.AddGridTextColumn(dgvGroupAuthority, "메뉴이름", "Menu_Name",150);
        }
        #endregion

        #region 정렬
        private void OderByGroupVo()
        {
            var list = GroupVo.OrderBy(x=> x.Group_No).ToList();
            GroupVo.Sort();

        }
        #endregion

        #endregion

        #region 이벤트

        #region 폼 재조회
        private void btn_Fromsreference_Click(object sender, EventArgs e)
        {
            Fromsreference();
        }
        #endregion

        #region 권한그릅 폼 더블클릭
        private void dgvGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            no = Convert.ToInt32(dgvGroup["Group_No", e.RowIndex].Value);
            SetAuthority(no);
            txtNo.Text = dgvGroup["Group_No", e.RowIndex].Value.ToString();
            txtName.Text = dgvGroup["GroupName", e.RowIndex].Value.ToString();
            if (!enabled)   //한번도 누른적없으면
            {
                enabled = true;
                btnAdd.Enabled = btnDelete.Enabled = btnGruopUpadte.Enabled = btnGruopDelete.Enabled = enabled; //버튼을 선택할수 있게함
            }
        }
        #endregion

        #region 권한 할당 추가버튼클릭 => 버튼
        /// <summary>
        /// => 버튼을 클릭하여 해당 권한 그룹에 Form을 추가 접근 할 수 있게함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvFormInfo.SelectedRows != null || dgvFormInfo.SelectedRows[0].Index != -1)
            {
                int index = dgvFormInfo.SelectedRows[0].Index;
                GroupAuthority_Service service = new GroupAuthority_Service();
                if (service.InsertGroupAuthority(no, dgvFormInfo["Form_Name", index].Value.ToString())) //추가가 되면
                {
                    authorityVO.Add(new GroupAuthorityAndMenuNameVO //리스트에 추가
                    {
                        Group_No = no,
                        Form_Name = dgvFormInfo["Form_Name", index].Value.ToString(),
                        Menu_Name = dgvFormInfo["Menu_Name", index].Value.ToString()
                    });
                    SetAuthority(no); //재 조회
                }
            } 
        }
        #endregion

        #region 권한 삭제 삭제버튼클릭 <= 버튼
        /// <summary>
        ///  <=버튼을 클릭하여 할당된 권한 Form을 삭제하고 재조회함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGroupAuthority.SelectedRows != null || dgvGroupAuthority.SelectedRows[0].Index != -1)
            {
                int index = dgvGroupAuthority.SelectedRows[0].Index;
                GroupAuthority_Service service = new GroupAuthority_Service();
                if (service.DeletedGroupAuthority(no, dgvGroupAuthority["Form_Name", index].Value.ToString())) //삭제가되면
                {
                    GroupAuthorityAndMenuNameVO temp = null;
                    foreach (var item in authorityVO) //삭제할 vo찾음
                    {
                        if (item.Group_No == no && item.Form_Name == dgvGroupAuthority["Form_Name", index].Value.ToString())
                        {
                            temp = item;
                            break;
                        }
                    }
                    authorityVO.Remove(temp); //삭제
                    SetAuthority(no);           //재 조회
                }
            }
        }
        #endregion

        #region 그룹추가
        private void btnGruopAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo.Text) || string.IsNullOrEmpty(txtName.Text))
                return;
            int GroupNo = Convert.ToInt32(txtNo.Text);
            GroupInfo_Service service = new GroupInfo_Service();
            if (service.InserGroupInfo(GroupNo, txtName.Text)) //추가가되면
            {
                GroupVo.Add(new GroupInfoVO                     //List에추가
                {
                    Group_No = GroupNo,
                    GroupName = txtName.Text
                });
                OderByGroupVo();                                //정렬
                dgvGroup.RefreshGridView();                     //데이터 그리드뷰 제조회
            }

        }
        #endregion

        #region 그룹명 변경
        private void btnGruopUpadte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo.Text) || string.IsNullOrEmpty(txtName.Text))
                return;
            int GroupNo = Convert.ToInt32(txtNo.Text);
            GroupInfo_Service service = new GroupInfo_Service();
            if (service.UpdateGroupInfo(GroupNo, txtName.Text)) //변경이 되면
            {
                GroupInfoVO temp = null;
                foreach (var item in GroupVo)       //변경할 vo찾음
                {
                    if (item.Group_No == GroupNo)
                    {
                        temp = item;
                        break;
                    }
                }
                GroupVo.Remove(temp);           //일단 삭제
                temp.GroupName = txtName.Text;  //그룹명을 변경
                GroupVo.Add(temp);              //추가
                OderByGroupVo();                //정렬
                dgvGroup.RefreshGridView();     //재할당
            }
        }
        #endregion

        #region 삭제
        private void btnGruopDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo.Text))
                return;
            int GroupNo = Convert.ToInt32(txtNo.Text);
            GroupInfo_Service service = new GroupInfo_Service();
            if (service.DeleteGroupInfo(GroupNo))   //삭제가 되면
            {
                GroupInfoVO temp = null;
                foreach(var item in GroupVo)        //삭제할것을찾음
                {
                    if(item.Group_No == GroupNo)
                    {
                        temp = item;
                        break;
                    }
                }
                GroupVo.Remove(temp);   //삭제
                OderByGroupVo();        //정렬
                dgvGroup.RefreshGridView(); //재할당
            }
        }
        #endregion

        #endregion
    }
}
