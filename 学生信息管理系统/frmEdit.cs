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
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }
        private int stuID=0;
        private void frmEdit_Load(object sender, EventArgs e)
        {
            LoadClassLIst();
            //加载学生信息
            InitStudent();
        }

        private void InitStudent()
        {
            //获取id
            if (this.Tag!=null && this.Tag.ToString()!="")
            {
                int.TryParse(this.Tag.ToString(),out stuID);
                string sql = "select StuName,StuID,sex,phone from StudentInfo where StuID=@StuID";
                SqlParameter para = new SqlParameter("@StuID",stuID);
                SqlDataReader dr= sqlHelper.ExecuteReader(sql, para);
                if (dr.Read())
                {
                    txtStuName.Text = dr["StuName"].ToString();
                    txtPhone.Text = dr["phone"].ToString();
                    string sex = dr["sex"].ToString().Trim();
                    if (sex == "男")
                        rdoMale.Checked = true;
                    else
                       rdoFemale.Checked = true;
                    //int classID = (int)dr["ClassID"];
                    //cboClass.SelectedValue = classID;
                }
                dr.Close();
            }
        }

        private void LoadClassLIst()
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

            DataRow drNew = dtClass.NewRow();
            drNew["ClassID"] = 0;
            drNew["ClassName"] = "请选择";
            dtClass.Rows.InsertAt(drNew, 0);

            cboClass.DataSource = dtClass;
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassID";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //获取信息
            string stuName = txtStuName.Text.Trim();
            int classID = (int)cboClass.SelectedValue;
            string sex = rdoMale.Checked ? rdoMale.Text.Trim() :
                rdoFemale.Text.Trim();
            string phone = txtPhone.Text.Trim();
            //判空
            if (string.IsNullOrEmpty(stuName))
            {
                MessageBox.Show("请输入姓名！", "修改学生提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("请输入电话！", "修改学生提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //判断是否存在

            //修改
            string sqlUpdate = "update StudentInfo set StuName=@StuName,ClassID=@ClassID,sex=@sex,phone=@phone" +
                " where StuID=@StuID";
            SqlParameter[] parasUpdate =
                {
                new SqlParameter("@StuName",stuName),
                new SqlParameter("@CLassID",classID),
                new SqlParameter("@sex",sex),
                new SqlParameter("@phone",phone),
                new SqlParameter("@StuID",stuID)
                };
            int count = sqlHelper.ExecuteNonQuery(sqlUpdate, parasUpdate);
            if (count > 0)
            {
                MessageBox.Show("修改成功", "修改学生提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("修改失败", "修改学生提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
