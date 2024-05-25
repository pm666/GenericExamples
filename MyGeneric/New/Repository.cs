using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric.New
{
    // 定义一个泛型接口
    interface IRepository<out T>
    {
        T GetById(int id);
    }
   
    // 实现泛型接口的泛型类
    class Repository<T> : IRepository<T> where T : Animal, new()
    {
        public T GetById(int id)
        {
            // 根据id从数据库中获取对象
            // 这里只是一个示例，实际实现可能会有数据库查询等操作
            //return new T { Name = "Animal" };

            return new T {  };
        }
    }



    interface IAnimalRepository<in T>
    {
        void Save(T animal);
    }
    class AnimalRepository<T> : IAnimalRepository<T> where T : Animal
    {
        public void Save(T animal)
        {
            // 将动物保存到数据库
            //Console.WriteLine($"Saving {animal.Name} to the database...");
            Console.WriteLine($"Saving {animal.GetType().ToString()} to the database...");
        }
    }
}
