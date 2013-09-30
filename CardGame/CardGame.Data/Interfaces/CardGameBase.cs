//Base class to derive card games from. Implements basic functionality common to all card games.
//Derived classes inherit base behaviour and implement additional functionality (SINGLE RESPONSABILITY PRINCIPLE),
//keeping this base class from adding functionality for every game card (OPEN CLOSE PRINCIPLE)

using System.Collections.Generic;
using CardGame.Data.Models;

namespace CardGame.Data.Interfaces {

  public abstract class CardGameBase {

    public List<IPlayer> Players { get; set; }
    public Stack<ICard> Cards = new Stack<ICard>();

    //private class Card : ICard {
    //  public Suit Suit { get; set; }
    //  public Rank Rank { get; set; }
    //}

    protected CardGameBase(List<IPlayer> players) {
      Players = players;
      SetUpCards();
    }

    public virtual void SetUpCards() {
      //for (var j = Suit.Clubs; j <= Suit.Spades; j++)
      //  for (var i = Rank.Ace; i <= Rank.King; i++)
      //    Cards.Push(new Card { Rank = i, Suit = j });
    }

    public virtual void Setup() {
      ShuffleCards();
      DealCards();
    }

    public virtual void DealCards() {
      //TODO Implement in derived classes
    }

    public virtual void ShuffleCards() {
      //TODO Implement default behaviour here, but may be overriden in derived classes
    }

  }

}