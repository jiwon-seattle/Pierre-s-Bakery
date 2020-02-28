using System;
using System.Collections.Generic;

public class Bakery {

    public string Bread;
    public string Pastry;

    static void Main()
    {
        Console.WriteLine("Welcome to Pierre's Bakery");
        Console.WriteLine("Would you like to get some fresh bakeries? Please answer with this format, Y for Yes & N for N");

        string userVisitAnswer = Console.ReadLine().ToLower();

        if (userVisitAnswer == "y")
        {
            
            BreadBrowsing();
            PastryBrowsing();
        }
        else
        {
            Console.WriteLine("Thank you for visiting Pierre's Bakery. We are looking forward to seeing you next time!");
        }
        
        


    }

    static void BreadBrowsing()
    {
        Bread bagel = new Bread();
        bagel.Name ="Bagel";
        bagel.Price = 5;
        bagel.Loaves = 10;

        List<Bread> Breads = new List<Bread>() {bagel};

        // foreach(Bread bread in Breads)
        //     {
        Console.Write("We have " + Breads[0].Name + " in the bread section." + " The price is $" + Breads[0].Price + ".");
        Console.Write(" Would you buy some " + Breads[0].Name + "?" + " Please enter a number that you want to get.");
        int userBreadNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("The cost is " + Breads[0].Buying(userBreadNumber) + ".");
            // }
    }

    static void PastryBrowsing()
    {
        Pastry maccaron = new Pastry();
        maccaron.Name = "Maccaron";
        maccaron.Price = 5;
        maccaron.Loaves = 10;

        List<Pastry> Pastries = new List<Pastry> () {maccaron};

        Console.Write("We have " + Pastries[0].Name + " in the pastry section. " + "The price is $" + Pastries[0].Price + ".");
        Console.Write(" Would you buy some " + Pastries[0].Name + "?" + " Please enter a number that you want to get");
        int userPastryNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("The cost is " + Pastries[0].Buying(userPastryNumber) + ".");

    }


    static void BakeryShopping()
    {
       
        
     
    }
}
public class Bread 
{

   public string Name;
   public int Price;
   public int Loaves;

   public int Buying (int loaves) 
   {
       
       return Price * loaves;
   }
        
}

public class Pastry {

   public string Name;
   public int Price;
   public int Loaves;

   public int Buying (int loaves)
   {
       return Price * loaves;
   }

}