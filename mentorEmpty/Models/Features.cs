using System.Collections.Generic;

namespace mentorEmpty.Models
{
    public class Features
    {
        public int Id { get; set; }
        public string Feature { get; set; }

        public List<Join> Join { get; set; }
    }
}
