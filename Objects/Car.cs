using System;
using System.Collections.Generic;

namespace CarLot.Objects
{
  public class Car
  {
// Set strings
    private string _makeModel;
    // private int _price;
    // private int _miles;
// Constructor
    public Car (string makemodel)
    {
      _makeModel = makemodel;
    }
    // {
    //   SetMakeModel(vehicle);
    //   SetPrice(cost);
    //   SetMiles(mileage);
    // }
// Getters and Setters
    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    //
    // public int GetPrice()
    // {
    //   return _price;
    // }
    // public void SetPrice(int newPrice)
    // {
    //   _price = newPrice;
    // }
    //
    // public int GetMiles()
    // {
    //   return _miles;
    // }
    // public void SetMiles(int newMiles)
    // {
    //   _miles = newMiles;
    // }
// brackets added when text below was commented out
  }
}





//     public bool WorthBuying(int maxPrice, int maxMiles)
//     {
//       return (GetPrice() < (maxPrice + 100) && GetMiles() < maxMiles);
//     }
//   }
//
//   public class Program
//   {
//     public static void Main()
//     {
//       Car porsche = new Car("2014 Porsche 911", 114991, 7864, "Excellent");
//
//       Car ford = new Car("2011 Ford F450", 55995, 14241, "Meh");
//
//       Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "Radical");
//
//       Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "The WORST!");
//
//       List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
//
//       Console.WriteLine("Enter maximum price: ");
//       string stringMaxPrice = Console.ReadLine();
//       int maxPrice = int.Parse(stringMaxPrice);
//
//       Console.WriteLine("Enter maximum miles: ");
//       string stringMaxMiles = Console.ReadLine();
//       int maxMiles = int.Parse(stringMaxMiles);
//
//       List<Car> CarsMatchingSearch = new List<Car>(0);
//
//       foreach (Car automobile in Cars)
//       {
//         if (automobile.GetPrice() < maxPrice && automobile.GetMiles() < maxMiles)
//         {
//           CarsMatchingSearch.Add(automobile);
//         }
//       }
//
//       foreach(Car automobile in CarsMatchingSearch)
//       {
//         Console.WriteLine(automobile.GetMakeModel());
//       }
//     }
//   }
// }
