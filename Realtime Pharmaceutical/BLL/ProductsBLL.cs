using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime_Pharmaceutical.BLL
{
    class ProductsBLL
    {
        public int ProdcutID { get; set; }
        public string ProductName { get; set; }
        public int Unit { get; set; }
        public double Taxing { get; set; }
        public string BatchNumber { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public DateTime ImportedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int ManufacturedID { get; set; }
        public string Comment { get; set; }
    }
}
