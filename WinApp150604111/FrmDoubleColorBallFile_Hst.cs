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
    public partial class FrmDoubleColorBallFile_Hst : Form
    {
        public FrmDoubleColorBallFile_Hst()
        {
            InitializeComponent();
        }

        Random r_Hst = new Random();

        int[] rs_Hst = new int[6];      //用于比较摇出的数字是否重复
        int count_Hst = 0;      //记录当前已经摇出的号码的个数

        #region 数字滚动的控制      
        private void timer1_Hst_Tick(object sender, EventArgs e)
        {                      
            ball1_Hst.Text = r_Hst.Next(1, 34).ToString("00");      //以随机数更改标签的文本，且以标准的形式显示
        }
        private void timer2_Hst_Tick(object sender, EventArgs e)
        {
            ball2_Hst.Text = r_Hst.Next(1, 34).ToString("00"); 
        }

        private void timer3_Hst_Tick(object sender, EventArgs e)
        {
            ball3_Hst.Text = r_Hst.Next(1, 34).ToString("00"); 
        }

        private void timer4_Hst_Tick(object sender, EventArgs e)
        {
            ball4_Hst.Text = r_Hst.Next(1, 34).ToString("00"); 
        }

        private void timer5_Hst_Tick(object sender, EventArgs e)
        {
            ball5_Hst.Text = r_Hst.Next(1, 34).ToString("00"); 
        }

        private void timer6_Hst_Tick(object sender, EventArgs e)
        {
            ball6_Hst.Text = r_Hst.Next(1, 34).ToString("00"); 
        }

        private void timer7_Hst_Tick(object sender, EventArgs e)
        {
            ball7_Hst.Text = r_Hst.Next(1, 18).ToString("00");       
        }
        #endregion

        private void operation_Hst_Click(object sender, EventArgs e)      //按钮操控标签的号码摇动
        {
            if (operation_Hst.Text == "点击摇号")
            {
                operation_Hst.Text = "第一个号";
                timer1_Hst.Interval = 120;
                timer1_Hst.Enabled = true;
                timer2_Hst.Interval = 20;
                timer2_Hst.Enabled = true;
                timer3_Hst.Interval = 20;
                timer3_Hst.Enabled = true;
                timer4_Hst.Interval = 20;
                timer4_Hst.Enabled = true;
                timer5_Hst.Interval = 20;
                timer5_Hst.Enabled = true;
                timer6_Hst.Interval = 20;
                timer6_Hst.Enabled = true;
                timer7_Hst.Interval = 20;
                timer7_Hst.Enabled = true;
            }
            else if (operation_Hst.Text == "第一个号")
            {
                operation_Hst.Text = "第二个号";
                timer1_Hst.Stop();      //停止第一个时间组件
                timer2_Hst.Interval = 120;      //改变第二个时间组件的周期
                txtShowBall_Hst.Text = ball1_Hst.Text + " ";
                rs_Hst[0] = int.Parse(ball1_Hst.Text);      //将数字存入用于比对的数组中，以供后续比对
                count_Hst++;        //表示摇出的数字增加1
            }
            else if (operation_Hst.Text == "第二个号")
            {
                    operation_Hst.Text = "第三个号";
                    timer2_Hst.Stop();
                    timer3_Hst.Interval = 120;
                    int i_Hst;
                    for (i_Hst = 0; i_Hst < count_Hst;)
                    {
                        if (rs_Hst[i_Hst] == int.Parse(ball2_Hst.Text))             //检查是否出现重号
                        {
                            ball2_Hst.Text = r_Hst.Next(1, 33).ToString("00");  //若出现重号则再次生成数
                            i_Hst = 0;      //将i置零以重新检查
                        }
                        else                //将i++放在这里，是为了防止当当前摇到的数与第一个数重复时，                   
                        {                   //i置零后，i在后续仍被+1，而导致生成与第一个数相同的数的情况，下同
                            i_Hst++;
                        }
                    }
                    if (i_Hst == count_Hst)
                    {
                        txtShowBall_Hst.Text = txtShowBall_Hst.Text + ball2_Hst.Text + " ";
                        rs_Hst[1] = int.Parse(ball2_Hst.Text);      //将数字存入用于比对的数组中，以供后续比对
                        count_Hst++;        //表示摇出的数字增加1
                    }
            }
            else if (operation_Hst.Text == "第三个号")
            {
                    operation_Hst.Text = "第四个号";
                    timer3_Hst.Stop();
                    timer4_Hst.Interval = 120;
                    int i_Hst;
                    for (i_Hst = 0; i_Hst < count_Hst;)
                    {
                        if (rs_Hst[i_Hst] == int.Parse(ball3_Hst.Text))             //检查是否出现重号
                        {
                            ball3_Hst.Text = r_Hst.Next(1, 33).ToString("00");  //若出现重号则再次生成数
                            i_Hst = 0;      //将i置零以重新检查
                        }
                        else
                        {
                            i_Hst++;
                        }
                    }
                    if (i_Hst == count_Hst)
                    {
                        txtShowBall_Hst.Text = txtShowBall_Hst.Text + ball3_Hst.Text + " ";
                        rs_Hst[2] = int.Parse(ball3_Hst.Text);      //将数字存入用于比对的数组中，以供后续比对
                        count_Hst++;        //表示摇出的数字增加1
                    }                
            }
            else if (operation_Hst.Text == "第四个号")
            {
                    operation_Hst.Text = "第五个号";
                    timer4_Hst.Stop();
                    timer5_Hst.Interval = 120;
                    int i_Hst;
                    for (i_Hst = 0; i_Hst < count_Hst;)
                    {               
                        if (rs_Hst[i_Hst] == int.Parse(ball4_Hst.Text))             //检查是否出现重号
                        {
                            ball4_Hst.Text = r_Hst.Next(1, 33).ToString("00");  //若出现重号则再次生成数
                            i_Hst = 0;      //将i置零以重新检查
                        }
                        else
                        {
                            i_Hst++;
                        }
                    }
                    if (i_Hst == count_Hst)
                    {
                        txtShowBall_Hst.Text = txtShowBall_Hst.Text + ball4_Hst.Text + " ";
                        rs_Hst[3] = int.Parse(ball4_Hst.Text);      //将数字存入用于比对的数组中，以供后续比对
                        count_Hst++;        //表示摇出的数字增加1
                    }
            }
            else if (operation_Hst.Text == "第五个号")
            {
                    operation_Hst.Text = "第六个号";
                    timer5_Hst.Stop();
                    timer6_Hst.Interval = 120;
                    int i_Hst;
                    for (i_Hst = 0; i_Hst < count_Hst;)
                    {                        
                        if (rs_Hst[i_Hst] == int.Parse(ball5_Hst.Text))             //检查是否出现重号
                        {
                            ball5_Hst.Text = r_Hst.Next(1, 33).ToString("00");  //若出现重号则再次生成数
                            i_Hst = 0;      //将i置零以重新检查
                        }
                        else
                        {
                            i_Hst++;
                        }
                    }
                    if (i_Hst == count_Hst)
                    {
                        txtShowBall_Hst.Text = txtShowBall_Hst.Text + ball5_Hst.Text + " ";
                        rs_Hst[4] = int.Parse(ball5_Hst.Text);      //将数字存入用于比对的数组中，以供后续比对
                        count_Hst++;        //表示摇出的数字增加1
                    }
            }
            else if (operation_Hst.Text == "第六个号")
            {
                    operation_Hst.Text = "第七个号";
                    timer6_Hst.Stop();
                    timer7_Hst.Interval = 120;
                    int i_Hst;
                    for (i_Hst = 0; i_Hst < count_Hst;)
                    {
                        if (rs_Hst[i_Hst] == int.Parse(ball6_Hst.Text))             //检查是否出现重号
                        {
                            ball6_Hst.Text = r_Hst.Next(1, 33).ToString("00");  //若出现重号则再次生成数
                            i_Hst = 0;      //将i置零以重新检查
                        }
                        else
                        {
                            i_Hst++;
                        }
                    }
                    if (i_Hst == count_Hst)
                    {
                        txtShowBall_Hst.Text = txtShowBall_Hst.Text + ball6_Hst.Text + " ";
                        rs_Hst[5] = int.Parse(ball6_Hst.Text);      //将数字存入用于比对的数组中，以供后续比对
                        count_Hst++;        //表示摇出的数字增加1
                    }
            }
            else if (operation_Hst.Text == "第七个号")
            {
                operation_Hst.Text = "点击摇号";
                timer7_Hst.Stop();
                count_Hst = 0;      //将计数器重置为0，以供下次摇号记录
                txtShowBall_Hst.Text = txtShowBall_Hst.Text + ball7_Hst.Text + " ";
                //if (!File.Exists("DoubleColorBallNubmer.txt"))
                //{
                //    File.Create("DoubleColorBallNubmer.txt");                    
                //}
                using (StreamWriter SW_Hst = new StreamWriter("DoubleColorBallNubmer.txt",true ))
                {
                    SW_Hst.WriteLine(txtShowBall_Hst.Text);
                }
                MessageBox.Show("本次开奖开出的号数为：" + txtShowBall_Hst.Text+"您中奖了吗？");
            }


        }

        private void operation_Hst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FrmDoubleColorBallFile_Hst_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("DoubleColorBallNubmer.txt"))
                {
                    using (StreamReader SR_Hst = new StreamReader("DoubleColorBallNubmer.txt"))
                    {
                        while (!SR_Hst.EndOfStream)         //读取文本中的号码的信息
                        {
                            txtShowBall_Hst.Text = " ";
                            string[] balls_Hst = SR_Hst.ReadLine().Split(' ');
                            ball1_Hst.Text = balls_Hst[0];
                            ball2_Hst.Text = balls_Hst[1];
                            ball3_Hst.Text = balls_Hst[2];
                            ball4_Hst.Text = balls_Hst[3];
                            ball5_Hst.Text = balls_Hst[4];
                            ball6_Hst.Text = balls_Hst[5];
                            ball7_Hst.Text = balls_Hst[6];
                            for (int i_Hst = 0; i_Hst < balls_Hst.Length; i_Hst++)
                            {
                                txtShowBall_Hst.Text += balls_Hst[i_Hst] + " ";
                            }
                        }
                    }
                }
            }
            catch { }
        }



       
    }
}
