using System;
using System.Collections.Generic;

namespace CarLot.Objects
{
  public class Car
  {
// Set strings
    private string _makeModel;
    private string _price;
    private string _miles;
    private static List<Car> _instances = new List<Car> {};
// Constructor
    public Car (string makemodel, string price, string mileage)
    {
      _makeModel = makemodel;
      _price = price;
      _miles = mileage;
    }
// Getters and Setters
    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }

    public string GetPrice()
    {
      return _price;
    }
    public void SetPrice(string newPrice)
    {
      _price = newPrice;
    }

    public string GetMiles()
    {
      return _miles;
    }
    public void SetMiles(string newMiles)
    {
      _miles = newMiles;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(this);
    }
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
