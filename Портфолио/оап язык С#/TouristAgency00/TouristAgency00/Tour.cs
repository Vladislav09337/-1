using System;
using System.Collections.Generic;

namespace TouristAgency00
{
    public class Tour
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Days { get; set; }
        public int AvailableSeats { get; set; }
        public bool IsChildFriendly { get; set; }
        public int Stars { get; set; }
        public string MealType { get; set; }
        public List<string> Services { get; set; }
        public decimal Price { get; set; }
        public string TourType { get; set; }

        public string DatesString => $"{StartDate:dd.MM.yyyy} - {EndDate:dd.MM.yyyy}";
        public string PriceString => $"{Price:N0} ₽";
    }
}