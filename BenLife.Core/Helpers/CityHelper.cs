using System.Collections.Generic;
using BenLife.Core.Places;

namespace BenLife.Core.Helpers
{
    public static class CityHelper
    {
        public static List<IPlace> GeneratePlaces()
        {
            var places = new List<IPlace>
            {
                new Home() { Name = "Home" }, 
                new Job() { Name = "Job" }, 
                new Shop() { Name = "Shop" }, 
                new University() { Name = "University" }
            };

            return places;
        }
    }
}