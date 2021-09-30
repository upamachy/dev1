using System;

namespace Delegates
{
    class Program
    {
        delegate int Method(int a, int b);//How to create delegate(It's mainly hold a method signature).
        delegate string Info(string FName, string LName);
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Method m=Add;
            Method n = Formula;
            //Console.WriteLine(Add(x, y));
            Info I = InfoMethod;
            sum(m, x, y);
        }

        static int Add(int a,int b)
        {
            return a + b;
        }

        static void sum (Method m, int a ,int b)//This is how we can use the delegate
        {
            Console.WriteLine(m(a, b));  
        }

        static int Formula(int a,int b)
        {
            return a * 2 + b * 3;
        }

        static string InfoMethod(string f,string l)
        {
            return f + l;
        }
    }
}
