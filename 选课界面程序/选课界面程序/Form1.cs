using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 选课界面程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 myform = new Form2();
            myform.listview1 = listView1;
            myform.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[][] subitem = new string[4][];
            subitem[0] = new string[4] {"B1", "C#", "60", "张三"};
            subitem[1] = new string[4] {"B2", "操作系统", "60", "李四"};
            subitem[2] = new string[4] {"B3", "信息安全", "60", "王五"};
            subitem[3] = new string[4] {"B4", "数据库", "60", "赵六"};
            for (int i = 0; i < subitem.Length; i++)
                this.listView1.Items.Add(new ListViewItem(subitem[i]));
        }
    }
}
