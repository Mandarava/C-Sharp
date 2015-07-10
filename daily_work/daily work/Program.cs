using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Security.Policy;
using System.Text;

namespace daily_work
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory.ToString();			//文件路径为程序所在路径
            StreamReader sr = new StreamReader(path+"\\url.txt",Encoding.ASCII);//文件名为url.txt 网址以英文 ,分隔
            string str = sr.ReadToEnd().Trim();
            sr.Close();
            string[] url = str.Split(',');
            for (int i = 0; i < url.Length; i++)
            {
                url[i] = url[i].Replace("\r\n", "");
                System.Diagnostics.Process.Start(url[i]);
                Console.WriteLine(string.Format("opening {0}", url[i]));
            }
            Console.WriteLine("opening finished,press any key to close");
            Console.ReadKey();
        }
    }
}