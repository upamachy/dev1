using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class GenericDictionary<TKey,TValue>
    {
        public void Add(TKey key,TValue value)
        {

        }
    }
    public class GenericList<T>
    {
        public void Add(T book)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
         
        }
    }
}
