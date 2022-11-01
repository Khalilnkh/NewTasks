using System.Collections.Generic;
using Task.Models;

namespace Task.ViewModels.Home
{
    public class HomeVm
    {
        
        public CarModel CarModel { get; set; }
        public List<Car> Cars { get; set; }
    }
}
