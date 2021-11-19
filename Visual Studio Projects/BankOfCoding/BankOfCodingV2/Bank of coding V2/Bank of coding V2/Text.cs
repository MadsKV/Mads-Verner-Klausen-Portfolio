using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_of_coding_V2
{
    public class TextClass
    {
        //Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "TEXT"));
        public void BankTitle()
        {
            // Bank logo
            Console.WriteLine("                                         |$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$|\n");
            Console.WriteLine("                                         |   Welcome to the BANK of CODING   |\n");
            Console.WriteLine("                                         |$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$|\n\n");
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
        }
        public void ExistingAccount()
        {
            // Open Login screen
            Console.WriteLine("                                                 |Existing Account menu|\n\n");
            Console.WriteLine("                                         |How would you like to proceed?|\n\n");
            Console.WriteLine("                                         |1) Log-in\n");
            Console.WriteLine("                                         |2) Forgot Account?\n\n");
            Console.WriteLine("                                         |0) Exit:        \n");
            Console.Write("                                             | --->: ");
        }
        public void LogIn()
        {
            // Open Login screen
            Console.WriteLine("                                                 |Log-in|\n\n");
            Console.WriteLine("                                         |Use your login credentials below to login|\n\n");
            Console.Write("                                             |) Username:\n");
            Console.Write("                                             |) Password:\n\n");
            Console.WriteLine("                                         |0) Exit:        \n");
            Console.Write("                                             | --->: ");
        }
        public void MyAccount()
        {
            // Open "My Account" screen
            Console.WriteLine("                                         |Welcome 'User'|\n\n");
            Console.WriteLine("                                         |Choose what you want to do below|\n\n");
            Console.WriteLine("                                         |1) Withdraw\n");
            Console.WriteLine("                                         |2) Deposit\n\n");
            Console.WriteLine("                                         |3) Transfer\n\n");
            Console.WriteLine("                                         |4) Balance\n\n");
            Console.WriteLine("                                         |0) Exit:        \n");
            Console.Write("                                             | --->: ");
            Console.Read();
        }
        public void Withdraw()
        {
            // Open withdraw amount screen
            Console.WriteLine("                                         |Welcome 'User'|\n\n");
            Console.WriteLine("                                         |Choose how much you want to withdraw|\n\n");
            Console.WriteLine("                                         |1) 100 DKK\n");
            Console.WriteLine("                                         |2) 200 DKK\n\n");
            Console.WriteLine("                                         |3) 500 DKK\n\n");
            Console.WriteLine("                                         |4) 1000 DKK\n\n");
            Console.WriteLine("                                         |5) Other amount\n\n");
            Console.WriteLine("                                         |0) Exit:        \n");
            Console.Write("                                             | --->: ");
            Console.Read();
        }
        public void Deposit()
        {
            // Open deposit amount screen
            Console.WriteLine("                                         |Welcome 'User'|\n\n");
            Console.WriteLine("                                         |Choose how much you want to deposit|\n\n");
            Console.WriteLine("                                         |1) Enter amount to deposit\n");
            Console.WriteLine("                                         |0) Exit:        \n");
            Console.Write("                                             | --->: ");
            Console.Read();
        }
        public void Transfer()
        {
            // Open transfer amount screen
            Console.WriteLine("                                         |Welcome 'User'|\n\n");
            Console.WriteLine("                                         |Choose how much you want to transfer|\n\n");
            Console.WriteLine("                                         |1) Enter amount to transfer\n");
            Console.WriteLine("                                         |0) Exit:        \n");
            Console.Write("                                             | --->: ");
            Console.Read();
        }
        public void NewAccountMenu()
        {
            // Open "New Account" Menu
            Console.WriteLine("                                              |New Account Menu|\n\n");
            Console.WriteLine("                                Enter your new login credentials below to create an account\n\n");
            Console.WriteLine("                                             |)First Name  \n");
            Console.WriteLine("                                             |)Last Name   \n");
            Console.WriteLine("                                             |)Date of birth (dd/mm/yy)\n");
            Console.WriteLine("                                             |)Password\n");
            Console.WriteLine("                                             |)Password again\n");
            Console.WriteLine("                                             |0) Exit                   \n\n");
            Console.WriteLine("                                         |Press any key to continue  1-5| \n");
            Console.Write("                                             | --->: ");
        }
        public void CustomerSupport()
        {

            // Open Customer Support screen
            Console.WriteLine("                                         |Customer Support|\n\n");
            Console.WriteLine("                                         |1) If you are having problems with your account\n");
            Console.WriteLine("                                         |2) If you are having problems making a new account\n");
            Console.WriteLine("                                         |3) If you have questions to the bank\n\n");
            Console.WriteLine("                                         |0) Exit: \n");
            Console.Write("                                             | --->: ");
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
