using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    public class Constraint
    {
        /// <summary>
        /// 泛型：不同的参数类型都能进来；任何类型都能过来，你知道我是谁?
        /// 没有约束，也就没有自由
        /// 泛型约束--基类约束（不能是sealed）：
        /// 1 可以使用基类的一切属性方法---权利
        /// 2  强制保证T一定是People或者People的子类---义务
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        public static void Show<T>(T tParameter)
            where T : People, ISports, IWork, new()
        {
            //Console.WriteLine("This is {0},parameter={1},type={2}",
            //    typeof(GenericMethod), tParameter.GetType().Name, tParameter.ToString());

            Console.WriteLine($"{tParameter.Id}_{tParameter.Name}");
            tParameter.Hi();
            //tParameter.Majiang();
            tParameter.Pingpang();
            tParameter.Work();
        }
        public static void ShowBase(People tParameter)//因为约束可以叠加  更灵活
        {
            Console.WriteLine($"{tParameter.Id}_{tParameter.Name}");
            tParameter.Hi();
        }


        //为啥不直接用基类
        //int？

        public static T Get<T>(T t)
            //where T : ISports//接口约束
            //where T : class//引用类型约束
            //where T : struct//值类型约束
            where T : new()//无参数构造函数约束
        {
            //t.Pingpang();
            //T tNew = null;
            //T tNew = default(T);//会根据T的不同  赋予默认值
            T tNew = new T();
            return t;
        }
    }
}
