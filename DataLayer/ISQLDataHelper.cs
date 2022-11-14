using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.DataLayer
{
    public interface ISQLDataHelper
    {
        public List<Country> GetCountriesData();
        public List<SpecialDay> GetSpecialDaysData();
    }
}
