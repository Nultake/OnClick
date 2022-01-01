﻿using System;
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
    }
}
