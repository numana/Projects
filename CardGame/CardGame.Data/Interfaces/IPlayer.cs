using CardGame.Data.Models;

namespace CardGame.Data.Interfaces {

  public interface IPlayer {
    User User { get; set; }
    Hand Hand { get; set; }
  }

}