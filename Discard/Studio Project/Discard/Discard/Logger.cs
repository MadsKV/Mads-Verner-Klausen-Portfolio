using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Discard__message_
{
    class Logger
    {
        public static void WriteToFile(Exception e)
        {

            string toBeLogged = string.Format("{0}, {1}, {2}\n", DateTime.Now, "Error", e.Message);
            File.AppendAllText("Events.txt", toBeLogged);

        }
        public static void WriteToFile(string message)
        {

            string toBeLogged = string.Format("{0}, {1}, {2}\n", DateTime.Now, "Info", message);
            File.AppendAllText("Events.txt", toBeLogged);

        }
    }
}
