using System;

namespace PierreBakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("How many loaves of bread would you like? :");
      int custBread = int.Parse(Console.ReadLine());
      Loaf loafOrder = new Loaf(custBread);
      Console.WriteLine($"{loafOrder.LoafOrderPrice()}");
      Console.WriteLine("How many Pastries would you like? :");
      int custPastry = int.Parse(Console.ReadLine());
      Pastry pastryOrder = new Pastry(custPastry);
      Console.WriteLine($"{pastryOrder.PastryOrderPrice()}");
      Console.WriteLine($"Your total purchase today at Pierre's Bakery is ${pastryOrder.PastryOrderPrice() + loafOrder.LoafOrderPrice()} dollars");
    }
  }
}

