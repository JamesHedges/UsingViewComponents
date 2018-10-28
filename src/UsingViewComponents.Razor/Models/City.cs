using System.Collections.Generic;

namespace UsingViewComponents.Models
{
    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
    }

    public interface ICityRepository
    {
        IEnumerable<City> Cities { get; }
        void AddCity(City newCity);
    }
}
