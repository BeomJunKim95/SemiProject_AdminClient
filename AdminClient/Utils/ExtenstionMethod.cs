using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    public static class ExtenstionMethod
    {
        #region DataTable
        public static DataRow insertRow(this DataTable dt)
        {
            DataRow row= dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            return row;
        }
        #endregion

        #region SqlCommand
        public static void setParameters(this SqlCommand cmd, SqlDbType type, string ParamName, string ParamValue)
        {
            cmd.Parameters.Add(ParamName, type);
            cmd.Parameters[ParamName].Value = ParamValue;
        }
        #endregion

        #region DataGridView
        public static void RefreshGridView(this DataGridView dgv)
        {
            if (dgv.DataSource != null) {
                object data  = dgv.DataSource;
                dgv.DataSource = null;
                dgv.DataSource = data;
            }
        }
        #endregion

        #region Form
        public static void OpenCreateForm<T>(this Form Parent , bool IsParentMDI = false) where T : Form, new()
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
            if (IsParentMDI)
            {
                frm.MdiParent = Parent;
            }
            else
            {
                frm.Owner = Parent;
            }
            frm.Show();
        }

        public static void OpenCreateForm<T>(this Form Parent, Func<T> func , bool IsParentMDI = false) where T : Form, new()
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
            if (IsParentMDI)
            {
                frm.MdiParent = Parent;
            }
            else
            {
                frm.Owner = Parent;
            }
            frm.Show();
        }

        public static void OpenCreateForm(this Form Parent, Form Fm, Type type, bool IsParentMDI = false)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == type)
                {
                    form.Activate();
                    return;
                }
            }
            if (IsParentMDI)
            {
                Fm.MdiParent = Parent;
            }
            else
            {
                Fm.Owner = Parent;
            }
            Fm.Show();
        }
        #endregion

        #region string
        public static string Left(this string target, int length)
        {
            if (length <= target.Length)
            {
                return target.Substring(0, length);
            }
            return target;
        }

        public static string Right(this string target, int length)
        {
            if (length <= target.Length)
            {
                return target.Substring(target.Length - length);
            }
            return target;
        }
        #endregion

        #region TextBox
        public static string ToTrimText(this TextBox target)
        {
            
            return target.Text.Trim();
        }

        public static int Toint(this TextBox target)
        {
            return Convert.ToInt32(target.ToTrimText());
        }
        #endregion
    }
}
