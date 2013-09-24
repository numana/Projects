using System.Collections.Generic;
using CardGame.Data.Interfaces;

namespace CardGame.Data.Models {

  public class BlackJack : CardGameBase {

    public BlackJack(List<Player> players) : base(players) { }

    public void Setup() {
      ShuffleCards();
      DealCards();
    }

    public override void DealCards() {
      //TODO Implement
    }

  }

}