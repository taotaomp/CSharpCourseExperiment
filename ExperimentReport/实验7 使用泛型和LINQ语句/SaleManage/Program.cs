using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemSaled_HstManage
{
 
    public class ItemSaled_Hst 
    {
        string code_Hst;
        public string Code_Hst//实现编号属性
        {
            get
            {
                return code_Hst;
            }
            set
            {
                code_Hst = value;
            }
        }

        string name_Hst;
        public string Name_Hst//实现名称属性
        {
            get
            {
                return name_Hst;
            }
            set
            {
                name_Hst = value;
            }
        }
        public ItemSaled_Hst(string code_Hst, string name_Hst)//构造函数，为属性赋初始值
        {
            Code_Hst = code_Hst;
            Name_Hst = name_Hst;
        }
        public void ShowInfo_Hst()//ShowInfo重载方法，输出销售的商品信息
        {
            Console.WriteLine("商品编号：" + Code_Hst + "  商品名称：  " + Name_Hst);
        }
    }

    class Program
    {
        static double totalMoney_Hst(double[] data_Hst)
        {
            double sum_Hst = 0;
            foreach (double item_Hst in data_Hst)
            {
                sum_Hst += item_Hst;
            }
            return sum_Hst;
        }

        static void Main(string[] args)
        {
            //创建对象数组，存储1——3月份的每月的销售商品
            ItemSaled_Hst[] ItemSaleinJan = { new ItemSaled_Hst("T0001", "笔记本电脑"), new ItemSaled_Hst("T0002", "华为荣耀4X"), new ItemSaled_Hst("T0003", "iPad"),
                new ItemSaled_Hst("T0004", "华为荣耀6Plus"), new ItemSaled_Hst("T0005", "MacBook") };
            ItemSaled_Hst[] ItemSaleinFeb = { new ItemSaled_Hst("T0006", "华为荣耀6标配版"), new ItemSaled_Hst("T0007", "华为荣耀6高配版") };
            ItemSaled_Hst[] ItemSaleinMar = { new ItemSaled_Hst("T0003", "iPad"), new ItemSaled_Hst("T0004", "华为荣耀6Plus"), new ItemSaled_Hst("T0008", "一加手机"), new ItemSaled_Hst("T0009", "充电宝") };
            //创建对象数组，存储1——3月份的每月的销售金额
            double[] MoneyJan_Hst = { 4600, 1200, 4322, 1500, 13699 };
            double[] MoneyFeb_Hst = { 1200, 1900 };
            double[] MoneyMar_Hst = { 4236, 2000, 1299, 60 };
            while (true)
            {
                Console.Write("\n请输出要查询的月份（比如1、2、3等）：");
                try
                {
                    int month_Hst = int.Parse(Console.ReadLine());
                    switch (month_Hst)
                    {
                        case 1:
                            Console.WriteLine("1月份的商品销售明细如下：");
                            foreach (var item in ItemSaleinJan)
                            {
                                item.ShowInfo_Hst();//调用方法输出销售的商品信息
                            }
                            //调用泛型方法计算每月的总销售额,并输出
                            Console.WriteLine("\n1月商品总销售额：" + totalMoney_Hst(MoneyJan_Hst));
                            break;
                        case 2:
                            Console.WriteLine("2月份的商品销售明细如下：");
                            foreach (var item in ItemSaleinFeb)
                            {
                                item.ShowInfo_Hst();//调用方法输出销售的商品信息
                            }
                            Console.WriteLine("\n2月商品总销售额：" + totalMoney_Hst(MoneyFeb_Hst));
                            break;
                        case 3:
                            Console.WriteLine("3月份的商品销售明细如下：");
                            foreach (var item in ItemSaleinMar)
                            {
                                item.ShowInfo_Hst();//调用方法输出销售的商品信息
                            }
                            Console.WriteLine("\n3月商品总销售额：" + totalMoney_Hst(MoneyMar_Hst));
                            break;
                        default:
                            Console.WriteLine("该月没有销售数据或者输入的月份有误！");
                            break;
                    }
                }
                catch (Exception ex)//捕获可能出现的异常信息
                {
                    Console.WriteLine(ex.Message);//输出异常信息
                }
            }
        }
    }
}
