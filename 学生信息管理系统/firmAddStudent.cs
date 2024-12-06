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
    public partial class firmAddStudent : Form
    {
        public firmAddStudent()
        {
            InitializeComponent();
        }

        private void firmAddStudent_Load(object sender, EventArgs e)
        {
            InitClass();//加载班级列表
            rdoMale.Checked = true;


        }

        private void InitClass()
        {
            string sql = "select ClassID,ClassName,GradeName from ClassInfo c ,GradeInfo g where\r\nc.GradeId = g.GradeID";
            DataTable dtClass = sqlHelper.GetDataTable(sql);
            if (dtClass.Rows.Count > 0)
            {
                foreach (DataRow dr in dtClass.Rows)
                {
                    string className = dr["ClassName"].ToString();
                    string gradeName = dr["GradeName"].ToString();
                    dr["ClassName"] = className + "--" + gradeName;
                }
            }
            cboClass.DataSource = dtClass;
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //获取信息
            string stuName = txtStuName.Text.Trim();
            int classID = (int)cboClass.SelectedValue;
            string sex = rdoMale.Checked? rdoMale.Text.Trim():
                rdoFemale.Text.Trim();
            string phone = txtPhone.Text.Trim();
            //判空
            if(string.IsNullOrEmpty(stuName))
            {
                MessageBox.Show("请输入姓名！", "添加学生提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(phone)) 
            {
                MessageBox.Show("请输入电话！", "添加学生提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //查重

            //入库
            string sqlAdd = "insert into StudentInfo (StuName,ClassID,sex,phone)" +
                " values (@StuName,@ClassID,@sex,@phone)";
            SqlParameter[] parasAdd = 
                {
                new SqlParameter("@StuName",stuName),
                new SqlParameter("@CLassID",classID),
                new SqlParameter("@sex",sex),
                new SqlParameter("@phone",phone)
                };
           int count= sqlHelper.ExecuteNonQuery(sqlAdd, parasAdd);
           if(count > 0)
            {
                MessageBox.Show("添加成功", "添加学生提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
           else
            {
                MessageBox.Show("添加失败", "添加学生提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
