using System;

namespace Bakeryshop.Pastries
{
  public class Pastry {

     private string Name;
     private int Price;
     private int Loaves;

     public Pastry(string name, int price, int loaves)
     {
       Name = name;
       Price = price;
       Loaves = loaves;
     }

     public string GetPastryName()
     {
       return Name;
     }

     public int GetPrice()
     {
       return Price;
     }

     public int GetLoaves()
     {
       return Loaves;
     }

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
}
