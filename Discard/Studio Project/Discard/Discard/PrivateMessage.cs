using System;
using System.Collections.Generic;
using System.Text;

namespace Discard__message_
{
    class PrivateMessage : Message
    {
        public  int RecipientID { get; set; }
        public PrivateMessage(string Author_Text, int Author_ID, int recipient) : base(Author_Text, Author_ID)
        {
            RecipientID = recipient;
        }
    }
}
