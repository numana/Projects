//Base class to derive card games from. Implements basic functionality common to all card games.
//Derived classes inherit base behaviour and implement additional functionality (SINGLE RESPONSABILITY PRINCIPLE),
//keeping this base class from adding functionality for every game card (OPEN CLOSE PRINCIPLE)

using System.Collections.Generic;

namespace CardGame.Data.Models {

  public abstract class CardGameBase {

    public List<Player> Players { get; set; }
    public List<Card> Cards = new List<Card>();

    protected CardGameBase(List<Player> players) {
      Players = players;
      for (var j = Suit.Clubs; j <= Suit.Spades; j++)
        for (var i = Rank.Ace; i <= Rank.King; i++)
          Cards.Add(new Card { Rank = i, Suit = j });
    }

    public virtual void DealCards() {
      //TODO Implement in derived classes
    }

    public virtual void ShuffleCards() {
      //TODO Implement default behaviour here, but may be overriden in derived classes
    }

  }

}