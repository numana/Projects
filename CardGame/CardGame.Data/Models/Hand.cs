using System.Collections.Generic;

namespace CardGame.Data.Models { 
  
  public abstract class Hand {
    public List<Card> Cards { get; set; }
    public abstract int Value { get; }
  }

}
