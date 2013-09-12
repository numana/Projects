using System;
using Inventory.Test.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Inventory.Test
{
  [TestClass]
  public class InventoryTest
  {
    //Product Inventory Project
    //Create an application which manages an inventory of products.
    //Create a product class which has a price, id, and quantity on hand.
    //Then create an inventory class which keeps track of various products and can sum up the inventory value.

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void PriceLessThanZeroNotAllowed()
    {
      new Product { Id = 1, Price = -1, Quantity = 0 };
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void InventoryAddNullProductNotAllowed()
    {
      new Models.Inventory().Add(null);
    }

    [TestMethod]
    public void InventoryAddSubtractQuantityEqualsExpectedResults()
    {
      var inventory = new Models.Inventory();

      //Add 4 products to inventory
      for (int i = 0; i < 4; i++)
        inventory.Add(new Product { Id = i, Quantity = 5 });

      //Add to each product's quantity
      for (int i = 0; i < 4; i++)
        inventory.AddQuantity(i, i);

      //Compare added quantity with expected result
      for (int i = 0; i < 4; i++)
        Assert.AreEqual(5 + i, inventory.Product(i).Quantity);

      //Subtract to each product's quantity
      for (int i = 0; i < 4; i++)
        inventory.AddQuantity(i, -i);

      //Compare subtracted quantity with expected result
      for (int i = 0; i < 4; i++)
        Assert.AreEqual(5, inventory.Product(i).Quantity);
    }

    [TestMethod]
    public void InventoryCalculateInventoryValueEqualsExpectedResults()
    {
      var inventory = new Models.Inventory();

      //Add 4 products to inventory
      for (int i = 0; i < 4; i++)
        inventory.Add(new Product { Id = i, Quantity = 5, Price=10*i });

      //Compare each product's inventory value to expected result
      for (int i = 0; i < 4; i++)
      {
        Assert.AreEqual(5 * 10 * i, inventory.ProductValue(i));
      }
    }
  }
}
