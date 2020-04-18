using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    /// <summary>
    /// 一个类来满足不同的具体类型，做相同的事儿
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="S"></typeparam>
    /// <typeparam name="X"></typeparam>
    /// <typeparam name="Eleven"></typeparam>
    /// <typeparam name="老K"></typeparam>
    public class GenericClass<T>
        //, S, X, Eleven, 老K>
        //where T : People
        //where S : Chinese
        //where Eleven : Hubei
    {
        public T _T;
    }

    /// <summary>
    ///  一个接口来满足不同的具体类型的接口，做相同的事儿
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericInterface<T> //where T : People
    {
        T GetT(T t);//泛型类型的返回值
    }

    public class CommonClass
        //: GenericClass<int>//必须指定
        : IGenericInterface<int>//必须指定
    {
        public int GetT(int t)
        {
            throw new NotImplementedException();
        }
    }

    public class GenericClassChild<Eleven>
        //: GenericClass<Eleven>
        : GenericClass<int>, IGenericInterface<Eleven>
    {
        public Eleven GetT(Eleven t)
        {
            throw new NotImplementedException();
        }
    }

    public delegate void SayHi<T>(T t);//泛型委托
}
