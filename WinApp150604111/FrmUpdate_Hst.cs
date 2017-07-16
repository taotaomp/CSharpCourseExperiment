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
    public partial class FrmUpdate_Hst : Form
    {
        public FrmUpdate_Hst()
        {
            InitializeComponent();
        }

        string[] UserInfoStore_Hst = new string[20];        //用户信息临时储存字符串
        DataBase_Hst DB_Hst;        //声明数据库操作对象
        int count_Hst = 0;

        private void FrmUpdate_Hst_Load(object sender, EventArgs e)     //窗体加载事件
        {
            CancelOperation_Hst.Visible = false;        //设置各控件属性
            comboBox_Hst.DropDownStyle = ComboBoxStyle.DropDownList;
            txtName_Hst.ReadOnly = true;
            txtAge_Hst.ReadOnly = true;
            buttonFindPic_Hst.Enabled = false;
            radioButtonFemale_Hst.Enabled = false;
            radioButtonMale_Hst.Enabled = false;

            DB_Hst = new DataBase_Hst();       //实例化数据库操作对象
            DB_Hst.SqlCon_Hst();
            ReLoadComoBox();
            comboBox_Hst.Text = comboBox_Hst.Items[0].ToString() ;
            pictureBox_Hst.SizeMode = PictureBoxSizeMode.StretchImage;  //设置图像显示方式
        }

        private void ReLoadComoBox()        //重新加载ComoBox的方法
        {
            DB_Hst.SqlRea_Hst(UserInfoStore_Hst);       //读取数据库
            comboBox_Hst.Items.Clear();
            foreach (string item_Hst in UserInfoStore_Hst)      //遍历用户信息以装载comboBox
            {
                if (item_Hst != null)
                {
                    string[] temp_Hst = item_Hst.Split('#');
                    comboBox_Hst.Items.Add(temp_Hst[0]);
                    count_Hst++;
                }
            }
        }

        private void comboBox_Hst_SelectedIndexChanged(object sender, EventArgs e)      //comboBox项改变事件
        {
            foreach (string item_Hst in UserInfoStore_Hst)
            {
                if (item_Hst != null)
                {
                    string[] temp_Hst = item_Hst.Split('#');
                    if (comboBox_Hst.SelectedItem.ToString() == temp_Hst[0])    //通过比对ID判断用户，并设置信息
                    {
                        txtName_Hst.Text = temp_Hst[1];
                        txtAge_Hst.Text = temp_Hst[2];
                        if (temp_Hst[3] == "男")
                        {
                            radioButtonMale_Hst.Select();
                        }
                        else if (temp_Hst[3] == "女")
                        {
                            radioButtonFemale_Hst.Select();
                        }
                        pictureBox_Hst.ImageLocation = temp_Hst[4];
                    }
                }
            }
        }

        string picUrl_Hst ="";

        private void buttonFindPic_Hst_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog picSelect = new OpenFileDialog();
                picSelect.Filter = "头像|*.bmp";
                picSelect.ShowDialog();
                pictureBox_Hst.ImageLocation = picSelect.FileName;
                PhotoUrlDeal(picSelect.FileName);
            }
            catch(Exception )
            {
                MessageBox.Show("请从Data\\Image文件夹下选择图片");
            }

        }

        private void PhotoUrlDeal(string Url)       //图像路径处理方法
        {
            picUrl_Hst = "";
            string Temp_Pic_Hst = Url;
            string temp_temp_Pic_Hst = "Data";
            int flag_Hst = 0, j_Hst = 0, count = 0;
            for (int i_Hst = 0; i_Hst < temp_temp_Pic_Hst.Length; i_Hst++)
            {
                if (temp_temp_Pic_Hst[i_Hst] == Temp_Pic_Hst[j_Hst])
                {
                    j_Hst++;
                    count++;
                    if (count == temp_temp_Pic_Hst.Length - 1)
                    {
                        break;
                    }
                }
                else
                {
                    flag_Hst++;
                    j_Hst = flag_Hst;
                    i_Hst = 0;
                    count = 0;
                }
            }
            if (flag_Hst != 0)
            {
                for (int i_Hst = flag_Hst - 1; i_Hst < Temp_Pic_Hst.Length; i_Hst++)
                {
                    picUrl_Hst += Temp_Pic_Hst[i_Hst];
                }
            }
            else 
            {
                picUrl_Hst = Url;
            }
        }


        private void AddInfo_Hst_Click(object sender, EventArgs e)      //添加按钮的点击事件
        {
            CancelOperation_Hst.Visible = true;     //更改各控件的属性
            comboBox_Hst.DropDownStyle = ComboBoxStyle.DropDown;
            txtName_Hst.ReadOnly = false;
            txtAge_Hst.ReadOnly = false;
            buttonFindPic_Hst.Enabled = true;
            radioButtonFemale_Hst.Enabled = true;
            radioButtonMale_Hst.Enabled = true;

            if (AddInfo_Hst.Text == "添加")
            {
                Modify_Hst.Enabled = false;
                Delete_Hst.Enabled = false;
                AddInfo_Hst.Text = "确定";
                comboBox_Hst.Text = "";
                txtName_Hst.Text = "";
                txtAge_Hst.Text = "";
                pictureBox_Hst.ImageLocation = string.Empty;

            }
            else if (AddInfo_Hst.Text == "确定")
            {
                if (comboBox_Hst.Text != "")
                {
                    string temp_Sex_Hst;
                    if (radioButtonFemale_Hst.Checked)
                    {
                        temp_Sex_Hst = radioButtonFemale_Hst.Text;
                    }
                    else
                    {
                        temp_Sex_Hst = radioButtonMale_Hst.Text;
                    }
                    string temp_AddUserInfo_Hst = comboBox_Hst.Text + "#" + txtName_Hst.Text + "#" + txtAge_Hst.Text + "#" + temp_Sex_Hst + "#" + picUrl_Hst + "#";
                    DB_Hst.SqlInsert_Hst(temp_AddUserInfo_Hst);     //将信息插入数据库
                    Modify_Hst.Enabled = true;
                    Delete_Hst.Enabled = true;
                    AddInfo_Hst.Text = "添加";

                    CancelOperation_Hst.Visible = false;             //还原更改的各控件的属性
                    comboBox_Hst.DropDownStyle = ComboBoxStyle.DropDownList;
                    txtName_Hst.ReadOnly = true;
                    txtAge_Hst.ReadOnly = true;
                    buttonFindPic_Hst.Enabled = false;
                    radioButtonFemale_Hst.Enabled = false;
                    radioButtonMale_Hst.Enabled = false;

                    ReLoadComoBox();
                }
            }
        }
        

        private void CancelOperation_Hst_Click(object sender, EventArgs e)      //取消按钮点击事件
        {
            CancelOperation_Hst.Visible = false;        //还原更改的各控件的属性
            comboBox_Hst.DropDownStyle = ComboBoxStyle.DropDownList;
            txtName_Hst.ReadOnly = true;
            txtAge_Hst.ReadOnly = true;
            buttonFindPic_Hst.Enabled = false;
            radioButtonFemale_Hst.Enabled = false;
            radioButtonMale_Hst.Enabled = false;
        }

        private void Modify_Hst_Click(object sender, EventArgs e)       //修改按钮点击事件
        {
            CancelOperation_Hst.Visible = true;         //更改各控件的属性
            comboBox_Hst.Enabled = false;           /**/
            txtName_Hst.ReadOnly = false;
            txtAge_Hst.ReadOnly = false;
            buttonFindPic_Hst.Enabled = true;
            radioButtonFemale_Hst.Enabled = true;
            radioButtonMale_Hst.Enabled = true;

            if (Modify_Hst.Text == "修改")
            {
                AddInfo_Hst.Enabled = false;
                Delete_Hst.Enabled = false;
                Modify_Hst.Text = "确定";
            }
            else if (Modify_Hst.Text == "确定")
            {
                if (comboBox_Hst.Text != "")
                {
                    string temp_Sex_Hst;
                    if (radioButtonFemale_Hst.Checked)
                    {
                        temp_Sex_Hst = radioButtonFemale_Hst.Text;
                    }
                    else
                    {
                        temp_Sex_Hst = radioButtonMale_Hst.Text;
                    }
                    PhotoUrlDeal(pictureBox_Hst.ImageLocation);
                    string temp_ModifyUserInfo_Hst = comboBox_Hst.Text + "#" + txtName_Hst.Text + "#" + txtAge_Hst.Text + "#" + temp_Sex_Hst + "#" + picUrl_Hst + "#";
                    DB_Hst.SqlUpdate_Hst(temp_ModifyUserInfo_Hst);      //更新数据库信息
                    AddInfo_Hst.Enabled = true;
                    Delete_Hst.Enabled = true;
                    Modify_Hst.Text = "修改";

                    CancelOperation_Hst.Visible = false;        //还原更改的各控件的属性
                    comboBox_Hst.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBox_Hst.Enabled = true;    /**/
                    txtName_Hst.ReadOnly = true;
                    txtAge_Hst.ReadOnly = true;
                    buttonFindPic_Hst.Enabled = false;
                    radioButtonFemale_Hst.Enabled = false;
                    radioButtonMale_Hst.Enabled = false;

                    ReLoadComoBox();
                }
            }
        }

        private void Delete_Hst_Click(object sender, EventArgs e)       //删除按钮点击事件
        {
            if (DialogResult.Yes == MessageBox.Show("要删除这个人吗？", "提示", MessageBoxButtons.YesNo))
            {
                DB_Hst.SqlDelete_Hst(comboBox_Hst.Text);        //删除数据库中的信息

                ReLoadComoBox();
            }
        }
    }
}
