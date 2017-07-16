using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp150604111
{
    class Score_Hst:Student_Hst
    {
        public void dataSet_Hst()   //录入信息
        {
            Console.WriteLine("请输入姓名");
            Name_Hst = Console.ReadLine();
            Console.WriteLine("请输入班级");
            ClassName_Hst = Console.ReadLine();
            Console.WriteLine("请输入科目");
            Subject_Hst = Console.ReadLine();
            Console.WriteLine("请输入成绩");
            Temp_score_Hst = Console.ReadLine();
        }
        public void scoreDeal_Hst()     //处理成绩
        {
            int temp;                                   //若成绩是int型则将其改为double
            if (int.TryParse(Temp_score_Hst, out temp))
            {
                double.Parse(Temp_score_Hst);
            }
            double temp2;
            double.TryParse(Temp_score_Hst, out temp2);     //判断成绩是否为数字
            The_score_Hst = temp2;      //判断成功就把值赋给成绩
            if (The_score_Hst > 100 || The_score_Hst < 0)       //判断成绩是否在范围内
            {
                The_score_Hst = 0.0;
            }
        }
        public void dataShow_Hst()      //显示信息
        {
            Console.WriteLine("姓名：" + Name_Hst);
            Console.WriteLine("班级：" + ClassName_Hst);
            Console.WriteLine("科目：" + Subject_Hst);
            Console.WriteLine("成绩：" + The_score_Hst);
        }
        public void dataModify_Hst()        //成绩修改
        {
               do
               {
                   try
                   {
                       Console.WriteLine("请输入正确的成绩：");
                       string temp_Hst = Console.ReadLine();
                       double temp1_Hst;
                       int temp2_Hst;
                       if (!(double.TryParse(temp_Hst, out temp1_Hst) || int.TryParse(temp_Hst, out temp2_Hst))) throw new ArgumentOutOfRangeException();       //判断输入的成绩是否合法
                       if (double.Parse(temp_Hst) < 0 || double.Parse(temp_Hst) > 100) throw new IndexOutOfRangeException();
                       The_score_Hst = double.Parse(temp_Hst);
                       Console.WriteLine("修改成功！");
                       Console.ReadLine();
                       break;
                   }
                   catch (ArgumentOutOfRangeException)
                   {
                       Console.WriteLine("您输入的成绩格式不对，请输入数字\n确认");
                       Console.ReadLine();
                       Console.Clear();
                   }
                   catch (IndexOutOfRangeException)
                   {
                       Console.WriteLine("您输入的成绩超出范围，请输入0~100的成绩\n确认");
                       Console.ReadLine();
                       Console.Clear();
                   }
               } while (true);
       }
   }
    class Student_Hst
    {
        #region 各种字段及其属性访问器
        private string name_Hst;
        public string Name_Hst
        {
            get { return name_Hst; }
            set { name_Hst = value; }
        }

        private string className_Hst;
        public string ClassName_Hst
        {
            get { return className_Hst; }
            set { className_Hst = value; }
        }

        private double the_score_Hst;
        public double The_score_Hst
        {
            get { return the_score_Hst; }
            set { the_score_Hst = value; }
        }

        private string subject_Hst;
        public string Subject_Hst
        {
            get { return subject_Hst; }
            set { subject_Hst = value; }
        }

        private string temp_score_Hst;
        public string Temp_score_Hst       //用于处理未处理之前的成绩
        {
            get { return temp_score_Hst; }
            set { temp_score_Hst = value; }
        }
        #endregion
    }
    class Operator_Hst:Score_Hst
    {
        
        public void MenuForScore_Hst()
        {
            while (true)
            {
                Console.WriteLine("\t\t************************\n");
                Console.WriteLine("\t\t1.录入成绩\n");
                Console.WriteLine("\t\t2.查看成绩\n");
                Console.WriteLine("\t\t3.修改成绩\n");
                Console.WriteLine("\t\t0.返回上一级\n");
                Console.WriteLine("\t\t************************");
                Console.WriteLine("\t\t请选择功能：");
                try                 //检测选择功能时的输入异常
                {
                    string temp = Console.ReadLine();      //临时记录输入的内容
                    int select_Hst;     //记录选择的功能
                    if (!int.TryParse(temp, out select_Hst)) throw new ArrayTypeMismatchException();
                    if (select_Hst < 0 || select_Hst > 3) throw new IndexOutOfRangeException();
                    switch (select_Hst)
                    {
                        case 1:
                            Console.Clear();
                            dataSet_Hst();
                            scoreDeal_Hst();
                            break;
                        case 2:
                            Console.Clear();
                            dataShow_Hst();
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            dataModify_Hst();
                            break;
                        case 0:
                            {
                                Console.Clear();
                                return ;
                            }
                    }
                }
                catch (ArrayTypeMismatchException)
                {
                    Console.WriteLine("请输入正确的格式");
                    Console.ReadLine();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("请输入的数字超出范围，请输入0~3之间的数字");
                    Console.ReadLine();
                }
                finally
                {
                    Console.Clear();
                }
            }
        }
    }
}
