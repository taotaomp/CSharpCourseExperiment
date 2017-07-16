using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinApp150604111
{
    public partial class FrmLoginFile_Hst : Form
    {
        public FrmLoginFile_Hst()
        {
            InitializeComponent();
        }

        public Boolean theSwitch_Hst;       //判断是否登陆的开关
        private void txtName_Hst_KeyDown(object sender, KeyEventArgs e)    //用户名框下的按键事件
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
            if (e.KeyCode == Keys.Enter && txtName_Hst.Text != "") 
            {
                txtKey_Hst.Focus();
            }
        }

        private void txtKey_Hst_KeyDown(object sender, KeyEventArgs e)   //密码框下的按键事件
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
            if (e.KeyCode == Keys.Enter && txtKey_Hst.Text != "") 
            {
                log_Hst.Focus();
            }
        }

        private void cancel_Hst_Click(object sender, EventArgs e)  //按下取消按钮的事件    
        {
            this.Hide();
        }

        private void log_Hst_Click(object sender, EventArgs e)    //按下登陆按钮的事件
        {
            if ((txtName_Hst.Text == "" && txtKey_Hst.Text == "") || (txtName_Hst.Text == "" && txtKey_Hst.Text != "")) 
            {
                MessageBox.Show("用户名不能为空！");
                txtName_Hst.Focus();        //聚焦
                txtName_Hst.SelectAll();        //全选
            }
            else if (txtKey_Hst.Text == "" )
            {
                MessageBox.Show("密码不能为空！");
                txtKey_Hst.Focus();
                txtKey_Hst.SelectAll();
            }
            else
            {
                int i_Hst;
                for (i_Hst = 0; i_Hst < TempUesrInfo_Hst.Length; i_Hst++)
                {
                    string[] part_Hst = TempUesrInfo_Hst[i_Hst].Split('\t');        //存放分离后的字符串
                    if (txtName_Hst.Text == part_Hst[0])    //判断用户名是否匹配
                    {
                        if (txtKey_Hst.Text != part_Hst[2])     //判断密码和用户名是否配对
                        {
                            MessageBox.Show("密码错误！");
                            txtKey_Hst.Focus();
                            txtKey_Hst.SelectAll();
                            break;
                        }
                        else if (txtKey_Hst.Text == part_Hst[2])
                        {
                            MessageBox.Show("登陆成功！");
                            this.Text = "已登陆";
                            theSwitch_Hst = true;
                            this.Hide();
                            break;
                        }
                    }
                }
                if (i_Hst == TempUesrInfo_Hst.Length)   //没在文本文件中找到匹配用户名的情况
                {
                    MessageBox.Show("用户名错误！");
                    txtName_Hst.Focus();
                    txtName_Hst.SelectAll();                
                }
            }        
        }

        private void FrmLogin_Hst_FormClosing(object sender, FormClosingEventArgs e)    //停用窗体右上角取消按钮
        {
            e.Cancel = true;
        }

        string[] TempUesrInfo_Hst = new string[5];  //临时存放读取的用户信息

        private void FrmLoginFile_Hst_Load(object sender, EventArgs e)      //窗体加载事件
        {           
            using (StreamReader SR_Hst = new StreamReader("UesrInfo.txt",Encoding.Default))
            {
                int Index_Hst = 0;
                while (!SR_Hst.EndOfStream)     //读取所有用户信息
                {
                    TempUesrInfo_Hst[Index_Hst] = SR_Hst.ReadLine();
                    Index_Hst++;
                }
            }
        }

    }
}
