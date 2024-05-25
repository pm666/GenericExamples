using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    
    public class CommonMethod
    {
        /// <summary>
        /// 打印个int值
        /// </summary>
        /// <param name="iParameter"></param>
        public static void ShowInt(int iParameter)
        {
            Console.WriteLine($"ShowInt  {typeof(CommonMethod).FullName},parameter={iParameter.GetType().Name},type={iParameter}");
        } 
        /// <summary>
        /// 打印个string值
        /// </summary>
        /// <param name="sParameter"></param>
        public static void ShowString(string sParameter)
        {
            Console.WriteLine($"ShowString  {typeof(CommonMethod).Name},parameter={sParameter.GetType().Name},type={sParameter}"); 
        } 
        /// <summary>
        /// 打印个DateTime值
        /// </summary>
        /// <param name="oParameter"></param>
        public static void ShowDateTime(DateTime dtParameter)
        {
            Console.WriteLine($"ShowDateTime {typeof(CommonMethod).Name},parameter={dtParameter.GetType().Name},type={dtParameter}");
        }

        /// <summary>
        /// object  :引用类型
        /// </summary>
        /// <param name="oParameter"></param>
        public static void ShowObject(object oParameter)
        {
            Console.WriteLine($"对象类型  {typeof(CommonMethod).Name},parameter={oParameter.GetType().Name},type={oParameter}");
        }


        /// <summary>
        /// 泛型方法
        /// </summary>
        /// <typeparam name="T">类型变量  类型参数</typeparam>
        /// <param name="tParameter"></param>
        public static void Show<T>(T tParameter)
        {
            Console.WriteLine($"泛型  {typeof(CommonMethod).Name},parameter={tParameter.GetType().Name},type={tParameter}");
        }
    }
}
