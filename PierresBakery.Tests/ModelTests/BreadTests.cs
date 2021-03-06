using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models; 

namespace PierresBakery.Tests {
  [TestClass]
  public class BreadTests {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread() { 
      // arrange
      Bread bread = new Bread(4);
      // assert
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }
    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int() { 
      // arrange
      int quantity = 4;
      Bread bread = new Bread(quantity);
      // act
      int order = bread.Quantity;
      // assert
      Assert.AreEqual(4, order);
    }
    [TestMethod]
    public void GetPrice_ReturnsPrice_Int() { 
      // arrange
      int quantity = 4;
      Bread bread = new Bread(quantity);
      // act
      int order = bread.Quantity;
      // assert
      Assert.AreEqual(15, bread.GetPrice(quantity));
    }
  }
}