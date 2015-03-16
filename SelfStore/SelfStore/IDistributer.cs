using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturerProject
{
    interface IDistributer
    {
        void Update(Manufacturer p_Manufacturer, Product p_Product);
    }
}
