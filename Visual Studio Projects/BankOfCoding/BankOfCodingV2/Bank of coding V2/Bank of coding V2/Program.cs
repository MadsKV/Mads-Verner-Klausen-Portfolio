using System;
using System.Data.SqlClient;

namespace Bank_of_coding_V2
{
    public class Program
    {
            public static SqlConnection Connection()
            {
                SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder();

                //Finds and Uses the correct Database
                builder.DataSource = @"MADS-V-KLAUSEN\MSSQLSERVER01";
                //builder.DataSource = @"DESKTOP-CHHJASV\SQLEXPRESS";
                builder.InitialCatalog = "Bank Of Coding";
                builder.IntegratedSecurity = true;

                //Opens the database's connection
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                connection.Open();
                return connection;
            }
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

                //Program p = new Program();
                TextClass t = new TextClass();
                AccountChanges C = new AccountChanges();
                ExistingAccount E = new ExistingAccount();
                NewAccountMenu N = new NewAccountMenu();
                CustomerSupport S = new CustomerSupport();


                const ConsoleKey keyInfo0 = ConsoleKey.D0;
                const ConsoleKey keyInfo1 = ConsoleKey.D1;
                const ConsoleKey keyInfo2 = ConsoleKey.D2;
                const ConsoleKey keyInfo3 = ConsoleKey.D3;
                const ConsoleKey keyInfo4 = ConsoleKey.D4;
                const ConsoleKey keyInfo5 = ConsoleKey.D5;
                const ConsoleKey keyInfo6 = ConsoleKey.D6;

            Console.Clear();
                //t.BankTitle();
                //t.BankMenu();

            while (true)
            {
                //Clears the screen everytime it goes back to the menu after use
                Console.Clear();
                Console.ForegroundColor
                = ConsoleColor.DarkGray;
                t.BankTitle();
                t.BankMenu();

                ConsoleKey pressedKey = PressedKey();

                // Gives the user the option to go to the desired place (Key 1-6)
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
                                t.BankTitle();
                                t.NewAccountMenu();

                                pressedKey = PressedKey();

                                switch (pressedKey)
                                {
                                    //Gives the user the option to Insert a new customer to the database
                                    case keyInfo1:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Console.WriteLine("Enter the credentials of your new account in this format : \n\n" +
                                            ">First name, Last name, Date of Birth, Pin code, Pin code again<");
                                        string CInput = Console.ReadLine();
                                        string CInput2 = Console.ReadLine();
                                        string CInput3 = Console.ReadLine();
                                        int CInput4 = int.Parse(Console.ReadLine());
                                        string CInput5 = Console.ReadLine();
                                        //Database.insertCustomer(CInput, CInput2, CInput3, CInput4, CInput5, connection);
                                        break;

                                    //Gives the user the option to Delete a customer from the database
                                    case keyInfo2:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Console.WriteLine("Enter the BANK ID of the account you would like to Delete : \n\n");
                                        int CDelete = int.Parse(Console.ReadLine());
                                        //Database.deleteCustomer(CDelete, connection);
                                        break;

                                    //Gives the user the option to update a existing users credentiels
                                    case keyInfo3:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Console.Write("Enter the Bank ID of the Customer you would like to Update > ");
                                        int CUpdate = int.Parse(Console.ReadLine());
                                        Console.Write("Enter the First Name of the users account > ");
                                        string CUpdate2 = Console.ReadLine();
                                        Console.Write("Enter the Last Name of the users account > ");
                                        string CUpdate3 = Console.ReadLine();
                                        Console.Write("Enter the Date of birth (dd/mm/yy) of the users account > ");
                                        string CUpdate4 = Console.ReadLine();
                                        Console.Write("Enter the password of the users account > ");
                                        string CUpdate5 = Console.ReadLine();
                                        Console.Write("Enter the password again of the users account > ");
                                        int CUpdate6 = int.Parse(Console.ReadLine());
                                        //Database.updateCustomer(CUpdate, CUpdate2, CUpdate3, CUpdate4, CUpdate5, CUpdate6, connection);
                                        break;

                                    //Gives the user the option to display all the current users in the database
                                    case keyInfo4:
                                        Console.ForegroundColor
                                        = ConsoleColor.Green;
                                        Console.WriteLine("All the current accounts :");
                                        //Database.ShowCustomers(connection);
                                        break;

                                    //Gives the user the option to display specific users from the database
                                    case keyInfo5:
                                        Console.ForegroundColor
                                        = ConsoleColor.Green;
                                        Console.Write("What are you looking for? (account ID) > ");
                                        string Search = Console.ReadLine();
                                        //Database.SearchCustomer(connection, Search);
                                        break;

                                    //Gives the user the option to go back a step (To the previous menu)
                                    case keyInfo0:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        break;
                                }
                                break;
                        }
                        break;

