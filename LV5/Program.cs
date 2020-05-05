using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShipable> itemList = new List<IShipable>();
            itemList.Add(new Product("Product1", 19.99, 2));
            itemList.Add(new Product("Product2", 10, 1.5));
            Box box = new Box("Box1");
            foreach(IShipable item in itemList)
            {
                box.Add(item);
            }
            //Testiranje prvog zadatka
            Console.WriteLine("Ukupna cijena: " + box.Price);
            Console.WriteLine("Ukupna kilaža: " + box.Weight);
            //Testiranje drugog zadatka
            ShippingService service = new ShippingService(3.99);
            Console.WriteLine("Cijena dostave: " + service.calculateDeliveryPrice(box));
        }
    }
}
