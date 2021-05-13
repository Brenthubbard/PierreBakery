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
      if (PastryOrder % 3 == 0)
      {
        int TotalPrice = (PastryOrder /3) * 5;
        return TotalPrice;
      }
      else
      {
        return PastryOrder * 2;
      }

    }

  }
}