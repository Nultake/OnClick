using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class RealEstateProperty : Product
    {

        public string address { get; set; }
        public int area { get; set; }
        public HeatingSystem heatingSystem { get; set; }
        public int roomNumber { get; set; }

    }
}
