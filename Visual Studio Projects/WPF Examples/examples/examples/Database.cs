using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Documents;

namespace examples
{
    public class Database
    {
        static SqlConnection connection;
        public static bool Connect(string username, string password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-CHHJASV\MSQLSERVERDEV";
            builder.UserID = username;
            builder.Password = password;
            //builder.IntegratedSecurity = true;
            builder.InitialCatalog = "School101";

            connection = new SqlConnection(builder.ToString());
            try
            {
                connection.Open();
                return true;
            }
            catch(Exception ex)
            {

            }

            return false;
        }

        public static void InsertNewStudent(Student studentBuffer)
        {
            using SqlCommand command = new SqlCommand(@"
            INSERT INTO Student (StudentFirstName, StudentLastName, StudentAge, ClassID)
            VALUES (@StudentFirstName, @StudentLastName, @StudentAge, @ClassID)", connection);
            {
                command.Parameters.AddWithValue("@StudentFirstName", studentBuffer.StudentFirstName);
                command.Parameters.AddWithValue("@StudentLastName", studentBuffer.StudentLastName);
                command.Parameters.AddWithValue("@StudentAge", studentBuffer.StudentAge);
                command.Parameters.AddWithValue("@ClassID", studentBuffer.ClassID);
                try
                {
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch(Exception e)
                {
                    
                }
            }
        }
        public static Dictionary<int, string> Fill_ClassID()
        {
            string sql = (@"SELECT ID, Name FROM Class");

            SqlCommand command = new SqlCommand(sql, connection);
            using SqlDataReader reader = command.ExecuteReader();
            Dictionary<int, string> ClassName = new Dictionary<int, string>();
            while (reader.Read())
            {
                ClassName.Add(reader.GetInt32(0),reader.GetString(1));
            }
            reader.Close();
            return ClassName;
        }
    }
}
