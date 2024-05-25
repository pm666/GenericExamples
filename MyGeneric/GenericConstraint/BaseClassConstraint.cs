using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyGeneric.GenericConstraintExample
{

    /// <summary>
    /// 基类约束 示例
    /// </summary>
    internal class BaseClassConstraint
    {
        public static void MakeSound<T>(T tParameter) where T : Animal01
        {
            tParameter.MakeSound();
        }
    }

    // 基类约束 示例
    public class Animal01
    {
        // 定义一个Name属性
        public string Name { get; set; }
        // 定义一个Age属性
        public int Age { get; set; }
        // 定义一个MakeSound方法
        public virtual void MakeSound()
        {
            Console.WriteLine($"Animal makes a sound . Name: {this.Name}, Age: {this.Age}");
        }
    }

    // 定义一个Dog类，继承自Animal
    public class Dog01 : Animal01
    {
        // 重写MakeSound方法
        public override void MakeSound()
        {
            Console.WriteLine($"Dog barks . Name: {this.Name}, Age: {this.Age}");
        }
    }

    // 定义一个Cat类，继承自Animal
    public class Cat01 : Animal01
    {
        // 重写MakeSound方法
        public override void MakeSound()
        {
            Console.WriteLine($"Cat meows . Name: {this.Name}, Age: {this.Age}");
        }
    }
}
