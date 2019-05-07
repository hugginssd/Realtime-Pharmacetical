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
    class ManufacturersDAL
    {
        Connection _con = new Connection();
        public bool Insert(ManufacturersBLL mbll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(_con.connection);
            string sql = "INSERT INTO [dbo].[Manufacturers]"+
                                               "([MANNAME]"+
                                               ",[MANLICENSE]"+
                                               ",[ADDRESS])"+
                                         "VALUES"+
                                               "(@MANNAME"+
                                               ",@MANLICENSE"+
                                               ",@ADDRESS)";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MANNAME", mbll.ManufacturerName);
                cmd.Parameters.AddWithValue("@MANLICENSE", mbll.ManufacturerLicense);
                cmd.Parameters.AddWithValue("@ADDRESS", mbll.Address);
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
        public DataTable Select()
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection(_con.connection);
            string sql = "SELECT [MANUFACTURERID]"+
                                          ",[MANNAME]"+
                                          ",[MANLICENSE]"+
                                          ",[ADDRESS]"+
                                      "FROM[dbo].[Manufacturers]";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Data Access Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

    }
}
