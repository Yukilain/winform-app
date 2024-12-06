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
    public partial class firmClassList : Form
    {
        public firmClassList()
        {
            InitializeComponent();
        }
        //初始化班级列表，班级列表信息
        private void firmClassList_Load(object sender, EventArgs e)
        {
            InitGrades();//加载年级列表
            InitAllClass();//加载所有班级信息
        }

        private void InitAllClass()
        {
            //联合查询语句
            string sql = "select ClassID,ClassName,GradeName,Remark from ClassInfo c\r\ninner join GradeInfo g on c.GradeID=g.GradeID;";
            DataTable dtClass = sqlHelper.GetDataTable(sql);
            dgvClassLIst.DataSource = dtClass;

        }

        private void InitGrades()
        {
            string sql = "select GradeID ,GradeName from GradeInfo";
            DataTable daGradeList = sqlHelper.GetDataTable(sql);
            //添加一个 请选择
            DataRow dr = daGradeList.NewRow();
            dr["GradeID"] = 0;
            dr["GradeName"] = "请选择";
            daGradeList.Rows.InsertAt(dr, 0);


            cboGrades.DataSource = daGradeList;
            cboGrades.DisplayMember = "GradeName";//显示的内容
            cboGrades.ValueMember = "GradeID";//值

        }
        
        //查询班级信息
        private void btnFind_Click(object sender, EventArgs e)
        {
            int gradeID = (int)cboGrades.SelectedValue;
            string className = txtClassName.Text.Trim();
            //sql查询语句
            string sql = "select ClassID,ClassName,GradeName,Remark from ClassInfo c\r\ninner join GradeInfo g on c.GradeID=g.GradeID";
            
            sql += " where 1=1";//
            if(gradeID > 0)
            {
                sql += " and c.GradeID = @GradeID";
            }
            if(!string.IsNullOrEmpty(className))
            {
                sql += " and ClassName like @ClassName";
            }
            SqlParameter[] paras =
            {
                new SqlParameter("@GradeID",gradeID),
                new SqlParameter("@ClassName","%"+className+"%")//模糊查询
            };


            DataTable dtClass = sqlHelper.GetDataTable(sql,paras);
            dgvClassLIst.DataSource= dtClass;
        }
    }
}
