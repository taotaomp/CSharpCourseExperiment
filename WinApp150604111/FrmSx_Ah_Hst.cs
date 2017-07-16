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
    public partial class FrmSx_Ah_Hst : Form
    {
        public FrmSx_Ah_Hst()
        {
            InitializeComponent();
        }
        #region 生肖

        char[] ShengXiao_Hst = { '鼠', '牛', '虎', '兔', '龙', '蛇', '马', '羊', '猴', '鸡', '狗', '猪' };      //定义字符型数组存放生肖
        int Index_Hst = 0;      //生肖索引
        int IndexForReSelect_Hst = 0;       //生肖索引(建立不同的生肖索引，防止不同功能相互影响)
        RadioButton[] NameOfRadioButton_Hst = new RadioButton[12];        //建立数组储存单选按钮
        int[] reYear_Hst = new int[12];             //用于记录反选操作所要选的年

        private void FrmSx_Ah_Hst_Load(object sender, EventArgs e)
        {
            #region 计算反选（即选生肖定位年份）时的年份数据

            /* 设当前年生肖为8，求与生肖8最近的其他生肖
             * 0 1 2 3 4 5 6 7 8 9 10 11 12 0 1 2 3
                               8
               8 7 6 5 4 3 2 1 0 1  2  3  4 5 6 7 8
             * 8-i与13+i-8...比较
             */
            IndexForReSelect_Hst = (DateTime.Now.Year - 1936) % 12;        //计算当前年生肖索引
            for (int i_Hst = 0; i_Hst < 12; i_Hst++)
            {
                if (IndexForReSelect_Hst - i_Hst < 13-IndexForReSelect_Hst + i_Hst)               
                {
                    reYear_Hst[i_Hst] = DateTime.Now.Year - IndexForReSelect_Hst + i_Hst;   //i的变化对应了不同生肖的年应有的年份                           
                }
                else if (IndexForReSelect_Hst - i_Hst >= 13 - IndexForReSelect_Hst + i_Hst)
                {
                    reYear_Hst[i_Hst] = DateTime.Now.Year + (12 - IndexForReSelect_Hst) + i_Hst;
                }
            }
            #endregion

            NameOfRadioButton_Hst[0] = Sx1_Hst;
            NameOfRadioButton_Hst[1] = Sx2_Hst;
            NameOfRadioButton_Hst[2] = Sx3_Hst;
            NameOfRadioButton_Hst[3] = Sx4_Hst;
            NameOfRadioButton_Hst[4] = Sx5_Hst;
            NameOfRadioButton_Hst[5] = Sx6_Hst;
            NameOfRadioButton_Hst[6] = Sx7_Hst;
            NameOfRadioButton_Hst[7] = Sx8_Hst;
            NameOfRadioButton_Hst[8] = Sx9_Hst;
            NameOfRadioButton_Hst[9] = Sx10_Hst;
            NameOfRadioButton_Hst[10] = Sx11_Hst;
            NameOfRadioButton_Hst[11] = Sx12_Hst;

            for (int i_Hst = DateTime.Now.Year - 80; i_Hst < DateTime.Now.Year + 30; i_Hst++)       //为年份选择添加年份
            {
                comboBox_Hst.Items.Add(i_Hst);
            }
            comboBox_Hst.Text = DateTime.Now.Year.ToString();       //设置起始年份为当前年

            NameOfAh_Hst[0] = Ah1_Hst;     //将爱好的名称录入数组
            NameOfAh_Hst[1] = Ah2_Hst;
            NameOfAh_Hst[2] = Ah3_Hst;
            NameOfAh_Hst[3] = Ah4_Hst;
            NameOfAh_Hst[4] = Ah5_Hst;
            NameOfAh_Hst[5] = Ah6_Hst;

            comboBox_Hst.DropDownStyle = ComboBoxStyle.DropDownList; 
        }
        
        private void comboBox_Hst_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index_Hst = (int.Parse(comboBox_Hst.Text) - 1936) % 12;        //计算当前年生肖
            NameOfRadioButton_Hst[Index_Hst].Select();      //使单选按钮选中
            return;
            
        }

        private void Sx1_Hst_MouseClick(object sender, MouseEventArgs e)    //使用共享事件
        {                                                                   
            for (int i_Hst = 0; i_Hst < 12; i_Hst++)
            {
                if (sender.Equals(NameOfRadioButton_Hst[i_Hst]))             
                {
                    comboBox_Hst.Text = reYear_Hst[i_Hst].ToString();       //改变comboBox的年份值
                }
            }           
        }

        #endregion

        #region 爱好

        CheckBox[] NameOfAh_Hst = new CheckBox[6];      //建立字符串数组以记录爱好的名称
        bool[] register_Hst = new bool[6];        //登记爱好是否被选中 true为已选中，false为未选中

        private void Ah1_Hst_MouseClick(object sender, MouseEventArgs e)        //使用了事件共享
        {
            txtOfSelected_Hst.Clear();          //先清除文本框
            for (int i_Hst = 0; i_Hst < 6; i_Hst++)
            {
                if (sender.Equals(NameOfAh_Hst[i_Hst]))
                {
                    if (NameOfAh_Hst[i_Hst].Checked == true)        //处理爱好的选中情况，并进行登记
                    {
                        register_Hst[i_Hst] = true;
                    }
                    else if (NameOfAh_Hst[i_Hst].Checked == false)
                    {
                        register_Hst[i_Hst] = false;
                    }
                }
            }
            for (int i_Hst = 0; i_Hst < 6; i_Hst++)     //将爱好写入文本框
            {
                if (register_Hst[i_Hst])            //登记为选中的才写入
                {
                    txtOfSelected_Hst.Text += NameOfAh_Hst[i_Hst].Text +"、";
                }
            }
            txtOfSelected_Hst.Text = txtOfSelected_Hst.Text.Remove(txtOfSelected_Hst.Text.Length - 1, 1);      //去除最后一个顿号（、）
        }     
        #endregion
    }
}
