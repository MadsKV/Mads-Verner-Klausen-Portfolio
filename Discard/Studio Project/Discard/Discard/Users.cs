using System;
using System.Collections.Generic;
using System.Text;

namespace Discard__message_
{
    class Users
    {
        public int Author_ID { get; set; }
        public string Author_Name { get; set; }
        public static int CurrentUserId { get; set; }


        /*public Users(int author_ID, string author_Name)
        {
            Author_ID = author_ID;
            Author_Name = author_Name;
        }*/
        public Users(int author_ID, string author_Name)
        {
            Author_Name = author_Name;
            Author_ID = author_ID;
        }
    }
}
