using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyA companyA = new CompanyA("CompanyA");
            Console.WriteLine("Review CompanyA Products");
            foreach (Product item in companyA.Products)
            {
                Console.WriteLine("Name {0}, Price {1:C}", item.Name, item.Price);
            }
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
            //distributer definitions
            Distributer distributer1 = new Distributer("Distributer1");
            Distributer distributer2 = new Distributer("Distributer2");
            Distributer distributer3 = new Distributer("Distributer3");
            //subscribing distributers
            companyA.Attach(distributer1);
            companyA.Attach(distributer2);
            companyA.Attach(distributer3);

            companyA.ChangePrice(102, 80.00);
            Console.WriteLine("********");
            companyA.Detach(distributer2);
            Console.WriteLine(distributer2.Name + " is detached..");
            companyA.AddProduct(new Product(108, "Product8", 44.00));
            Console.WriteLine("********");
            companyA.ChangePrice(104, 56.00);
            Console.WriteLine("********");
            Console.WriteLine("Latest Prices of Products");
            foreach (Product item in companyA.Products)
            {
                Console.WriteLine("Name {0}, Price {1:C}", item.Name, item.Price);
            }
            Console.ReadKey();
        }
    }
}
