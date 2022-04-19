using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvsI
{
    public class NonStaticDemo
    {
        public static string NoInstance()
        {
            return "I dont need no instantiation!";
        }
    }
    public class StaticVsInstance
    {
        static string AnotherNoInstance()
        {
            return "This does not need an instance either.";
        }
        static void Main()
        {
            Console.WriteLine($"Says the NonStaticDemo class: {NonStaticDemo.NoInstance()}");
            Console.WriteLine($"Says the StaticVsInstance class: {StaticVsInstance.AnotherNoInstance()}");
            Console.Read();
        }
    }
}