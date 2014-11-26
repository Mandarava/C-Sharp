using System;
using System.IO;
using System.Windows.Forms;

namespace 文件操作
{
    public partial class Form1 : Form
    {
        private static string path = @"C:\mydir";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            textBox1.Text = "目录创建时间： " + Convert.ToString(Directory.GetCreationTime(path));
            showListView(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string sourcepath = fileDialog.FileName;
            File.Copy(sourcepath, Path.Combine(@"C:\mydir", fileDialog.SafeFileName), true);
            showListView(path);
        }

        private void showListView(string path)
        {
            listView1.Items.Clear();
            string[] filepaths = Directory.GetFiles(path);
            foreach (string filePath in filepaths)
            {
                var fileInfo = new FileInfo(filePath);
                var item = new ListViewItem();
                item.SubItems[0].Text = fileInfo.Name;
                item.SubItems.Add(fileInfo.CreationTime.ToString());
                item.SubItems.Add(((float) fileInfo.Length/1024).ToString("F1") + " KB");
                listView1.Items.Add(item);
            }
        }
    }
}