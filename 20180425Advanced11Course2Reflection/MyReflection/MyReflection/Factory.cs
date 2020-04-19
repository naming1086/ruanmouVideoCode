using Ruanmou.DB.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyReflection
{
    /// <summary>
    /// 创建对象
    /// </summary>
    public  class Factory
    {
        private static string IDBHelperConfig = ConfigurationManager.AppSettings["IDBHelperConfig"];
        private static string DllName = IDBHelperConfig.Split(',')[1];
        private static string TypeName = IDBHelperConfig.Split(',')[0];


        public static IDBHelper CreateHelper()//1 2
        {
            Assembly assembly = Assembly.Load(DllName);//1 加载dll
            Type type = assembly.GetType(TypeName);//2 获取类型信息
            object oDBHelper = Activator.CreateInstance(type);//3 创建对象
            IDBHelper iDBHelper = (IDBHelper)oDBHelper;//4 类型转换
            return iDBHelper;
        }
    }
}
