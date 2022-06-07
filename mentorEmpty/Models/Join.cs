namespace mentorEmpty.Models
{
    public class Join
    {
        public int Id { get; set; }
        public int PricingId { get; set; }
        public Pricings Pricing { get; set; }

        public int FeaturesId { get; set; }
        public Features Features { get; set; }
    }
}
