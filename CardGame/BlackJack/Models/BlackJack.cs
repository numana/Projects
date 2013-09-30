using CardGame.Data.Interfaces;
using CardGame.Data.Models;
using System.Collections.Generic;

namespace BlackJackGame.Models {

  public class BlackJack : CardGameBase {

    public BlackJack(List<IPlayer> players) : base(players) { }

    public override void SetUpCards() {
      //TODO Use Cards initialization in CardGameBase. How to instantiate new Card into cards?
      for (var j = Suit.Clubs; j <= Suit.Spades; j++)
        for (var i = Rank.Ace; i <= Rank.King; i++)
          Cards.Push(new Card { Rank = i, Suit = j, IsFaceUp = false });
    }

    public override void DealCards() {
      Players.ForEach(p => {
        p.Hand.Cards.Add(Cards.Pop());
        ((Card) Cards.Peek()).IsFaceUp = true;
        p.Hand.Cards.Add(Cards.Pop());
      });
    }

  }

}