using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class Product
    {
        public string info { get; set; }
        public bool isTradable { get; set; }
        public double price { get; set; }
        public PropertyType propertyType { get; set; }


        public override string ToString()
        {
            return "\n" + "Product info: " + info + "\n" + "Tradable: " + isTradable + "\n" + "Price: " + price + "\n" + "Property Type: " + propertyType;
        }
    }
}
