using System;

namespace Inventory.Test.Models
{
  public class Product
  {
    private decimal _price;
    public int Id { get; set; }

    public decimal Price
    {
      get { return _price; }
      set
      {
        if (value < 0)
          throw new InvalidOperationException("Price can not be less than 0");
        _price = value;
      }
    }

    public int Quantity { get; set; }
  }
}