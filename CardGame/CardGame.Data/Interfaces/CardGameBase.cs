using CardGame.Data.Models;
using System.Collections.Generic;

namespace CardGame.Data.Interfaces {

  public abstract class CardGameBase {

    public List<Player> Players { get; set; }
    public List<Card> Cards { get; set; }

    protected CardGameBase(List<Player> players) {
      Players = players;
    }

    public virtual void DealCards() { }

    public virtual void ShuffleCards() {
    }

  }

}