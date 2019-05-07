using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime_Pharmaceutical.BLL
{
    class OrdersBLL
    {
        public int OrdersDetailsID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int QuantityOrdered { get; set; }
        public double PriceEach { get; set; }   

    }
}
