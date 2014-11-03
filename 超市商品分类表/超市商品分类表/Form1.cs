using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 超市商品分类表
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode newNode=new TreeNode(this.textBox1.Text);
            treeView1.Nodes.Add(newNode);
            treeView1.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("添加子节点前先选中一个节点。");
                return;
            }
            TreeNode newNode=new TreeNode(this.textBox1.Text);
            selectedNode.Nodes.Add(newNode);
            selectedNode.Expand();
            this.treeView1.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("删除节点之前必须先选中一个节点。");
                return;
            }
            TreeNode parentNode = selectedNode.Parent;
            if(parentNode==null)
                this.treeView1.Nodes.Remove(selectedNode);
            else
                parentNode.Nodes.Remove(selectedNode);
            this.treeView1.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // treeView1.BeginUpdate();
            treeView1.Nodes.Add("所有商品分类");
            treeView1.Nodes[0].Nodes.Add("零食特产、生鲜、粮油");
            treeView1.Nodes[0].Nodes.Add("茶冲乳品、酒水、饮料");
            treeView1.Nodes[0].Nodes.Add("美容护法、洗发、沐浴");
            treeView1.Nodes[0].Nodes.Add("手机、数码、配件");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("生鲜食品");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("饼干、糕点");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("米面粮油");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("食品票券");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("酒");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("冲饮谷物");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("热销专区");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("洗浴用品");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("进口美护");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("洗发护发造型");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("身体护理");
            treeView1.Nodes[0].Nodes[3].Nodes.Add("手机通讯");
            treeView1.Nodes[0].Nodes[3].Nodes.Add("大牌专区");
            treeView1.Nodes[0].Nodes[3].Nodes.Add("运营商");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("水果");
           // treeView1.EndUpdate();
        }
    }
}
