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
    public partial class FrmIntegrated_Hst : Form
    {
        public FrmIntegrated_Hst()
        {
            InitializeComponent();
        }

        int countOfAdd_Hst = 0; //添加计数器

        private void AddCity_Hst_Click(object sender, EventArgs e)      //对应“添加到—>”按钮
        {
            try
            {
                if (InfoOfCity_Hst.Items.Contains(City_Hst.Text)) throw new InvalidOperationException();        //判断添加的城市是否重复
                if (City_Hst.Text == "") throw new InvalidEnumArgumentException();   //防止添加空项
                InputLog_Hst(Log_Hst, "添加内容：\"" + City_Hst.Text + "\"到项目列表", DateTime.Now.ToString());      //记录日志
                InfoOfCity_Hst.Items.Add(City_Hst.Text);
                InfoOfCity_Hst.Text = City_Hst.Text;
                City_Hst.Text = "";     //输入框置零
                City_Hst.Focus();
                countOfAdd_Hst++;       //添加计数器计数                
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("该项已存在！");
            }
            catch (InvalidEnumArgumentException)
            {
                MessageBox.Show("不能添加空项！");
            }
        }

        private void Remove_Hst_Click(object sender, EventArgs e)       //对应“移除”按钮
        {          
            try
            {
                if (InfoOfCity_Hst.SelectedItem == null) throw new InvalidEnumArgumentException();
                InputLog_Hst(Log_Hst, "从项目列表中移除\"" + InfoOfCity_Hst.SelectedItem.ToString() + "\"项目", DateTime.Now.ToString());      //记录日志
                deletedItems_Hst.Items.Add(InfoOfCity_Hst.SelectedItem);
                InfoOfCity_Hst.Items.Remove(InfoOfCity_Hst.SelectedItem);
                countOfAdd_Hst--;   //添加计数器计数
                if (countOfAdd_Hst != 0)    //运用计数器防止程序异常
                {
                    InfoOfCity_Hst.Text = InfoOfCity_Hst.Items[0].ToString();
                }
            }
            catch (InvalidEnumArgumentException)
            {
                MessageBox.Show("你还没有选择要移除的项目！");
            }
        }

        private void seletedModmS_Hst_CheckedChanged(object sender, EventArgs e)        //对应单选和多选
        {
            if (sender.Equals(seletedModmS_Hst))    //单选选中
            {
                deletedItems_Hst.SelectionMode = SelectionMode.One;
            }
            else if (sender.Equals(seletedModmM_Hst))       //多选选中
            {
                deletedItems_Hst.SelectionMode = SelectionMode.MultiSimple;
            }
        }

        private void FrmIntegrated_Hst_Load(object sender, EventArgs e)     //窗体加载事件
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            seletedModmS_Hst.Select();      //初始为单选

            InfoOfCity_Hst.DropDownStyle = ComboBoxStyle.DropDownList;      //设置下拉方式

            columnHeader1.Text = "操作"; columnHeader1.Width = (int)Log_Hst.Width * 1 / 2;
            columnHeader2.Text = "时间"; columnHeader2.Width = (int)Log_Hst.Width * 1 / 2;
            InputLog_Hst(Log_Hst, "启动应用程序", DateTime.Now.ToString());

            statusStrip_Hst.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;     //设置状态栏的整体对齐方式

            MouseLocation_Hst.Width = ((int)statusStrip_Hst.Width * 1 / 3)-20;      //记住在改变宽度时，要先去把autosize关了
            MouseLocation_Hst.Text = "Windows 应用程序".ToString();


            TimeShow_Hst.Width = (int)statusStrip_Hst.Width * 1 / 3;
            timer1_Hst.Interval = 100;
            timer1_Hst.Enabled = true;

            DateShow_Hst.Width = ((int)statusStrip_Hst.Width * 1 / 3)-20;
            DateShow_Hst.Text = "当前日期：" + DateTime.Now.Year.ToString("00") + "年" + DateTime.Now.Month.ToString("00") + "月" + DateTime.Now.Day.ToString("00") + "日";


        }

        private void InputLog_Hst(ListView lv, string detail, string time)      //记录添加
        {
            //lv.BeginUpdate();
            //ListViewItem lvi = new ListViewItem();
            //lvi.Text = detail;
            //ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
            //lvsi.Text = time;
            //lvi.SubItems.Add(lvsi);
            //lv.Items.Add(lvi);
            //lv.EndUpdate();
            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Clear();
            lvi.SubItems[0].Text = detail;
            lvi.SubItems.Add(time);
            lv.Items.Add(lvi);
            
        }

        private void Restore_Hst_Click(object sender, EventArgs e)      //对应还原按钮
        {
            try
            {
                if (deletedItems_Hst.SelectedItem == null) throw new IndexOutOfRangeException();
                if (seletedModmM_Hst.Checked)       //多选生效
                {
                    int temp_Hst = deletedItems_Hst.SelectedItems.Count;        //临时记录项目条数，.Count属性在循环中会自动变化
                    for (int i_Hst = 0; i_Hst < temp_Hst; i_Hst++)
                    {
                        InputLog_Hst(Log_Hst, "从回收中心恢复\"" + deletedItems_Hst.SelectedItems[0].ToString() + "\"项目", DateTime.Now.ToString());      //记录日志
                        InfoOfCity_Hst.Items.Add(deletedItems_Hst.SelectedItems[0]);        //这里SelectedItems的索引恒为0，因为把0删除后，索引为1的会变为0
                        InfoOfCity_Hst.Text = deletedItems_Hst.SelectedItems[0].ToString();
                        deletedItems_Hst.Items.Remove(deletedItems_Hst.SelectedItems[0]);
                        countOfAdd_Hst++;
                    }           
                }
                else if (seletedModmS_Hst.Checked)      //单选生效
                {
                    InputLog_Hst(Log_Hst, "从回收中心恢复\"" + deletedItems_Hst.SelectedItem.ToString() + "\"项目", DateTime.Now.ToString());      //记录日志
                    InfoOfCity_Hst.Items.Add(deletedItems_Hst.SelectedItem);
                    InfoOfCity_Hst.Text = deletedItems_Hst.SelectedItem.ToString();
                    deletedItems_Hst.Items.Remove(deletedItems_Hst.SelectedItem);
                    countOfAdd_Hst++;
                }
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("你还没有选择要还原的项目！");
            }
        }

        private void Delete_Hst_Click(object sender, EventArgs e)       //对应删除按钮
        {
            try
            {
                if (deletedItems_Hst.SelectedItem == null) throw new IndexOutOfRangeException();
                if (seletedModmM_Hst.Checked)       //多选生效
                {
                    int temp_Hst = deletedItems_Hst.SelectedItems.Count;         //临时记录项目条数，.Count属性在循环中会自动变化
                    for (int i_Hst = 0; i_Hst < temp_Hst; i_Hst++)
                    {
                        InputLog_Hst(Log_Hst, "从回收中心删除\"" + deletedItems_Hst.SelectedItem.ToString() + "\"项目", DateTime.Now.ToString());      //记录日志
                        deletedItems_Hst.Items.Remove(deletedItems_Hst.SelectedItems[0]);        //这里SelectedItems的索引恒为0，因为把0删除后，索引为1的会变为0                    
                        
                    }
                }
                else if (seletedModmS_Hst.Checked)      //单选生效
                {
                    InputLog_Hst(Log_Hst, "从回收中心删除\"" + deletedItems_Hst.SelectedItem.ToString() + "\"项目", DateTime.Now.ToString());      //记录日志
                    deletedItems_Hst.Items.Remove(deletedItems_Hst.SelectedItem);
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("你还没有选择要删除的项目！");
            }
        }

        private void Clear_Hst_Click(object sender, EventArgs e)        //对应清空按钮
        {
            InputLog_Hst(Log_Hst, "清空回收中心", DateTime.Now.ToString());      //记录日志
            deletedItems_Hst.Items.Clear();
        }

        private void backgroundColor_Hst_Click(object sender, EventArgs e)      //对应删除记录按钮
        {
            ColorDialog colorSelect_Hst = new ColorDialog();
            colorSelect_Hst.ShowDialog();
            Log_Hst.BackColor = colorSelect_Hst.Color;
        }

        private void fontChoose_Hst_Click(object sender, EventArgs e)       //对应记录字体按钮
        {
            FontDialog fontSelect_Hst = new FontDialog();
            fontSelect_Hst.ShowDialog();
            Log_Hst.Font = fontSelect_Hst.Font;
        }

        private void deleteLog_Hst_Click(object sender, EventArgs e)        //对应删除记录按钮
        {
            try
            {
                Log_Hst.SelectedItems[0].Remove();
            }
            catch 
            {
                MessageBox.Show("你还没有选择要删除的项目！");
            }
        }

        private void clearLog_Hst_Click(object sender, EventArgs e)      //对应清空记录按钮
        {
            Log_Hst.Items.Clear();
        }

        private void 重新加载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            City_Hst.Text = "";
            InfoOfCity_Hst.Items.Clear();
            deletedItems_Hst.Items.Clear();
            Log_Hst.Items.Clear();
            InputLog_Hst(Log_Hst, "重新启动应用程序", DateTime.Now.ToString());     //记录日志
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WinApp150604111\nVersion 3.4\nCopyright@2016 HST");
        }

        private void timer1_Hst_Tick(object sender, EventArgs e)    //用于更新状态栏的时间
        {
            TimeShow_Hst.Text = "当前时间：" + DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void statusStrip_Hst_MouseEnter(object sender, EventArgs e) //用于更新状态栏鼠标指示
        {
            MouseLocation_Hst.Text = "状态栏";
        }

        private void menuStrip_Hst_MouseEnter(object sender, EventArgs e)
        {
            MouseLocation_Hst.Text = "菜单栏";
        }

        private void toolStrip_Hst_MouseEnter(object sender, EventArgs e)
        {
            MouseLocation_Hst.Text = "工具栏";
        }

        private void FrmIntegrated_Hst_MouseEnter(object sender, EventArgs e)
        {
            MouseLocation_Hst.Text = "Windows 应用程序";
        }

        private void pictureBox_Hst_Click(object sender, EventArgs e)
        {
            pictureBox_Hst.Hide();
        }

        private void LogSave_Hst_Click(object sender, EventArgs e)       //对应保存记录按钮
        {
            if (!File.Exists("log.txt"))
            {
                File.Create("log.txt");
            }
            using (StreamWriter SW_Hst = new StreamWriter("log.txt"))
            {               
                for (int i_Hst = 0; i_Hst < Log_Hst.Items.Count; i_Hst++)
                {
                    SW_Hst.WriteLine(Log_Hst.Items[i_Hst].SubItems[0].Text +" , "+ Log_Hst.Items[i_Hst].SubItems[1].Text);
                }
                SW_Hst.Close();
            }
           
        }

        private void LogReload_Hst_Click(object sender, EventArgs e)         //对应加载记录按钮
        {
            using (StreamReader SR_Hst = new StreamReader("log.txt"))
            {
                string temp_Hst;
                while (!SR_Hst.EndOfStream)
                {
                    temp_Hst = SR_Hst.ReadLine();
                    string[] temp2_Hst = temp_Hst.Split(',');
                    InputLog_Hst(Log_Hst, temp2_Hst[0], temp2_Hst[1]);
                }
                SR_Hst.Close();
            }
        }

        private void LogOpen_Hst_Click(object sender, EventArgs e)       //对应打开记录按钮
        {
            try
            {
                System.Diagnostics.Process.Start("log.txt");
            }
            catch { }

        }


    }
}
