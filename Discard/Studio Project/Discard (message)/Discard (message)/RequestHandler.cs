using System;
using System.Collections.Generic;
using System.Text;
using TECHCOOL;
namespace Discard__message_
{
    class RequestHandler
    {
        public void Start()
        {
            WebLet httplistener = new WebLet("http://localhost:8080/");
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
            }

            List<Message> messages = Database.GetMessages();
            List<Users> users = Database.GetUsers();
            return HTML_Generator.GenerateIndex(messages, users);
        }
        string requestStylesheet(Request request)
        {
            return System.IO.File.ReadAllText("HTML/stylesheet.css");
        }
    }
}
