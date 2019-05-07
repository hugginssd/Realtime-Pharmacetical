using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime_Pharmaceutical.BLL
{
    class OrderDetailsBLL
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime PayDate { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string PaymentMode { get; set; }
        public double AmountPaid { get; set; }
        public double Discount { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
    }
}
