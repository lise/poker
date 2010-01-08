using System;
using System.Text;
using Cuke4Nuke.Framework;

namespace Poker
{
    public class PokerSteps
    {
        [Pending]
        [Given(@"^at (.*) har (.*)$")]
        public void GittAtSpillerHarHånd(string spiller, string hånd)
        {
        }


        [Given(@"^at operator skriver inn Bordkort (.*)$")]
        public void GittAtOperatørSkriverInnBordKort(string kort)
        {
            //PokerGame game = new PokerGame();
            //game.addTableCards(kort);
        }

        [Then(@"^faar jeg tilbake Registrert kort (.*) paa bordet.$")]
        public void FårJegTilbake(string registrerteKort)
        {
            //game.getTableCards();
        }
    }
}
