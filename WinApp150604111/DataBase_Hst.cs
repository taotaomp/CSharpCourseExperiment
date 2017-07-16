using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WinApp150604111
{
    class DataBase_Hst
    {
        private string SqlConStr = System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon_Hst"].ToString();       //定义数据库连接字符串

        SqlConnection conn_Hst = new SqlConnection();       //声明数据库连接对象
        SqlCommand SqlCom_Hst ;       //声明数据库操作对象
        SqlDataAdapter SqlDA_Hst;
        
        DataSet sqlDS_Hst;
        public DataSet SqlDS_Hst
        {
            get { return sqlDS_Hst; }
            set { sqlDS_Hst = value; }
        }
        

        public void SqlDisCon_Hst()     //断开数据库连接方法
        {
            conn_Hst.Close();
        }

        public void SqlCon_Hst()    //数据库连接方法
        {
            try
            {
                conn_Hst.ConnectionString = SqlConStr;
                conn_Hst.Open();
            }
            catch (Exception ex_Hst)
            {
                MessageBox.Show(ex_Hst.ToString());
            }
        }

        public bool conCheck_Hst()      //数据库连接检查方法
        {
            try
            {
                if (conn_Hst.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex_Hst)
            {
                MessageBox.Show(ex_Hst.ToString());
                return false;
            }
        }

        public void SqlRea_Hst(string[] str_Hst)    //读取数据库信息的方法
        {
            SqlCom_Hst = new SqlCommand("select * from UserLogin order by ID", conn_Hst);       //实例化数据库操作对象
            if (!conCheck_Hst())    //检查数据库是否关闭
            {
                SqlCon_Hst();       //关闭则连接数据库
            }
            SqlDataReader SqlReader_Hst = SqlCom_Hst.ExecuteReader();
            try
            {
                if (SqlReader_Hst.HasRows)
                {
                    int i = 0;
                    while (SqlReader_Hst.Read())
                    {
                        str_Hst[i] = SqlReader_Hst["ID"] + "#" + SqlReader_Hst["Name"] + "#" + SqlReader_Hst["Age"] + "#" + SqlReader_Hst["Sex"] + "#" + SqlReader_Hst["Photo"];
                        i++;
                    }
                }
                SqlReader_Hst.Close();
            }
            catch (Exception ex_Hst)
            {
                MessageBox.Show(ex_Hst.ToString());
            }
        }

        public void SqlInsert_Hst(string str_Hst)
        {
            string[] temp_Hst = str_Hst.Split('#');
            SqlCom_Hst = new SqlCommand("INSERT INTO UserLogin (ID,Name,Age,Sex,Photo) " +
                "VALUES ('" + temp_Hst[0] + "','" + temp_Hst[1] + "','" + temp_Hst[2] + "','" +
                temp_Hst[3] + "','" + temp_Hst[4] + "')", conn_Hst);
            SqlCom_Hst.ExecuteNonQuery();
            
        }

        public void SqlUpdate_Hst(string str_Hst)
        {
            string[] temp_Hst = str_Hst.Split('#');
            SqlCom_Hst = new SqlCommand("UPDATE UserLogin set Name='" + temp_Hst[1] + "',Age='" + 
                temp_Hst[2] + "',Sex='" + temp_Hst[3] + "',Photo='" + temp_Hst[4] + "'where ID = '" 
                + temp_Hst[0] + "'", conn_Hst);
            SqlCom_Hst.ExecuteNonQuery();
        }

        public void SqlDelete_Hst(string str_Hst)
        {
            SqlCom_Hst = new SqlCommand("DELETE from UserLogin where ID='"+str_Hst+"'", conn_Hst);
            SqlCom_Hst.ExecuteNonQuery();
        }

        public void SqlDataSet_Hst()
        {
            SqlDA_Hst = new SqlDataAdapter("SELECT *from UserLogin", conn_Hst);
            SqlDS_Hst = new DataSet();
            SqlDA_Hst.Fill(SqlDS_Hst);
        }

    }
}
