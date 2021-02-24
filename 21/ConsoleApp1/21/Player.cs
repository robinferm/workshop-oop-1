using System.Collections.Generic;

namespace _21
{
	class Player
	{
		string userName;
		List<Card> hand;
		uint points;
		
		public Player(string userName, uint points = 50)
		{
			this.userName = userName;
			this.points = points;
		}
		
		public void AddCard(Card card)
		{
			hand.Add(card);
		}
	}
}