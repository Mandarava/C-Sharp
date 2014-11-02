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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public ListView listview1 = null;
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listview1.CheckedItems)
               listView2.Items.Add((ListViewItem)item.Clone());
        }

    }
}
