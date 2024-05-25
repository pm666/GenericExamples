using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric.New
{
    using System;

    // 定义一个基类 Animal
    public class Animal
    {
        // Animal类的属性
        public string Name { get; set; }
        public int Age { get; set; }

        // Animal类的方法
        public void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // 定义另一个基类 Pet
    public class Pet : Animal
    {
        // Pet类的额外属性
        public string Owner { get; set; }

        // Pet类的方法
        public void BeFriendly()
        {
            Console.WriteLine("Pet is friendly");
        }
    }

    // 定义一个派生类 Dog，继承自 Pet
    public class Dog : Pet
    {
        // Dog类的额外属性
        public string Breed { get; set; }

        // Dog类的方法
        public void Bark()
        {
            Console.WriteLine("Dog barks");
        }
    }


}
