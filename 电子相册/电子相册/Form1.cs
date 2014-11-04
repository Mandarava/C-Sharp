using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace 电子相册
{
    public partial class Form1 : Form
    {
        private int PicNo; //定义数据成员变量PicNo，表示显示图片号
        private bool bStatus=false;
        [DllImport("winmm.dll")]
        public static extern bool PlaySound(string pszSound, int hmod, int fdwSound);
        public string path = Application.StartupPath + @"\1.wav";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicNo = 0;
            timer1.Enabled = false;// 设置定时器不可用	
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "位图文件|*.bmp|GIF文件|*.gif|JPEG文件|*.jpg|PNG文件|*.png";
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.ShowDialog();
            foreach (string s in openFileDialog1.FileNames)
            {
                listBox1.Items.Add(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            bStatus = !bStatus;
            if (bStatus)
            {
                timer1.Enabled = true;
                button2.Text = "暂停";
                PlaySound(path, 0, 9);
            }
            else
            {                
                timer1.Enabled = false;
                button2.Text = "浏览";
                PlaySound(@"G:\0.wav", 0, 9);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = PicNo;
            string s = listBox1.SelectedItem.ToString();// 得到某一要显示图片的路径
            pictureBox1.Image = Image.FromFile(s);   // 加载图片
            PicNo = PicNo + 1;// 为得到下一张图片做准备
            if (PicNo >= listBox1.Items.Count)
                // 如果是最后一张，则转为第一张
                PicNo = 0;
        }




    }
}
