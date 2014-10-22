using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class DivisorIsZero
    {
        private static void Main()
        {
            int dividend = 10;
            int divisor1 = 0;
            int divisor2 = 5;
            int DivideValue;

            try
            {
                DivideValue = dividend / divisor1;  
                System.Console.WriteLine("DivideValue={0}", DivideValue);//这一行将不会被执行。  
            }
            catch(Exception e)
            {
                //System.Console.WriteLine("传递过来的异常值为：{0}", e);
                DivideValue = dividend / divisor2;
                System.Console.WriteLine("DivideValue={0}", DivideValue);
            }
            finally
            {
                System.Console.WriteLine("无论是否发生异常，我都会显示。");
            }
            Console.ReadKey();
        }
    } 
}
