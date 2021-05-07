using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BakeryTests //: IDisposable
  {
    // public void Dispose()
    // {
    // Item.ClearAll();
    // }
    [TestMethod]
    public void LoafConstructor_CreatesInstanceOfLoaf_Loaf()
    {
      Loaf newLoaf = new Loaf();
      Assert.AreEqual(typeof(Loaf), newLoaf.GetType());
    }
    
  }
}


