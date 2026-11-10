using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TouristAgency
{
    internal static class Program
    {
        public static UserPreferences GlobalPreferences = new UserPreferences();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStep1());
        }
    }

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

    public class Tour
    {
        public int Id;
        public string Country;
        public string City;
        public string HotelName;
        public string Address;
        public DateTime StartDate;
        public DateTime EndDate;
        public int BasePrice;
        public int Stars;
        public string MealType;
        public List<string> Services = new List<string>();
        public List<string> TourTypes = new List<string>();
        public bool IsChildrenTour;
        public int TotalCount;
        public int SoldCount;
        public int AvailableCount => TotalCount - SoldCount;
        public int Duration => (EndDate - StartDate).Days + 1;
    }
}