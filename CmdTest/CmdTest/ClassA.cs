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

        public static int Sum(int n, int m)
        {
            return n + m;
        }
        protected static int Difference(int n, int m)
        {
            return n - m;
        }
        internal static int Multiply(int n, int m)
        {
            return n - m;
        }
        protected internal static int Except(int n, int m)
        {
            return n - m;
        }
    }
}
