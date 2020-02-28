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
        bagel.Loaves = 100;
        Breads.Add(bagel);
        
        Bread ryeBread = new Bread();
        ryeBread.Name = "Rye bread";
        ryeBread.Price = 7;
        ryeBread.Loaves = 100;
        Breads.Add(ryeBread);

        Pastry maccaron = new Pastry();
        maccaron.Name = "Maccaron";
        maccaron.Price = 2;
        maccaron.Loaves = 100;
        Pastries.Add(maccaron);

        Pastry danish = new Pastry();
        danish.Name = "Danish";
        danish.Price = 3;
        danish.Loaves = 100;
        Pastries.Add(danish);
        
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
        Console.Write("We have " + Breads[0].Name + " and " + Breads[1].Name + " in the bread section." + " The price is $" + Breads[0].Price + ", $" + Breads[1].Price + " per each.");
    }

    static void PastryBrowsing()
    {
        Console.WriteLine(" For the pastry section, We also have " + Pastries[0].Name + " with the price for each $" + Pastries[0].Price + ".");
    }

    static int BreadPrice()
    {
        Console.Write("Would you liek to buy some breads? Enter a number that you want to get.");
        int userBreadNumber = int.Parse(Console.ReadLine());
        return userBreadNumber;
    }
    static void BreadShopping()
    {   
        Dictionary<string, int> Breadstype = new Dictionary<string, int> {};
        Breadstype.Add(Breads[0].Name, Breads[0].Price);

        
        int userBreadNumber = BreadPrice();

        if(Breads[0].outOfStock(userBreadNumber))
        {
            int stocks = Math.Abs(userBreadNumber - Breads[0].Loaves);
            Console.WriteLine("Sorry, some breads are out of stock for youe order. " + stocks + " bread/s are not available.");
            Console.WriteLine("Available " + Breads[0].Loaves + "'s cost is " + Breads[0].Buying(Breads[0].Loaves));
        }
        else
        {
        Console.WriteLine("The cost is " + Breads[0].Buying(userBreadNumber) + ".");
        }
    }

    static int PastryPrice()
    {
        Console.Write("Would you like to buy some pastries? Enter a number that you want to get.");
        int userPastryNumber = int.Parse(Console.ReadLine());
        return userPastryNumber;
    }
    static void PastryShopping()
    {
        int userPastryNumber = PastryPrice();

        if(Pastries[0].outofStock(userPastryNumber))
        {
            int stocks = Math.Abs(userPastryNumber - Pastries[0].Loaves);
            Console.WriteLine("Sorry, some pastries are out of stock for your order. " + stocks + " pastry/ies are not available.");
            Console.WriteLine("Available " + Pastries[0].Loaves + "'s cost is " + Pastries[0].Buying(Pastries[0].Loaves));
        }
        else
        {
        Console.WriteLine("The cost is " + Pastries[0].Buying(userPastryNumber) + ".");
        }
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