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
                new Car{Id=1,Name="Bmw"},
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
            return View();
        }
    }
}
