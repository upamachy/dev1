using System;

namespace GenericsExample
{
    public class utilities<T> where T : IComparable,new()
    {
        //where T:IComparable
        //where T:product
        //where T:struct
        //where T:class
        //where T:new()
        public int max(int a,int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        public T Max(T a,T b) 
        {
            return a.CompareTo(b)>0 ? a : b;
        }

        //public T Max<T>(T a, T b) where T : IComparable
        //{
        //    return a.CompareTo(b) > 0 ? a : b;
        //}


    }
}
