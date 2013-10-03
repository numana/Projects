using System;
using System.Collections.Generic;
using BlackJackGame.Models;
using CardGame.Data.Interfaces;
using CardGame.Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJackGame.Tests {

  [TestClass]
  public class WhenStartingBlackJack {

    public BlackJack BlackJack { get; set; }

    [TestInitialize]
    public void MyMethod() {
      var players = new List<IPlayer>();

      for (int i = 0; i < 5; i++) players.Add(new Player { User = new User { UserName = String.Format("Player {0}", i) } });
      BlackJack = new BlackJack(players);
      BlackJack.SetUpCards();
    }

    [TestMethod]
    public void DeckOfCardsGets52Cards() {
      Assert.AreEqual(52, BlackJack.Cards.Count);
    }

    [TestMethod]
    public void UsersGet2Cards() {
      BlackJack.DealCards();
      BlackJack.Players.ForEach(p => Assert.AreEqual(2, p.Hand.Cards.Count));
    }

    [TestMethod]
    public void FirstCardIsNotFaceUpAndSecondCardIsFaceUp() {
      BlackJack.DealCards();
      BlackJack.Players.ForEach(p => Assert.IsTrue(!((Card)p.Hand.Cards[0]).IsFaceUp && ((Card)p.Hand.Cards[1]).IsFaceUp));
    }
  }
}