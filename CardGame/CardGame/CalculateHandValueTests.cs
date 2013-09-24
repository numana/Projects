using CardGame.Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CardGame.Tests {

  [TestClass]
  public class CalculateHandValueTests {

    public BlackJackHandBase BlackJackHandBase = new BlackJackHandBase();

    [TestInitialize]
    public void InitTests() {
      BlackJackHandBase.Cards = new List<Card> {
        new Card {Rank = Rank.Eight, Suit = Suit.Clubs},
        new Card {Rank = Rank.Four, Suit = Suit.Diamonds}
      };
    }

    [TestMethod]
    public void CalculateHandValueWithNoAces() {
      Assert.AreEqual(12, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new Card { Rank = Rank.Seven });
      Assert.AreEqual(19, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new Card { Rank = Rank.Four });
      Assert.AreEqual(23, BlackJackHandBase.Value);
    }

    [TestMethod]
    public void CalculateHandValueWithOneAce() {
      Assert.AreEqual(12, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new Card { Rank = Rank.Ace });
      Assert.AreEqual(13, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new Card { Rank = Rank.Eight });
      Assert.AreEqual(21, BlackJackHandBase.Value);
    }

    [TestMethod]
    public void CalculateHandValueWithTwoAces() {
      Assert.AreEqual(12, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new Card { Rank = Rank.Ace });
      Assert.AreEqual(13, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new Card { Rank = Rank.Ace });
      Assert.AreEqual(14, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new Card { Rank = Rank.Queen });
      Assert.AreEqual(24, BlackJackHandBase.Value);
    }

    [TestMethod]
    public void CalculateHandValueWithMoreThanThreeAces() {
      Assert.AreEqual(12, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new Card { Rank = Rank.Ace });
      Assert.AreEqual(13, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new Card { Rank = Rank.Ace });
      Assert.AreEqual(14, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new Card { Rank = Rank.Ace });
      Assert.AreEqual(15, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new Card { Rank = Rank.Eight });
      Assert.AreEqual(23, BlackJackHandBase.Value);
    }

  }
}