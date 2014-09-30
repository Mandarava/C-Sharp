using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 密码验证程序
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string key = "admin";
            Console.WriteLine("请输入密码进入");
            string a=Console.ReadLine();
            while(!key.Equals(a))
            {
                if (count < 3)
                {
                    Console.WriteLine("密码输入错误，请重新输入！");
                    a = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("对不起，超过最多输入次数，取消服务！");
                    return;
                }
                    count++;
            }
            Console.WriteLine("欢迎进入本系统");
            Console.ReadKey();

        }
    }
}
