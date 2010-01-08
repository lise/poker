using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class PokerGame
    {
        private string Input;
        private string Winner;

        public PokerGame(string input)
        {
            Input = input;
            FindWinner();
        }

        public PokerGame()
        {
            Input = Console.ReadLine();
            FindWinner();
            Console.WriteLine(Winner);
        }

        public void FindWinner()
        {
            Winner = Input.Split(':')[0];
        }

        public string GetWinner()
        {
            return Winner;
        }
    }
}
