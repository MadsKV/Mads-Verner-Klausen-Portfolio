using System;
using System.Collections.Generic;
using System.Text;

namespace StructureVehicles
{
    class Bus : PersonalCar
    {
        public Bus(string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmPerLiter,
            fuelTypeEnum fuelType,
            busDimentionsStruct busDimentions,
            int numberOfSeats,
            int numberOfSleepingRoom,
            bool toilets) : base(name, km, registrationNumber, year, newPrice, towbar, engineSize, kmPerLiter, fuelType, numberOfSeats)
        {
            this.BusDimentions = busDimentions;
            this.NumberOfSeats = numberOfSeats;
            this.NumberOfSleepingRoom = numberOfSleepingRoom;
            this.Toilets = toilets;
            this.DriverLisence = driverLicenseEnum.D;
        }

        public int NumberOfSeats;
        private int numberOfSeats;

        public int NumberOfSleepingRoom;
        private int numberOfSleepingRoom;

        public bool Toilets;
        private bool toilets;


        public busDimentionsStruct BusDimentions
        {
            get { return busDimentions; }
            set { busDimentions = value; }
        }
        private busDimentionsStruct busDimentions;

        public struct busDimentionsStruct
        {
            public double height;
            public double weight;
            public double length;
            public override string ToString() => $"({height}, {weight}, {length})";
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n {0}: {1}\n {2}: {3}\n {4}: {5}\n {6}: {7}\n {8}: {9}",
                    nameof(this.Towbar),
                    this.Towbar,
                    nameof(this.busDimentions),
                    this.busDimentions,
                    nameof(this.numberOfSeats),
                    this.numberOfSeats,
                    nameof(this.numberOfSleepingRoom),
                    this.numberOfSleepingRoom,
                    nameof(this.toilets),
                    this.toilets
                    );
        }

    }
}
