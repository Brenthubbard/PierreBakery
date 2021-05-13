using System;

namespace PierreBakery.Models
{
  public class Loaf
  {
      public int LoafOrder { get; set; }
    
      public Loaf(int loafOrder)
      {
        LoafOrder = loafOrder;
      }
    public int LoafOrderPrice()
    {
      if (LoafOrder % 3 == 0)
      {
        int TotalPrice = (LoafOrder - (LoafOrder /3 )) * 5;
        return TotalPrice;
      }
      else
      {
        return LoafOrder * 5;
      }

    }


  }
}



