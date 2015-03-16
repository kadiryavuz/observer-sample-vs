using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturerProject
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int p_id, string p_name, double p_price)
        {
            this.ID = p_id;
            this.Name = p_name;
            this.Price = p_price;
        }

    }
}
