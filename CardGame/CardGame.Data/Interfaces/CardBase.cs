using CardGame.Data.Models;

namespace CardGame.Data.Interfaces {
  public class CardBase {
    public Suit Suit { get; set; }
    public Rank Rank { get; set; }
  }
}