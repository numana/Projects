using System.Collections.Generic;
using CardGame.Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardGame.Tests {

  [TestClass]
  public class BlackJackRulesTests {

    [TestMethod]
    public void StarBlackJackGame() {
      var players = new List<Player> {new Player()};
      var blackJack = new BlackJack(players);
      blackJack.Setup();
      for (var j = Suit.Clubs; j <= Suit.Spades; j++)
      {
        //blackJack.Cards.Add(new Card { Rank = Rank.Ace, Suit = j });
        for (var i = Rank.Ace; i <= Rank.King; i++)
          blackJack.Cards.Add(new Card {Rank = i, Suit = j});
        //blackJack.Cards.Add(new Card { Rank = Rank.Jack, Suit = j });
        //blackJack.Cards.Add(new Card { Rank = Rank.Queen, Suit = j });
        //blackJack.Cards.Add(new Card { Rank = Rank.King, Suit = j });
      }
    }

  }
}
