using Realtime_Pharmaceutical.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime_Pharmaceutical.DAL
{
    class ProductsDAL
    {
        Connection _con = new Connection();
        public bool Insert(ProductsBLL pbll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(_con.connection);
            string sql = "INSERT INTO [dbo].[Products]"+
                                               "([PRODUCTNAME]"+
                                               ",[UNIT]"+
                                               ",[TAXING]"+
                                               ",[BATCHNUM]"+
                                               ",[MANDATE]"+
                                               ",[IMPORTDATE]"+
                                               ",[EXPIREDATE]"+
                                               ",[MANUFACTURERID]"+
                                               ",[COMMENT])"+
                                         "VALUES"+
                                               "(@PRODUCTNAME"+
                                               ",@UNIT"+
                                               ",@TAXING"+
                                               ",@BATCHNUM"+
                                               ",@MANDATE"+
                                               ",@IMPORTDATE"+
                                               ",@EXPIREDATE"+
                                               ",@MANUFACTURERID"+
                                               ",@COMMENT)";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Parameters.AddWithValue("@PRODUCTNAME", pbll.ProductName);
            cmd.Parameters.AddWithValue("@UNIT", pbll.Unit);
            cmd.Parameters.AddWithValue("@TAXING", pbll.Taxing);
            cmd.Parameters.AddWithValue("@BATCHNUM", pbll.BatchNumber);
            cmd.Parameters.AddWithValue("@MANDATE", pbll.ManufacturedDate);
            cmd.Parameters.AddWithValue("@IMPORTDATE", pbll.ImportedDate);
            cmd.Parameters.AddWithValue("@EXPIREDATE", pbll.ExpiredDate);
            cmd.Parameters.AddWithValue("@MANUFACTURERID", pbll.ManufacturedID);
            cmd.Parameters.AddWithValue("@COMMENT", pbll.Comment);
            return IsSuccess;
        }
    }
}
