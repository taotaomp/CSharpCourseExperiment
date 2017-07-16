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
    public partial class FrmStart_Hst : Form
    {
        public FrmStart_Hst()
        {
            InitializeComponent();
        }

        private string[] str_Hst = new string[4];
        private int i_Hst = 0;
        private bool theSwitch;     //主窗体加载开关，只有数据库连接可用才开启

        private void FrmStart_Hst_Load(object sender, EventArgs e)
        {
            DataBase_Hst DBCheck_Hst = new DataBase_Hst();
            DBCheck_Hst.SqlCon_Hst();       //调用数据库连接方法
            if (DBCheck_Hst.conCheck_Hst())     //调用连接检查方法
            {
                str_Hst[2] = "连接可用..";
                str_Hst[3] = "正在进入";
                theSwitch = true;
                DBCheck_Hst.SqlDisCon_Hst();
            }
            else
            {
                str_Hst[2] = "连接不可用..";
                str_Hst[3] = "请检查后重试";
                theSwitch = false;
            }
            theSwitch = true;
            str_Hst[0] = "正在加载资源文件..";
            str_Hst[1] = "正在检查数据库连接...";
            
            timer1_Hst.Interval = 4500;
            timer1_Hst.Enabled = true;
       
            timer2_Hst.Interval = 1000;
            timer2_Hst.Enabled = true;

        }

        private void timer1_Hst_Tick(object sender, EventArgs e)
        {
            if (theSwitch)
            {
                FrmMain_Hst fm_Hst = new FrmMain_Hst();
                fm_Hst.Show();
            }
            else        //数据库连接失败则退出
            {
                Application.Exit();
            }
            timer1_Hst.Enabled = false;
            timer1_Hst.Stop();
            timer2_Hst.Stop();
            Hide();
            
        }

        private void timer2_Hst_Tick(object sender, EventArgs e)
        {
            txtInformation_Hst.Text = str_Hst[i_Hst++];
        }

      
    }
}
