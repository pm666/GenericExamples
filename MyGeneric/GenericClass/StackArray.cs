using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric.GenericClass
{
    public class StackArray<T>
    {
        private T[] items;
        private int top;

        public StackArray(int initialCapacity)
        {
            if (initialCapacity <= 0)
            {
                throw new ArgumentOutOfRangeException("初始参数必须大于零.");
            }
            items = new T[initialCapacity];
            top = -1;
        }

        public void Push(T item)
        {
            if (top == items.Length - 1)
            {

                Console.WriteLine($"堆栈已空");
            }
            items[++top] = item;
        }

        public T Pop()
        {
            if (top == -1)
            {
                Console.WriteLine($"堆栈已空");
            }
            return items[top--];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }

}
