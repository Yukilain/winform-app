namespace 学生信息管理系统
{
    partial class firmClassAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labClassName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cboGrade);
            this.panel1.Controls.Add(this.txtRemark);
            this.panel1.Controls.Add(this.txtClassName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labClassName);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 426);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(257, 371);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(55, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(98, 69);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(207, 23);
            this.cboGrade.TabIndex = 6;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(98, 137);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(207, 184);
            this.txtRemark.TabIndex = 5;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(98, 21);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(207, 25);
            this.txtClassName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "描述：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "年级：";
            // 
            // labClassName
            // 
            this.labClassName.AutoSize = true;
            this.labClassName.Location = new System.Drawing.Point(26, 24);
            this.labClassName.Name = "labClassName";
            this.labClassName.Size = new System.Drawing.Size(52, 15);
            this.labClassName.TabIndex = 0;
            this.labClassName.Text = "班名：";
            // 
            // firmClassAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.panel1);
            this.Name = "firmClassAdd";
            this.Text = "班级信息页面";
            this.Load += new System.EventHandler(this.firmClassAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labClassName;
    }
}