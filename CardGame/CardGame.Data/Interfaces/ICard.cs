using CardGame.Data.Models;

namespace CardGame.Data.Interfaces {

  public interface ICard {
    Suit Suit { get; set; }
    Rank Rank { get; set; }
  }

}