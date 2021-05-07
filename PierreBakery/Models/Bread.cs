using System;

namespace PierreBakery.Models
{
  public class Bread
  {
    public int BreadOrder { get; set; }
   
     public Bread(int breadOrder)
    {
      BreadOrder = breadOrder;
    }
   


  }
}



     // - must be declared static because it returns a static variable (_instances)
    // - variables & methods *dealing with entire classes* must be static
    // - whenever we use static data, we *need to create a Dispose() method* to clean up between tests
    // https://www.learnhowtoprogram.com/c-and-net/test-driven-development-with-c/adding-a-disposable-method-to-tests
  // properties, methods, etc. will go here.