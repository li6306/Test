using System;

namespace CmdTest
{
    class Program:ClassA
    {
        static void Main(string[] args)
        {
            string a,b = "";
            Console.WriteLine("请输入第一个数");
            a = Console.ReadLine();
            Console.WriteLine("请输入第二个数");
            b = Console.ReadLine();
            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
            {
                Console.WriteLine("和:"+Sum(int.Parse(a), int.Parse(b)));
                
            }
            else
            {
                Error();
            }

            Console.ReadKey();
        }
        public void A() {
            Console.WriteLine("GitHub is Good！");
        }
    }
}
