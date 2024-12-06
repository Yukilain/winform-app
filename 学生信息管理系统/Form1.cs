using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32.SafeHandles;

namespace 学生信息管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 获取用户信息
            string uName = userAccount.Text.Trim();
            string uPwd = userPwd.Text.Trim();
            if (string.IsNullOrEmpty(uName))
            {
                MessageBox.Show("请输入账号！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userAccount.Focus();
                return;
            }
            if (string.IsNullOrEmpty(uPwd))
            {
                MessageBox.Show("请输入密码！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userPwd.Focus();
                return;
            }

            //查询语句
            string sql = "select count(1) from  UserInfo where UserName= @UserName and UserPwd= @UserPwd";
            
            SqlParameter[] paras =
            {
                new SqlParameter("@UserName",uName),
                new SqlParameter("@UserPwd", uPwd)
            };

            object o= sqlHelper.ExecuteScalar(sql, paras);
            //处理结果
            if(o==null||o==DBNull.Value||((int)o)==0)
            {
                MessageBox.Show("账号或密码有误，请检查！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("登陆成功", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //跳转页面
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
