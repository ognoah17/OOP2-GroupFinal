using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Rental
    {
        public int RentalID { get; set; }
        public int CustomerID { get; set; }
        public DateTime Date { get; set; }
        public double TotalCost { get; set; }
    }
}
