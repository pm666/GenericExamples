using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{

    public interface ibar<in T>
    {
        void bar(T t);
    }



    public interface GenericInterfac<T>
    {
        public T Show();
    }


    //T:类型参数一定要为T，尽量不要使用关键字
    //尖括号中可以有多个类型参数
    public class GenericClass<T, S, X, Richard>
    {
        public void Show(T t)
        {

        }
    }

    public abstract class GenericAbstractClass<T>
    {
        public void Show(T t)
        {

        }
    }

    public class ChildClass : GenericAbstractClass<int> //为什么不行？
    {

    }

    public class ChildClass1<S> : GenericAbstractClass<S> //可以--为什么可以？
    {

    }

    public class ChildClass2<S> //可以--为什么可以？
    {
        public S Show()
        {
            //return new S();
            return default(S);
        }

        public S Show2(S s)
        {
            return s;
        }
    }

    public class ChildClass3 : GenericInterfac<int>
    {
        public int Show()
        {
            throw new NotImplementedException();
        }
    }


    public delegate T Genericdelegate<T>();



}



