using System;
using OnClick.DataTypes;
using VehicleType = OnClick.DataTypes.VehicleType;

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
        public VehicleType type { get; set; }

        public Vehicle() : base()
        {
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + "Brand: " + brand + "\n" + "Color: " + color + "\n" + "Engine Volume: " + engineVolume + "\n" + "Fuel Consumption: " + fuelConsumption + "\n" + "Fuel Type: " +
                fuelType + "\n" + "Kilometers: " + kilometers + "\n" + "Model Year: " + modelYear + "\n" + "Shifter: " + shifter + "\n" + "Type: " + type;
        }
    }
}
