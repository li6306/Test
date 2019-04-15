using System;

namespace CmdTest
{
    class Program : ClassA
    {
        static void Main(string[] args)
        {

            int a, b, action=0;
            var res = 1;
            do
            {
                do
                {
                    Console.Write("请选择功能:\n1:求和\n2.求差\n3.乘积\n4.除数\n5.求余;\n");
                    try
                    {
                        action = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        // ignored
                    }
                } while (action < 1 || action > 5);

                try
                {

                    Console.WriteLine("请输入第一个数");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入第二个数");
                    b = int.Parse(Console.ReadLine());
                    var result = 0;
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
                        case 5:
                            result = new ClassA().Remainder(a, b);
                            break;
                        default:
                            Console.WriteLine("输入错误!");
                            return;
                    }

                    Console.WriteLine("结果:" + result);
                    Console.WriteLine("是否继续?继续按任意键,退出请输入0。");
                    res = int.Parse(Console.ReadLine()) == 0 ? 0 : 1;
                }
                catch (Exception e)
                {
                    Console.WriteLine("程序异常" + e);
                }

            } while (res == 1);

        }

        public void A()
        {
            Console.WriteLine("GitHub is Good！");
        }
    }
}
