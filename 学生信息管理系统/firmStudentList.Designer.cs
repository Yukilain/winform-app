namespace 学生信息管理系统
{
    partial class firmStudentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.dgvStuList = new System.Windows.Forms.DataGridView();
            this.StuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtStuName);
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "学生姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "班级：";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(609, 30);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(149, 35);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "查询（刷新）";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(360, 37);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(155, 25);
            this.txtStuName.TabIndex = 1;
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(78, 37);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(152, 23);
            this.cboClass.TabIndex = 0;
            // 
            // dgvStuList
            // 
            this.dgvStuList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuID,
            this.StuName,
            this.ClassID,
            this.sex,
            this.phone,
            this.colDel,
            this.colEdit});
            this.dgvStuList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStuList.Location = new System.Drawing.Point(0, 179);
            this.dgvStuList.Name = "dgvStuList";
            this.dgvStuList.RowHeadersWidth = 51;
            this.dgvStuList.RowTemplate.Height = 27;
            this.dgvStuList.Size = new System.Drawing.Size(1088, 380);
            this.dgvStuList.TabIndex = 1;
            this.dgvStuList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStuList_CellContentClick);
            // 
            // StuID
            // 
            this.StuID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StuID.DataPropertyName = "StuID";
            this.StuID.HeaderText = "编号";
            this.StuID.MinimumWidth = 6;
            this.StuID.Name = "StuID";
            this.StuID.Width = 111;
            // 
            // StuName
            // 
            this.StuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StuName.DataPropertyName = "StuName";
            this.StuName.HeaderText = "姓名";
            this.StuName.MinimumWidth = 6;
            this.StuName.Name = "StuName";
            this.StuName.Width = 112;
            // 
            // ClassID
            // 
            this.ClassID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClassID.DataPropertyName = "ClassName";
            this.ClassID.HeaderText = "班级";
            this.ClassID.MinimumWidth = 6;
            this.ClassID.Name = "ClassID";
            this.ClassID.Width = 111;
            // 
            // sex
            // 
            this.sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "性别";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.Width = 112;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "电话号码";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.Width = 111;
            // 
            // colDel
            // 
            this.colDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.NullValue = "删除";
            this.colDel.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDel.HeaderText = "删除";
            this.colDel.MinimumWidth = 6;
            this.colDel.Name = "colDel";
            this.colDel.Width = 112;
            // 
            // colEdit
            // 
            dataGridViewCellStyle4.NullValue = "修改";
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle4;
            this.colEdit.HeaderText = "修改";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            // 
            // firmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 559);
            this.Controls.Add(this.dgvStuList);
            this.Controls.Add(this.groupBox1);
            this.Name = "firmStudentList";
            this.Text = "学生列表";
            this.Load += new System.EventHandler(this.firmStudentList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.DataGridView dgvStuList;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewLinkColumn colDel;
        private System.Windows.Forms.DataGridViewLinkColumn colEdit;
    }
}