namespace WinApp150604111
{
    partial class FrmQuery_Hst
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
            this.comboBox_Hst = new System.Windows.Forms.ComboBox();
            this.txtKey_Hst = new System.Windows.Forms.TextBox();
            this.Inquire_Hst = new System.Windows.Forms.Button();
            this.Update_Hst = new System.Windows.Forms.Button();
            this.dataGridView_Hst = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hst)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Hst
            // 
            this.comboBox_Hst.FormattingEnabled = true;
            this.comboBox_Hst.Location = new System.Drawing.Point(21, 38);
            this.comboBox_Hst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Hst.Name = "comboBox_Hst";
            this.comboBox_Hst.Size = new System.Drawing.Size(160, 23);
            this.comboBox_Hst.TabIndex = 0;
            this.comboBox_Hst.Text = "请选择要查询的项";
            this.comboBox_Hst.SelectedIndexChanged += new System.EventHandler(this.comboBox_Hst_SelectedIndexChanged);
            // 
            // txtKey_Hst
            // 
            this.txtKey_Hst.Location = new System.Drawing.Point(191, 38);
            this.txtKey_Hst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKey_Hst.Name = "txtKey_Hst";
            this.txtKey_Hst.Size = new System.Drawing.Size(203, 25);
            this.txtKey_Hst.TabIndex = 1;
            // 
            // Inquire_Hst
            // 
            this.Inquire_Hst.Location = new System.Drawing.Point(403, 35);
            this.Inquire_Hst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inquire_Hst.Name = "Inquire_Hst";
            this.Inquire_Hst.Size = new System.Drawing.Size(100, 29);
            this.Inquire_Hst.TabIndex = 2;
            this.Inquire_Hst.Text = "查询";
            this.Inquire_Hst.UseVisualStyleBackColor = true;
            this.Inquire_Hst.Click += new System.EventHandler(this.Inquire_Hst_Click);
            // 
            // Update_Hst
            // 
            this.Update_Hst.Location = new System.Drawing.Point(511, 35);
            this.Update_Hst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update_Hst.Name = "Update_Hst";
            this.Update_Hst.Size = new System.Drawing.Size(100, 29);
            this.Update_Hst.TabIndex = 3;
            this.Update_Hst.Text = "更新";
            this.Update_Hst.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Hst
            // 
            this.dataGridView_Hst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Hst.Location = new System.Drawing.Point(21, 71);
            this.dataGridView_Hst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Hst.Name = "dataGridView_Hst";
            this.dataGridView_Hst.RowTemplate.Height = 23;
            this.dataGridView_Hst.Size = new System.Drawing.Size(589, 240);
            this.dataGridView_Hst.TabIndex = 4;
            // 
            // FrmQuery_Hst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 326);
            this.Controls.Add(this.dataGridView_Hst);
            this.Controls.Add(this.Update_Hst);
            this.Controls.Add(this.Inquire_Hst);
            this.Controls.Add(this.txtKey_Hst);
            this.Controls.Add(this.comboBox_Hst);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuery_Hst";
            this.ShowIcon = false;
            this.Text = "信息查询";
            this.Load += new System.EventHandler(this.FrmQuery_Hst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Hst;
        private System.Windows.Forms.TextBox txtKey_Hst;
        private System.Windows.Forms.Button Inquire_Hst;
        private System.Windows.Forms.Button Update_Hst;
        private System.Windows.Forms.DataGridView dataGridView_Hst;
    }
}