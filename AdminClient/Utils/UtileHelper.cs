using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient
{
    public class UtileHelper
    {

        #region Obj <<-->> Byte Helper
        /// <summary>
        /// Object의 Size
        /// </summary>
        /// <typeparam name="T">타입</typeparam>
        /// <returns></returns>
        public static int GetObjectBytesSize<T>()
        {
            return Marshal.SizeOf(default(T));
        }

        /// <summary>
        /// T -->> Byte형변환
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] ObjectToBytes<T>(T obj)
        {
            int datasize = Marshal.SizeOf(obj);
            IntPtr buff = Marshal.AllocHGlobal(datasize);
            Marshal.StructureToPtr(obj, buff, true);
            byte[] data = new byte[datasize];
            Marshal.Copy(buff, data, 0, datasize);
            Marshal.FreeHGlobal(buff);

            return data;
        }

        /// <summary>
        /// byte -->> T형변환
        /// </summary>
        /// <typeparam name="T">객체타입</typeparam>
        /// <param name="data">데이터</param>
        /// <returns></returns>
        public static T BytesToObject<T>(byte[] data)
        {
            IntPtr ptr = Marshal.AllocHGlobal(data.Length);
            Marshal.Copy(data, 0, ptr, data.Length);
            var obj = (T)Marshal.PtrToStructure(ptr, typeof(T));
            Marshal.FreeHGlobal(ptr);

            if (Marshal.SizeOf(obj) != data.Length)
            {
                return default(T);
            }

            return obj;
        }
        #endregion

        public static T GetCopyObj<T>(T data)
        {
            Type type = typeof(T);
            T result = (T)Activator.CreateInstance(type);
            foreach (PropertyInfo property in type.GetProperties())
            {
                property.SetValue(result, property.GetValue(data));
            }
            return result;
        }
    }
}
