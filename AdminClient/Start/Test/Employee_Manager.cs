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
using System.Reflection;
using AdminClient;
namespace AdminClient.Start
{
    public partial class EmployeeManager : Form
    {
        List<EmployeesVO> empList;
        List<GroupInfoVO> grpList;

        public EmployeeManager()
        {
            InitializeComponent();
        }

        #region Load
        private void EmployeeManager_Load(object sender, EventArgs e)
        {
            GroupInfo_Service service = new GroupInfo_Service();
            grpList = service.GetAllGroupInfo();
            grpList.Insert(0, new GroupInfoVO { Group_No = 0, GroupName = "전체" });

            cbo_Group.DataSource = cbo_InfoGrp.DataSource = grpList.ToList();
            cbo_Group.ValueMember = cbo_InfoGrp.ValueMember = "Group_No";
            cbo_Group.DisplayMember = cbo_InfoGrp.DisplayMember = "GroupName";
            cbo_InfoTel.SelectedIndex = cbo_InfoEmail.SelectedIndex = 0;

            txt_EmpNo.KeyPress += UtilEvent.TextBoxIsDigit;
            txt_InfoTel1.KeyPress += UtilEvent.TextBoxIsDigit;
            txt_InfoTel2.KeyPress += UtilEvent.TextBoxIsDigit;

            dtp_From.Value = DateTime.Now.AddDays(-1);

            CommonUtil.SetInitGridView(dgv_EmpList, false);
            CommonUtil.AddGridTextColumn(dgv_EmpList, "이름", "Emp_Name");
            CommonUtil.AddGridTextColumn(dgv_EmpList, "아이디", "Emp_ID");
            CommonUtil.AddGridTextColumn(dgv_EmpList, "핸드폰", "Emp_Phone");
            CommonUtil.AddGridTextColumn(dgv_EmpList, "메일", "Emp_Email");
            CommonUtil.AddGridTextColumn(dgv_EmpList, "입사일", "Emp_HireDate");
            CommonUtil.AddGridTextColumn(dgv_EmpList, "퇴사일", "Emp_RetiredDate");
            CommonUtil.AddGridTextColumn(dgv_EmpList, "Emp_No", "Emp_No", visibility: false);

        }
        #endregion

        #region 검색조건
        private void btn_Search_Click(object sender, EventArgs e) //검색버튼
        {
            string grpNo, limit, now;
            grpNo = limit = now = string.Empty;

            if (cbx_Limit.Checked)
                limit = nu_Limit.Value.ToString();

            if (cbx_SearchPoint.Checked && cbo_Group.SelectedIndex > 0)
                grpNo = cbo_Group.SelectedValue.ToString();

            if (cbx_RetireRemove.Checked)
                now = "0";

            EmployeesService service = new EmployeesService();
            empList = service.GetAllEmployeeList(limit, grpNo, now);
            var empListGroup = empList.GroupBy(item => item.Emp_ID).ToList();
            List<EmployeesVO> employees = new List<EmployeesVO>();
            empListGroup.ForEach(item =>
                employees.Add(item.First())
            );
            dgv_EmpList.DataSource = employees;

        }

        private void cbx_Limit_CheckedChanged(object sender, EventArgs e) //검색제한 
        {
            nu_Limit.Enabled = cbx_Limit.Checked;
        }

        private void cbx_SearchPoint_CheckedChanged(object sender, EventArgs e) //검색조건 
        {
            gb_Point.Enabled = cbx_SearchPoint.Checked;
        }
        #endregion

        #region 상세검색
        private void DetailSearchCheck(object sender, EventArgs e) //상세검색조건 
        {
            foreach(Control ct in gb_Detail.Controls)
            {
                if(!(ct is RadioButton) && ((Control)ct).Tag != null)
                {
                    if (((Control)sender).Tag.ToString() == ct.Tag.ToString())
                        ct.Enabled = ((RadioButton)sender).Checked;
                }
            }
        }

        private void btn_apply_Click(object sender, EventArgs e) //상세검색 
        {
            if (rb_EmpNo.Checked)
            {
                var list = (from emp in empList
                            where emp.Emp_No == int.Parse(txt_EmpNo.Text)
                            select emp).ToList();

                dgv_EmpList.DataSource = null;
                dgv_EmpList.DataSource = list;
                txt_EmpNo.Text = "";
            }
            else if (rb_Name.Checked)
            {
                var list = empList.Where((emp) => emp.Emp_Name.Contains(txt_Name.Text));

                dgv_EmpList.DataSource = null;
                dgv_EmpList.DataSource = list.ToList();
                txt_Name.Text = "";
            }
            else if (rb_Hire.Checked)
            {
                List<EmployeesVO> list = (from info in empList
                                          where info.Emp_HireDate >= dtp_From.Value && info.Emp_HireDate <= dtp_To.Value
                                          select info).ToList();

                dgv_EmpList.DataSource = null;
                dgv_EmpList.DataSource = list;
            }
        }

