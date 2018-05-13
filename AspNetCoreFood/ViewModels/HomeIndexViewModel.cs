using System.Collections.Generic;
using AspNetCoreFood.Models;

namespace AspNetCoreFood.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
    }
}
