using System;
using System.Collections.Generic;
using System.Dynamic;
using TECHCOOL;

namespace Discard__message_
{
    class Program
    {
        static void Main(string[] args)
        {
            string host = "http://localhost:8080/";
            if (args.Length > 0)
            {
                host = args[0];
            }
            Console.WriteLine(host);
            SQLet.ConnectSqlServer("Discard", @"MADS-V-KLAUSEN\MSSQLSERVER01");
            RequestHandler requestHandler = new RequestHandler(host);
            requestHandler.Start();
            Console.Read();
        }
        static void Main_(string[] args)
        {
            SQLet.ConnectSqlServer("Discard", @"MADS-V-KLAUSEN\MSSQLSERVER01", "SA", "Muskel-Jack");
            Database.SetupSQLServer();

            Database.GetMessages();
            List<Message> beskeder = Database.GetMessages();
            string beskedHTML = HTML_Generator.GenerateMessage(beskeder);
            Console.WriteLine(beskedHTML);
            List<Users> user = Database.GetUsers();
            string userList = HTML_Generator.GenerateUser(user);
            Console.WriteLine(user);
            string userHTML = HTML_Generator.GenerateUser(user);
            string index = HTML_Generator.GenerateIndex(beskeder, user, 0);
            Console.WriteLine(index);
            System.IO.File.WriteAllText("C:/Users/MadsV/OneDrive/Dokumenter/GitHub/Mads-Verner-Klausen-Portfolio/Discard/Studio Project/Discard (message)/Discard (message)/HTML/test.html", index);
            Console.ReadKey();
            const ConsoleKey keyInfo1 = ConsoleKey.D1;
            const ConsoleKey keyInfo2 = ConsoleKey.D2;
            const ConsoleKey keyInfo3 = ConsoleKey.D3;
            const ConsoleKey keyInfo4 = ConsoleKey.D4;
            const ConsoleKey keyInfo5 = ConsoleKey.D5;
            const ConsoleKey keyInfo6 = ConsoleKey.D6;
            const ConsoleKey keyInfo7 = ConsoleKey.D7;
            const ConsoleKey keyInfo8 = ConsoleKey.D8;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor
                = ConsoleColor.DarkGray;
                MessagesMethods.SelectAllMessage();
                Console.WriteLine("" +
                    "Press 1 :Insert Message.\n" +
                    "Press 2 :Delete Message.\n" +
                    "Press 3 :Update Message.\n" +
                    "Press 4 :Show Message from user.\n\n" +
                    "Press 5 :Insert new Author.\n" +
                    "Press 6 :Delete Author.\n" +
                    "Press 7 :Update Author.\n" +
                    "Press 8 :Show Message from Author.\n");

                ConsoleKey pressedKey = PressedKey();

                switch (pressedKey)
                {
                    case keyInfo1:
                        Console.ForegroundColor
                        = ConsoleColor.Blue;
                        Console.Write("Enter new message > ");
                        string input = Console.ReadLine();
                        Console.Write("What author ID is this message connected to? > ");
                        
                        int messagesauthor = int.Parse(Console.ReadLine());
                        MessagesMethods.insertMessage(input, messagesauthor);
                        break;

                    case keyInfo2:
                        Console.ForegroundColor
                        = ConsoleColor.Blue;
                        Console.Write("Specify what Message_ID you want to delete > ");
                        string inputdelete = Console.ReadLine();
                        MessagesMethods.deleteMessage(inputdelete);
                        break;

                    case keyInfo3:
                        Console.ForegroundColor
                        = ConsoleColor.Blue;
                        Console.Write("What Message_ID do you want to update > ");
                        string inputUpdate = Console.ReadLine();
                        Console.Write("What do you want to update the message to > ");
                        string inputMessage = Console.ReadLine();
                        MessagesMethods.updateMessage(inputUpdate, inputMessage);
                        break;

                    case keyInfo4:
                        Console.ForegroundColor
                        = ConsoleColor.Green;
                        Console.Write("What Author_ID do you want to see messages from? > ");
                        string aInputID = Console.ReadLine();
                        MessagesMethods.SelectMessage(aInputID);
                        break;

                    case keyInfo5:
                        Console.ForegroundColor
                        = ConsoleColor.Green;
                        Console.Write("Enter new Author Name > ");
                        string Authorinput = Console.ReadLine();
                        UserMethods.insertAuthor(Authorinput);
                        break;

                    case keyInfo6:
                        Console.ForegroundColor
                        = ConsoleColor.Green;
                        Console.Write("Specify what Author_ID you want to delete > ");
                        string Authorinputdelete = Console.ReadLine();
                        UserMethods.deleteAuthor(Authorinputdelete);
                        break;

                    case keyInfo7:
                        Console.ForegroundColor
                        = ConsoleColor.Green;
                        Console.Write("What Author_ID do you want to update > ");
                        string AuthorinputUpdate = Console.ReadLine();
                        Console.Write("What do you want to update the Author_Name to > ");
                        string AuthorinputMessage = Console.ReadLine();
                        UserMethods.updateAuthor(AuthorinputUpdate, AuthorinputMessage);
                        break;

                    case keyInfo8:
                        Console.ForegroundColor
                        = ConsoleColor.Green;
                        Console.Write("What Author_ID do you want to see messages from(Under construction)? > ");
                        string AuthoraInputID = Console.ReadLine();
                        UserMethods.SelectAuthor(AuthoraInputID);
                        break;
                }
            }
            ConsoleKey PressedKey()
            {
                do
                {
                    while (!Console.KeyAvailable) ;
                    ConsoleKey pressed = Console.ReadKey(true).Key;
                    if (pressed == keyInfo1 || pressed == keyInfo2 || pressed == keyInfo3 || pressed == keyInfo4 || pressed == keyInfo5 || pressed == keyInfo6 || pressed == keyInfo7 || pressed == keyInfo8)
                        return pressed;
                    Console.Clear();
                } while (true);
            }
        }
    }
}

