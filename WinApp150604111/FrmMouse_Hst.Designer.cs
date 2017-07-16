namespace WinApp150604111
{
    partial class FrmMouse_Hst
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
            this.pictureBox_Hst = new System.Windows.Forms.PictureBox();
            this.picInfo_Hst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hst)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Hst
            // 
            this.pictureBox_Hst.BackgroundImage = global::WinApp150604111.Properties.Resources._20150826115726_u3JzL_thumb_700_0;
            this.pictureBox_Hst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Hst.Image = global::WinApp150604111.Properties.Resources.face01;
            this.pictureBox_Hst.Location = new System.Drawing.Point(300, 163);
            this.pictureBox_Hst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Hst.Name = "pictureBox_Hst";
            this.pictureBox_Hst.Size = new System.Drawing.Size(75, 81);
            this.pictureBox_Hst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Hst.TabIndex = 0;
            this.pictureBox_Hst.TabStop = false;
            this.pictureBox_Hst.MouseEnter += new System.EventHandler(this.pictureBox_Hst_MouseEnter);
            // 
            // picInfo_Hst
            // 
            this.picInfo_Hst.ForeColor = System.Drawing.Color.Black;
            this.picInfo_Hst.Location = new System.Drawing.Point(297, 246);
            this.picInfo_Hst.Name = "picInfo_Hst";
            this.picInfo_Hst.Size = new System.Drawing.Size(127, 15);
            this.picInfo_Hst.TabIndex = 1;
            this.picInfo_Hst.Text = "你能抓住我吗？";
            this.picInfo_Hst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMouse_Hst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinApp150604111.Properties.Resources._20150826115726_u3JzL_thumb_700_0;
            this.ClientSize = new System.Drawing.Size(1100, 710);
            this.Controls.Add(this.picInfo_Hst);
            this.Controls.Add(this.pictureBox_Hst);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMouse_Hst";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "试试看咯";
            this.Load += new System.EventHandler(this.FrmMouse_Hst_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FrmMouse_Hst_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label picInfo_Hst;
        private System.Windows.Forms.PictureBox pictureBox_Hst;
    }
}