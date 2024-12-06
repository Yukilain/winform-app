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
    public partial class firmStudentList : Form
    {
        public firmStudentList()
        {
            InitializeComponent();
        }
        //单例
        private static firmStudentList fStudentList = null;
        public static firmStudentList CreateInstance()
        {
            if(fStudentList == null||fStudentList.IsDisposed)
            {
                fStudentList = new firmStudentList();
            }
            return fStudentList;
        }
        //加载学生列表，班级列表
        private void firmStudentList_Load(object sender, EventArgs e)
        {
            LoadClassLIst();//班级
            LoadALLStudent();//加载所有学生
        }

        private void LoadALLStudent()
        {
            string sql = "select StuID,StuName,c.ClassName,GradeName,sex,phone" +
                " from StudentInfo s"
                + " inner join ClassInfo c on c.ClassID = s.ClassID"
                + " inner join GradeInfo g on g.GradeID = c.GradeID"
                ;

            DataTable dtStudent = sqlHelper.GetDataTable(sql);
            //组装数据
            if (dtStudent.Rows.Count > 0)
            {
                foreach (DataRow dr in dtStudent.Rows)
                {
                    string className = dr["ClassName"].ToString();
                    string gradeName = dr["GradeName"].ToString();
                    dr["ClassName"] = className + "--" + gradeName;
                }
            }
            dgvStuList.AutoGenerateColumns = false;
            dgvStuList.DataSource = dtStudent;
            
        }

        private void LoadClassLIst()
        {
            string sql = "select ClassID,ClassName,GradeName from ClassInfo c ,GradeInfo g where\r\nc.GradeId = g.GradeID";
            DataTable dtClass = sqlHelper.GetDataTable(sql);
            if(dtClass.Rows.Count > 0 ) 
            {
                foreach(DataRow dr in dtClass.Rows )
                {
                    string className = dr["ClassName"].ToString();
                    string gradeName = dr["GradeName"].ToString();
                    dr["ClassName"] = className +"--"+ gradeName;
                }
            }

            DataRow drNew = dtClass.NewRow();
            drNew["ClassID"] = 0;
            drNew["ClassName"] = "请选择";
            dtClass.Rows.InsertAt(drNew,0);

            cboClass.DataSource = dtClass;
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassID";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //接收查询信息
            int classID = (int)cboClass.SelectedValue;
            string stuName = txtStuName.Text.Trim();
            //

            string sql = "select StuID,StuName,c.ClassName,GradeName,sex,phone" +
                " from StudentInfo s"
                + " inner join ClassInfo c on c.ClassID = s.ClassID"
                + " inner join GradeInfo g on g.GradeID = c.GradeID";
            sql += " where 1=1 ";
            if(classID > 0)
            {
                sql += "and s.ClassID =@CLassID";
            }
            if(!string.IsNullOrEmpty(stuName))
            {
                sql += " and StuName like @StuName ";
            }
            sql += " order by StuID";
            SqlParameter[] paras =
            {
                new SqlParameter("@StuName","%"+stuName+"%"),
                new SqlParameter("@ClassID",classID)
            };
            DataTable dtStudent = sqlHelper.GetDataTable(sql,paras);
            //组装数据
            if (dtStudent.Rows.Count > 0)
            {
                foreach (DataRow dr in dtStudent.Rows)
                {
                    string className = dr["ClassName"].ToString();
                    string gradeName = dr["GradeName"].ToString();
                    dr["ClassName"] = className + "--" + gradeName;
                }
            }
            dgvStuList.AutoGenerateColumns = false;
            dgvStuList.DataSource = dtStudent;
        }
        //修改或删除的实现
        private void dgvStuList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataRow dr = (dgvStuList.Rows[e.RowIndex].DataBoundItem as
                            DataRowView).Row;
                DataGridViewCell cell = dgvStuList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell is DataGridViewLinkCell && cell.FormattedValue.ToString() == "删除")
                {
                    //删除操作
                    if(MessageBox.Show("您确定要删除该学生的信息吗？","删除学生信息提示",MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        //获取行数据               
                        int stuID = int.Parse(dr["stuID"].ToString());
                        //真删除
                        string sqlDel0 = "delete StudentInfo  where StuID=@StuID";
                        SqlParameter para = new SqlParameter("@StuID", stuID);
                        int count = sqlHelper.ExecuteNonQuery(sqlDel0, para);
                        if (count > 0)
                        {
                            MessageBox.Show("删除成功！", "删除学生信息提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                            //刷新
                            DataTable dtStudents = (DataTable)dgvStuList.DataSource;
                            //dgvStuList.DataSource = null;
                            dtStudents.Rows.Remove(dr);
                            dgvStuList.DataSource = dtStudents;
                        }
                        else
                        {
                            MessageBox.Show("删除失败！", "删除学生信息提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                            return;
                        }
                    }

                }
                else if (cell is DataGridViewLinkCell && cell.FormattedValue.ToString() == "修改")
                {
                   
                    //修改操作
                    int stuID = (int)dr["StuID"];
                    frmEdit frmEdit = new frmEdit();
                    frmEdit.Tag = stuID;

                    frmEdit.MdiParent = this.MdiParent;
                    frmEdit.Show();
                    


                }
            }
            

        }
    }
}
