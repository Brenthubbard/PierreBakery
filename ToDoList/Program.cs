using System;
using ToDoList.Models;
using System.Collections.Generic;


namespace WorkSpace
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To DO List");
      Console.WriteLine("Would you like to add items to your list or view your list?(Add/View");
      string userInput = Console.ReadLine();
      //add userInput here
      string userInputLower = userInput.ToLower();
      bool addInput = (userInputLower =="add");
      bool viewInput = (userInputLower == "view");
      if (addInput)
      {
        //Console.WriteLine(UserInputLower)
        Console.WriteLine("Please add your item to the To Do List");
        string addToList = Console.ReadLine();
        Item newItem = new Item(addToList);
        List<Item> theList = Item.GetAll(); // item within theList should have a type of ____
        foreach (Item item in theList)
        {
          Console.WriteLine(item.Description);
        }
        Main();
      }
      else if (viewInput)
      { 
        // Console.WriteLine(List<Item>)
        // Continue working on the functionality below to match the functionality we have above in our foreach loop to print out our List<Item> items.
      Console.WriteLine("Here is your to do list");
        List<Item> list = Item.GetAll();
        foreach (Item item in list)
        {
          Console.WriteLine(item.Description);
        }
      }
      else
      {
        Console.WriteLine("Please enter the exact words add or view with no spaces");
      }
    } // add an else {} here to deal with any input from the user that isn't "add" or "view", say something like "please input either add or view, then restart Main();
      // Main();
      
  }
}

