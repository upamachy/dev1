using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
     public static class Extention
    {
        public static int Add(this int a,int b)
        {
            return a + b;
        }
    }
}
