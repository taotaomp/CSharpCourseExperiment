namespace WinApp150604111
{
    partial class FrmStart_Hst
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStart_Hst));
            this.timer1_Hst = new System.Windows.Forms.Timer(this.components);
            this.timer2_Hst = new System.Windows.Forms.Timer(this.components);
            this.txtInformation_Hst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1_Hst
            // 
            this.timer1_Hst.Enabled = true;
            this.timer1_Hst.Interval = 1000;
            this.timer1_Hst.Tick += new System.EventHandler(this.timer1_Hst_Tick);
            // 
            // timer2_Hst
            // 
            this.timer2_Hst.Tick += new System.EventHandler(this.timer2_Hst_Tick);
            // 
            // txtInformation_Hst
            // 
            this.txtInformation_Hst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(109)))), ((int)(((byte)(26)))));
            this.txtInformation_Hst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInformation_Hst.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txtInformation_Hst.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInformation_Hst.Location = new System.Drawing.Point(9, 632);
            this.txtInformation_Hst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInformation_Hst.Name = "txtInformation_Hst";
            this.txtInformation_Hst.ReadOnly = true;
            this.txtInformation_Hst.Size = new System.Drawing.Size(440, 24);
            this.txtInformation_Hst.TabIndex = 0;
            this.txtInformation_Hst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmStart_Hst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 659);
            this.ControlBox = false;
            this.Controls.Add(this.txtInformation_Hst);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmStart_Hst";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmStart_Hst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1_Hst;
        private System.Windows.Forms.Timer timer2_Hst;
        private System.Windows.Forms.TextBox txtInformation_Hst;
    }
}

