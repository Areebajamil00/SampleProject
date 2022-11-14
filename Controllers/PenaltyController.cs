using Microsoft.AspNetCore.Mvc;
using SampleProject.BusinessLayer;
using SampleProject.DataLayer;
using SampleProject.Models;
using System;
using System.Collections.Generic;

namespace SampleProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PenaltyController : Controller
    {
        IPenaltyCalculator _penaltyCalculator;
        public PenaltyController(IPenaltyCalculator penaltyCalculator)
        {
            _penaltyCalculator = penaltyCalculator;
        }
        [HttpGet("getcountries")]
        public IEnumerable<Country> GetCountriesData()
        {
            return _penaltyCalculator.GetCountriesData();
        }
        [HttpGet("getspecialdays")]
        public IEnumerable<SpecialDay> GetSpecialDaysData()
        {
            return _penaltyCalculator.GetSpecialDaysData();
        }
        [HttpPost("calculateamount")]
        public string CalculateAmount(CheckInInput checkInInput)
        {
            return _penaltyCalculator.CalculateAmount(checkInInput);
        }
    }
}
