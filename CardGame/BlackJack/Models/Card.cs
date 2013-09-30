using CardGame.Data.Interfaces;
using CardGame.Data.Models;

namespace BlackJackGame.Models {

  public class Card : ICard {
    public bool IsFaceUp = false;
    public Suit Suit { get; set; }
    public Rank Rank { get; set; }
  }

}