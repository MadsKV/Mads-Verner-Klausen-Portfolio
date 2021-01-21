using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SqlInjection
{
    class SecureVersion
    {
        //Den farlige injection der er mulig at lave ved input 2 (StudentLastname) dette kan potentielt være DROP TABLE, DELETE FROM osv osv.
        //sqlinjection', 1,2); CREATE TABLE Sqlinjection (Id int);--

        public static SqlConnection openConnection()
        {
            SqlConnectionStringBuilder builder =
            new SqlConnectionStringBuilder();

            builder.DataSource = @"MADS-V-KLAUSEN\MSSQLSERVER01";
            builder.InitialCatalog = "School101";
            builder.IntegratedSecurity = true;

            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
            return connection;
        }
        public static void CreateStudent(string StudentFirstName, string StudentLastName, int StudentAge, int ClassID)
        {
            SqlConnection conn = openConnection(); // Åbner forbindelse til databasen



            // Initialiserer en ny instans af SqlClient build-in funktion fra System.Data.SqlClient;
            using SqlCommand command = new SqlCommand(@"INSERT INTO Student
                                                      (StudentFirstname, StudentLastName, StudentAge, ClassID)
                                                      VALUES(@StudentFirstName, @StudentLastName, @StudentAge, @ClassID)", conn);
            {
                command.Parameters.Add("@StudentFirstName", SqlDbType.NVarChar, 32).Value = StudentFirstName;
                command.Parameters.Add("@StudentLastName", SqlDbType.NVarChar, 32).Value = StudentLastName;
                command.Parameters.Add("@studentAge", SqlDbType.Int).Value = StudentAge;
                command.Parameters.Add("@ClassID", SqlDbType.Int).Value = ClassID;
                command.ExecuteNonQuery();
                conn.Close(); // Lukker forbindelsen til databasen når query er kørt.
            }
        }
            public static void Main(string[] args)
            {
                const ConsoleKey keyInfo1 = ConsoleKey.D1;

                while (true)
                {
                    Console.Clear();
                    Console.ForegroundColor
                    = ConsoleColor.DarkGray;
                    Console.WriteLine("" +
                        "Press 1 :For Student Management.\n");

                    ConsoleKey pressedKey = PressedKey();

                    switch (pressedKey)
                    {
                        case keyInfo1:
                            Console.ForegroundColor
                            = ConsoleColor.Blue;

                            switch (pressedKey)
                            {
                                // The Second menu
                                case keyInfo1:
                                    Console.ForegroundColor
                                    = ConsoleColor.Blue;
                                    Console.Clear();
                                    Console.WriteLine("" +
                                    "Press 1 :To Create a new Student");

                                    pressedKey = PressedKey();

                                    switch (pressedKey)
                                    {
                                        case keyInfo1:
                                            Console.ForegroundColor
                                            = ConsoleColor.Blue;
                                            Console.WriteLine("Enter the credentials of the student in this format : \n\n" +
                                                ">First name, Last name, Age, ClassID<");
                                            string CInput = Console.ReadLine();
                                            string CInput2 = Console.ReadLine();
                                            int CInput3 = int.Parse(Console.ReadLine());
                                            int CInput4 = int.Parse(Console.ReadLine());
                                            CreateStudent(CInput, CInput2, CInput3, CInput4);
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
                    ConsoleKey PressedKey()
                    {
                        do
                        {
                            while (!Console.KeyAvailable) ;
                            ConsoleKey pressed = Console.ReadKey(true).Key;
                            if (pressed == keyInfo1)
                                return pressed;
                            Console.Clear();
                        } while (true);

                    }
                }
            }
    }
}
    

