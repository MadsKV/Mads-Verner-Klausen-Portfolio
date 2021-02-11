using System;

namespace StructureVehicles
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonalCar.trunkDimentionsStruct bmwtrunk;
            bmwtrunk.height = 18.00;
            bmwtrunk.width = 15.00;
            bmwtrunk.depth = 16.00;

            PersonalCar.trunkDimentionsStruct m3trunk;
            m3trunk.height = 15.00;
            m3trunk.width = 13.00;
            m3trunk.depth = 14.00;

            PersonalCar.trunkDimentionsStruct a4trunk;
            a4trunk.height = 20.00;
            a4trunk.width = 16.00;
            a4trunk.depth = 18.00;

            ProfessionalPersonalCar BMWi8 = new ProfessionalPersonalCar("BMW I8", 380, "W1CK836", 2018, 210000, true, 12, 29, Vehicle.fuelTypeEnum.Benzine, bmwtrunk, true, 480, 5);
            ProfessionalPersonalCar M3E90 = new ProfessionalPersonalCar("M3 E90", 970, "A$$EATER", 1999, 31000, true, 7, 14, Vehicle.fuelTypeEnum.Diesel, m3trunk, false, 290, 5);
            //PrivatePersonalCar AUDIA4 = new PrivatePersonalCar("AUDI A4", 630, "AQ83M3S", 2004, 99000, true, 19, 18, Vehicle.fuelTypeEnum.Benzine, 5, true, a4trunk);
            //Trucks MAN = new Trucks("MAN", 390, "LCS95SC", 1991, 98000, true, 29, 31, Vehicle.fuelTypeEnum.Diesel, Vehicle.energyClassEnum.C);


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(BMWi8);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(M3E90);
            //Console.WriteLine("\n");
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine(AUDIA4);
            //Console.WriteLine("\n");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(MAN);
        }
    }
}
