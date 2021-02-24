using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Card
    {
        public enum CardSuit
        {
            clubs,
            diamonds,
            hearts,
            spades
        }
        public enum CardValue
        {
            ace,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine,
            ten,
            jack,
            queen,
            king
        }
		CardSuit suit;
		CardValue val;
		
		public Card(CardSuit suit, CardValue val)
		{
			this.suit = suit;
			this.val = val;
		}
    }
}
