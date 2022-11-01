using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Task.Models;
using Task.ViewModels.Home;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Car> _cars;
        public HomeController()
        {
            _cars= new List<Car>
            {
                new Car{Id=1,
                    Name="Bmw",
                    CarModels=new List<CarModel>
                    {
                        new CarModel
                        {
                            Name="E23",
                            Date=1978,
                            Price=30000
                            
                        },
                        new CarModel
                        {
                            Name="E24",
                            Date=1985,
                            Price=36000

                        },
                        new CarModel
                        {
                            Name="E34",
                            Date=1994,
                            Price=6000

                        },
                        new CarModel
                        {
                            Name="E39",
                            Date=1999,
                            Price=12000

                        },
                    }
                },
                new Car{Id=2,Name="Mercedes"},
                new Car{Id=3,Name="Lada"},
            };
        }
        public IActionResult Index()
        {
            Car car = new Car
            {
                Name = "Bmw",
                

            };
            CarModel carModel = new CarModel
            {
                Name = "Bmw",
                Date = 2010,
                Price = 30000

            };

            HomeVm homeVm = new HomeVm
            {
                Cars=_cars,
                CarModel = carModel

            };
            
            return View(homeVm);
        }


        public IActionResult Details(int? id)
        {
            Car car = _cars.Find(c => c.Id == id);
            return View();
        }
    }
}
