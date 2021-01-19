using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SqlInjection
{
    class Program
    {
        public static SqlConnection Connection()
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
        //Den farlige injection der er mulig at lave ved input 2 (StudentLastname) dette kan potentielt være DROP TABLE, DELETE FROM osv osv.
        //sqlinjection', 1,2); CREATE TABLE Sqlinjection (Id int);--

        //for at undgå at denne type injection kan bruges, skal man forebygge parameter hvilket bliver vist i "SecureVersion"
        public static string insertStudent(string StudentFirstName, string StudentLastName, int StudentAge, int ClassID, SqlConnection connection)
        {
            try
            {
                string sql = @"
                    INSERT INTO Student (StudentFirstName, StudentLastName, StudentAge, ClassID)
                    VALUES ('{0}', '{1}', {2}, {3})";
                string formatted = string.Format(sql, StudentFirstName, StudentLastName, StudentAge, ClassID);
                SqlCommand command = new SqlCommand(formatted, connection);

                int numberOfRowAffected = command.ExecuteNonQuery();
                return numberOfRowAffected + "Rows was affected.\n";
            }
            catch (SqlException e)
            {
                Console.WriteLine("SQL exception caught in DeleteById " + e.ToString());
                Console.ReadLine();
                return "0 rows affected.\n";
            }
        }
        public static void Main(string[] args)
        {
            SqlConnection connection = Connection();

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
                                        insertStudent(CInput, CInput2, CInput3, CInput4, connection);
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