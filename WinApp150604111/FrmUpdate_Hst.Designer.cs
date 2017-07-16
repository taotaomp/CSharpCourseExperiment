namespace WinApp150604111
{
    partial class FrmUpdate_Hst
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
            this.labelNum_Hst = new System.Windows.Forms.Label();
            this.labelName_Hst = new System.Windows.Forms.Label();
            this.txtName_Hst = new System.Windows.Forms.TextBox();
            this.labelAge_Hst = new System.Windows.Forms.Label();
            this.txtAge_Hst = new System.Windows.Forms.TextBox();
            this.labelSex_Hst = new System.Windows.Forms.Label();
            this.radioButtonMale_Hst = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale_Hst = new System.Windows.Forms.RadioButton();
            this.labelPhoto_Hst = new System.Windows.Forms.Label();
            this.pictureBox_Hst = new System.Windows.Forms.PictureBox();
            this.buttonFindPic_Hst = new System.Windows.Forms.Button();
            this.AddInfo_Hst = new System.Windows.Forms.Button();
            this.Modify_Hst = new System.Windows.Forms.Button();
            this.Delete_Hst = new System.Windows.Forms.Button();
            this.CancelOperation_Hst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hst)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Hst
            // 
            this.comboBox_Hst.FormattingEnabled = true;
            this.comboBox_Hst.Location = new System.Drawing.Point(77, 36);
            this.comboBox_Hst.Name = "comboBox_Hst";
            this.comboBox_Hst.Size = new System.Drawing.Size(76, 20);
            this.comboBox_Hst.TabIndex = 0;
            this.comboBox_Hst.SelectedIndexChanged += new System.EventHandler(this.comboBox_Hst_SelectedIndexChanged);
            // 
            // labelNum_Hst
            // 
            this.labelNum_Hst.AutoSize = true;
            this.labelNum_Hst.ForeColor = System.Drawing.Color.Black;
            this.labelNum_Hst.Location = new System.Drawing.Point(30, 39);
            this.labelNum_Hst.Name = "labelNum_Hst";
            this.labelNum_Hst.Size = new System.Drawing.Size(41, 12);
            this.labelNum_Hst.TabIndex = 1;
            this.labelNum_Hst.Text = "学号：";
            // 
            // labelName_Hst
            // 
            this.labelName_Hst.AutoSize = true;
            this.labelName_Hst.ForeColor = System.Drawing.Color.Black;
            this.labelName_Hst.Location = new System.Drawing.Point(30, 73);
            this.labelName_Hst.Name = "labelName_Hst";
            this.labelName_Hst.Size = new System.Drawing.Size(41, 12);
            this.labelName_Hst.TabIndex = 1;
            this.labelName_Hst.Text = "姓名：";
            // 
            // txtName_Hst
            // 
            this.txtName_Hst.Location = new System.Drawing.Point(77, 70);
            this.txtName_Hst.Name = "txtName_Hst";
            this.txtName_Hst.Size = new System.Drawing.Size(76, 21);
            this.txtName_Hst.TabIndex = 2;
            // 
            // labelAge_Hst
            // 
            this.labelAge_Hst.AutoSize = true;
            this.labelAge_Hst.ForeColor = System.Drawing.Color.Black;
            this.labelAge_Hst.Location = new System.Drawing.Point(30, 109);
            this.labelAge_Hst.Name = "labelAge_Hst";
            this.labelAge_Hst.Size = new System.Drawing.Size(41, 12);
            this.labelAge_Hst.TabIndex = 1;
            this.labelAge_Hst.Text = "年龄：";
            // 
            // txtAge_Hst
            // 
            this.txtAge_Hst.Location = new System.Drawing.Point(77, 106);
            this.txtAge_Hst.Name = "txtAge_Hst";
            this.txtAge_Hst.Size = new System.Drawing.Size(76, 21);
            this.txtAge_Hst.TabIndex = 2;
            // 
            // labelSex_Hst
            // 
            this.labelSex_Hst.AutoSize = true;
            this.labelSex_Hst.ForeColor = System.Drawing.Color.Black;
            this.labelSex_Hst.Location = new System.Drawing.Point(30, 142);
            this.labelSex_Hst.Name = "labelSex_Hst";
            this.labelSex_Hst.Size = new System.Drawing.Size(41, 12);
            this.labelSex_Hst.TabIndex = 1;
            this.labelSex_Hst.Text = "性别：";
            // 
            // radioButtonMale_Hst
            // 
            this.radioButtonMale_Hst.AutoSize = true;
            this.radioButtonMale_Hst.ForeColor = System.Drawing.Color.Black;
            this.radioButtonMale_Hst.Location = new System.Drawing.Point(77, 142);
            this.radioButtonMale_Hst.Name = "radioButtonMale_Hst";
            this.radioButtonMale_Hst.Size = new System.Drawing.Size(35, 16);
            this.radioButtonMale_Hst.TabIndex = 3;
            this.radioButtonMale_Hst.TabStop = true;
            this.radioButtonMale_Hst.Text = "男";
            this.radioButtonMale_Hst.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale_Hst
            // 
            this.radioButtonFemale_Hst.AutoSize = true;
            this.radioButtonFemale_Hst.ForeColor = System.Drawing.Color.Black;
            this.radioButtonFemale_Hst.Location = new System.Drawing.Point(118, 142);
            this.radioButtonFemale_Hst.Name = "radioButtonFemale_Hst";
            this.radioButtonFemale_Hst.Size = new System.Drawing.Size(35, 16);
            this.radioButtonFemale_Hst.TabIndex = 4;
            this.radioButtonFemale_Hst.TabStop = true;
            this.radioButtonFemale_Hst.Text = "女";
            this.radioButtonFemale_Hst.UseVisualStyleBackColor = true;
            // 
            // labelPhoto_Hst
            // 
            this.labelPhoto_Hst.AutoSize = true;
            this.labelPhoto_Hst.ForeColor = System.Drawing.Color.Black;
            this.labelPhoto_Hst.Location = new System.Drawing.Point(196, 10);
            this.labelPhoto_Hst.Name = "labelPhoto_Hst";
            this.labelPhoto_Hst.Size = new System.Drawing.Size(41, 12);
            this.labelPhoto_Hst.TabIndex = 5;
            this.labelPhoto_Hst.Text = "照片：";
            // 
            // pictureBox_Hst
            // 
            this.pictureBox_Hst.Location = new System.Drawing.Point(172, 36);
            this.pictureBox_Hst.Name = "pictureBox_Hst";
            this.pictureBox_Hst.Size = new System.Drawing.Size(94, 100);
            this.pictureBox_Hst.TabIndex = 6;
            this.pictureBox_Hst.TabStop = false;
            // 
            // buttonFindPic_Hst
            // 
            this.buttonFindPic_Hst.ForeColor = System.Drawing.Color.Black;
            this.buttonFindPic_Hst.Location = new System.Drawing.Point(183, 142);
            this.buttonFindPic_Hst.Name = "buttonFindPic_Hst";
            this.buttonFindPic_Hst.Size = new System.Drawing.Size(75, 27);
            this.buttonFindPic_Hst.TabIndex = 7;
            this.buttonFindPic_Hst.Text = "浏览";
            this.buttonFindPic_Hst.UseVisualStyleBackColor = true;
            this.buttonFindPic_Hst.Click += new System.EventHandler(this.buttonFindPic_Hst_Click);
            // 
            // AddInfo_Hst
            // 
            this.AddInfo_Hst.ForeColor = System.Drawing.Color.Black;
            this.AddInfo_Hst.Location = new System.Drawing.Point(32, 200);
            this.AddInfo_Hst.Name = "AddInfo_Hst";
            this.AddInfo_Hst.Size = new System.Drawing.Size(75, 23);
            this.AddInfo_Hst.TabIndex = 8;
            this.AddInfo_Hst.Text = "添加";
            this.AddInfo_Hst.UseVisualStyleBackColor = true;
            this.AddInfo_Hst.Click += new System.EventHandler(this.AddInfo_Hst_Click);
            // 
            // Modify_Hst
            // 
            this.Modify_Hst.ForeColor = System.Drawing.Color.Black;
            this.Modify_Hst.Location = new System.Drawing.Point(113, 199);
            this.Modify_Hst.Name = "Modify_Hst";
            this.Modify_Hst.Size = new System.Drawing.Size(75, 23);
            this.Modify_Hst.TabIndex = 9;
            this.Modify_Hst.Text = "修改";
            this.Modify_Hst.UseVisualStyleBackColor = true;
            this.Modify_Hst.Click += new System.EventHandler(this.Modify_Hst_Click);
            // 
            // Delete_Hst
            // 
            this.Delete_Hst.ForeColor = System.Drawing.Color.Black;
            this.Delete_Hst.Location = new System.Drawing.Point(194, 199);
            this.Delete_Hst.Name = "Delete_Hst";
            this.Delete_Hst.Size = new System.Drawing.Size(75, 23);
            this.Delete_Hst.TabIndex = 10;
            this.Delete_Hst.Text = "删除";
            this.Delete_Hst.UseVisualStyleBackColor = true;
            this.Delete_Hst.Click += new System.EventHandler(this.Delete_Hst_Click);
            // 
            // CancelOperation_Hst
            // 
            this.CancelOperation_Hst.ForeColor = System.Drawing.Color.Black;
            this.CancelOperation_Hst.Location = new System.Drawing.Point(113, 229);
            this.CancelOperation_Hst.Name = "CancelOperation_Hst";
            this.CancelOperation_Hst.Size = new System.Drawing.Size(75, 23);
            this.CancelOperation_Hst.TabIndex = 8;
            this.CancelOperation_Hst.Text = "取消";
            this.CancelOperation_Hst.UseVisualStyleBackColor = true;
            this.CancelOperation_Hst.Click += new System.EventHandler(this.CancelOperation_Hst_Click);
            // 
            // FrmUpdate_Hst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Delete_Hst);
            this.Controls.Add(this.Modify_Hst);
            this.Controls.Add(this.CancelOperation_Hst);
            this.Controls.Add(this.AddInfo_Hst);
            this.Controls.Add(this.buttonFindPic_Hst);
            this.Controls.Add(this.pictureBox_Hst);
            this.Controls.Add(this.labelPhoto_Hst);
            this.Controls.Add(this.radioButtonFemale_Hst);
            this.Controls.Add(this.radioButtonMale_Hst);
            this.Controls.Add(this.txtAge_Hst);
            this.Controls.Add(this.labelSex_Hst);
            this.Controls.Add(this.labelAge_Hst);
            this.Controls.Add(this.txtName_Hst);
            this.Controls.Add(this.labelName_Hst);
            this.Controls.Add(this.labelNum_Hst);
            this.Controls.Add(this.comboBox_Hst);
            this.Name = "FrmUpdate_Hst";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息维护";
            this.Load += new System.EventHandler(this.FrmUpdate_Hst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Hst;
        private System.Windows.Forms.Label labelNum_Hst;
        private System.Windows.Forms.Label labelName_Hst;
        private System.Windows.Forms.TextBox txtName_Hst;
        private System.Windows.Forms.Label labelAge_Hst;
        private System.Windows.Forms.TextBox txtAge_Hst;
        private System.Windows.Forms.Label labelSex_Hst;
        private System.Windows.Forms.RadioButton radioButtonMale_Hst;
        private System.Windows.Forms.RadioButton radioButtonFemale_Hst;
        private System.Windows.Forms.Label labelPhoto_Hst;
        private System.Windows.Forms.PictureBox pictureBox_Hst;
        private System.Windows.Forms.Button buttonFindPic_Hst;
        private System.Windows.Forms.Button AddInfo_Hst;
        private System.Windows.Forms.Button Modify_Hst;
        private System.Windows.Forms.Button Delete_Hst;
        private System.Windows.Forms.Button CancelOperation_Hst;
    }
}