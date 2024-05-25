using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric.GenericInterface
{
    public class SimpleGenericContainer<T> : IGenericContainer<T>
    {
        private List<T> items = new List<T>();

        public bool Contains(T item)
        {
            return items.Contains(item);
        }

        public void Add(T item)
        {   
            items.Add(item);
        }
    }

}
