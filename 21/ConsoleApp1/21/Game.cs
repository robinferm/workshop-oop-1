using System;
using System.Collections.Generic;

namespace _21
{
	class Game
	{
		List<Player> players;
		Deck deck;
		//Dealer dealer;
		
		public Game(int numberOfPlayers)
		{
			this.deck = new Deck();
			this.players = new List<Player>();
            //dealer = new Dealer();
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine($"Input username for player {i+1}: ");
				string userName = Console.ReadLine();
				players.Add(new Player(userName));
            }
		}

		public void Play()
        {
			// TODO game logic
        }
	}
}