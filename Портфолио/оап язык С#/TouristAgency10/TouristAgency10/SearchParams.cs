using System;

namespace TouristAgency00
{
    internal class SearchParams
    {
        internal DateTime StartDate;
        internal DateTime EndDate;
        internal int Duration;
        internal int TravelersCount;
        internal bool HasChildren;
        internal object HotelFilters;
    }
}