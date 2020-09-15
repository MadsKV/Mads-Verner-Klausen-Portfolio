using System;
using System.Collections.Generic;
using System.Text;

namespace Discard__message_
{
    class Message
    {
        public int Message_ID { get; set; }
        public int Message_Author_ID { get; set; }
        public string Message_Text { get; set; }
        public DateTime Message_Date { get; set; }


        public Message(string message_Text, int message_Author_ID)
        {
            Message_Author_ID = message_Author_ID;
            Message_Text = message_Text;
            Message_Date = DateTime.Now;
        }
    }
}
