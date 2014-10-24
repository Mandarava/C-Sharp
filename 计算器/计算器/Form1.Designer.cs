namespace 计算器
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
            this.BT_NUM0 = new System.Windows.Forms.Button();
            this.Operator_Equal = new System.Windows.Forms.Button();
            this.BT_NUM2 = new System.Windows.Forms.Button();
            this.BT_NUM3 = new System.Windows.Forms.Button();
            this.Operator_Sub = new System.Windows.Forms.Button();
            this.BT_NUM1 = new System.Windows.Forms.Button();
            this.Operator_Add = new System.Windows.Forms.Button();
            this.Opeartor_Point = new System.Windows.Forms.Button();
            this.BT_NUM5 = new System.Windows.Forms.Button();
            this.BT_NUM6 = new System.Windows.Forms.Button();
            this.Operator_Mul = new System.Windows.Forms.Button();
            this.BT_NUM4 = new System.Windows.Forms.Button();
            this.BT_NUM7 = new System.Windows.Forms.Button();
            this.BT_NUM8 = new System.Windows.Forms.Button();
            this.BT_NUM9 = new System.Windows.Forms.Button();
            this.Operator_div = new System.Windows.Forms.Button();
            this.Operator_CE = new System.Windows.Forms.Button();
            this.Operator_Clear = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BT_NUM0
            // 
            this.BT_NUM0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.BT_NUM0.Location = new System.Drawing.Point(8, 289);
            this.BT_NUM0.Name = "BT_NUM0";
            this.BT_NUM0.Size = new System.Drawing.Size(98, 46);
            this.BT_NUM0.TabIndex = 0;
            this.BT_NUM0.Text = "0";
            this.BT_NUM0.UseVisualStyleBackColor = false;
            this.BT_NUM0.Click += new System.EventHandler(this.bt_Click);
            // 
            // Operator_Equal
            // 
            this.Operator_Equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.Operator_Equal.Location = new System.Drawing.Point(216, 230);
            this.Operator_Equal.Name = "Operator_Equal";
            this.Operator_Equal.Size = new System.Drawing.Size(49, 105);
            this.Operator_Equal.TabIndex = 3;
            this.Operator_Equal.Text = "=";
            this.Operator_Equal.UseVisualStyleBackColor = false;
            this.Operator_Equal.Click += new System.EventHandler(this.bt_Click);
            // 
            // BT_NUM2
            // 
            this.BT_NUM2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.BT_NUM2.Location = new System.Drawing.Point(60, 230);
            this.BT_NUM2.Name = "BT_NUM2";
            this.BT_NUM2.Size = new System.Drawing.Size(46, 46);
            this.BT_NUM2.TabIndex = 4;
            this.BT_NUM2.Text = "2";
            this.BT_NUM2.UseVisualStyleBackColor = false;
            this.BT_NUM2.Click += new System.EventHandler(this.bt_Click);
            // 
            // BT_NUM3
            // 
            this.BT_NUM3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.BT_NUM3.Location = new System.Drawing.Point(112, 230);
            this.BT_NUM3.Name = "BT_NUM3";
            this.BT_NUM3.Size = new System.Drawing.Size(46, 46);
            this.BT_NUM3.TabIndex = 5;
            this.BT_NUM3.Text = "3";
            this.BT_NUM3.UseVisualStyleBackColor = false;
            this.BT_NUM3.Click += new System.EventHandler(this.bt_Click);
            // 
            // Operator_Sub
            // 
            this.Operator_Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.Operator_Sub.Location = new System.Drawing.Point(164, 230);
            this.Operator_Sub.Name = "Operator_Sub";
            this.Operator_Sub.Size = new System.Drawing.Size(46, 46);
            this.Operator_Sub.TabIndex = 6;
            this.Operator_Sub.Text = "-";
            this.Operator_Sub.UseVisualStyleBackColor = false;
            this.Operator_Sub.Click += new System.EventHandler(this.bt_Click);
            // 
            // BT_NUM1
            // 
            this.BT_NUM1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.BT_NUM1.Location = new System.Drawing.Point(8, 230);
            this.BT_NUM1.Name = "BT_NUM1";
            this.BT_NUM1.Size = new System.Drawing.Size(46, 46);
            this.BT_NUM1.TabIndex = 7;
            this.BT_NUM1.Text = "1";
            this.BT_NUM1.UseVisualStyleBackColor = false;
            this.BT_NUM1.Click += new System.EventHandler(this.bt_Click);
            // 
            // Operator_Add
            // 
            this.Operator_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.Operator_Add.Location = new System.Drawing.Point(164, 289);
            this.Operator_Add.Name = "Operator_Add";
            this.Operator_Add.Size = new System.Drawing.Size(46, 46);
            this.Operator_Add.TabIndex = 10;
            this.Operator_Add.Text = "+";
            this.Operator_Add.UseVisualStyleBackColor = false;
            this.Operator_Add.Click += new System.EventHandler(this.bt_Click);
            // 
            // Opeartor_Point
            // 
            this.Opeartor_Point.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.Opeartor_Point.Location = new System.Drawing.Point(112, 289);
            this.Opeartor_Point.Name = "Opeartor_Point";
            this.Opeartor_Point.Size = new System.Drawing.Size(46, 46);
            this.Opeartor_Point.TabIndex = 11;
            this.Opeartor_Point.Text = ".";
            this.Opeartor_Point.UseVisualStyleBackColor = false;
            this.Opeartor_Point.Click += new System.EventHandler(this.bt_Click);
            // 
            // BT_NUM5
            // 
            this.BT_NUM5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.BT_NUM5.Location = new System.Drawing.Point(60, 178);
            this.BT_NUM5.Name = "BT_NUM5";
            this.BT_NUM5.Size = new System.Drawing.Size(46, 46);
            this.BT_NUM5.TabIndex = 12;
            this.BT_NUM5.Text = "5";
            this.BT_NUM5.UseVisualStyleBackColor = false;
            this.BT_NUM5.Click += new System.EventHandler(this.bt_Click);
            // 
            // BT_NUM6
            // 
            this.BT_NUM6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.BT_NUM6.Location = new System.Drawing.Point(112, 178);
            this.BT_NUM6.Name = "BT_NUM6";
            this.BT_NUM6.Size = new System.Drawing.Size(46, 46);
            this.BT_NUM6.TabIndex = 13;
            this.BT_NUM6.Text = "6";
            this.BT_NUM6.UseVisualStyleBackColor = false;
            this.BT_NUM6.Click += new System.EventHandler(this.bt_Click);
            // 
            // Operator_Mul
            // 
            this.Operator_Mul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.Operator_Mul.Location = new System.Drawing.Point(164, 178);
            this.Operator_Mul.Name = "Operator_Mul";
            this.Operator_Mul.Size = new System.Drawing.Size(46, 46);
            this.Operator_Mul.TabIndex = 14;
            this.Operator_Mul.Text = "*";
            this.Operator_Mul.UseVisualStyleBackColor = false;
            this.Operator_Mul.Click += new System.EventHandler(this.bt_Click);
            // 
            // BT_NUM4
            // 
            this.BT_NUM4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.BT_NUM4.Location = new System.Drawing.Point(8, 178);
            this.BT_NUM4.Name = "BT_NUM4";
            this.BT_NUM4.Size = new System.Drawing.Size(46, 46);
            this.BT_NUM4.TabIndex = 15;
            this.BT_NUM4.Text = "4";
            this.BT_NUM4.UseVisualStyleBackColor = false;
            this.BT_NUM4.Click += new System.EventHandler(this.bt_Click);
            // 
            // BT_NUM7
            // 
            this.BT_NUM7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.BT_NUM7.Location = new System.Drawing.Point(8, 126);
            this.BT_NUM7.Name = "BT_NUM7";
            this.BT_NUM7.Size = new System.Drawing.Size(46, 46);
            this.BT_NUM7.TabIndex = 16;
            this.BT_NUM7.Text = "7";
            this.BT_NUM7.UseVisualStyleBackColor = false;
            this.BT_NUM7.Click += new System.EventHandler(this.bt_Click);
            // 
            // BT_NUM8
            // 
            this.BT_NUM8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.BT_NUM8.Location = new System.Drawing.Point(60, 126);
            this.BT_NUM8.Name = "BT_NUM8";
            this.BT_NUM8.Size = new System.Drawing.Size(46, 46);
            this.BT_NUM8.TabIndex = 17;
            this.BT_NUM8.Text = "8";
            this.BT_NUM8.UseVisualStyleBackColor = false;
            this.BT_NUM8.Click += new System.EventHandler(this.bt_Click);
            // 
            // BT_NUM9
            // 
            this.BT_NUM9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.BT_NUM9.Location = new System.Drawing.Point(112, 126);
            this.BT_NUM9.Name = "BT_NUM9";
            this.BT_NUM9.Size = new System.Drawing.Size(46, 46);
            this.BT_NUM9.TabIndex = 18;
            this.BT_NUM9.Text = "9";
            this.BT_NUM9.UseVisualStyleBackColor = false;
            this.BT_NUM9.Click += new System.EventHandler(this.bt_Click);
            // 
            // Operator_div
            // 
            this.Operator_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.Operator_div.Location = new System.Drawing.Point(164, 126);
            this.Operator_div.Name = "Operator_div";
            this.Operator_div.Size = new System.Drawing.Size(46, 46);
            this.Operator_div.TabIndex = 19;
            this.Operator_div.Text = "/";
            this.Operator_div.UseVisualStyleBackColor = false;
            this.Operator_div.Click += new System.EventHandler(this.bt_Click);
            // 
            // Operator_CE
            // 
            this.Operator_CE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.Operator_CE.Location = new System.Drawing.Point(216, 178);
            this.Operator_CE.Name = "Operator_CE";
            this.Operator_CE.Size = new System.Drawing.Size(46, 46);
            this.Operator_CE.TabIndex = 20;
            this.Operator_CE.Text = "CE";
            this.Operator_CE.UseVisualStyleBackColor = false;
            this.Operator_CE.Click += new System.EventHandler(this.bt_Click);
            // 
            // Operator_Clear
            // 
            this.Operator_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.Operator_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Operator_Clear.Location = new System.Drawing.Point(216, 126);
            this.Operator_Clear.Name = "Operator_Clear";
            this.Operator_Clear.Size = new System.Drawing.Size(46, 46);
            this.Operator_Clear.TabIndex = 21;
            this.Operator_Clear.Text = "^-^";
            this.Operator_Clear.UseVisualStyleBackColor = false;
            this.Operator_Clear.Click += new System.EventHandler(this.bt_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(8, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(254, 78);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(271, 349);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Operator_Clear);
            this.Controls.Add(this.Operator_CE);
            this.Controls.Add(this.Operator_div);
            this.Controls.Add(this.BT_NUM9);
            this.Controls.Add(this.BT_NUM8);
            this.Controls.Add(this.BT_NUM7);
            this.Controls.Add(this.BT_NUM4);
            this.Controls.Add(this.Operator_Mul);
            this.Controls.Add(this.BT_NUM6);
            this.Controls.Add(this.BT_NUM5);
            this.Controls.Add(this.Opeartor_Point);
            this.Controls.Add(this.Operator_Add);
            this.Controls.Add(this.BT_NUM1);
            this.Controls.Add(this.Operator_Sub);
            this.Controls.Add(this.BT_NUM3);
            this.Controls.Add(this.BT_NUM2);
            this.Controls.Add(this.Operator_Equal);
            this.Controls.Add(this.BT_NUM0);
            this.Name = "Form1";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_NUM0;
        private System.Windows.Forms.Button Operator_Equal;
        private System.Windows.Forms.Button BT_NUM2;
        private System.Windows.Forms.Button BT_NUM3;
        private System.Windows.Forms.Button Operator_Sub;
        private System.Windows.Forms.Button BT_NUM1;
        private System.Windows.Forms.Button Operator_Add;
        private System.Windows.Forms.Button Opeartor_Point;
        private System.Windows.Forms.Button BT_NUM5;
        private System.Windows.Forms.Button BT_NUM6;
        private System.Windows.Forms.Button Operator_Mul;
        private System.Windows.Forms.Button BT_NUM4;
        private System.Windows.Forms.Button BT_NUM7;
        private System.Windows.Forms.Button BT_NUM8;
        private System.Windows.Forms.Button BT_NUM9;
        private System.Windows.Forms.Button Operator_div;
        private System.Windows.Forms.Button Operator_CE;
        private System.Windows.Forms.Button Operator_Clear;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

