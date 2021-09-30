using System;

namespace FuncAndAction
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Func<int, int, int> m = Add;//last one is return type
            Action<int, int> n = Test;// here return type is void so  no need to mention
            //Console.WriteLine(Add(x, y));
            sum(Add, x, y);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void sum(Func<int,int,int> m, int a, int b)//This is how we can use the delegate
        {
            Console.WriteLine(m(a, b));
        }

        static void Test(int a,int b)
        {

        }
       
        
    }
}
