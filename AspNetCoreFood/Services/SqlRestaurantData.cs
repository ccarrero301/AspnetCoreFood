using System.Collections.Generic;
using System.Linq;
using AspNetCoreFood.Data;
using AspNetCoreFood.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreFood.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly AspNetCoreFoodDbContext _context;

        public SqlRestaurantData(AspNetCoreFoodDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();

            return restaurant;
        }

        public Restaurant Update(Restaurant restaurant)
        {
            _context.Attach(restaurant).State = EntityState.Modified;
            _context.SaveChanges();

            return restaurant;
        }
    }
}
