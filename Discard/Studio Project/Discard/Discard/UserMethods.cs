using System;
using System.Collections.Generic;
using System.Text;
using TECHCOOL;

namespace Discard__message_
{
    class UserMethods
    {
        public static void insertAuthor(string name)
        {
            string sql = @"
            INSERT INTO Author (Author_Name)
            VALUES ('{0}')";
            string formatted = string.Format(sql, name);
            //Console.WriteLine(formatted);
            SQLet.Execute(formatted);

        }

        public static void deleteAuthor(string ID)
        {
            string sql = @"
            DELETE FROM Author WHERE Author_ID = {0}";
            string formatted = string.Format(sql, ID);
            //Console.WriteLine(formatted);
            SQLet.Execute(formatted);
        }
        public static void updateAuthor(string ID, string Author)
        {
            string sql = @"
            UPDATE Author SET Author_Name = '{1}' WHERE Author_ID = {0} ";
            string formatted = string.Format(sql, ID, Author);
            //Console.WriteLine(formatted);
            SQLet.Execute(formatted);
        }
        public static void SelectAuthor(string Author_ID)
        {
            string sql = @"
            SELECT * FROM Author
            WHERE Author_ID = {0}
            ORDER BY Author_Name DESC";


            string formatted = string.Format(sql, Author_ID);
            //Console.WriteLine(formatted);
            Result result = SQLet.GetResult(formatted);
            foreach (var record in result)
            {
                Console.WriteLine(record["Author_Name"]);
            }
        }

        public static void SelectAllAuthors()
        {
            string sql = @"
            SELECT * FROM Author
            ORDER BY Author_ID DESC";


            string formatted = string.Format(sql);
            //Console.WriteLine(formatted);
            Result result = SQLet.GetResult(formatted);
            foreach (var record in result)
            {
                Console.WriteLine(record["Author_Name"]);
            }
        }
    }
}
