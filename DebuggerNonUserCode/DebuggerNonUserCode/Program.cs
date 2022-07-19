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

        //DebuggerNonUserCode属性为了避免断点调试进入你不感兴趣的代码块中
        [DebuggerNonUserCode]
        private static void boo()
        {
            Console.WriteLine("Hi");
        }
    }
}
