using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        private string sOper;
        private bool bDot;
        private bool bEqu;
        private double dblAcc, dblDes, dblResult;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void bt_Click(object sender, EventArgs e)
        {
            String sText;
            Button bClick = (Button) sender;
            sText = bClick.Text;
            switch (sText)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    if (bEqu) richTextBox1.Text = "";             //如果已经执行过一次计算，那么再次输入数字时，应清空textBox1
                    bEqu = false;
                    richTextBox1.Text =richTextBox1.Text + sText; // 将输入的字符累加
                    break;
                case "+":
                case "-":
                case "*":
                case "/":
                    dblAcc = Convert.ToDouble(richTextBox1.Text);
                    richTextBox1.Text = "";
                    sOper = sText;
                    break;
                case "=":
                    bDot = false;
                    if (!bEqu) dblDes = Convert.ToDouble(richTextBox1.Text);  //如果本次对“=”的点击是连续的第二次点击，那么操作数不变
                    bEqu = true;
                    switch (sOper)
                    {
                        case "+": dblResult = dblAcc + dblDes; break;
                        case "-": dblResult = dblAcc - dblDes; break;
                        case "*": dblResult = dblAcc * dblDes; break;
                        case "/": dblResult = dblAcc / dblDes; break;
                    }
                    richTextBox1.Text = dblResult.ToString();
                    dblAcc = dblResult;
                    //将计算结果赋给被操作数，以便执行连续的第二次操作
                    break;
                case "CE":
                    richTextBox1.Text = "";//清除文本框内容
                    break;
            }
        }
    }
}
