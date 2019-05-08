using Realtime_Pharmaceutical.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtime_Pharmaceutical.DAL
{
    class CustomersDAL
    {
        Connection _con = new Connection();
        public bool Insert(CustomersBLL cbll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(_con.connection);
            string sql = "INSERT INTO [dbo].[Customers]" +
                                           "([CUSTOMERNAME]" +
                                           ",[ADDRESS]" +
                                           ",[CONTACT]" +
                                           ",[TYPE])" +
                                     "VALUES" +
                                           "(@CUSTOMERNAME" +
                                           ",@ADDRESS" +
                                           ",@CONTACT" +
                                           ",@TYPE)";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.Parameters.AddWithValue("@CUSTOMERNAME", cbll.CustomerName);
                cmd.Parameters.AddWithValue("@ADDRESS", cbll.Address);
                cmd.Parameters.AddWithValue("@CONTACT", cbll.Contact);
                cmd.Parameters.AddWithValue("@TYPE", cbll.Type);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Data Access Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }finally
            {
                con.Close();
            }
            return IsSuccess;
        }
        public DataTable Select()
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection(_con.connection);
            string sql = "SELECT[CUSTOMERID]"+
                                      ",[CUSTOMERNAME]"+
                                      ",[ADDRESS]"+
                                      ",[CONTACT]"+
                                      ",[TYPE]"+
                             "FROM[dbo].[Customers]";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Data Access Error", MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            }finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
