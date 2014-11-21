using System;
using System.Drawing;
using System.Windows.Forms;

namespace 正弦函数
{
    public partial class Form1 : Form
    {
        public Pen MyPen;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MyPen = new Pen(Color.Black, 1);
            var p1 = new Point(0, 270);
            var p2 = new Point(880, 270);
            var p3 = new Point(440, 0);
            var p4 = new Point(440, 600);
            g.DrawLine(MyPen, p1, p2);
            g.DrawLine(MyPen, p3, p4);
            string s;
            float b = 0.5f;
            for (int i = 440; i < 880; i = i + 90)
            {
                s = Convert.ToString(b);
                b += 0.5f;
                var p5 = new Point(i, 270);
                var p6 = new Point(i, 260);
                g.DrawLine(Pens.Black, p5, p6);
                g.DrawString(s + "π", Font, Brushes.Black, i + 90, 275);
            }
            b = 0.5f;
            for (int i = 440; i > 0; i = i - 90)
            {
                s = Convert.ToString(b);
                b += 0.5f;
                var p7 = new Point(i, 270);
                var p8 = new Point(i, 260);
                g.DrawLine(Pens.Black, p7, p8);
                g.DrawString("-" + s + "π", Font, Brushes.Black, i - 110, 275);
            }
            float a = 0f;
            for (int i = 270; i < 600; i = i + 45)
            {
                s = Convert.ToString(a);
                a -= 0.5f;
                var p9 = new Point(440, i);
                var p10 = new Point(450, i);
                g.DrawLine(Pens.Black, p9, p10);
                g.DrawString(s, Font, Brushes.Black, 405, i);
            }
            a = 0;
            for (int i = 270; i > 0; i = i - 45)
            {
                s = Convert.ToString(a);
                a += 0.5f;
                var p11 = new Point(440, i);
                var p12 = new Point(450, i);
                g.DrawLine(Pens.Black, p11, p12);
                g.DrawString(s, Font, Brushes.Black, 405, i);
            }
            MyPen = new Pen(Color.Red, 1);

            for (float x = 0; x < 1150; x = x + 0.002f)
            {
                float x1, x2, y1, y2;
                x1 = x;
                x2 = x + 0.001f;
                y1 = (float) Math.Sin((x1 - 270)*Math.PI/180)*90 + 270.0f;
                y2 = (float) Math.Sin((x2 - 270)*Math.PI/180)*90 + 270.0f;
                var p13 = new PointF(x1, y1);
                var p14 = new PointF(x2, y2);
                g.DrawLine(MyPen, x1 - 10, y1, x2 - 10, y2); //由于π和数值之间转化有误差  减去10消除偏移量                
            }
        }
    }
}