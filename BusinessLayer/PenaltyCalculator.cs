using SampleProject.DataLayer;
using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.BusinessLayer
{
    public class PenaltyCalculator : IPenaltyCalculator
    {
        ISQLDataHelper _sqlDataHelper;
        public PenaltyCalculator(ISQLDataHelper sqlDataHelper)
        {
            this._sqlDataHelper = sqlDataHelper;
        }
        public List<Country> GetCountriesData()
        {
            return this._sqlDataHelper.GetCountriesData();
        }
        public List<SpecialDay> GetSpecialDaysData()
        {
            return this._sqlDataHelper.GetSpecialDaysData();
        }
        public string CalculateAmount(CheckInInput model)
        {
            var country = GetCountriesData().FirstOrDefault(p => p.Id == model.CountryId);
            List<SpecialDay> specialDays = GetSpecialDaysData().Where(p => p.CountryId == model.CountryId).ToList();
            int penaltyAmount = CalculateAmount(model.BookCheckIn, model.BookReceived, specialDays, country.OffDay1, country.OffDay2);
            return "Penalty Amount =" + penaltyAmount + country.CurrencyCode;
        }
        public int CalculateAmount(DateTime BookCheckIn, DateTime BookReceived, List<SpecialDay> specialDays, string offDay1, string offDay2)
        {
            int amount = 0;
            //calculations here
            return amount;
        }
    }
}
