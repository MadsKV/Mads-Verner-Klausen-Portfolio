using System;
using System.Collections.Generic;
using System.Text;

namespace Discard__message_
{
    class HTML_Generator
    {
        public static string generateIndex(List<Message> messages, List<Users> users)
        {
            
            string html = System.IO.File.ReadAllText("C:/Users/MadsV/OneDrive/Dokumenter/GitHub/Mads-Verner-Klausen-Portfolio/Discard/Studio Project/Discard (message)/Discard (message)/HTML/DiscordIndex.html");
            html = html.Replace("{{MessageWindow}}", HTML_Generator.generateMessage(messages));
            html = html.Replace("{{UserWindow}}", HTML_Generator.generateUser(users));
            return html;
        }
        public static string generateMessage(List<Message> messages)
        {
            string html = "";
            foreach (Message msg in messages)
            {
                string tpl = "<div class=\"firstMsg\"><strong style=\"color:black;\">{0}</strong><em style=\"color: black;\"><u>Username : {1}</u><br></em> {2}<br></div>";
                html += string.Format(tpl, msg.Message_Date, msg.Message_Author_ID, msg.Message_Text);
            }

            return html;
        }

        public static string generateUser(List<Users> users)
        {
            string html = "";
            foreach (Users user in users)
            {
                string tpl2 = "<button style=\"border-radius:25px;width:100%;text-align:left;\"class=\"btn btn-primary\"data-toggle=\"collapse\"href=\"#multiCollapseExample1\"role=\"button\"aria-expanded=\"false\"aria-controls=\"multiCollapseExample1\"> {0}</a><br>";
                html += string.Format(tpl2, user.Author_Name);

            }

            return html;
        }
    }
}