                    //The third menu
                    case keyInfo2:
                        Console.ForegroundColor
                        = ConsoleColor.Blue;
                        Console.Clear();
                        t.BankTitle();
                        t.ExistingAccount();

                        pressedKey = PressedKey();

                        switch (pressedKey)
                        {
                            //Gives the user the option to Insert a new item into the Database
                            case keyInfo1:
                                Console.ForegroundColor
                                = ConsoleColor.Blue;
                                t.LogIn();
                                //string IInput = Console.ReadLine();
                                //int IInput2 = int.Parse(Console.ReadLine());
                                //double IInput3 = double.Parse(Console.ReadLine());
                                //Database.insertItems(IInput, IInput2, IInput3, connection);
                                break;

                            //Gives the user the option to Delete an item from the Database
                            case keyInfo2:
                                Console.ForegroundColor
                                = ConsoleColor.Blue;
                                
                                break;

                            //Gives the user the option to Update an item from the Database
                            case keyInfo3:
                                Console.ForegroundColor
                                = ConsoleColor.Blue;
                                
                                break;

                            //Gives the user the option to Display all the current items in the Database
                            case keyInfo4:
                                Console.ForegroundColor
                                = ConsoleColor.Green;
                                
                                break;

                            //Gives the user the option to Display specific items from the Database
                            case keyInfo5:
                                Console.ForegroundColor
                                = ConsoleColor.Green;
                                
                                break;

                            //Gives the user the option to go back a step (To the previous menu)
                            case keyInfo0:
                                Console.ForegroundColor
                                = ConsoleColor.Blue;
                                break;
                        }
                        break;

                    //The forth menu
                    case keyInfo3:
                        Console.ForegroundColor
                        = ConsoleColor.Blue;
                        Console.Clear();
                        t.BankTitle();
                        t.CustomerSupport();

                        pressedKey = PressedKey();

                        switch (pressedKey)
                        {
                            //Gives the user the option to Insert a new item into the Database
                            case keyInfo1:
                                Console.ForegroundColor
                                = ConsoleColor.Blue;
                                t.CustomerSupport();
                                break;

                            //Gives the user the option to Delete an item from the Database
                            case keyInfo2:
                                Console.ForegroundColor
                                = ConsoleColor.Blue;

                                break;

                            //Gives the user the option to Update an item from the Database
                            case keyInfo3:
                                Console.ForegroundColor
                                = ConsoleColor.Blue;

                                break;

                            //Gives the user the option to Display all the current items in the Database
                            case keyInfo4:
                                Console.ForegroundColor
                                = ConsoleColor.Green;

                                break;

                            //Gives the user the option to Display specific items from the Database
                            case keyInfo5:
                                Console.ForegroundColor
                                = ConsoleColor.Green;

                                break;

                            //Gives the user the option to go back a step (To the previous menu)
                            case keyInfo0:
                                Console.ForegroundColor
                                = ConsoleColor.Blue;
                                break;
                        }
                        break;

                    //Terminates the program.
                    case keyInfo4:
                        Environment.Exit(0);
                        break;
                }
            }


            ConsoleKey PressedKey()
            {
                do
                {
                    while (!Console.KeyAvailable) ;
                    ConsoleKey pressed = Console.ReadKey(true).Key;
                    if (pressed == keyInfo0 || pressed == keyInfo1 || pressed == keyInfo2 || pressed == keyInfo3 || pressed == keyInfo4 || pressed == keyInfo5 || pressed == keyInfo6)
                        return pressed;
                    Console.Clear();
                } while (true);
            }
        }
    }
}
