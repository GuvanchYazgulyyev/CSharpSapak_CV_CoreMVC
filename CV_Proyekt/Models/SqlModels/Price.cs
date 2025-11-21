namespace CV_Proyekt.Models.SqlModels
{
    public class Price
    {
        public long Id { get; set; }
        public string IconUrl { get; set; }

        public string TypeOfService { get; set; }

        public string Description { get; set; }

        public decimal PricePeriod { get; set; }

        public string HireMe { get; set; }
    }
}
