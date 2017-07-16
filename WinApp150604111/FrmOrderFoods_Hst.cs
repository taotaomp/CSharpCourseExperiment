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
    public partial class FrmOrderFoods_Hst : Form
    {
        public FrmOrderFoods_Hst()
        {
            InitializeComponent();
        }

        String[,] Foods_Hst = new String[12,3];         //建立一个二维数组，用以储存菜品名称、价格、数量
        Image[] foodsPictures = new Image[12];
        int theCount_Hst = 0;      //已点菜数计数器
        int theMoney_Hst = 0;      //共计金额记录

        private void FrmOrderFoods_Hst_Load(object sender, EventArgs e)
        {
            #region 菜名 菜价
            Foods_Hst[0, 0] = "番茄炒蛋"; Foods_Hst[0, 1] = "7";
            Foods_Hst[1, 0] = "宫保鸡丁"; Foods_Hst[1, 1] = "23";
            Foods_Hst[2, 0] = "回锅肉"; Foods_Hst[2, 1] = "20";
            Foods_Hst[3, 0] = "麻婆豆腐"; Foods_Hst[3, 1] = "12";
            Foods_Hst[4, 0] = "泡椒牛柳"; Foods_Hst[4, 1] = "20";
            Foods_Hst[5, 0] = "青椒肉丝"; Foods_Hst[5, 1] = "18";
            Foods_Hst[6, 0] = "水煮肉片"; Foods_Hst[6, 1] = "23";
            Foods_Hst[7, 0] = "糖醋里脊"; Foods_Hst[7, 1] = "25";
            Foods_Hst[8, 0] = "土豆烧牛肉"; Foods_Hst[8, 1] = "25";
            Foods_Hst[9, 0] = "鱼香茄子"; Foods_Hst[9, 1] = "7";
            Foods_Hst[10, 0] = "芋儿烧鸡"; Foods_Hst[10, 1] = "20";
            Foods_Hst[11, 0] = "纸包鱼"; Foods_Hst[11, 1] = "30";
            #endregion
            for (int i_Hst = 0; i_Hst < 12; i_Hst++)       
            {
                Foods_Hst[i_Hst, 2] = "0";      //菜品份数设0
                picShowed[i_Hst] = 0;       //菜品图片展示与否开关设为关，意为此菜品未展示过
            }

            #region 菜品图片添加
            foodsPictures[0] = global::WinApp150604111.Properties.Resources.番茄炒蛋;
            foodsPictures[1] = global::WinApp150604111.Properties.Resources.宫保鸡丁;
            foodsPictures[2] = global::WinApp150604111.Properties.Resources.回锅肉;
            foodsPictures[3] = global::WinApp150604111.Properties.Resources.麻婆豆腐;
            foodsPictures[4] = global::WinApp150604111.Properties.Resources.泡椒牛柳;
            foodsPictures[5] = global::WinApp150604111.Properties.Resources.青椒肉丝;
            foodsPictures[6] = global::WinApp150604111.Properties.Resources.水煮肉片;
            foodsPictures[7] = global::WinApp150604111.Properties.Resources.糖醋里脊;
            foodsPictures[8] = global::WinApp150604111.Properties.Resources.土豆烧牛肉;
            foodsPictures[9] = global::WinApp150604111.Properties.Resources.鱼香茄子;
            foodsPictures[10] = global::WinApp150604111.Properties.Resources.芋儿烧鸡;
            foodsPictures[11] = global::WinApp150604111.Properties.Resources.纸包鱼;
            #endregion

            for (int i_Hst = 0; i_Hst < 12; i_Hst++)   //向菜单中添加所有菜品项   
            {
                Menu_Hst.Items.Add(Foods_Hst[i_Hst, 0] + "  ￥" + Foods_Hst[i_Hst, 1]);       
            }
            Menu_Hst.SelectionMode = SelectionMode.MultiSimple;     //设置菜单为可多选
            Order_Hst.SelectionMode = SelectionMode.MultiSimple;

        }

        private void AddSelected_Hst_Click(object sender, EventArgs e)
        {
            try
            {
                if (Menu_Hst.SelectedItem == null) throw new ArgumentNullException();
                for (int i_Hst = 0; i_Hst < Menu_Hst.SelectedIndices.Count; i_Hst++)        //第一个循环遍历已经选择的菜品
                {
                    for (int j_Hst = 0; j_Hst < 12; j_Hst++)        //第二个循环遍历所有已有的菜品
                    {
                        if (Foods_Hst[j_Hst, 0] + "  ￥" + Foods_Hst[j_Hst, 1] == Menu_Hst.SelectedItems[i_Hst].ToString())      //将已经选择的菜品与所有已有的菜品名字进行比对，相同则进行下一步处理
                        {
                            Foods_Hst[j_Hst, 2] = (int.Parse(Foods_Hst[j_Hst, 2]) + 1).ToString();  //使菜品记录的自身的数量+1
                            if (int.Parse(Foods_Hst[j_Hst, 2]) == 1)       //判断菜品是否是第一次添加，若是，则直接添加菜品
                            {
                                Order_Hst.Items.Add(Foods_Hst[j_Hst, 0] + " x" + Foods_Hst[j_Hst, 2]);       //添加当前选中的菜品，并显示数量
                            }
                            else        //若菜品不是第一次添加，则先删除前面添加的菜品，再重新添加当前菜品
                            {
                                Order_Hst.Items.Remove(Foods_Hst[j_Hst, 0] + " x" + (int.Parse(Foods_Hst[j_Hst, 2]) - 1).ToString());     //删除上次菜品
                                Order_Hst.Items.Add(Foods_Hst[j_Hst, 0] + " x" + Foods_Hst[j_Hst, 2]);        //重新添加
                            }
                            theCount_Hst++;     //使菜品计数器计数
                        }
                    }
                    
                }
                              
                theMoney_Hst = 0;   //将总金额置零
                for (int j_Hst = 0; j_Hst < 12; j_Hst++)
                {
                    theMoney_Hst += int.Parse(Foods_Hst[j_Hst, 1]) * int.Parse(Foods_Hst[j_Hst, 2]);  //计算总金额
                }

                Count_Hst.Text = "已点的菜品数：" + theCount_Hst.ToString();
                Money_Hst.Text = "消费金额：￥" + theMoney_Hst.ToString();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("您还未选中任何菜品！");
            }
        }

        private void AddAll_Hst_Click(object sender, EventArgs e)
        {
            for (int i_Hst = 0; i_Hst < 12; i_Hst++)
            {
                Foods_Hst[i_Hst, 2] = (int.Parse(Foods_Hst[i_Hst, 2]) + 1).ToString();        //使所有菜品记录的自身的数量+1
                if (int.Parse(Foods_Hst[i_Hst, 2]) == 1)       //判断菜品是否是第一次添加，若是，则直接添加菜品
                {
                    Order_Hst.Items.Add(Foods_Hst[i_Hst, 0] + " x" + Foods_Hst[i_Hst, 2]);       //添加当前选中的菜品，并显示数量
                }
                else        //若菜品不是第一次添加，则先删除前面添加的菜品，再重新添加当前菜品
                {
                    Order_Hst.Items.Remove(Foods_Hst[i_Hst, 0] + " x" + (int.Parse(Foods_Hst[i_Hst, 2]) - 1).ToString());     //删除上次菜品
                    Order_Hst.Items.Add(Foods_Hst[i_Hst, 0] + " x" + Foods_Hst[i_Hst, 2]);        //重新添加
                }
                theCount_Hst++;     //使菜品计数器计数
                theMoney_Hst = 0;   //将总金额置零
                for (int j_Hst = 0; j_Hst < 12; j_Hst++)
                {
                    theMoney_Hst += int.Parse(Foods_Hst[j_Hst, 1]) * int.Parse(Foods_Hst[j_Hst, 2]);  //计算总金额
                }

                Count_Hst.Text = "已点的菜品数：" + theCount_Hst.ToString();
                Money_Hst.Text = "消费金额： ￥" + theMoney_Hst.ToString();
            }

        }

        private void CancelSelected_Hst_Click(object sender, EventArgs e)
        {
            try
            {
                if (Order_Hst.SelectedItem == null) throw new ArgumentNullException();
                int temp_Hst = Order_Hst.SelectedIndices.Count;     //临时记录已经选择的菜品的数量
                for (int i_Hst = 0; i_Hst < temp_Hst; i_Hst++)        //第一个循环遍历已经选择的菜品
                {
                    for (int j_Hst = 0; j_Hst < 12; j_Hst++)        //第二个循环遍历所有已有的菜品
                    {
                        if (Foods_Hst[j_Hst, 0] + " x" + Foods_Hst[j_Hst, 2] == Order_Hst.SelectedItems[0].ToString())      //将已经选择的菜品与所有已有的菜品名字进行比对，相同则进行下一步处理
                        {                                                                                                     //这里SelectedItems的索引恒为零，因为把0删除后，索引为1的会变为0
                            Foods_Hst[j_Hst, 2] = (int.Parse(Foods_Hst[j_Hst, 2]) - 1).ToString();      //使菜品记录的自身的数量-1
                            if (int.Parse(Foods_Hst[j_Hst, 2]) == 0)       //判断菜品是否点了多次，若不是，则直接删除菜品
                            {
                                Order_Hst.Items.Remove(Foods_Hst[j_Hst, 0] + " x" + (int.Parse(Foods_Hst[j_Hst, 2]) + 1).ToString());      //移除当前选中的菜品
                            }
                            else        //若菜品点了多次，则先删除前面添加的菜品，使菜品数量-1，再重新添加当前菜品
                            {
                                Order_Hst.Items.Remove(Foods_Hst[j_Hst, 0] + " x" + (int.Parse(Foods_Hst[j_Hst, 2]) + 1).ToString());     //删除上次菜品
                                Order_Hst.Items.Add(Foods_Hst[j_Hst, 0] + " x" + Foods_Hst[j_Hst, 2]);        //重新添加
                            }
                            theCount_Hst--;     //使菜品计数器计数
                            break;
                        }
                    }
                }
                theMoney_Hst = 0;   //将总金额置零
                for (int j_Hst = 0; j_Hst < 12; j_Hst++)
                {
                    theMoney_Hst += int.Parse(Foods_Hst[j_Hst, 1]) * int.Parse(Foods_Hst[j_Hst, 2]);  //计算总金额
                }
                Count_Hst.Text = "已点的菜品数：" + theCount_Hst.ToString();
                Money_Hst.Text = "消费金额：￥" + theMoney_Hst.ToString(); 
            }
            catch(ArgumentNullException ) 
            {
                MessageBox.Show("您还未选中任何菜品！");
            }
        }

        private void CancelAll_Hst_Click(object sender, EventArgs e)
        {
            for (int i_Hst = 0; i_Hst < 12; i_Hst++)
            {
                Foods_Hst[i_Hst, 2] = "0";   //使菜品记录的自身的数量归零
            }
            Order_Hst.Items.Clear();  //清除所有选择项
            theCount_Hst = 0;     //使菜品计数器计数
            theMoney_Hst = 0;   //将总金额置零
            Count_Hst.Text = "已点的菜品数：" + theCount_Hst.ToString();
            Money_Hst.Text = "消费金额：" + theMoney_Hst.ToString();
        }

        int[] picShowed = new int[12];      //记录已选择过的图片

        private void Menu_Hst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Menu_Hst.SelectedItem == null)
            {
                preView_Hst.BackgroundImage = global::WinApp150604111.Properties.Resources.菜谱;      //设置未选中菜品时预览框出现的图片
                for (int i_Hst = 0; i_Hst < 12; i_Hst++)        
                {
                    picShowed[i_Hst] = 0;       //菜品图片展示与否开关设为关，意为此菜品未展示过
                }
            }
            else
            {
                preView_Hst.BackgroundImageLayout = ImageLayout.Center;     //设置图片的布局方式
                for (int i_Hst = 0; i_Hst < Menu_Hst.SelectedIndices.Count; i_Hst++)        //第一个循环遍历已经选择的菜品
                {
                    for (int j_Hst = 0; j_Hst < 12; j_Hst++)        //第二个循环遍历所有已有的菜品
                    {
                        if (Foods_Hst[j_Hst, 0] + "  ￥" + Foods_Hst[j_Hst, 1] == Menu_Hst.SelectedItems[i_Hst].ToString() && picShowed[j_Hst] != 1)       //将已经选择的菜品与所有已有的菜品名字进行比对，相同则进行下一步处理
                        {
                            preView_Hst.BackgroundImage = foodsPictures[j_Hst];     //展示该菜品图片
                            picShowed[j_Hst] = 1;       //此菜品已经被展示过，开关置为1
                        }
                    }
                }                  
            }
        }


    }
}
