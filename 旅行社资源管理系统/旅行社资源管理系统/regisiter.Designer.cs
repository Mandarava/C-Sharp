namespace 旅行社资源管理系统
{
    partial class regisiter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.txtRegPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnreg = new System.Windows.Forms.Button();
            this.txtPwdVerify = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPwdVerify);
            this.groupBox1.Controls.Add(this.btnreg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRegPwd);
            this.groupBox1.Controls.Add(this.txtRegID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请填写完整以下信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // txtRegID
            // 
            this.txtRegID.BackColor = System.Drawing.SystemColors.Control;
            this.txtRegID.Location = new System.Drawing.Point(71, 35);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(190, 25);
            this.txtRegID.TabIndex = 4;
            // 
            // txtRegPwd
            // 
            this.txtRegPwd.BackColor = System.Drawing.SystemColors.Control;
            this.txtRegPwd.Location = new System.Drawing.Point(71, 66);
            this.txtRegPwd.Name = "txtRegPwd";
            this.txtRegPwd.PasswordChar = '*';
            this.txtRegPwd.Size = new System.Drawing.Size(190, 25);
            this.txtRegPwd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "(账号为11位手机号)";
            // 
            // btnreg
            // 
            this.btnreg.Enabled = false;
            this.btnreg.Location = new System.Drawing.Point(171, 166);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 9;
            this.btnreg.Text = "注册";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // txtPwdVerify
            // 
            this.txtPwdVerify.BackColor = System.Drawing.SystemColors.Control;
            this.txtPwdVerify.Location = new System.Drawing.Point(71, 106);
            this.txtPwdVerify.Name = "txtPwdVerify";
            this.txtPwdVerify.PasswordChar = '*';
            this.txtPwdVerify.Size = new System.Drawing.Size(190, 25);
            this.txtPwdVerify.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "验证密码";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // regisiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(485, 250);
            this.Controls.Add(this.groupBox1);
            this.Name = "regisiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegPwd;
        private System.Windows.Forms.TextBox txtRegID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPwdVerify;
        private System.Windows.Forms.Timer timer1;
    }
}