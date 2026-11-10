using System;
using System.Collections.Generic;

namespace TouristAgency00.Models
{
    public class SearchParams
    {
        public HotelFilters HotelFilters { get; set; }
        public List<string> RankedPreferences { get; set; }

        // Основные параметры поиска
        public string Destination { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }
        public int TravelersCount { get; set; }
        public bool HasChildren { get; set; }

        // Дополнительные параметры
        public int Adults { get; set; }
        public int Children { get; set; }

        public SearchParams()
        {
            HotelFilters = new HotelFilters();
            RankedPreferences = new List<string>();
            StartDate = DateTime.Now;
            EndDate = DateTime.Now.AddDays(7);
            Duration = 7;
            TravelersCount = 2;
            Adults = 2;
            Children = 0;
            HasChildren = false;
            Destination = "";
        }
    }
}