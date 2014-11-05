using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace 电子相册
{
    public partial class Form1 : Form
    {
        private int PicNo; //定义数据成员变量PicNo，表示显示图片号
        private bool bStatus;

        public string path = Application.StartupPath + @"\1.wav";

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("winmm.dll")]
        public static extern bool PlaySound(string pszSound, int hmod, int fdwSound);

        private void Form1_Load(object sender, EventArgs e)
        {
            PicNo = 0;
            timer1.Enabled = false; // 设置定时器不可用	
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("请打开文件!");
                openFile();
            }

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
                PlaySound("0", 0, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = PicNo;
            string s = listBox1.SelectedItem.ToString(); // 得到某一要显示图片的路径
            pictureBox1.Image = Image.FromFile(s); // 加载图片
            PicNo = PicNo + 1; // 为得到下一张图片做准备
            if (PicNo >= listBox1.Items.Count)
            {
                // 如果是最后一张，则转为第一张
                PicNo = 0;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 适应ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(870, 522);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            拉伸ToolStripMenuItem.Checked = false;
            普通ToolStripMenuItem.Checked = false;
            适应ToolStripMenuItem.Checked = true;
            普通ToolStripMenuItem.CheckState = CheckState.Unchecked;
            适应ToolStripMenuItem.CheckState = CheckState.Checked;
            拉伸ToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void 拉伸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(870, 522);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            拉伸ToolStripMenuItem.Checked = true;
            普通ToolStripMenuItem.Checked = false;
            适应ToolStripMenuItem.Checked = false;
            普通ToolStripMenuItem.CheckState = CheckState.Unchecked;
            适应ToolStripMenuItem.CheckState = CheckState.Unchecked;
            拉伸ToolStripMenuItem.CheckState = CheckState.Checked;
        }

        private void 普通ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(870, 522);
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            拉伸ToolStripMenuItem.Checked = false;
            普通ToolStripMenuItem.Checked = true;
            适应ToolStripMenuItem.Checked = false;
            普通ToolStripMenuItem.CheckState = CheckState.Checked;
            适应ToolStripMenuItem.CheckState = CheckState.Unchecked;
            拉伸ToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("音乐文件请置于应用程序同文件夹下，wav文件，重命名为1.wav");
        }

        private void openFile()
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
    }
}