namespace 学生信息管理系统
{
    partial class firmGradeList
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
            this.dgvGradeList = new System.Windows.Forms.DataGridView();
            this.GradeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGradeList
            // 
            this.dgvGradeList.AllowUserToAddRows = false;
            this.dgvGradeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGradeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradeID,
            this.GradeName});
            this.dgvGradeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGradeList.Location = new System.Drawing.Point(0, 0);
            this.dgvGradeList.Name = "dgvGradeList";
            this.dgvGradeList.RowHeadersWidth = 51;
            this.dgvGradeList.RowTemplate.Height = 27;
            this.dgvGradeList.Size = new System.Drawing.Size(721, 467);
            this.dgvGradeList.TabIndex = 0;
            // 
            // GradeID
            // 
            this.GradeID.DataPropertyName = "GradeID";
            this.GradeID.HeaderText = "年级编号";
            this.GradeID.MinimumWidth = 6;
            this.GradeID.Name = "GradeID";
            this.GradeID.ReadOnly = true;
            // 
            // GradeName
            // 
            this.GradeName.DataPropertyName = "GradeName";
            this.GradeName.HeaderText = "年级名称";
            this.GradeName.MinimumWidth = 6;
            this.GradeName.Name = "GradeName";
            this.GradeName.ReadOnly = true;
            // 
            // firmGradeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 467);
            this.Controls.Add(this.dgvGradeList);
            this.Name = "firmGradeList";
            this.Text = "年级列表页面";
            this.Load += new System.EventHandler(this.firmGradeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGradeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeName;
    }
}