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
      Get["/car_added"] = _ => {
        Car newCar = new Car(Request.Query["new-make-model"]);
        return View["car_added.cshtml", newCar];
      };
    }
  }
}
