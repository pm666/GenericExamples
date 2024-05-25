using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric.GenericInterface
{
    public interface IGenericContainer<T>
    {
        bool Contains(T item);
        void Add(T item);
    }

    public delegate T GenericDelegate<T>(T input);
}
