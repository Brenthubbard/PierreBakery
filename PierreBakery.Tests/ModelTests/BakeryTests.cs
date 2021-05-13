using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BakeryTests 
  {
    
    [TestMethod]
    public void LoafConstructor_CreatesInstanceOfLoaf_Loaf()
    {
      Loaf newLoaf = new Loaf(5);
      Assert.AreEqual(typeof(Loaf), newLoaf.GetType());
    }
    [TestMethod]
    public void LoafOrderPrice_ReturnsPriceFor1Loaf_int()
    {
      int loafOrder = 1;
      Loaf newLoafOrder = new Loaf(loafOrder);
      int result = newLoafOrder.LoafOrderPrice();
      Assert.AreEqual(5,result);
    }
    [TestMethod]
    public void LoafOrderPrice_ReturnsPriceFor3Loaf_int()
    {
      int loafOrder = 3;
      Loaf newLoafOrder = new Loaf(loafOrder);
      int result = newLoafOrder.LoafOrderPrice();
      Assert.AreEqual(10, result);
    }
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
   
  }
}


