namespace 字体编辑器
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.楷体 = new System.Windows.Forms.RadioButton();
            this.隶书 = new System.Windows.Forms.RadioButton();
            this.华文彩云 = new System.Windows.Forms.RadioButton();
            this.size16 = new System.Windows.Forms.RadioButton();
            this.size20 = new System.Windows.Forms.RadioButton();
            this.size24 = new System.Windows.Forms.RadioButton();
            this.red = new System.Windows.Forms.RadioButton();
            this.blue = new System.Windows.Forms.RadioButton();
            this.green = new System.Windows.Forms.RadioButton();
            this.underline = new System.Windows.Forms.CheckBox();
            this.italic = new System.Windows.Forms.CheckBox();
            this.bold = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(47, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "请输入文本：";
            // 
            // 楷体
            // 
            this.楷体.AutoSize = true;
            this.楷体.Checked = true;
            this.楷体.Location = new System.Drawing.Point(6, 31);
            this.楷体.Name = "楷体";
            this.楷体.Size = new System.Drawing.Size(58, 19);
            this.楷体.TabIndex = 2;
            this.楷体.TabStop = true;
            this.楷体.Text = "楷体";
            this.楷体.UseVisualStyleBackColor = true;
            // 
            // 隶书
            // 
            this.隶书.AutoSize = true;
            this.隶书.Location = new System.Drawing.Point(6, 73);
            this.隶书.Name = "隶书";
            this.隶书.Size = new System.Drawing.Size(58, 19);
            this.隶书.TabIndex = 3;
            this.隶书.Text = "隶书";
            this.隶书.UseVisualStyleBackColor = true;
            // 
            // 华文彩云
            // 
            this.华文彩云.AutoSize = true;
            this.华文彩云.Location = new System.Drawing.Point(6, 118);
            this.华文彩云.Name = "华文彩云";
            this.华文彩云.Size = new System.Drawing.Size(88, 19);
            this.华文彩云.TabIndex = 4;
            this.华文彩云.TabStop = true;
            this.华文彩云.Text = "华文彩云";
            this.华文彩云.UseVisualStyleBackColor = true;
            // 
            // size16
            // 
            this.size16.AutoSize = true;
            this.size16.Checked = true;
            this.size16.Location = new System.Drawing.Point(6, 32);
            this.size16.Name = "size16";
            this.size16.Size = new System.Drawing.Size(44, 19);
            this.size16.TabIndex = 5;
            this.size16.TabStop = true;
            this.size16.Text = "16";
            this.size16.UseVisualStyleBackColor = true;
            // 
            // size20
            // 
            this.size20.AutoSize = true;
            this.size20.Location = new System.Drawing.Point(6, 73);
            this.size20.Name = "size20";
            this.size20.Size = new System.Drawing.Size(44, 19);
            this.size20.TabIndex = 6;
            this.size20.TabStop = true;
            this.size20.Text = "20";
            this.size20.UseVisualStyleBackColor = true;
            // 
            // size24
            // 
            this.size24.AutoSize = true;
            this.size24.Location = new System.Drawing.Point(6, 118);
            this.size24.Name = "size24";
            this.size24.Size = new System.Drawing.Size(44, 19);
            this.size24.TabIndex = 7;
            this.size24.TabStop = true;
            this.size24.Text = "24";
            this.size24.UseVisualStyleBackColor = true;
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Checked = true;
            this.red.Location = new System.Drawing.Point(6, 35);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(43, 19);
            this.red.TabIndex = 8;
            this.red.TabStop = true;
            this.red.Text = "红";
            this.red.UseVisualStyleBackColor = true;
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(6, 73);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(43, 19);
            this.blue.TabIndex = 9;
            this.blue.TabStop = true;
            this.blue.Text = "蓝";
            this.blue.UseVisualStyleBackColor = true;
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.Location = new System.Drawing.Point(6, 118);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(43, 19);
            this.green.TabIndex = 10;
            this.green.TabStop = true;
            this.green.Text = "绿";
            this.green.UseVisualStyleBackColor = true;
            // 
            // underline
            // 
            this.underline.AutoSize = true;
            this.underline.Location = new System.Drawing.Point(6, 36);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(74, 19);
            this.underline.TabIndex = 14;
            this.underline.Text = "下划线";
            this.underline.UseVisualStyleBackColor = true;
            this.underline.CheckedChanged += new System.EventHandler(this.underline_CheckedChanged);
            // 
            // italic
            // 
            this.italic.AutoSize = true;
            this.italic.Location = new System.Drawing.Point(6, 79);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(59, 19);
            this.italic.TabIndex = 15;
            this.italic.Text = "斜体";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.CheckedChanged += new System.EventHandler(this.italic_CheckedChanged);
            // 
            // bold
            // 
            this.bold.AutoSize = true;
            this.bold.Location = new System.Drawing.Point(6, 119);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(59, 19);
            this.bold.TabIndex = 16;
            this.bold.Text = "粗体";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.CheckedChanged += new System.EventHandler(this.bold_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(51, 300);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(618, 116);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "程序设计实践与分析";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.underline);
            this.groupBox1.Controls.Add(this.italic);
            this.groupBox1.Controls.Add(this.bold);
            this.groupBox1.Location = new System.Drawing.Point(544, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 144);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字型";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.red);
            this.groupBox2.Controls.Add(this.blue);
            this.groupBox2.Controls.Add(this.green);
            this.groupBox2.Location = new System.Drawing.Point(402, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 144);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "颜色";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.size16);
            this.groupBox3.Controls.Add(this.size20);
            this.groupBox3.Controls.Add(this.size24);
            this.groupBox3.Location = new System.Drawing.Point(247, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 144);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "字号";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.楷体);
            this.groupBox4.Controls.Add(this.隶书);
            this.groupBox4.Controls.Add(this.华文彩云);
            this.groupBox4.Location = new System.Drawing.Point(51, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 144);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "字体";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "字体编辑器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton 楷体;
        private System.Windows.Forms.RadioButton 隶书;
        private System.Windows.Forms.RadioButton 华文彩云;
        private System.Windows.Forms.RadioButton size16;
        private System.Windows.Forms.RadioButton size20;
        private System.Windows.Forms.RadioButton size24;
        private System.Windows.Forms.RadioButton red;
        private System.Windows.Forms.RadioButton blue;
        private System.Windows.Forms.RadioButton green;
        private System.Windows.Forms.CheckBox underline;
        private System.Windows.Forms.CheckBox italic;
        private System.Windows.Forms.CheckBox bold;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
    }
}

