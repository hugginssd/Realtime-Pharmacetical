using Realtime_Pharmaceutical.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime_Pharmaceutical.BLL
{
    class CustomersBLL
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
            
    }
}
