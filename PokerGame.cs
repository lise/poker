using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class PokerGame
    {
        private string Input { get; set; }
        private string Winner {get; set; }

        public PokerGame(string input)
        {
            Input = input;
        }

        public PokerGame()
        {
            Input = Console.ReadLine();
            FindWinner();
            Console.WriteLine(Winner);
        }

        public string GetWinner()
        {
            return "Ole med 1 par";
        }

        private void FindWinner()
        {
            Winner = Input.Split(':')[0];
        }
    }
}