        private void EmpListSort(object sender, EventArgs e) //정렬 
        {
            string[] sortinfo = ((Control)sender).Tag.ToString().Split('|');

            Type type = typeof(EmployeesVO);
            PropertyInfo pinfo = type.GetProperty($"{sortinfo[1]}");

            dgv_EmpList.DataSource = null;

            if (Convert.ToBoolean(sortinfo[0]))
            {
                dgv_EmpList.DataSource = empList.OrderBy(info => pinfo.GetValue(info, null)).ThenBy(info => info.Emp_No).ToList();
                sortinfo[0] = "false";
                string sorts = sortinfo[0] + "|" + sortinfo[1];
                ((Control)sender).Tag = sorts;
            }
            else
            {
                dgv_EmpList.DataSource = empList.OrderByDescending(info => pinfo.GetValue(info, null)).ThenByDescending(info => info.Emp_No).ToList();
                sortinfo[0] = "true";
                string sorts = sortinfo[0] + "|" + sortinfo[1];
                ((Control)sender).Tag = sorts;
            }
        }

        #endregion

        #region 직원정보그룹
        private void dgv_EmpList_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //직원정보보기 
        {
            if(e.RowIndex > -1)
            {
                txt_InfoName.Text   = dgv_EmpList["Emp_Name", e.RowIndex].Value.ToString();
                lbl_infoEmpNo.Text  = dgv_EmpList["Emp_No", e.RowIndex].Value.ToString();

                var list = (from grpinfo in empList
                            where grpinfo.Emp_No == Convert.ToInt32(dgv_EmpList["Emp_No", e.RowIndex].Value)
                            group grpinfo by new { grpinfo.Group_No, grpinfo.GroupName } into grp
                            select new { No = grp.Key.Group_No, Name = grp.Key.GroupName}).ToList();


                cbo_InfoGrp.DataSource = list.ToList();
                cbo_InfoGrp.DisplayMember = "Name";
                cbo_InfoGrp.ValueMember = "No";

                string[] tels = dgv_EmpList["Emp_Phone", e.RowIndex].Value.ToString().Split('-');

                for(int i = 0; i<cbo_InfoTel.Items.Count; i++)
                {
                    if(cbo_InfoTel.Items[i].ToString().Trim() == tels[0].Trim())
                    {
                        cbo_InfoTel.SelectedIndex = i;
                        break;
                    }
                }

                txt_InfoTel1.Text = tels[1];
                txt_InfoTel2.Text = tels[2];

                string[] emails = dgv_EmpList["Emp_Email", e.RowIndex].Value.ToString().Split('@');
                txt_InfoEmail.Text = emails[0];
                cbo_InfoEmail.Text = emails[1];

                for (int i = 0; i < cbo_InfoEmail.Items.Count; i++)
                {
                    if (cbo_InfoEmail.Items[i].ToString().Trim() == emails[1].Trim())
                    {
                        cbo_InfoEmail.SelectedIndex = i;
                        break;
                    }
                }

            }
        }

        private bool CheckInfo()
        {
            if (txt_InfoName.Text.Trim().Length < 1)
            {
                MessageBox.Show("이름은 필수 입력입니다.");
                return false;
            }

            if (cbo_Group.SelectedIndex < 1)
            {
                MessageBox.Show("기본그룹을 지정해주세요");
                return false;
            }

            if (txt_InfoTel1.Text.Trim().Length + txt_InfoTel2.Text.Trim().Length > 0)
            {
                MessageBox.Show("핸드폰 앞자리를 선택해주세요");
                return false;
            }

            if (txt_EmpNo.Text.Trim().Length > 0)
            {
                MessageBox.Show("이메일 주소를 선택해주세요");
                return false;
            }

            return true;
        }

        private void btn_NewEmp_Click(object sender, EventArgs e) //신규직원등록 
        {
            if (!CheckInfo())
                return;

            EmployeesVO newEmp = new EmployeesVO
            {
                Emp_Name = txt_InfoName.Text,
                Group_No = Convert.ToInt32(cbo_InfoGrp.SelectedValue),
                Emp_ID = txt_InfoName.Text,
                Emp_HireDate = DateTime.Now,
                Emp_RetiredDate = Convert.ToDateTime("9999-12-31")
            };

            if (cbo_InfoTel.SelectedIndex > 0)
                newEmp.Emp_Phone = cbo_InfoTel.SelectedItem + "-" + txt_InfoTel1.Text + "-" + txt_InfoTel2.Text;

            if (cbo_InfoEmail.SelectedIndex > 0)
                newEmp.Emp_Email = txt_InfoEmail.Text + "@" + cbo_InfoEmail.SelectedItem;

            EmployeesService service = new EmployeesService();
            int result = service.InsertNewEmp(newEmp);

            if(result > 0)
            {
                newEmp.Emp_No = result;
                newEmp.GroupName = cbo_InfoGrp.Text;

                empList.Add(newEmp);
                dgv_EmpList.DataSource = null;
                dgv_EmpList.DataSource = empList;

                foreach(Control ct in gb_info.Controls)
                {
                    if (ct is TextBox)
                        ct.Text = "";
                }

            } else
                MessageBox.Show("이미 등록되어있는 직원입니다.");

        }

