using System;
using System.Collections.Generic;
using System.Text;
using TECHCOOL;

namespace Discard__message_
{
    class MessagesMethods
    {
        public static void insertMessage(string message, int author)
        {
            string sql = @"
            INSERT INTO Messages (Message_text, Message_Author_ID, Message_Date)
            VALUES ('{0}', {1}, '{2}')";
            string formatted = string.Format(sql, message, author, DateTime.Now);
            //Console.WriteLine(formatted);
            SQLet.Execute(formatted);

        }

        public static void deleteMessage(string ID)
        {
            string sql = @"
            DELETE FROM Messages WHERE Message_ID = {0}";
            string formatted = string.Format(sql, ID);
            //Console.WriteLine(formatted);
            SQLet.Execute(formatted);
        }
        public static void updateMessage(string ID, string Message)
        {
            string sql = @"
            UPDATE Messages SET Message_Text = '{1}' WHERE Message_ID = {0} ";
            string formatted = string.Format(sql, ID, Message);
            //Console.WriteLine(formatted);
            SQLet.Execute(formatted);
        }
        public static void SelectMessage(string Message_Author_ID)
        {
            string sql = @"
            SELECT * FROM Messages
            WHERE Message_Author_ID = {0}
            ORDER BY Message_ID DESC";


            string formatted = string.Format(sql, Message_Author_ID);
            //Console.WriteLine(formatted);
            Result result = SQLet.GetResult(formatted);
            foreach (var record in result)
            {
                Console.WriteLine(record["Message_ID"] + "\t" + record["Message_Text"] + "\t" + record["Message_Author_ID"] + "\t" + record["Message_Date"]);
            }
        }

        public static void SelectAllMessage()
        {
            string sql = @"
            SELECT * FROM Messages
            ORDER BY Message_ID DESC";


            string formatted = string.Format(sql);
            //Console.WriteLine(formatted);
            Result result = SQLet.GetResult(formatted);
            foreach (var record in result)
            {
                Console.WriteLine(record["Message_ID"] + "\t" + record["Message_Text"] + "\t" + record["Message_Author_ID"] + "\t" + record["Message_Date"]);
            }
        }
    }
}
