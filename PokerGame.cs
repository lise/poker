using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{
    public class PokerGame
    {
        private string Input { get; set; }

        public PokerGame(string input)
        {
            Input = input;
        }

        public PokerGame()
        {
            Input = Console.ReadLine();
            FindWinner();
            Console.WriteLine(GetWinner());
        }

        public string GetWinner()
        {
            return FindWinner() + " vant";
        }

        private string FindWinner()
        {
            return Input.Split(':')[0];
        }
    }
}
