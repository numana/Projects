//Base class to inherit from and use in different card game implementations.
//The value for each derived class Hand is not dependent of any external class, adding cohesion to the class.
//Also, any method inspecting polymorphically the Value property gets the correct implementation of the concrete class at runtime,
//making all derived classes substitutable (LISKOV SUBSTITUTION PRINCIPLE)

using System.Collections.Generic;
using CardGame.Data.Interfaces;

namespace CardGame.Data.Models { 
  
  public abstract class HandBase {
    public List<CardBase> Cards = new List<CardBase>();
    public abstract int Value { get; }
  }

}
