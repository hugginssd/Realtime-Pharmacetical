﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtime_Pharmaceutical.DAL
{
    class Functions
    {
        Connection _con = new Connection();
        public int _nextId(string table)
        {
            SqlDataAdapter da = null;
            DataTable dt = null;
            SqlConnection con = new SqlConnection(_con.connection);
            int MAX_ID = 0;
            string sql = "SELECT MAX(ID) + 1 FROM " + table;
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {

                con.Open();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MAX_ID = Convert.ToInt32(dt.Rows[0][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Function Error");
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

            return MAX_ID;
        }

        //Revenue sales-volume variance
        
        //Sales price variance

    }
}
