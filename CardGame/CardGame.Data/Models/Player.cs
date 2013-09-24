using CardGame.Data.Interfaces;

namespace CardGame.Data.Models {

  public class Player : IPlayer {
    public User User { get; set; }
    public Hand Hand { get; set; }
  }
}