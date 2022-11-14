namespace SampleProject.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CurrencyCode { get; set; }
        public decimal PenaltyAmount { get; set; }
        public string OffDay1 { get; set; }
        public string OffDay2 { get; set; }
    }
}