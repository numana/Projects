using System;
using System.Collections.Generic;
using System.Linq;
using System.Monads;

namespace Inventory.Test.Models
{
  class Inventory
  {
    public IList<Product> Products = new List<Product>();

    public void Add(Product product)
    {
      if (product == null)
        throw new ArgumentNullException();
      if (Product(product.Id) == null)
        Products.Add(product);
    }

    public void AddQuantity(int id, int quantity)
    {
      //With monads extensions
      Product(id).Do(p => p.Quantity += quantity);
    }

    public Product Product(int? id)
    {
      return Products.FirstOrDefault(s => s.Id == id);
    }

    internal decimal ProductValue(int id)
    {
      //With monads extensions
      return Product(id).With(p => p.Price*p.Quantity);
    }
  }
}
