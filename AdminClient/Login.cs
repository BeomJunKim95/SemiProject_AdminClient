using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtEmpID.KeyPress += UtilEvent.isAlphaAndDigit_KeyPress;
            txtEmpPwd.KeyPress += UtilEvent.isAlphaAndDigit_KeyPress;

            txtEmpID.KeyPress += UtilEvent.tbx_Trim;
            txtEmpPwd.KeyPress += UtilEvent.tbx_Trim;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            EmployeesService service = new EmployeesService();
            Global.employee = service.GetEmployeesFromIDPwd(txtEmpID.Text, txtEmpPwd.Text);
            if(Global.employee == null)
            {
                MessageBox.Show("로그인 실패");
                return;
            }
            if (Global.employee != null)
            {
                MessageBox.Show("로그인 성공");
                FormInfoService Formservice = new FormInfoService();
                this.OpenCreateForm<MainForm>(() => { return new MainForm(Formservice.GetFormForEmp(Global.employee.Emp_No));});
                this.Hide();
            }
        }
    }
}
