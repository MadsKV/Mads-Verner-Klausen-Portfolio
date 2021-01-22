using System;
using System.Collections.Generic;
using System.Text;

namespace StructureVehicles
{
    abstract class Vehicle
    {
        
        public string name();
        public double km();
        public double kmL();
        public string fuel();
        public string registerNumber();
        public int year();
        public double newPrice();
        public bool towbar();
        public string drivingLicenseType();
        public string motorSize();
        public string energyClass();
    }
}
