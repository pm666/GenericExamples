using MyGeneric.Extension;
using MyGeneric.GenericClass;
using MyGeneric.GenericConstraint01;
using MyGeneric.GenericConstraintExample;
using MyGeneric.GenericInterface;
using System;
using System.Collections.Generic;

namespace MyGeneric
{
    class Program
    {


        static void Main(string[] args)
        {
            //1.泛型的引入,
            //2.泛型的声明
            //3.泛型的特点+原理
            //4.泛型的优势 ,核心设计
            //5.泛型方法，泛型类
            //6.泛型接口，泛型委托
            //7.泛型约束，泛型缓存
            //8.协变，逆变  


            Console.WriteLine("************泛型***************");
            try
            {

                int iValue = 123;
                string sValue = "456";
                DateTime dtValue = DateTime.Now;
                object oValue = "678";

                #region 一、泛型的引入,优势

                //1.泛型---泛：宽泛的--不确定的；   型：类型-----不确定的类型
                //2.无处不在的；
                //3.调用普通方法的时候，参数类型在声明的时候就确定了，调用按照类型传递参数即可
                //  a.如果有100个类型----100个方法？--很累
                //  b.有没有能够做一个方法可以能够满足不同类型的需求呢？
                //4.Object类型作为参数---可以传递不同的类型进去；
                //  a.任何子类出现的地方都可以让父类来代替
                //  b.万物皆对象---任何一个类型都是继承自Object

                //5.问题：
                //  a.性能问题--装箱拆箱---在C#语法中，按照声明时决定类型的ShowInt
                //  b.类型安全问题---后面说

                //6.有没有既性能好，也能够多种类型的方法呢---泛型方法
                //  a.声明--多了尖括号+  占位符T
                //  b.调用--也需要多一个尖括号，尖括号中指定的类型要和传递的参数类型一致
                //  c.如果可以通过参数推导出类型---尖括号可以省略

                //7.泛型方法---做到了性能高---可以一个方法满足不同类型的需求；

                #endregion

                #region 泛型方法和普通方法的对比
                //{
                //    CommonMethod.ShowInt(iValue);
                //    CommonMethod.ShowString(sValue);
                //    CommonMethod.ShowDateTime(dtValue);
                //    Console.WriteLine("***************************");
                //    CommonMethod.ShowObject(oValue);

                //    ////Object类型作为参数---可以传递不同的类型进去； 
                //    CommonMethod.ShowObject(iValue);
                //    CommonMethod.ShowObject(sValue);
                //    CommonMethod.ShowObject(dtValue);

                //    Console.WriteLine("***************************");
                //    CommonMethod.Show(iValue); //不允许--如果可以通过参数推导出类型---尖括号可以省略
                //    CommonMethod.Show(sValue);// 省略类型--语法糖
                //    CommonMethod.Show<DateTime>(dtValue);
                //    CommonMethod.Show<object>(oValue);
                //    // 性能问题
                //    Monitor.Show();
                //}
                #endregion

                #region 二、泛型的声明--设计思想 


                {
                    //1.泛型方法：--在方法名称后面多了一个尖括号，尖括号中有占位符
                    //2.延迟声明：声明的时候，只是给一个占位符T,T是什么类型？不知道什么类型---调用的时候，指定你是什么，调用（使用）的时候，必须要确定类型，你说什么就是什么；

                    //3.占位符：T---类型参数---类型变量
                    //4.类型参数当做方法的参数的时候，明确参数类型
                }
                #endregion

                #region 三、泛型的特点+原理--在底层如何支持

                //1.在高级语言中，定义的泛型T，在计算机执行的执行的时候，一定要是一个具体的类型；
                //2.在底层如何支持？---在底层看到 生成的结果是：List`1[T]  Dictionary`2[TKey,TValue]
                //3.在底层---生成了带有`1   `2  `3....`4.`5.....
                //4.编译器必须要能够支持泛型---
                //5.CLR 运行时环境也必须要支持泛型
                //6.泛型当然是框架的升级支持的---- 泛型是语法糖---泛型不是语法糖---由框架的升级支持的；
                //7.语法糖：编译器提供的便捷功能--.NETFrameowork2.0时代支持的 
                {
                    //Console.WriteLine(typeof(int));
                    //Console.WriteLine(typeof(Dictionary<,>));
                }
                #endregion

                #region 五、泛型的多种应用
                ////1.泛型方法----可以一个方法满足不同类型的需求
                //{
                //    CommonMethod.Show(iValue); //如果可以通过参数推导出类型---尖括号可以省略
                //}
                ////2.泛型接口----可以一个接口满足不同类型的需求---尖括号+占位符
                //{

                //    //示例：1
                //    SimpleGenericContainer<int> sgc = new SimpleGenericContainer<int>();
                //    sgc.Add(1);
                //    sgc.Add(2);
                //    sgc.Add(3);
                //    sgc.Add(4);
                //    sgc.Add(5);
                //    sgc.Contains(5);
                //    Console.WriteLine($"SimpleGenericContainer示例包含5：{sgc.Contains(5).ToString()}");


                //    //示例：2
                //    SimpleGenericContainer<string> sgc2 = new SimpleGenericContainer<string>();
                //    sgc2.Add("1");
                //    sgc2.Add("2");
                //    sgc2.Add("3");
                //    sgc2.Add("4");
                //    sgc2.Add("5");


                //    Console.WriteLine($"SimpleGenericContainer示例包含字符3：{sgc2.Contains("3").ToString()}");
                //    Console.WriteLine($"SimpleGenericContainer示例包含字符6：{sgc2.Contains("6").ToString()}");

                //}
                ////3.泛型类------可以一个类型满足不同类型的需求---尖括号+占位符
                //{
                //    //示例：1
                //    StackArray<int> intStack = new StackArray<int>(10);
                //    intStack.Push(5);
                //    intStack.Push(10);
                //    Console.WriteLine($"intStack.Pop():{intStack.Pop()}");// 输出：10
                //    Console.WriteLine($"intStack.Pop():{intStack.Pop()}");// 输出：5
                //    //Console.WriteLine($"intStack.Pop():{intStack.Pop()}");// 输出：异常信息

                //    //示例：2

                //    StackArray<string> strStack = new StackArray<string>(10);
                //    strStack.Push("第一字符串");
                //    strStack.Push("第二字符串");
                //    Console.WriteLine($"intStack.Pop():{strStack.Pop()}");// 输出：第二字符串
                //    Console.WriteLine($"intStack.Pop():{strStack.Pop()}");// 输出：第一字符串
                //    //Console.WriteLine($"intStack.Pop():{strStack.Pop()}");// 输出：异常信息

                //}
                //4.泛型委托----可以一个委托满足不同类型的需求

                //{
                //    // 创建一个泛型委托，接受一个整数参数并返回一个整数
                //    GenericDelegate<int> intDelegate = x => x * 2;

                //    // 创建一个泛型委托，接受一个字符串参数并返回一个字符串
                //    GenericDelegate<string> stringDelegate = x => x.ToUpper();

                //    // 使用泛型委托处理整数
                //    int resultInt = intDelegate(5);
                //    Console.WriteLine("Result of intDelegate: " + resultInt);

                //    // 使用泛型委托处理字符串
                //    string resultString = stringDelegate("hello");
                //    Console.WriteLine("Result of stringDelegate: " + resultString);
                //}

                #endregion
                //六、泛型约束--要有真正的自由--就必须要有约束--开车---交通规则---红绿灯
                //1.Object类型安全问题--就是代码就可能存在隐患，但是编译器检测不到；
                //2.如何避免类型安全问题--泛型--不存在类型安全问题
                #region 泛型基礎描述

                //1.基类约束
                //  泛型约束：要么不让你进来，如果让你进来，就一定是没有问题




                //2接口约束：
                //    a.把这个T 当做ISports
                //    b.就只能传递ISports 这个接口或者是实现过这个接口的类
                //    c.就可以增加功能，可以获取新的功能


                //3引用类型约束
                //   a.就只能传递类型进来

                //4.值类型约束
                //   a.就只能传递值类型进来

                //5.无参数构造函数约束
                //  b.必须有一个无参数构造函数才能当做参数传入

                //6.枚举约束
                //   a.必须是一个枚举类型才能传入
                #endregion
                {

                    //People people = new People()
                    //{
                    //    Id = 123,
                    //    Name = "闻"
                    //};
                    //GenericConstraint.ShowObject(people);
                    //Chinese chinese = new Chinese()
                    //{
                    //    Id = 234,
                    //    Name = "Richard"
                    //};

                    //Japanese japanese = new Japanese()
                    //{
                    //    Id = 345,
                    //    Name = "苍老师"
                    //};


                    #region 01.基类约束
                    //Animal01 animal = new Animal01 { Name = "Generic Animal", Age = 5 };
                    //Dog01 dog = new Dog01 { Name = "Buddy", Age = 2 };
                    //Cat01 cat = new Cat01 { Name = "Whiskers", Age = 3 };

                    //BaseClassConstraint.MakeSound(animal);
                    //BaseClassConstraint.MakeSound(dog);
                    //BaseClassConstraint.MakeSound(cat);
                    #endregion

                    //接口约束--
                    #region 02.接口约束
                    //Football football = new Football();
                    //Tennis tennis = new Tennis();

                    //InterfaceConstraint01.PlaySports(football);
                    //InterfaceConstraint01.PlaySports(tennis);
                    #endregion
                    ////引用类型约束
                    {
                        //GenericConstraint.ShowClass<People>(people);
                        //GenericConstraint.ShowClass<Chinese>(chinese);
                        //GenericConstraint.ShowClass<Japanese>(japanese);
                        //GenericConstraint.ShowClass<int>(iValue); //因为Int 是结构--值类型
                    }

                    ////值类型约束
                    //{
                    //    //GenericConstraint.ShowStruct<People>(people); //应用类型--不行
                    //    //GenericConstraint.ShowStruct<Chinese>(chinese);//应用类型--不行
                    //    //GenericConstraint.ShowStruct<Japanese>(japanese);//应用类型--不行
                    //    GenericConstraint.ShowStruct<int>(iValue); //因为Int  是Struct
                    //    GenericConstraint.ShowStruct<DateTime>(dtValue); //因为DateTime  是Struct
                    //}

                    //无参数构造函数约束
                    //{
                    //    GenericConstraint.ShowNew<People>(people);
                    //}

                    ////还有吗？  枚举约束
                    //{
                    //    //GenericConstraint.ShowEnum<People>(people);
                    //    GenericConstraint.ShowEnum<Enum>(UserType.Normal);
                    //}

                    //{
                    //    GenericConstraint.ShowParent<Chinese, People>(chinese, people);
                    //    //GenericConstraint.ShowParent<People, Chinese>(people, chinese);
                    //} 
                }

                //七、泛型缓存-泛型类
                //应用：在后面 手写ORM的是时候会用到；
                {
                    //GenericCacheTest.Show();
                }

                //八、泛型的协变/逆变 是一种高级约束，
                //是为了规避  1.把子类做参数，却把父类当参数传入；
                //            2.把子类做返回值，却返回的时候，返回了一个父类
                //{
                //    ContravariantCovariance.Show();
                //}

                //{
                //    ICustomerListOut<Animal> customerListOut = new CustomerListOut<Animal>();
                //    ICustomerListOut<Animal> customerListOut1 = new CustomerListOut<Cat>();
                //    //左边是Animal  右边是：Cat
                //    //customerListOut1.Show(new Animal());
                //    //customerListOut1.Show(new Cat());
                //    customerListOut1.Get();
                //}

                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}