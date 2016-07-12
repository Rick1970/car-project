using Nancy;
using CarLot.Objects;
using System.Collections.Generic;

namespace CarLot
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_car.cshtml"];
      Post["/car_added"] = _ => {
        Car newCar = new Car(Request.Form["make-model"], Request.Form["price"], Request.Form["mileage"]);
        newCar.Save();
        return View["car_added.cshtml", newCar];
      };
      Get["/inventory"] = _ => {
        List<Car> allCars = Car.GetAll();
        return View["inventory.cshtml", allCars];
      };
    }
  }
}
