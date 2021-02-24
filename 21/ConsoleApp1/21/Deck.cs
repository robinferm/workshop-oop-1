using System;
using System.Collections.Generic;
using System.Linq;

namespace _21
{
	class Deck
	{
		List<Card> cards;
		private Random prng;
		
		public Deck()
		{
			this.cards = new List<Card>();
			prng = new Random();
			foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
			{
				foreach (CardValue val in Enum.GetValues(typeof(CardValue)))
				{
					cards.Add(new Card(suit, val));
				}
			}
		}
		public Card Draw(){
			Card rndCard = cards[prng.Next(cards.Count)];
			cards.Remove(rndCard);
			return rndCard;
		}
	}
}