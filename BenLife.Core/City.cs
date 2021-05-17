using System;
using System.Collections.Generic;
using BenLife.Core.Places;

namespace BenLife.Core
{
    public class City
    {
        private readonly List<IPlace> _places;
        private readonly Random _random;

        public City(List<IPlace> places)
        {
            _places = places;
            _random = new Random();
        }

        public IPlace GetRandomPlace() => _places[_random.Next(0, _places.Count)];
    }
}