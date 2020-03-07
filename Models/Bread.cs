namespace Bakeryshop.Models
{
  public class Bread
  {

     public string Name {get; set;}
     public int Price {get; set;}
     public int Loaves {get; set;}

     public Bread(string name, int price, int loaves)
     {
       Name = name;
       Price = price;
       Loaves = loaves;
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
