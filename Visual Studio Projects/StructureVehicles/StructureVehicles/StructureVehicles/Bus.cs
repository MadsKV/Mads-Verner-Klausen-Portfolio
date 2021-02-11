using System;
using System.Collections.Generic;
using System.Text;

namespace StructureVehicles
{
    abstract class Bus : Vehicle
    {   
        public Bus (string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            energyClassEnum energyClass) : base(name, km, registrationNumber, year, newPrice, towbar, engineSize, kmPerLiter, fuelType)
        {
            throw new NotImplementedException();
        }
    }
}
