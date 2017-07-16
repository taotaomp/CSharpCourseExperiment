namespace WinApp150604111
{
    partial class FrmOrderFoods_Hst
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
            this.AddSelected_Hst = new System.Windows.Forms.Button();
            this.AddAll_Hst = new System.Windows.Forms.Button();
            this.CancelSelected_Hst = new System.Windows.Forms.Button();
            this.CancelAll_Hst = new System.Windows.Forms.Button();
            this.InfoOfMenu_Hst = new System.Windows.Forms.Label();
            this.InfoOfChoosed_Hst = new System.Windows.Forms.Label();
            this.Menu_Hst = new System.Windows.Forms.ListBox();
            this.Order_Hst = new System.Windows.Forms.ListBox();
            this.Count_Hst = new System.Windows.Forms.Label();
            this.Money_Hst = new System.Windows.Forms.Label();
            this.preView_Hst = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // AddSelected_Hst
            // 
            this.AddSelected_Hst.ForeColor = System.Drawing.Color.Black;
            this.AddSelected_Hst.Location = new System.Drawing.Point(204, 125);
            this.AddSelected_Hst.Name = "AddSelected_Hst";
            this.AddSelected_Hst.Size = new System.Drawing.Size(83, 32);
            this.AddSelected_Hst.TabIndex = 0;
            this.AddSelected_Hst.Text = "添加选择";
            this.AddSelected_Hst.UseVisualStyleBackColor = true;
            this.AddSelected_Hst.Click += new System.EventHandler(this.AddSelected_Hst_Click);
            // 
            // AddAll_Hst
            // 
            this.AddAll_Hst.ForeColor = System.Drawing.Color.Black;
            this.AddAll_Hst.Location = new System.Drawing.Point(204, 163);
            this.AddAll_Hst.Name = "AddAll_Hst";
            this.AddAll_Hst.Size = new System.Drawing.Size(83, 32);
            this.AddAll_Hst.TabIndex = 1;
            this.AddAll_Hst.Text = "添加所有";
            this.AddAll_Hst.UseVisualStyleBackColor = true;
            this.AddAll_Hst.Click += new System.EventHandler(this.AddAll_Hst_Click);
            // 
            // CancelSelected_Hst
            // 
            this.CancelSelected_Hst.ForeColor = System.Drawing.Color.Black;
            this.CancelSelected_Hst.Location = new System.Drawing.Point(204, 232);
            this.CancelSelected_Hst.Name = "CancelSelected_Hst";
            this.CancelSelected_Hst.Size = new System.Drawing.Size(83, 32);
            this.CancelSelected_Hst.TabIndex = 2;
            this.CancelSelected_Hst.Text = "取消选择";
            this.CancelSelected_Hst.UseVisualStyleBackColor = true;
            this.CancelSelected_Hst.Click += new System.EventHandler(this.CancelSelected_Hst_Click);
            // 
            // CancelAll_Hst
            // 
            this.CancelAll_Hst.ForeColor = System.Drawing.Color.Black;
            this.CancelAll_Hst.Location = new System.Drawing.Point(204, 270);
            this.CancelAll_Hst.Name = "CancelAll_Hst";
            this.CancelAll_Hst.Size = new System.Drawing.Size(83, 32);
            this.CancelAll_Hst.TabIndex = 3;
            this.CancelAll_Hst.Text = "取消所有";
            this.CancelAll_Hst.UseVisualStyleBackColor = true;
            this.CancelAll_Hst.Click += new System.EventHandler(this.CancelAll_Hst_Click);
            // 
            // InfoOfMenu_Hst
            // 
            this.InfoOfMenu_Hst.AutoSize = true;
            this.InfoOfMenu_Hst.ForeColor = System.Drawing.Color.Black;
            this.InfoOfMenu_Hst.Location = new System.Drawing.Point(12, 30);
            this.InfoOfMenu_Hst.Name = "InfoOfMenu_Hst";
            this.InfoOfMenu_Hst.Size = new System.Drawing.Size(52, 15);
            this.InfoOfMenu_Hst.TabIndex = 2;
            this.InfoOfMenu_Hst.Text = "菜单：";
            // 
            // InfoOfChoosed_Hst
            // 
            this.InfoOfChoosed_Hst.AutoSize = true;
            this.InfoOfChoosed_Hst.ForeColor = System.Drawing.Color.Black;
            this.InfoOfChoosed_Hst.Location = new System.Drawing.Point(307, 30);
            this.InfoOfChoosed_Hst.Name = "InfoOfChoosed_Hst";
            this.InfoOfChoosed_Hst.Size = new System.Drawing.Size(82, 15);
            this.InfoOfChoosed_Hst.TabIndex = 2;
            this.InfoOfChoosed_Hst.Text = "选择的菜：";
            // 
            // Menu_Hst
            // 
            this.Menu_Hst.FormattingEnabled = true;
            this.Menu_Hst.ItemHeight = 15;
            this.Menu_Hst.Location = new System.Drawing.Point(15, 72);
            this.Menu_Hst.Name = "Menu_Hst";
            this.Menu_Hst.Size = new System.Drawing.Size(170, 274);
            this.Menu_Hst.TabIndex = 3;
            this.Menu_Hst.SelectedIndexChanged += new System.EventHandler(this.Menu_Hst_SelectedIndexChanged);
            // 
            // Order_Hst
            // 
            this.Order_Hst.FormattingEnabled = true;
            this.Order_Hst.ItemHeight = 15;
            this.Order_Hst.Location = new System.Drawing.Point(310, 72);
            this.Order_Hst.Name = "Order_Hst";
            this.Order_Hst.Size = new System.Drawing.Size(170, 274);
            this.Order_Hst.TabIndex = 4;
            // 
            // Count_Hst
            // 
            this.Count_Hst.AutoSize = true;
            this.Count_Hst.ForeColor = System.Drawing.Color.Black;
            this.Count_Hst.Location = new System.Drawing.Point(12, 367);
            this.Count_Hst.Name = "Count_Hst";
            this.Count_Hst.Size = new System.Drawing.Size(112, 15);
            this.Count_Hst.TabIndex = 5;
            this.Count_Hst.Text = "已点的菜品数：";
            // 
            // Money_Hst
            // 
            this.Money_Hst.AutoSize = true;
            this.Money_Hst.ForeColor = System.Drawing.Color.Black;
            this.Money_Hst.Location = new System.Drawing.Point(307, 367);
            this.Money_Hst.Name = "Money_Hst";
            this.Money_Hst.Size = new System.Drawing.Size(82, 15);
            this.Money_Hst.TabIndex = 5;
            this.Money_Hst.Text = "消费金额：";
            // 
            // preView_Hst
            // 
            this.preView_Hst.ForeColor = System.Drawing.Color.Black;
            this.preView_Hst.Location = new System.Drawing.Point(501, 30);
            this.preView_Hst.Name = "preView_Hst";
            this.preView_Hst.Size = new System.Drawing.Size(362, 352);
            this.preView_Hst.TabIndex = 6;
            this.preView_Hst.TabStop = false;
            this.preView_Hst.Text = "菜品预览";
            // 
            // FrmOrderFoods_Hst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinApp150604111.Properties.Resources.full_res__1_;
            this.ClientSize = new System.Drawing.Size(875, 394);
            this.Controls.Add(this.preView_Hst);
            this.Controls.Add(this.Money_Hst);
            this.Controls.Add(this.Count_Hst);
            this.Controls.Add(this.Order_Hst);
            this.Controls.Add(this.Menu_Hst);
            this.Controls.Add(this.InfoOfChoosed_Hst);
            this.Controls.Add(this.InfoOfMenu_Hst);
            this.Controls.Add(this.CancelAll_Hst);
            this.Controls.Add(this.CancelSelected_Hst);
            this.Controls.Add(this.AddAll_Hst);
            this.Controls.Add(this.AddSelected_Hst);
            this.Name = "FrmOrderFoods_Hst";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电子菜单";
            this.Load += new System.EventHandler(this.FrmOrderFoods_Hst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSelected_Hst;
        private System.Windows.Forms.Button AddAll_Hst;
        private System.Windows.Forms.Button CancelSelected_Hst;
        private System.Windows.Forms.Button CancelAll_Hst;
        private System.Windows.Forms.Label InfoOfMenu_Hst;
        private System.Windows.Forms.Label InfoOfChoosed_Hst;
        private System.Windows.Forms.ListBox Menu_Hst;
        private System.Windows.Forms.ListBox Order_Hst;
        private System.Windows.Forms.Label Count_Hst;
        private System.Windows.Forms.Label Money_Hst;
        private System.Windows.Forms.GroupBox preView_Hst;
    }
}