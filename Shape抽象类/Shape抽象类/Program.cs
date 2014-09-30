using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape抽象类
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerim();
    }

    public class Rectangle:Shape
    {
        private double length, width;
        public Rectangle(double l,double w)
        {
            length = l;
            width = w;
        }
        public override double GetArea()
        {
            return length * width;
        }
        public override double GetPerim()
        {
            return 2 * (length + width);
        }
    }

    public class Circle:Shape
    {
        private double r;
        public Circle(double a )
        {
            r=a;
        }
        public override double GetArea()
        {
            return Math.PI*r*r;
        }
        public override double GetPerim()
        {
            return 2 * Math.PI * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, r;
            Console.WriteLine("请输入圆的半径");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入长方形的长");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入长方形的宽");
            width = Convert.ToDouble(Console.ReadLine());
            Circle c = new Circle(r);
            Rectangle R = new Rectangle(length,width);
            Console.WriteLine("圆的面积为：{0:0.000}",c.GetArea());
            Console.WriteLine("圆的周长为:{0:0.000}", c.GetPerim());
            Console.WriteLine("长方形的面积为：{0:0.000}", R.GetArea());
            Console.WriteLine("长方形的周长为：{0:0.000}",R.GetPerim());
            Console.ReadKey();
        }
    }
}
