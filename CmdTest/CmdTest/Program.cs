using System;

namespace CmdTest
{
    class Program:ClassA
    {
        static void Main(string[] args)
        {
            string a,b = "";
            a = Console.ReadLine();
            b = Console.ReadLine();
            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
            {
                Console.WriteLine(a+b);
            }
            else
            {
                cons();
            }

            Console.ReadKey();
        }
        public void A() {
            Console.WriteLine("GitHub is Good！");
        }

        public int B(int m,int n) {
            return m + n;
        }
    }
}
