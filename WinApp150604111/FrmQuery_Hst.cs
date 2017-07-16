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
    public partial class FrmQuery_Hst : Form
    {
        public FrmQuery_Hst()
        {
            InitializeComponent();
        }

        DataBase_Hst DB_Hst = new DataBase_Hst();

        private void FrmQuery_Hst_Load(object sender, EventArgs e)
        {
            DB_Hst.SqlCon_Hst();        //连接数据库
            DB_Hst.SqlDataSet_Hst();        //调用函数将数据库中数据填充进入DataSet类对象中
            dataGridView_Hst.DataSource = DB_Hst.SqlDS_Hst.Tables[0];
            for (int i_Hst = 0; i_Hst < DB_Hst.SqlDS_Hst.Tables[0].Columns.Count; i_Hst++)
            {
                comboBox_Hst.Items.Add(DB_Hst.SqlDS_Hst.Tables[0].Columns[i_Hst].ToString());
            }
            comboBox_Hst.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        string tempStyle_Hst;

        private void comboBox_Hst_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempStyle_Hst = comboBox_Hst.Text;
        }

        private void Inquire_Hst_Click(object sender, EventArgs e)
        {
            if (txtKey_Hst.Text != string.Empty)
            {
                foreach (DataColumn item in DB_Hst.SqlDS_Hst.Tables[0].Columns)
                {
                    if (item.ColumnName == tempStyle_Hst)
                    {
                        for (int i_Hst = 0; i_Hst < DB_Hst.SqlDS_Hst.Tables[0].Rows.Count; i_Hst++)
                        {
                            if (DB_Hst.SqlDS_Hst.Tables[0].Rows[i_Hst][item.ToString()]== txtKey_Hst)
                            {
                                dataGridView_Hst.Rows[i_Hst].Selected = true;
                            }
                        }
                    }
                }
            }
        }



    }
}
