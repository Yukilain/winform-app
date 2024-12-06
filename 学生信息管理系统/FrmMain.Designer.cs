namespace 学生信息管理系统
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.subStudentAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.subStudentList = new System.Windows.Forms.ToolStripMenuItem();
            this.miClass = new System.Windows.Forms.ToolStripMenuItem();
            this.subClassAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.subClassList = new System.Windows.Forms.ToolStripMenuItem();
            this.miGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.subGradeList = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStudent,
            this.miClass,
            this.miGrade,
            this.miExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miStudent
            // 
            this.miStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subStudentAdd,
            this.subStudentList});
            this.miStudent.Name = "miStudent";
            this.miStudent.Size = new System.Drawing.Size(83, 24);
            this.miStudent.Text = "学生管理";
            // 
            // subStudentAdd
            // 
            this.subStudentAdd.Name = "subStudentAdd";
            this.subStudentAdd.Size = new System.Drawing.Size(152, 26);
            this.subStudentAdd.Text = "新增学生";
            this.subStudentAdd.Click += new System.EventHandler(this.subStudentAdd_Click);
            // 
            // subStudentList
            // 
            this.subStudentList.Name = "subStudentList";
            this.subStudentList.Size = new System.Drawing.Size(152, 26);
            this.subStudentList.Text = "学生列表";
            this.subStudentList.Click += new System.EventHandler(this.subStudentList_Click);
            // 
            // miClass
            // 
            this.miClass.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subClassAdd,
            this.subClassList});
            this.miClass.Name = "miClass";
            this.miClass.Size = new System.Drawing.Size(83, 24);
            this.miClass.Text = "班级管理";
            // 
            // subClassAdd
            // 
            this.subClassAdd.Name = "subClassAdd";
            this.subClassAdd.Size = new System.Drawing.Size(152, 26);
            this.subClassAdd.Text = "增加班级";
            this.subClassAdd.Click += new System.EventHandler(this.subClassAdd_Click);
            // 
            // subClassList
            // 
            this.subClassList.Name = "subClassList";
            this.subClassList.Size = new System.Drawing.Size(152, 26);
            this.subClassList.Text = "班级列表";
            this.subClassList.Click += new System.EventHandler(this.subClassList_Click);
            // 
            // miGrade
            // 
            this.miGrade.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subGradeList});
            this.miGrade.Name = "miGrade";
            this.miGrade.Size = new System.Drawing.Size(83, 24);
            this.miGrade.Text = "年级管理";
            // 
            // subGradeList
            // 
            this.subGradeList.Name = "subGradeList";
            this.subGradeList.Size = new System.Drawing.Size(152, 26);
            this.subGradeList.Text = "年级列表";
            this.subGradeList.Click += new System.EventHandler(this.subGradeList_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(83, 24);
            this.miExit.Text = "退出系统";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 663);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "学生管理系统主页面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miStudent;
        private System.Windows.Forms.ToolStripMenuItem subStudentAdd;
        private System.Windows.Forms.ToolStripMenuItem subStudentList;
        private System.Windows.Forms.ToolStripMenuItem miClass;
        private System.Windows.Forms.ToolStripMenuItem subClassAdd;
        private System.Windows.Forms.ToolStripMenuItem subClassList;
        private System.Windows.Forms.ToolStripMenuItem miGrade;
        private System.Windows.Forms.ToolStripMenuItem subGradeList;
        private System.Windows.Forms.ToolStripMenuItem miExit;
    }
}