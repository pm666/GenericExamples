using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric.GenericConstraint01
{
    // 定义一个接口约束
    internal class InterfaceConstraint01
    {
        public static void PlaySports<T>(T tParameter) where T : ISports01
        {
            tParameter.Play();
        }
    }

    // 定义一个ISports01接口
    public interface ISports01
    {
        void Play();
    }

    // 定义一个Football类，实现ISports01接口
    public class Football : ISports01
    {
        public void Play()
        {
            Console.WriteLine("Playing football");
        }
    }

    // 定义一个Tennis类，实现ISports01接口
    public class Tennis : ISports01
    {
        public void Play()
        {
            Console.WriteLine("Playing tennis");
        }
    }
}
