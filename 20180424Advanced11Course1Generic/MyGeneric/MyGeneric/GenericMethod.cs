using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    /// <summary>
    /// 泛型方法
    /// </summary>
    public class GenericMethod
    {
        /// <summary>
        /// 2.0推出的新语法
        /// 泛型方法解决用一个方法，满足不同参数类型；做相同的事儿
        /// 没有写死参数类型，调用的时候才指定的类型
        /// 单身狗：小西瓜
        /// 章子怡  范冰冰  凤姐
        /// 延迟声明：把参数类型的声明推迟到调用
        /// 
        /// 推迟一切可以推迟的~~  延迟思想
        /// 
        /// 
        /// 不是语法糖，而是2.0由框架升级提供的功能
        /// 需要编译器支持+JIT支持
        /// </summary>
        /// <typeparam name="T">T/S 不要用关键字  也不要跟别的类型冲突 </typeparam>
        /// <param name="tParameter"></param>
        public static void Show<T>(T tParameter)
        {
            Console.WriteLine("This is {0},parameter={1},type={2}",
                typeof(GenericMethod), tParameter.GetType().Name, tParameter.ToString());
        }


        public static void ShowObject(object oParameter)
        {
            Console.WriteLine("This is {0},parameter={1},type={2}",
                typeof(GenericMethod), oParameter.GetType().Name, oParameter);
        }
    }
}
