namespace Bakeryshop.Models
{
  public class Pastry {

     public string Name {get; set;}
     public int Price {get; set;}
     public int Loaves {get; set;}

     public Pastry(string name, int price, int loaves)
     {
       Name = name;
       Price = price;
       Loaves = loaves;
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
