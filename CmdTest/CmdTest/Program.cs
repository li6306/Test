using System;

namespace CmdTest
{
    class Program:ClassA
    {
        static void Main(string[] args)
        {
            
            int a,b =0;
            Console.Write("请选择功能:\n1:求和\n2.求差\n3.乘积\n4.除数;\n");
            
            try
            {
                int action =int.Parse(Console.ReadLine());
                Console.WriteLine("请输入第一个数");
                a =int.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二个数");
                b = int.Parse(Console.ReadLine());
                int result = 0;
                switch (action)
                {
                    case 1:
                        result = Sum(a, b);
                        break;
                    case 2:
                        result = Difference(a, b);
                        break;
                    case 3:
                        result = Multiply(a, b);
                        break;
                    case 4:
                            result = Except(a, b);
                        break;
                      default:
                          Console.WriteLine("输入错误!");
                          return;
                }

                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("程序异常"+e);
            }

            Console.ReadKey();
        }
        public void A() {
            Console.WriteLine("GitHub is Good！");
        }
    }
}
