using System;

namespace BankOfCoding
{
    public class TextClass
    {
        public void BankTitle()
        {
            // Bank logo
            Console.WriteLine("                                         |$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$|\n");
            Console.WriteLine("                                         |   Welcome to the BANK of CODING   |\n");
            Console.WriteLine("                                         |$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$|\n\n\n");
        }
        public void BankMenu()
        {
            // Bank menu options
            Console.WriteLine("                                                     |MAIN MENU|\n\n");
            Console.WriteLine("                                         =================================\n");
            Console.WriteLine("                                         |1) Make New Account:            |\n");
            Console.WriteLine("                                         |2) Login to Existing Account:   |\n");
            Console.WriteLine("                                         |3) Contact Customer Support:    |\n");
            Console.WriteLine("                                         |4) Exit Menu:                   |\n\n");
            Console.WriteLine("                                         | Press any key to continue   1-4| \n");
            Console.Write("                                             | --->: ");
            Console.Read();

        }
        public void NewAccountMenu()
        {
            // Open "New Account" Menu
            Console.WriteLine("                                                     |New Account Menu|\n\n");
            Console.WriteLine("                                     Choose what type of account you would like created\n\n");
            Console.WriteLine("                                                 |1) Basic        Account:  |\n");
            Console.WriteLine("                                                 |2) Savings      Account:  |\n");
            Console.WriteLine("                                                 |3) Checking     Account:  |\n");
            Console.WriteLine("                                                 |4) Investment   Account:  |\n");
            Console.WriteLine("                                                 |5) Exit                   |\n\n");
            Console.WriteLine("                                                 |Press any key to continue  1-5| \n");
            Console.Write("                                                     | --->: ");
            Console.Read();
        }
        public void ExistingAccount()
        {
            // Open Login screen
            Console.WriteLine("                                                 |Existing Account menu|\n\n");
            Console.WriteLine("                                                 |Use your login credentials below to login|\n\n");
            Console.WriteLine("                                                 |1) Log-in\n");
            Console.WriteLine("                                                 |2) Forgot Account?\n\n");
            Console.WriteLine("                                                 |3) Exit:        \n");
            Console.Write("                                                     | --->: ");
            Console.Read();
        }
        public void CustomerSupport()
        {

            // Open Customer Support screen
            Console.WriteLine("                                                 |Customer Support|\n\n");
            Console.WriteLine("                                                 |1) If you are having problems with your account\n");
            Console.WriteLine("                                                 |2) If you are having problems making a new account\n");
            Console.WriteLine("                                                 |3) If you have questions to the bank\n\n");
            Console.WriteLine("                                                 |4) Exit: \n");
            Console.Write("                                                     | --->: ");
            Console.Read();

        }
        public void EndScreen()
        {
            Console.WriteLine("                                         |$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$|\n");
            Console.WriteLine("                                         |           BANK of CODING          |\n");
            Console.WriteLine("                                         |$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$|\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                           Thanks for choosing BANK of CODING. Hope to see you again soon.\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                         |$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$|\n");
            Console.WriteLine("                                         |           BANK of CODING          |\n");
            Console.WriteLine("                                         |$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$|\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                     Coded by M.V.K\n\n");
        }
    }
}
