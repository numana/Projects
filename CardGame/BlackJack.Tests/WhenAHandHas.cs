using System.Collections.Generic;
using BlackJackGame.Models;
using CardGame.Data.Interfaces;
using CardGame.Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJackGame.Tests {

  [TestClass]
  public class WhenAHandHas {

    public Hand BlackJackHandBase = new Hand();

    [TestInitialize]
    public void InitTests() {
      BlackJackHandBase.Cards = new List<CardBase> {
        new CardBase {Rank = Rank.Eight, Suit = Suit.Clubs},
        new CardBase {Rank = Rank.Four, Suit = Suit.Diamonds}
      };
    }

    [TestMethod]
    public void NoAcesValueIsCorrect() {
      Assert.AreEqual(12, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new CardBase { Rank = Rank.Seven });
      Assert.AreEqual(19, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new CardBase { Rank = Rank.Four });
      Assert.AreEqual(23, BlackJackHandBase.Value);
    }

    [TestMethod]
    public void OneAceValueIsCorrect() {
      Assert.AreEqual(12, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new CardBase { Rank = Rank.Ace });
      Assert.AreEqual(13, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new CardBase { Rank = Rank.Eight });
      Assert.AreEqual(21, BlackJackHandBase.Value);
    }

    [TestMethod]
    public void TwoAcesValueIsCorrect() {
      Assert.AreEqual(12, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new CardBase { Rank = Rank.Ace });
      Assert.AreEqual(13, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new CardBase { Rank = Rank.Ace });
      Assert.AreEqual(14, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new CardBase { Rank = Rank.Queen });
      Assert.AreEqual(24, BlackJackHandBase.Value);
    }

    [TestMethod]
    public void ThreeAcesValueIsCorrect() {
      Assert.AreEqual(12, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new CardBase { Rank = Rank.Ace });
      Assert.AreEqual(13, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new CardBase { Rank = Rank.Ace });
      Assert.AreEqual(14, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new CardBase { Rank = Rank.Ace });
      Assert.AreEqual(15, BlackJackHandBase.Value);
      BlackJackHandBase.Cards.Add(new CardBase { Rank = Rank.Eight });
      Assert.AreEqual(23, BlackJackHandBase.Value);
    }

  }
}