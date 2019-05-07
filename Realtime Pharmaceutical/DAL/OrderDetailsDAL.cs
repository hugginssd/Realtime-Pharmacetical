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
    class OrderDetailsDAL   
    {
        Connection _con = new Connection();

        public bool Insert(OrderDetailsBLL odbll)
        {
            bool IsSuccess = false;

            SqlConnection con = new SqlConnection(_con.connection);
            string sql = "INSERT INTO[dbo].[Orders]"+
                                                    "([ORDERDATE]"+
                                                      ",[PAYDATE]"+
                                                      ",[CUSTOMERID]"+
                                                      ",[USERID]"+
                                                      ",[PAYMENTMODE]"+
                                                      ",[AMOUNTPAID]"+
                                                      ",[DISCOUNT]"+
                                                      ",[STATUS]"+
                                                      ",[COMMENT])"+
                                                "VALUES"+
                                                       "(@ORDERDATE"+
                                                       ",@PAYDATE"+
                                                       ",@CUSTOMERID"+
                                                       ",@USERID"+
                                                       ",@PAYMENTMODE"+
                                                       ",@AMOUNTPAID"+
                                                       ",@DISCOUNT"+
                                                       ",@STATUS"+
                                                       ",@COMMENT)";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ORDERDATE", odbll.OrderDate);
                cmd.Parameters.AddWithValue("@PAYDATE", odbll.PayDate);
                cmd.Parameters.AddWithValue("@CUSTOMERID", odbll.CustomerID);
                cmd.Parameters.AddWithValue("@USERID", odbll.UserID);
                cmd.Parameters.AddWithValue("@PAYMENTMODE", odbll.PaymentMode);
                cmd.Parameters.AddWithValue("@AMOUNTPAID", odbll.AmountPaid);
                cmd.Parameters.AddWithValue("@DISCOUNT", odbll.OrderDate);
                cmd.Parameters.AddWithValue("@STATUS", odbll.Status);
                cmd.Parameters.AddWithValue("@COMMENT", odbll.Comment);
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
            string sql = "SELECT [ORDERID]"+
                                ",[ORDERDATE]"+
                                ",[PAYDATE]"+
                                ",[CUSTOMERID]"+
                                ",[USERID]"+
                                ",[PAYMENTMODE]"+
                                ",[AMOUNTPAID]"+
                                ",[DISCOUNT]"+
                                ",[STATUS]"+
                                ",[COMMENT]"+
                            "FROM[dbo].[Orders]";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Data Access Error", MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public void SelectCustomerIDAndUserID(ComboBox cmb, ComboBox cmb1)
        {
            SqlConnection con = new SqlConnection(_con.connection);
            try
            {
            Dictionary<int, String> SiteSource = new Dictionary<int,String>();
            SqlDataReader dr = null;
                string sql = "SELECT [CUSTOMERID]" +
                                ",[CUSTOMERNAME]" +
                                ",[ADDRESS]" +
                                ",[CONTACT]" +
                                ",[TYPE]" +
                            "FROM[dbo].[Customers]";
                SqlCommand cmd = new SqlCommand(sql, con);
                dr = cmd.ExecuteReader();
                while (dr.HasRows)
                {
                    SiteSource.Add(Convert.ToInt32(dr["CUSTOMERID"]), dr["CUSTOMERNAME"].ToString());
                }
                cmb.DataSource = new BindingSource(SiteSource, null);
                cmb.DisplayMember = "Value";
                cmb.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Data Access Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
            finally
            {
                con.Close();
            }
            //users
            try
            {
            Dictionary<int, String> SiteSource = new Dictionary<int, String>();
            SqlDataReader dr = null;
                string sql = "SELECT [USERID]"+
                                      ",[FIRSTNAME]"+
                                      ",[LASTNAME]"+
                                      ",[USERNAME]"+
                                      ",[PASSWORD]"+
                                  "FROM[dbo].[Users]";
                SqlCommand cmd = new SqlCommand(sql, con);
                dr = cmd.ExecuteReader();
                SiteSource.Clear();
                while (dr.HasRows)
                {
                    SiteSource.Add(Convert.ToInt32(dr["USERID"]), dr["USERNAME"].ToString());
                }
                cmb1.DataSource = new BindingSource(SiteSource, null);
                cmb1.DisplayMember = "Value";
                cmb1.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                con.Close();
            }
        }


    }
}
