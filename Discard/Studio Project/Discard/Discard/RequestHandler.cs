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
            Users user = null;
            if (r.HttpMethod == "POST")
            {
                RequestData data = r.Data;
                if (r.Data.Post.ContainsKey("Author_Name"))
                {
                    user = logUserIn(r.Data);
                    //Sæt ID på indlogget bruger på CurrenUserId
                    Users.CurrentUserId = user.Author_ID; 

                }
                else if (r.Data.Post.ContainsKey("msg"))
                {
                    int recipientID = 0;
                    int userID = 0;
                    int.TryParse(r.Data.Post["Author_ID"], out userID);
                    user = Database.GetUser(userID);

                    if (user != null)
                    {
                        string msg = data.Post["msg"];
                        if (r.Data.Post.ContainsKey("Recipient_ID"))
                        {
                        int.TryParse(r.Data.Post["Recipient_ID"], out recipientID);
                        }
                        MessagesMethods.insertMessage(msg.ToString(), userID, recipientID);
                        
                    }
                }
            }
            if (user != null)
            {
                List<Message> messages = Database.GetMessages();
                List<Users> users = Database.GetUsers();
                return HTML_Generator.GenerateIndex(messages, users, user.Author_ID);
            }
            return HTML_Generator.generateLogin();
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

        public Users logUserIn(RequestData data)
        {
            Users user = Database.GetUserByLogin(data.Post["Author_Name"]);
            if (user == null)
            {
                UserMethods.insertAuthor(data.Post["Author_Name"]);
                user = Database.GetUserByLogin(data.Post["Author_Name"]);
            }



            return user;

        }
    }
}
