using System.ComponentModel.DataAnnotations;
using AspNetCoreFood.Models;

namespace AspNetCoreFood.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
