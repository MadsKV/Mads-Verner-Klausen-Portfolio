using System;
using System.Data.SqlClient;
using CardForm;

namespace CardForm
{
    public class Cards
    {
        public string InsertCards(string cards, string type, string colors, SqlConnection connection)
        {
            {
                string sql = @"
                INSERT INTO Deck (Cards, Types, Colors)
                VALUES ('{0}', '{1}', '{2}'";
                string formatted = string.Format(sql, cards, type, colors);
                SqlCommand command = new SqlCommand(formatted, connection);

                int numberOfRowAffected = command.ExecuteNonQuery();
                return numberOfRowAffected + "Rows was affected.\n";
            }
        }
    }
}
