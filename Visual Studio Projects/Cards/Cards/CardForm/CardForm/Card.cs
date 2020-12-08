using CardForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CardForm
{

    public class Card
	{
		public Card(int _color, int _suit, int _value)
        {
			Value = _value;
			Suite = (Suites)_suit;
			Color = _color;
        }
        public override string ToString()
        {
            return Value.ToString() + " " + Suite.ToString() + " " + Color.ToString();
        }
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

		public int Color
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
	public List<Card> Cards2 = new List<Card>();
	//public void FillDeck()
	//{
	//	int val = 0;
	//	//Checks through 52 cards starting from 1 and increments by 1 everytime
	//	for (int i = 0; i < 52; i++)
	//	{
	//		Card.Suites suite = (Card.Suites)(Math.Floor((decimal)i / 13));
	//		val = i % 13 + 2;
	//		Cards.Add(new Card(val, suite));
	//	}
	//}
	public void FillDeck2()
	{
		//Card Color
		for (int i = 0; i < 2; i++)
		{
			//Card Suit
			for (int j = 0; j < 2; j++)
			{
				//Card Value
				for (int k = 0; k < 13; k++)
				{
					Card tempCard;
                    if (i == 1)
                    {
						int o = j + 2;
						Console.WriteLine("Color = " + i + " Suit = " + o + " Value = " + k);
						tempCard = new Card(i, o, k);
					}
                    else
                    {
						Console.WriteLine("Color = " + i + " Suit = " + j + " Value = " + k);
						tempCard = new Card(i, j, k);
					}
					Cards2.Add(tempCard);
				}
			}
		}
	}

	//Prints the deck when called in "Form1" to the textbox
	//public string PrintDeck()
	//{
	//	string s = "";
	//	//Makes sure to create a new line after every card #LookPretty.
	//	string newline = Environment.NewLine;
	//	Console.WriteLine(Cards.Count);
	//	foreach (Card card in this.Cards)
 //       {
 //           s += card.Name + newline;
 //       }
	//	//FillDeck2();
	//	return s;
	//}


	public string PrintDeck2()
	{
		string s = "";
		//Makes sure to create a new line after every card #LookPretty.
		string newline = Environment.NewLine;
		Console.WriteLine(Cards2.Count);
		foreach (Card card in this.Cards2)
		{
			//s += card.Color + card.Suite + card.Value + newline;
			s += card.ToString() + newline;
		}
		//FillDeck2();
		return s;
	}

	public void PrintToDB()
	{
		//Makes sure to create a new line after every card #LookPretty.
		string newline = Environment.NewLine;
		Console.WriteLine(Cards2.Count);
		foreach (Card card in this.Cards2)
		{
			string c = card.Color.ToString();
			string t = card.Suite.ToString();
			string o = card.Value.ToString();
			//s += card.ToString() + newline;
		}
	}
}
