using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class equipment
    {
        public int EquipmentID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double CostPerDay { get; set; }
        public bool Status { get; set; }
    }
}
