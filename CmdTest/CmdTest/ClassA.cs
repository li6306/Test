using System;
using System.Collections.Generic;
using System.Text;

namespace CmdTest
{
    public class ClassA
    {
        public static void Error()
        {
            Console.WriteLine("Err");
        }

        protected static int Sum(int n, int m)
        {
            return n + m;
        }
    }
}
