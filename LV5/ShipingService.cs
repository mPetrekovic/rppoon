using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv_4
{
    class ShipingService
    {
        private double pricePerMass;
        public ShipingService(double price)
            {
            this.pricePerMass = price;
            }
        public double shipingPrice(Box box)
        {
            return box.Weight * this.pricePerMass;
        }
    }
}
