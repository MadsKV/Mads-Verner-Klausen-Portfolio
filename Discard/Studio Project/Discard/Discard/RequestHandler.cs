using System;
using System.Collections.Generic;
using System.Text;
using TECHCOOL;
namespace Discard__message_
{
    class RequestHandler
    {
        private string host = "";
        public RequestHandler(string host)
        {
            this.host = host;
        }
        public void Start()
        {
            WebLet httplistener = new WebLet(host);
            httplistener.Route("^/messages/$", requestMessages);
            httplistener.Route("^/users/$", requestUsers);
            httplistener.Route("^/stylesheet.css$", requestStylesheet);
            httplistener.Route("^[/]$", requestRoot);
            httplistener.Start();
        }
        //Brugeren request localhost:8080
        string requestRoot(Request r)
        {
            if (r.HttpMethod == "POST")
            {
                RequestData data = r.Data;
                string msg = data.Post["msg"];
                MessagesMethods.insertMessage(msg, 1);
            }

            List<Message> messages = Database.GetMessages();
            List<Users> users = Database.GetUsers();
            return HTML_Generator.GenerateIndex(messages, users);
        }
        string requestStylesheet(Request request)
        {
            return System.IO.File.ReadAllText("HTML/stylesheet.css");
        }
        string requestMessages(Request r)
        {
            List<Message> messages = Database.GetMessages();
            return HTML_Generator.GenerateMessage(messages);
        }
        string requestUsers(Request r)
        {
            List<Users> users = Database.GetUsers();
            return HTML_Generator.GenerateUser(users);
        }
    }
}
