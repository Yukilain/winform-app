using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生信息管理系统
{
    public partial class firmClassAdd : Form
    {
        public firmClassAdd()
        {
            InitializeComponent();
        }

        private void firmClassAdd_Load(object sender, EventArgs e)
        {
            InitGrade();//初始化班级列表

        }

        private void InitGrade()
        {
            string sql = "select GradeID,GradeName from GradeInfo";
            DataTable daGradeList = sqlHelper.GetDataTable(sql);

            cboGrade.DataSource = daGradeList;
            cboGrade.DisplayMember = "GradeName";//显示的内容
            cboGrade.ValueMember = "GradeID";//值
            cboGrade.SelectedIndex = 0;
        }

        //添加班级
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //获取信息
            string className = txtClassName.Text.Trim();
            int gradeID = (int)cboGrade.SelectedValue;
            string remark = txtRemark.Text.Trim();
            //判空
            if(string.IsNullOrEmpty(className) )
            {
                MessageBox.Show("请输入班名！","添加班级提示",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //判读是否存在
            string sqlExsit = "select count(1) from ClassInfo where ClassName=@ClassName and" +
                " GradeID = @GradeID";
            SqlParameter[] paras =
            {
               new SqlParameter("@ClassName",className),
               new SqlParameter("@GradeID",gradeID)
            };
            object o=sqlHelper.ExecuteScalar(sqlExsit, paras);
            if(o == null||o==DBNull.Value||(int)o==0)
            {
                //添加操作
                string sqlAdd = "insert into ClassInfo(ClassName,GradeID,Remark)" +
                    " values (@CLassName,@GradeID,@Remark)";
                SqlParameter[] parasAdd =
                {
                    new SqlParameter("@ClassName",className),
                    new SqlParameter("@GradeID",gradeID),
                    new SqlParameter("@Remark",remark)
                };
                int count = sqlHelper.ExecuteNonQuery(sqlAdd, parasAdd);
                if (count>0)
                {
                    MessageBox.Show("班级添加成功!", "添加班级提示",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("班级添加失败", "添加班级提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("班级已存在", "添加班级提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
