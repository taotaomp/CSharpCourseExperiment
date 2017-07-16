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
    public partial class FrmMouse_Hst : Form
    {
        public FrmMouse_Hst()
        {
            InitializeComponent();
        }
        private Boolean theSwitch_Hst = false;      //MouseEnter事件的开关
        Random rx_Hst = new Random();                //用随机函数操纵图片坐标值
        Random ry_Hst = new Random();
        int x_Hst, y_Hst;
        private void pictureBox_Hst_MouseEnter(object sender, EventArgs e)
        {
            if (!theSwitch_Hst)
            {
                pictureBox_Hst.Image = global::WinApp150604111.Properties.Resources.face01;    //设置图片
                picInfo_Hst.Text = "你能抓住我吗";     //设置文本
                while (true)
                { 
                    x_Hst = 75 * rx_Hst.Next(0, 11);
                    ry_Hst.Next(0, 7);                          //为使随机数更随机，特地添加一次随机
                    y_Hst = 81 * ry_Hst.Next(0, 7);
                    //整个窗口内狗的数量为11*7个，移动的图像坐标应与背景单个狗对应重合
                    if (pictureBox_Hst.Location != new Point(x_Hst, y_Hst))        //检查生成的坐标是否和当前坐标重合
                    {
                        pictureBox_Hst.Location = new Point(x_Hst, y_Hst);
                        picInfo_Hst.Location = new Point(x_Hst - 15, y_Hst+ 78);        //标签框和图片框之间应保持的相对位置应为（-15，+78）
                        break;
                    }

                }
            }
            else 
            {
                pictureBox_Hst.Image = global::WinApp150604111.Properties.Resources.face02;
                picInfo_Hst.Text = "恭喜你";
            }
        }

        private void FrmMouse_Hst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)     //检查按下的是否为鼠标右键
            {
                theSwitch_Hst = !theSwitch_Hst;     //改变开关状态
            }
        }


        private void FrmMouse_Hst_Load(object sender, EventArgs e)
        {
            pictureBox_Hst.Location = new Point(0, 0);
            picInfo_Hst.Location = new Point(-15, 78);
        }
    }
}
