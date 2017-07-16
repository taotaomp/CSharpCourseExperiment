using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp150604111
{
    class Program
    {
        #region 实验一菜单
        static void Menu_Hst()          //控制台菜单
        {
            while (true)
            {
                Console.WriteLine("\t\t************************\n");
                Console.WriteLine("\t\t1.九九乘法表\n");
                Console.WriteLine("\t\t2.输入年份输出生肖\n");
                Console.WriteLine("\t\t3.客车售票系统\n");
                Console.WriteLine("\t\t4.字符串加密\n");
                Console.WriteLine("\t\t0.返回上一级\n");
                Console.WriteLine("\t\t************************");
                Console.WriteLine("\t\t请选择功能：");
                try                 //检测选择功能时的输入异常
                {
                    string temp = Console.ReadLine();      //临时记录输入的内容
                    int select_Hst;     //记录选择的功能
                    if (!int.TryParse(temp, out select_Hst)) throw new ArrayTypeMismatchException();
                    if (select_Hst < 0 || select_Hst > 4) throw new IndexOutOfRangeException();
                    switch (select_Hst)
                    {
                        case 1:
                            Console.Clear();
                            MultiplicationTable_Hst();      //九九乘法表
                            break;
                        case 2:
                            Console.Clear();
                            ShengXiao_Hst();        //生肖查询
                            break;
                        case 3:
                            Console.Clear();
                            Ticket_Hst();       //购票系统
                            break;
                        case 4:
                            Console.Clear();
                            SrtEncrypt_Hst();       //密码加密
                            break;
                        case 0:
                            {
                                Console.Clear();
                                Menu_Hst_total();   //回掉总菜单
                            }
                            break;
                    }
                }
                catch (ArrayTypeMismatchException)
                {
                    Console.WriteLine("请输入正确的格式");
                    Console.ReadLine();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("请输入的数字超出范围，请输入0~4之间的数字");
                }
                finally
                {
                    Console.Clear();
                }
            }
        }
        #endregion

        #region 实验二菜单
        static public void Menu_Hst_ForTestwo()
        {
            while (true)
            {
                Console.WriteLine("\t\t************************\n");
                Console.WriteLine("\t\t1.计算长方形和圆的面积与周长\n");
                Console.WriteLine("\t\t2.用继承的方式实现计算长方形和圆的面积与周长\n");
                Console.WriteLine("\t\t3.成绩类\n");
                Console.WriteLine("\t\t0.返回上一级\n");
                Console.WriteLine("\t\t************************");
                Console.WriteLine("\t\t请选择功能：");

                try
                {
                    string temp = Console.ReadLine();      //临时记录输入的内容
                    int select_Hst;     //记录选择的功能
                    if (!int.TryParse(temp, out select_Hst)) throw new ArrayTypeMismatchException();
                    if (select_Hst < 0 || select_Hst > 3) throw new IndexOutOfRangeException();
                    switch (select_Hst)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Shape_Hst s_Hst = new Shape_Hst();
                                s_Hst.setValue_Hst();
                                s_Hst.showResult_Hst();
                                Console.ReadLine();
                            }
                            break;
                        case 2:
                            {
                                Console.Clear();
                                Rectangle r_Hst = new Rectangle();
                                Circular c_Hst = new Circular();
                                r_Hst.setRectangleValue();
                                c_Hst.setCircularValue();
                                r_Hst.P_showResult_Hst();
                                c_Hst.P_showResult_Hst();
                                Console.ReadLine();
                            }
                            break;
                        case 3:
                            {
                                Console.Clear();
                                Operator_Hst o_Hst = new Operator_Hst();
                                o_Hst.MenuForScore_Hst();
                                Console.ReadLine();
                            }
                            break;
                        case 0:
                            {
                                Console.Clear();
                                return;
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
                }
                finally
                {
                    Console.Clear();
                }
            }
        }
        #endregion

        #region 实验总菜单
        static public void Menu_Hst_total()
        {
            Console.Title = "程序清单";
            Console.ForegroundColor = ConsoleColor.DarkRed; //改字体颜色
            Console.BackgroundColor = ConsoleColor.Gray;    //改背景颜色
            while (true)
            {
                Console.WriteLine("\t\t************************\n");
                Console.WriteLine("\t\t1.实验一\n");
                Console.WriteLine("\t\t2.实验二\n");
                Console.WriteLine("\t\t0.退出\n");
                Console.WriteLine("\t\t************************");
                Console.WriteLine("\t\t请选择功能：");
                try
                {
                    string temp = Console.ReadLine();      //临时记录输入的内容
                    int select_Hst;     //记录选择的功能
                    if (!int.TryParse(temp, out select_Hst)) throw new ArrayTypeMismatchException();
                    if (select_Hst < 0 || select_Hst > 2) throw new IndexOutOfRangeException();
                    switch (select_Hst)
                    {
                        case 1:
                            Console.Clear();
                            Menu_Hst();
                            break;
                        case 2:
                            Console.Clear();
                            Menu_Hst_ForTestwo();
                            break;
                        case 0:
                            return;
                    }
                }
                catch (ArrayTypeMismatchException)
                {
                    Console.WriteLine("请输入正确的格式");
                    Console.ReadLine();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("请输入的数字超出范围，请输入0~2之间的数字");
                    Console.ReadLine();
                }
                finally
                {
                    Console.Clear();
                }
            }
        }
        #endregion

        #region 九九乘法表
        static void MultiplicationTable_Hst()       //九九乘法表
        {
            int[][] elements_Hst = new int[9][];        //建立不规则数组来用于遍历
            Console.WriteLine("\t\t\t九九乘法表");
            for (int i_Hst = 0; i_Hst < elements_Hst.Length; i_Hst++)
            {
                elements_Hst[i_Hst] = new int[i_Hst + 1];       //对不规则数组进行实例化
                for (int j_Hst = 0; j_Hst < elements_Hst.Length; j_Hst++)
                {
                    if (i_Hst >= j_Hst)         //判断输出条件，使乘法表能够以阶梯形输出
                    {
                        Console.Write((j_Hst + 1) + "x" + (i_Hst + 1) + "=" + ((i_Hst + 1) * (j_Hst + 1)) + "\t");
                    }
                }
                Console.WriteLine();        //用于输出换行
            }
            Console.ReadLine();
        }
        #endregion

        #region 输入年份输出生肖
        static void ShengXiao_Hst()
        {
            char[] ShengXiao_Hst = { '鼠', '牛', '虎', '兔', '龙', '蛇', '马', '羊', '猴', '鸡', '狗', '猪' };      //定义字符型数组存放生肖
            int year_Hst, Index_Hst;     //声明年份储存和生肖数组索引
            while (true)
            {
                Console.WriteLine("\t\t1900年-2100年生肖查询");
                Console.Write("\t请输入年份（输入-1返回上一级菜单）：");
                try
                {
                    string temp = Console.ReadLine();
                    if (!int.TryParse(temp, out year_Hst)) throw new ArrayTypeMismatchException();      //判断输入的年份是否格式正确
                    if ((year_Hst > 2100 || year_Hst < 1900) && year_Hst != -1) throw new IndexOutOfRangeException();     //判断输入的年份是否在规定范围内
                    
                    if (year_Hst == -1)
                    {
                        break;
                    }
                    Index_Hst = (year_Hst - 1900) % 12;     //判断生肖，确定索引
                    Console.WriteLine("\t" + year_Hst + "年的生肖为：" + ShengXiao_Hst[Index_Hst]);
                    Console.Write("\t确定");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("年份超出范围");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (ArrayTypeMismatchException)
                {
                    Console.WriteLine("请输入正确的年份");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        #endregion

        #region 客车售票系统
        static void Ticket_Hst()        //客车售票系统
        {
            String[,] seat_Hst = new String[9, 4];
            for (int i_Hst = 0; i_Hst < seat_Hst.GetLength(0); i_Hst++)     //初始化所有数组元素为“有票”
                for (int j_Hst = 0; j_Hst < seat_Hst.GetLength(1); j_Hst++)
                {
                    seat_Hst[i_Hst, j_Hst] = "【有票】";
                }
            while (true)
            {
                Console.WriteLine("    1         2         3         4");
                for (int i_Hst = 0; i_Hst < seat_Hst.GetLength(0); i_Hst++)
                {
                    for (int j_Hst = 0; j_Hst < seat_Hst.GetLength(1); j_Hst++)
                    {
                        if (seat_Hst[i_Hst, j_Hst] == "【已售】")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;      //改变字体颜色以突出此座位已被预订
                        }
                        Console.Write(seat_Hst[i_Hst, j_Hst] + "  ");     //输出数组元素内的文本内容
                        Console.ForegroundColor = ConsoleColor.DarkRed;     //恢复字体颜色
                    }
                    Console.WriteLine(i_Hst + 1);
                }
                try
                {
                    Console.WriteLine("请输入您要购买的座位（如：(2,3)）（输入q退出）");
                    String location_Hst = Console.ReadLine();
                    if (location_Hst == "q")
                    { break; }
                    String[] temp = location_Hst.Split(',');        //建立临时数组存放分割的字符
                    int row_Hst;   //行定位
                    int line_Hst;  //列定位
                    if (!int.TryParse(temp[0], out row_Hst)) throw new ArrayTypeMismatchException();
                    if (!int.TryParse(temp[1], out line_Hst)) throw new ArrayTypeMismatchException();
                    if (row_Hst < 1 || row_Hst > 9 || line_Hst < 1 || line_Hst > 4) throw new IndexOutOfRangeException();       //判断是否越界
                    if (seat_Hst[row_Hst - 1, line_Hst - 1] == "【已售】")      //判断座位是否已经被卖出
                    {
                        Console.WriteLine("此座位已被预定，请选择其他座位");
                        Console.ReadLine();
                        Console.Clear();
                        continue;

                    }
                    else
                    {
                        seat_Hst[row_Hst - 1, line_Hst - 1] = "【已售】";
                    }
                    Console.WriteLine("确认");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("您选择的座位超出范围，请重新输入");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (ArrayTypeMismatchException)
                {
                    Console.WriteLine("您输入的座位系统无法识别，请检查格式是否正确");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }
        #endregion

        #region 字符串加密
        static void SrtEncrypt_Hst()
        {
            while (true)
            {
                try
                {
                    int code_Hst = 0;
                    Console.WriteLine("请输入您要加密的内容（输入-1退出）");
                    String sentence_Hst;
                    sentence_Hst = Console.ReadLine();
                    if (sentence_Hst == "-1")
                    { break; }
                    for (int i_Hst = 0; i_Hst < sentence_Hst.Length; i_Hst++)   //检查输入的内容是否合法
                    {
                        if (!((sentence_Hst[i_Hst] >= '0' && sentence_Hst[i_Hst] <= '9') || (sentence_Hst[i_Hst] <= 'z' && sentence_Hst[i_Hst] >= 'a') || (sentence_Hst[i_Hst] <= 'Z' && sentence_Hst[i_Hst] >= 'A'))) throw new IndexOutOfRangeException();
                    }
                    Console.WriteLine("请输入加密密钥（大于零的整数）");
                    code_Hst = int.Parse(Console.ReadLine());

                    if (code_Hst < 0) throw new IndexOutOfRangeException();     //检查输入的密钥是否大于零
                    int[] temp = new int[sentence_Hst.Length];      //建立临时数组以储存改变后的已加密字符串
                    for (int i_Hst = 0; i_Hst < sentence_Hst.Length; i_Hst++)
                    {
                        if (sentence_Hst[i_Hst] >= '0' && sentence_Hst[i_Hst] <= '9')   //判断单个字符元素是数字还是字母
                        {
                            int key;
                            key = (code_Hst) % 10;                                  //详细加密算法
                            temp[i_Hst] = sentence_Hst[i_Hst] + key;
                            if (temp[i_Hst] > '9')
                            {
                                temp[i_Hst] = '0' + (key - ('9' - sentence_Hst[i_Hst])) - 1;
                            }
                        }
                        if (sentence_Hst[i_Hst] >= 'a' && sentence_Hst[i_Hst] <= 'z')       //判断单个字符元素是数字还是大小写字母
                        {
                            int key;
                            key = (code_Hst) % 26;                                  //详细加密算法
                            temp[i_Hst] = sentence_Hst[i_Hst] + key;
                            if (temp[i_Hst] > 'z')
                            {
                                temp[i_Hst] = 'a' + (key - ('z' - sentence_Hst[i_Hst])) - 1;
                            }
                        }
                        if (sentence_Hst[i_Hst] >= 'A' && sentence_Hst[i_Hst] <= 'Z')       //判断单个字符元素是数字还是大小写字母
                        {
                            int key;
                            key = (code_Hst) % 26;                                  //详细加密算法
                            temp[i_Hst] = sentence_Hst[i_Hst] + key;
                            if (temp[i_Hst] > 'Z')
                            {
                                temp[i_Hst] = 'A' + (key - ('Z' - sentence_Hst[i_Hst])) - 1;
                            }
                        }
                    }
                    Console.WriteLine("加密后的字符串为");
                    for (int i_Hst = 0; i_Hst < sentence_Hst.Length; i_Hst++)       //输出加密后的字符串
                    {
                        Console.Write((char)temp[i_Hst]);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("您输入的字符串格式错误，请重新输入");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }
        #endregion

        #region 主方法
        static void Main(string[] args)     //主方法接口
        {
            Menu_Hst_total();       //调用总菜单
            Console.WriteLine("bye~bye~");
            Console.ReadLine();
        }
        #endregion
    }
}