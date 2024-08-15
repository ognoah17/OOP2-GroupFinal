using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class RentalItem
    {
        public int RentalItemID { get; set; }
        public int RentalID { get; set; }
        public int EquipmentID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public double CostOfRental { get; set; }
    }
}
