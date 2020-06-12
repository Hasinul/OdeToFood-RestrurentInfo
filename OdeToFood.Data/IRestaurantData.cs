using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant> 
            {
                new Restaurant { Id=1, Name="Italian Masala", Location="Gulshan", CusisineType=CusisineType.Italian},
                new Restaurant { Id=2, Name="Indian Dhosa", Location="Panthapath", CusisineType=CusisineType.Indian},
                new Restaurant { Id=3, Name="Mexican Food", Location="Motijheel", CusisineType=CusisineType.Mexican},
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }

    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
