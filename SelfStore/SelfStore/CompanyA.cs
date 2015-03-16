using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturerProject
{
    class CompanyA : Manufacturer
    {
        public CompanyA(string p_Name)
            : base(p_Name)
        {

        }

        public override List<Product> LoadProducts()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product(101, "Product1", 10.86));
            productList.Add(new Product(102, "Product2", 22.89));
            productList.Add(new Product(103, "Product3", 15.50));
            productList.Add(new Product(104, "Product4", 75.50));

            return productList;
        }
    }
}
