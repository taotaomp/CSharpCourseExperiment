using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp150604111
{
    #region 计算圆和长方形的面积和周长
    class Shape_Hst
    {
        
        #region 各种字段及其属性访问器
        private double length_Hst;      //长方形的长
        protected double Length_Hst     //该成员的属性访问器
        {
            get { return length_Hst; }
            set { length_Hst = value; }
        }

        private double width_Hst;       //长方形的宽
        protected double Width_Hst
        {
            get { return width_Hst; }
            set { width_Hst = value; }
        }

        private double r_Hst;       //圆的半径
        protected double R_Hst
        {
            get { return r_Hst; }
            set { r_Hst = value; }
        }
        #endregion
        public void setValue_Hst()      //调用此函数以让用户输入数据
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("请输入长方形的长：(输入s跳过)");
                    /*对长的输入进行判断*/
                    String temp1_Hst = Console.ReadLine();
                    if (temp1_Hst == "s" || temp1_Hst == "S") break;
                    double temp1_1_Hst; int temp1_2_Hst;
                    if (!(double.TryParse(temp1_Hst, out temp1_1_Hst) || int.TryParse(temp1_Hst, out temp1_2_Hst))) throw new ArgumentOutOfRangeException();
                    else
                    { Length_Hst = double.Parse(temp1_Hst); }

                    Console.WriteLine("请输入长方形的宽：");
                    /*对宽的输入进行判断*/
                    String temp2_Hst = Console.ReadLine();
                    double temp2_1_Hst; int temp2_2_Hst;
                    if (!(double.TryParse(temp2_Hst, out temp2_1_Hst) || int.TryParse(temp2_Hst, out temp2_2_Hst))) throw new ArgumentOutOfRangeException();
                    else
                    { Width_Hst = double.Parse(temp2_Hst); }

                    Console.WriteLine("请输入圆的半径：");
                    /*对半径的输入进行判断*/
                    String temp3_Hst = Console.ReadLine();
                    double temp3_1_Hst; int temp3_2_Hst;
                    if (!(double.TryParse(temp3_Hst, out temp3_1_Hst) || int.TryParse(temp3_Hst, out temp3_2_Hst))) throw new ArgumentOutOfRangeException();
                    else
                    { R_Hst = double.Parse(temp3_Hst); }

                    break;

                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("输入错误，请输入数字\n\t\t确定");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public void showResult_Hst()     //展示运算结果
        {
            Console.WriteLine();
            Console.WriteLine("长方形形面积为" + calculateRectangleAcreage_Hst());
            Console.WriteLine("长方形形周长为" + calculateRectangleCircumference_Hst());
            Console.WriteLine("圆形面积为" + calculateCircularAcreage_Hst());
            Console.WriteLine("圆形周长为" + calculateCircularCircumference_Hst());
        }

        public double calculateRectangleCircumference_Hst()  //计算长方形周长
        {
            double circumference_Hst;       //定义临时变量储存计算结果
            circumference_Hst = (length_Hst + width_Hst) * 2;
            return circumference_Hst;
        }
        public double calculateCircularCircumference_Hst()  //计算圆周长
        {
            double circumference_Hst;       //定义临时变量储存计算结果
            circumference_Hst = 2 * Math.PI * r_Hst;
            return circumference_Hst;
        }
        public double calculateRectangleAcreage_Hst()  //计算长方形面积
        {
            double acreage_Hst;     //定义临时变量储存计算结果
            acreage_Hst = length_Hst * width_Hst;
            return acreage_Hst;
        }
        public double calculateCircularAcreage_Hst()  //计算圆面积
        {
            double acreage_Hst;     //定义临时变量储存计算结果
            acreage_Hst = Math.PI * r_Hst * r_Hst;
            return acreage_Hst;
        }
    }
    #endregion
}
    