using System;
using System.Collections.Generic;

namespace TouristAgency
{
    public class UserPreferences
    {
        public DateTime PeriodStart = DateTime.Now;
        public DateTime PeriodEnd = DateTime.Now.AddDays(7);
        public int Days = 7;
        public int PeopleCount = 2;
        public bool HasChildren = false;
        public bool Step1Skipped = false;
        public List<string> PrioritizedTourTypes = new List<string>();
        public bool Step2Skipped = false;
        public int HotelStars = 0;
        public string MealType = "";
        public List<string> SelectedServices = new List<string>();
        public int MinPrice = 0;
        public int MaxPrice = 500000;
        public bool Step3Skipped = false;
    }
}