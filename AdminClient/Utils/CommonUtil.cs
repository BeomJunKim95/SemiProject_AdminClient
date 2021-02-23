using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    public class CommonUtil
    {
        public static void BindingComboBoxDictionary(ComboBox cbo, Dictionary<int, string> dic, bool blankItemAdd = true)
        {
            cbo.DataSource = new BindingSource(dic, null);
            cbo.ValueMember = "Key";
            cbo.DisplayMember = "Value";
        }


        public static void BindingComboBox(ComboBox cbo, DataTable dt, string valueMember, string displayMember, bool blankItemAdd = true)
        {
            if (blankItemAdd)
            {
                DataRow dr = dt.NewRow();
                dr[valueMember] = "";
                dr[displayMember] = "";
                dt.Rows.InsertAt(dr, 0);
                dt.AcceptChanges();
            }

            cbo.ValueMember = valueMember;
            cbo.DisplayMember = displayMember;
            cbo.DataSource = dt;
        }

        #region dgvSet
        public static void SetInitGridView(DataGridView dgv, bool RowHeadersVisible = true)
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = RowHeadersVisible;
        }

        public static void AddGridTextColumn(
                            DataGridView dgv,
                            string headerText,
                            string dataPropertyName,
                            int colWidth = 100,
                            bool visibility = true,
                            DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = dataPropertyName;
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.DefaultCellStyle.Alignment = textAlign;
            col.Visible = visibility;
            col.ReadOnly = true;

            dgv.Columns.Add(col);
        }


        public static void AddGridCheckColumn(
                                DataGridView dgv,
                                string headerText,
                                string dataPropertyName,
                                int colWidth = 100,
                                bool visibility = true,
                                DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.Name = dataPropertyName;
            col.HeaderText = headerText;
            col.Width = colWidth;
            col.DefaultCellStyle.Alignment = textAlign;
            col.Visible = visibility;
            dgv.Columns.Add(col);
        }

        public static void AddGridImageColumn(
                                DataGridView dgv,
                                string headerText,
                                string dataPropertyName,
                                int colWidth = 100,
                                bool visibility = true,
                                DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewImageColumn col = new DataGridViewImageColumn();
            col.Name = dataPropertyName;
            col.HeaderText = headerText;
            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
            col.DataPropertyName = dataPropertyName;
            col.DefaultCellStyle.Alignment = textAlign;
            col.Visible = visibility;
            dgv.Columns.Add(col);
        }

        public static void AddGridLinkColumn(
                                DataGridView dgv,
                                string headerText,
                                string dataPropertyName,
                                int colWidth = 100,
                                bool visibility = true,
                                DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewLinkColumn col = new DataGridViewLinkColumn();
            col.Name = dataPropertyName;
            col.DefaultCellStyle.Alignment = textAlign;
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Visible = visibility;
            dgv.Columns.Add(col);
        }

        public static void AddGridButtonColumn(
                                DataGridView dgv,
                                string headerText,
                                string buttonText,
                                int colWidth = 100,
                                bool visibility = true,
                                DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.Name = headerText;
            col.Text = buttonText;
            col.DefaultCellStyle.Alignment = textAlign;
            col.HeaderText = headerText;
            col.Width = colWidth;
            col.Visible = visibility;
            dgv.Columns.Add(col);
        }


        #endregion

        public static Bitmap WebImageView(string URL)
        {
            try
            {
                WebClient Downloader = new WebClient();
                Stream ImageStream = Downloader.OpenRead(URL);
                Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
                return DownloadImage;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }

        }

        public static List<R> ControlFunc<T, R, Covert>(T pnl, Func<Covert, R> func) where T : Control where Covert : Control
        {
            List<R> r = new List<R>();
            foreach (Control ctrl in pnl.Controls)
            {
                if(ctrl is Covert temp)
                    r.Add(func(temp));
            }
            return r;
        }

        public static void ControlAction<T, Covert>(T pnl, Action<Covert> Action) where T : Control where Covert : Control
        {
            foreach (Control ctrl in pnl.Controls)
            {
                if (ctrl is Covert temp)
                    Action(temp);
            }
        }

        public static string ConvertToIntFromPrice(int price)
        {
            NumberFormatInfo NF = new CultureInfo("ko-KR", false).NumberFormat;
            return price.ToString("C", NF);
        }

        public static void OpenCreateForm<T>() where T : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    return;
                }
            }

            T frm = new T();
            frm.Show();
        }

        public static void OpenCreateForm<T>(Func<T> func) where T : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    return;
                }
            }
            T frm = func();
            frm.Show();
        }

        public static string MakingPK()        //앞 4글자 난수 + 뒤 6글자 분,초,밀리세컨드 합쳐서 PK  만드는 함수
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                int num = rnd.Next(0, 36);
                if (num < 10)
                {
                    sb.Append(num);
                }
                else
                    sb.Append((char)(num + 55));

            }
            sb.Append(DateTime.Now.ToString("mmssff"));
            return sb.ToString();
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static Image ByteToImage(byte[] data)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            return (Bitmap)(tc.ConvertFrom(data));
        }
    }
}

