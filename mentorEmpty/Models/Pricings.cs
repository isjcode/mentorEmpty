using System.Collections.Generic;

namespace mentorEmpty.Models
{
    public class Pricings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsFeatured { get; set; }
        public bool isAdvanced { get; set; }
        public List<Join> Join { get; set; }

    }
}
