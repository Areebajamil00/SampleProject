using System;
using System.ComponentModel.DataAnnotations;

namespace SampleProject.Models
{
    public class CheckInInput
    {
        public CheckInInput()
        {
            BookCheckIn = DateTime.Now;
            BookReceived = DateTime.Now;
        }
        public DateTime BookCheckIn { get; set; }
        public DateTime BookReceived { get; set; }
        public int CountryId { get; set; }
    }
}