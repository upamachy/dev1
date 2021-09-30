using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 9, 10, 23, 34, 78, 90 };

            var querySyntax = from obj in list
                              where obj > 2
                              select obj;
            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("............");

            var methodSyntax = list.Where(obj => obj > 2);
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
                            
                           
        }
    }
}
