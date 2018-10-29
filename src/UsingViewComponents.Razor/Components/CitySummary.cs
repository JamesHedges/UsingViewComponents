using System.Linq;
using UsingViewComponents.Models;
using Microsoft.AspNetCore.Mvc;

namespace UsingViewComponents.Components
{
    public class CitySummary : ViewComponent
    {
        private readonly ICityRepository _cityRepository;

        public CitySummary(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public string Invoke()
        {
            return $"{_cityRepository.Cities.Count()} cities, {_cityRepository.Cities.Sum(c => c.Population)} people";
        }

    }
}
