using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入18位身份证号码：");
            string id = Console.ReadLine();
            while (id.Length != 18)
            {
                Console.WriteLine("输入错误，请再次输入正确的身份证号码\a");
                id = Console.ReadLine();
            }

            char[] birthday = new char[8];
            char[] sex = new char[1];
            id.CopyTo(6, birthday, 0, 8);
            id.CopyTo(16, sex, 0, 1);
            Console.Write("生日:");
            for (int i = 0; i < 4; i++)
                Console.Write(birthday[i]);
            Console.Write("年");
            for (int i = 4; i < 6; i++)
                Console.Write(birthday[i]);
            Console.Write("月");
            for (int i = 6; i < 8; i++)
                Console.Write(birthday[i]);
            Console.WriteLine("日");
            Console.Write("性别:");
            if (0 == sex[0] % 2)
            {
                Console.WriteLine("女");
            }
            else
            {
                Console.WriteLine("男");
            }
            Console.ReadKey();
        }
    }
}

