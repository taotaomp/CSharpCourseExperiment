namespace LinqPages
{
    partial class FrmLinqPages_Hst
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.PageUp_Hst = new System.Windows.Forms.Button();
            this.PageDown_Hst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(4, 3);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(314, 177);
            this.dgvInfo.TabIndex = 0;
            // 
            // PageUp_Hst
            // 
            this.PageUp_Hst.Location = new System.Drawing.Point(205, 189);
            this.PageUp_Hst.Name = "PageUp_Hst";
            this.PageUp_Hst.Size = new System.Drawing.Size(53, 23);
            this.PageUp_Hst.TabIndex = 1;
            this.PageUp_Hst.Text = "上一页";
            this.PageUp_Hst.UseVisualStyleBackColor = true;
            this.PageUp_Hst.Click += new System.EventHandler(this.PageUp_Hst_Click);
            // 
            // PageDown_Hst
            // 
            this.PageDown_Hst.Location = new System.Drawing.Point(264, 189);
            this.PageDown_Hst.Name = "PageDown_Hst";
            this.PageDown_Hst.Size = new System.Drawing.Size(53, 23);
            this.PageDown_Hst.TabIndex = 1;
            this.PageDown_Hst.Text = "下一页";
            this.PageDown_Hst.UseVisualStyleBackColor = true;
            this.PageDown_Hst.Click += new System.EventHandler(this.PageDown_Hst_Click);
            // 
            // FrmLinqPages_Hst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 219);
            this.Controls.Add(this.PageDown_Hst);
            this.Controls.Add(this.PageUp_Hst);
            this.Controls.Add(this.dgvInfo);
            this.Name = "FrmLinqPages_Hst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "使用LINQ技术实现数据分页";
            this.Load += new System.EventHandler(this.FrmLinqPages_Hst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button PageUp_Hst;
        private System.Windows.Forms.Button PageDown_Hst;
    }
}

