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
    public partial class FrmLogin_Hst : Form
    {
        public FrmLogin_Hst()
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
            else if ((txtName_Hst.Text != "admin" && txtKey_Hst.Text != "admin") || txtName_Hst.Text != "admin" && txtKey_Hst.Text == "admin")
            {
                MessageBox.Show("用户名错误！");
                txtName_Hst.Focus();
                txtName_Hst.SelectAll();
            }
            else if (txtKey_Hst.Text != "admin")
            {
                MessageBox.Show("密码错误！");
                txtKey_Hst.Focus();
                txtKey_Hst.SelectAll();
            }
            else if (txtName_Hst.Text == "admin" && txtKey_Hst.Text == "admin")
            {
                MessageBox.Show("登陆成功！");
                this.Text = "已登陆";
                theSwitch_Hst = true;
                this.Hide();  
            }
        }

        private void FrmLogin_Hst_FormClosing(object sender, FormClosingEventArgs e)    //停用窗体右上角取消按钮
        {
            e.Cancel = true;
        }

    }
}
