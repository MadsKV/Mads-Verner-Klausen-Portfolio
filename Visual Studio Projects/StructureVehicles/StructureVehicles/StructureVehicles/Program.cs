using System;
using System.Collections.Generic;

namespace StructureVehicles
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ProfessionalCar
            PersonalCar.trunkDimentionsStruct bmwtrunk;
            bmwtrunk.height = 18.00;
            bmwtrunk.width = 15.00;
            bmwtrunk.depth = 16.00;
            PersonalCar.trunkDimentionsStruct m3trunk;
            m3trunk.height = 15.00;
            m3trunk.width = 13.00;
            m3trunk.depth = 14.00;


            ProfessionalPersonalCar BMWi8 = new ProfessionalPersonalCar("BMW I8", 380, "W1CK836", 2018, 210000, true, 12, 29, Vehicle.fuelTypeEnum.Benzine, bmwtrunk, true, 480, 5);
            ProfessionalPersonalCar M3E90 = new ProfessionalPersonalCar("M3 E90", 970, "A$$EATER", 1999, 31000, true, 7, 14, Vehicle.fuelTypeEnum.Diesel, m3trunk, false, 290, 5);
            #endregion
            #region PersonalCar
            PersonalCar.trunkDimentionsStruct a4trunk;
            a4trunk.height = 20.00;
            a4trunk.width = 16.00;
            a4trunk.depth = 18.00;

            PersonalCar.trunkDimentionsStruct bugatitrunk;
            bugatitrunk.height = 14.00;
            bugatitrunk.width = 16.00;
            bugatitrunk.depth = 15.00;

            PrivatePersonalCar AUDIA4 = new PrivatePersonalCar("AUDI A4", 630, "AQ83M3S", 2004, 99000, true, 19, 18, Vehicle.fuelTypeEnum.Benzine, 5, true, a4trunk);
            PrivatePersonalCar Bugati = new PrivatePersonalCar("Bugati Chiron", 930, "AP94K6Z", 2008, 168000, true, 14, 24, Vehicle.fuelTypeEnum.Benzine, 5, true, bugatitrunk);
            #endregion
            #region Trucks
            Trucks.truckDimentionsStruct MANSize;
            MANSize.height = 19.00;
            MANSize.weight = 2870.00;
            MANSize.length = 21.00;

            Trucks.truckDimentionsStruct ScaniaSize;
            ScaniaSize.height = 21.00;
            ScaniaSize.weight = 2240.00;
            ScaniaSize.length = 24.00;


            Trucks MAN = new Trucks("MAN", 1700, "LS23M4S", 1999, 54000, true, 31, 21, Vehicle.fuelTypeEnum.Benzine, MANSize, 1200 );
            Trucks Scania = new Trucks("Scania", 1400, "YS71X9L", 2001, 68000, true, 29, 24, Vehicle.fuelTypeEnum.Benzine, ScaniaSize, 1600);
            #endregion
            #region Busses
            Bus.busDimentionsStruct schoolSize;
            schoolSize.height = 14.00;
            schoolSize.weight = 1360.00;
            schoolSize.length = 28.00;

            Bus.busDimentionsStruct taxiSize;
            taxiSize.height = 11.00;
            taxiSize.weight = 940.00;
            taxiSize.length = 18.00;


            Bus School = new Bus("SchoolBus", 1800, "IC34O5S", 1994, 31000, true, 18, 21, Vehicle.fuelTypeEnum.Diesel, schoolSize, 18, 4, true);
            Bus Taxi = new Bus("Taxi", 2100, "AK11S8P", 2004, 56000, true, 23, 19, Vehicle.fuelTypeEnum.Diesel, taxiSize, 6, 0, true);
            #endregion

            #region ColorCoding
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("professionalCar = Red color");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PrivateCar = Blue color");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Trucks = Yellow color");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Busses = Magenta color");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            #endregion

            #region ProfessionalCar
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(BMWi8);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(M3E90);
            Console.WriteLine("\n");
            #endregion
            #region PersonalCar
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(AUDIA4);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Bugati);
            Console.WriteLine("\n");
            #endregion
            #region Trucks
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(MAN);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Scania);
            Console.WriteLine("\n");
            #endregion
            #region Busses
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(School);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Taxi);
            Console.WriteLine("\n");
            #endregion

            List<Vehicle> Auctionvehicles = new List<Vehicle>();
            Auctionvehicles.Add(BMWi8);
            Auctionvehicles.Add(M3E90);
            Auctionvehicles.Add(AUDIA4);
            Auctionvehicles.Add(Bugati);
            Auctionvehicles.Add(MAN);
            Auctionvehicles.Add(Scania);
            Auctionvehicles.Add(School);
            Auctionvehicles.Add(Taxi);

            foreach(Vehicle vehicle in Auctionvehicles)
            {
                Console.WriteLine(Auctionvehicles.ToString() + "\n");
            }
        }
    }
}
