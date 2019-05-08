using Realtime_Pharmaceutical.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtime_Pharmaceutical.DAL
{
    class OrdersDAL
    {
        Connection _con = new Connection();
        public bool Insert(OrdersBLL obll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(_con.connection);
            string sql = "INSERT INTO [dbo].[OrderDetails]"+
                                               "([ORDERID]"+
                                               ",[PRODUCTID]"+
                                               ",[QUANTITY ORDERED]"+
                                               ",[PRICE EACH])"+
                                         "VALUES"+
                                               "(@ORDERID"+
                                               ",@PRODUCTID"+
                                               ",@QUANTITY"+
                                               ",@PRICEEACH)";
            SqlCommand cmd = new SqlCommand(sql,con);
            try
            {
                cmd.Parameters.AddWithValue("@ORDERID", obll.OrderID);
                cmd.Parameters.AddWithValue("@PRODUCTID", obll.ProductID);
                cmd.Parameters.AddWithValue("@QUANTITY", obll.QuantityOrdered);
                cmd.Parameters.AddWithValue("@PRICEEACH", obll.PriceEach);
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
            }
            finally
            {
                con.Close();
            }

            return IsSuccess;
        }

    }
}
