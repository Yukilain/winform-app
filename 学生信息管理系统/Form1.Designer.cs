namespace 学生信息管理系统
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.userAccount = new System.Windows.Forms.TextBox();
            this.userPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(130, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "学生信息管理系统";
            // 
            // userAccount
            // 
            this.userAccount.Location = new System.Drawing.Point(266, 175);
            this.userAccount.Name = "userAccount";
            this.userAccount.Size = new System.Drawing.Size(331, 25);
            this.userAccount.TabIndex = 2;
            this.userAccount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // userPwd
            // 
            this.userPwd.Location = new System.Drawing.Point(266, 230);
            this.userPwd.Name = "userPwd";
            this.userPwd.PasswordChar = '*';
            this.userPwd.Size = new System.Drawing.Size(331, 25);
            this.userPwd.TabIndex = 3;
            this.userPwd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(266, 339);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 52);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(474, 339);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(123, 52);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(183, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "账号：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(183, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.userPwd);
            this.Controls.Add(this.userAccount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userAccount;
        private System.Windows.Forms.TextBox userPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

