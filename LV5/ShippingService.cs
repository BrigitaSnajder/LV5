using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class ShippingService
    {
        private double price;
        public ShippingService(double price)
        {
            this.price = price;
        }
        public double calculateDeliveryPrice(IShipable item)
        {
            return item.Weight* price;
        }
    }
}
