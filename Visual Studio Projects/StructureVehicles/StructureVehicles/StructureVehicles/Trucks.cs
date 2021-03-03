using System;
using System.Collections.Generic;
using System.Text;

namespace StructureVehicles
{
    class Trucks : Vehicle
    {
        public Trucks(string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            truckDimentionsStruct trunkDimentions,
            double loadCapacity) : base (name, km, registrationNumber, year, newPrice, towbar, engineSize, kmPerLiter, fuelType)
        {
            this.TruckDimentions = truckDimentions;
            this.DriverLisence = driverLicenseEnum.C;
        }
        public int LoadCapacity;
        private int loadCapacity;
        public override double EngineSize
        {
            get { return this.engineSize; }
            set
            {
                if (value < 4.2 || value > 15.0)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} Must be between 4.2 and 15.0 L.");

                this.engineSize = value;
            }
        }

        public truckDimentionsStruct TruckDimentions
        {
            get { return truckDimentions; }
            set { truckDimentions = value; }
        }
        private truckDimentionsStruct truckDimentions;

        public struct truckDimentionsStruct
        {
            public double height;
            public double weight;
            public double length;
            public override string ToString() => $"({height}, {weight}, {length})";
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n {0}: {1}\n {2}:{3}",
                    nameof(this.Towbar),
                    this.Towbar,
                    nameof(this.loadCapacity),
                    this.loadCapacity,
                    nameof(this.truckDimentions),
                    this.truckDimentions
                    );
        }
    }
}
