using System;
using System.Text;
using Cuke4Nuke.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker
{
    public class PokerSteps
    {
        private string CurrentResult { get; set; }
        
        [Given(@"^at operator skriver inn '(.*)'$")]
        public void AtOperatorSkriverInnPokerSpill(string pokerGameInput)
        {
            PokerGame pokerGame = new PokerGame(pokerGameInput);
            CurrentResult = pokerGame.GetWinner();
        }

        [Then(@"^faar jeg tilbake '(.*)'$")]
        public void FaarJegTilbakeOleMed1Par(string expectedResult)
        {
            Assert.AreEqual(expectedResult, CurrentResult);
        }

        #region Example
        [Pending]
        [Given(@"^at (.*) har (.*)$")]
        public void GittAtSpillerHarHånd(string spiller, string hånd)
        {
        }
        #endregion
    }
}
