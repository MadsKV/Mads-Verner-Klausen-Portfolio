using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CardForm;


namespace CardForm
{
    public class CardsToDB
    {
        //Stores the entire deck into the DB, with all of them beeing sorted into value, suit and color.
        public void InsertCards(string values, string suits, string colors, SqlConnection connection)
        {
            
             //DELETE FROM Deck WHERE ID in(SELECT MAX(ID) FROM Deck) 
             string sql = @"
             INSERT INTO Deck ([Values], Suits, Colors)
             VALUES ('{0}', '{1}', '{2}')";

             string formatted = string.Format(sql, values, suits, colors);
             SqlCommand command = new SqlCommand(formatted, connection);

                
             command.ExecuteNonQuery();
            
        }

        public void deleteHistory(SqlConnection connection)
        {
            string sql = @"
            Delete FROM Deck";

            string formatted = string.Format(sql);
            SqlCommand command = new SqlCommand(formatted, connection);


            command.ExecuteNonQuery();
        }
        public void Removecard(int i, SqlConnection connection)
        {
            string sql = @"
            DELETE FROM Deck WHERE ID = {0}";
            string formatted = string.Format(sql, i);

            SqlCommand command = new SqlCommand(formatted, connection);
            command.ExecuteNonQuery();
            //SqlDataReader sdr = command.ExecuteReader();
        }
        
        //Withdraws 7 cards at a time from the deck in the DB to the "players hand"
        public void getCards(SqlConnection connection)
        {
            List<int> list = new List<int>();

            string sql = @"
            SELECT   DISTINCT top 7 ID, [Values], Suits, Colors, newid()
            FROM     Deck
            ORDER BY newid()";

            //SELECT TOP 13 PERCENT * FROM [Deck] ORDER BY newid()";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-15}", sdr[0], sdr[1], sdr[2], sdr[3]);
                list.Add(sdr.GetInt32(0));
                //Removecard(sdr.GetInt32(0), connection);
            }
            sdr.Close();
            for (int i = 0; i < list.Count; i++)
            {
                Removecard(list[i], connection);
            }
        }
        //Withdraws 1 card at a time from the deck in the DB to the "players hand"
        public void getCard(SqlConnection connection)
        {
            List<int> list = new List<int>();

            string sql = @"
            SELECT   DISTINCT top 1 ID, [Values], Suits, Colors, newid()
            FROM     Deck
            ORDER BY newid()";

            //SELECT TOP 1 PERCENT * FROM [Deck] ORDER BY newid()";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-15}", sdr[0], sdr[1], sdr[2], sdr[3]);
                list.Add(sdr.GetInt32(0));
            }
            sdr.Close();
            for (int i = 0; i < list.Count; i++)
            {
                Removecard(list[i], connection);
            }
        }
        //Withdraws 7 cards at a time from the deck in the DB to the "players hand"
        public void getHalf(SqlConnection connection)
        {
            List<int> list = new List<int>();

            string sql = @"
            SELECT   DISTINCT top 26 ID, [Values], Suits, Colors, newid()
            FROM     Deck
            ORDER BY newid()";

            //SELECT TOP 50 PERCENT * FROM [Deck] ORDER BY newid()";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-15}", sdr[0], sdr[1], sdr[2], sdr[3]);
                list.Add(sdr.GetInt32(0));
            }
            sdr.Close();
            for (int i = 0; i < list.Count; i++)
            {
                Removecard(list[i], connection);
            }
        }
        //Withdraws 7 cards at a time from the deck in the DB to the "players hand"
        public void getWhole(SqlConnection connection)
        {
            List<int> list = new List<int>();

            string sql = @"
            SELECT * FROM [Deck] ORDER BY newid()";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-15}", sdr[0], sdr[1], sdr[2], sdr[3]);
                list.Add(sdr.GetInt32(0));
            }
            sdr.Close();
            for (int i = 0; i < list.Count; i++)
            {
                Removecard(list[i], connection);
            }
        }
    }
}
