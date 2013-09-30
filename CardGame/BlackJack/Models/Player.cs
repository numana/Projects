using CardGame.Data.Interfaces;
using CardGame.Data.Models;

namespace BlackJackGame.Models {

  public class Player : IPlayer {
    public User User { get; set; }
    public HandBase Hand { get; set; }

    public Player() {
      Hand=new Hand();
    }
  }

}
