using System.Collections.Generic;
using System;

//// single loaf costs $5, two loaves costs $10, and three loaves cost $10
//// Bread: Buy 2, get 1 free

namespace PierresBakery.Models {
  public class Bread { 
    public int Quantity { get; set; }
    public Bread(int quantity) {
      Quantity = quantity;
    }
    public int GetPrice(int quantity) {
      int price = 0;
      for (int i = 1 ; i < quantity; i++) {
        if (!(i % 3 == 0)) {
        price = price + 5;          
        }
        else if (i % 3 == 0) {
          price = price + 0;
        }
      }
      return price;
    }
  }
}