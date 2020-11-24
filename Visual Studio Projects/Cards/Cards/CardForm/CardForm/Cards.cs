using System;
using System.Data.SqlClient;
using CardForm;

namespace CardForm
{
    public class Cards
    {
        public void InsertCards(string cards, string types, string colors, SqlConnection connection)
        {
            {
                string sql = @"
                INSERT INTO Deck (Cards, Types, Colors)
                VALUES ('{0}', '{1}', '{2}')";
                string formatted = string.Format(sql, cards, types, colors);
                SqlCommand command = new SqlCommand(formatted, connection);

                
                command.ExecuteNonQuery();
            }
        }
    }
}
