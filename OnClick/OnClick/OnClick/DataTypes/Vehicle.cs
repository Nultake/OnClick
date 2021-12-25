using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class Vehicle : Product
    {

        public string brand { get; set; }
        public string color { get; set; }
        public int engineVolume { get; set; }
        public double fuelConsumption { get; set; }
        public FuelType fuelType { get; set; }
        public int kilometers { get; set; }
        public int modelYear { get; set; }
        public Shifter shifter { get; set; }
        public Type type { get; set; }

        public Vehicle() : base()
        {
        }
    }
}
