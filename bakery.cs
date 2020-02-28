using System;
using System.Collections.Generic;

public class Bakery {
    public static List<Bread> Breads = new List<Bread>() {};
    public static List<Pastry> Pastries = new List<Pastry> () {};

    static void Main()
    {
        Bread bagel = new Bread();
        bagel.Name ="Bagel";
        bagel.Price = 5;
        bagel.Loaves = 10;
        Breads.Add(bagel);

        Pastry maccaron = new Pastry();
        maccaron.Name = "Maccaron";
        maccaron.Price = 2;
        maccaron.Loaves = 10;
        Pastries.Add(maccaron);

        Console.WriteLine("Welcome to Pierre's Bakery");
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
        // foreach(Bread bread in Breads)
        //     {
        Console.Write("We have " + Breads[0].Name + " in the bread section." + " The price is $" + Breads[0].Price + ".");
            // }
    }

    static void PastryBrowsing()
    {
        Console.WriteLine(" For the pastry section, We also have " + Pastries[0].Name + " with the price for each $" + Pastries[0].Price + ".");
    }

    static void BreadShopping()
    {
        Console.Write("Would you like to buy some breads? Enter a number that you want to get.");
        int userBreadNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("The cost is " + Breads[0].Buying(userBreadNumber) + ".");
    }

    static void PastryShopping()
    {
        Console.Write("Would you like to buy some pastries? Enter a number that you want to get.");
        int userPastryNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("The cost is " + Pastries[0].Buying(userPastryNumber) + ".");
    }
}
public class Bread 
{

   public string Name;
   public int Price;
   public int Loaves;

   public int Buying (int loaves) 
   {
       if (loaves >= 2)
       {
           return (loaves / 2) * Price + (loaves % 2) * Price;
       }
       else
       {
       return Price * loaves;
       }
   }

   public bool outOfStock (int loaves)
   {
       return (loaves > Loaves);
   }
}

public class Pastry {

   public string Name;
   public int Price;
   public int Loaves;

   public int Buying (int loaves)
   {
       if (loaves >= 3)
       {
           return (loaves / 3) * 5 + (loaves % 3) * Price;
       }
       else
       {
           return loaves * Price;
       }
   }

   public bool outofStock (int loaves)
   {
       return (loaves > Loaves);
   }

}