using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinApp150604111
{
    public partial class FrmLinqPages_Hst : Form
    {
        public FrmLinqPages_Hst()
        {
            InitializeComponent();
        }

        private void FrmLinqPages_Hst_Load(object sender, EventArgs e)
        {
            string sqlconstr = "Data Source=依;Initial Catalog=LINQ_to_SQL;Integrated Security=True";
            SqlConnection sqlCon_Hst = new SqlConnection(sqlconstr);
            SqlDataAdapter sda_Hst = new SqlDataAdapter("SELECT *from LinqClass", sqlCon_Hst);
            DataSet ds_Hst = new DataSet();
            sda_Hst.Fill(ds_Hst);
            dataGridView1.DataSource = ds_Hst.Tables[0];
        }
        
    }
}
