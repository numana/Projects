using CardGame.Data.Models;

namespace CardGame.Data.Interfaces {

  public interface IPlayer {
    User User { get; set; }
    HandBase Hand { get; set; }
  }

}