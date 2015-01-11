namespace 旅游景点资源管理系统
{
    partial class F_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.priceSort = new System.Windows.Forms.TabPage();
            this.infoSearch = new System.Windows.Forms.TabPage();
            this.priceManage = new System.Windows.Forms.TabPage();
            this.scenicManage = new System.Windows.Forms.TabPage();
            this.showAll = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 653);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1144, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(221, 20);
            this.toolStripStatusLabel1.Text = "||  欢迎使用旅游资源管理系统  ||";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel2.Text = "当前时间：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // priceSort
            // 
            this.priceSort.BackColor = System.Drawing.SystemColors.Control;
            this.priceSort.Location = new System.Drawing.Point(4, 25);
            this.priceSort.Name = "priceSort";
            this.priceSort.Size = new System.Drawing.Size(1112, 577);
            this.priceSort.TabIndex = 5;
            this.priceSort.Text = "票价排序";
            // 
            // infoSearch
            // 
            this.infoSearch.BackColor = System.Drawing.SystemColors.Control;
            this.infoSearch.Location = new System.Drawing.Point(4, 25);
            this.infoSearch.Name = "infoSearch";
            this.infoSearch.Size = new System.Drawing.Size(1112, 577);
            this.infoSearch.TabIndex = 2;
            this.infoSearch.Text = "景点信息查找";
            // 
            // priceManage
            // 
            this.priceManage.BackColor = System.Drawing.SystemColors.Control;
            this.priceManage.Location = new System.Drawing.Point(4, 25);
            this.priceManage.Name = "priceManage";
            this.priceManage.Padding = new System.Windows.Forms.Padding(3);
            this.priceManage.Size = new System.Drawing.Size(1112, 577);
            this.priceManage.TabIndex = 1;
            this.priceManage.Text = "景点票价管理";
            // 
            // scenicManage
            // 
            this.scenicManage.BackColor = System.Drawing.SystemColors.Control;
            this.scenicManage.Location = new System.Drawing.Point(4, 25);
            this.scenicManage.Name = "scenicManage";
            this.scenicManage.Padding = new System.Windows.Forms.Padding(3);
            this.scenicManage.Size = new System.Drawing.Size(1136, 590);
            this.scenicManage.TabIndex = 0;
            this.scenicManage.Text = "景点信息管理";
            // 
            // showAll
            // 
            this.showAll.BackColor = System.Drawing.SystemColors.Control;
            this.showAll.Location = new System.Drawing.Point(4, 25);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(1136, 590);
            this.showAll.TabIndex = 4;
            this.showAll.Text = "全部景点信息";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.showAll);
            this.tabControl1.Controls.Add(this.scenicManage);
            this.tabControl1.Controls.Add(this.priceManage);
            this.tabControl1.Controls.Add(this.infoSearch);
            this.tabControl1.Controls.Add(this.priceSort);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1144, 619);
            this.tabControl1.TabIndex = 2;
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 678);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "旅游景点资源管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage priceSort;
        private System.Windows.Forms.TabPage infoSearch;
        private System.Windows.Forms.TabPage priceManage;
        private System.Windows.Forms.TabPage scenicManage;
        private System.Windows.Forms.TabPage showAll;
        private System.Windows.Forms.TabControl tabControl1;

    }
}