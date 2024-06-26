﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    /// <summary>
    /// 泛型约束
    /// </summary>
    public class GenericConstraint
    {
        public static void ShowObject(object oParameter)
        {
            //Console.WriteLine("This is {0},parameter={1},type={2}",
            //    typeof(GenericConstraint), oParameter.GetType().Name, oParameter);  
            //传递一个实体对象：操作字段和数据 
            //问题：
            //1.无法去属性字段--因为oParameter是Object； C#是强类型语言，编译时决定参数是什么类型；
            //2.强制转换
            //Console.WriteLine($"People.Id={oParameter.Id}");
            //Console.WriteLine($"People.Name={oParameter.Name}"); 
            People people = (People)oParameter;
            Console.WriteLine($"People.Id={people.Id}");
            Console.WriteLine($"People.Name={people.Name}");

        }

        /// <summary>
        /// 1.基类约束
        ///   a.就是把类型参数当做People
        ///   b.调用---就可以传递Popple或者People的子类型
        ///   c.泛型约束：要么不让你进来，如果让你进来，就一定是没有问题
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        public static void ShowBase<T>(T tParameter) where T : People //    ,ISports
        {
            Console.WriteLine($"People.Id={tParameter.Id}");
            Console.WriteLine($"People.Name={tParameter.Name}");
            //tParameter.Pingpang();
        }


        /// <summary>
        /// 接口约束：
        ///   a.把这个T 当做ISports
        ///   b.就只能传递ISports 这个接口或者是实现过这个接口的类
        ///   c.就可以增加功能，可以获取新的功能
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        public static void ShowInterface<T>(T tParameter) where T : ISports
        {
            tParameter.Pingpang();
        }


        /// <summary>
        /// 引用类型约束
        ///    a.就只能传递类型进来
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        public static void ShowClass<T>(T tParameter) where T : class
        {
            //T t = new T(); //因为T 可能没有无参数构造构造函数
        }

        /// <summary>
        /// 值类型约束
        ///    a.就只能传递值类型进来
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        public static void ShowStruct<T>(T tParameter) where T : struct
        {
            T t = new T();
        }

        /// <summary>
        /// 无参数构造函数约束
        ///    a.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        public static void ShowNew<T>(T tParameter) where T : new()
        {
            T t = new T();
        }

        /// <summary>
        /// 枚举约束
        ///     a.必须是个枚举才能够传递进来
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        public static void ShowEnum<T>(T tParameter) where T : Enum
        {
             
        }

        /// <summary>
        /// 要么是同一个类型，要么是父子级关系
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="S"></typeparam>
        /// <param name="tParameter"></param>
        /// <param name="sParameter"></param>
        public static void ShowParent<T,S>(T tParameter,S sParameter) where T : S
        {

        }

        public static void ShowTest<T, S>(T tParameter, S sParameter) where T:class where  S:struct
        {

        }

    }
}
