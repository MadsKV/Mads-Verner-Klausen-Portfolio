using CardForm;
using System;
using System.Collections.Generic;

namespace CardForm
{

    public class Card
	{
		//stores the 4 different suits starting from Heart ends with Spades.
		public enum Suites
		{
			Hearts = 0,
			Diamonds,
			Clubs,
			Spades
		}

		public int Value
		{
			get;
			set;
		}

		public Suites Suite
		{
			get;
			set;
		}

		public string NamedValue
		{
			get
			{
				//Makes sure that every 11-14 card in each suit is turned into a picture card.
				string name = string.Empty;
				switch (Value)
				{
					case (14):
						name = "Ace";
						break;
					case (13):
						name = "King";
						break;
					case (12):
						name = "Queen";
						break;
					case (11):
						name = "Jack";
						break;
					default:
						name = Value.ToString();
						break;
				}

				return name;
			}
		}

		//Prints fx "4 of hearts" into the textbox when called in 'PrintDeck'.
		public string Name
		{
			get
			{
				return NamedValue + " of  " + Suite.ToString();
			}
		}

		public Card(int Value, Suites Suite)
		{
			this.Value = Value;
			this.Suite = Suite;
		}
	}
}
public class Deck
{
	//Fills the deck starting from Hearts to Spades (See Enum "Suites").
	public List<Card> Cards = new List<Card>();
	public void FillDeck()
	{
		int val = 0;
		//Checks through 52 cards starting from 1 and increments by 1 everytime
		for (int i = 0; i < 52; i++)
		{
			Card.Suites suite = (Card.Suites)(Math.Floor((decimal)i / 13));
			val = i % 13 + 2;
			Cards.Add(new Card(val, suite));
		}
	}

	//Prints the deck when called in "Form1" to the textbox
	public string PrintDeck()
	{
		string s = "";
		//Makes sure to create a new line after every card #LookPretty.
		string newline = Environment.NewLine;
		Console.WriteLine(Cards.Count);
		foreach (Card card in this.Cards)
        {
            s += card.Name + newline;
			Console.WriteLine(s);
        }
	
		return s;
	}

	
	//....RIP
	public void PrintToDB()
    {
        foreach (Card card in this.Cards)
        {

            foreach (var item in collection)
            {
                foreach (var item in collection)
                {
                    foreach (var item in collection)
                    {

                    }
                }
            }
        }
    }
	
}
