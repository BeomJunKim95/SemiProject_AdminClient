using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminClientVO;


namespace AdminClient
{
    public partial class EmpGroupAdd : Form
    {
        public List<GroupInfoVO> empGroup { get; set; }
        public List<GroupInfoVO> grpList { get; set; }
        public int empno { get; set; }
        public EmpGroupAdd()
        {
            InitializeComponent();
        }

        public EmpGroupAdd(int empno, List<GroupInfoVO> empGroup, List<GroupInfoVO> grpList) : this()
        {
            this.empno = empno;
            this.empGroup = empGroup;
            grpList.RemoveAt(0);
            var lsit = grpList;
            empGroup.ForEach((item) =>
            {
                lsit = lsit.Where((grp) => grp.Group_No != item.Group_No).ToList();
            });

            this.grpList = lsit;
        }


        private void EmpGroupAdd_Load(object sender, EventArgs e)
        {
            DataGridSet();
            dgv_empGroup.DataSource = empGroup;
            dgv_Group.DataSource = grpList;
        }

        private void DataGridSet()
        {
            CommonUtil.SetInitGridView(dgv_Group);
            CommonUtil.SetInitGridView(dgv_empGroup); 
            CommonUtil.AddGridTextColumn(dgv_Group, "그룹 번호", "Group_No");
            CommonUtil.AddGridTextColumn(dgv_Group, "그룹 이름", "GroupName");
            CommonUtil.AddGridTextColumn(dgv_empGroup, "그룹 번호", "Group_No");
            CommonUtil.AddGridTextColumn(dgv_empGroup, "그룹 이름", "GroupName");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!(dgv_Group.SelectedRows.Count > 0 || dgv_empGroup.SelectedRows.Count > 0))
                return;

            if (!(dgv_Group.SelectedRows[0].Index > -1 || dgv_empGroup.SelectedRows[0].Index > -1))
                return;
            int groupNo = Convert.ToInt32(dgv_Group["Group_No", dgv_Group.SelectedRows[0].Index].Value);


            EmpGroupConnService Service = new EmpGroupConnService();
            if(Service.InsertEmpGroupConn(empno, groupNo))
            {
                empGroup.Add(new GroupInfoVO { Group_No = groupNo, GroupName = dgv_Group["GroupName", dgv_Group.SelectedRows[0].Index].Value.ToString() });

                grpList = grpList.Where(item => item.Group_No != groupNo).ToList();
                dgv_Group.DataSource = grpList;
                dgv_empGroup.DataSource = empGroup;

                dgv_Group.RefreshGridView();
                dgv_empGroup.RefreshGridView();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!(dgv_empGroup.SelectedRows.Count > 0))
                return;

            if (!(dgv_empGroup.SelectedRows[0].Index > -1))
                return;
            int RowIndex = dgv_empGroup.SelectedRows[0].Index;
            int groupNo = Convert.ToInt32(dgv_empGroup["Group_No", RowIndex].Value);

            EmpGroupConnService Service = new EmpGroupConnService();
            if (Service.DeleteEmpGroupConn(empno, groupNo))
            {
                empGroup = empGroup.Where(item => item.Group_No != groupNo).ToList();
                grpList.Add(new GroupInfoVO { Group_No = groupNo, GroupName = dgv_empGroup["GroupName", RowIndex].Value.ToString() });


                dgv_Group.DataSource = grpList;
                dgv_empGroup.DataSource = empGroup;
                dgv_Group.RefreshGridView();
                dgv_empGroup.RefreshGridView();
            }
        }
    }
}
