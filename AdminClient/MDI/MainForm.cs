using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    public partial class MainForm : Form
    {
        public List<FormInfoAndGNameVO> infoVOs;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(List<FormInfoAndGNameVO> infoVOs)
        {
            InitializeComponent();
            this.infoVOs = infoVOs;
        }

        /// <summary>
        /// 폼의 로드, 로드될때 그룹별로 나눠어서 
        /// List<a> a= string, IGroping<string, VO>형식
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //    AssemblyBuilder newAssembly = AppDomain.CurrentDomain.DefineDynamicAssembly(
            //    new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);
            //    ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");
            //    TypeBuilder newType = newModule.DefineType("AllForm");

            //    infoVOs.ForEach((infoVO) =>
            //    {
            //        MethodBuilder newMethod = newType.DefineMethod(
            //        infoVO.Form_Name,
            //        MethodAttributes.Public,
            //        typeof(int),
            //        new Type[0]);
            //        ILGenerator generator = newMethod.GetILGenerator();
            //        generator.Emit(OpCodes.Call, )
            //    });

            var items = (from pa in infoVOs
                         group pa by pa.GroupName into data
                         select new { GroupName = data.Key, vo = data }).ToList();

            foreach (var item in items)
            {
                menuStrip1.Items.Add(new ToolStripMenuItem { Name = item.GroupName, Text = item.GroupName });
                foreach (var vo in item.vo)
                {
                    ((ToolStripMenuItem)menuStrip1.Items[item.GroupName]).DropDownItems.Add(vo.Menu_Name, null, (sende, evnt) =>
                    {
                        Type type = Type.GetType("AdminClient.Start." + vo.Form_Name);
                        Form instance = Activator.CreateInstance(type) as Form;
                        instance.Name = vo.Form_Name+vo.GroupName;
                        instance.Text = vo.Menu_Name;
                        this.OpenCreateForm(instance, type, true);
                    });
                }
            }
        }


        #region 이벤트

        #region 폼종료
        /// <summary>
        ///  폼이 종료될때 로딩창이 뜨어짐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
        #endregion

        #region 폼선택
        /// <summary>
        /// 폼이 선택되면
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null){
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized; //폼이 표시될때 최대크기

            TabPage tp = new TabPage { Name = ActiveMdiChild.Name, Text = this.ActiveMdiChild.Text + "      " };
            //탭하나 생성
            foreach(TabPage tab in tabForms.TabPages)
            {
                if (tab.Name == tp.Name)// 해당탭이 있으면 실행   ##Constans 사용불가
                {
                    tabForms.SelectedTab = tab;             //해당탭선택
                    int Select = tabForms.SelectedIndex;    //선택한 탭 인덱스 가져옴
                    //해당 탭의 마우스 버튼 이벤트를 일으킴
                    tabForms_MouseDown(tabForms, new MouseEventArgs(MouseButtons.Left, 1, tabForms.GetTabRect(Select).X + 2, tabForms.GetTabRect(Select).Y + 2, 1));
                    return;
                }
            }
            tp.Tag = this.ActiveMdiChild;   //탭에  Active폼 테그로상속
            tabForms.TabPages.Add(tp);      //탭추가
            tabForms.SelectedTab = tp;      //탭선택

            this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            this.ActiveMdiChild.Tag = tp;
        }
        #endregion
        
        #region 자식폼 닫음
        /// <summary>
        /// 폼닫을때
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();//폼이 닫히면 해당 폼을 상속한 탭 메모리해재(삭제)
        }
        #endregion

        #region 탭선택
        /// <summary>
        /// 탭을 선택
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabForms.SelectedTab != null && tabForms.SelectedTab.Tag != null)
            {
                (tabForms.SelectedTab.Tag as Form).Activate(); //해당 탭 Acticate
            }
        }
        #endregion

        #region 탭 추가
        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text == "") //혹시모를 이상한 추가 탭 안보이게함
                e.Item.Visible = false;
        }
        #endregion

        #region 탭추가
        /// <summary>
        /// 해당 탭의 닫기 이미지를 눌렀을경우실행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabForms_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < tabForms.TabPages.Count; i++)
            {
                var tabRect = tabForms.GetTabRect(i); //탭의 사각형범위 
                //tabRect.Inflate(-2, -2);
                var closeImage = Properties.Resources.close_grey; //이미지가져옴
                var imageRect = new Rectangle(                    //해당이미지의 위치값 가져옴
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))             //만약 닫기이미지위치에 마우스가있으면
                {
                    this.ActiveMdiChild.Close();                //해당 표시 창 닫음
                    //tabForms.TabPages.RemoveAt(i);                    
                    break;
                }
            }
        }
        #endregion
        #endregion
    }
}
