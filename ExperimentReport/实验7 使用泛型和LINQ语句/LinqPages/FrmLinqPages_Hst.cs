using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinqPages
{
    public partial class FrmLinqPages_Hst : Form
    {
        public FrmLinqPages_Hst()
        {
            InitializeComponent();
        }

        LinqClassDataContext linqDataContext_Hst = new LinqClassDataContext();
        int pageSize_Hst = 7;           //设置每页显示7条记录
        int page = 0;                   //当前页

        private void FrmLinqPages_Hst_Load(object sender, EventArgs e)
        {
            page = 0;                   //设置当前页
            bindGrid_Hst();             //调用绑定DataGridView控件方法
        }

        private void PageUp_Hst_Click(object sender, EventArgs e)
        {
            page = page - 1;            //设置当前页数为当前页数减一
            bindGrid_Hst();             //调用绑定DataGridView控件方法
        }

        private void PageDown_Hst_Click(object sender, EventArgs e)
        {
            page = page + 1;            //设置当前页数为当前页数加一
            bindGrid_Hst();              //调用绑定DataGridView控件方法
        }


        protected void bindGrid_Hst()       //绑定DataGridView控件方法
        {
            int pageIndex_Hst = Convert.ToInt32(page);      //获取当前页

            var result_Hst = (from info in linqDataContext_Hst.tb_stock //使用LINQ查询，并对查询的数据进行分页
                          select new
                          {
                              商品编号 = info.tradecode,
                              商品全称 = info.fullname,
                              商品型号 = info.type,
                              商品规格 = info.standard,
                              单位 = info.unit,
                              产地 = info.produce,
                              库存数量 = info.qty,
                              进货时的最后一次进价 = info.price,
                              加权平均价 = info.averageprice
                          }).Skip(pageSize_Hst * pageIndex_Hst).Take(pageSize_Hst);

            dgvInfo.DataSource = result_Hst;//设置DataGridView控件的数据源
            PageUp_Hst.Enabled=PageDown_Hst.Enabled = true; 
            if (page == 0)
            {
                PageUp_Hst.Enabled = false;
            }
            if (page == getCount() - 1)
            {
                PageDown_Hst.Enabled = false;
            }
        }


        protected int getCount()
        {
            int sum_Hst = linqDataContext_Hst.tb_stock.Count();//设置总数据行数
            int s1 = sum_Hst / pageSize_Hst;//获取可以分的页面

            int s2 = sum_Hst % pageSize_Hst > 0 ? 1 : 0;        //当总行数对页数求余后是否大于0，如果大于获取1否则获取0
            int count_Hst = s1 + s2;//计算出总页数
            return count_Hst;
        }
    }
}
