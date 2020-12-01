using System;
using System.Data.SqlClient;
using CardForm;


namespace CardForm
{
    public class CardsToDB
    {
        //Stores the entire deck into the DB, with all of them beeing sorted into value, suit and color.
        public void InsertCards(string cards, string types, string colors, SqlConnection connection)
        {
            
             string sql = @"
             DELETE FROM Deck
             INSERT INTO Deck (Cards, [Types], Colors)
             VALUES ('{0}', '{1}', '{2}')";

             string formatted = string.Format(sql, cards, types, colors);
             SqlCommand command = new SqlCommand(formatted, connection);

                
             command.ExecuteNonQuery();
            
        }
        //Withdraws one card at a time from the deck in the DB to the "players hand"
        public void getCards(string cards, string types, string colors, SqlConnection connection)
        {
            string sql = @""; 
        }
    }
}
