using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托方式求平方根
{
    class Program
    {
        delegate double ProcessDelegate(double param);

        static double Square(double param)
        {
            return param * param;
        }

        static double Sqrt(double param)
        {
            return Math.Sqrt(param);
        }
        static void Main(string[] args)
        {
            ProcessDelegate process;
            ProcessDelegate process2;
            Console.WriteLine("enter a number");
            double param = Convert.ToDouble(Console.ReadLine());
            process = new ProcessDelegate(Square);
            process2 = new ProcessDelegate(Sqrt);
            Console.WriteLine("平方结果如下：");
            Console.WriteLine(process(param));
            Console.WriteLine("平方根结果如下：");
            Console.WriteLine(process2(param));
            Console.ReadKey();
        }
    }
}

