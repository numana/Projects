using CardGame.Data.Interfaces;
using CardGame.Data.Models;
using System.Collections.Generic;

namespace BlackJackGame.Models {

  public class BlackJack : CardGameBase {

    public BlackJack(List<IPlayer> players) : base(players) { }

    public override CardBase CardFactory(Rank rank, Suit suit) {
      return new Card {Rank = rank, Suit = suit, IsFaceUp = false};
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