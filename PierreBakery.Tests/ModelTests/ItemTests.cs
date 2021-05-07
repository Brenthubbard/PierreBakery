using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
using System.Collections.Generic;

namespace PierreBakery.Tests
{
  [TestClass]
  public class ItemsTests: IDisposable
  {
    public void Dispose()
    {
    Item.ClearAll();
    }
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newbread = new bread("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
   


