namespace WinApp150604111
{
    partial class FrmLinqPages_Hst
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PgUp_Hst = new System.Windows.Forms.Button();
            this.PgDown_Hst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(382, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // PgUp_Hst
            // 
            this.PgUp_Hst.Location = new System.Drawing.Point(206, 206);
            this.PgUp_Hst.Name = "PgUp_Hst";
            this.PgUp_Hst.Size = new System.Drawing.Size(77, 29);
            this.PgUp_Hst.TabIndex = 1;
            this.PgUp_Hst.Text = "上一页";
            this.PgUp_Hst.UseVisualStyleBackColor = true;
            // 
            // PgDown_Hst
            // 
            this.PgDown_Hst.Location = new System.Drawing.Point(308, 206);
            this.PgDown_Hst.Name = "PgDown_Hst";
            this.PgDown_Hst.Size = new System.Drawing.Size(77, 29);
            this.PgDown_Hst.TabIndex = 1;
            this.PgDown_Hst.Text = "下一页";
            this.PgDown_Hst.UseVisualStyleBackColor = true;
            // 
            // FrmLinqPages_Hst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 238);
            this.Controls.Add(this.PgDown_Hst);
            this.Controls.Add(this.PgUp_Hst);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmLinqPages_Hst";
            this.Text = "FrmLinqPages_Hst";
            this.Load += new System.EventHandler(this.FrmLinqPages_Hst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PgUp_Hst;
        private System.Windows.Forms.Button PgDown_Hst;
    }
}