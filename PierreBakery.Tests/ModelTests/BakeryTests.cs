using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
using System.Collections.Generic;

namespace PierreBakery.Tests
{
  [TestClass]
  public class ItemsTests //: IDisposable
  {
    // public void Dispose()
    // {
    // Item.ClearAll();
    // }
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
    public void GetOrderDescription_ReturnsDescription_String()
    {
      //Arrange
      String description = "UserInput";
      Item newItem = new Item(description);

      //Act
      string result = newItem.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
  }
}


