using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp150604111
{
    public partial class FrmMain_Hst : Form
    {
        public FrmMain_Hst()
        {
            InitializeComponent();
        }

        FrmLogin_Hst fl_Hst = new FrmLogin_Hst();
        FrmLoginFile_Hst flf_Hst = new FrmLoginFile_Hst();       //建立全局登陆窗口对象
        Image[] i_Hst = new Image[3];
        int Index_Hst = 0;

        private void FrmMain_Hst_Load(object sender, EventArgs e)
        {
            flf_Hst.MdiParent = this;        //登陆窗口弹出
            flf_Hst.Show();

            this.BackgroundImageLayout = ImageLayout.Stretch;
            
            i_Hst[0] = global::WinApp150604111.Properties.Resources.full_res__7_;
            i_Hst[1] = global::WinApp150604111.Properties.Resources.full_res__1_;
            i_Hst[2] = global::WinApp150604111.Properties.Resources.full_res__6_;

            this.BackgroundImage = i_Hst[0]; //设置背景图片
            
            实验三选择菜单项_Hst.Visible = false;
            实验四选择菜单项_Hst.Visible = false;
            实验五选择菜单项_Hst.Visible = false;
            timer1_Hst.Interval = 100;
            timer1_Hst.Enabled = true;
            timer2_Hst.Interval = 5000;
            timer2_Hst.Enabled = true;
        }

        private void FrmMain_Hst_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 双色球菜单项_Hst_Click(object sender, EventArgs e)
        {
            FrmDoubleColorBall_Hst fdcb_Hst = new FrmDoubleColorBall_Hst();
            fdcb_Hst.MdiParent = this;
            fdcb_Hst.Show();
        }

        private void 小游戏菜单项_Hst_Click(object sender, EventArgs e)
        {
            FrmMouse_Hst fm_Hst = new FrmMouse_Hst();
            fm_Hst.MdiParent = this;
            fm_Hst.Show();
        }

        private void timer1_Hst_Tick(object sender, EventArgs e)
        {
            if (flf_Hst.theSwitch_Hst == true || fl_Hst.theSwitch_Hst == true)                   //实时监测用户是否登陆
            {
                实验三选择菜单项_Hst.Visible = true;
                实验四选择菜单项_Hst.Visible = true;
                实验五选择菜单项_Hst.Visible = true;
                timer1_Hst.Stop();                  //登陆则停止监测
            }
        }

        private void 退出项_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 登录项_Click(object sender, EventArgs e)
        {
            fl_Hst.MdiParent = this;
            fl_Hst.Show();
        }

        private void 注销项_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要退出登录吗？", "您正在注销！", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                实验三选择菜单项_Hst.Visible = false;       //使实验不可见
                实验四选择菜单项_Hst.Visible = false;
                实验五选择菜单项_Hst.Visible = false;
                flf_Hst.theSwitch_Hst = false;       //关闭登陆开关
                fl_Hst.theSwitch_Hst = false; 
                timer1_Hst.Start();         //打开登陆监测
            }
        }

        private void timer2_Hst_Tick(object sender, EventArgs e)        //用于背景图片更改
        {
            this.BackgroundImage = i_Hst[Index_Hst];
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Index_Hst++;
            if (Index_Hst == 3)
            {
                Index_Hst = 0;
            }
        }

        private void 生肖和爱好菜单项_Hst_Click(object sender, EventArgs e)
        {
            FrmSx_Ah_Hst FSA_Hst = new FrmSx_Ah_Hst();
            FSA_Hst.MdiParent = this;
            FSA_Hst.StartPosition = FormStartPosition.Manual;
            FSA_Hst.Location = new Point((this.Width - FSA_Hst.Width) / 2, (this.Height - FSA_Hst.Height) * 6 / 7);
            FSA_Hst.Show();
        }

        private void 电子菜单菜单项_Hst_Click(object sender, EventArgs e)
        {
            FrmOrderFoods_Hst FOF_Hst = new FrmOrderFoods_Hst();
            FOF_Hst.MdiParent = this;
            FOF_Hst.StartPosition = FormStartPosition.CenterScreen;
            FOF_Hst.Show();
        }
        
        private void 综合应用菜单项_Hst_Click(object sender, EventArgs e)
        {
            FrmIntegrated_Hst FI_Hst = new FrmIntegrated_Hst();
            FI_Hst.MdiParent = this;
            FI_Hst.StartPosition = FormStartPosition.CenterScreen;
            FI_Hst.Show();
        }

        private void 登陆File_Hst_Click(object sender, EventArgs e)
        {
            flf_Hst.MdiParent = this;
            flf_Hst.Show();
        }

        private void 双色球File_Hst_Click(object sender, EventArgs e)
        {
            FrmDoubleColorBallFile_Hst fdcbf_Hst = new FrmDoubleColorBallFile_Hst();
            fdcbf_Hst.MdiParent = this;
            fdcbf_Hst.Show();
        }

        private void 信息维护_Hst_Click(object sender, EventArgs e)
        {
            FrmUpdate_Hst fu_Hst = new FrmUpdate_Hst();
            fu_Hst.MdiParent = this;
            fu_Hst.Show();
        }

        private void 信息查询_Hst_Click(object sender, EventArgs e)
        {
            FrmQuery_Hst fq_Hst = new FrmQuery_Hst();
            fq_Hst.MdiParent = this;
            fq_Hst.Show();
        }

        private void 实验七选择菜单项_Hst_Click(object sender, EventArgs e)
        {

        }
   
    }
}
