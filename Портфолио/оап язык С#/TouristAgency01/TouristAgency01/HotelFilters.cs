using System.Collections.Generic;

namespace TouristAgency00.Models
{
    public class HotelFilters
    {
        public int? Stars { get; set; }
        public string MealType { get; set; }
        public List<string> ExtraServices { get; set; }
        public decimal PriceMin { get; set; }
        public decimal PriceMax { get; set; }

        public HotelFilters()
        {
            ExtraServices = new List<string>();
            PriceMin = 3000;
            PriceMax = 15000;
        }
    }
}