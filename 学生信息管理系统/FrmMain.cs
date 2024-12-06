using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生信息管理系统
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void subStudentAdd_Click(object sender, EventArgs e)
        {
            firmAddStudent fAddStudent = new firmAddStudent();
            fAddStudent.MdiParent = this;
            fAddStudent.Show();

        }

        private void subStudentList_Click(object sender, EventArgs e)
        {
            bool bl = CheckForm(typeof(firmStudentList).Name);
            if (!bl)
            {
                firmStudentList fStudentList = firmStudentList.CreateInstance();
                fStudentList.MdiParent = this;
                fStudentList.Show();
            }
        }
        private bool  CheckForm(string formName)
        {
            bool bl = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == formName)

                {
                    bl = true;
                    f.Activate();
                    break;
                }
            }
            return bl;
                
        }

        private void subClassAdd_Click(object sender, EventArgs e)
        {
            firmClassAdd fClassAdd = new firmClassAdd();
            fClassAdd.MdiParent = this;
            fClassAdd.Show();
        }

        private void subClassList_Click(object sender, EventArgs e)
        {
            bool bl = CheckForm(typeof(firmClassList).Name);
            if (!bl)
            {
                firmClassList fClassList = new firmClassList();
                fClassList.MdiParent = this;
                fClassList.Show();
            }
        }

        private void subGradeList_Click(object sender, EventArgs e)
        {
            bool bl = CheckForm(typeof(firmGradeList).Name);
            if (!bl)
            {
                firmGradeList fGradeList = new firmGradeList();
                fGradeList.MdiParent = this;
                fGradeList.Show();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result= MessageBox.Show("您确定要退出吗？","退出提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
