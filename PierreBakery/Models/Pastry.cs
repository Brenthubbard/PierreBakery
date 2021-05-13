// using System;

namespace PierreBakery.Models
{
  public class Pastry
  {
      public int PastryOrder { get; set; }

    public Pastry(int pastryOrder)
    {
      PastryOrder = pastryOrder;
    }
    public int PastryOrderPrice()
    {
      if (PastryOrder == 1)
      {
        int TotalPrice = (PastryOrder) * 2;
        return TotalPrice;
      }
      else
      {
        return PastryOrder * 2;
      }

    }

  }
}