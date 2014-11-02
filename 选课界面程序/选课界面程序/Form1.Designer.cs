namespace 选课界面程序
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.课程编号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.课程名称 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.课程学时 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.课程教师 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.课程编号,
            this.课程名称,
            this.课程学时,
            this.课程教师});
            this.listView1.Location = new System.Drawing.Point(12, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 280);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
//            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            // 
            // 课程编号
            // 
            this.课程编号.Text = "课程编号";
            this.课程编号.Width = 100;
            // 
            // 课程名称
            // 
            this.课程名称.Text = "课程名称";
            this.课程名称.Width = 100;
            // 
            // 课程学时
            // 
            this.课程学时.Text = "课程学时";
            this.课程学时.Width = 100;
            // 
            // 课程教师
            // 
            this.课程教师.Text = "课程教师";
            this.课程教师.Width = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "选课";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "选课界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader 课程编号;
        public System.Windows.Forms.ColumnHeader 课程名称;
        public System.Windows.Forms.ColumnHeader 课程学时;
        public System.Windows.Forms.ColumnHeader 课程教师;
    }
}

