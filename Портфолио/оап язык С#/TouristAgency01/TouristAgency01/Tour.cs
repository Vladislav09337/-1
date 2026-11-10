using System;
using System.Collections.Generic;

namespace TouristAgency00.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public int Stars { get; set; }
        public string MealType { get; set; }
        public List<string> ExtraServices { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DurationDays { get; set; }
        public int AvailableCount { get; set; }
        public decimal BasePrice { get; set; }
        public List<string> TourTypes { get; set; }
        public bool IsChildTour { get; set; }

        public Tour()
        {
            ExtraServices = new List<string>();
            TourTypes = new List<string>();
        }
    }
}