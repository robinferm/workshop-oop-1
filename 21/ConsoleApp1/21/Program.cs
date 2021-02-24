using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
			string input;
			while(true){
				Console.WriteLine("Welcome to 21!");
				//TODO: more stuff
				Console.Write(">");
				input = Console.ReadLine();
				
				if(input == "exit")
				{
					Console.WriteLine("Goodbye.");
					break;
				}
				else if(input == "play")
				{
					Game game = new Game(3);
					game.Play();
				}
			}
        }
    }
}
