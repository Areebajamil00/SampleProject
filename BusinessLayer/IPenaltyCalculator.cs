using SampleProject.Models;
using System;
using System.Collections.Generic;

namespace SampleProject.BusinessLayer
{
    public interface IPenaltyCalculator
    {
        public List<Country> GetCountriesData();
        public List<SpecialDay> GetSpecialDaysData();
        public string CalculateAmount(CheckInInput model);
        public int CalculateAmount(DateTime BookCheckIn, DateTime BookReceived, List<SpecialDay> specialDays, string offDay1, string offDay2);
    }
}
