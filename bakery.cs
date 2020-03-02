using System;
using System.Collections.Generic;
using Bakeryshop.Pastries;
using Bakeryshop.Breads;

namespace Bakeryshop
{
  public class Bakery {
      public static List<Bread> Breads = new List<Bread>() {};
      public static List<Pastry> Pastries = new List<Pastry>() {};

      static void Main()
      {
          Bread bagel = new Bread("Bagel", 5, 100);
          Breads.Add(bagel);

          Pastry maccaron = new Pastry("Maccaron", 2, 100);
          Pastries.Add(maccaron);

          Console.WriteLine("Welcome to Pierre's Bakery!");
          Console.WriteLine("Would you like to get some fresh bakeries? Please answer with this format, Y for Yes & N for N");

          string userVisitAnswer = Console.ReadLine().ToLower();

          if (userVisitAnswer == "y")
          {
              BreadBrowsing();
              PastryBrowsing();
              BreadShopping();
              PastryShopping();
          }
          else
          {
              Console.WriteLine("Thank you for visiting Pierre's Bakery. We are looking forward to seeing you next time!");
          }
      }

      static void BreadBrowsing()
      {
          Console.Write("We have " + Breads[0].GetBreadName() + " in the bread section." + " The price is $" + Breads[0].GetPrice() + ".");
      }

      static void PastryBrowsing()
      {
          Console.WriteLine(" For the pastry section, We also have " + Pastries[0].GetPastryName() + " with the price for each $" + Pastries[0].GetPrice() + ".");
      }

      static int BreadPrice()
      {
          Console.Write("Would you like to buy some breads? Enter a number that you want to get.");
          Console.WriteLine(" If you buy 2 breads, you can get 1 for free.");
          int.TryParse(Console.ReadLine(), out int userBreadNumber);
          return userBreadNumber;
      }
      static void BreadShopping()
      {
          int userBreadNumber = BreadPrice();

          if(Breads[0].outOfStock(userBreadNumber))
          {
              int stocks = Math.Abs(userBreadNumber - Breads[0].GetLoaves());
              Console.WriteLine("Sorry, some breads are out of stock for youe order. " + stocks + " bread/s are not available.");
              Console.WriteLine("Available " + Breads[0].GetLoaves() + "'s cost is " + Breads[0].Buying(Breads[0].GetLoaves()));
          }
          else
          {
          Console.WriteLine("The cost is " + Breads[0].Buying(userBreadNumber) + ".");
          }
      }

      static int PastryPrice()
      {
          Console.Write("Would you like to buy some pastries? Enter a number that you want to get.");
          Console.WriteLine(" If you buy 3 pastries, it is 5 dollars in total!");
          int.TryParse(Console.ReadLine(), out int userPastryNumber);
          return userPastryNumber;
      }
      static void PastryShopping()
      {
          int userPastryNumber = PastryPrice();

          if(Pastries[0].outofStock(userPastryNumber))
          {
              int stocks = Math.Abs(userPastryNumber - Pastries[0].GetLoaves());
              Console.WriteLine("Sorry, some pastries are out of stock for your order. " + stocks + " pastry/ies are not available.");
              Console.WriteLine("Available " + Pastries[0].GetLoaves() + "'s cost is " + Pastries[0].Buying(Pastries[0].GetLoaves()));
          }
          else
          {
          Console.WriteLine("The cost is " + Pastries[0].Buying(userPastryNumber) + ".");
          }
      }
    }
  }
