using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz
{
    public class Product
    {
        public string Name { get; set; }

        public string Price { get; set; }

        public string Quantity { get; set; }

        public string Country { get; set; }

        public string Discount { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nQuantity: {Quantity}\nCountry: {Country}\nDiscount: {Discount}";
        }
    }
}