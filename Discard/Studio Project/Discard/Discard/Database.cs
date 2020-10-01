using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TECHCOOL;

namespace Discard__message_
{
    class Database
    {
        public static void SetupSQLServer()
        {
            try
            {

            SQLet.Execute(@"CREATE TABLE Author (
                Author_ID int primary key IDENTITY(1,1) NOT NULL,
                Author_Name nvarchar(32) NOT NULL
                )");

            SQLet.Execute(@"CREATE TABLE Messages (
                Message_ID int primary key IDENTITY(1,1) NOT NULL,
                Message_Date datetime NOT NULL DEFAULT GETDATE(),
                Message_Text text NOT NULL,
                Message_Author_ID int NOT NULL CONSTRAINT FK_user_message FOREIGN KEY (Message_Author_ID)
                    REFERENCES Author
                    ON DELETE Cascade
                    ON Update Cascade
                )");
            
            SQLet.Execute(@"CREATE VIEW Discard_Info AS 
                SELECT Message_Text, Message_ID, Message_Author_ID, Message_Date, sender.Author_Name, Recipient_ID, Recipient.Author_Name AS Recipient
                FROM Messages 
                INNER JOIN Author 
                    AS sender ON Messages.Message_Author_ID=sender.Author_ID
                    LEFT JOIN Author AS Recipient ON messages.Recipient_ID = Recipient.Author_ID
                    ");
             }
            catch(Microsoft.Data.SqlClient.SqlException)
            {

            }

        }
        public static List<Message> GetMessages()
        {
            List<Message> messages = new List<Message>();
            Result result = SQLet.GetResult(@$"SELECT * FROM Discard_Info
                                              WHERE (Recipient_ID = 0 || Recipient_ID IS NULL
                                              OR Recipient_ID == {Users.CurrentUserId}
                                              OR Author_ID == {Users.CurrentUserId}");
            int number = 0;
            foreach (var row in result)
            {
                int.TryParse(row["Message_Author_ID"], out number); //Parser tekseten Athor_ID om til et tal
                Message msg = new Message(row["Message_Text"], number); //Opretter en instans af message
                msg.Message_Date = DateTime.Parse(row["Message_Date"]); //Sætter Datoen på instansen til samme dato som fra databasen
                int.TryParse(row["Message_ID"], out number); //Parser teksten fra MessageId om til et tal og lægger det i number
                msg.Message_ID = number; //Putter tallet fra number over i MessageId på instansen

                // Sæt propertien Users til en bruger instans
                int.TryParse(row["Message_Author_ID"], out number);
                msg.Sender = new Users(number, row["Author_Name"]);


                int.TryParse(row["Recipient_ID"], out number);
                msg.recipient = new Users(number, row["Recipient"]);

                //Tilføj instansen til listen
                messages.Add(msg);
            }

            return messages;
        }
        public static List<Users> GetUsers()
        {
            List<Users> users = new List<Users>();
            Result result = SQLet.GetResult("SELECT Author_ID, Author_Name FROM Author");
            int number1 = 0;
            foreach (var row in result)
            {
                int.TryParse(row["Author_ID"], out number1);
                Users user = new Users(number1, row["Author_Name"]);

                users.Add(user);
            }

            return users;
        }
        public static Users GetUserByLogin(string username)
        {

            Result result;

            string sql = "";
            username = username.Replace("'", "\'");
            sql = string.Format("SELECT Author_ID, Author_Name FROM Author WHERE Author_Name = '{0}'", username);
            try
            {
                result = SQLet.GetResult(sql);
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                Logger.WriteToFile(e);
                return null;
            }

            if (result.Count == 0)
            {
                return null;
            }
            Users user = new Users(int.Parse(result[0]["Author_ID"]), result[0]["Author_Name"]);
            return user;
        }

        public static Users GetUser(int userID)
        {
            string sql = "";
            sql = string.Format("SELECT Author_ID, Author_Name FROM Author WHERE Author_ID = '{0}'", userID);
            Result result = SQLet.GetResult(sql);
            if (result.Count == 0)
            {
                return null;
            }
            Users user = new Users(int.Parse(result[0]["Author_ID"]), result[0]["Author_Name"]);
            return user;
        }
    }
}
