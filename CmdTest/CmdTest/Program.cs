using System;

namespace CmdTest
{
    class Program:ClassA
    {
        static void Main(string[] args)
        {
            cons();
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
