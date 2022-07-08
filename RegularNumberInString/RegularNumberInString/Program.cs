using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularNumberInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "提取123abc提取";    //我们抓取当前字符当中的123
            string result = System.Text.RegularExpressions.Regex.Replace(str, @"[^0-9]+", "");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