        private void btn_infoClear_Click(object sender, EventArgs e) //초기화버튼 
        {
            cbo_InfoGrp.DataSource = grpList.ToList();
            cbo_InfoGrp.ValueMember = "Group_No";
            cbo_InfoGrp.DisplayMember = "GroupName";
            cbo_InfoEmail.SelectedIndex = cbo_InfoTel.SelectedIndex = 0;
            lbl_infoEmpNo.Text = "";

            foreach(Control ct in gb_info.Controls)
            {
                if(ct is TextBox)
                    ct.Text = "";
            }
        }

        private void btn_UpdateEmp_Click(object sender, EventArgs e) // 직원정보 업데이트
        {
            if(lbl_infoEmpNo.Text.Length < 1)
            {
                MessageBox.Show("직원을 선택해주세요");
                return;
            }

            if (cbo_InfoGrp.Text == "퇴사")
            {
                MessageBox.Show("퇴사처리 된 직원입니다.");
                return;
            }

            if (!CheckInfo())
                return;

            EmployeesVO info = new EmployeesVO
            {
                Emp_No = int.Parse(lbl_infoEmpNo.Text),
                Emp_Name = txt_InfoName.Text,
                Emp_Phone = cbo_InfoTel.SelectedItem.ToString() + "-" + txt_InfoTel1.Text + "-" + txt_InfoTel2.Text,
                Emp_Email = txt_InfoEmail.Text + "@" + cbo_InfoEmail.SelectedItem.ToString()
            };

            EmployeesService service = new EmployeesService();
            bool result = service.EmpInfoUpdate(info);

            if(result)
            {
                empList.ForEach(infos =>
                {
                    if(infos.Emp_No == info.Emp_No)
                    {
                        infos.Emp_Name = info.Emp_Name;
                        infos.Emp_Phone = info.Emp_Phone;
                        infos.Emp_Email = info.Emp_Email;
                    }
                });

                dgv_EmpList.DataSource = null;
                dgv_EmpList.DataSource = empList;

                MessageBox.Show("정보가 수정되었습니다.");
            }
            else
                MessageBox.Show("수정중 오류가 발생하였습니다.");
        }

        private void btn_DelEmp_Click(object sender, EventArgs e)
        {
            if (lbl_infoEmpNo.Text.Length < 1)
            {
                MessageBox.Show("직원을 선택해주세요");
                return;
            }


            if(cbo_InfoGrp.Text == "퇴사")
            {
                MessageBox.Show("이미 퇴사처리 된 직원입니다.");
                return;
            }
            

            int no = Convert.ToInt32(lbl_infoEmpNo.Text);

            EmployeesService service = new EmployeesService();
            bool result = service.DeleteEmp(no);

            if(result)
            {
                for(int i = 0; i<empList.Count; i++)
                {
                    if (empList[i].Emp_No == no)
                    {
                        empList.RemoveAt(i);
                        break;
                    }
                }

                dgv_EmpList.DataSource = null;
                dgv_EmpList.DataSource = empList;

                foreach (Control ct in gb_info.Controls)
                {
                    if (ct is TextBox)
                        ct.Text = "";
                }
                lbl_infoEmpNo.Text = "";

                MessageBox.Show("퇴사처리 했습니다.");
            }
            else
                MessageBox.Show("처리중 오류가 발생했습니다.");
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lbl_infoEmpNo.Text))
            {
                var emps = (from emp in empList
                            where emp.Emp_No == Convert.ToInt32(lbl_infoEmpNo.Text)
                            select new GroupInfoVO { Group_No = emp.Group_No, GroupName = emp.GroupName }).ToList();
                EmpGroupAdd groupAdd = new EmpGroupAdd(Convert.ToInt32(lbl_infoEmpNo.Text), emps
                    , grpList.ToList() );
                groupAdd.ShowDialog();
                //groupAdd.empGroup();
                var temp = empList.First(item => item.Emp_No == groupAdd.empno);
                empList = empList.Where(item => item.Emp_No != groupAdd.empno).ToList();
                groupAdd.empGroup.ForEach(item =>
                {
                    temp.GroupName = item.GroupName;
                    temp.Group_No = item.Group_No;
                    empList.Add(UtileHelper.GetCopyObj(temp));
                });
                //foreach()
            }
        }
    }
}
