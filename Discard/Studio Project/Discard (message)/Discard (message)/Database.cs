using System;
using System.Collections.Generic;
using System.Text;
using TECHCOOL;

namespace Discard__message_
{
    class Database
    {
        public static void SetupSQLServer()
        {
            try
            {

            SQLet.Execute(@"CREATE TABLE Users (
                Author_ID int primary key IDENTITY(1,1) NOT NULL,
                Author_Name nvarchar(32) NOT NULL
                )");

            SQLet.Execute(@"CREATE TABLE Messages (
                Message_ID int primary key IDENTITY(1,1) NOT NULL,
                Message_Date datetime NOT NULL DEFAULT GETDATE(),
                Message_Text text NOT NULL,
                Message_Author_ID int NOT NULL CONSTRAINT FK_user_message FOREIGN KEY (Message_Author_ID)
                    REFERENCES Users
                    ON DELETE Cascade
                    ON Update Cascade
                )");
            }
            catch(Microsoft.Data.SqlClient.SqlException)
            {

            }
        }
    }
}
