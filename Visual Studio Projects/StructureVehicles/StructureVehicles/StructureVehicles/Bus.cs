using System;
using System.Collections.Generic;
using System.Text;

namespace StructureVehicles
{
    class Bus : Vehicle
    {
        //inherited Bus from Vehicle
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
            //Bus Constructor
            this.BusDimentions = busDimentions;
            this.NumberOfSeats = numberOfSeats;
            this.NumberOfSleepingRoom = numberOfSleepingRoom;
            this.Toilets = toilets;
            this.DriverLisence = driverLicenseEnum.D;
        }

        /// <summary>
        /// NumberOfSeats Field and proberty
        /// </summary>
        public int NumberOfSeats;
        private int numberOfSeats;

        /// <summary>
        /// NumberOfSleepingRoom Field and proberty
        /// </summary>
        public int NumberOfSleepingRoom;
        private int numberOfSleepingRoom;

        /// <summary>
        /// Toilets Field and proberty
        /// </summary>
        public bool Toilets;
        private bool toilets;

        /// <summary>
        /// BusDimentions Field and proberty
        /// </summary>
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

        /// <summary>
        /// ToString (String.Format)
        /// </summary>
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
