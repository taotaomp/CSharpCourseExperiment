namespace WinApp150604111
{
    partial class FrmLogin_Hst
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
            this.user_Hst = new System.Windows.Forms.Label();
            this.passwords_Hst = new System.Windows.Forms.Label();
            this.txtName_Hst = new System.Windows.Forms.TextBox();
            this.txtKey_Hst = new System.Windows.Forms.TextBox();
            this.log_Hst = new System.Windows.Forms.Button();
            this.cancel_Hst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_Hst
            // 
            this.user_Hst.AutoSize = true;
            this.user_Hst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.user_Hst.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user_Hst.ForeColor = System.Drawing.Color.White;
            this.user_Hst.Location = new System.Drawing.Point(68, 144);
            this.user_Hst.Name = "user_Hst";
            this.user_Hst.Size = new System.Drawing.Size(72, 27);
            this.user_Hst.TabIndex = 0;
            this.user_Hst.Text = "用户名";
            this.user_Hst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwords_Hst
            // 
            this.passwords_Hst.AutoSize = true;
            this.passwords_Hst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.passwords_Hst.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwords_Hst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwords_Hst.Location = new System.Drawing.Point(88, 189);
            this.passwords_Hst.Name = "passwords_Hst";
            this.passwords_Hst.Size = new System.Drawing.Size(52, 27);
            this.passwords_Hst.TabIndex = 1;
            this.passwords_Hst.Text = "密码";
            // 
            // txtName_Hst
            // 
            this.txtName_Hst.Location = new System.Drawing.Point(174, 144);
            this.txtName_Hst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName_Hst.Name = "txtName_Hst";
            this.txtName_Hst.Size = new System.Drawing.Size(163, 25);
            this.txtName_Hst.TabIndex = 2;
            this.txtName_Hst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_Hst_KeyDown);
            // 
            // txtKey_Hst
            // 
            this.txtKey_Hst.Location = new System.Drawing.Point(174, 189);
            this.txtKey_Hst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKey_Hst.Name = "txtKey_Hst";
            this.txtKey_Hst.PasswordChar = '●';
            this.txtKey_Hst.Size = new System.Drawing.Size(163, 25);
            this.txtKey_Hst.TabIndex = 3;
            this.txtKey_Hst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKey_Hst_KeyDown);
            // 
            // log_Hst
            // 
            this.log_Hst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.log_Hst.ForeColor = System.Drawing.Color.White;
            this.log_Hst.Location = new System.Drawing.Point(130, 256);
            this.log_Hst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.log_Hst.Name = "log_Hst";
            this.log_Hst.Size = new System.Drawing.Size(75, 22);
            this.log_Hst.TabIndex = 4;
            this.log_Hst.Text = "登陆";
            this.log_Hst.UseVisualStyleBackColor = false;
            this.log_Hst.Click += new System.EventHandler(this.log_Hst_Click);
            // 
            // cancel_Hst
            // 
            this.cancel_Hst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.cancel_Hst.ForeColor = System.Drawing.Color.White;
            this.cancel_Hst.Location = new System.Drawing.Point(274, 256);
            this.cancel_Hst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_Hst.Name = "cancel_Hst";
            this.cancel_Hst.Size = new System.Drawing.Size(75, 22);
            this.cancel_Hst.TabIndex = 5;
            this.cancel_Hst.Text = "取消";
            this.cancel_Hst.UseVisualStyleBackColor = false;
            this.cancel_Hst.Click += new System.EventHandler(this.cancel_Hst_Click);
            // 
            // FrmLogin_Hst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinApp150604111.Properties.Resources.gamersky_06origin_11_2016932029E43;
            this.ClientSize = new System.Drawing.Size(443, 304);
            this.Controls.Add(this.cancel_Hst);
            this.Controls.Add(this.log_Hst);
            this.Controls.Add(this.txtKey_Hst);
            this.Controls.Add(this.txtName_Hst);
            this.Controls.Add(this.passwords_Hst);
            this.Controls.Add(this.user_Hst);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmLogin_Hst";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_Hst_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_Hst;
        private System.Windows.Forms.Label passwords_Hst;
        private System.Windows.Forms.TextBox txtName_Hst;
        private System.Windows.Forms.TextBox txtKey_Hst;
        private System.Windows.Forms.Button log_Hst;
        private System.Windows.Forms.Button cancel_Hst;
    }
}