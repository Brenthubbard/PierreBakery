using System;
// using PierreBakery.Models;
// using System.Collections.Generic;


namespace PierreBakery.Models
{
  public class Program
  {
public static void Main()
    {
      
            // Pastry pastryOrder = new Pastry(custPastry);

      Console.WriteLine("How many loaves of bread would you like? :");
      int custBread = int.Parse(Console.ReadLine());
          Loaf loafOrder = new Loaf(custBread);
      

        Console.WriteLine($"{loafOrder.LoafOrderPrice()}");
     
      Console.WriteLine("How many Pastries would you like? :");
      int custPastry = int.Parse(Console.ReadLine());
       Pastry pastryOrder = new Pastry(custPastry);
      

        Console.WriteLine($"{pastryOrder.PastryOrderPrice()}");

Console.WriteLine($"Your total purchase today at Pierre's Bakery is ${pastryOrder.PastryOrderPrice()+ loafOrder.LoafOrderPrice()} dollars");




      // Console.WriteLine("Welcome to Pierre's PierreBakery");

      // Console.WriteLine("We have a few specials today.");

      // Console.WriteLine(" We have * Bread 'Buy 2, get 1 free with a single loaf for $5");
      // int userInputBread = Console.ReadLine();
      // Console.WriteLine("We have * Pastry's Buy 1 for $2 or 3 for $5'");
      // int userInputPastry = Console.ReadLine();
      // Console.WriteLine("Please input how many loafs of Bread you would like!");
      // Add userInput here
      // string userInputLower = userInput.ToLower
    }
  }
}

