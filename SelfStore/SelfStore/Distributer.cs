using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturerProject
{
    class Distributer : IDistributer
    {
        public string Name { get; set; }

        public Distributer(string p_name)
        {
            this.Name = p_name;
        }

        public void Update(Manufacturer p_Manufacturer, Product p_Product)
        {
            switch (p_Manufacturer._actionType)
            {

                case UpdateType.NewProduct:
                    Console.WriteLine("Dear {0}, new Product Added! {1} announced {2} with price {3:C}", Name, p_Manufacturer.Name, p_Product.Name, p_Product.Price);
                    break;
                case UpdateType.PriceChanged:
                    Console.WriteLine("Dear {0}, Price Changed! {1} announced {2} with new price {3:C}", Name, p_Manufacturer.Name, p_Product.Name, p_Product.Price);
                    break;
                case UpdateType.None:
                default:
                    break;
            }

        }
    }
}
