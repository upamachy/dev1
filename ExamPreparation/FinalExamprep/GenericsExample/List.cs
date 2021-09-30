using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class List
    {
        public void Add(int number)// Add the element
        {
            throw new NotImplementedException();

        }

        public int this [int index]
        {
            get { throw new NotImplementedException(); } // just return the of the given index
        }
    }
}
