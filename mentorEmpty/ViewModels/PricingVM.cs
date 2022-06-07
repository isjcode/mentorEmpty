using mentorEmpty.Models;
using System.Collections.Generic;

namespace mentorEmpty.ViewModels
{
    public class PricingVM
    {
        public List<Pricings> Pricing { get; set; }
        public List<Features> Features { get; set; }
    }
}