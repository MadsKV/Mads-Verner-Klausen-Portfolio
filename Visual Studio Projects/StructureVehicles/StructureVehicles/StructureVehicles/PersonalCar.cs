using System;
using System.Collections.Generic;
using System.Text;

namespace StructureVehicles
{
    abstract class PersonalCar : Vehicle
    {
        //inherited PersonalCar from Vehicle
        public PersonalCar(string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            int numberOfSeats) : base(name, km, registrationNumber, year, newPrice, towbar, engineSize, kmPerLiter, fuelType)
        {
            //PersonalCar Constructor
            this.NumberOfSeats = numberOfSeats;
        }

        /// <summary>
        /// NumberOfSeats Field and proberty
        /// </summary>
        public int NumberOfSeats;
        private int numberOfSeats;

        /// <summary>
        /// TrunkDimentions Field and proberty
        /// </summary>
        public trunkDimentionsStruct TrunkDimentions
        {
            get { return trunkDimentions; }
            set { trunkDimentions = value; }
        }
        private trunkDimentionsStruct trunkDimentions;

        /// <summary>
        /// TrunkDimentions Struct Field and proberty
        /// </summary>
        public struct trunkDimentionsStruct
        {
            public double height;
            public double width;
            public double depth;
            public override string ToString() => $"({height}, {width}, {depth})";
        }

        /// <summary>
        /// EngineSize Struct Field and proberty
        /// </summary>
        public override double EngineSize 
        {
            get { return this.engineSize; }
            set
            {
                if (value < 0.7 || value > 10.0)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} Must be between 0.7 and 10.0 L.");
                this.engineSize = value;
            }
        }

        }
        class PrivatePersonalCar : PersonalCar
        {
            //inherited PrivatePersonalCar from PersonalCar
            public PrivatePersonalCar(
            string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            int numberOfSeats,
            bool isofix,
            trunkDimentionsStruct trunkDimentions) : base(name, km, registrationNumber, year, newPrice, towbar, engineSize, kmPerLiter, fuelType, numberOfSeats)
            {
                //PersonalCar Constructor
                this.DriverLisence = driverLicenseEnum.B;
            }

            public bool isofix;


            /// <summary>
            /// ToString (String.Format)
            /// </summary>
            public override string ToString()
            {
            return base.ToString() + string.Format("\n {0}: {1}\n {2}: {3}\n {4}: {5}",
                nameof(this.isofix),
                this.isofix,
                nameof(this.NumberOfSeats),
                this.NumberOfSeats,
                nameof(this.Towbar),
                this.Towbar
                );
        }
        }
        class ProfessionalPersonalCar : PersonalCar
        {
            //inherited ProfessionalPersonalCar from Vehicle
            public ProfessionalPersonalCar(string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            trunkDimentionsStruct trunkDimentions,
            bool safetyBar,
            double loadCapacity,
            int numberOfSeats) : base(name, km, registrationNumber, year, newPrice, towbar, engineSize, kmPerLiter, fuelType, numberOfSeats)
            {
                //professionalPersoncalCar Constructor
                this.Name = name;
                this.Km = km;
                this.RegistrationNumber = registrationNumber;
                this.Year = year;
                this.NewPrice = newPrice;
                this.Towbar = towbar;
                this.engineSize = engineSize;
                this.KmPerLiter = kmPerLiter;
                this.FuelType = fuelType;
                this.TrunkDimentions = trunkDimentions;

                this.safetyBar = safetyBar;
                this.NumberOfSeats = 2;
                this.Towbar = true;

                //LoadCapacity -> DriversLicense decider
                if(loadCapacity > 750.0)
                {
                    this.DriverLisence = driverLicenseEnum.BE;
                }
                else
                {
                    this.DriverLisence = driverLicenseEnum.B;
                }
            }
            /// <summary>
            /// SafetyBar Struct Field and proberty
            /// </summary>
            public bool safetyBar;
            private bool safetyBar;
            /// <summary>
            /// EngineSize Struct Field and proberty
            /// </summary>
            public double loadCapacity;
            private double loadCapacity;

            /// <summary>
            /// ToString (String.Format)
            /// </summary>
            public override string ToString()
            {
                return base.ToString() + string.Format("\n {0}: {1}\n {2}: {3}\n {4}: {5}",
                    nameof(this.safetyBar),
                    this.safetyBar,
                    nameof(this.NumberOfSeats),
                    this.NumberOfSeats,
                    nameof(this.Towbar),
                    this.Towbar
                    );

            }
    }
}


