using System;

namespace Bakeryshop.Breads
{
  public class Bread
  {

     private string Name;
     private int Price;
     private int Loaves;

     public Bread(string name, int price, int loaves)
     {
       Name = name;
       Price = price;
       Loaves = loaves;
     }

     public string GetBreadName()
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

     public void SetPrice(int newPrice)
     {
       Price = newPrice;
     }

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
}
