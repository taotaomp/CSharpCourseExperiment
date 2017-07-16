using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp150604111
{
    //继承实现计算圆和长方形的面积和周长
    #region 基类
    class PShape_Hst
    {
        double p_width_Hst;
        public double P_width_Hst
        {
            get { return p_width_Hst; }
            set { p_width_Hst = value; }
        }

        double p_length_Hst;
        public double P_length_Hst
        {
            get { return p_length_Hst; }
            set { p_length_Hst = value; }
        }

        double p_r_Hst;
        public double P_r_Hst
        {
            get { return p_r_Hst; }
            set { p_r_Hst = value; }
        } 
    }
    #endregion
    #region 派生的长方形类
    class Rectangle : PShape_Hst
    {
        public void setRectangleValue()
        {
            while(true)
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
                    { P_length_Hst = double.Parse(temp1_Hst); }

                    Console.WriteLine("请输入长方形的宽：");
                    /*对宽的输入进行判断*/
                    String temp2_Hst = Console.ReadLine();
                    double temp2_1_Hst; int temp2_2_Hst;
                    if (!(double.TryParse(temp2_Hst, out temp2_1_Hst) || int.TryParse(temp2_Hst, out temp2_2_Hst))) throw new ArgumentOutOfRangeException();
                    else
                    { P_width_Hst = double.Parse(temp2_Hst); }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("输入错误，请输入数字\n\t\t确定");
                    Console.ReadLine();
                    Console.Clear();
                }

                break;
            }
        }
        public void P_showResult_Hst()     //展示运算结果
        {
            Console.WriteLine();
            Console.WriteLine("长方形形面积为" + P_calculateRectangleAcreage_Hst());
            Console.WriteLine("长方形形周长为" + P_calculateRectangleCircumference_Hst());
        }
        public double P_calculateRectangleCircumference_Hst()  //计算长方形周长
        {
            double circumference_Hst;       //定义临时变量储存计算结果
            circumference_Hst = (P_length_Hst + P_width_Hst) * 2;
            return circumference_Hst;
        } 
        public double P_calculateRectangleAcreage_Hst()  //计算长方形面积
        {
            double acreage_Hst;     //定义临时变量储存计算结果
            acreage_Hst = P_length_Hst * P_width_Hst;
            return acreage_Hst;
        }
        
    }
    #endregion
    #region 派生的圆形类
    class Circular : PShape_Hst
    {
        public void setCircularValue()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("请输入圆的半径：(输入s跳过)");
                    /*对半径的输入进行判断*/
                    String temp_Hst = Console.ReadLine();
                    if (temp_Hst == "s" || temp_Hst == "S") break;
                    double temp_1_Hst; int temp_2_Hst;
                    if (!(double.TryParse(temp_Hst, out temp_1_Hst) || int.TryParse(temp_Hst, out temp_2_Hst))) throw new ArgumentOutOfRangeException();
                    else
                    { P_r_Hst = double.Parse(temp_Hst); }

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
        public double P_calculateCircularCircumference_Hst()  //计算圆周长
        {
            double circumference_Hst;       //定义临时变量储存计算结果
            circumference_Hst = 2 * Math.PI * P_r_Hst;
            return circumference_Hst;
        }
        public double P_calculateCircularAcreage_Hst()  //计算圆面积
        {
            double acreage_Hst;     //定义临时变量储存计算结果
            acreage_Hst = Math.PI * P_r_Hst * P_r_Hst;
            return acreage_Hst;
        }
        public void P_showResult_Hst()     //展示运算结果
        {
            Console.WriteLine();
            Console.WriteLine("圆形面积为" + P_calculateCircularAcreage_Hst());
            Console.WriteLine("圆形周长为" + P_calculateCircularCircumference_Hst());
        }
    }
    #endregion
}
