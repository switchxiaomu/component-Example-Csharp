using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggerNonUserCode
{
    class Program
    {
        static void Main(string[] args)
        {
            foo();
            Console.ReadKey();
        }

        private static void foo()
        {
            Console.WriteLine("Hello");
            boo();
        }

        //DebuggerNonUserCode属性为了避免断点调试进入你不感兴趣的代码块中，堆栈中心显示为外部代码
        //[DebuggerNonUserCode]
        //DebuggerHidden属性甚至堆栈中都不显示
        [DebuggerHidden]
        private static void boo()
        {
            Console.WriteLine("Hi");
        }
    }
}
