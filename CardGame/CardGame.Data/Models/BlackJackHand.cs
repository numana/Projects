using System.Linq;

namespace CardGame.Data.Models {

  public class BlackJackHandBase : HandBase {

    public override int Value {
      get {
        var value = Cards.Sum(c => c.Rank == Rank.Ace ? 11 : (c.Rank == Rank.Jack || c.Rank == Rank.Queen || c.Rank == Rank.King ? 10 : (int) c.Rank));
        var acesCount = Cards.Count(c => c.Rank == Rank.Ace);
        for (int i = 0; i < acesCount && value > 21; i++) {
          value -= 10; }
        return value;
      }
    }

  }

}